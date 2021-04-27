namespace Lyricaps.Controllers
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;
    using Lyricaps.Views;

    public class CaptionController
    {
        internal CaptionController(MainController mainController)
        {
            MainController = mainController;
            View = new CaptionDialog();
        }

        private MainController MainController;
        private CaptionDialog mView;

        #region Properties

        private CaptionDialog View
        {
            get => mView;
            set
            {
                if (View != null)
                {

                }
                mView = value;
                if (View != null)
                {

                }
            }
        }

        private int CaptionCount => CaptionLines.Length / 4;
        private string[] CaptionLines => CaptionsTextBox.Lines;
        private TextBox CaptionsTextBox => MainForm.CaptionsTextBox;
        private NumericUpDown EdDuration => View.EdDuration;
        private NumericUpDown EdIndex => View.EdIndex;
        private TextBox EdLyric => View.EdLyric;
        private NumericUpDown EdMilliseconds => View.EdMilliseconds;
        private NumericUpDown EdMinutes => View.EdMinutes;
        private NumericUpDown EdSeconds => View.EdSeconds;
        private MainForm MainForm => MainController.View;
        
        /// <summary>
        /// Used for TimeSpan parsing. SubRip was originally written in France, and uses the comma as millisecond separator.
        /// </summary>
        private CultureInfo French = new CultureInfo("fr-FR");

        #endregion

        #region Methods

        internal void Execute(int captionNumber)
        {
            LoadCaption(captionNumber);
            View.ShowDialog(MainController.View);
        }

        private void LoadCaption(int captionNumber)
        {
            if (captionNumber < 1 || captionNumber > CaptionCount)
                return;
            EdIndex.Value = captionNumber;
            var timing = CaptionLines[4 * captionNumber - 3];
            TimeSpan
                start = TimeSpan.Parse(timing.Substring(0, 12), French),
                stop = TimeSpan.Parse(timing.Substring(17, 12), French);
            EdMinutes.Value = start.Minutes;
            EdSeconds.Value = start.Seconds;
            EdMilliseconds.Value = start.Milliseconds;
            EdDuration.Value = (decimal)(stop - start).TotalSeconds;
            EdLyric.Text = CaptionLines[4 * captionNumber - 2];
        }

        #endregion
    }
}
