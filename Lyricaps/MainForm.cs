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

        private List<string> Lyrics = new List<string>();

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

        private void Recalculate() => CaptionsTextBox.Lines = GetCaptions(
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

        private IList<string> GetCaptions(int m, int s, int ms) => GetCaptions(new TimeSpan(0, 0, m, s, ms));

        private IList<string> GetCaptions(TimeSpan timeSpan)
        {
            Lyrics.Clear();
            Lyrics.AddRange(LyricsTextBox.Lines);
            var captions = new List<string>();
            int
                lyricIndex = 0,
                itemIndex = 0;
            string
                startTime,
                stopTime = "00:00:00,000",
                previousLyric = string.Empty;
            var totalTime = timeSpan.TotalMilliseconds;
            foreach (var lyric in Lyrics)
            {
                lyricIndex++;
                startTime = stopTime;
                stopTime = TimeSpan.FromMilliseconds(totalTime * lyricIndex / Lyrics.Count).ToString(@"hh\:mm\:ss\,fff");
                if (!string.IsNullOrWhiteSpace(lyric) && lyric != previousLyric) // Add the new lyric line.
                {
                    captions.AddRange(new[]
                    {
                        $"{++itemIndex}",
                        $"{startTime} --> {stopTime}",
                        lyric,
                        string.Empty
                    });
                    previousLyric = lyric;
                }
                else if (itemIndex > 0) // The previous lyric line is repeated, so just extend its display time.
                {
                    var captionIndex = 4 * itemIndex - 3;
                    var caption = captions[captionIndex];
                    captions[captionIndex] = $"{caption.Substring(0, 17)}{stopTime}";
                }
            }
            return captions;
        }

        #endregion
    }
}
