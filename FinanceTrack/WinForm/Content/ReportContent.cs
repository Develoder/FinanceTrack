using FinanceTrack.DataLayer;
using FinanceTrack.WinForm.Content.Abstract;
using FinanceTrack.WinForm.Content.Control;
using FinanceTrack.WinForm.Content.Control.Report.Abstract;

namespace FinanceTrack.WinForm.Content
{
    public class ReportContent : IContentState
    {
        private IContentControlStrategy _contentControl;
        public string GetNameContent() => _reportStrategy.GetNameReport();

        private User _user;
        private IReportStrategy _reportStrategy;

        public ReportContent(User user, IReportStrategy reportStrategy)
        {
            _user = user;
            _reportStrategy = reportStrategy;
        }

        public UserControl GetUserControl()
        {
            if (_contentControl == null)
            {
                _contentControl = new ReportControl(_user, _reportStrategy);
                _contentControl.LoadContent();
            }

            return (UserControl)_contentControl;
        }

        public void CloseContent()
        {

        }
    }
}
