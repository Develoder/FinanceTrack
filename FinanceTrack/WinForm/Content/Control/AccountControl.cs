using FinanceTrack.Classes;
using FinanceTrack.DataLayer;
using FinanceTrack.Enums;
using FinanceTrack.WinForm.Content.Abstract;
using FinanceTrack.WinForm.MainWindow.Control;
using Microsoft.EntityFrameworkCore;

namespace FinanceTrack.WinForm.Content.CntentItem
{
    public partial class AccountControl : UserControl, IContentControlStrategy
    {
        private User _user;
        private List<Account> _accounts;
        private List<TypeAccount> _typeAccounts;

        private StateOperation _stateOperation = StateOperation.Read;

        public AccountControl(User user)
        {
            InitializeComponent();
            _user = user;
        }

        public void CloseContent()
        {

        }

        public void LoadContent()
        {
            LoadData();
            UpdateStateForm();
        }

        private void LoadData()
        {
            using EntitiesContext db = new();

            _accounts = db.Account
                .Include(x => x.Type)
                .Where(x => x.UserId == _user.Id)
                .ToList();

            _typeAccounts = db.TypeAccount
                .OrderBy(x => x.Order)
                .ToList();

            icbTypeAccount.FillItems(_typeAccounts, false);

            UpdateDateGrid();
        }

        private void UpdateDateGrid()
        {
            dgvcAccount.Rows.Clear();

            foreach (Account account in _accounts)
            {
                InsertDataGrid(account, 0);
            }
        }

        private void InsertDataGrid(Account account, int index)
        {
            DataGridViewRow row = GetNewRow();

            object[] data = account.GetAccountDataSources();

            for (int i = 0; i < data.Length; i++)
            {
                row.Cells[i].Value = data[i];
            }

            if (!dgvcAccount.Rows.Contains(row))
                dgvcAccount.Rows.Insert(index, row);
        }

        private DataGridViewRow GetNewRow()
        {
            DataGridViewRow row;
            if (dgvcAccount.Rows.Count > 0)
            {
                row = (DataGridViewRow)dgvcAccount.Rows[0].Clone();
            }
            else
            {
                int id = dgvcAccount.Rows.Add();
                row = dgvcAccount.Rows[id];
            }

            return row;
        }

        private bool SaveAccount()
        {
            if (!Verification())
                return false;

            bool isAplay = false;
            if (_stateOperation == StateOperation.Create)
            {
                isAplay = CreateAccount();
            }
            else if (_stateOperation == StateOperation.Edit)
            {
                isAplay = UpdateAccount();
            }

            if (!isAplay)
                return false;

            ManagerMainControl.Instance.UpdateAccount();
            UpdateDateGrid();

            return true;
        }

        private bool CreateAccount()
        {
            Account account = new();

            account.Balance = 0;
            account.TypeId = icbTypeAccount.GetItem<TypeAccount>().Id;
            account.Name = tbName.Text.Trim();
            account.UserId = _user.Id;

            using EntitiesContext db = new();
            try
            {
                db.Account.Add(account);

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка создания транзакции!");
                return false;
            }

            account.Type = icbTypeAccount.GetItem<TypeAccount>();
            _accounts.Add(account);

            return true;
        }

        private bool UpdateAccount()
        {
            Account curentAccount = GetCurrentAccount();

            if (curentAccount == null)
                return false;

            Account account;
            try
            {
                using EntitiesContext db = new();

                account = db.Account.FirstOrDefault(x => x.Id == curentAccount.Id);

                if (account == null)
                    return false;

                db.Account.Attach(account);

                account.TypeId = icbTypeAccount.GetItem<TypeAccount>().Id;
                account.Name = tbName.Text.Trim();

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка редактирования транзакции!");
                return false;
            }

            account.Type = icbTypeAccount.GetItem<TypeAccount>();

            int index = _accounts.IndexOf(curentAccount);
            _accounts.Remove(curentAccount);
            _accounts.Insert(index, account);

            return true;
        }

        private bool Verification()
        {
            if (tbName.Text.IsNullOrWhiteSpace())
            {
                MessageBox.Show("Описание должно быть заполненно");
                return false;
            }

            return true;
        }

        private void DeleteAccount()
        {
            Account curentAccount = GetCurrentAccount();

            if (curentAccount == null)
                return;

            using EntitiesContext db = new();

            Account? account = db.Account
                .Select(x => new Account { Id = x.Id} )
                .FirstOrDefault(x => x.Id == curentAccount.Id);

            List<Transaction> transactions = db.Transaction
                .Where(x => x.AccountId == curentAccount.Id)
                .Select(x => new Transaction { Id = x.Id })
                .ToList();

            if (account == null)
                return;

            if (transactions != null || transactions.Count > 0)
            {
                db.Transaction.RemoveRange(transactions);
            }

            db.Account.Remove(account);

            db.SaveChanges();

            _accounts.Remove(curentAccount);

            ManagerMainControl.Instance.UpdateBalance();
            UpdateDateGrid();
        }

        private void UpdateStateForm()
        {
            switch (_stateOperation)
            {
                case StateOperation.Read:
                    tlpEdit.Visible = false;
                    dgvcAccount.Enabled = true;
                    tlpEditDataGrid.Visible = true;
                    break;

                case StateOperation.Edit:
                    tlpEdit.Visible = true;
                    dgvcAccount.Enabled = false;
                    tlpEditDataGrid.Visible = false;
                    icbTypeAccount.Focus();
                    break;

                case StateOperation.Create:
                    tlpEdit.Visible = true;
                    dgvcAccount.Enabled = false;
                    tlpEditDataGrid.Visible = false;
                    icbTypeAccount.Focus();
                    break;
            }
        }

        private void UpdateEditPanel()
        {
            switch (_stateOperation)
            {
                case StateOperation.Create:
                    tbName.Text = string.Empty;
                    icbTypeAccount.Selected(0);
                    buttonAddNext.Visible = true;
                    break;

                case StateOperation.Edit:
                    tbName.Text = GetCurrentAccount().Name.Trim();
                    icbTypeAccount.Selected(GetCurrentAccount().Id);
                    buttonAddNext.Visible = false;
                    break;
            }
        }

        private Account GetCurrentAccount()
        {
            int id = (int)dgvcAccount.Rows[dgvcAccount.CurrentCell.RowIndex].Cells[0].Value;
            return _accounts.FirstOrDefault(x => x.Id == id);
        }

        private void AddTransaction()
        {
            _stateOperation = StateOperation.Create;
            UpdateStateForm();
            UpdateEditPanel();
        }

        private void EditTransaction()
        {
            _stateOperation = StateOperation.Edit;
            UpdateStateForm();
            UpdateEditPanel();
        }

        #region Events

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddTransaction();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditTransaction();
        }

        private void buttonDeleted_Click(object sender, EventArgs e)
        {
            string title = "Удаление счета";
            string caption = "Вы действительно хотите удалить выбранный счет со всеми транзакциями?";
            DialogResult result = MessageBox.Show(title, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DeleteAccount();
            }
        }

        private void buttonAddNext_Click(object sender, EventArgs e)
        {
            if (SaveAccount())
                AddTransaction();
        }

        private void buttonComplite_Click(object sender, EventArgs e)
        {
            if (SaveAccount())
            {
                _stateOperation = StateOperation.Read;
                UpdateStateForm();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            _stateOperation = StateOperation.Read;
            UpdateStateForm();
        }
    }
    #endregion
}
