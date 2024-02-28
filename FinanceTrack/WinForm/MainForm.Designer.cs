using System.Windows.Forms;

namespace FinanceTrack
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelPrimaryControl = new Panel();
            SuspendLayout();
            // 
            // panelPrimaryControl
            // 
            panelPrimaryControl.Dock = DockStyle.Fill;
            panelPrimaryControl.Location = new Point(0, 0);
            panelPrimaryControl.Margin = new Padding(0);
            panelPrimaryControl.Name = "panelPrimaryControl";
            panelPrimaryControl.Size = new Size(1117, 733);
            panelPrimaryControl.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 733);
            Controls.Add(panelPrimaryControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Finance Track - ваш личный учет финансов";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private CustomTools.CollapsePanel collapsePanel1;
        private CustomTools.CollapsePanel collapsePanel2;
        private Panel panelPrimaryControl;
    }
}