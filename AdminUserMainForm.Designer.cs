namespace Library_Project
{
    partial class AdminUserMainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.AdminUserFormLabel = new System.Windows.Forms.Label();
            this.DepartmentMainFormButton = new System.Windows.Forms.Button();
            this.AuthorMainFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(238, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME";
            // 
            // AdminUserFormLabel
            // 
            this.AdminUserFormLabel.AutoSize = true;
            this.AdminUserFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminUserFormLabel.ForeColor = System.Drawing.Color.Blue;
            this.AdminUserFormLabel.Location = new System.Drawing.Point(222, 35);
            this.AdminUserFormLabel.Name = "AdminUserFormLabel";
            this.AdminUserFormLabel.Size = new System.Drawing.Size(174, 24);
            this.AdminUserFormLabel.TabIndex = 8;
            this.AdminUserFormLabel.Text = "Admin User Form";
            // 
            // DepartmentMainFormButton
            // 
            this.DepartmentMainFormButton.BackColor = System.Drawing.Color.YellowGreen;
            this.DepartmentMainFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentMainFormButton.Location = new System.Drawing.Point(180, 198);
            this.DepartmentMainFormButton.Name = "DepartmentMainFormButton";
            this.DepartmentMainFormButton.Size = new System.Drawing.Size(246, 41);
            this.DepartmentMainFormButton.TabIndex = 9;
            this.DepartmentMainFormButton.Text = "Department Main Form";
            this.DepartmentMainFormButton.UseVisualStyleBackColor = false;
            this.DepartmentMainFormButton.Click += new System.EventHandler(this.DepartmentMainFormButton_Click);
            // 
            // AuthorMainFormButton
            // 
            this.AuthorMainFormButton.BackColor = System.Drawing.Color.YellowGreen;
            this.AuthorMainFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorMainFormButton.Location = new System.Drawing.Point(180, 134);
            this.AuthorMainFormButton.Name = "AuthorMainFormButton";
            this.AuthorMainFormButton.Size = new System.Drawing.Size(246, 41);
            this.AuthorMainFormButton.TabIndex = 10;
            this.AuthorMainFormButton.Text = "Author Main Form";
            this.AuthorMainFormButton.UseVisualStyleBackColor = false;
            this.AuthorMainFormButton.Click += new System.EventHandler(this.AuthorMainFormButton);
            // 
            // AdminUserMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 325);
            this.Controls.Add(this.AuthorMainFormButton);
            this.Controls.Add(this.DepartmentMainFormButton);
            this.Controls.Add(this.AdminUserFormLabel);
            this.Controls.Add(this.label1);
            this.Name = "AdminUserMainForm";
            this.Text = "AdminUserMainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AdminUserFormLabel;
        private System.Windows.Forms.Button DepartmentMainFormButton;
        private System.Windows.Forms.Button AuthorMainFormButton;
    }
}