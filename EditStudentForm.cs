// EditStudentForm.cs

using System;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentManagementSystem
{
    public partial class EditStudentForm : Form
    {
        private string _studentNumberToEdit;
        private string connectionString = "Server=localhost;Database=student_management_db;Uid=root;Pwd=your_strong_password;";
        private string currentPhotoPath; // To store the current photo path if loaded

        public EditStudentForm(string studentNumber)
        {
            InitializeComponent();
            _studentNumberToEdit = studentNumber;
            LoadStudentDetails(_studentNumberToEdit);
        }

        public EditStudentForm()
        {
            InitializeComponent();
            EnableEditFields(false);
        }

        private void LoadStudentDetails(string studentNumber)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT first_name, last_name, email, birthdate, gender, mobile, address, course, state, year, student_photo, student_number FROM students WHERE student_number = @StudentNumber";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentNumber", studentNumber);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtFirstName.Text = reader["first_name"].ToString();
                                txtLastName.Text = reader["last_name"].ToString();
                                txtEmail.Text = reader["email"].ToString();
                                dateTimePickerBirthdate.Value = Convert.ToDateTime(reader["birthdate"]);
                                string gender = reader["gender"].ToString();
                                rdoMale.Checked = (gender == "Male");
                                rdoFemale.Checked = (gender == "Female");
                                txtMobile.Text = reader["mobile"].ToString();
                                txtAddress.Text = reader["address"].ToString();
                                if (cmbCourse.Items.Contains(reader["course"].ToString()))
                                {
                                    cmbCourse.SelectedItem = reader["course"].ToString();
                                }
                                if (cmbEnrollmentStatus.Items.Contains(reader["state"].ToString()))
                                {
                                    cmbEnrollmentStatus.SelectedItem = reader["state"].ToString();
                                }
                                if (cmbYear.Items.Contains(reader["year"].ToString()))
                                {
                                    cmbYear.SelectedItem = reader["year"].ToString();
                                }

                                // Set the student number
                                txtStudentNumber.Text = reader["student_number"].ToString();
                                txtStudentNumber.Enabled = false; // Optionally disable editing

                                // Handle student photo (for file paths)
                                object photoPathObject = reader["student_photo"];
                                if (photoPathObject != DBNull.Value && photoPathObject is string filePath && File.Exists(filePath))
                                {
                                    try
                                    {
                                        pictureBoxStudentPhoto.Image = System.Drawing.Image.FromFile(filePath);
                                        currentPhotoPath = filePath;
                                        pictureBoxStudentPhoto.SizeMode = PictureBoxSizeMode.Zoom;
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show($"Error loading image from path: {ex.Message}", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        pictureBoxStudentPhoto.Image = null;
                                    }
                                }
                                else
                                {
                                    pictureBoxStudentPhoto.Image = null; // No photo path or file not found
                                }

                                EnableEditFields(true);
                            }
                            else
                            {
                                MessageBox.Show($"Student with number '{studentNumber}' not found.", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error loading student details: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void btnBrowsePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudentPhoto.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                currentPhotoPath = openFileDialog.FileName; // Store the full path
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"UPDATE students SET
                                            first_name = @FirstName,
                                            last_name = @LastName,
                                            email = @Email,
                                            birthdate = @Birthdate,
                                            gender = @Gender,
                                            mobile = @Mobile,
                                            address = @Address,
                                            course = @Course,
                                            state = @State,
                                            year = @Year,
                                            student_photo = @StudentPhoto
                                        WHERE student_number = @OriginalStudentNumber";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                        command.Parameters.AddWithValue("@LastName", txtLastName.Text);
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);
                        command.Parameters.AddWithValue("@Birthdate", dateTimePickerBirthdate.Value.Date);
                        command.Parameters.AddWithValue("@Gender", rdoMale.Checked ? "Male" : "Female");
                        command.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                        command.Parameters.AddWithValue("@Address", txtAddress.Text);
                        command.Parameters.AddWithValue("@Course", cmbCourse.SelectedItem?.ToString());
                        command.Parameters.AddWithValue("@State", cmbEnrollmentStatus.SelectedItem?.ToString());
                        command.Parameters.AddWithValue("@Year", cmbYear.SelectedItem?.ToString());

                        // Save the current photo path (it might be a new one if browsed)
                        command.Parameters.AddWithValue("@StudentPhoto", currentPhotoPath ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@OriginalStudentNumber", _studentNumberToEdit);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update student details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error updating student details: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtAddress.Clear();
            cmbCourse.SelectedIndex = -1;
            cmbEnrollmentStatus.SelectedIndex = -1;
            cmbYear.SelectedIndex = -1;
            pictureBoxStudentPhoto.Image = null;
            currentPhotoPath = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnableEditFields(bool enable)
        {
            txtFirstName.Enabled = enable;
            txtLastName.Enabled = enable;
            txtEmail.Enabled = enable;
            dateTimePickerBirthdate.Enabled = enable;
            rdoMale.Enabled = enable;
            rdoFemale.Enabled = enable;
            txtMobile.Enabled = enable;
            txtAddress.Enabled = enable;
            cmbCourse.Enabled = enable;
            cmbEnrollmentStatus.Enabled = enable;
            cmbYear.Enabled = enable;
            btnBrowsePhoto.Enabled = enable;
            btnUpdate.Enabled = enable;
            btnClear.Enabled = enable;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string studentNumberToDelete = txtStudentNumber.Text;

            if (string.IsNullOrEmpty(studentNumberToDelete))
            {
                MessageBox.Show("No student selected to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"Are you sure you want to delete student with Student Number: {studentNumberToDelete}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM students WHERE student_number = @StudentNumber";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@StudentNumber", studentNumberToDelete);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show($"Student with Student Number: {studentNumberToDelete} deleted successfully!", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.DialogResult = DialogResult.OK; // Indicate success when closing
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show($"Failed to delete student with Student Number: {studentNumberToDelete}.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"Database Error during delete: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}