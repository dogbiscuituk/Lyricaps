namespace Lyricaps.Controllers
{
    using System;
    using System.Windows.Forms;
    using Lyricaps.Views;

    internal class MainController : Controller
    {
        #region Constructors

        internal MainController() : base(null) { }

        #endregion

        #region Fields

        internal MainForm MainForm;

        #endregion

        #region Properties

        private Orientation Orientation
        {
            get => SplitContainer.Orientation;
            set => SplitContainer.Orientation = value;
        }

        private SplitContainer SplitContainer => MainForm.SplitContainer;

        #endregion

        #region Event Handlers

        private void FileExit_Click(object sender, EventArgs e) => MainForm.Close();
        private void ViewMenu_DropDownOpening(object sender, EventArgs e) => ViewMenuOpening();
        private void ViewHorizontalSplit_Click(object sender, EventArgs e) => Orientation = Orientation.Horizontal;
        private void ViewVerticalSplit_Click(object sender, EventArgs e) => Orientation = Orientation.Vertical;
        private void HelpAbout_Click(object sender, EventArgs e) => HelpAbout();
        private void PopupToggleSplit_Click(object sender, EventArgs e) => ToggleSplit();

        #endregion

        #region Methods

        private void HelpAbout() => MessageBox.Show(
            MainForm,
            @"LYRICS MARKUP INFORMATION

To repeat a lyric line use a double quotation mark ""
To 'comment out' a lyric line use a leading hyphen -

At the start of a line (or on an otherwise empty line):

    .. Two periods = ¾ time (75%)
    . Period = ½ time (50%)
    : Colon = ¼ time (25%)
    ; Semicolon = ⅛ time (12.5%)

At the end of a nonempty line:

    Two periods = 1¾ time (175%) ..
    Period = 1½ time (150%) .
    Colon = 1¼ time (125%) :
    Semicolon = 1⅛ time (112.5%) ;",
            "Lyric Captions - version 1.4 by John Michael Kerr",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

        protected override void InitControllers(Controller parent)
        {
            base.InitControllers(parent);
            MainForm = new MainForm();
            _ = new FileController(this);
        }

        protected override void InitEvents()
        {
            base.InitEvents();

            MainForm.FileExit.Click += FileExit_Click;
            MainForm.ViewMenu.DropDownOpening += ViewMenu_DropDownOpening;
            MainForm.ViewHorizontalSplit.Click += ViewHorizontalSplit_Click;
            MainForm.ViewVerticalSplit.Click += ViewVerticalSplit_Click;
            MainForm.HelpAbout.Click += HelpAbout_Click;
            MainForm.PopupCaptionsToggleSplit.Click += PopupToggleSplit_Click;
            MainForm.PopupLyricsToggleSplit.Click += PopupToggleSplit_Click;
        }

        private void ToggleSplit() => Orientation = Orientation == Orientation.Horizontal ? Orientation.Vertical : Orientation.Horizontal;

        private void ViewMenuOpening()
        {
            MainForm.ViewHorizontalSplit.Checked = Orientation == Orientation.Horizontal;
            MainForm.ViewVerticalSplit.Checked = Orientation == Orientation.Vertical;
        }

        #endregion
    }
}
