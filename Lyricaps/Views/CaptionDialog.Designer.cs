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
            this.edStartMilliseconds = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edStartSeconds = new System.Windows.Forms.NumericUpDown();
            this.edStartMinutes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.edIndex = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.edLyric = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edStartMilliseconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edStartSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edStartMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            // edStartMilliseconds
            // 
            this.edStartMilliseconds.Location = new System.Drawing.Point(205, 64);
            this.edStartMilliseconds.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.edStartMilliseconds.Name = "edStartMilliseconds";
            this.edStartMilliseconds.Size = new System.Drawing.Size(41, 20);
            this.edStartMilliseconds.TabIndex = 24;
            this.edStartMilliseconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // edStartSeconds
            // 
            this.edStartSeconds.Location = new System.Drawing.Point(134, 64);
            this.edStartSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.edStartSeconds.Name = "edStartSeconds";
            this.edStartSeconds.Size = new System.Drawing.Size(35, 20);
            this.edStartSeconds.TabIndex = 21;
            this.edStartSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // edStartMinutes
            // 
            this.edStartMinutes.Location = new System.Drawing.Point(64, 64);
            this.edStartMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.edStartMinutes.Name = "edStartMinutes";
            this.edStartMinutes.Size = new System.Drawing.Size(35, 20);
            this.edStartMinutes.TabIndex = 20;
            this.edStartMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // edIndex
            // 
            this.edIndex.Location = new System.Drawing.Point(64, 12);
            this.edIndex.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.edIndex.Name = "edIndex";
            this.edIndex.Size = new System.Drawing.Size(41, 20);
            this.edIndex.TabIndex = 27;
            this.edIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // edLyric
            // 
            this.edLyric.Location = new System.Drawing.Point(64, 38);
            this.edLyric.Name = "edLyric";
            this.edLyric.Size = new System.Drawing.Size(268, 20);
            this.edLyric.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 3;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(64, 91);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(105, 20);
            this.numericUpDown1.TabIndex = 39;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.edLyric);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edIndex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edStartMilliseconds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edStartSeconds);
            this.Controls.Add(this.edStartMinutes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CaptionDialog";
            this.Text = "Edit Lyric Caption / Duration";
            ((System.ComponentModel.ISupportInitialize)(this.edStartMilliseconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edStartSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edStartMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown edStartMilliseconds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown edStartSeconds;
        private System.Windows.Forms.NumericUpDown edStartMinutes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown edIndex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox edLyric;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
    }
}