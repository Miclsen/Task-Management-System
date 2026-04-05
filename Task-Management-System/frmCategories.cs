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
    public partial class frmCategories : Form
    {
        int selectedCategoryId = 0;
        public frmCategories()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dgvCategories.DataSource = CategoryFunctions.ViewCategories();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
        class CategoryFunctions
        {
            public static void AddCategory(string name, string desc)
            {
                // DbConnection exposes an instance method GetConnection(), create instance first
                DbConnection db = new DbConnection();
                using (MySqlConnection conn = db.GetConnection())
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO categories(category_name,description) VALUES(@n,@d)", conn))
                {
                    cmd.Parameters.AddWithValue("@n", name);
                    cmd.Parameters.AddWithValue("@d", desc);
                    cmd.ExecuteNonQuery();
                }
            }

            public static void UpdateCategory(int id, string name, string desc)
            {
                DbConnection db = new DbConnection();
                using (MySqlConnection conn = db.GetConnection())
                using (MySqlCommand cmd = new MySqlCommand("UPDATE categories SET category_name=@n, description=@d WHERE category_id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@n", name);
                    cmd.Parameters.AddWithValue("@d", desc);
                    cmd.ExecuteNonQuery();
                }
            }

            public static void DeleteCategory(int id)
            {
                DbConnection db = new DbConnection();
                using (MySqlConnection conn = db.GetConnection())
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM categories WHERE category_id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            public static DataTable ViewCategories()
            {
                DbConnection db = new DbConnection();
                using (MySqlConnection conn = db.GetConnection())
                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM categories", conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }

            public static DataTable SearchCategory(string keyword)
            {
                DbConnection db = new DbConnection();
                using (MySqlConnection conn = db.GetConnection())
                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM categories WHERE category_name LIKE @k", conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@k", "%" + keyword + "%");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedCategoryId = Convert.ToInt32(dgvCategories.CurrentRow.Cells["category_id"].Value);
            txtCategoryName.Text = dgvCategories.CurrentRow.Cells["category_name"].Value.ToString();
            txtCategoryDesc.Text = dgvCategories.CurrentRow.Cells["description"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text == "")
            {
                MessageBox.Show("Enter category name");
                return;
            }

            CategoryFunctions.AddCategory(txtCategoryName.Text, txtCategoryDesc.Text);
            MessageBox.Show("Category Added!");
            dgvCategories.DataSource = CategoryFunctions.ViewCategories();
        }

        private void txtCategoryDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCategoryId == 0)
            {
                MessageBox.Show("Select category first");
                return;
            }

            CategoryFunctions.UpdateCategory(selectedCategoryId, txtCategoryName.Text, txtCategoryDesc.Text);
            MessageBox.Show("Category Updated!");
            dgvCategories.DataSource = CategoryFunctions.ViewCategories();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCategoryId == 0)
            {
                MessageBox.Show("Select category first");
                return;
            }

            DialogResult result = MessageBox.Show("Delete this category?", "Confirm", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                CategoryFunctions.DeleteCategory(selectedCategoryId);
                MessageBox.Show("Category Deleted!");
                dgvCategories.DataSource = CategoryFunctions.ViewCategories();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvCategories.DataSource = CategoryFunctions.SearchCategory(txtCategoryName.Text);
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            dgvCategories.DataSource = CategoryFunctions.ViewCategories();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCategoryName.Clear();
            txtCategoryDesc.Clear();
            selectedCategoryId = 0;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
