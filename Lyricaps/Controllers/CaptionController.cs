namespace Lyricaps.Controllers
{
    using System.Windows.Forms;
    using Lyricaps.Views;

    public class CaptionController
    {
        internal CaptionController(MainController mainController)
        {
            mMainController = mainController;
            View = new CaptionDialog();
        }

        private MainController mMainController;
        private CaptionDialog mView;

        #region Properties

        private MainController MainController => mMainController;

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

        private NumericUpDown EdIndex => View.EdIndex;

        #endregion

        #region Methods

        internal void Execute(int captionNumber)
        {
            EdIndex.Value = captionNumber;
            View.ShowDialog(MainController.View);
        }

        #endregion
    }
}
