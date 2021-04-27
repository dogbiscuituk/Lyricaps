namespace Lyricaps.Views
{
    partial class CaptionDialog
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
            this.label5 = new System.Windows.Forms.Label();
            this.EdMilliseconds = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EdSeconds = new System.Windows.Forms.NumericUpDown();
            this.EdMinutes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.EdIndex = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EdLyric = new System.Windows.Forms.TextBox();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.EdDuration = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EdMilliseconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "ms";
            // 
            // EdMilliseconds
            // 
            this.EdMilliseconds.Location = new System.Drawing.Point(205, 64);
            this.EdMilliseconds.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.EdMilliseconds.Name = "EdMilliseconds";
            this.EdMilliseconds.Size = new System.Drawing.Size(41, 20);
            this.EdMilliseconds.TabIndex = 24;
            this.EdMilliseconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "sec";
            // 
            // EdSeconds
            // 
            this.EdSeconds.Location = new System.Drawing.Point(134, 64);
            this.EdSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.EdSeconds.Name = "EdSeconds";
            this.EdSeconds.Size = new System.Drawing.Size(35, 20);
            this.EdSeconds.TabIndex = 21;
            this.EdSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EdMinutes
            // 
            this.EdMinutes.Location = new System.Drawing.Point(64, 64);
            this.EdMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.EdMinutes.Name = "EdMinutes";
            this.EdMinutes.Size = new System.Drawing.Size(35, 20);
            this.EdMinutes.TabIndex = 20;
            this.EdMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Index";
            // 
            // EdIndex
            // 
            this.EdIndex.Location = new System.Drawing.Point(64, 12);
            this.EdIndex.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.EdIndex.Name = "EdIndex";
            this.EdIndex.Size = new System.Drawing.Size(41, 20);
            this.EdIndex.TabIndex = 27;
            this.EdIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Lyric";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Start";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Duration";
            // 
            // EdLyric
            // 
            this.EdLyric.Location = new System.Drawing.Point(64, 38);
            this.EdLyric.Name = "EdLyric";
            this.EdLyric.Size = new System.Drawing.Size(268, 20);
            this.EdLyric.TabIndex = 31;
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(257, 126);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 38;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            // 
            // EdDuration
            // 
            this.EdDuration.DecimalPlaces = 3;
            this.EdDuration.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.EdDuration.Location = new System.Drawing.Point(64, 91);
            this.EdDuration.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.EdDuration.Name = "EdDuration";
            this.EdDuration.Size = new System.Drawing.Size(105, 20);
            this.EdDuration.TabIndex = 39;
            this.EdDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "seconds";
            // 
            // CaptionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 161);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EdDuration);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.EdLyric);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EdIndex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EdMilliseconds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EdSeconds);
            this.Controls.Add(this.EdMinutes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CaptionDialog";
            this.Text = "Edit Lyric Caption / Timing";
            ((System.ComponentModel.ISupportInitialize)(this.EdMilliseconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.NumericUpDown EdMilliseconds;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.NumericUpDown EdSeconds;
        internal System.Windows.Forms.NumericUpDown EdMinutes;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.NumericUpDown EdIndex;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox EdLyric;
        internal System.Windows.Forms.Button ButtonOK;
        internal System.Windows.Forms.NumericUpDown EdDuration;
        internal System.Windows.Forms.Label label8;
    }
}