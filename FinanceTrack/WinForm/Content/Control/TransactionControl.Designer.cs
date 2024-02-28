using FinanceTrack.CustomTools;

namespace FinanceTrack.WinForm.Content.Control
{
    partial class TransactionControl
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
            dgvcTransaction = new DataGridViewCustom();
            ColumnType = new DataGridViewImageColumn();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnAmount = new DataGridViewTextBoxColumn();
            ColumnCategory = new DataGridViewTextBoxColumn();
            ColumnDate = new DataGridViewTextBoxColumn();
            ColumnDescription = new DataGridViewTextBoxColumn();
            ColumnAccount = new DataGridViewTextBoxColumn();
            tlpEditDataGrid = new TableLayoutPanel();
            buttonAdd = new Button();
            buttonDeleted = new Button();
            buttonEdit = new Button();
            tlpEdit = new TableLayoutPanel();
            label1 = new Label();
            buttonType = new Button();
            label2 = new Label();
            icbCategory = new ItemComboBox();
            label3 = new Label();
            dtpDate = new DateTimePicker();
            tbDescription = new TextBox();
            label4 = new Label();
            label5 = new Label();
            icbAccount = new ItemComboBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            buttonAddNext = new Button();
            buttonComplite = new Button();
            buttonClose = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            label6 = new Label();
            nbcAmount = new NumberBoxCustom();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvcTransaction).BeginInit();
            tlpEditDataGrid.SuspendLayout();
            tlpEdit.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgvcTransaction, 0, 3);
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
            tableLayoutPanel1.TabIndex = 2;
            // 
            // dgvcTransaction
            // 
            dgvcTransaction.AllowUserToAddRows = false;
            dgvcTransaction.AllowUserToDeleteRows = false;
            dgvcTransaction.AllowUserToResizeRows = false;
            dgvcTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcTransaction.Columns.AddRange(new DataGridViewColumn[] { ColumnType, ColumnId, ColumnAmount, ColumnCategory, ColumnDate, ColumnDescription, ColumnAccount });
            dgvcTransaction.Dock = DockStyle.Fill;
            dgvcTransaction.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvcTransaction.Location = new Point(0, 112);
            dgvcTransaction.Margin = new Padding(0);
            dgvcTransaction.MultiSelect = false;
            dgvcTransaction.Name = "dgvcTransaction";
            dgvcTransaction.ReadOnly = true;
            dgvcTransaction.RowTemplate.Height = 25;
            dgvcTransaction.Size = new Size(917, 554);
            dgvcTransaction.TabIndex = 1;
            // 
            // ColumnType
            // 
            ColumnType.Frozen = true;
            ColumnType.HeaderText = "";
            ColumnType.MinimumWidth = 24;
            ColumnType.Name = "ColumnType";
            ColumnType.ReadOnly = true;
            ColumnType.Resizable = DataGridViewTriState.False;
            ColumnType.Width = 24;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "Id";
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            ColumnId.Visible = false;
            // 
            // ColumnAmount
            // 
            ColumnAmount.HeaderText = "Сумма";
            ColumnAmount.Name = "ColumnAmount";
            ColumnAmount.ReadOnly = true;
            // 
            // ColumnCategory
            // 
            ColumnCategory.HeaderText = "Категория";
            ColumnCategory.Name = "ColumnCategory";
            ColumnCategory.ReadOnly = true;
            // 
            // ColumnDate
            // 
            ColumnDate.HeaderText = "Дата";
            ColumnDate.Name = "ColumnDate";
            ColumnDate.ReadOnly = true;
            // 
            // ColumnDescription
            // 
            ColumnDescription.HeaderText = "Описание";
            ColumnDescription.Name = "ColumnDescription";
            ColumnDescription.ReadOnly = true;
            // 
            // ColumnAccount
            // 
            ColumnAccount.HeaderText = "Счет";
            ColumnAccount.Name = "ColumnAccount";
            ColumnAccount.ReadOnly = true;
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
            tlpEditDataGrid.Location = new Point(0, 74);
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
            tlpEdit.ColumnStyles.Add(new ColumnStyle());
            tlpEdit.ColumnStyles.Add(new ColumnStyle());
            tlpEdit.ColumnStyles.Add(new ColumnStyle());
            tlpEdit.ColumnStyles.Add(new ColumnStyle());
            tlpEdit.ColumnStyles.Add(new ColumnStyle());
            tlpEdit.ColumnStyles.Add(new ColumnStyle());
            tlpEdit.ColumnStyles.Add(new ColumnStyle());
            tlpEdit.Controls.Add(label1, 1, 0);
            tlpEdit.Controls.Add(buttonType, 0, 0);
            tlpEdit.Controls.Add(label2, 3, 0);
            tlpEdit.Controls.Add(icbCategory, 4, 0);
            tlpEdit.Controls.Add(label3, 5, 0);
            tlpEdit.Controls.Add(dtpDate, 6, 0);
            tlpEdit.Controls.Add(tbDescription, 2, 1);
            tlpEdit.Controls.Add(label4, 1, 1);
            tlpEdit.Controls.Add(label5, 3, 1);
            tlpEdit.Controls.Add(icbAccount, 4, 1);
            tlpEdit.Controls.Add(tableLayoutPanel4, 6, 1);
            tlpEdit.Controls.Add(tableLayoutPanel3, 2, 0);
            tlpEdit.Dock = DockStyle.Fill;
            tlpEdit.Location = new Point(0, 0);
            tlpEdit.Margin = new Padding(0);
            tlpEdit.Name = "tlpEdit";
            tlpEdit.RowCount = 2;
            tlpEdit.RowStyles.Add(new RowStyle());
            tlpEdit.RowStyles.Add(new RowStyle());
            tlpEdit.Size = new Size(917, 74);
            tlpEdit.TabIndex = 3;
            tlpEdit.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(79, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 30);
            label1.TabIndex = 0;
            label1.Text = "Сумма";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonType
            // 
            buttonType.Image = Properties.Resources.plus_16;
            buttonType.Location = new Point(3, 3);
            buttonType.Name = "buttonType";
            buttonType.Size = new Size(70, 24);
            buttonType.TabIndex = 0;
            buttonType.Text = "Доход";
            buttonType.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonType.UseVisualStyleBackColor = true;
            buttonType.Click += buttonType_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(424, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 30);
            label2.TabIndex = 3;
            label2.Text = "Категория";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // icbCategory
            // 
            icbCategory.Dock = DockStyle.Fill;
            icbCategory.FormattingEnabled = true;
            icbCategory.Location = new Point(493, 3);
            icbCategory.Name = "icbCategory";
            icbCategory.Size = new Size(283, 23);
            icbCategory.TabIndex = 2;
            icbCategory.TypeItem = typeof(DataLayer.CategoryTransaction);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(782, 0);
            label3.Name = "label3";
            label3.Size = new Size(32, 30);
            label3.TabIndex = 5;
            label3.Text = "Дата";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "dd.MM.yy";
            dtpDate.Dock = DockStyle.Fill;
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(820, 3);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(94, 23);
            dtpDate.TabIndex = 3;
            // 
            // tbDescription
            // 
            tbDescription.Dock = DockStyle.Fill;
            tbDescription.Location = new Point(147, 33);
            tbDescription.MaxLength = 100;
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(271, 38);
            tbDescription.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(79, 30);
            label4.Name = "label4";
            label4.Size = new Size(62, 44);
            label4.TabIndex = 8;
            label4.Text = "Описание";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(424, 30);
            label5.Name = "label5";
            label5.Size = new Size(63, 44);
            label5.TabIndex = 9;
            label5.Text = "Счет";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // icbAccount
            // 
            icbAccount.Dock = DockStyle.Fill;
            icbAccount.FormattingEnabled = true;
            icbAccount.Location = new Point(493, 40);
            icbAccount.Margin = new Padding(3, 10, 3, 3);
            icbAccount.Name = "icbAccount";
            icbAccount.Size = new Size(283, 23);
            icbAccount.TabIndex = 5;
            icbAccount.TypeItem = typeof(DataLayer.Account);
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
            tableLayoutPanel4.Location = new Point(817, 30);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(100, 44);
            tableLayoutPanel4.TabIndex = 6;
            // 
            // buttonAddNext
            // 
            buttonAddNext.Image = Properties.Resources.add_16;
            buttonAddNext.Location = new Point(8, 10);
            buttonAddNext.Name = "buttonAddNext";
            buttonAddNext.Size = new Size(24, 24);
            buttonAddNext.TabIndex = 0;
            buttonAddNext.UseVisualStyleBackColor = true;
            buttonAddNext.Click += buttonAddNext_Click;
            // 
            // buttonComplite
            // 
            buttonComplite.Image = Properties.Resources.check_16;
            buttonComplite.Location = new Point(38, 10);
            buttonComplite.Name = "buttonComplite";
            buttonComplite.Size = new Size(24, 24);
            buttonComplite.TabIndex = 1;
            buttonComplite.UseVisualStyleBackColor = true;
            buttonComplite.Click += buttonComplite_Click;
            // 
            // buttonClose
            // 
            buttonClose.Image = Properties.Resources.close_16;
            buttonClose.Location = new Point(68, 10);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(24, 24);
            buttonClose.TabIndex = 2;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(label6, 1, 0);
            tableLayoutPanel3.Controls.Add(nbcAmount, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(144, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(277, 30);
            tableLayoutPanel3.TabIndex = 1;
            tableLayoutPanel3.TabStop = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(145, 0);
            label6.Name = "label6";
            label6.Size = new Size(129, 30);
            label6.TabIndex = 2;
            label6.Text = "₽";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nbcAmount
            // 
            nbcAmount.AllowNegativeNumber = false;
            nbcAmount.Location = new Point(3, 3);
            nbcAmount.Name = "nbcAmount";
            nbcAmount.Size = new Size(136, 23);
            nbcAmount.TabIndex = 0;
            nbcAmount.TypeName = "System.Decimal";
            // 
            // TransactionContentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "TransactionContentControl";
            Size = new Size(917, 666);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvcTransaction).EndInit();
            tlpEditDataGrid.ResumeLayout(false);
            tlpEdit.ResumeLayout(false);
            tlpEdit.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private CustomTools.DataGridViewCustom dgvcTransaction;
        private TableLayoutPanel tlpEditDataGrid;
        private Button buttonAdd;
        private Button buttonDeleted;
        private Button buttonEdit;
        private DataGridViewImageColumn ColumnType;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnAmount;
        private DataGridViewTextBoxColumn ColumnCategory;
        private DataGridViewTextBoxColumn ColumnDate;
        private DataGridViewTextBoxColumn ColumnDescription;
        private DataGridViewTextBoxColumn ColumnAccount;
        private TableLayoutPanel tlpEdit;
        private Label label1;
        private Button buttonType;
        private Label label2;
        private CustomTools.ItemComboBox icbCategory;
        private Label label3;
        private DateTimePicker dtpDate;
        private TextBox tbDescription;
        private Label label4;
        private Label label5;
        private CustomTools.ItemComboBox icbAccount;
        private TableLayoutPanel tableLayoutPanel4;
        private Button buttonAddNext;
        private Button buttonComplite;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label6;
        private NumberBoxCustom nbcAmount;
        private Button buttonClose;
    }
}
