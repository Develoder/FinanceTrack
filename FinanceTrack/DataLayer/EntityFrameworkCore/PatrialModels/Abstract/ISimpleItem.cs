namespace FinanceTrack.DataLayer.PatrialModels.Abstract
{
    /// <summary>
    /// Класс создан для каждой модели для обращения к любой из них по интрефейсу
    /// </summary>
    public interface ISimpleItem
    {
        public long GetId();

        /// <summary>
        /// Выводит имя объекта
        /// </summary>
        /// <returns></returns>
        public string GetName();
    }
}
