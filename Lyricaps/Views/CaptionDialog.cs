namespace Lyricaps.Views
{
    using System.Windows.Forms;

    public partial class CaptionDialog : Form
    {
        public CaptionDialog()
        {
            InitializeComponent();
        }

        public void Execute(IWin32Window owner, int captionNumber)
        {
            ShowDialog(owner);
        }
    }
}
