using FinanceTrack.DataLayer;
using FinanceTrack.WinForm.Content.Abstract;
using FinanceTrack.WinForm.Content.Control;

namespace FinanceTrack.WinForm.Content
{
    public class TransactionContent : IContentState
    {
        private IContentControlStrategy _contentControl;

        private User _user;
        private List<Account> _accounts;

        public TransactionContent(User user, List<Account> accounts)
        {
            _user = user;
            _accounts = accounts;
        }

        public string GetNameContent()
        {
            if (_accounts == null || _accounts.Count() <= 0)
                return "Транзакции (для продолжения работы создайте счет)";
            else
                return "Транзакции";
        }

        public UserControl GetUserControl()
        {
            if (_contentControl == null)
            {
                _contentControl = new TransactionControl(_user, _accounts);
                _contentControl.LoadContent();
            }

            return (UserControl)_contentControl;
        }

        public void CloseContent()
        {
            if (_contentControl != null)
            {
                _contentControl.CloseContent();
                _contentControl = null;
            }
        }
    }
}
