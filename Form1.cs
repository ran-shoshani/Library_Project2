using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace Library_Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IUserController objUserControllerImpl = new UserControllerImpl();
            UserLoginDTO objUserLoginDTO = objUserControllerImpl.validateUserLogin(textBox1.Text, textBox2.Text);

            if (objUserLoginDTO == null)
            {
                MessageBox.Show("Invalid Username or Password");
            }
            else
            {
                if (objUserLoginDTO.UserLevel == 1)
                {
                    NormalUserMainForm objNormalUserMainForm = new NormalUserMainForm();
                    objNormalUserMainForm.ShowDialog();
                }
                else if (objUserLoginDTO.UserLevel == 2)
                {
                    // send to stuitable page....
                }
                else if (objUserLoginDTO.UserLevel == 3)
                {
                    // send to stuitable page....
                    //MessageBox.Show("You are a guest user, you don't have access to this system yet");
                    AdminUserMainForm objAdminUserMainForm = new AdminUserMainForm();
                    objAdminUserMainForm.ShowDialog();
                }
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
