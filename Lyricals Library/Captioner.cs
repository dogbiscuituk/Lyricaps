using System;
using System.Collections.Generic;
using System.Linq;

namespace LyricapsLibrary
{
    public class Captioner
    {
        public static IEnumerable<string> Caption(IEnumerable<string> lines, int minutes, int seconds) =>
            Caption(lines, new TimeSpan(hours: 0, minutes: minutes, seconds: seconds));

        public static IEnumerable<string> Caption(IEnumerable<string> lines, TimeSpan time)
        {
            var output = new List<string>();
            int
                lineCount = lines.Count(),
                lineNumber = 1;
            string
                text = string.Empty,
                start,
                stop = "00:00:00,000";
            var totalTime = time.TotalMilliseconds;
            foreach (var line in lines)
            {
                start = stop;
                stop = TimeSpan.FromMilliseconds(totalTime * lineNumber / lineCount).ToString(@"hh\:mm\:ss\,fff");
                output.Add($"{lineNumber}");
                output.Add($"{start} --> {stop}");
                if (!string.IsNullOrWhiteSpace(line))
                    text = line;
                output.Add(text);
                output.Add(string.Empty);
                lineNumber++;
            }
            return output;
        }
    }
}
