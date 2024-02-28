using FinanceTrack.Classes;
using FinanceTrack.DataLayer.PatrialModels.Abstract;
using System.Security.Cryptography;
using System.Text;

namespace FinanceTrack.DataLayer
{
    public partial class User : ISimpleItem
    {
        public long GetId()
        {
            return Id;
        }

        public string GetName()
        {
            return Name;
        }

        public static bool ValidationLogin(string login, out string warning)
        {
            login = login.Trim();
            if (login.IsNullOrWhiteSpace())
            {
                warning = "Логин не заполнен";
                return false;
            }

            if (login.Length < 3 || login.Length > 20)
            {
                warning = "Логин не должен быть меньше 3 и больше 20 символов";
                return false;
            }

            using EntitiesContext db = new();

            bool hasLoginName = db.User
                .Where(x => x.Name.Trim() == login)
                .Any();

            if (hasLoginName)
            {
                warning = "Придумайте другой логин";
                return false;
            }

            warning = string.Empty;
            return true;
        }

        public static bool ValidationPassword(string password, out string warning)
        {
            password = password.Trim();
            if (password.IsNullOrWhiteSpace())
            {
                warning = "Парль не заполнен";
                return false;
            }

            if (password.Length < 6 || password.Length > 20)
            {
                warning = "Пароль не должен быть меньше 3 и больше 20 символов";
                return false;
            }

            warning = string.Empty;
            return true;
        }

        public static bool ValidationRepitPassword(string password, string repitPassword, out string warning)
        {
            if (repitPassword.IsNullOrWhiteSpace())
            {
                warning = "Парль не заполнен";
                return false;
            }

            if (password.Trim() != repitPassword.Trim())
            {
                warning = "Пароль не совпадает";
                return false;
            }

            warning = string.Empty;
            return true;
        }

        /// <summary>
        /// Возвращает зашиврованный хэш (используется для записи пароля)
        /// </summary>
        public static string GetHashPassword(string input)
        {
            var hash = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(input.ToCharArray()));
            StringBuilder sb = new();
            for (int i = 0; i < hash.Length; i++)
                sb.Append(hash[i].ToString("x2"));
            return sb.ToString().Trim();
        }
    }
}