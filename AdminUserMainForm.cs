using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Project
{
    public partial class AdminUserMainForm : Form
    {
        public AdminUserMainForm()
        {
            InitializeComponent();
        }

        private void DepartmentMainFormButton_Click(object sender, EventArgs e) // NOT IN USE
        {
            DepartmentMainForm objDepartmentMainForm = new DepartmentMainForm();
            objDepartmentMainForm.ShowDialog();

        }

        private void AuthorMainFormButton(object sender, EventArgs e)
        {
            AuthorMainForm objAuthorMainForm = new AuthorMainForm();
            objAuthorMainForm.ShowDialog();
        }
    }
}
