using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi; // Set AutoScaleMode to Dpi

            // Set the initial size of the form
            this.Size = new Size(1241, 771); // Replace with your desired initial width and height

            // Remove form borders
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnDashboard_Sidebar_Click(object sender, EventArgs e)
        {
            // Hide the form container (referencePanel) if it was being used
            if (referencePanel != null)
            {
                referencePanel.Visible = false;
            }

            // Make the main dashboard elements visible
            if (labelWelcome != null) labelWelcome.Visible = true;
            if (btnAddStudent_Central != null) btnAddStudent_Central.Visible = true;
            if (btnViewStudent_Central != null) btnViewStudent_Central.Visible = true;
            if (btnEditStudent_Central != null) btnEditStudent_Central.Visible = true;
        }

        private void btnAddStudent_Sidebar_Click(object sender, EventArgs e)
        {
            // Hide main dashboard elements by sending them to the back
            if (labelWelcome != null) labelWelcome.SendToBack();
            if (btnAddStudent_Central != null) btnAddStudent_Central.SendToBack();
            if (btnViewStudent_Central != null) btnViewStudent_Central.SendToBack();
            if (btnEditStudent_Central != null) btnEditStudent_Central.SendToBack();

            // Load the Add Student Detail form into referencePanel
            AddStudentForm addStudentForm = new AddStudentForm();
            LoadFormInReferencePanel(addStudentForm);
        }

        private void btnViewStudent_Sidebar_Click(object sender, EventArgs e)
        {
            // Hide main dashboard elements by sending them to the back
            if (labelWelcome != null) labelWelcome.SendToBack();
            if (btnAddStudent_Central != null) btnAddStudent_Central.SendToBack();
            if (btnViewStudent_Central != null) btnViewStudent_Central.SendToBack();
            if (btnEditStudent_Central != null) btnEditStudent_Central.SendToBack();

            // Load the View Student Detail form into referencePanel
            ViewStudentForm viewStudentForm = new ViewStudentForm();
            LoadFormInReferencePanel(viewStudentForm);
        }

        private void btnEditStudent_Sidebar_Click(object sender, EventArgs e)
        {
            // Hide main dashboard elements by sending them to the back
            if (labelWelcome != null) labelWelcome.SendToBack();
            if (btnAddStudent_Central != null) btnAddStudent_Central.SendToBack();
            if (btnViewStudent_Central != null) btnViewStudent_Central.SendToBack();
            if (btnEditStudent_Central != null) btnEditStudent_Central.SendToBack();

            // Load the Edit Student Detail form into referencePanel
            EditStudentForm editStudentForm = new EditStudentForm();
            LoadFormInReferencePanel(editStudentForm);
        }

        private void btnLogout_Sidebar_Click(object sender, EventArgs e)
        {
            // Optionally close this form and show the login form again
            this.Close();
            if (Application.OpenForms["MainForm"] != null)
            {
                Application.OpenForms["MainForm"].Show();
            }
        }

        private void btnAddStudent_Central_Click(object sender, EventArgs e)
        {
            // Hide main dashboard elements by sending them to the back
            if (labelWelcome != null) labelWelcome.SendToBack();
            if (btnAddStudent_Central != null) btnAddStudent_Central.SendToBack();
            if (btnViewStudent_Central != null) btnViewStudent_Central.SendToBack();
            if (btnEditStudent_Central != null) btnEditStudent_Central.SendToBack();

            // Load the Add Student Detail form into referencePanel
            AddStudentForm addStudentForm = new AddStudentForm();
            LoadFormInReferencePanel(addStudentForm);
        }

        private void btnViewStudent_Central_Click(object sender, EventArgs e)
        {
            // Hide main dashboard elements by sending them to the back
            if (labelWelcome != null) labelWelcome.SendToBack();
            if (btnAddStudent_Central != null) btnAddStudent_Central.SendToBack();
            if (btnViewStudent_Central != null) btnViewStudent_Central.SendToBack();
            if (btnEditStudent_Central != null) btnEditStudent_Central.SendToBack();

            // Load the View Student Detail form into referencePanel
            ViewStudentForm viewStudentForm = new ViewStudentForm();
            LoadFormInReferencePanel(viewStudentForm);
        }

        private void btnEditStudent_Central_Click(object sender, EventArgs e)
        {
            // Hide main dashboard elements by sending them to the back
            if (labelWelcome != null) labelWelcome.SendToBack();
            if (btnAddStudent_Central != null) btnAddStudent_Central.SendToBack();
            if (btnViewStudent_Central != null) btnViewStudent_Central.SendToBack();
            if (btnEditStudent_Central != null) btnEditStudent_Central.SendToBack();

            // Load the Edit Student Detail form into referencePanel
            EditStudentForm editStudentForm = new EditStudentForm();
            LoadFormInReferencePanel(editStudentForm);
        }

        private void LoadFormInReferencePanel(Form formToShow)
        {
            if (referencePanel != null)
            {
                // Clear any existing controls in the reference panel
                referencePanel.Controls.Clear();

                if (formToShow != null)
                {
                    // Set the form to be a top-level control (not the main window)
                    formToShow.TopLevel = false;

                    // Remove form borders
                    formToShow.FormBorderStyle = FormBorderStyle.None;

                    // Dock the form to fill the reference panel
                    formToShow.Dock = DockStyle.Fill;

                    // Add the form to the reference panel's controls
                    referencePanel.Controls.Add(formToShow);

                    // Make the reference panel visible
                    referencePanel.Visible = true;

                    // Show the form
                    formToShow.Show();
                }
                else
                {
                    // If formToShow is null, hide the reference panel
                    referencePanel.Visible = false;
                }
            }
        }

        private void ShowAddStudentForm()
        {
            LoadFormInReferencePanel(new AddStudentForm());
        }

        private void ShowViewStudentForm()
        {
            LoadFormInReferencePanel(/*new ViewStudentForm()*/ null);
        }

        private void ShowEditStudentForm()
        {
            LoadFormInReferencePanel(/*new EditStudentForm()*/ null);
        }
    }
}