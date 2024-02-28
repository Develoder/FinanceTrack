namespace FinanceTrack.WinForm.Content.Abstract
{
    public interface IContentState
    {
        public UserControl GetUserControl();
        public void CloseContent();
        public string GetNameContent();
    }
}
