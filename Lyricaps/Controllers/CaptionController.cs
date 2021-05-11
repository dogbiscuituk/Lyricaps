namespace Lyricaps.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Lyricaps.Types;

    internal class CaptionController : Controller
    {
        #region Constructor

        internal CaptionController(Controller parent) : base(parent) { }

        #endregion

        #region Fields

        internal readonly List<string> Captions = new List<string>();

        private readonly List<string> Lines = new List<string>();

        #endregion

        #region Methods

        internal void GetCaptions(CaptionFormats captionFormat, int min, int sec, int ms) =>
            GetCaptions(captionFormat, new TimeSpan(0, 0, min, sec, ms));

        private void GetCaptions(CaptionFormats captionFormat, TimeSpan timeSpan)
        {
            var itemIndex = 0;
            string
                startString,
                endString = "00:00:00,000",
                text,
                previousText = string.Empty;

            string[] CreateNewItem()
            {
                switch (captionFormat)
                {
                    case CaptionFormats.SubRip:
                        return new[]
                        {
                                $"{++itemIndex}",
                                $"{startString} --> {endString}",
                                string.IsNullOrWhiteSpace(text) ? string.Empty : $" {text.Trim()} ",
                                string.Empty
                        };
                    case CaptionFormats.SubViewer:
                        return new[]
                        {
                                $"{startString},{endString}",
                                string.IsNullOrWhiteSpace(text) ? string.Empty : $" {text.Trim()} ",
                                string.Empty
                        };
                }
                return new string[0];
            }

            (int, int) GetEndPosition()
            {
                switch (captionFormat)
                {
                    case CaptionFormats.SubRip:
                        return (4 * itemIndex - 3, 17);
                    case CaptionFormats.SubViewer:
                        return (3 * itemIndex - 2, 12);
                }
                return (0, 0);
            }

            string GetTimeFormat()
            {
                switch (captionFormat)
                {
                    case CaptionFormats.SubRip:
                        return @"hh\:mm\:ss\,fff"; // ms separator is comma
                    case CaptionFormats.SubViewer:
                        return @"hh\:mm\:ss\.fff"; // ms separator is period
                }
                return string.Empty;
            }

            Lines.Clear();
            Lines.AddRange(((FileController)Parent).LyricsTextBox.Lines);
            Captions.Clear();
            var lineEnd = 0.0;
            TimeSpan
                startTime,
                endTime = TimeSpan.Zero;
            var totalTime = timeSpan.TotalMilliseconds;
            var linesEnd = Lines.Sum(line => ParseLine(line).Item2);
            var timeFormat = GetTimeFormat();
            foreach (var line in Lines)
            {
                text = line;
                var lineDelta = ParseLine(ref text);
                if (lineDelta == 0) // Ignore lines starting with a hyphen.
                    continue;
                lineEnd += lineDelta;
                startTime = endTime;
                endTime = TimeSpan.FromMilliseconds(totalTime * lineEnd / linesEnd);
                startString = endString;
                endString = endTime.ToString(timeFormat);
                if (text != "\"" && text != previousText || itemIndex == 0) // Add the new text.
                {
                    Captions.AddRange(CreateNewItem());
                    previousText = text;
                }
                else // The previous lyric is repeated, so just extend its display time.
                {
                    var p = GetEndPosition();
                    Captions[p.Item1] = $"{Captions[p.Item1].Substring(0, p.Item2)}{endString}";
                }
            }
        }

        #endregion

        #region Static Methods

        private static (int, double) ParseLine(string line) =>
            line.StartsWith("-") ? /* leading hyphen = comment, no lyric displayed */ (1, 0) :
            line.StartsWith("..") ? /* leading double period = ¾ line */ (2, 0.75) :
            line.StartsWith(".") ? /* leading single period = ½ line */ (1, 0.5) :
            line.StartsWith(":") ? /* leading colon = ¼ line */ (1, 0.25) :
            line.StartsWith(";") ? /* leading semicolon = ⅛ line */ (1, 0.125) :
            line.EndsWith("..") ? /* trailing double period = 1¾ line */ (-2, 1.75) :
            line.EndsWith(".") ? /* trailing single period = 1½ line */ (-1, 1.5) :
            line.EndsWith(":") ? /* trailing colon = 1¼ line */ (-1, 1.25) :
            line.EndsWith(";") ? /* trailing semicolon = 1⅛ line */ (-1, 1.125) :
            (0, 1.0);

        private static double ParseLine(ref string line)
        {
            var info = ParseLine(line);
            var index = info.Item1;
            if (index > 0)
                line = line.Substring(index);
            else if (index < 0)
                line = line.Substring(0, index + line.Length);
            return info.Item2;
        }

        #endregion
    }
}
