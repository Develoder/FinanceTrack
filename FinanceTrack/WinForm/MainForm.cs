using FinanceTrack.WinForm.MainWindow;
using FinanceTrack.WinForm.MainWindow.Abstract;

namespace FinanceTrack
{
    public partial class MainForm : Form
    {
        private static MainForm _mainForm;

        private IMainState _primaryItem;

        private MainForm()
        {
            InitializeComponent();

            IMainState.ChangedPrimary += SetPrimaryItem;
        }

        public static MainForm GetFormMain()
        {
            _mainForm ??= new();
            return _mainForm;
        }

        private void SetPrimaryItem(IMainState primaryItem)
        {
            if (_primaryItem != null)
            {
                panelPrimaryControl.Controls.Remove(_primaryItem.GetUserControl());
                _primaryItem.CloseContent();
            }

            _primaryItem = primaryItem;

            UserControl userControl = _primaryItem.GetUserControl();
            panelPrimaryControl.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }

        private void CloseForm()
        {
            Application.Exit();
        }

        #region Events

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                _primaryItem.PressEnter();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            CloseForm();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetPrimaryItem(new LoginMainWindow());
        }
    }
    #endregion
}