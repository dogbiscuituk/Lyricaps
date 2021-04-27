namespace Lyricaps.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Windows.Forms;
    using Lyricaps.Views;

    public class MainController
    {
        #region Constructor

        public MainController() => View = new MainForm();

        #endregion

        #region Fields

        private MainForm mView;

        private List<string>
            Lyrics = new List<string>(),
            Captions = new List<string>();

        private string FileName;

        private bool
            LyricsEdited,
            CaptionsUpdated;

        #endregion

        #region Properties

        public MainForm View
        {
            get => mView;
            set
            {
                if (View != null)
                {
                    View.BtnSelectVideoFile.Click -= BtnSelectVideoFile_Click;
                    View.CaptionsTextBox.TextChanged -= CaptionsTextBox_TextChanged;
                    View.EdMilliseconds.ValueChanged -= EdVideoLength_ValueChanged;
                    View.EdMinutes.ValueChanged -= EdVideoLength_ValueChanged;
                    View.EdSeconds.ValueChanged -= EdVideoLength_ValueChanged;
                    View.FormClosing -= View_FormClosing;
                    View.LyricsTextBox.TextChanged -= LyricsTextBox_TextChanged;
                    View.PopupCaptionsEdit.Click -= PopupCaptionsEdit_Click;
                    View.PopupCaptionsOpen.Click -= PopupCaptionsOpen_Click;
                    View.PopupCaptionsSave.Click -= PopupCaptionsSave_Click;
                    View.PopupCaptionsToggleSplit.Click -= PopupToggleSplit_Click;
                    View.PopupLyricsOpen.Click -= PopupLyricsOpen_Click;
                    View.PopupLyricsSave.Click -= PopupLyricsSave_Click;
                    View.PopupLyricsToggleSplit.Click -= PopupToggleSplit_Click;
                }
                mView = value;
                if (View != null)
                {
                    View.BtnSelectVideoFile.Click += BtnSelectVideoFile_Click;
                    View.CaptionsTextBox.TextChanged += CaptionsTextBox_TextChanged;
                    View.EdMilliseconds.ValueChanged += EdVideoLength_ValueChanged;
                    View.EdMinutes.ValueChanged += EdVideoLength_ValueChanged;
                    View.EdSeconds.ValueChanged += EdVideoLength_ValueChanged;
                    View.FormClosing += View_FormClosing;
                    View.LyricsTextBox.TextChanged += LyricsTextBox_TextChanged;
                    View.PopupCaptionsEdit.Click += PopupCaptionsEdit_Click;
                    View.PopupCaptionsOpen.Click += PopupCaptionsOpen_Click;
                    View.PopupCaptionsSave.Click += PopupCaptionsSave_Click;
                    View.PopupCaptionsToggleSplit.Click += PopupToggleSplit_Click;
                    View.PopupLyricsOpen.Click += PopupLyricsOpen_Click;
                    View.PopupLyricsSave.Click += PopupLyricsSave_Click;
                    View.PopupLyricsToggleSplit.Click += PopupToggleSplit_Click;
                }
            }
        }

        private OpenFileDialog CaptionsOpenDialog => View.CaptionsOpenDialog;
        private SaveFileDialog CaptionsSaveDialog => View.CaptionsSaveDialog;
        private TextBox CaptionsTextBox => View.CaptionsTextBox;
        private NumericUpDown EdMilliseconds => View.EdMilliseconds;
        private NumericUpDown EdMinutes => View.EdMinutes;
        private NumericUpDown EdSeconds => View.EdSeconds;
        private OpenFileDialog LyricsOpenDialog => View.LyricsOpenDialog;
        private SaveFileDialog LyricsSaveDialog => View.LyricsSaveDialog;
        private TextBox LyricsTextBox => View.LyricsTextBox;
        private SplitContainer SplitContainer => View.SplitContainer;
        private OpenFileDialog VideoOpenDialog => View.VideoOpenDialog;

        #endregion

        #region Event Handlers

        private void BtnSelectVideoFile_Click(object sender, System.EventArgs e) => LoadDuration();
        private void CaptionsTextBox_TextChanged(object sender, EventArgs e) => CaptionsChanged();
        private void EdVideoLength_ValueChanged(object sender, EventArgs e) => Recalculate();
        private void LyricsTextBox_TextChanged(object sender, EventArgs e) => LyricsChanged();
        private void PopupCaptionsEdit_Click(object sender, System.EventArgs e) => EditCaptions();
        private void PopupCaptionsOpen_Click(object sender, System.EventArgs e) => LoadCaptions();
        private void PopupCaptionsSave_Click(object sender, System.EventArgs e) => SaveCaptions();
        private void PopupLyricsOpen_Click(object sender, System.EventArgs e) => LoadLyrics();
        private void PopupLyricsSave_Click(object sender, System.EventArgs e) => SaveLyrics();
        private void PopupToggleSplit_Click(object sender, System.EventArgs e) => ToggleSplit();
        private void View_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = CancelClose(e.CloseReason);

        #endregion

        #region Private Methods

        private bool CancelClose(CloseReason closeReason)
        {
            if (closeReason != CloseReason.UserClosing)
                return false;
            if (LyricsEdited)
                switch (MessageBox.Show(
                    View,
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
                    View,
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

        private void GetCaptions(int m, int s, int ms) => GetCaptions(new TimeSpan(0, 0, m, s, ms));

        private void GetCaptions(TimeSpan timeSpan)
        {
            Lyrics.Clear();
            Lyrics.AddRange(LyricsTextBox.Lines);
            Captions = new List<string>();
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
                    Captions.AddRange(new[]
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
                    var caption = Captions[captionIndex];
                    Captions[captionIndex] = $"{caption.Substring(0, 17)}{stopTime}";
                }
            }
        }

        private void EditCaptions()
        {
            var captionNumber = 10;
            new CaptionDialog().Execute(View, captionNumber);
        }

        private void LoadCaptions()
        {
            if (CaptionsOpenDialog.ShowDialog(View) != DialogResult.OK)
                return;
            FileName = CaptionsOpenDialog.FileName;
            using (var reader = new StreamReader(FileName))
                CaptionsTextBox.Text = reader.ReadToEnd();
            CaptionsSaveDialog.FileName = FileName;
            CaptionsUpdated = false;
            UpdateFileName();
        }

        private void LoadDuration()
        {
            if (VideoOpenDialog.ShowDialog(View) != DialogResult.OK)
                return;
            FileName = VideoOpenDialog.FileName;
            var file = TagLib.File.Create(FileName);
            var duration = file.Properties.Duration;
            EdMinutes.Value = duration.Minutes;
            EdSeconds.Value = duration.Seconds;
            EdMilliseconds.Value = duration.Milliseconds;
            UpdateFileName();
        }

        private void LoadLyrics()
        {
            if (LyricsOpenDialog.ShowDialog(View) != DialogResult.OK)
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

        private void Recalculate()
        {
            GetCaptions(
            (int)EdMinutes.Value,
            (int)EdSeconds.Value,
            (int)EdMilliseconds.Value);
            CaptionsTextBox.Lines = Captions.ToArray();
        }

        private void SaveCaptions()
        {
            if (CaptionsSaveDialog.ShowDialog(View) != DialogResult.OK)
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
            if (LyricsSaveDialog.ShowDialog(View) != DialogResult.OK)
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

        private void UpdateFileName() => View.Text = $"{Path.GetFileNameWithoutExtension(FileName)} - Lyric Captions";

        #endregion
    }
}
