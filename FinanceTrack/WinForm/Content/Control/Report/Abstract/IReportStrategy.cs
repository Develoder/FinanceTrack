using FinanceTrack.DataLayer;
using ScottPlot;

namespace FinanceTrack.WinForm.Content.Control.Report.Abstract
{
    public interface IReportStrategy
    {
        public string GetNameReport();
        public void LoadReport(Plot plot, User user);
    }
}
