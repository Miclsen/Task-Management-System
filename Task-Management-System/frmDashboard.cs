using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Task_Management_System
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }
        private void btnTaskManagement_Click(object sender, EventArgs e)
        {
            frmTasks taskForm = new frmTasks();
            taskForm.ShowDialog();
        }

        private void btnCategoryManagement_Click(object sender, EventArgs e)
        {
            frmCategories categoryForm = new frmCategories();
            categoryForm.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReport reportsForm = new frmReport();
            reportsForm.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout aboutForm = new frmAbout();
            aboutForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form loginForm = Application.OpenForms["frmLogin"];

                if (loginForm != null)
                {
                    loginForm.Show();
                }
                else
                {
                    frmLogin newLogin = new frmLogin();
                    newLogin.Show();
                }

                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Exit System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
