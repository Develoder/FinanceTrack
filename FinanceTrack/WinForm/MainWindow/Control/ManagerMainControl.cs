using FinanceTrack.DataLayer;
using FinanceTrack.WinForm.Content;
using FinanceTrack.WinForm.Content.Abstract;
using FinanceTrack.WinForm.Content.Control.Report;
using FinanceTrack.WinForm.Content.Control.Report.Abstract;
using FinanceTrack.WinForm.MainWindow.Abstract;
using Microsoft.EntityFrameworkCore;

namespace FinanceTrack.WinForm.MainWindow.Control
{
    public partial class ManagerMainControl : UserControl, IControlStrategy
    {
        private IContentState _curentContentItem;
        private User _user;
        private List<Account> _accounts;

        public static ManagerMainControl Instance;

        public ManagerMainControl(User user)
        {
            InitializeComponent();

            Instance = this;
            _user = user;
        }

        public void CloseContent()
        {

        }

        public void LoadContent()
        {
            labelUserName.Text = _user.Name.Trim();

            UpdateBalance();

            HomeContent homeContent = new(_accounts);
            SetContent(homeContent);
        }

        private void SetContent(IContentState contentItem)
        {
            if (_curentContentItem != null)
            {
                panelContent.Controls.Remove(_curentContentItem.GetUserControl());
                _curentContentItem.CloseContent();
            }

            _curentContentItem = contentItem;

            labelHeader.Text = _curentContentItem.GetNameContent();

            UserControl userControl = _curentContentItem.GetUserControl();
            panelContent.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }

        public void UpdateBalance()
        {
            UpdateAccount();

            using EntitiesContext db = new();

            if (_accounts == null)
            {
                labelBalance.Text = "Нет счетов";
                return;
            }

            decimal balance = _accounts.Sum(x => x.Balance);

            labelBalance.Text = $"{balance:#,##0.##} ₽";
        }

        public void UpdateAccount()
        {
            using EntitiesContext db = new();

            _accounts = db.Account
                .Include(x => x.Type)
                .Where(x => x.UserId == _user.Id)
                .ToList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cpReport.ExecuteCollapse();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            cpMenu.ExecuteCollapse();
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            AccountContent cardContent = new(_user);
            SetContent(cardContent);
        }

        private void MainPrimaryControl_Load(object sender, EventArgs e)
        {
            cpReport.InicializationStartParametrs();
            cpMenu.InicializationStartParametrs();
        }

        public void PressEnter()
        {

        }

        private void buttonTransaction_Click(object sender, EventArgs e)
        {
            TransactionContent transactionContent = new(_user, _accounts);
            SetContent(transactionContent);
        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            HomeContent homeContent = new(_accounts);
            SetContent(homeContent);
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            ProfileContent profileContent = new(_user);
            SetContent(profileContent);
        }

        private void buttonReportMonth_Click(object sender, EventArgs e)
        {
            IReportStrategy reportStrategy = new TransactionReport();
            ReportContent reportContent = new(_user, reportStrategy);
            SetContent(reportContent);
        }

        private void buttonReportCategory_Click(object sender, EventArgs e)
        {
            IReportStrategy reportStrategy = new CategoryReport();
            ReportContent reportContent = new(_user, reportStrategy);
            SetContent(reportContent);
        }
    }
}
