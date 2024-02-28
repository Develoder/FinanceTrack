using FinanceTrack.DataLayer.PatrialModels.Abstract;

namespace FinanceTrack.DataLayer
{
    public partial class Account : ISimpleItem
    {
        public long GetId()
        {
            return Id;
        }

        public string GetName()
        {
            string name = string.Empty;

            name += $"{Name.Trim()}";

            if (Type != null)
                name += $" ({Type.Name.Trim()})";
            
            return name;
        }

        public object[] GetAccountDataSources()
        {
            return new object[]
            {
                Id,
                Type?.Name.Trim() ?? string.Empty,
                Name.Trim(),
                Balance.ToString(),
            };
        }
    }
}