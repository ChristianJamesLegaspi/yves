// ViewStudentForm.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
// using System.Data.SqlClient; // Comment out the SQL Server namespace
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Import the MySQL namespace

namespace StudentManagementSystem
{
    public partial class ViewStudentForm : Form
    {
        private List<Student> studentList = new List<Student>();
        // Update the connection string for MySQL
        private string connectionString = "Server=localhost;Database=student_management_db;Uid=root;Pwd=your_strong_password;";
        private string selectedStudentNumber;

        public ViewStudentForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadAllStudents();
            btnEditSelected.Enabled = false;
        }

        private void InitializeDataGridView()
        {
            // Configure the DataGridView to display student data
            dataGridViewStudents.AutoGenerateColumns = false;
            dataGridViewStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStudents.ReadOnly = true;
            dataGridViewStudents.AllowUserToAddRows = false; // Prevent users from adding rows directly
            dataGridViewStudents.AllowUserToDeleteRows = false; // Prevent users from deleting rows

            // Define the columns.  Make sure these match the properties of the Student class.
            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StudentNumber", HeaderText = "Student Number", Name = "StudentNumber" });
            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FirstName", HeaderText = "First Name", Name = "FirstName" });
            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LastName", HeaderText = "Last Name", Name = "LastName" });
            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Email", HeaderText = "Email", Name = "Email" });
            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Birthdate", HeaderText = "Birthdate", Name = "Birthdate" });
            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Gender", HeaderText = "Gender", Name = "Gender" });
            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Mobile", HeaderText = "Mobile", Name = "Mobile" });
            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Address", HeaderText = "Address", Name = "Address" });
            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Course", HeaderText = "Course", Name = "Course" });
            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "EnrollmentStatus", HeaderText = "Enrollment Status", Name = "EnrollmentStatus" });
            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Year", HeaderText = "Year", Name = "Year" });

            //Make sure the Student Photo is not shown as a column.
            dataGridViewStudents.Columns.Add(new DataGridViewImageColumn { DataPropertyName = "StudentPhoto", HeaderText = "Student Photo", Name = "StudentPhoto" });
            dataGridViewStudents.Columns["StudentPhoto"].Visible = false;
        }

        private void LoadAllStudents()
        {
            studentList.Clear(); // Clear the list before loading
            using (MySqlConnection connection = new MySqlConnection(connectionString)) // Use MySqlConnection
            {
                try
                {
                    connection.Open();
                    string query = "SELECT student_number, first_name, last_name, email, birthdate, gender, mobile, address, course, state, year, student_photo FROM students";
                    using (MySqlCommand command = new MySqlCommand(query, connection)) // Use MySqlCommand
                    {
                        using (MySqlDataReader reader = command.ExecuteReader()) // Use MySqlDataReader
                        {
                            while (reader.Read())
                            {
                                Student student = new Student
                                {
                                    StudentNumber = reader["student_number"].ToString(),
                                    FirstName = reader["first_name"].ToString(),
                                    LastName = reader["last_name"].ToString(),
                                    Email = reader["email"].ToString(),
                                    Birthdate = Convert.ToDateTime(reader["birthdate"]),
                                    Gender = reader["gender"].ToString(),
                                    Mobile = reader["mobile"].ToString(),
                                    Address = reader["address"].ToString(),
                                    Course = reader["course"].ToString(),
                                    EnrollmentStatus = reader["state"].ToString(), // Corrected to "state"
                                    Year = reader["year"].ToString(),
                                    // Handle the photo.  Store the path, not the image itself, in the Student class.
                                    StudentPhotoPath = reader["student_photo"].ToString()
                                };
                                studentList.Add(student);
                            }
                        }
                    }
                    dataGridViewStudents.DataSource = null; // Important: Clear the data source *before* setting it again.
                    dataGridViewStudents.DataSource = studentList; // Bind the list to the DataGridView
                    lblTotalStudents.Text = $"Total Students: {studentList.Count}"; //update count
                }
                catch (MySqlException ex) // Catch MySqlException
                {
                    MessageBox.Show($"Error loading student data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();

            // Use LINQ to filter the student list based on the search criteria
            List<Student> filteredList = studentList.Where(student =>
                student.StudentNumber.ToLower().Contains(searchText) ||
                student.FirstName.ToLower().Contains(searchText) ||
                student.LastName.ToLower().Contains(searchText) ||
                student.Address.ToLower().Contains(searchText)
            ).ToList();

            dataGridViewStudents.DataSource = null;
            dataGridViewStudents.DataSource = filteredList;
            lblTotalStudents.Text = $"Total Students: {filteredList.Count}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditSelected_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedStudentNumber))
            {
                OpenEditStudentForm(selectedStudentNumber);
            }
            else
            {
                MessageBox.Show("Please select a student to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                // Get the StudentNumber from the selected row
                selectedStudentNumber = dataGridViewStudents.SelectedRows[0].Cells["StudentNumber"].Value.ToString();
                btnEditSelected.Enabled = true; // Enable the Edit button
            }
            else
            {
                selectedStudentNumber = null;
                btnEditSelected.Enabled = false; // Disable the Edit button if no row is selected
            }
        }

        private void dataGridViewStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the StudentNumber from the clicked row
                string studentNumber = dataGridViewStudents.Rows[e.RowIndex].Cells["StudentNumber"].Value.ToString();
                OpenEditStudentForm(studentNumber);
            }
        }

        private void OpenEditStudentForm(string studentNumberToEdit)
        {
            EditStudentForm editForm = new EditStudentForm(studentNumberToEdit);
            editForm.TopLevel = false;
            editForm.FormBorderStyle = FormBorderStyle.None;
            editForm.Dock = DockStyle.Fill;
            // Assuming 'referencePanel' is in your main DashboardForm where you are displaying these forms
            Form parentForm = this.ParentForm;
            if (parentForm != null)
            {
                Panel referencePanel = parentForm.Controls.Find("referencePanel", true)[0] as Panel;
                if (referencePanel != null)
                {
                    referencePanel.Controls.Clear();
                    referencePanel.Controls.Add(editForm);
                    referencePanel.Tag = editForm;
                    editForm.BringToFront();
                    editForm.Show();
                    referencePanel.Visible = true;
                    this.Close(); // Close the View form after opening the Edit form (optional)
                }
                else
                {
                    MessageBox.Show("Error: 'referencePanel' not found in the parent form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error: This form does not have a parent form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    // Class to represent a student. This makes it easier to work with the data.
    public class Student
    {
        public string StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public string Gender { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string Course { get; set; }
        public string EnrollmentStatus { get; set; }
        public string Year { get; set; }
        public string StudentPhotoPath { get; set; } // Store the file path
        public Image StudentPhoto
        {
            get
            {
                if (string.IsNullOrEmpty(StudentPhotoPath) || !File.Exists(StudentPhotoPath))
                {
                    return null; // Or return a default "no image" image
                }
                try
                {
                    return Image.FromFile(StudentPhotoPath);
                }
                catch
                {
                    return null; // Handle any exceptions during image loading
                }
            }
        }
    }
}