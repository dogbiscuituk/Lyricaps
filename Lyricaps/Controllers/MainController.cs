namespace Lyricaps.Controllers
{
    using System.Windows.Forms;
    using Lyricaps.Views;

    internal class MainController
    {
        internal MainController()
        {
            MainForm = new MainForm();
            MainForm.PopupCaptionsToggleSplit.Click += PopupToggleSplit_Click;
            MainForm.PopupLyricsToggleSplit.Click += PopupToggleSplit_Click;
            _ = new FileController(this);
        }

        internal MainForm MainForm;

        private SplitContainer SplitContainer => MainForm.SplitContainer;

        private void PopupToggleSplit_Click(object sender, System.EventArgs e) => ToggleSplit();

        private void ToggleSplit() => SplitContainer.Orientation =
            SplitContainer.Orientation == Orientation.Horizontal ? Orientation.Vertical : Orientation.Horizontal;
    }
}
