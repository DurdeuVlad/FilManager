using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FilManager
{
    public partial class Register : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="
+ Directory.GetCurrentDirectory() + "\\userList.mdf;Integrated Security=True;Connect Timeout=30");

        public Register()
        {
            InitializeComponent();
            connection.Open();
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            // verify entry
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM dbo.[Table]", connection);
            
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            bool Check = true;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                string email = data.Rows[i][1].ToString();
                if (email.Contains(textBox_Email.Text))

                {
                    ModifyError("That email already exists!");
                    Check = false;
                    break;
                }
            }
            if (Check)
            {
                ClearError();
                // add entry
                string newPassword = RandomDataGenerator.AutoPasswordGenerator();
                SqlCommand command = new SqlCommand(
                     "INSERT INTO dbo.[Table](Id, EMAIL, PASSWORD, DATE_REGISTER, PASSWORD_RECOVERY)" +
                     "VALUES (@Id, @EMAIL, @PASSWORD, @DATE_REGISTER, @PASSWORD_RECOVERY)",
                     connection);
                sqlDataAdapter.InsertCommand = command;

                command.Parameters.Add("@Id", SqlDbType.Int, 50, "Id");
                command.Parameters.Add("@EMAIL", SqlDbType.VarChar, 50, "EMAIL");
                command.Parameters.Add("@PASSWORD", SqlDbType.VarChar, 50, "PASSWORD");
                command.Parameters.Add("@DATE_REGISTER", SqlDbType.DateTime, 50, "DATE_REGISTER");
                command.Parameters.Add("PASSWORD_RECOVERY", SqlDbType.VarChar, 50, "PASSWORD_RECOVERY");

                command.Parameters["@Id"].Value = data.Rows.Count;
                command.Parameters["@EMAIL"].Value = textBox_Email.Text; //EMAIL;
                command.Parameters["@PASSWORD"].Value = textBox_Password.Text; //PASSWORD;
                command.Parameters["@DATE_REGISTER"].Value = DateTime.Now; //DATE_REGISTER;
                command.Parameters["PASSWORD_RECOVERY"].Value = newPassword; //DATE_REGISTER;

                command.ExecuteNonQuery();
                connection.Close();
                ModifyError("Account created successfully. \nYou may login.");
                
                /*EmailManager.sendEmail(textBox_Email.Text,
                        "FilManager - Account Verification",
                        "Hello! Thank you for creating a new account! " +
                        "\nPlease follow the instructions bellow to activate your account \n" +
                        "\n" +
                        "IMPORTANT: You have been provided with a temporary password. " +
                        "This password will last until the next successful login." +
                        "\nTEMPORARY PASSWORD: " + newPassword +
                        "\nYou may procced to log in your account with this password and your email." +
                        "\nPlease use this password to log in for the first time." +
                        "\n" +
                        "If you didn't request a account creation you can safely " +
                        "ignore this email.\n" +
                        "We wish you all the best,\nFilManager Team");*/
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userListDataSet.SELECT_USER' table. You can move, or remove it, as needed.
            ActivateRegisterButton();
        }

        bool EmailConfirmation => textBox_Email.Text == textBox_ConfirmEmail.Text;
        bool Email => textBox_Email.Text.Contains("@") && textBox_Email.Text.Contains(".") && textBox_Email.Text.Length>5;
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

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void checkBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPassword.Checked)
            {
                textBox_Password.PasswordChar = (char)0;
                textBox_ConfirmPassword.PasswordChar = (char)0;
            }
            else
            {
                textBox_Password.PasswordChar = '*';
                textBox_ConfirmPassword.PasswordChar = '*';
            }
        }
    }
}







