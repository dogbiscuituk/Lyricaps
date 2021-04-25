namespace Lyricaps
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        #region Constructor

        public MainForm() => InitializeComponent();

        #endregion

        #region Fields

        private string FileName;
        private bool LyricsEdited, CaptionsUpdated;

        #endregion

        #region Menu Event Handlers

        private void PopupCaptionsSave_Click(object sender, EventArgs e) => SaveCaptions();

        private void PopupLyricsOpen_Click(object sender, EventArgs e) => LoadLyrics();

        private void PopupLyricsSave_Click(object sender, EventArgs e) => SaveLyrics();

        private void PopupToggleSplit_Click(object sender, EventArgs e) => ToggleSplit();

        #endregion

        #region Control Event Handlers

        private void btnSelectVideoFile_Click(object sender, EventArgs e) => LoadDuration();

        private void edCaptions_TextChanged(object sender, EventArgs e) => CaptionsChanged();

        private void edLyrics_TextChanged(object sender, EventArgs e) => LyricsChanged();

        private void edVideoLength_ValueChanged(object sender, EventArgs e) => Recalculate();

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = CancelClose(e.CloseReason);

        #endregion

        #region Private Methods

        private bool CancelClose(CloseReason closeReason)
        {
            if (closeReason != CloseReason.UserClosing)
                return false;
            if (LyricsEdited)
                switch (MessageBox.Show(
                    this,
                    "The lyrics have been edited. Save changes?",
                    "Confirmation",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                        SaveLyrics();
                        break;
                    case DialogResult.Cancel:
                        return true;
                }
            if (CaptionsUpdated)
                switch (MessageBox.Show(
                    this,
                    "The captions have been updated. Save changes?",
                    "Confirmation",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                        SaveCaptions();
                        break;
                    case DialogResult.Cancel:
                        return true;
                }
            return false;
        }

        private void CaptionsChanged() => CaptionsUpdated = true;

        private void LoadDuration()
        {
            if (VideoOpenDialog.ShowDialog(this) != DialogResult.OK)
                return;
            FileName = VideoOpenDialog.FileName;
            var file = TagLib.File.Create(FileName);
            var duration = file.Properties.Duration;
            edHours.Value = duration.Hours;
            edMinutes.Value = duration.Minutes;
            edSeconds.Value = duration.Seconds;
            edMilliseconds.Value = duration.Milliseconds;
            UpdateFileName();
        }

        private void LoadLyrics()
        {
            if (LyricsOpenDialog.ShowDialog(this) != DialogResult.OK)
                return;
            FileName = LyricsOpenDialog.FileName;
            using (var reader = new StreamReader(FileName))
                LyricsTextBox.Text = reader.ReadToEnd();
            LyricsSaveDialog.FileName = FileName;
            LyricsEdited = false;
            UpdateFileName();
        }

        private void LyricsChanged()
        {
            LyricsEdited = true;
            Recalculate();
        }

        private void Recalculate() => CaptionsTextBox.Lines = CreateCaptions(
            LyricsTextBox.Lines,
            (int)edHours.Value,
            (int)edMinutes.Value,
            (int)edSeconds.Value,
            (int)edMilliseconds.Value)
            .ToArray();

        private void SaveCaptions()
        {
            if (CaptionsSaveDialog.ShowDialog(this) != DialogResult.OK)
                return;
            FileName = CaptionsSaveDialog.FileName;
            using (var writer = new StreamWriter(FileName))
            {
                writer.Write(CaptionsTextBox.Text);
                writer.Flush();
                writer.Close();
            }
            CaptionsUpdated = false;
            UpdateFileName();
        }

        private void SaveLyrics()
        {
            if (LyricsSaveDialog.ShowDialog(this) != DialogResult.OK)
                return;
            FileName = LyricsSaveDialog.FileName;
            using (var writer = new StreamWriter(FileName))
            {
                writer.Write(LyricsTextBox.Text);
                writer.Flush();
                writer.Close();
            }
            LyricsOpenDialog.FileName = FileName;
            LyricsEdited = false;
            UpdateFileName();
        }

        private void ToggleSplit() => SplitContainer.Orientation =
            SplitContainer.Orientation == Orientation.Horizontal
            ? Orientation.Vertical
            : Orientation.Horizontal;

        private void UpdateFileName() => Text = $"{Path.GetFileNameWithoutExtension(FileName)} - Lyric Captions";

        #endregion

        #region Static Methods

        private static IEnumerable<string> CreateCaptions(IEnumerable<string> lyrics, int hours, int minutes, int seconds, int milliseconds) =>
            CreateCaptions(lyrics, new TimeSpan(days: 0, hours: hours, minutes: minutes, seconds: seconds, milliseconds: milliseconds));

        private static IEnumerable<string> CreateCaptions(IEnumerable<string> lyrics, TimeSpan timeSpan)
        {
            var output = new List<string>();
            int
                lineCount = lyrics.Count(),
                lineNumber = 1;
            string
                text = string.Empty,
                start,
                stop = "00:00:00,000";
            var totalTime = timeSpan.TotalMilliseconds;
            foreach (var line in lyrics)
            {
                if (!string.IsNullOrWhiteSpace(line))
                    text = line;
                start = stop;
                stop = TimeSpan.FromMilliseconds(totalTime * lineNumber / lineCount).ToString(@"hh\:mm\:ss\,fff");
                output.Add($"{lineNumber}");
                output.Add($"{start} --> {stop}");
                output.Add(text);
                output.Add(string.Empty);
                lineNumber++;
            }
            return output;
        }

        #endregion
    }
}
