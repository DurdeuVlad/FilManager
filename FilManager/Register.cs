using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FilManager
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            DataRow newEntry = userListDataSet.USER.NewRow();
            newEntry[0] = ""+userListDataSet.USER.Count+1;
            newEntry[1] = textBox_Email.Text; //EMAIL
            newEntry[2] = textBox_Password.Text; //PASSWORD
            newEntry[3] = ""+DateTime.Now; //DATE_REGISTER
            userListDataSet.USER.Rows.InsertAt(newEntry, userListDataSet.USER.Count + 1);
            tableAdapterManager.UserUpdateTableAdapter.Fill(userListDataSet);
            this.Close();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            button_Register.Enabled = false;
        }

        bool EmailConfirmation => textBox_Email.Text == textBox_ConfirmEmail.Text;
        bool Email => textBox_Email.Text.Contains("@") && textBox_Email.Text.Contains(".");
        bool Password => textBox_Password.Text.Length >= 6;
        bool PasswordConfirmation => textBox_Password.Text == textBox_ConfirmPassword.Text;
        bool VerificationSuccessful => EmailConfirmation && Email && Password && PasswordConfirmation;

        void ActivateRegisterButton()
        {
            button_Register.Enabled = VerificationSuccessful;
        }

        void ModifyError(string text) { 
        
           label_Error.Text = text;   
        }

        void ClearError()
        {
            label_Error.Text = "";
        }

        private void textBox_Email_TextChanged(object sender, EventArgs e)
        {
            ActivateRegisterButton();
            ModifyError("Email must be valid!");
            if (Email) { ClearError(); }
        }

        private void textBox_ConfirmEmail_TextChanged(object sender, EventArgs e)
        {
            ActivateRegisterButton();
            ModifyError("Emails must be the same!");
            if (EmailConfirmation) { ClearError(); }
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {
            ActivateRegisterButton();
            ModifyError("Password must be 6 letters long!");
            if (Password) { ClearError(); }
        }

        private void textBox_ConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            ActivateRegisterButton();
            ModifyError("Passwords must be the same!");
            if (PasswordConfirmation) { ClearError(); }
        }
    }
}







//bool email => ValidEmail(textBox_Email.Text);
/*bool ValidEmail(string email)
        {
            bool check1 = false, check2 = false;
            foreach (char c in email)
            {
                if (c == '@')
                {
                    check1 = true;
                }
                if (c == '.')
                {
                    check2 = true;
                }

                if(check1 && check2)
                {
                    return true;
                }
            }
            return false;
        } */
