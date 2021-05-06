namespace Lyricaps.Controllers
{
    using System;
    using System.IO;
    using System.Windows.Forms;
    using Lyricaps.Views;

    internal class FileController : Controller
    {
        #region Constructor

        internal FileController(Controller parent) : base(parent) { }

        #endregion

        #region Fields

        private CaptionController CaptionController;
        private string FileName;
        private bool LyricsEdited, CaptionsUpdated;

        #endregion

        #region Properties

        internal TextBox LyricsTextBox => MainForm.LyricsTextBox;

        private MainForm MainForm => ((MainController)Parent).MainForm;

        private OpenFileDialog CaptionsOpenDialog => MainForm.CaptionsOpenDialog;
        private SaveFileDialog CaptionsSaveDialog => MainForm.CaptionsSaveDialog;
        private OpenFileDialog LyricsOpenDialog => MainForm.LyricsOpenDialog;
        private SaveFileDialog LyricsSaveDialog => MainForm.LyricsSaveDialog;
        private OpenFileDialog VideoOpenDialog => MainForm.VideoOpenDialog;

        private TextBox CaptionsTextBox => MainForm.CaptionsTextBox;
        private NumericUpDown EdMilliseconds => MainForm.EdMilliseconds;
        private NumericUpDown EdMinutes => MainForm.EdMinutes;
        private NumericUpDown EdSeconds => MainForm.EdSeconds;

        private string BaseFileName => Path.GetFileNameWithoutExtension(FileName);

        #endregion

        #region Event Handlers

        private void BtnSelectVideoFile_Click(object sender, System.EventArgs e) => LoadDuration();
        private void CaptionsTextBox_TextChanged(object sender, EventArgs e) => CaptionsChanged();
        private void EdVideoLength_ValueChanged(object sender, EventArgs e) => Recalculate();
        private void LyricsTextBox_DragDrop(object sender, DragEventArgs e) => DropFile(e);
        private void LyricsTextBox_DragEnter(object sender, DragEventArgs e) => DropCheck(e);
        private void LyricsTextBox_TextChanged(object sender, EventArgs e) => LyricsChanged();
        private void PopupCaptionsOpen_Click(object sender, System.EventArgs e) => LoadCaptions();
        private void PopupCaptionsSave_Click(object sender, System.EventArgs e) => SaveCaptions();
        private void PopupLyricsOpen_Click(object sender, System.EventArgs e) => LoadLyrics();
        private void PopupLyricsSave_Click(object sender, System.EventArgs e) => SaveLyrics();
        private void View_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = CancelClose(e.CloseReason);

        #endregion

        #region Methods

        private bool CancelClose(CloseReason closeReason)
        {
            if (closeReason != CloseReason.UserClosing)
                return false;
            if (LyricsEdited)
                switch (MessageBox.Show(
                    MainForm,
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
                    MainForm,
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

        private void DropCheck(DragEventArgs e) =>
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None;

        private void DropFile(DragEventArgs e)
        {
            var fileNames = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (var fileName in fileNames)
                LoadLyrics(fileName);
        }

        protected override void InitControllers(Controller parent)
        {
            base.InitControllers(parent);
            CaptionController = new CaptionController(this);
        }

        protected override void InitEvents()
        {
            base.InitEvents();
            MainForm.BtnSelectVideoFile.Click += BtnSelectVideoFile_Click;
            MainForm.FormClosing += View_FormClosing;
            MainForm.PopupLyricsOpen.Click += PopupLyricsOpen_Click;
            MainForm.PopupLyricsSave.Click += PopupLyricsSave_Click;
            MainForm.PopupCaptionsOpen.Click += PopupCaptionsOpen_Click;
            MainForm.PopupCaptionsSave.Click += PopupCaptionsSave_Click;
            CaptionsTextBox.TextChanged += CaptionsTextBox_TextChanged;
            EdMilliseconds.ValueChanged += EdVideoLength_ValueChanged;
            EdMinutes.ValueChanged += EdVideoLength_ValueChanged;
            EdSeconds.ValueChanged += EdVideoLength_ValueChanged;
            LyricsTextBox.DragDrop += LyricsTextBox_DragDrop;
            LyricsTextBox.DragEnter += LyricsTextBox_DragEnter;
            LyricsTextBox.TextChanged += LyricsTextBox_TextChanged;
        }

        private void LoadCaptions()
        {
            if (CaptionsOpenDialog.ShowDialog(MainForm) != DialogResult.OK)
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
            if (VideoOpenDialog.ShowDialog(MainForm) != DialogResult.OK)
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
            if (LyricsOpenDialog.ShowDialog(MainForm) == DialogResult.OK)
                LoadLyrics(LyricsOpenDialog.FileName);
        }

        private void LoadLyrics(string fileName)
        {
            FileName = fileName;
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
            CaptionController.GetCaptions((int)EdMinutes.Value, (int)EdSeconds.Value, (int)EdMilliseconds.Value);
            CaptionsTextBox.Lines = CaptionController.Captions.ToArray();
        }

        private void SaveCaptions()
        {
            if (CaptionsSaveDialog.ShowDialog(MainForm) != DialogResult.OK)
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
            if (LyricsSaveDialog.ShowDialog(MainForm) != DialogResult.OK)
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

        private void UpdateFileDialog(string extension, params FileDialog[] fileDialogs)
        {
            foreach (var fileDialog in fileDialogs)
                if (string.IsNullOrWhiteSpace(fileDialog.FileName))
                    fileDialog.FileName = $"{BaseFileName}.{extension}";
        }

        private void UpdateFileName()
        {
            MainForm.Text = $"{BaseFileName} - Lyric Captions";
            UpdateFileDialog("mp4", VideoOpenDialog);
            UpdateFileDialog("txt", LyricsOpenDialog, LyricsSaveDialog);
            UpdateFileDialog("srt", CaptionsOpenDialog, CaptionsSaveDialog);
        }

        #endregion
    }
}
