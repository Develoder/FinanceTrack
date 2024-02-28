﻿using FinanceTrack.WinForm.MainWindow.Abstract;
using FinanceTrack.WinForm.MainWindow.Control;

namespace FinanceTrack.WinForm.MainWindow
{
    public class RegistrationMainWindow : IMainState
    {
        private IControlStrategy _mainControl;

        public UserControl GetUserControl()
        {
            if (_mainControl == null)
            {
                _mainControl = new RegistrationMainControl();
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
