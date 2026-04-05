namespace StudentManagementSystem
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelEmailLogin = new System.Windows.Forms.Label();
            this.txtEmailLogin = new System.Windows.Forms.TextBox();
            this.labelPasswordLogin = new System.Windows.Forms.Label();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEmailLogin
            // 
            this.labelEmailLogin.AutoSize = true;
            this.labelEmailLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.labelEmailLogin.ForeColor = System.Drawing.Color.White;
            this.labelEmailLogin.Location = new System.Drawing.Point(282, 70);
            this.labelEmailLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmailLogin.Name = "labelEmailLogin";
            this.labelEmailLogin.Size = new System.Drawing.Size(63, 23);
            this.labelEmailLogin.TabIndex = 0;
            this.labelEmailLogin.Text = "Email";
            // 
            // txtEmailLogin
            // 
            this.txtEmailLogin.BackColor = System.Drawing.Color.MistyRose;
            this.txtEmailLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtEmailLogin.Location = new System.Drawing.Point(286, 97);
            this.txtEmailLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailLogin.Name = "txtEmailLogin";
            this.txtEmailLogin.Size = new System.Drawing.Size(499, 31);
            this.txtEmailLogin.TabIndex = 1;
            // 
            // labelPasswordLogin
            // 
            this.labelPasswordLogin.AutoSize = true;
            this.labelPasswordLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.labelPasswordLogin.ForeColor = System.Drawing.Color.White;
            this.labelPasswordLogin.Location = new System.Drawing.Point(282, 158);
            this.labelPasswordLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPasswordLogin.Name = "labelPasswordLogin";
            this.labelPasswordLogin.Size = new System.Drawing.Size(107, 23);
            this.labelPasswordLogin.TabIndex = 2;
            this.labelPasswordLogin.Text = "Password";
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.BackColor = System.Drawing.Color.MistyRose;
            this.txtPasswordLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtPasswordLogin.Location = new System.Drawing.Point(286, 185);
            this.txtPasswordLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.PasswordChar = '*';
            this.txtPasswordLogin.Size = new System.Drawing.Size(499, 31);
            this.txtPasswordLogin.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Salmon;
            this.btnLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(470, 292);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(141, 48);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1113, 430);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPasswordLogin);
            this.Controls.Add(this.labelPasswordLogin);
            this.Controls.Add(this.txtEmailLogin);
            this.Controls.Add(this.labelEmailLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmailLogin;
        private System.Windows.Forms.TextBox txtEmailLogin;
        private System.Windows.Forms.Label labelPasswordLogin;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.Button btnLogin;
    }
}