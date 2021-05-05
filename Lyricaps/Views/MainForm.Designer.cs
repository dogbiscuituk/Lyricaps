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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LyricsTextBox = new System.Windows.Forms.TextBox();
            this.PopupLyrics = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PopupLyricsOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.PopupLyricsSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.PopupLyricsToggleSplit = new System.Windows.Forms.ToolStripMenuItem();
            this.EdMinutes = new System.Windows.Forms.NumericUpDown();
            this.EdSeconds = new System.Windows.Forms.NumericUpDown();
            this.CaptionsTextBox = new System.Windows.Forms.TextBox();
            this.PopupCaptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PopupCaptionsOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.PopupCaptionsSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.PopupCaptionsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.PopupCaptionsToggleSplit = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.EdMilliseconds = new System.Windows.Forms.NumericUpDown();
            this.BtnSelectVideoFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VideoOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.LyricsOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.CaptionsSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.LyricsSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CaptionsOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.PopupLyrics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdSeconds)).BeginInit();
            this.PopupCaptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdMilliseconds)).BeginInit();
            this.SuspendLayout();
            // 
            // LyricsTextBox
            // 
            this.LyricsTextBox.AllowDrop = true;
            this.LyricsTextBox.ContextMenuStrip = this.PopupLyrics;
            this.LyricsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LyricsTextBox.Location = new System.Drawing.Point(0, 0);
            this.LyricsTextBox.Multiline = true;
            this.LyricsTextBox.Name = "LyricsTextBox";
            this.LyricsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LyricsTextBox.Size = new System.Drawing.Size(390, 528);
            this.LyricsTextBox.TabIndex = 1;
            this.ToolTip.SetToolTip(this.LyricsTextBox, "The lyrics can be pasted into this control from the clipboard.\r\nOr, right-click t" +
        "o load the song lyrics into this control from a text file.");
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
            // EdMinutes
            // 
            this.EdMinutes.Location = new System.Drawing.Point(93, 6);
            this.EdMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.EdMinutes.Name = "EdMinutes";
            this.EdMinutes.Size = new System.Drawing.Size(35, 20);
            this.EdMinutes.TabIndex = 2;
            this.EdMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EdSeconds
            // 
            this.EdSeconds.Location = new System.Drawing.Point(163, 6);
            this.EdSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.EdSeconds.Name = "EdSeconds";
            this.EdSeconds.Size = new System.Drawing.Size(35, 20);
            this.EdSeconds.TabIndex = 3;
            this.EdSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CaptionsTextBox
            // 
            this.CaptionsTextBox.ContextMenuStrip = this.PopupCaptions;
            this.CaptionsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CaptionsTextBox.Location = new System.Drawing.Point(0, 0);
            this.CaptionsTextBox.Multiline = true;
            this.CaptionsTextBox.Name = "CaptionsTextBox";
            this.CaptionsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.CaptionsTextBox.Size = new System.Drawing.Size(390, 528);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "sec";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "min";
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(0, 33);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.LyricsTextBox);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.CaptionsTextBox);
            this.SplitContainer.Size = new System.Drawing.Size(784, 528);
            this.SplitContainer.SplitterDistance = 390;
            this.SplitContainer.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.EdMilliseconds);
            this.panel1.Controls.Add(this.BtnSelectVideoFile);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.EdSeconds);
            this.panel1.Controls.Add(this.EdMinutes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 33);
            this.panel1.TabIndex = 15;
            this.ToolTip.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "ms";
            // 
            // EdMilliseconds
            // 
            this.EdMilliseconds.Location = new System.Drawing.Point(234, 6);
            this.EdMilliseconds.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.EdMilliseconds.Name = "EdMilliseconds";
            this.EdMilliseconds.Size = new System.Drawing.Size(41, 20);
            this.EdMilliseconds.TabIndex = 18;
            this.EdMilliseconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnSelectVideoFile
            // 
            this.BtnSelectVideoFile.Location = new System.Drawing.Point(307, 6);
            this.BtnSelectVideoFile.Name = "BtnSelectVideoFile";
            this.BtnSelectVideoFile.Size = new System.Drawing.Size(117, 23);
            this.BtnSelectVideoFile.TabIndex = 17;
            this.BtnSelectVideoFile.Text = "Select video file...";
            this.ToolTip.SetToolTip(this.BtnSelectVideoFile, "Click this button to read the duration directly from the selected media source.");
            this.BtnSelectVideoFile.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Video duration";
            // 
            // VideoOpenDialog
            // 
            this.VideoOpenDialog.Filter = "Video files (*.mov;*.mp4)|*.mov;*.mp4|Audio files (*.wav;*.mp3)|*.wav;*.mp3|All f" +
    "iles (*.*)|*.*";
            this.VideoOpenDialog.Title = "Select a Video File";
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
            // CaptionsOpenDialog
            // 
            this.CaptionsOpenDialog.Filter = "SubRip files (*.srt)|*.srt|All files (*.*)|*.*";
            this.CaptionsOpenDialog.Title = "Open Captions File";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.SplitContainer);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.Text = "Lyric Captions";
            this.PopupLyrics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EdMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdSeconds)).EndInit();
            this.PopupCaptions.ResumeLayout(false);
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel1.PerformLayout();
            this.SplitContainer.Panel2.ResumeLayout(false);
            this.SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdMilliseconds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.TextBox LyricsTextBox;
        internal System.Windows.Forms.NumericUpDown EdMinutes;
        internal System.Windows.Forms.NumericUpDown EdSeconds;
        internal System.Windows.Forms.TextBox CaptionsTextBox;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.SplitContainer SplitContainer;
        internal System.Windows.Forms.ContextMenuStrip PopupLyrics;
        internal System.Windows.Forms.ToolStripMenuItem PopupLyricsOpen;
        internal System.Windows.Forms.ToolStripMenuItem PopupLyricsSave;
        internal System.Windows.Forms.ContextMenuStrip PopupCaptions;
        internal System.Windows.Forms.ToolStripMenuItem PopupCaptionsSave;
        internal System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button BtnSelectVideoFile;
        internal System.Windows.Forms.OpenFileDialog VideoOpenDialog;
        internal System.Windows.Forms.OpenFileDialog LyricsOpenDialog;
        internal System.Windows.Forms.SaveFileDialog CaptionsSaveDialog;
        internal System.Windows.Forms.SaveFileDialog LyricsSaveDialog;
        internal System.Windows.Forms.ToolStripMenuItem PopupLyricsToggleSplit;
        internal System.Windows.Forms.ToolStripMenuItem PopupCaptionsToggleSplit;
        internal System.Windows.Forms.ToolTip ToolTip;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.NumericUpDown EdMilliseconds;
        internal System.Windows.Forms.ToolStripMenuItem PopupCaptionsEdit;
        internal System.Windows.Forms.ToolStripMenuItem PopupCaptionsOpen;
        internal System.Windows.Forms.OpenFileDialog CaptionsOpenDialog;
        internal System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        internal System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        internal System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
    }
}

