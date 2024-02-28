using FinanceTrack.DataLayer;
using FinanceTrack.WinForm.MainWindow.Abstract;
using FinanceTrack.WinForm.MainWindow.Control;

namespace FinanceTrack.WinForm.MainWindow
{
    public class ManagerMainWindow : IMainState
    {
        private IControlStrategy _mainControl;
        private User _user;

        public ManagerMainWindow(User user)
        {
            _user = user;
        }

        public UserControl GetUserControl()
        {
            if (_mainControl == null)
            {
                _mainControl = new ManagerMainControl(_user);
                _mainControl.LoadContent();
            }

            return (UserControl)_mainControl;
        }

        public void CloseContent()
        {
            if (_mainControl != null)
            {
                _mainControl.CloseContent();
                _mainControl = null;
            }
        }

        public void PressEnter()
        {
            _mainControl?.PressEnter();
        }
    }
}
