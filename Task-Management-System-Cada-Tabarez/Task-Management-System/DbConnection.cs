using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

public class DbConnection
{
    private string connectionString = "Server=localhost;Database=task_management_db;Uid=root;Pwd=admin;";

    public MySqlConnection GetConnection()
    {
        MySqlConnection conn = new MySqlConnection(connectionString);
        try
        {
            conn.Open();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Database Connection Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return conn;
    }
}