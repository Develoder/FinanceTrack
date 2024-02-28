using FinanceTrack.Classes;
using FinanceTrack.DataLayer;
using FinanceTrack.WinForm.Content.Control.Report.Abstract;
using Microsoft.EntityFrameworkCore;
using ScottPlot;

namespace FinanceTrack.WinForm.Content.Control.Report
{
    public class CategoryReport : IReportStrategy
    {
        public string GetNameReport()
        {
            DateTime dateStart = DateTime.Now.FirstDay();
            DateTime dateEnd = DateTime.Now.LastDay();
            return $"Расходы по категориям за преиод {dateStart:dd.MM.yy} - {dateEnd:dd.MM.yy}";
        }

        public void LoadReport(Plot plot, User user)
        {
            using EntitiesContext db = new();

            DateTime dateStart = DateTime.Now.FirstDay();
            DateTime dateEnd = DateTime.Now.LastDay();

            Dictionary<string, decimal> consumptionByCategory = db.Transaction
                .Include(x => x.Category)
                .Where(x => !x.Category.Type
                         && x.UserId == user.Id
                         && x.Date >= dateStart && x.Date <= dateEnd)
                .GroupBy(x => x.Category.Name)
                .ToDictionary(x => x.Key, y => y.Select(z => z.Amount).Sum());

            List<PieSlice> slices = consumptionByCategory.Select
                (
                 x => new PieSlice()
                 {
                     Value = (double)x.Value,
                     FillColor = Generate.RandomColor(),
                     Label = $"{x.Key.Trim()} - {x.Value:#,##0.##} ₽"
                 }
                )
                .ToList();

            var pie = plot.Add.Pie(slices);
            pie.ShowSliceLabels = true;
            pie.ExplodeFraction = 0.1d;

            plot.HideGrid();
            plot.Layout.Frameless();
            plot.ScaleFactor = 1.2f;

            plot.Style.Background(ScottPlot.Color.FromHex("#000000"), ScottPlot.Color.FromHex("#f0f0f0"));
        }
    }
}
