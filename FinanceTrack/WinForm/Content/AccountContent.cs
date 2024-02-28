using FinanceTrack.DataLayer;
using FinanceTrack.WinForm.Content.Abstract;
using FinanceTrack.WinForm.Content.CntentItem;

namespace FinanceTrack.WinForm.Content
{
    public class AccountContent : IContentState
    {
        private IContentControlStrategy _contentControl;
        public string GetNameContent() => "Счета";

        private User _user;

        public AccountContent(User user)
        {
            _user = user;
        }

        public UserControl GetUserControl()
        {
            if (_contentControl == null)
            {
                _contentControl = new AccountControl(_user);
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
