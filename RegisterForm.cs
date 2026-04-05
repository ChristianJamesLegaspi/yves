using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace StudentManagementSystem
{
    public partial class RegisterForm : Form
    {
        private string connectionString = "Server=localhost;Database=student_management_db;Uid=root;Pwd=your_strong_password;";

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please enter your full name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFullName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmailRegister.Text))
            {
                MessageBox.Show("Please enter your email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailRegister.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPasswordRegister.Text))
            {
                MessageBox.Show("Please enter your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPasswordRegister.Focus();
                return;
            }
            if (txtPasswordRegister.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Focus();
                return;
            }

            string hashedPassword = HashPassword(txtPasswordRegister.Text);

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO users (full_name, email, password) VALUES (@fullName, @email, @password)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@fullName", txtFullName.Text);
                    command.Parameters.AddWithValue("@email", txtEmailRegister.Text);
                    command.Parameters.AddWithValue("@password", hashedPassword);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtFullName.Clear();
                        txtEmailRegister.Clear();
                        txtPasswordRegister.Clear();
                        txtConfirmPassword.Clear();
                        if (this.ParentForm is dashboardHostPanel mainForm)
                        {
                            mainForm.ShowLoginForm();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062)
                    {
                        MessageBox.Show("Email address is already taken. Please use a different email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);
                return Convert.ToBase64String(hashBytes);
            }
            return string.Empty;
        }
    }
}