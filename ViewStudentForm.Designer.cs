namespace StudentManagementSystem
{
    partial class ViewStudentForm
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTotalStudents = new System.Windows.Forms.Label();
            this.btnEditSelected = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(14, 20);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(72, 20);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.txtSearch.Location = new System.Drawing.Point(94, 17);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(317, 27);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Salmon;
            this.btnSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(420, 15);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AllowUserToDeleteRows = false;
            this.dataGridViewStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStudents.BackgroundColor = System.Drawing.Color.LightCoral;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(17, 82);
            this.dataGridViewStudents.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.Size = new System.Drawing.Size(897, 400);
            this.dataGridViewStudents.TabIndex = 3;
            this.dataGridViewStudents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellDoubleClick);
            this.dataGridViewStudents.SelectionChanged += new System.EventHandler(this.dataGridViewStudents_SelectionChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Salmon;
            this.btnClose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(797, 518);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 37);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTotalStudents
            // 
            this.lblTotalStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblTotalStudents.ForeColor = System.Drawing.Color.White;
            this.lblTotalStudents.Location = new System.Drawing.Point(14, 525);
            this.lblTotalStudents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalStudents.Name = "lblTotalStudents";
            this.lblTotalStudents.Size = new System.Drawing.Size(147, 20);
            this.lblTotalStudents.TabIndex = 5;
            this.lblTotalStudents.Text = "Total Students: 0";
            // 
            // btnEditSelected
            // 
            this.btnEditSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditSelected.BackColor = System.Drawing.Color.Salmon;
            this.btnEditSelected.Enabled = false;
            this.btnEditSelected.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.btnEditSelected.ForeColor = System.Drawing.Color.White;
            this.btnEditSelected.Location = new System.Drawing.Point(659, 517);
            this.btnEditSelected.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditSelected.Name = "btnEditSelected";
            this.btnEditSelected.Size = new System.Drawing.Size(117, 37);
            this.btnEditSelected.TabIndex = 6;
            this.btnEditSelected.Text = "Edit";
            this.btnEditSelected.UseVisualStyleBackColor = false;
            this.btnEditSelected.Click += new System.EventHandler(this.btnEditSelected_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteSelected.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteSelected.Enabled = false;
            this.btnDeleteSelected.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.btnDeleteSelected.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeleteSelected.Location = new System.Drawing.Point(922, 549);
            this.btnDeleteSelected.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(117, 37);
            this.btnDeleteSelected.TabIndex = 7;
            this.btnDeleteSelected.Text = "Delete";
            this.btnDeleteSelected.UseVisualStyleBackColor = false;
            // 
            // ViewStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(931, 565);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.btnEditSelected);
            this.Controls.Add(this.lblTotalStudents);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewStudentForm";
            this.Text = "View Students";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTotalStudents;
        private System.Windows.Forms.Button btnEditSelected;
        private System.Windows.Forms.Button btnDeleteSelected;
    }
}
