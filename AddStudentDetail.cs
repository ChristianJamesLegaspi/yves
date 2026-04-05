using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentManagementSystem
{
    public partial class AddStudentForm : Form
    {
        private string connectionString = "Server=localhost;Database=student_management_db;Uid=root;Pwd=your_strong_password;";
        private string studentPhotoPath;

        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void btnBrowsePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudentPhoto.Image = new Bitmap(openFileDialog.FileName);
                studentPhotoPath = openFileDialog.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            DateTime birthdate = dateTimePickerBirthdate.Value;
            string gender = rdoMale.Checked ? "Male" : (rdoFemale.Checked ? "Female" : "");
            string mobile = txtMobile.Text;
            string studentNumber = txtStudentNumber.Text;
            string address = txtAddress.Text;
            string course = cmbCourse.SelectedItem?.ToString();
            string year = cmbYear.SelectedItem?.ToString();
            string enrollmentStatus = cmbEnrollmentStatus.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(studentNumber))
            {
                MessageBox.Show("First Name, Last Name, and Student Number are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO students (first_name, last_name, email, birthdate, gender, student_number, mobile, address, course, state, year, student_photo) " +
                                    "VALUES (@firstName, @lastName, @email, @birthdate, @gender, @studentNumber, @mobile, @address, @course, @state, @year, @studentPhoto)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@firstName", firstName);
                        command.Parameters.AddWithValue("@lastName", lastName);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@birthdate", birthdate);
                        command.Parameters.AddWithValue("@gender", gender);
                        command.Parameters.AddWithValue("@studentNumber", studentNumber);
                        command.Parameters.AddWithValue("@mobile", mobile);
                        command.Parameters.AddWithValue("@address", address);
                        command.Parameters.AddWithValue("@course", course ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@state", enrollmentStatus ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@year", year ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@studentPhoto", studentPhotoPath ?? (object)DBNull.Value);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to save student data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            dateTimePickerBirthdate.Value = DateTime.Now;
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            txtMobile.Clear();
            txtStudentNumber.Clear();
            txtAddress.Clear();
            cmbCourse.SelectedIndex = -1;
            cmbYear.SelectedIndex = -1;
            cmbEnrollmentStatus.SelectedIndex = -1;
            pictureBoxStudentPhoto.Image = null;
            studentPhotoPath = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}