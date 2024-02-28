using FinanceTrack.DataLayer;
using FinanceTrack.WinForm.MainWindow.Abstract;
using Microsoft.Win32;

namespace FinanceTrack.WinForm.MainWindow.Control
{
    public partial class LoginMainControl : UserControl, IControlStrategy
    {
        private const string REGISTRY_PATH = "FinanceTrack";
        private const string USER_ID = "UserId";

        public LoginMainControl()
        {
            InitializeComponent();
        }

        public void CloseContent()
        {

        }

        public void LoadContent()
        {
            using EntitiesContext db = new();

            List<User> users = db.User.ToList();

            tpPassword.Text = string.Empty;
            labelWarningLogin.Text = string.Empty;
            labelWarningPassword.Text = string.Empty;

            bool hasParametr = LoadLastLoginParametr(out int userId);
            if (hasParametr)
            {
                icbUser.FillItems(users, userId, false);
            }
            else
            {
                icbUser.FillItems(users, false);
            }
        }

        private void Login()
        {
            var user = icbUser.GetItem<User>();

            if (user == null)
            {
                labelWarningLogin.Text = "Не выбран пользователь";
                icbUser.Focus();
                return;
            }

            if (user.Password.Trim() != User.GetHashPassword(tpPassword.Text.Trim()))
            {
                labelWarningPassword.Text = "Не верный пароль";
                tpPassword.Text = string.Empty;
                tpPassword.Focus();
                return;
            }

            SaveLoginParametr(user.Id);
            IMainState.ChangedPrimary(new ManagerMainWindow(user));
        }

        public static bool LoadLastLoginParametr(out int userId)
        {
            using RegistryKey key = Registry.CurrentUser.OpenSubKey(REGISTRY_PATH);
            if (key != null)
            {
                // Получаем значения из реестра
                string storedUserId = key.GetValue(USER_ID).ToString();

                bool tryParseUserId = int.TryParse(storedUserId, out userId);

                return tryParseUserId;
            }
            else
            {
                userId = -1;
                return false;
            }
        }

        public static void SaveLoginParametr(int userId)
        {
            try
            {
                using RegistryKey key = Registry.CurrentUser.CreateSubKey(REGISTRY_PATH);
                key.SetValue(USER_ID, userId);
            }
            catch (Exception ex)
            {

            }
        }

        #region Events

        private void button1_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void llRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IMainState.ChangedPrimary(new RegistrationMainWindow());
        }

        public void PressEnter()
        {
            Login();
        }
    }
        #endregion
}
