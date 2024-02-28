using FinanceTrack.Classes;
using FinanceTrack.DataLayer.PatrialModels.Abstract;
using System.ComponentModel;

namespace FinanceTrack.CustomTools
{
    public class ItemComboBox : ComboBox
    {
        [Category("Data")]
        [Description("Указывает нужный тип данных, который будет хранить ComboBox.")]
        [TypeConverter(typeof(ItemTypeConverter))] // Используем кастомный класс-конвертер для выбора типа данных
        /// <summary>
        /// Открыт только для дизайнера, во время выполнения кода НЕ МЕНЯТЬ.
        /// Для просмотра типа исспользуйте <see cref="GetTypeItem"/>
        /// </summary>
        public Type TypeItem { get; set; }

        [Description("ЗАБЛОКИРОВАН, т.к. порядок не должен меняться при выводе списком.")]
        public new bool Sorted
        {
            get { return base.Sorted; }
            set
            {
                throw new InvalidOperationException("Изменение свойства Sorted заблокировано.");
            }
        }

        private List<ISimpleItem> _items;
        private List<SimpleItem> _simpleItem;

        private bool _usingNoname = true;
        /// <summary>
        /// Програмно ли менялся индекс? Использует только в реализации <<see cref="ItemComboBox"/>(FillItems и Selected)
        /// </summary>
        public bool IsProgramingIndexChanged { get; private set; }
        private bool _isFirstIndexChanged;

        private const string NONE_NAME = "<НЕ ЗАДАНО>";

        public ItemComboBox()
        {
            base.Sorted = false;

            TypeItem = SimpleItem.TypesForConverter[0]; // Использвуется вместо [DefaultValue] так как оно для Type не робит
            SelectedIndexChanged += _icbActs_SelectedIndexChanged;
        }

        private void SetProgramingIndexChanged()
        {
            IsProgramingIndexChanged = true;
            _isFirstIndexChanged = true;
        }

