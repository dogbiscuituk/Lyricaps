namespace Lyricaps
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.PopupLyricsToggleSplit = new System.Windows.Forms.ToolStripMenuItem();
            this.edMinutes = new System.Windows.Forms.NumericUpDown();
            this.edSeconds = new System.Windows.Forms.NumericUpDown();
            this.CaptionsTextBox = new System.Windows.Forms.TextBox();
            this.PopupCaptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PopupCaptionsSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.PopupCaptionsToggleSplit = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelectVideoFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.edHours = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.VideoOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.LyricsOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.CaptionsSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.LyricsSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.edMilliseconds = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.PopupLyrics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSeconds)).BeginInit();
            this.PopupCaptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMilliseconds)).BeginInit();
            this.SuspendLayout();
            // 
            // LyricsTextBox
            // 
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
            this.LyricsTextBox.TextChanged += new System.EventHandler(this.edLyrics_TextChanged);
            // 
            // PopupLyrics
            // 
            this.PopupLyrics.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PopupLyricsOpen,
            this.PopupLyricsSave,
            this.toolStripMenuItem1,
            this.PopupLyricsToggleSplit});
            this.PopupLyrics.Name = "PopupLyrics";
            this.PopupLyrics.Size = new System.Drawing.Size(145, 76);
            // 
            // PopupLyricsOpen
            // 
            this.PopupLyricsOpen.Name = "PopupLyricsOpen";
            this.PopupLyricsOpen.Size = new System.Drawing.Size(144, 22);
            this.PopupLyricsOpen.Text = "Open Lyrics...";
            this.PopupLyricsOpen.ToolTipText = "Load the song lyrics into this control from a text file.\r\nThe lyrics can also be " +
    "pasted into this control from the clipboard.";
            this.PopupLyricsOpen.Click += new System.EventHandler(this.PopupLyricsOpen_Click);
            // 
            // PopupLyricsSave
            // 
            this.PopupLyricsSave.Name = "PopupLyricsSave";
            this.PopupLyricsSave.Size = new System.Drawing.Size(144, 22);
            this.PopupLyricsSave.Text = "Save Lyrics...";
            this.PopupLyricsSave.ToolTipText = "Save the song lyrics to a text file.";
            this.PopupLyricsSave.Click += new System.EventHandler(this.PopupLyricsSave_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(141, 6);
            // 
            // PopupLyricsToggleSplit
            // 
            this.PopupLyricsToggleSplit.Name = "PopupLyricsToggleSplit";
            this.PopupLyricsToggleSplit.Size = new System.Drawing.Size(144, 22);
            this.PopupLyricsToggleSplit.Text = "Toggle Split";
            this.PopupLyricsToggleSplit.ToolTipText = "Toggle between a horizontally and vertically split window.";
            this.PopupLyricsToggleSplit.Click += new System.EventHandler(this.PopupToggleSplit_Click);
            // 
            // edMinutes
            // 
            this.edMinutes.Location = new System.Drawing.Point(152, 6);
            this.edMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.edMinutes.Name = "edMinutes";
            this.edMinutes.Size = new System.Drawing.Size(35, 20);
            this.edMinutes.TabIndex = 2;
            this.edMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edMinutes.ValueChanged += new System.EventHandler(this.edVideoLength_ValueChanged);
            // 
            // edSeconds
            // 
            this.edSeconds.Location = new System.Drawing.Point(222, 6);
            this.edSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.edSeconds.Name = "edSeconds";
            this.edSeconds.Size = new System.Drawing.Size(35, 20);
            this.edSeconds.TabIndex = 3;
            this.edSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edSeconds.ValueChanged += new System.EventHandler(this.edVideoLength_ValueChanged);
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
            this.CaptionsTextBox.TextChanged += new System.EventHandler(this.edCaptions_TextChanged);
            // 
            // PopupCaptions
            // 
            this.PopupCaptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PopupCaptionsSave,
            this.toolStripMenuItem2,
            this.PopupCaptionsToggleSplit});
            this.PopupCaptions.Name = "PopupCaptions";
            this.PopupCaptions.Size = new System.Drawing.Size(158, 54);
            // 
            // PopupCaptionsSave
            // 
            this.PopupCaptionsSave.Name = "PopupCaptionsSave";
            this.PopupCaptionsSave.Size = new System.Drawing.Size(157, 22);
            this.PopupCaptionsSave.Text = "Save Captions...";
            this.PopupCaptionsSave.ToolTipText = "Save the calculated captions to a SubRip format file.";
            this.PopupCaptionsSave.Click += new System.EventHandler(this.PopupCaptionsSave_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(154, 6);
            // 
            // PopupCaptionsToggleSplit
            // 
            this.PopupCaptionsToggleSplit.Name = "PopupCaptionsToggleSplit";
            this.PopupCaptionsToggleSplit.Size = new System.Drawing.Size(157, 22);
            this.PopupCaptionsToggleSplit.Text = "Toggle Split";
            this.PopupCaptionsToggleSplit.ToolTipText = "Toggle between a horizontally and vertically split window.";
            this.PopupCaptionsToggleSplit.Click += new System.EventHandler(this.PopupToggleSplit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "sec";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 9);
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
            this.panel1.Controls.Add(this.edMilliseconds);
            this.panel1.Controls.Add(this.btnSelectVideoFile);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.edHours);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.edSeconds);
            this.panel1.Controls.Add(this.edMinutes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 33);
            this.panel1.TabIndex = 15;
            this.ToolTip.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
            // 
            // btnSelectVideoFile
            // 
            this.btnSelectVideoFile.Location = new System.Drawing.Point(366, 4);
            this.btnSelectVideoFile.Name = "btnSelectVideoFile";
            this.btnSelectVideoFile.Size = new System.Drawing.Size(117, 23);
            this.btnSelectVideoFile.TabIndex = 17;
            this.btnSelectVideoFile.Text = "Select video file...";
            this.ToolTip.SetToolTip(this.btnSelectVideoFile, "Click this button to read the duration directly from the selected media source.");
            this.btnSelectVideoFile.UseVisualStyleBackColor = true;
            this.btnSelectVideoFile.Click += new System.EventHandler(this.btnSelectVideoFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "hrs";
            // 
            // edHours
            // 
            this.edHours.Location = new System.Drawing.Point(84, 6);
            this.edHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.edHours.Name = "edHours";
            this.edHours.Size = new System.Drawing.Size(35, 20);
            this.edHours.TabIndex = 16;
            this.edHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edHours.ValueChanged += new System.EventHandler(this.edVideoLength_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Video length";
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
            // edMilliseconds
            // 
            this.edMilliseconds.Location = new System.Drawing.Point(293, 6);
            this.edMilliseconds.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.edMilliseconds.Name = "edMilliseconds";
            this.edMilliseconds.Size = new System.Drawing.Size(41, 20);
            this.edMilliseconds.TabIndex = 18;
            this.edMilliseconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edMilliseconds.ValueChanged += new System.EventHandler(this.edVideoLength_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "ms";
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.PopupLyrics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSeconds)).EndInit();
            this.PopupCaptions.ResumeLayout(false);
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel1.PerformLayout();
            this.SplitContainer.Panel2.ResumeLayout(false);
            this.SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMilliseconds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox LyricsTextBox;
        private System.Windows.Forms.NumericUpDown edMinutes;
        private System.Windows.Forms.NumericUpDown edSeconds;
        private System.Windows.Forms.TextBox CaptionsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.ContextMenuStrip PopupLyrics;
        private System.Windows.Forms.ToolStripMenuItem PopupLyricsOpen;
        private System.Windows.Forms.ToolStripMenuItem PopupLyricsSave;
        private System.Windows.Forms.ContextMenuStrip PopupCaptions;
        private System.Windows.Forms.ToolStripMenuItem PopupCaptionsSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown edHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectVideoFile;
        private System.Windows.Forms.OpenFileDialog VideoOpenDialog;
        private System.Windows.Forms.OpenFileDialog LyricsOpenDialog;
        private System.Windows.Forms.SaveFileDialog CaptionsSaveDialog;
        private System.Windows.Forms.SaveFileDialog LyricsSaveDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem PopupLyricsToggleSplit;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem PopupCaptionsToggleSplit;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown edMilliseconds;
    }
}

