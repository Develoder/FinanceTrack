using FinanceTrack.DataLayer;
using FinanceTrack.WinForm.Content.Abstract;
using FinanceTrack.WinForm.Content.Control;

namespace FinanceTrack.WinForm.Content
{
    public class HomeContent : IContentState
    {
        private IContentControlStrategy _contentControl;
        public string GetNameContent() => "Главная";
        private List<Account> _accounts;

        public HomeContent(List<Account> accounts)
        {
            _accounts = accounts;
        }

        public UserControl GetUserControl()
        {
            if (_contentControl == null)
            {
                _contentControl = new HomeControl(_accounts);
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
