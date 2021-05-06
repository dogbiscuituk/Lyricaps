namespace Lyricaps.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LyricsTextBox = new System.Windows.Forms.TextBox();
            this.PopupLyrics = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PopupLyricsOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.PopupLyricsSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.PopupLyricsToggleSplit = new System.Windows.Forms.ToolStripMenuItem();
            this.CaptionsTextBox = new System.Windows.Forms.TextBox();
            this.PopupCaptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PopupCaptionsOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.PopupCaptionsSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.PopupCaptionsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.PopupCaptionsToggleSplit = new System.Windows.Forms.ToolStripMenuItem();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.AvOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.LyricsOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.CaptionsSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.LyricsSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CaptionsOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.EdMinutes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.EdSeconds = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.EdMilliseconds = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSelectAvSource = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.FileLoadLyrics = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveLyrics = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveCaptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.FileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewHorizontalSplit = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewVerticalSplit = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.PopupLyrics.SuspendLayout();
            this.PopupCaptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdMilliseconds)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // LyricsTextBox
            // 
            this.LyricsTextBox.ContextMenuStrip = this.PopupLyrics;
            this.LyricsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LyricsTextBox.Location = new System.Drawing.Point(0, 0);
            this.LyricsTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LyricsTextBox.Multiline = true;
            this.LyricsTextBox.Name = "LyricsTextBox";
            this.LyricsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LyricsTextBox.Size = new System.Drawing.Size(390, 504);
            this.LyricsTextBox.TabIndex = 1;
            this.ToolTip.SetToolTip(this.LyricsTextBox, "Drop or paste lyrics here, or \r\nright-click for more options.");
            this.LyricsTextBox.WordWrap = false;
            // 
            // PopupLyrics
            // 
            this.PopupLyrics.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PopupLyricsOpen,
            this.PopupLyricsSave,
            this.toolStripMenuItem3,
            this.PopupLyricsToggleSplit});
            this.PopupLyrics.Name = "PopupLyrics";
            this.PopupLyrics.Size = new System.Drawing.Size(156, 76);
            // 
            // PopupLyricsOpen
            // 
            this.PopupLyricsOpen.Name = "PopupLyricsOpen";
            this.PopupLyricsOpen.Size = new System.Drawing.Size(155, 22);
            this.PopupLyricsOpen.Text = "Open Lyrics...";
            this.PopupLyricsOpen.ToolTipText = "Load the song lyrics into this control from a text file.\r\nThe lyrics can also be " +
    "pasted into this control from the clipboard.";
            // 
            // PopupLyricsSave
            // 
            this.PopupLyricsSave.Name = "PopupLyricsSave";
            this.PopupLyricsSave.Size = new System.Drawing.Size(155, 22);
            this.PopupLyricsSave.Text = "Save Lyrics As...";
            this.PopupLyricsSave.ToolTipText = "Save the song lyrics to a text file.";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 6);
            // 
            // PopupLyricsToggleSplit
            // 
            this.PopupLyricsToggleSplit.Name = "PopupLyricsToggleSplit";
            this.PopupLyricsToggleSplit.Size = new System.Drawing.Size(155, 22);
            this.PopupLyricsToggleSplit.Text = "Toggle Split";
            this.PopupLyricsToggleSplit.ToolTipText = "Toggle between a horizontally and vertically split window.";
            // 
            // CaptionsTextBox
            // 
            this.CaptionsTextBox.ContextMenuStrip = this.PopupCaptions;
            this.CaptionsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CaptionsTextBox.Location = new System.Drawing.Point(0, 0);
            this.CaptionsTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CaptionsTextBox.Multiline = true;
            this.CaptionsTextBox.Name = "CaptionsTextBox";
            this.CaptionsTextBox.ReadOnly = true;
            this.CaptionsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.CaptionsTextBox.Size = new System.Drawing.Size(389, 504);
            this.CaptionsTextBox.TabIndex = 4;
            this.ToolTip.SetToolTip(this.CaptionsTextBox, "The calculated captions appear here.\r\nRight-click to save them to a SubRip file.");
            this.CaptionsTextBox.WordWrap = false;
            // 
            // PopupCaptions
            // 
            this.PopupCaptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PopupCaptionsOpen,
            this.PopupCaptionsSave,
            this.toolStripMenuItem1,
            this.PopupCaptionsEdit,
            this.toolStripMenuItem2,
            this.PopupCaptionsToggleSplit});
            this.PopupCaptions.Name = "PopupCaptions";
            this.PopupCaptions.Size = new System.Drawing.Size(174, 104);
            // 
            // PopupCaptionsOpen
            // 
            this.PopupCaptionsOpen.Name = "PopupCaptionsOpen";
            this.PopupCaptionsOpen.Size = new System.Drawing.Size(173, 22);
            this.PopupCaptionsOpen.Text = "Open Captions...";
            // 
            // PopupCaptionsSave
            // 
            this.PopupCaptionsSave.Name = "PopupCaptionsSave";
            this.PopupCaptionsSave.Size = new System.Drawing.Size(173, 22);
            this.PopupCaptionsSave.Text = "Save Captions As...";
            this.PopupCaptionsSave.ToolTipText = "Save the calculated captions to a SubRip format file.";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(170, 6);
            this.toolStripMenuItem1.Visible = false;
            // 
            // PopupCaptionsEdit
            // 
            this.PopupCaptionsEdit.Name = "PopupCaptionsEdit";
            this.PopupCaptionsEdit.Size = new System.Drawing.Size(173, 22);
            this.PopupCaptionsEdit.Text = "Edit Caption...";
            this.PopupCaptionsEdit.Visible = false;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(170, 6);
            // 
            // PopupCaptionsToggleSplit
            // 
            this.PopupCaptionsToggleSplit.Name = "PopupCaptionsToggleSplit";
            this.PopupCaptionsToggleSplit.Size = new System.Drawing.Size(173, 22);
            this.PopupCaptionsToggleSplit.Text = "Toggle Split";
            this.PopupCaptionsToggleSplit.ToolTipText = "Toggle between a horizontally and vertically split window.";
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.LyricsTextBox);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.CaptionsTextBox);
            this.SplitContainer.Size = new System.Drawing.Size(784, 504);
            this.SplitContainer.SplitterDistance = 390;
            this.SplitContainer.SplitterWidth = 5;
            this.SplitContainer.TabIndex = 8;
            // 
            // AvOpenDialog
            // 
            this.AvOpenDialog.Filter = "AV files (*.mov;*.mp4;*.wav;*.mp3)|*.mov;*.mp4;*.wav;*.mp3|All files (*.*)|*.*";
            this.AvOpenDialog.Title = "Select Audio or Video File";
            // 
            // LyricsOpenDialog
            // 
            this.LyricsOpenDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            this.LyricsOpenDialog.Title = "Select a Lyrics File";
            // 
            // CaptionsSaveDialog
            // 
            this.CaptionsSaveDialog.DefaultExt = "srt";
            this.CaptionsSaveDialog.Filter = "SubRip files (*.srt)|*.srt|All files (*.*)|*.*";
            this.CaptionsSaveDialog.Title = "Save Captions File";
            // 
            // LyricsSaveDialog
            // 
            this.LyricsSaveDialog.DefaultExt = "txt";
            this.LyricsSaveDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            this.LyricsSaveDialog.Title = "Save Lyrics File";
            // 
            // ToolTip
            // 
            this.ToolTip.AutomaticDelay = 1000;
            this.ToolTip.AutoPopDelay = 5000;
            this.ToolTip.InitialDelay = 100;
            this.ToolTip.ReshowDelay = 100;
            // 
            // CaptionsOpenDialog
            // 
            this.CaptionsOpenDialog.Filter = "SubRip files (*.srt)|*.srt|All files (*.*)|*.*";
            this.CaptionsOpenDialog.Title = "Open Captions File";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.SplitContainer);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.flowLayoutPanel1);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(784, 537);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(784, 561);
            this.toolStripContainer1.TabIndex = 16;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.MainMenu);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.EdMinutes);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.EdSeconds);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.EdMilliseconds);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 504);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(784, 33);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Song duration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EdMinutes
            // 
            this.EdMinutes.Location = new System.Drawing.Point(100, 4);
            this.EdMinutes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EdMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.EdMinutes.Name = "EdMinutes";
            this.EdMinutes.Size = new System.Drawing.Size(41, 25);
            this.EdMinutes.TabIndex = 2;
            this.EdMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(147, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "min";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EdSeconds
            // 
            this.EdSeconds.Location = new System.Drawing.Point(187, 4);
            this.EdSeconds.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EdSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.EdSeconds.Name = "EdSeconds";
            this.EdSeconds.Size = new System.Drawing.Size(41, 25);
            this.EdSeconds.TabIndex = 3;
            this.EdSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(234, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "sec";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EdMilliseconds
            // 
            this.EdMilliseconds.Location = new System.Drawing.Point(276, 4);
            this.EdMilliseconds.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EdMilliseconds.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.EdMilliseconds.Name = "EdMilliseconds";
            this.EdMilliseconds.Size = new System.Drawing.Size(48, 25);
            this.EdMilliseconds.TabIndex = 18;
            this.EdMilliseconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(330, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "ms";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainMenu
            // 
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.ViewMenu,
            this.HelpMenu});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(784, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileSelectAvSource,
            this.toolStripMenuItem4,
            this.FileLoadLyrics,
            this.FileSaveLyrics,
            this.FileSaveCaptions,
            this.toolStripMenuItem5,
            this.FileExit});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "&File";
            // 
            // FileSelectAvSource
            // 
            this.FileSelectAvSource.Name = "FileSelectAvSource";
            this.FileSelectAvSource.Size = new System.Drawing.Size(170, 22);
            this.FileSelectAvSource.Text = "Select AV Source...";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(167, 6);
            // 
            // FileLoadLyrics
            // 
            this.FileLoadLyrics.Name = "FileLoadLyrics";
            this.FileLoadLyrics.Size = new System.Drawing.Size(170, 22);
            this.FileLoadLyrics.Text = "Load Lyrics";
            // 
            // FileSaveLyrics
            // 
            this.FileSaveLyrics.Name = "FileSaveLyrics";
            this.FileSaveLyrics.Size = new System.Drawing.Size(170, 22);
            this.FileSaveLyrics.Text = "Save Lyrics";
            // 
            // FileSaveCaptions
            // 
            this.FileSaveCaptions.Name = "FileSaveCaptions";
            this.FileSaveCaptions.Size = new System.Drawing.Size(170, 22);
            this.FileSaveCaptions.Text = "Save Captions";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(167, 6);
            // 
            // FileExit
            // 
            this.FileExit.Name = "FileExit";
            this.FileExit.Size = new System.Drawing.Size(170, 22);
            this.FileExit.Text = "Exit";
            // 
            // ViewMenu
            // 
            this.ViewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewHorizontalSplit,
            this.ViewVerticalSplit});
            this.ViewMenu.Name = "ViewMenu";
            this.ViewMenu.Size = new System.Drawing.Size(44, 20);
            this.ViewMenu.Text = "&View";
            // 
            // ViewHorizontalSplit
            // 
            this.ViewHorizontalSplit.Name = "ViewHorizontalSplit";
            this.ViewHorizontalSplit.Size = new System.Drawing.Size(155, 22);
            this.ViewHorizontalSplit.Text = "&Horizontal Split";
            // 
            // ViewVerticalSplit
            // 
            this.ViewVerticalSplit.Name = "ViewVerticalSplit";
            this.ViewVerticalSplit.Size = new System.Drawing.Size(155, 22);
            this.ViewVerticalSplit.Text = "&Vertical Split";
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpAbout});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(44, 20);
            this.HelpMenu.Text = "&Help";
            // 
            // HelpAbout
            // 
            this.HelpAbout.Name = "HelpAbout";
            this.HelpAbout.Size = new System.Drawing.Size(107, 22);
            this.HelpAbout.Text = "&About";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.toolStripContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.MainMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.Text = "Lyric Captions";
            this.PopupLyrics.ResumeLayout(false);
            this.PopupCaptions.ResumeLayout(false);
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel1.PerformLayout();
            this.SplitContainer.Panel2.ResumeLayout(false);
            this.SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EdMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdMilliseconds)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.TextBox LyricsTextBox;
        internal System.Windows.Forms.TextBox CaptionsTextBox;
        internal System.Windows.Forms.SplitContainer SplitContainer;
        internal System.Windows.Forms.ContextMenuStrip PopupLyrics;
        internal System.Windows.Forms.ToolStripMenuItem PopupLyricsOpen;
        internal System.Windows.Forms.ToolStripMenuItem PopupLyricsSave;
        internal System.Windows.Forms.ContextMenuStrip PopupCaptions;
        internal System.Windows.Forms.ToolStripMenuItem PopupCaptionsSave;
        internal System.Windows.Forms.OpenFileDialog AvOpenDialog;
        internal System.Windows.Forms.OpenFileDialog LyricsOpenDialog;
        internal System.Windows.Forms.SaveFileDialog CaptionsSaveDialog;
        internal System.Windows.Forms.SaveFileDialog LyricsSaveDialog;
        internal System.Windows.Forms.ToolStripMenuItem PopupLyricsToggleSplit;
        internal System.Windows.Forms.ToolStripMenuItem PopupCaptionsToggleSplit;
        internal System.Windows.Forms.ToolTip ToolTip;
        internal System.Windows.Forms.ToolStripMenuItem PopupCaptionsEdit;
        internal System.Windows.Forms.ToolStripMenuItem PopupCaptionsOpen;
        internal System.Windows.Forms.OpenFileDialog CaptionsOpenDialog;
        internal System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        internal System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        internal System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        internal System.Windows.Forms.ToolStripContainer toolStripContainer1;
        internal System.Windows.Forms.MenuStrip MainMenu;
        internal System.Windows.Forms.ToolStripMenuItem FileMenu;
        internal System.Windows.Forms.ToolStripMenuItem FileSelectAvSource;
        internal System.Windows.Forms.ToolStripMenuItem FileLoadLyrics;
        internal System.Windows.Forms.ToolStripMenuItem FileSaveLyrics;
        internal System.Windows.Forms.ToolStripMenuItem FileSaveCaptions;
        internal System.Windows.Forms.ToolStripMenuItem FileExit;
        internal System.Windows.Forms.ToolStripMenuItem HelpMenu;
        internal System.Windows.Forms.ToolStripMenuItem HelpAbout;
        internal System.Windows.Forms.ToolStripMenuItem ViewMenu;
        internal System.Windows.Forms.ToolStripMenuItem ViewHorizontalSplit;
        internal System.Windows.Forms.ToolStripMenuItem ViewVerticalSplit;
        internal System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        internal System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.NumericUpDown EdMinutes;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.NumericUpDown EdSeconds;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.NumericUpDown EdMilliseconds;
        internal System.Windows.Forms.Label label5;
    }
}

