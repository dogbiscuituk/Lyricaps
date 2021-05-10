namespace Lyricaps.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

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

        internal void GetCaptions(int min, int sec, int ms) => GetCaptions(new TimeSpan(0, 0, min, sec, ms));

        private void GetCaptions(TimeSpan timeSpan)
        {
            Lines.Clear();
            Lines.AddRange(((FileController)Parent).LyricsTextBox.Lines);
            Captions.Clear();
            var itemIndex = 0;
            var lineEnd = 0.0;
            string
                startString,
                endString = "00:00:00,000",
                previousText = string.Empty;
            TimeSpan
                startTime,
                endTime = TimeSpan.Zero;
            var totalTime = timeSpan.TotalMilliseconds;
            var linesEnd = Lines.Sum(line => ParseLine(line).Item2);
            foreach (var line in Lines)
            {
                var text = line;
                var lineDelta = ParseLine(ref text);
                if (lineDelta == 0) // Ignore lines starting with a hyphen.
                    continue;
                lineEnd += lineDelta;
                startTime = endTime;
                endTime = TimeSpan.FromMilliseconds(totalTime * lineEnd / linesEnd);
                startString = endString;
                endString = endTime.ToString(@"hh\:mm\:ss\,fff");
                if (text != "\"" && text != previousText || itemIndex == 0) // Add the new text.
                {
                    Captions.AddRange(new[]
                    {
                        $"{++itemIndex}",
                        $"{startString} --> {endString}",
                        string.IsNullOrWhiteSpace(text) ? string.Empty : $" {text.Trim()} ",
                        string.Empty
                    });
                    previousText = text;
                }
                else // The previous lyric is repeated, so just extend its display time.
                {
                    var captionIndex = 4 * itemIndex - 3;
                    Captions[captionIndex] = $"{Captions[captionIndex].Substring(0, 17)}{endString}";
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
