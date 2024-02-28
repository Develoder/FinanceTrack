using FinanceTrack.WinForm.Content.Control;

namespace FinanceTrack.DataLayer
{
    public partial class Transaction
    {
        public decimal GetPayment()
        {
            return GetPayment(Category.Type);
        }

        public decimal GetPayment(bool type)
        {
            return type ? Amount : -Amount;
        }

        public object[] GetTransactionDataSources()
        {
            return new object[]
            {
                Category.Type ? TransactionControl.PLUS_IMAGE : TransactionControl.MINUS_IMAGE,
                Id,
                Amount,
                Category?.GetName().Trim() ?? string.Empty,
                Date.ToString("dd.MM.yy"),
                Description.Trim(),
                Account?.GetName() ?? string.Empty,
            };
        }
    }
}