using FinanceTrack.DataLayer.PatrialModels.Abstract;

namespace FinanceTrack.DataLayer
{
    public partial class TypeAccount : ISimpleItem
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