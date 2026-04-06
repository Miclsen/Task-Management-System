using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Task_Management_System
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadData("SELECT * FROM tasks WHERE due_date < CURDATE() AND status!='Completed'");

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadData("SELECT * FROM tasks");
        }
        void LoadData(string query)
        {
            // DbConnection provides an instance method GetConnection(), so create an instance first
            DbConnection db = new DbConnection();
            using (MySqlConnection conn = db.GetConnection())
            {
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            LoadData("SELECT * FROM tasks WHERE status='Completed'");
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            LoadData("SELECT * FROM tasks WHERE status='Pending'");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData("SELECT * FROM tasks");
        }

        private void btnSearchTitle_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                MessageBox.Show("Enter task title to search");
                return;
            }

            string query = $"SELECT * FROM tasks WHERE task_title LIKE '%{txtSearch.Text}%'";
            LoadData(query);
        }

        private void btnSearchAssigned_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                MessageBox.Show("Enter assigned person to search");
                return;
            }

            string query = $"SELECT * FROM tasks WHERE assigned_to LIKE '%{txtSearch.Text}%'";
            LoadData(query);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
