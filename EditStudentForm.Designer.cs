// EditStudentForm.Designer.cs

namespace StudentManagementSystem
{
    partial class EditStudentForm
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.dateTimePickerBirthdate = new System.Windows.Forms.DateTimePicker();
            this.lblGender = new System.Windows.Forms.Label();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.lblMobile = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblStudentPhoto = new System.Windows.Forms.Label();
            this.pictureBoxStudentPhoto = new System.Windows.Forms.PictureBox();
            this.btnBrowsePhoto = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblEnrollmentStatus = new System.Windows.Forms.Label();
            this.cmbEnrollmentStatus = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudentPhoto)).BeginInit();
            this.SuspendLayout();
            //
            // lblFirstName
            //
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblFirstName.ForeColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Location = new System.Drawing.Point(14, 29);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(103, 20);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            //
            // txtFirstName
            //
            this.txtFirstName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.txtFirstName.Location = new System.Drawing.Point(179, 26);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(265, 27);
            this.txtFirstName.TabIndex = 1;
            //
            // lblLastName
            //
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(471, 29);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(101, 20);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            //
            // txtLastName
            //
            this.txtLastName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.txtLastName.Location = new System.Drawing.Point(653, 26);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(265, 27);
            this.txtLastName.TabIndex = 3;
            //
            // lblEmail
            //
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.Transparent;
            this.lblEmail.Location = new System.Drawing.Point(14, 78);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            //
            // txtEmail
            //
            this.txtEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.txtEmail.Location = new System.Drawing.Point(179, 75);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(265, 27);
            this.txtEmail.TabIndex = 5;
            //
            // lblBirthdate
            //
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblBirthdate.ForeColor = System.Drawing.Color.White;
            this.lblBirthdate.Location = new System.Drawing.Point(471, 78);
            this.lblBirthdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(91, 20);
            this.lblBirthdate.TabIndex = 6;
            this.lblBirthdate.Text = "Birthdate:";
            //
            // dateTimePickerBirthdate
            //
            this.dateTimePickerBirthdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.dateTimePickerBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirthdate.Location = new System.Drawing.Point(653, 75);
            this.dateTimePickerBirthdate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerBirthdate.Name = "dateTimePickerBirthdate";
            this.dateTimePickerBirthdate.Size = new System.Drawing.Size(265, 27);
            this.dateTimePickerBirthdate.TabIndex = 7;
            //
            // lblGender
            //
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblGender.ForeColor = System.Drawing.Color.Transparent;
            this.lblGender.Location = new System.Drawing.Point(14, 127);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(75, 20);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "Gender:";
            //
            // rdoMale
            //
            this.rdoMale.AutoSize = true;
            this.rdoMale.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.rdoMale.ForeColor = System.Drawing.Color.White;
            this.rdoMale.Location = new System.Drawing.Point(179, 125);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(4);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(69, 24);
            this.rdoMale.TabIndex = 9;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            //
            // rdoFemale
            //
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.rdoFemale.ForeColor = System.Drawing.Color.White;
            this.rdoFemale.Location = new System.Drawing.Point(256, 125);
            this.rdoFemale.Margin = new System.Windows.Forms.Padding(4);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(90, 24);
            this.rdoFemale.TabIndex = 10;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            //
            // lblMobile
            //
            this.lblMobile.AutoSize = true;
            this.lblMobile.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblMobile.ForeColor = System.Drawing.Color.White;
            this.lblMobile.Location = new System.Drawing.Point(471, 127);
            this.lblMobile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(69, 20);
            this.lblMobile.TabIndex = 11;
            this.lblMobile.Text = "Mobile:";
            //
            // txtMobile
            //
            this.txtMobile.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.txtMobile.Location = new System.Drawing.Point(653, 125);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(4);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(265, 27);
            this.txtMobile.TabIndex = 12;
            //
            // lblStudentNumber
            //
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblStudentNumber.ForeColor = System.Drawing.Color.Transparent;
            this.lblStudentNumber.Location = new System.Drawing.Point(14, 177);
            this.lblStudentNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(148, 20);
            this.lblStudentNumber.TabIndex = 13;
            this.lblStudentNumber.Text = "Student Number:";
            //
            // txtStudentNumber
            //
            this.txtStudentNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.txtStudentNumber.Location = new System.Drawing.Point(179, 174);
            this.txtStudentNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(265, 27);
            this.txtStudentNumber.TabIndex = 14;
            //
            // lblAddress
            //
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(471, 177);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(83, 20);
            this.lblAddress.TabIndex = 15;
            this.lblAddress.Text = "Address:";
            //
            // txtAddress
            //
            this.txtAddress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.txtAddress.Location = new System.Drawing.Point(653, 174);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(265, 73);
            this.txtAddress.TabIndex = 16;
            //
            // lblCourse
            //
            this.lblCourse.AutoSize = true;
            this.lblCourse.BackColor = System.Drawing.Color.Transparent;
            this.lblCourse.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblCourse.ForeColor = System.Drawing.Color.Transparent;
            this.lblCourse.Location = new System.Drawing.Point(14, 226);
            this.lblCourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(73, 20);
            this.lblCourse.TabIndex = 17;
            this.lblCourse.Text = "Course:";
            //
            // cmbCourse
            //
            this.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourse.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Items.AddRange(new object[] {
            "Hospitality Management",
            "Information Technology",
            "Business Management",
            "Tourism Management"});
            this.cmbCourse.Location = new System.Drawing.Point(179, 223);
            this.cmbCourse.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(265, 28);
            this.cmbCourse.TabIndex = 18;
            //
            // lblYear
            //
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblYear.ForeColor = System.Drawing.Color.Transparent;
            this.lblYear.Location = new System.Drawing.Point(14, 275);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(52, 20);
            this.lblYear.TabIndex = 21;
            this.lblYear.Text = "Year:";
            //
            // cmbYear
            //
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year"});
            this.cmbYear.Location = new System.Drawing.Point(179, 272);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(4);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(265, 28);
            this.cmbYear.TabIndex = 22;
            //
            // lblStudentPhoto
            //
            this.lblStudentPhoto.AutoSize = true;
            this.lblStudentPhoto.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentPhoto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblStudentPhoto.ForeColor = System.Drawing.Color.Transparent;
            this.lblStudentPhoto.Location = new System.Drawing.Point(12, 324);
            this.lblStudentPhoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentPhoto.Name = "lblStudentPhoto";
            this.lblStudentPhoto.Size = new System.Drawing.Size(129, 20);
            this.lblStudentPhoto.TabIndex = 23;
            this.lblStudentPhoto.Text = "Student Photo:";
            //
            // pictureBoxStudentPhoto
            //
            this.pictureBoxStudentPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxStudentPhoto.Location = new System.Drawing.Point(179, 324);
            this.pictureBoxStudentPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxStudentPhoto.Name = "pictureBoxStudentPhoto";
            this.pictureBoxStudentPhoto.Size = new System.Drawing.Size(199, 184);
            this.pictureBoxStudentPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStudentPhoto.TabIndex = 24;
            this.pictureBoxStudentPhoto.TabStop = false;
            //
            // btnBrowsePhoto
            //
            this.btnBrowsePhoto.BackColor = System.Drawing.Color.Salmon;
            this.btnBrowsePhoto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.btnBrowsePhoto.ForeColor = System.Drawing.Color.White;
            this.btnBrowsePhoto.Location = new System.Drawing.Point(224, 516);
            this.btnBrowsePhoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowsePhoto.Name = "btnBrowsePhoto";
            this.btnBrowsePhoto.Size = new System.Drawing.Size(112, 33);
            this.btnBrowsePhoto.TabIndex = 25;
            this.btnBrowsePhoto.Text = "Browse";
            this.btnBrowsePhoto.UseVisualStyleBackColor = false;
            this.btnBrowsePhoto.Click += new System.EventHandler(this.btnBrowsePhoto_Click);
            //
            // btnUpdate
            //
            this.btnUpdate.BackColor = System.Drawing.Color.Salmon;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(466, 365);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 37);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            //
            // btnClear
            //
            this.btnClear.BackColor = System.Drawing.Color.Salmon;
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(696, 365);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 37);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            //
            // btnCancel
            //
            this.btnCancel.BackColor = System.Drawing.Color.Salmon;
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(811, 365);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 37);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            //
            // lblEnrollmentStatus
            //
            this.lblEnrollmentStatus.AutoSize = true;
            this.lblEnrollmentStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblEnrollmentStatus.ForeColor = System.Drawing.Color.White;
            this.lblEnrollmentStatus.Location = new System.Drawing.Point(471, 263);
            this.lblEnrollmentStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnrollmentStatus.Name = "lblEnrollmentStatus";
            this.lblEnrollmentStatus.Size = new System.Drawing.Size(159, 20);
            this.lblEnrollmentStatus.TabIndex = 19;
            this.lblEnrollmentStatus.Text = "Enrollment Status:";
            //
            // cmbEnrollmentStatus
            //
            this.cmbEnrollmentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnrollmentStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.cmbEnrollmentStatus.FormattingEnabled = true;
            this.cmbEnrollmentStatus.Items.AddRange(new object[] {
            "Enrolled",
            "On Leave",
            "Graduated",
            "Dropped Out",
            "Suspended"});
            this.cmbEnrollmentStatus.Location = new System.Drawing.Point(653, 260);
            this.cmbEnrollmentStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEnrollmentStatus.Name = "cmbEnrollmentStatus";
            this.cmbEnrollmentStatus.Size = new System.Drawing.Size(265, 28);
            this.cmbEnrollmentStatus.TabIndex = 20;
            //
            // btnDelete
            //
            this.btnDelete.BackColor = System.Drawing.Color.Salmon;
            this.btnDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(581, 365);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 37);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // EditStudentForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(931, 575);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBrowsePhoto);
            this.Controls.Add(this.pictureBoxStudentPhoto);
            this.Controls.Add(this.lblStudentPhoto);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.cmbEnrollmentStatus);
            this.Controls.Add(this.lblEnrollmentStatus);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtStudentNumber);
            this.Controls.Add(this.lblStudentNumber);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.dateTimePickerBirthdate);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditStudentForm";
            this.Text = "Edit Student Detail";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudentPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthdate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblStudentPhoto;
        private System.Windows.Forms.PictureBox pictureBoxStudentPhoto;
        private System.Windows.Forms.Button btnBrowsePhoto;
        private System.Windows.Forms.Button btnUpdate; // Renamed to btnUpdate
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblEnrollmentStatus;
        private System.Windows.Forms.ComboBox cmbEnrollmentStatus;
        private System.Windows.Forms.Button btnDelete;
    }
}