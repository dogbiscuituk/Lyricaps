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

        internal List<string> Captions = new List<string>();

        private List<string> Lines = new List<string>();

        #endregion

        #region Methods

        internal void GetCaptions(int m, int s, int ms) => GetCaptions(new TimeSpan(0, 0, m, s, ms));

        private void GetCaptions(TimeSpan timeSpan)
        {
            Lines.Clear();
            Lines.AddRange(((FileController)Parent).LyricsTextBox.Lines);
            Captions.Clear();
            var itemIndex = 0;
            var lineEnd = 0.0;
            string
                startTime,
                endTime = "00:00:00,000",
                previousText = string.Empty;
            var totalTime = timeSpan.TotalMilliseconds;
            var linesEnd = Lines.Sum(line => ParseLine(line).Item2);
            foreach (var line in Lines)
            {
                var text = line;
                lineEnd += ParseLine(ref text);
                startTime = endTime;
                endTime = TimeSpan.FromMilliseconds(totalTime * lineEnd / linesEnd).ToString(@"hh\:mm\:ss\,fff");
                if (!string.IsNullOrWhiteSpace(text) && text != previousText) // Add the new text.
                {
                    if (text == @"\")
                        text = string.Empty;
                    else
                        text = $" {text.Trim()} ";
                    Captions.AddRange(new[]
                    {
                        $"{++itemIndex}",
                        $"{startTime} --> {endTime}",
                        text,
                        string.Empty
                    });
                    previousText = text;
                }
                else if (itemIndex > 0) // The previous lyric is repeated, so just extend its display time.
                {
                    var captionIndex = 4 * itemIndex - 3;
                    Captions[captionIndex] = $"{Captions[captionIndex].Substring(0, 17)}{endTime}";
                }
            }
        }

        #endregion

        #region Static Methods

        private static (int, double) ParseLine(string line) =>
            line.StartsWith("..") ? (2, 0.75) :
            line.StartsWith(".") ? (1, 0.5) :
            line.StartsWith(":") ? (1, 0.25) :
            line.EndsWith("..") ? (-2, 1.75) :
            line.EndsWith(".") ? (-1, 1.5) :
            line.EndsWith(":") ? (-1, 1.25) : (0, 1.0);

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
