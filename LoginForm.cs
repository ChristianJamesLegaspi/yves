using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentManagementSystem
{
    public partial class LoginForm : Form
    {
        private string connectionString = "Server=localhost;Database=student_management_db;Uid=root;Pwd=your_strong_password;";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmailLogin.Text))
            {
                MessageBox.Show("Please enter your email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailLogin.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPasswordLogin.Text))
            {
                MessageBox.Show("Please enter your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPasswordLogin.Focus();
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id, full_name, email, password FROM users WHERE email = @email";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@email", txtEmailLogin.Text);
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string storedHashedPassword = reader["password"].ToString();
                        if (VerifyPassword(txtPasswordLogin.Text, storedHashedPassword))
                        {
                            int userId = (int)reader["id"];
                            string fullName = reader["full_name"].ToString();
                            string email = reader["email"].ToString();

                            MessageBox.Show($"Login successful! Welcome, {fullName}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Open the MainForm and pass user info
                            dashboardHostPanel mainForm = new dashboardHostPanel(userId, fullName, email); // Assuming your MainForm constructor can accept this
                            this.Hide(); // Hide the login form
                            mainForm.ShowDialog(); // Show the MainForm as a dialog, which will block until it's closed
                            this.Close(); // Close the login form after MainForm is closed (optional)
                        }
                        else
                        {
                            MessageBox.Show("Invalid password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email not found. Please register or check your email.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private bool VerifyPassword(string password, string hashedPassword)
        {
            string hashedInput = HashPassword(password);
            return hashedInput.Equals(hashedPassword);
        }
    }
}