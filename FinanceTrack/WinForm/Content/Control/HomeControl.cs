using FinanceTrack.DataLayer;
using FinanceTrack.WinForm.Content.Abstract;

namespace FinanceTrack.WinForm.Content.Control
{
    public partial class HomeControl : UserControl, IContentControlStrategy
    {
        private List<Account> _accounts;

        public HomeControl(List<Account> accounts)
        {
            InitializeComponent();

            _accounts = accounts;
        }

        public void CloseContent()
        {

        }

        public void LoadContent()
        {
            if (_accounts == null || _accounts.Count <= 0)
            {
                labelText.Text = $"Чтобы начать работу вы должны создать счет.\n\nСчет можно создать в разделе \"Счет\"";
            }
            else
            {
                labelText.Text = $"";
            }
        }
    }
}
