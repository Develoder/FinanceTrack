using FinanceTrack.DataLayer.PatrialModels.Abstract;

namespace FinanceTrack.DataLayer
{
    public partial class CategoryTransaction : ISimpleItem
    {
        public long GetId()
        {
            return Id;
        }

        public string GetName()
        {
            return Name;
        }
    }
}