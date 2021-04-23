namespace Lyricaps
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using LyricapsLibrary;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SubRip()
        {
            var lines = LinesTextBox.Lines;
            var output = Captioner.Caption(lines, (int)edMinutes.Value, (int)edSeconds.Value);
            OutputTextBox.Lines = output.ToArray();
        }

        private void LinesTextBox_TextChanged(object sender, EventArgs e)
        {
            SubRip();
        }

        private void edMinutes_ValueChanged(object sender, EventArgs e)
        {
            SubRip();
        }
    }
}