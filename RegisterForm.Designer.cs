namespace StudentManagementSystem
{
    partial class RegisterForm
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
            this.labelFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.labelEmailRegister = new System.Windows.Forms.Label();
            this.txtEmailRegister = new System.Windows.Forms.TextBox();
            this.labelPasswordRegister = new System.Windows.Forms.Label();
            this.txtPasswordRegister = new System.Windows.Forms.TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.labelFullName.ForeColor = System.Drawing.Color.White;
            this.labelFullName.Location = new System.Drawing.Point(273, 24);
            this.labelFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(67, 23);
            this.labelFullName.TabIndex = 0;
            this.labelFullName.Text = "Name";
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.MistyRose;
            this.txtFullName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtFullName.Location = new System.Drawing.Point(277, 51);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(510, 31);
            this.txtFullName.TabIndex = 1;
            // 
            // labelEmailRegister
            // 
            this.labelEmailRegister.AutoSize = true;
            this.labelEmailRegister.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.labelEmailRegister.ForeColor = System.Drawing.Color.White;
            this.labelEmailRegister.Location = new System.Drawing.Point(273, 104);
            this.labelEmailRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmailRegister.Name = "labelEmailRegister";
            this.labelEmailRegister.Size = new System.Drawing.Size(63, 23);
            this.labelEmailRegister.TabIndex = 2;
            this.labelEmailRegister.Text = "Email";
            // 
            // txtEmailRegister
            // 
            this.txtEmailRegister.BackColor = System.Drawing.Color.MistyRose;
            this.txtEmailRegister.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtEmailRegister.Location = new System.Drawing.Point(277, 131);
            this.txtEmailRegister.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailRegister.Name = "txtEmailRegister";
            this.txtEmailRegister.Size = new System.Drawing.Size(510, 31);
            this.txtEmailRegister.TabIndex = 3;
            // 
            // labelPasswordRegister
            // 
            this.labelPasswordRegister.AutoSize = true;
            this.labelPasswordRegister.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.labelPasswordRegister.ForeColor = System.Drawing.Color.White;
            this.labelPasswordRegister.Location = new System.Drawing.Point(273, 186);
            this.labelPasswordRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPasswordRegister.Name = "labelPasswordRegister";
            this.labelPasswordRegister.Size = new System.Drawing.Size(107, 23);
            this.labelPasswordRegister.TabIndex = 4;
            this.labelPasswordRegister.Text = "Password";
            // 
            // txtPasswordRegister
            // 
            this.txtPasswordRegister.BackColor = System.Drawing.Color.MistyRose;
            this.txtPasswordRegister.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtPasswordRegister.Location = new System.Drawing.Point(277, 213);
            this.txtPasswordRegister.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswordRegister.Name = "txtPasswordRegister";
            this.txtPasswordRegister.PasswordChar = '*';
            this.txtPasswordRegister.Size = new System.Drawing.Size(510, 31);
            this.txtPasswordRegister.TabIndex = 5;
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.labelConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.labelConfirmPassword.Location = new System.Drawing.Point(273, 273);
            this.labelConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(190, 23);
            this.labelConfirmPassword.TabIndex = 6;
            this.labelConfirmPassword.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.MistyRose;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(277, 300);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(510, 31);
            this.txtConfirmPassword.TabIndex = 7;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Salmon;
            this.btnRegister.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(445, 357);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(175, 59);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1113, 430);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.txtPasswordRegister);
            this.Controls.Add(this.labelPasswordRegister);
            this.Controls.Add(this.txtEmailRegister);
            this.Controls.Add(this.labelEmailRegister);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.labelFullName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label labelEmailRegister;
        private System.Windows.Forms.TextBox txtEmailRegister;
        private System.Windows.Forms.Label labelPasswordRegister;
        private System.Windows.Forms.TextBox txtPasswordRegister;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnRegister;
    }
}