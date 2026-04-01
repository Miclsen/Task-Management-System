using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Task_Management_System
{
    public partial class frmTasks : Form
    {
        DbConnection db = new DbConnection();
        int selectedTaskId = 0;

        public frmTasks()
        {
            InitializeComponent();
        }

        private void frmTasks_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadTasks();
        }

        private void LoadCategories()
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    string query = "SELECT category_id, category_name FROM categories";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbCategory.DataSource = dt;
                    cmbCategory.DisplayMember = "category_name";
                    cmbCategory.ValueMember = "category_id";
                    cmbCategory.SelectedIndex = -1;
                }
            }
        }

        private void LoadTasks(string searchKeyword = "")
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    string query = @"SELECT t.task_id AS 'ID', t.task_title AS 'Title', t.description AS 'Description', 
                                            t.due_date AS 'Due Date', t.priority AS 'Priority', t.status AS 'Status', 
                                            t.assigned_to AS 'Assigned To', c.category_name AS 'Category', t.category_id
                                     FROM tasks t 
                                     LEFT JOIN categories c ON t.category_id = c.category_id ";

                    if (!string.IsNullOrEmpty(searchKeyword))
                    {
                        query += "WHERE t.task_title LIKE @search OR t.assigned_to LIKE @search";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    if (!string.IsNullOrEmpty(searchKeyword))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" + searchKeyword + "%");
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvTasks.DataSource = dt;

                    if (dgvTasks.Columns["category_id"] != null)
                        dgvTasks.Columns["category_id"].Visible = false;

                    dgvTasks.ClearSelection();
                }
            }
        }

        private void ClearFields()
        {
            txtTaskTitle.Clear();
            txtDescription.Clear();
            txtAssignedTo.Clear();
            dtpDueDate.Value = DateTime.Now;
            cmbPriority.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
            selectedTaskId = 0;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtTaskTitle.Text) ||
                string.IsNullOrWhiteSpace(txtAssignedTo.Text) ||
                cmbPriority.SelectedIndex == -1 ||
                cmbStatus.SelectedIndex == -1 ||
                cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Please fill in all required fields (Title, Assigned To, Priority, Status, Category).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            using (MySqlConnection conn = db.GetConnection())
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    string query = @"INSERT INTO tasks (task_title, description, due_date, priority, status, assigned_to, category_id) 
                                     VALUES (@title, @desc, @dueDate, @priority, @status, @assigned, @catId)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@title", txtTaskTitle.Text);
                    cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@dueDate", dtpDueDate.Value.Date);
                    cmd.Parameters.AddWithValue("@priority", cmbPriority.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@assigned", txtAssignedTo.Text);
                    cmd.Parameters.AddWithValue("@catId", cmbCategory.SelectedValue);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Task successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();
                    LoadTasks();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedTaskId == 0)
            {
                MessageBox.Show("Please select a task from the list to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            using (MySqlConnection conn = db.GetConnection())
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    string query = @"UPDATE tasks SET task_title=@title, description=@desc, due_date=@dueDate, 
                                     priority=@priority, status=@status, assigned_to=@assigned, category_id=@catId 
                                     WHERE task_id=@id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@title", txtTaskTitle.Text);
                    cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@dueDate", dtpDueDate.Value.Date);
                    cmd.Parameters.AddWithValue("@priority", cmbPriority.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@assigned", txtAssignedTo.Text);
                    cmd.Parameters.AddWithValue("@catId", cmbCategory.SelectedValue);
                    cmd.Parameters.AddWithValue("@id", selectedTaskId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Task successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();
                    LoadTasks();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedTaskId == 0)
            {
                MessageBox.Show("Please select a task from the list to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to permanently delete this task?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                    {
                        string query = "DELETE FROM tasks WHERE task_id=@id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", selectedTaskId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Task deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearFields();
                        LoadTasks();
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadTasks(txtSearch.Text);
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadTasks();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgvTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTasks.Rows[e.RowIndex];

                selectedTaskId = Convert.ToInt32(row.Cells["ID"].Value);
                txtTaskTitle.Text = row.Cells["Title"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();

                if (row.Cells["Due Date"].Value != DBNull.Value)
                    dtpDueDate.Value = Convert.ToDateTime(row.Cells["Due Date"].Value);

                cmbPriority.SelectedItem = row.Cells["Priority"].Value.ToString();
                cmbStatus.SelectedItem = row.Cells["Status"].Value.ToString();
                txtAssignedTo.Text = row.Cells["Assigned To"].Value.ToString();

                if (row.Cells["category_id"].Value != DBNull.Value)
                    cmbCategory.SelectedValue = row.Cells["category_id"].Value;
            }
        }
    }
}
