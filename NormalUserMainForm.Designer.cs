namespace Library_Project
{
    partial class NormalUserMainForm
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
            this.NormalUserLabel = new System.Windows.Forms.Label();
            this.NormalUserLoginFormLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NormalUserLabel
            // 
            this.NormalUserLabel.AutoSize = true;
            this.NormalUserLabel.BackColor = System.Drawing.Color.Yellow;
            this.NormalUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NormalUserLabel.ForeColor = System.Drawing.Color.Red;
            this.NormalUserLabel.Location = new System.Drawing.Point(169, 116);
            this.NormalUserLabel.Name = "NormalUserLabel";
            this.NormalUserLabel.Size = new System.Drawing.Size(128, 25);
            this.NormalUserLabel.TabIndex = 0;
            this.NormalUserLabel.Text = "WELCOME";
            // 
            // NormalUserLoginFormLabel
            // 
            this.NormalUserLoginFormLabel.AutoSize = true;
            this.NormalUserLoginFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NormalUserLoginFormLabel.ForeColor = System.Drawing.Color.Blue;
            this.NormalUserLoginFormLabel.Location = new System.Drawing.Point(159, 171);
            this.NormalUserLoginFormLabel.Name = "NormalUserLoginFormLabel";
            this.NormalUserLoginFormLabel.Size = new System.Drawing.Size(181, 24);
            this.NormalUserLoginFormLabel.TabIndex = 8;
            this.NormalUserLoginFormLabel.Text = "Normal User Form";
            // 
            // NormalUserMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 358);
            this.Controls.Add(this.NormalUserLoginFormLabel);
            this.Controls.Add(this.NormalUserLabel);
            this.Name = "NormalUserMainForm";
            this.Text = "NormalUserMainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NormalUserLabel;
        private System.Windows.Forms.Label NormalUserLoginFormLabel;
    }
}