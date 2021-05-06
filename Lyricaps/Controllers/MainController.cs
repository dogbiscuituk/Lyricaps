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
        private void PopupToggleSplit_Click(object sender, EventArgs e) => ToggleSplit();

        #endregion

        #region Methods

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
