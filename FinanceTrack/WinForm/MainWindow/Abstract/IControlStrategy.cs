namespace FinanceTrack.WinForm.MainWindow.Abstract
{
    public interface IControlStrategy
    {
        public void LoadContent();
        public void CloseContent();
        void PressEnter();
    }
}
