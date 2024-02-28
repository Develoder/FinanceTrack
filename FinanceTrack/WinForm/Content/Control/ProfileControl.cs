using FinanceTrack.DataLayer;
using FinanceTrack.WinForm.Content.Abstract;
using FinanceTrack.WinForm.MainWindow;
using FinanceTrack.WinForm.MainWindow.Abstract;

namespace FinanceTrack.WinForm.Content.Control
{
    public partial class ProfileControl : UserControl, IContentControlStrategy
    {
        private User _user;

        public ProfileControl(User user)
        {
            InitializeComponent();

            _user = user;
        }

        public void CloseContent()
        {

        }

        public void LoadContent()
        {
            labelUserName.Text = _user.Name.Trim();
        }

        private void buttonExid_Click(object sender, EventArgs e)
        {
            IMainState.ChangedPrimary(new LoginMainWindow());
        }
    }
}
