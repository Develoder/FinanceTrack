namespace FinanceTrack.WinForm.MainWindow.Control
{
    partial class ManagerMainControl
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
            cpMenu = new CustomTools.CollapsePanel();
            buttonMain = new Button();
            buttonAccount = new Button();
            cpReport = new CustomTools.CollapsePanel();
            buttonTransaction = new Button();
            buttonReport = new Button();
            buttonReportTransaction = new Button();
            buttonReportCategory = new Button();
            buttonProfile = new Button();
            buttonMenu = new Button();
            panelContent = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            labelHeader = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            labelUserName = new Label();
            pictureBox1 = new PictureBox();
            labelBalance = new Label();
            pictureBox2 = new PictureBox();
            cpMenu.SuspendLayout();
            cpReport.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // cpMenu
            // 
            cpMenu.Controls.Add(buttonMain);
            cpMenu.Controls.Add(buttonAccount);
            cpMenu.Controls.Add(buttonTransaction);
            cpMenu.Controls.Add(cpReport);
            cpMenu.Controls.Add(buttonProfile);
            cpMenu.Direction = CustomTools.CollapsePanel.TypeDirection.Hirizontal;
            cpMenu.Dock = DockStyle.Left;
            cpMenu.FlowDirection = FlowDirection.TopDown;
            cpMenu.HorizontalMinSize = 34;
            cpMenu.InitialView = CustomTools.CollapsePanel.StateCollapse.Expanded;
            cpMenu.Location = new Point(0, 0);
            cpMenu.Margin = new Padding(0);
            cpMenu.Name = "cpMenu";
            cpMenu.Size = new Size(200, 699);
            cpMenu.TabIndex = 13;
            cpMenu.TimeCollapse = 100;
            // 
            // buttonMain
            // 
            buttonMain.BackColor = SystemColors.ControlLight;
            buttonMain.FlatAppearance.BorderSize = 0;
            buttonMain.FlatStyle = FlatStyle.Flat;
            buttonMain.Image = Properties.Resources.home;
            buttonMain.ImageAlign = ContentAlignment.MiddleLeft;
            buttonMain.Location = new Point(0, 0);
            buttonMain.Margin = new Padding(0);
            buttonMain.Name = "buttonMain";
            buttonMain.Size = new Size(200, 33);
            buttonMain.TabIndex = 14;
            buttonMain.Text = "   Глваная";
            buttonMain.TextAlign = ContentAlignment.MiddleLeft;
            buttonMain.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonMain.UseVisualStyleBackColor = false;
            buttonMain.Click += buttonMain_Click;
            // 
            // buttonAccount
            // 
            buttonAccount.BackColor = SystemColors.ControlLight;
            buttonAccount.FlatAppearance.BorderSize = 0;
            buttonAccount.FlatStyle = FlatStyle.Flat;
            buttonAccount.Image = Properties.Resources.account;
            buttonAccount.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAccount.Location = new Point(0, 33);
            buttonAccount.Margin = new Padding(0);
            buttonAccount.Name = "buttonAccount";
            buttonAccount.Size = new Size(200, 33);
            buttonAccount.TabIndex = 2;
            buttonAccount.Text = "   Счета";
            buttonAccount.TextAlign = ContentAlignment.MiddleLeft;
            buttonAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAccount.UseVisualStyleBackColor = false;
            buttonAccount.Click += buttonAccount_Click;
            // 
            // cpReport
            // 
            cpReport.Controls.Add(buttonReport);
            cpReport.Controls.Add(buttonReportTransaction);
            cpReport.Controls.Add(buttonReportCategory);
            cpReport.FlowDirection = FlowDirection.TopDown;
            cpReport.Location = new Point(0, 99);
            cpReport.Margin = new Padding(0);
            cpReport.Name = "cpReport";
            cpReport.Size = new Size(200, 99);
            cpReport.TabIndex = 13;
            cpReport.TimeCollapse = 100;
            // 
            // buttonTransaction
            // 
            buttonTransaction.BackColor = SystemColors.ControlLight;
            buttonTransaction.FlatAppearance.BorderSize = 0;
            buttonTransaction.FlatStyle = FlatStyle.Flat;
            buttonTransaction.Image = Properties.Resources.transaction;
            buttonTransaction.ImageAlign = ContentAlignment.MiddleLeft;
            buttonTransaction.Location = new Point(0, 66);
            buttonTransaction.Margin = new Padding(0);
            buttonTransaction.Name = "buttonTransaction";
            buttonTransaction.Size = new Size(200, 33);
            buttonTransaction.TabIndex = 3;
            buttonTransaction.Text = "   Транзакции";
            buttonTransaction.TextAlign = ContentAlignment.MiddleLeft;
            buttonTransaction.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonTransaction.UseVisualStyleBackColor = false;
            buttonTransaction.Click += buttonTransaction_Click;
            // 
            // buttonReport
            // 
            buttonReport.BackColor = SystemColors.ControlLight;
            buttonReport.FlatAppearance.BorderSize = 0;
            buttonReport.FlatStyle = FlatStyle.Flat;
            buttonReport.Image = Properties.Resources.reports;
            buttonReport.ImageAlign = ContentAlignment.MiddleLeft;
            buttonReport.Location = new Point(0, 0);
            buttonReport.Margin = new Padding(0);
            buttonReport.Name = "buttonReport";
            buttonReport.Size = new Size(200, 33);
            buttonReport.TabIndex = 8;
            buttonReport.Text = "   Отчеты";
            buttonReport.TextAlign = ContentAlignment.MiddleLeft;
            buttonReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonReport.UseVisualStyleBackColor = false;
            buttonReport.Click += button8_Click;
            // 
            // buttonReportTransaction
            // 
            buttonReportTransaction.FlatAppearance.BorderSize = 0;
            buttonReportTransaction.FlatStyle = FlatStyle.Flat;
            buttonReportTransaction.Image = Properties.Resources.degree;
            buttonReportTransaction.ImageAlign = ContentAlignment.MiddleLeft;
            buttonReportTransaction.Location = new Point(0, 33);
            buttonReportTransaction.Margin = new Padding(0);
            buttonReportTransaction.Name = "buttonReportTransaction";
            buttonReportTransaction.Size = new Size(200, 33);
            buttonReportTransaction.TabIndex = 11;
            buttonReportTransaction.Text = "   Транзакции";
            buttonReportTransaction.TextAlign = ContentAlignment.MiddleLeft;
            buttonReportTransaction.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonReportTransaction.UseVisualStyleBackColor = true;
            buttonReportTransaction.Click += buttonReportMonth_Click;
            // 
            // buttonReportCategory
            // 
            buttonReportCategory.FlatAppearance.BorderSize = 0;
            buttonReportCategory.FlatStyle = FlatStyle.Flat;
            buttonReportCategory.Image = Properties.Resources.degree;
            buttonReportCategory.ImageAlign = ContentAlignment.MiddleLeft;
            buttonReportCategory.Location = new Point(0, 66);
            buttonReportCategory.Margin = new Padding(0);
            buttonReportCategory.Name = "buttonReportCategory";
            buttonReportCategory.Size = new Size(200, 33);
            buttonReportCategory.TabIndex = 10;
            buttonReportCategory.Text = "   Категории";
            buttonReportCategory.TextAlign = ContentAlignment.MiddleLeft;
            buttonReportCategory.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonReportCategory.UseVisualStyleBackColor = true;
            buttonReportCategory.Click += buttonReportCategory_Click;
            // 
            // buttonProfile
            // 
            buttonProfile.BackColor = SystemColors.ControlLight;
            buttonProfile.FlatAppearance.BorderSize = 0;
            buttonProfile.FlatStyle = FlatStyle.Flat;
            buttonProfile.Image = Properties.Resources.user_24;
            buttonProfile.ImageAlign = ContentAlignment.MiddleLeft;
            buttonProfile.Location = new Point(0, 198);
            buttonProfile.Margin = new Padding(0);
            buttonProfile.Name = "buttonProfile";
            buttonProfile.Size = new Size(200, 33);
            buttonProfile.TabIndex = 1;
            buttonProfile.Text = "   Профиль";
            buttonProfile.TextAlign = ContentAlignment.MiddleLeft;
            buttonProfile.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonProfile.UseVisualStyleBackColor = false;
            buttonProfile.Click += buttonProfile_Click;
            // 
            // buttonMenu
            // 
            buttonMenu.BackColor = SystemColors.Control;
            buttonMenu.FlatAppearance.BorderSize = 0;
            buttonMenu.FlatStyle = FlatStyle.Flat;
            buttonMenu.Image = Properties.Resources.Menu;
            buttonMenu.ImageAlign = ContentAlignment.MiddleLeft;
            buttonMenu.Location = new Point(0, 0);
            buttonMenu.Margin = new Padding(0);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(34, 33);
            buttonMenu.TabIndex = 0;
            buttonMenu.TextAlign = ContentAlignment.MiddleLeft;
            buttonMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonMenu.UseVisualStyleBackColor = false;
            buttonMenu.Click += buttonMenu_Click;
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 33);
            panelContent.Margin = new Padding(0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(917, 666);
            panelContent.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1117, 733);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Controls.Add(cpMenu);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 34);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1117, 699);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panelContent, 0, 1);
            tableLayoutPanel3.Controls.Add(labelHeader, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(200, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(917, 699);
            tableLayoutPanel3.TabIndex = 15;
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.Dock = DockStyle.Fill;
            labelHeader.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelHeader.Location = new Point(3, 0);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(911, 33);
            labelHeader.TabIndex = 15;
            labelHeader.Text = "Заголовок";
            labelHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(buttonMenu, 0, 0);
            tableLayoutPanel2.Controls.Add(labelUserName, 4, 0);
            tableLayoutPanel2.Controls.Add(pictureBox1, 5, 0);
            tableLayoutPanel2.Controls.Add(labelBalance, 2, 0);
            tableLayoutPanel2.Controls.Add(pictureBox2, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1117, 34);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Dock = DockStyle.Fill;
            labelUserName.Location = new Point(981, 0);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(109, 34);
            labelUserName.TabIndex = 1;
            labelUserName.Text = "Имя пользователя";
            labelUserName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_24;
            pictureBox1.Location = new Point(1093, 4);
            pictureBox1.Margin = new Padding(0, 4, 0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.Dock = DockStyle.Fill;
            labelBalance.Location = new Point(890, 0);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(61, 34);
            labelBalance.TabIndex = 3;
            labelBalance.Text = "1000 000 ₽";
            labelBalance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.wallet_24;
            pictureBox2.Location = new Point(954, 4);
            pictureBox2.Margin = new Padding(0, 4, 0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // ManagerMainControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(0);
            Name = "ManagerMainControl";
            Size = new Size(1117, 733);
            Load += MainPrimaryControl_Load;
            cpMenu.ResumeLayout(false);
            cpReport.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomTools.CollapsePanel cpMenu;
        private Button buttonMenu;
        private CustomTools.CollapsePanel cpReport;
        private Button buttonReport;
        private Button buttonReportTransaction;
        private Button buttonReportCategory;
        private Button buttonTransaction;
        private Button buttonAccount;
        private Button buttonProfile;
        private Panel panelContent;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelUserName;
        private PictureBox pictureBox1;
        private Label labelBalance;
        private PictureBox pictureBox2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label labelHeader;
        private Button buttonMain;
    }
}
