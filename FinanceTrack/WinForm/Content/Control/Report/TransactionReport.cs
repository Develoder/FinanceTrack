using FinanceTrack.Classes;
using FinanceTrack.DataLayer;
using FinanceTrack.WinForm.Content.Control.Report.Abstract;
using Microsoft.EntityFrameworkCore;
using ScottPlot;

namespace FinanceTrack.WinForm.Content.Control.Report
{
    public class TransactionReport : IReportStrategy
    {
        public string GetNameReport()
        {
            DateTime dateStart = DateTime.Now.FirstDay();
            DateTime dateEnd = DateTime.Now.LastDay();
            return $"Транзакции за преиод {dateStart:dd.MM.yy} - {dateEnd:dd.MM.yy}";
        }

        public void LoadReport(Plot plot, User user)
        {
            using EntitiesContext db = new();

            DateTime dateStart = DateTime.Now.FirstDay();
            DateTime dateEnd = DateTime.Now.LastDay();

            var dateRange = Enumerable.Range(0, (dateEnd - dateStart).Days + 1)
                          .Select(offset => dateStart.AddDays(offset));

            Dictionary<DateTime, List<decimal>> consumptionPerDay = dateRange
                .GroupJoin
                    (
                        db.Transaction
                        .Include(x => x.Category)
                        .Where(x => x.UserId == user.Id && x.Date >= dateStart && x.Date <= dateEnd),
                        date => date,
                        transaction => new DateTime(transaction.Date.Year, transaction.Date.Month, transaction.Date.Day),
                        (date, transactions) => new { Date = date, Transactions = transactions.Select(x => x.GetPayment()).ToList() }
                    )
                .ToDictionary(x => x.Date, y => y.Transactions);

            List<OHLC> prices = consumptionPerDay
                .Select(x => new OHLC()
                {
                    DateTime = x.Key,
                    Close = (double)x.Value.Sum(),
                    TimeSpan = TimeSpan.FromDays(1.0)
                })
                .ToList();

            var candlePlot = plot.Add.Candlestick(prices);
            plot.Axes.DateTimeTicksBottom();
        }
    }
}
