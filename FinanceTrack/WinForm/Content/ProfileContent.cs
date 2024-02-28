using FinanceTrack.DataLayer;
using FinanceTrack.WinForm.Content.Abstract;
using FinanceTrack.WinForm.Content.Control;

namespace FinanceTrack.WinForm.Content
{
    public class ProfileContent : IContentState
    {
        private IContentControlStrategy _contentControl;
        public string GetNameContent() => "Профиль";

        private User _user;

        public ProfileContent(User user)
        {
            _user = user;
        }

        public UserControl GetUserControl()
        {
            if (_contentControl == null)
            {
                _contentControl = new ProfileControl(_user);
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
