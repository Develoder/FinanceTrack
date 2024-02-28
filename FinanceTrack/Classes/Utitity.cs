
namespace FinanceTrack.Classes
{
    public static class Utitity
    {
        /// <summary>
        /// Проверяет, является ли строка null, пустой или состоящей только из пробелов
        /// </summary>
        /// <param name="input">Строка для проверки</param>
        /// <returns>true если строка пуста</returns>
        public static bool IsNullOrWhiteSpace(this string? input)
        {
            return string.IsNullOrWhiteSpace(input);
        }

        public static DateTime FirstDay(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, 1);
        }

        public static DateTime LastDay(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, 1, 23, 59, 59).AddMonths(1).AddDays(-1);
        }
    }
}
