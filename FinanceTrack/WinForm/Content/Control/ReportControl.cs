using FinanceTrack.DataLayer;
using FinanceTrack.WinForm.Content.Abstract;
using FinanceTrack.WinForm.Content.Control.Report.Abstract;

namespace FinanceTrack.WinForm.Content.Control
{
    public partial class ReportControl : UserControl, IContentControlStrategy
    {
        private User _user;
        private IReportStrategy _reportStrategy;

        public ReportControl(User user, IReportStrategy reportStrategy)
        {
            InitializeComponent();

            _user = user;
            _reportStrategy = reportStrategy;
        }

        public void LoadContent()
        {
            _reportStrategy.LoadReport(formsPlot1.Plot, _user);
        }

        public void CloseContent()
        {

        }
    }
}
