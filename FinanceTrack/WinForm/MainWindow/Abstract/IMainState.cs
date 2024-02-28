namespace FinanceTrack.WinForm.MainWindow.Abstract
{
    public interface IMainState
    {
        public static Action<IMainState> ChangedPrimary;

        public UserControl GetUserControl();
        public void CloseContent();
        public void PressEnter();
    }
}
