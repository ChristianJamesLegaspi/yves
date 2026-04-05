namespace StudentManagementSystem
{
    partial class dashboardHostPanel
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
            this.btnRegister_Main = new System.Windows.Forms.Button();
            this.btnLogin_Main = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.referencePanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegister_Main
            // 
            this.btnRegister_Main.BackColor = System.Drawing.Color.Salmon;
            this.btnRegister_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister_Main.ForeColor = System.Drawing.Color.White;
            this.btnRegister_Main.Location = new System.Drawing.Point(521, 66);
            this.btnRegister_Main.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister_Main.Name = "btnRegister_Main";
            this.btnRegister_Main.Size = new System.Drawing.Size(139, 35);
            this.btnRegister_Main.TabIndex = 0;
            this.btnRegister_Main.Text = "Register";
            this.btnRegister_Main.UseVisualStyleBackColor = false;
            this.btnRegister_Main.Click += new System.EventHandler(this.btnRegister_Main_Click);
            // 
            // btnLogin_Main
            // 
            this.btnLogin_Main.BackColor = System.Drawing.Color.Salmon;
            this.btnLogin_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin_Main.ForeColor = System.Drawing.Color.White;
            this.btnLogin_Main.Location = new System.Drawing.Point(672, 66);
            this.btnLogin_Main.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin_Main.Name = "btnLogin_Main";
            this.btnLogin_Main.Size = new System.Drawing.Size(139, 35);
            this.btnLogin_Main.TabIndex = 1;
            this.btnLogin_Main.Text = "Login";
            this.btnLogin_Main.UseVisualStyleBackColor = false;
            this.btnLogin_Main.Click += new System.EventHandler(this.btnLogin_Main_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.Location = new System.Drawing.Point(125, 121);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1131, 477);
            this.panelContainer.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLogin_Main);
            this.panel1.Controls.Add(this.btnRegister_Main);
            this.panel1.Controls.Add(this.panelContainer);
            this.panel1.Location = new System.Drawing.Point(1, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1383, 645);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(516, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin Login | Register";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(336, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(688, 54);
            this.label2.TabIndex = 4;
            this.label2.Text = "Student Management System";
            // 
            // referencePanel
            // 
            this.referencePanel.BackColor = System.Drawing.Color.Transparent;
            this.referencePanel.Location = new System.Drawing.Point(1, -6);
            this.referencePanel.Name = "referencePanel";
            this.referencePanel.Size = new System.Drawing.Size(1385, 771);
            this.referencePanel.TabIndex = 6;
            this.referencePanel.Visible = false;
            // 
            // dashboardHostPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1379, 777);
            this.Controls.Add(this.referencePanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "dashboardHostPanel";
            this.Text = "Student Management System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister_Main;
        private System.Windows.Forms.Button btnLogin_Main;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel referencePanel;
    }
}