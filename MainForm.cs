using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StudentManagementSystem
{
    public partial class dashboardHostPanel : Form
    {
        private LoginForm loginForm;
        private RegisterForm registerForm;
        private int _loggedInUserId;
        private string _loggedInFullName;
        private string _loggedInEmail;
        private Form currentChildForm; // To track the currently displayed child form

        // Default constructor (used when the MainForm is initially created)
        public dashboardHostPanel()
        {
            InitializeComponent();
            loginForm = new LoginForm();
            registerForm = new RegisterForm();

            // Configure Login Form
            loginForm.TopLevel = false;
            loginForm.FormBorderStyle = FormBorderStyle.None;
            loginForm.Dock = DockStyle.Fill;

            // Configure Register Form
            registerForm.TopLevel = false;
            registerForm.FormBorderStyle = FormBorderStyle.None;
            registerForm.Dock = DockStyle.Fill;

            // Initially show the register form in panelContainer
            ShowRegisterForm();
        }

        // Constructor that accepts user information from LoginForm
        public dashboardHostPanel(int userId, string fullName, string email)
        {
            InitializeComponent();
            _loggedInUserId = userId;
            _loggedInFullName = fullName;
            _loggedInEmail = email;
            loginForm = new LoginForm();
            registerForm = new RegisterForm();

            // Configure Login Form
            loginForm.TopLevel = false;
            loginForm.FormBorderStyle = FormBorderStyle.None;
            loginForm.Dock = DockStyle.Fill;

            // Configure Register Form
            registerForm.TopLevel = false;
            registerForm.FormBorderStyle = FormBorderStyle.None;
            registerForm.Dock = DockStyle.Fill;

            // Optionally show a welcome message
            MessageBox.Show($"Welcome, {_loggedInFullName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // After successful login, show the Dashboard in referencePanel
            ShowDashboardForm();
        }

        private void btnRegister_Main_Click(object sender, EventArgs e)
        {
            ShowRegisterForm();
        }

        private void btnLogin_Main_Click(object sender, EventArgs e)
        {
            ShowLoginForm();
        }

        public void ShowLoginForm()
        {
            HideCurrentChildForm();
            panelContainer.Controls.Clear(); // Clear panelContainer
            panelContainer.Controls.Add(loginForm);
            loginForm.Show();
            currentChildForm = loginForm;
        }

        public void ShowRegisterForm()
        {
            HideCurrentChildForm();
            panelContainer.Controls.Clear(); // Clear panelContainer
            panelContainer.Controls.Add(registerForm);
            registerForm.Show();
            currentChildForm = registerForm;
        }

        private void HideCurrentChildForm()
        {
            if (currentChildForm != null)
            {
                currentChildForm.Hide();
            }
        }

        private void ShowDashboardForm()
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.TopLevel = false;
            dashboardForm.FormBorderStyle = FormBorderStyle.None;
            dashboardForm.Dock = DockStyle.Fill;

            // Explicitly set the parent of the DashboardForm
            dashboardForm.Parent = this.referencePanel;

            // Clear any existing controls in referencePanel
            referencePanel.Controls.Clear();

            // Add the DashboardForm to referencePanel's controls
            referencePanel.Controls.Add(dashboardForm);

            referencePanel.Visible = true;
            dashboardForm.Show();
            currentChildForm = dashboardForm;
        }
    }
}