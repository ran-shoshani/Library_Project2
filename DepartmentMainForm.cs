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
    public partial class DepartmentMainForm : Form
    {
        public DepartmentMainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Dispose(); // go back to previous form/page
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DepartmentNoTextBox.Clear();
            DepartmentNameTextBox.Clear();
            DepartmentLocationTextBox.Clear();
        }
    }
}
