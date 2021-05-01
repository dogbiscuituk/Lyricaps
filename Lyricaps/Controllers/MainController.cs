namespace Lyricaps.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
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
            Lines = new List<string>(),
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
                    CaptionsTextBox.DoubleClick -= PopupCaptionsEdit_Click;
                    CaptionsTextBox.TextChanged -= CaptionsTextBox_TextChanged;
                    EdMilliseconds.ValueChanged -= EdVideoLength_ValueChanged;
                    EdMinutes.ValueChanged -= EdVideoLength_ValueChanged;
                    EdSeconds.ValueChanged -= EdVideoLength_ValueChanged;
                    LyricsTextBox.TextChanged -= LyricsTextBox_TextChanged;
                    View.BtnSelectVideoFile.Click -= BtnSelectVideoFile_Click;
                    View.FormClosing -= View_FormClosing;
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
                    CaptionsTextBox.DoubleClick += PopupCaptionsEdit_Click;
                    CaptionsTextBox.TextChanged += CaptionsTextBox_TextChanged;
                    EdMilliseconds.ValueChanged += EdVideoLength_ValueChanged;
                    EdMinutes.ValueChanged += EdVideoLength_ValueChanged;
                    EdSeconds.ValueChanged += EdVideoLength_ValueChanged;
                    LyricsTextBox.TextChanged += LyricsTextBox_TextChanged;
                    View.BtnSelectVideoFile.Click += BtnSelectVideoFile_Click;
                    View.FormClosing += View_FormClosing;
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

        private void EditCaptions() => new CaptionController(this).Execute(
            1 + CaptionsTextBox.GetLineFromCharIndex(CaptionsTextBox.SelectionStart) / 4);

        private void GetCaptions(int m, int s, int ms) => GetCaptions(new TimeSpan(0, 0, m, s, ms));

        private void GetCaptions(TimeSpan timeSpan)
        {
            Lines.Clear();
            Lines.AddRange(LyricsTextBox.Lines);
            Captions = new List<string>();
            var itemIndex = 0;
            var lineEnd = 0.0;
            string
                startTime,
                endTime = "00:00:00,000",
                previousText = string.Empty;
            var totalTime = timeSpan.TotalMilliseconds;
            var linesEnd = Lines.Sum(line => ParseLine(ref line));
            foreach (var line in Lines)
            {
                var text = line;
                lineEnd += ParseLine(ref text);
                startTime = endTime;
                endTime = TimeSpan.FromMilliseconds(totalTime * lineEnd / linesEnd).ToString(@"hh\:mm\:ss\,fff");
                if (!string.IsNullOrWhiteSpace(text) && text != previousText) // Add the new text.
                {
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
                    var caption = Captions[captionIndex];
                    Captions[captionIndex] = $"{caption.Substring(0, 17)}{endTime}";
                }
            }
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

        #region Static Methods

        private static double ParseLine(ref string line)
        {
            var info = line.StartsWith("..") ? (2, 0.75) : line.StartsWith(".") ? (1, 0.5) : line.StartsWith(":") ? (1, 0.25) : (0, 1.0);
            if (info.Item1 > 0)
                line = line.Substring(info.Item1);
            return info.Item2;
        }

        #endregion
    }
}
