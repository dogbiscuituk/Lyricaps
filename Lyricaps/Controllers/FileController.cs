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
        private OpenFileDialog VideoOpenDialog => MainForm.AvOpenDialog;

        private TextBox CaptionsTextBox => MainForm.CaptionsTextBox;
        private NumericUpDown EdMilliseconds => MainForm.EdMilliseconds;
        private NumericUpDown EdMinutes => MainForm.EdMinutes;
        private NumericUpDown EdSeconds => MainForm.EdSeconds;

        private string BaseFileName => Path.GetFileNameWithoutExtension(FileName);

        private bool CanSaveCaptions => CaptionsUpdated && !string.IsNullOrWhiteSpace(CaptionsSaveDialog.FileName);
        private bool CanSaveLyrics => LyricsEdited && !string.IsNullOrWhiteSpace(LyricsSaveDialog.FileName);

        #endregion

        #region Event Handlers

        private void Menu_Opening(object sender, EventArgs e) => UpdateUI();

        private void FileSelectAvSource_Click(object sender, EventArgs e) => LoadDuration();
        private void FileOpenCaptions_Click(object sender, EventArgs e) => LoadCaptions();
        private void FileSaveCaptions_Click(object sender, EventArgs e) => SaveCaptions();
        private void FileSaveCaptionsAs_Click(object sender, EventArgs e) => SaveCaptionsAs();
        private void FileOpenLyrics_Click(object sender, EventArgs e) => LoadLyrics();
        private void FileSaveLyrics_Click(object sender, EventArgs e) => SaveLyrics();
        private void FileSaveLyricsAs_Click(object sender, EventArgs e) => SaveLyricsAs();

        private void MainForm_DragDrop(object sender, DragEventArgs e) => DropFile(e);
        private void MainForm_DragEnter(object sender, DragEventArgs e) => DropCheck(e);

        private void CaptionsTextBox_TextChanged(object sender, EventArgs e) => CaptionsUpdated = true;
        private void EdVideoLength_ValueChanged(object sender, EventArgs e) => Recalculate();
        private void LyricsTextBox_TextChanged(object sender, EventArgs e) => LyricsChanged();
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
                        SaveLyricsAs();
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
                        SaveCaptionsAs();
                        break;
                    case DialogResult.Cancel:
                        return true;
                }
            return false;
        }

        private void DropCheck(DragEventArgs e) =>
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None;

        private void DropFile(DragEventArgs e)
        {
            foreach (var fileName in (string[])e.Data.GetData(DataFormats.FileDrop, false))
                switch (Path.GetExtension(fileName).ToUpper())
                {
                    case ".MOV":
                    case ".MP3":
                    case ".MP4":
                    case ".WAV":
                        LoadDuration(fileName);
                        break;
                    case ".TXT":
                        LoadLyrics(fileName);
                        break;
                }
        }

        protected override void InitControllers(Controller parent)
        {
            base.InitControllers(parent);
            CaptionController = new CaptionController(this);
        }

        protected override void InitEvents()
        {
            base.InitEvents();

            MainForm.FileMenu.DropDownOpening += Menu_Opening;

            MainForm.FileSelectAvSource.Click += FileSelectAvSource_Click;
            MainForm.FileLoadLyrics.Click += FileOpenLyrics_Click;
            MainForm.FileSaveLyrics.Click += FileSaveLyrics_Click;
            MainForm.FileSaveLyricsAs.Click += FileSaveLyricsAs_Click;
            MainForm.FileSaveCaptions.Click += FileSaveCaptions_Click;
            MainForm.FileSaveCaptionsAs.Click += FileSaveCaptionsAs_Click;

            MainForm.PopupLyrics.Opening += Menu_Opening;
            MainForm.PopupLyricsOpen.Click += FileOpenLyrics_Click;
            MainForm.PopupLyricsSave.Click += FileSaveLyrics_Click;
            MainForm.PopupLyricsSaveAs.Click += FileSaveLyricsAs_Click;

            MainForm.PopupCaptions.Opening += Menu_Opening;
            MainForm.PopupCaptionsOpen.Click += FileOpenCaptions_Click;
            MainForm.PopupCaptionsSave.Click += FileSaveCaptions_Click;
            MainForm.PopupCaptionsSaveAs.Click += FileSaveCaptionsAs_Click;

            MainForm.DragDrop += MainForm_DragDrop;
            MainForm.DragEnter += MainForm_DragEnter;
            MainForm.FormClosing += View_FormClosing;

            CaptionsTextBox.TextChanged += CaptionsTextBox_TextChanged;
            EdMilliseconds.ValueChanged += EdVideoLength_ValueChanged;
            EdMinutes.ValueChanged += EdVideoLength_ValueChanged;
            EdSeconds.ValueChanged += EdVideoLength_ValueChanged;
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
            if (VideoOpenDialog.ShowDialog(MainForm) == DialogResult.OK)
                LoadDuration(VideoOpenDialog.FileName);
        }

        private void LoadDuration(string fileName)
        {
            FileName = fileName;
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

        private void SaveCaptionsAs()
        {
            if (CaptionsSaveDialog.ShowDialog(MainForm) == DialogResult.OK)
                SaveCaptions();
        }

        private void SaveLyrics()
        {
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

        private void SaveLyricsAs()
        {
            if (LyricsSaveDialog.ShowDialog(MainForm) == DialogResult.OK)
                SaveLyrics();
        }

        private void UpdateFileDialog(string extension, params FileDialog[] fileDialogs)
        {
            foreach (var fileDialog in fileDialogs)
                if (string.IsNullOrWhiteSpace(fileDialog.FileName))
                    fileDialog.FileName = $"{BaseFileName}.{extension}";
        }

        private void UpdateUI()
        {
            MainForm.FileSaveLyrics.Enabled = MainForm.PopupLyricsSave.Enabled = CanSaveLyrics;
            MainForm.FileSaveCaptions.Enabled = MainForm.PopupCaptionsSave.Enabled = CanSaveCaptions;
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
