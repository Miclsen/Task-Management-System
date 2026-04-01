namespace Task_Management_System
{
    partial class frmDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnTaskManagement = new Button();
            btnCategoryManagement = new Button();
            btnReports = new Button();
            btnAbout = new Button();
            btnLogout = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 9);
            label1.Name = "label1";
            label1.Size = new Size(251, 126);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Task Management System";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnTaskManagement
            // 
            btnTaskManagement.Location = new Point(17, 138);
            btnTaskManagement.Name = "btnTaskManagement";
            btnTaskManagement.Size = new Size(246, 56);
            btnTaskManagement.TabIndex = 1;
            btnTaskManagement.Text = "Task Management";
            btnTaskManagement.UseVisualStyleBackColor = true;
            btnTaskManagement.Click += btnTaskManagement_Click;
            // 
            // btnCategoryManagement
            // 
            btnCategoryManagement.Location = new Point(17, 200);
            btnCategoryManagement.Name = "btnCategoryManagement";
            btnCategoryManagement.Size = new Size(246, 56);
            btnCategoryManagement.TabIndex = 2;
            btnCategoryManagement.Text = "Category Management";
            btnCategoryManagement.UseVisualStyleBackColor = true;
            btnCategoryManagement.Click += btnCategoryManagement_Click;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(17, 262);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(246, 56);
            btnReports.TabIndex = 3;
            btnReports.Text = "Reports / View Tasks";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnAbout
            // 
            btnAbout.Location = new Point(17, 347);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(75, 23);
            btnAbout.TabIndex = 4;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(102, 347);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(187, 347);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 383);
            Controls.Add(btnExit);
            Controls.Add(btnLogout);
            Controls.Add(btnAbout);
            Controls.Add(btnReports);
            Controls.Add(btnCategoryManagement);
            Controls.Add(btnTaskManagement);
            Controls.Add(label1);
            Name = "frmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnTaskManagement;
        private Button btnCategoryManagement;
        private Button btnReports;
        private Button btnAbout;
        private Button btnLogout;
        private Button btnExit;
    }
}