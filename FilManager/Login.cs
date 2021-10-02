using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            Register _Register = new Register();
            _Register.ShowDialog();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < userListDataSet.USER.Count; i++) 
            {
                if ((string) userListDataSet.Tables[0].Rows[i].ItemArray[1] ==
                    textBox_Email.Text)
                {
                    if ((string)userListDataSet.Tables[0].Rows[i].ItemArray[2] ==
                    textBox_Password.Text)
                    {
                        MainPage _MainPage = new MainPage();
                        _MainPage.Show();
                        this.Close();
                    }
                    else
                    {
                        label_Error.Text = "Password is invalid";
                    }
                }
                else
                {
                    label_Error.Text = "Email is invalid";
                }
            }
        }

        bool Email => textBox_Email.Text.Contains("@") && textBox_Email.Text.Contains(".");
        bool Password => textBox_Password.Text.Length >= 6;
        void LoginEnable()
        {
            button_Login.Enabled = Email && Password;
        }

        private void textBox_Email_TextChanged(object sender, EventArgs e)
        {
            LoginEnable();
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {
            LoginEnable();
        }
    }
}