        private void _icbActs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsProgramingIndexChanged)
            {
                if (_isFirstIndexChanged)
                    _isFirstIndexChanged = false;
                else
                    IsProgramingIndexChanged = false;
            }
        }

        /// <summary>
        /// Метод для правильного заполнения ComboBox imem-мами.
        /// </summary>
        /// <param name="useNoname">Нужно ли использовать <see cref="NONE_NAME"/></param>
        private void FillingComboBoxItems(bool useNoname)
        {
            List<string> correctArray = new();
            if (useNoname)
                correctArray.Add(NONE_NAME);
            correctArray.AddRange(_simpleItem.Select(x => x.Name.Trim()));

            Items.Clear();
            Items.AddRange(correctArray.ToArray());

            _usingNoname = useNoname;
        }

        /// <summary>
        /// Врщвращает выбраный Item из ComboBox заполненный <see cref="FillingComboBoxItems"/>
        /// </summary>
        /// <returns>Выбранный item или если не нашел, то <see cref="null"/></returns>
        private SimpleItem GetItemsFromComboBox()
        {
            string selectItem = Text.Trim();

            if (selectItem == NONE_NAME || string.IsNullOrWhiteSpace(selectItem))
                return null;

            var result = _simpleItem.Where(x => x.Name.Trim() == selectItem);
            if (!result.Any())
                return null;

            return result.FirstOrDefault();
        }

        private int? GetIndex()
        {
            return SelectedIndex - (_usingNoname ? 1 : 0) < 0
                ? null
                : SelectedIndex - (_usingNoname ? 1 : 0);
        }

        /// <summary>
        /// Ищет индекс элемента comboBox по id <see cref="SimpleItem"/>
        /// </summary>
        /// <param name="id">id искомого элемента</param>
        /// <returns>Возвращяет индекс найденного элемента в порядке списка comboBox (если не найден то возвращает -1)</returns>
        private int FindIndex(int id)
        {
            SimpleItem simpleItem = FindItem(id);

            if (simpleItem == null)
                return -1;

            for (int i = 0; i < _simpleItem.Count; i++)
            {
                if (_simpleItem[i] == simpleItem)
                    return i + (_usingNoname ? 1 : 0);
            }

            return -1;
        }

        private SimpleItem FindItem(int id)
        {
            if (id == -1)
                return null;

            return _simpleItem.FirstOrDefault(x => x.Id == id);
        }

        private void FillingObjectInItems<T>(List<T> items)
        {
            _items = new List<ISimpleItem>();
            foreach (var item in items)
                _items.Add((ISimpleItem)item);
        }

        #region API

        /// <summary>
        /// Заполнение comboBox элементами указанных в <see cref="TypeItem"/> 
        /// </summary>
        /// <typeparam name="T">Любой тип из списка <see cref="SimpleItem.TypesForConverter"/></typeparam>
        /// <param name="items">Список для заполнения комбо бокса</param>
        public void FillItems<T>(List<T> items, bool useNoname = true)
        {
            FillItems(items, -1, useNoname);
        }

        /// <summary>
        /// Заполнение comboBox элементами указанных в <see cref="TypeItem"/> 
        /// </summary>
        /// <typeparam name="T">Любой тип из списка <see cref="SimpleItem.TypesForConverter"/></typeparam>
        /// <param name="items">Список для заполнения комбо бокса</param>
        /// <param name="selected">Текст элемента которого нужно выбрать</param>
        public void FillItems<T>(List<T> items, string selected, bool useNoname = true)
        {
            if (items == null || items.Count == 0)
                return;

            if (typeof(T) != TypeItem)
                throw new InvalidCastException();

            FillingObjectInItems(items);

            _simpleItem = SimpleItem.ToSimpleItem(_items);

            FillingComboBoxItems(useNoname);

            Selected(selected);
        }

        /// <summary>
        /// Заполнение comboBox элементами указанных в <see cref="TypeItem"/> 
        /// </summary>
        /// <typeparam name="T">Любой тип из списка <see cref="SimpleItem.TypesForConverter"/></typeparam>
        /// <param name="items">Список для заполнения комбо бокса</param>
        /// <param name="id">Id из <see cref="SimpleItem.Id"/> элемента для выбора (-1 выберет <see cref="NONE_NAME"/>) (смотреть подробную генерацию для вашего типа в <see cref="SimpleItem"/>)</param>
        /// <param name="useNoname">Нужно ли использовать <see cref="NONE_NAME"/></param>
        public void FillItems<T>(List<T> items, int id, bool useNoname = true)
        {
            if (items == null || items.Count == 0)
                return;

            if (typeof(T) != TypeItem)
                throw new InvalidCastException();

            FillingObjectInItems(items);
            _simpleItem = SimpleItem.ToSimpleItem(_items);

            FillingComboBoxItems(useNoname);

            Selected(id);
        }

        /// <summary>
        /// Возвращяет выбранный item установленного типа в <see cref="TypeItem"/>
        /// </summary>
        /// <returns>Выбранный item (если 'НЕ ВЫБРАННО' то null)</returns>
        public object GetSelectedItem()
        {
            int? index = GetIndex();
            if (index == null)
                return null;

            return _items[index ?? 0];
        }

        /// <summary>
        /// Возвращяет выбранный item установленного типа в <see cref="TypeItem"/>
        /// </summary>
        /// <typeparam name="T">Тип указанный в <see cref="TypeItem"/></typeparam>
        /// <returns>Выбранный item (если 'НЕ ВЫБРАННО' то null)</returns>
        public T GetItem<T>() where T : class
        {
            int? index = GetIndex();
            if (index == null)
                return null;

            return (T)_items[index ?? 0];
        }

        /// <summary>
        /// Возвращяет все item установленного типа в <see cref="TypeItem"/> (кроме НЕ ЗАДАННО)
        /// </summary>
        /// <typeparam name="T">Тип указанный в <see cref="TypeItem"/></typeparam>
        public List<T> GetItems<T>() where T : class
        {
            if (_items == null || _items.Count == 0)
                return null;

            return _items.Cast<T>().ToList();
        }

        /// <summary>
        /// Выбирает в comboBox элемент по имени
        /// </summary>
        /// <param name="selected">Текст строки</param>
        public void Selected(string selected)
        {
            SetProgramingIndexChanged();

            if (selected.IsNullOrWhiteSpace())
            {
                SelectedIndex = 0;
                return;
            }

            selected = selected.Trim();
            int index = FindString(selected);
            SelectedIndex = index == -1 ? 0 : index;
        }

        /// <summary>
        /// Выбирает в comboBox элемент по его ID класса <see cref="TypeItem"/> (-1 - не заданно \ первый элемент)
        /// </summary>
        /// <param name="selected"></param>
        public void Selected(int id)
        {
            SetProgramingIndexChanged();

            if (id == -1)
            {
                SelectedIndex = 0;
                return;
            }

            int index = FindIndex(id);
            SelectedIndex = index == -1 ? 0 : index;
        }

        /// <summary>
        /// Возвращает тип для этого comboBox их <see cref="TypeItem"/>
        /// </summary>
        /// <returns>Тип comboBox</returns>
        public Type GetTypeItem()
        {
            return TypeItem;
        }

        public void BaseValue()
        {
            if (_simpleItem == null)
                SelectedIndex = -1;
            else
                SelectedIndex = 0;
        }

        /// <summary>
        /// Очищает список внутренних объектов и из списка выбора
        /// </summary>
        public void Clear()
        {
            _items?.Clear();
            Items.Clear();
        }

        #endregion
    }

    internal class ItemTypeConverter : CustomTypeConverter
    {
        public ItemTypeConverter()
        {
            standardTypes = SimpleItem.TypesForConverter;
        }
    }
}