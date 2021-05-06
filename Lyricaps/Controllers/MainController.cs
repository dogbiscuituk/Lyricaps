namespace Lyricaps.Controllers
{
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

        private SplitContainer SplitContainer => MainForm.SplitContainer;

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
            MainForm.PopupCaptionsToggleSplit.Click += PopupToggleSplit_Click;
            MainForm.PopupLyricsToggleSplit.Click += PopupToggleSplit_Click;
        }

        private void PopupToggleSplit_Click(object sender, System.EventArgs e) => ToggleSplit();

        private void ToggleSplit() => SplitContainer.Orientation =
            SplitContainer.Orientation == Orientation.Horizontal ? Orientation.Vertical : Orientation.Horizontal;

        #endregion
    }
}
