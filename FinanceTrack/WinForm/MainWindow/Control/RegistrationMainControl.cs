using FinanceTrack.DataLayer;
using FinanceTrack.WinForm.MainWindow.Abstract;

namespace FinanceTrack.WinForm.MainWindow.Control
{
    public partial class RegistrationMainControl : UserControl, IControlStrategy
    {
        public RegistrationMainControl()
        {
            InitializeComponent();
        }

        private void Registration()
        {
            if (!Validation())
                return;

            User user = CreateUser();

            LoginMainControl.SaveLoginParametr(user.Id);
            IMainState.ChangedPrimary(new ManagerMainWindow(user));
        }

        private User CreateUser()
        {
            User user = new();

            user.Name = tbLogin.Text.Trim();
            user.Password = User.GetHashPassword(tbPassword.Text.Trim());

            using EntitiesContext db = new();

            db.User.Add(user);

            db.SaveChanges();

            return user;
        }

        private bool Validation()
        {
            bool isValideLogin = LoginValidation();
            bool isValidePassword = PasswordValidation();
            bool isValideRepitPassword = RepitPasswordValidation();

            return isValideLogin && isValidePassword && isValideRepitPassword;
        }

        private bool LoginValidation()
        {
            string warnig;
            bool isValide = User.ValidationLogin(tbLogin.Text, out warnig);

            labelWarningLogin.Text = warnig;
            labelWarningLogin.Visible = isValide;

            return isValide;
        }

        private bool PasswordValidation()
        {
            string warnig;
            bool isValide = User.ValidationPassword(tbPassword.Text, out warnig);

            labelWarningPassword.Text = warnig;
            labelWarningPassword.Visible = isValide;

            return isValide;
        }

        private bool RepitPasswordValidation()
        {
            string warnig;
            bool isValide = User.ValidationRepitPassword(tbPassword.Text, tbRepitPassword.Text, out warnig);

            labelWarningRepitPassword.Text = warnig;
            labelWarningRepitPassword.Visible = isValide;

            return isValide;
        }

        public void LoadContent()
        {
            tbLogin.Text = string.Empty;
            tbPassword.Text = string.Empty;
            tbRepitPassword.Text = string.Empty;
            labelWarningLogin.Text = string.Empty;
            labelWarningPassword.Text = string.Empty;
            labelWarningRepitPassword.Text = string.Empty;
        }

        public void CloseContent()
        {

        }

        #region Events

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Registration();
        }

        private void llLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IMainState.ChangedPrimary(new LoginMainWindow());
        }

        private void tpPassword_TextChanged(object sender, EventArgs e)
        {
            RepitPasswordValidation();
        }

        private void tbRepitPassword_TextChanged(object sender, EventArgs e)
        {
            PasswordValidation();
        }

        private void tbLogin_Leave(object sender, EventArgs e)
        {
            LoginValidation();
        }

        public void PressEnter()
        {
            Registration();
        }
    }
    #endregion
}
