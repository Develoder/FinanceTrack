using FinanceTrack.DataLayer;
using FinanceTrack.Enums;
using FinanceTrack.WinForm.Content.Abstract;
using FinanceTrack.WinForm.MainWindow.Control;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace FinanceTrack.WinForm.Content.Control
{
    public partial class TransactionControl : UserControl, IContentControlStrategy
    {
        public readonly static Bitmap MINUS_IMAGE = Properties.Resources.minus_16;
        public readonly static Bitmap PLUS_IMAGE = Properties.Resources.plus_16;
        public const string MINUS_TEXT = "Расход";
        public const string PLUS_TEXT = "Доход";

        /// <summary>
        /// true - доход, false - расход
        /// </summary>
        private bool _currentTypeButton = false;

        private User _user;
        private List<Account> _accounts;

        private List<CategoryTransaction> _categoryTransactions;
        private List<Transaction> _transactions;

        private StateOperation _stateOperation = StateOperation.Read;

        public TransactionControl(User user, List<Account> accounts)
        {
            InitializeComponent();
            _user = user;
            _accounts = accounts;
        }

        public void CloseContent()
        {

        }

        public void LoadContent()
        {
            if (_accounts == null || _accounts.Count <= 0)
            {
                Enabled = false;
                return;
            }

            LoadData();
            UpdateStateForm();
        }

        private void LoadData()
        {
            using EntitiesContext db = new();

            _transactions = db.Transaction
                .Include(x => x.Category)
                .Include(x => x.Account)
                    .ThenInclude(x => x.Type)
                .Where(x => x.UserId == _user.Id)
                .OrderBy(x => x.Date)
                .ToList();

            _categoryTransactions = db.CategoryTransaction
                .OrderBy(x => x.Order)
                .ToList();

            icbAccount.FillItems(_accounts, false);

            UpdateDateGrid();
        }

        private void UpdateDateGrid()
        {
            dgvcTransaction.Rows.Clear();

            foreach (Transaction transaction in _transactions)
            {
                InsertDataGrid(transaction, 0);
            }
        }

        private void InsertDataGrid(Transaction transaction, int index)
        {
            DataGridViewRow row = GetNewRow();

            object[] data = transaction.GetTransactionDataSources();

            for (int i = 0; i < data.Length; i++)
            {
                row.Cells[i].Value = data[i];
            }

            if (!dgvcTransaction.Rows.Contains(row))
                dgvcTransaction.Rows.Insert(index, row);
        }

        private DataGridViewRow GetNewRow()
        {
            DataGridViewRow row;
            if (dgvcTransaction.Rows.Count > 0)
            {
                row = (DataGridViewRow)dgvcTransaction.Rows[0].Clone();
            }
            else
            {
                int id = dgvcTransaction.Rows.Add();
                row = dgvcTransaction.Rows[id];
            }

            return row;
        }

        private void DeleteTransaction()
        {
            Transaction curretnTransaction = GetCurrentTransaction();

            if (curretnTransaction == null)
                return;

            using EntitiesContext db = new();

            Account account = db.Account.FirstOrDefault(x => x.Id == curretnTransaction.AccountId);
            Transaction transaction = db.Transaction.FirstOrDefault(x => x.Id == curretnTransaction.Id);

            if (transaction == null || account == null)
                return;

            account.Balance -= transaction.GetPayment();

            db.Transaction.Remove(transaction);

            db.SaveChanges();

            _transactions.Remove(curretnTransaction);

            UpdateDateGrid();
            ManagerMainControl.Instance.UpdateBalance();
        }

        private void UpdateStateForm()
        {
            switch (_stateOperation)
            {
                case StateOperation.Read:
                    tlpEdit.Visible = false;
                    dgvcTransaction.Enabled = true;
                    tlpEditDataGrid.Visible = true;
                    break;

                case StateOperation.Edit:
                    tlpEdit.Visible = true;
                    dgvcTransaction.Enabled = false;
                    tlpEditDataGrid.Visible = false;
                    buttonType.Focus();
                    break;

                case StateOperation.Create:
                    tlpEdit.Visible = true;
                    dgvcTransaction.Enabled = false;
                    tlpEditDataGrid.Visible = false;
                    buttonType.Focus();
                    break;
            }
        }

        private void UpdateEditPanel()
        {
            switch (_stateOperation)
            {
                case StateOperation.Create:
                    _currentTypeButton = false;
                    nbcAmount.Clear();
                    dtpDate.Value = DateTime.Now;
                    tbDescription.Text = string.Empty;
                    icbAccount.Selected(0);
                    buttonAddNext.Visible = true;
                    break;

                case StateOperation.Edit:
                    _currentTypeButton = GetCurrentTransaction().Category.Type;
                    nbcAmount.SetValue(GetCurrentTransaction().Amount);
                    dtpDate.Value = GetCurrentTransaction().Date;
                    tbDescription.Text = GetCurrentTransaction().Description.Trim();
                    icbAccount.Selected(GetCurrentTransaction().Id);
                    buttonAddNext.Visible = false;
                    break;
            }

            UpdateButtonType();
        }

        private void UpdateButtonType()
        {
            buttonType.Text = _currentTypeButton ? PLUS_TEXT : MINUS_TEXT;
            buttonType.Image = _currentTypeButton ? PLUS_IMAGE : MINUS_IMAGE;

            List<CategoryTransaction> categoryTransactions = _categoryTransactions
                .Where(x => x.Type == _currentTypeButton)
                .ToList();

            icbCategory.FillItems(categoryTransactions, false);

            switch (_stateOperation)
            {
                case StateOperation.Create:
                    icbCategory.Selected(0);
                    break;

                case StateOperation.Edit:
                    icbCategory.Selected(GetCurrentTransaction().CategoryId);
                    break;
            }
        }

        private bool SaveTransaction()
        {
            if (!Verification())
                return false;

            bool isAplay = false;
            if (_stateOperation == StateOperation.Create)
            {
                isAplay = CreateTransaction();
            }
            else if (_stateOperation == StateOperation.Edit)
            {
                isAplay = UpdateTransaction();
            }

            if (!isAplay)
                return false;

            UpdateDateGrid();
            ManagerMainControl.Instance.UpdateBalance();

            return true;
        }

        private bool CreateTransaction()
        {
            Transaction transaction = new();

            try
            {
                using EntitiesContext db = new();

                Account account = db.Account.FirstOrDefault(x => x.Id == icbAccount.GetItem<Account>().Id);

                if (account == null)
                    return false;

                db.Account.Attach(account);

                transaction.Amount = nbcAmount.GetDecimal() ?? throw new NullReferenceException();
                transaction.CategoryId = icbCategory.GetItem<CategoryTransaction>().Id;
                transaction.AccountId = icbAccount.GetItem<Account>().Id;
                transaction.Date = dtpDate.Value;
                transaction.Description = tbDescription.Text.Trim();
                transaction.UserId = _user.Id;

                account.Balance += transaction.GetPayment(icbCategory.GetItem<CategoryTransaction>().Type);

                db.Transaction.Add(transaction);

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка создания транзакции!");
                return false;
            }

            transaction.Category = icbCategory.GetItem<CategoryTransaction>();
            transaction.Account = icbAccount.GetItem<Account>();
            _transactions.Add(transaction);

            return true;
        }

        private bool UpdateTransaction()
        {
            Transaction curentTransaction = GetCurrentTransaction();

            if (curentTransaction == null)
                return false;

            Transaction transaction;
            try
            {
                using EntitiesContext db = new();

                Account oldAccount = db.Account.FirstOrDefault(x => x.Id == curentTransaction.AccountId);
                Account newAccount = db.Account.FirstOrDefault(x => x.Id == icbAccount.GetItem<Account>().Id);
                transaction = db.Transaction.FirstOrDefault(x => x.Id == curentTransaction.Id);

                if (transaction == null || oldAccount == null || newAccount == null)
                    return false;

                db.Transaction.Attach(transaction);
                db.Account.AttachRange(new List<Account>() { newAccount, oldAccount });

                transaction.Amount = nbcAmount.GetDecimal() ?? throw new NullReferenceException();
                transaction.CategoryId = icbCategory.GetItem<CategoryTransaction>().Id;
                transaction.AccountId = icbAccount.GetItem<Account>().Id;
                transaction.Date = dtpDate.Value;
                transaction.Description = tbDescription.Text.Trim();

                oldAccount.Balance -= curentTransaction.GetPayment();
                newAccount.Balance += transaction.GetPayment(icbCategory.GetItem<CategoryTransaction>().Type);

                db.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка редактирования транзакции!");
                return false;
            }

            transaction.Category = icbCategory.GetItem<CategoryTransaction>();
            transaction.Account = icbAccount.GetItem<Account>();

            int index = _transactions.IndexOf(curentTransaction);
            _transactions.Remove(curentTransaction);
            _transactions.Insert(index, transaction);

            return true;
        }

        private bool Verification()
        {
            if (nbcAmount.GetDecimal() == null)
            {
                MessageBox.Show("Введите сумму!");
                return false;
            }

            return true;
        }

        private Transaction GetCurrentTransaction()
        {
            int id = (int)dgvcTransaction.Rows[dgvcTransaction.CurrentCell.RowIndex].Cells[1].Value;
            return _transactions.FirstOrDefault(x => x.Id == id);
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

        #region

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditTransaction();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddTransaction();
        }

        private void buttonDeleted_Click(object sender, EventArgs e)
        {
            DeleteTransaction();
        }

        private void buttonAddNext_Click(object sender, EventArgs e)
        {
            if (SaveTransaction())
                AddTransaction();
        }

        private void buttonComplite_Click(object sender, EventArgs e)
        {
            if (SaveTransaction())
            {
                _stateOperation = StateOperation.Read;
                UpdateStateForm();
            }
        }

        private void buttonType_Click(object sender, EventArgs e)
        {
            _currentTypeButton = !_currentTypeButton;
            UpdateButtonType();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            _stateOperation = StateOperation.Read;
            UpdateStateForm();
        }
    }
    #endregion
}
