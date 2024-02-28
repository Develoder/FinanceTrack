using FinanceTrack.DataLayer;
using FinanceTrack.DataLayer.PatrialModels.Abstract;

namespace FinanceTrack
{
	public class SimpleItem
	{
		// Тип должен реализовавыть ISimpleItem
		public readonly static Type[] TypesForConverter = new Type[]
		{
			typeof(User),
			typeof(Account),
			typeof(CategoryTransaction),
			typeof(TypeAccount),
		};

		public long Id { get; set; }
		public string Name { get; set; }

		public SimpleItem(long id, string name)
		{
			Id = id;
			Name = name;
		}

        public static SimpleItem ToSimpleItem(ISimpleItem simpleItem)
        {
            if (simpleItem == null)
                return null;

            return new SimpleItem(simpleItem.GetId(), simpleItem.GetName());
        }

        public static List<SimpleItem> ToSimpleItem(List<ISimpleItem> simpleItems)
        {
            if (simpleItems.Count == 0)
                return new List<SimpleItem>();

            var items = new List<SimpleItem>();
            items.AddRange(simpleItems.Select(x => ToSimpleItem(x)).ToList());
            return items;
        }
    }
}
