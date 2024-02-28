namespace FinanceTrack.WinForm.Content.CntentItem
{
    partial class AccountControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvcAccount = new CustomTools.DataGridViewCustom();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnTypeAccount = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnBalance = new DataGridViewTextBoxColumn();
            tlpEditDataGrid = new TableLayoutPanel();
            buttonAdd = new Button();
            buttonDeleted = new Button();
            buttonEdit = new Button();
            tlpEdit = new TableLayoutPanel();
            label5 = new Label();
            icbTypeAccount = new CustomTools.ItemComboBox();
            label4 = new Label();
            tbName = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            buttonAddNext = new Button();
            buttonComplite = new Button();
            buttonClose = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvcAccount).BeginInit();
            tlpEditDataGrid.SuspendLayout();
            tlpEdit.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgvcAccount, 0, 3);
            tableLayoutPanel1.Controls.Add(tlpEditDataGrid, 0, 2);
            tableLayoutPanel1.Controls.Add(tlpEdit, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(917, 666);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // dgvcAccount
            // 
            dgvcAccount.AllowUserToAddRows = false;
            dgvcAccount.AllowUserToDeleteRows = false;
            dgvcAccount.AllowUserToResizeRows = false;
            dgvcAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcAccount.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnTypeAccount, ColumnName, ColumnBalance });
            dgvcAccount.Dock = DockStyle.Fill;
            dgvcAccount.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvcAccount.Location = new Point(0, 68);
            dgvcAccount.Margin = new Padding(0);
            dgvcAccount.MultiSelect = false;
            dgvcAccount.Name = "dgvcAccount";
            dgvcAccount.ReadOnly = true;
            dgvcAccount.RowTemplate.Height = 25;
            dgvcAccount.Size = new Size(917, 598);
            dgvcAccount.TabIndex = 1;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "Id";
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            ColumnId.Visible = false;
            // 
            // ColumnTypeAccount
            // 
            ColumnTypeAccount.HeaderText = "Тип счета";
            ColumnTypeAccount.Name = "ColumnTypeAccount";
            ColumnTypeAccount.ReadOnly = true;
            ColumnTypeAccount.Width = 150;
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Описание";
            ColumnName.Name = "ColumnName";
            ColumnName.ReadOnly = true;
            ColumnName.Width = 150;
            // 
            // ColumnBalance
            // 
            ColumnBalance.HeaderText = "Баланс";
            ColumnBalance.Name = "ColumnBalance";
            ColumnBalance.ReadOnly = true;
            // 
            // tlpEditDataGrid
            // 
            tlpEditDataGrid.AutoSize = true;
            tlpEditDataGrid.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpEditDataGrid.ColumnCount = 4;
            tlpEditDataGrid.ColumnStyles.Add(new ColumnStyle());
            tlpEditDataGrid.ColumnStyles.Add(new ColumnStyle());
            tlpEditDataGrid.ColumnStyles.Add(new ColumnStyle());
            tlpEditDataGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpEditDataGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpEditDataGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpEditDataGrid.Controls.Add(buttonAdd, 0, 0);
            tlpEditDataGrid.Controls.Add(buttonDeleted, 2, 0);
            tlpEditDataGrid.Controls.Add(buttonEdit, 1, 0);
            tlpEditDataGrid.Dock = DockStyle.Fill;
            tlpEditDataGrid.Location = new Point(0, 30);
            tlpEditDataGrid.Margin = new Padding(0);
            tlpEditDataGrid.Name = "tlpEditDataGrid";
            tlpEditDataGrid.RowCount = 1;
            tlpEditDataGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpEditDataGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpEditDataGrid.Size = new Size(917, 38);
            tlpEditDataGrid.TabIndex = 2;
            // 
            // buttonAdd
            // 
            buttonAdd.Image = Properties.Resources.add_24;
            buttonAdd.Location = new Point(3, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(32, 32);
            buttonAdd.TabIndex = 0;
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDeleted
            // 
            buttonDeleted.Image = Properties.Resources.basket_24;
            buttonDeleted.Location = new Point(79, 3);
            buttonDeleted.Name = "buttonDeleted";
            buttonDeleted.Size = new Size(32, 32);
            buttonDeleted.TabIndex = 2;
            buttonDeleted.UseVisualStyleBackColor = true;
            buttonDeleted.Click += buttonDeleted_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Image = Properties.Resources.edit_24;
            buttonEdit.Location = new Point(41, 3);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(32, 32);
            buttonEdit.TabIndex = 1;
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // tlpEdit
            // 
            tlpEdit.AutoSize = true;
            tlpEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpEdit.ColumnCount = 7;
            tlpEdit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpEdit.ColumnStyles.Add(new ColumnStyle());
            tlpEdit.ColumnStyles.Add(new ColumnStyle());
            tlpEdit.ColumnStyles.Add(new ColumnStyle());
            tlpEdit.ColumnStyles.Add(new ColumnStyle());
            tlpEdit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            tlpEdit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            tlpEdit.Controls.Add(label5, 1, 0);
            tlpEdit.Controls.Add(icbTypeAccount, 2, 0);
            tlpEdit.Controls.Add(label4, 3, 0);
            tlpEdit.Controls.Add(tbName, 4, 0);
            tlpEdit.Controls.Add(tableLayoutPanel4, 6, 0);
            tlpEdit.Dock = DockStyle.Fill;
            tlpEdit.Location = new Point(0, 0);
            tlpEdit.Margin = new Padding(0);
            tlpEdit.Name = "tlpEdit";
            tlpEdit.RowCount = 1;
            tlpEdit.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpEdit.Size = new Size(917, 30);
            tlpEdit.TabIndex = 3;
            tlpEdit.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(122, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 30);
            label5.TabIndex = 9;
            label5.Text = "Тип счета";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // icbTypeAccount
            // 
            icbTypeAccount.FormattingEnabled = true;
            icbTypeAccount.Location = new Point(188, 3);
            icbTypeAccount.Name = "icbTypeAccount";
            icbTypeAccount.Size = new Size(159, 23);
            icbTypeAccount.TabIndex = 0;
            icbTypeAccount.TypeItem = typeof(DataLayer.TypeAccount);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(353, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 30);
            label4.TabIndex = 8;
            label4.Text = "Описание";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbName
            // 
            tbName.Location = new Point(421, 3);
            tbName.MaxLength = 20;
            tbName.Name = "tbName";
            tbName.Size = new Size(252, 23);
            tbName.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel4.ColumnCount = 5;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(buttonAddNext, 1, 1);
            tableLayoutPanel4.Controls.Add(buttonComplite, 2, 1);
            tableLayoutPanel4.Controls.Add(buttonClose, 3, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(796, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(121, 30);
            tableLayoutPanel4.TabIndex = 6;
            // 
            // buttonAddNext
            // 
            buttonAddNext.Image = Properties.Resources.add_16;
            buttonAddNext.Location = new Point(18, 3);
            buttonAddNext.Name = "buttonAddNext";
            buttonAddNext.Size = new Size(24, 24);
            buttonAddNext.TabIndex = 0;
            buttonAddNext.UseVisualStyleBackColor = true;
            buttonAddNext.Click += buttonAddNext_Click;
            // 
            // buttonComplite
            // 
            buttonComplite.Image = Properties.Resources.check_16;
            buttonComplite.Location = new Point(48, 3);
            buttonComplite.Name = "buttonComplite";
            buttonComplite.Size = new Size(24, 24);
            buttonComplite.TabIndex = 1;
            buttonComplite.UseVisualStyleBackColor = true;
            buttonComplite.Click += buttonComplite_Click;
            // 
            // buttonClose
            // 
            buttonClose.Image = Properties.Resources.close_16;
            buttonClose.Location = new Point(78, 3);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(24, 24);
            buttonClose.TabIndex = 2;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // AccountContentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "AccountContentControl";
            Size = new Size(917, 666);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvcAccount).EndInit();
            tlpEditDataGrid.ResumeLayout(false);
            tlpEdit.ResumeLayout(false);
            tlpEdit.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private CustomTools.DataGridViewCustom dgvcAccount;
        private TableLayoutPanel tlpEditDataGrid;
        private Button buttonAdd;
        private Button buttonDeleted;
        private Button buttonEdit;
        private TableLayoutPanel tlpEdit;
        private TextBox tbName;
        private Label label4;
        private Label label5;
        private CustomTools.ItemComboBox icbTypeAccount;
        private TableLayoutPanel tableLayoutPanel4;
        private Button buttonAddNext;
        private Button buttonComplite;
        private Button buttonClose;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnTypeAccount;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnBalance;
    }
}
