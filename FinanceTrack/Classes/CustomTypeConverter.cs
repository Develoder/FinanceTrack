using System.ComponentModel;

namespace FinanceTrack
{
    public class CustomTypeConverter : TypeConverter
    {
        protected Type[] standardTypes;

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            if (value is string)
            {
                string typeName = (string)value;
                Type type = standardTypes.FirstOrDefault(t => t.Name == typeName); // Используем standardTypes для поиска типа по имени
                if (type != null)
                {
                    return type;
                }
            }
            return base.ConvertFrom(context, culture, value);
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string) && value is Type)
            {
                Type type = (Type)value;
                return type.Name;
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }

        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            // Возвращаем коллекцию с возможными значениями (типами данных)
            return new StandardValuesCollection(standardTypes);
        }

        public override bool GetStandardValuesSupported(ITypeDescriptorContext context) => true;

        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) => true; // Устанавливаем значение true, чтобы выбирать только из списка значений
    }

}

