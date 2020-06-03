namespace Library_Project
{
    partial class DepartmentMainForm
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
            this.DepartmentMainFormLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.DepartmentNoLable = new System.Windows.Forms.Label();
            this.DepartmentLocationTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.DepartmentNameLable = new System.Windows.Forms.Label();
            this.DepartmentLocationLable = new System.Windows.Forms.Label();
            this.DepartmentNameTextBox = new System.Windows.Forms.TextBox();
            this.DepartmentNoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DepartmentMainFormLabel
            // 
            this.DepartmentMainFormLabel.AutoSize = true;
            this.DepartmentMainFormLabel.BackColor = System.Drawing.Color.Black;
            this.DepartmentMainFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentMainFormLabel.ForeColor = System.Drawing.Color.Red;
            this.DepartmentMainFormLabel.Location = new System.Drawing.Point(192, 46);
            this.DepartmentMainFormLabel.Name = "DepartmentMainFormLabel";
            this.DepartmentMainFormLabel.Size = new System.Drawing.Size(223, 24);
            this.DepartmentMainFormLabel.TabIndex = 10;
            this.DepartmentMainFormLabel.Text = "Department Main Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(213, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "WELCOME";
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(403, 103);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(111, 30);
            this.SearchButton.TabIndex = 11;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // DepartmentNoLable
            // 
            this.DepartmentNoLable.AutoSize = true;
            this.DepartmentNoLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentNoLable.Location = new System.Drawing.Point(41, 111);
            this.DepartmentNoLable.Name = "DepartmentNoLable";
            this.DepartmentNoLable.Size = new System.Drawing.Size(131, 20);
            this.DepartmentNoLable.TabIndex = 12;
            this.DepartmentNoLable.Text = "Department No";
            this.DepartmentNoLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // DepartmentLocationTextBox
            // 
            this.DepartmentLocationTextBox.Location = new System.Drawing.Point(236, 177);
            this.DepartmentLocationTextBox.Name = "DepartmentLocationTextBox";
            this.DepartmentLocationTextBox.Size = new System.Drawing.Size(191, 20);
            this.DepartmentLocationTextBox.TabIndex = 13;
            this.DepartmentLocationTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(52, 236);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(111, 29);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(169, 235);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(111, 30);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(286, 234);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(111, 31);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(403, 234);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(111, 30);
            this.BackButton.TabIndex = 17;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DepartmentNameLable
            // 
            this.DepartmentNameLable.AutoSize = true;
            this.DepartmentNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentNameLable.Location = new System.Drawing.Point(41, 143);
            this.DepartmentNameLable.Name = "DepartmentNameLable";
            this.DepartmentNameLable.Size = new System.Drawing.Size(155, 20);
            this.DepartmentNameLable.TabIndex = 18;
            this.DepartmentNameLable.Text = "Department Name";
            // 
            // DepartmentLocationLable
            // 
            this.DepartmentLocationLable.AutoSize = true;
            this.DepartmentLocationLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentLocationLable.Location = new System.Drawing.Point(41, 177);
            this.DepartmentLocationLable.Name = "DepartmentLocationLable";
            this.DepartmentLocationLable.Size = new System.Drawing.Size(178, 20);
            this.DepartmentLocationLable.TabIndex = 19;
            this.DepartmentLocationLable.Text = "Department Location";
            // 
            // DepartmentNameTextBox
            // 
            this.DepartmentNameTextBox.Location = new System.Drawing.Point(236, 143);
            this.DepartmentNameTextBox.Name = "DepartmentNameTextBox";
            this.DepartmentNameTextBox.Size = new System.Drawing.Size(191, 20);
            this.DepartmentNameTextBox.TabIndex = 20;
            // 
            // DepartmentNoTextBox
            // 
            this.DepartmentNoTextBox.Location = new System.Drawing.Point(236, 113);
            this.DepartmentNoTextBox.Name = "DepartmentNoTextBox";
            this.DepartmentNoTextBox.Size = new System.Drawing.Size(115, 20);
            this.DepartmentNoTextBox.TabIndex = 21;
            // 
            // DepartmentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 374);
            this.Controls.Add(this.DepartmentNoTextBox);
            this.Controls.Add(this.DepartmentNameTextBox);
            this.Controls.Add(this.DepartmentLocationLable);
            this.Controls.Add(this.DepartmentNameLable);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DepartmentLocationTextBox);
            this.Controls.Add(this.DepartmentNoLable);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.DepartmentMainFormLabel);
            this.Controls.Add(this.label2);
            this.Name = "DepartmentMainForm";
            this.Text = "DepartmentMainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DepartmentMainFormLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label DepartmentNoLable;
        private System.Windows.Forms.TextBox DepartmentLocationTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label DepartmentNameLable;
        private System.Windows.Forms.Label DepartmentLocationLable;
        private System.Windows.Forms.TextBox DepartmentNameTextBox;
        private System.Windows.Forms.TextBox DepartmentNoTextBox;
    }
}