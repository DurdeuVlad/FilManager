using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilManager
{
    public partial class Account : Form
    {
        public string currentEmail;
        public string currentPassword;
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GitHub Project\FilManager\FilManager\userList.mdf;Integrated Security=True;Connect Timeout=30");
        DataTable data = new DataTable();
        public Account()
        {
            InitializeComponent();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            //SqlCommand sqlCommand = new SqlCommand("SELECT * FROM dbo.[Table]", connection);
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            //
            //sqlDataAdapter.SelectCommand = sqlCommand; 
            //sqlDataAdapter.Fill(data);
            int userid = -1;

            DatabaseCommands.ExistsEmail(currentEmail, out userid);
            int i = 0;
            if (DatabaseCommands.ExistsEmail(currentEmail, out data, out i))
            {
                label_JoinDate.Text = data.Rows[i][3].ToString();
                label_LastLogin.Text = data.Rows[i][4].ToString();
                label_Name.Text = data.Rows[i][1].ToString().Substring(0, data.Rows[i][1].ToString().IndexOf('@'));
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        bool Password => textBox_ChangePassword_Password.Text.Length >= 6;
        bool PasswordConfirmation => textBox_ChangePassword_ConfirmPassword.Text 
            == textBox_ChangePassword_Password.Text;
        bool Email => textBox_ChangePassword_ConfirmEmail.Text.Contains("@") 
            && textBox_ChangePassword_ConfirmEmail.Text.Contains(".") 
            && textBox_ChangePassword_ConfirmEmail.Text.Length > 5;

        private void checkBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ChangePassword_ShowPassword.Checked)
            {
                textBox_ChangePassword_Password.PasswordChar = (char)0;
                textBox_ChangePassword_ConfirmPassword.PasswordChar = (char)0;
            }
            else
            {
                textBox_ChangePassword_Password.PasswordChar = '*';
                textBox_ChangePassword_ConfirmPassword.PasswordChar = '*';
            }
        }

        private void button_ChangePassword_Confirm_Click(object sender, EventArgs e)
        {
            if (!Email)
            {
                label_ChangePassword_Error.Text = "Invalid email!";
            }
            else if (!Password)
            {
                label_ChangePassword_Error.Text = "Invalid password!";
            }
            else if (!PasswordConfirmation)
            {
                label_ChangePassword_Error.Text = "The passwords do not match!";
            }
            if (Email && PasswordConfirmation && Password)
            {
                connection.Open();
                // CHECK IF EMAIL EXISTS
                bool EmailExists = false;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                string newPassword = RandomDataGenerator.AutoPasswordGenerator();

                for (int i = 0; i < data.Rows.Count; i++)
                {
                    string email = data.Rows[i][1].ToString();
                    if (email.Contains(textBox_ChangePassword_ConfirmEmail.Text))

                    {
                        EmailExists = true;
                        //update password
                        SqlCommand command = new SqlCommand(
                            "UPDATE dbo.[Table] " +
                            "SET PASSWORD_RECOVERY=@PASSWORD_RECOVERY,PASSWORD=@PASSWORD " +
                            "WHERE Id=@Id",
                            connection);
                        sqlDataAdapter.UpdateCommand = command;
                        command.Parameters.Add("@PASSWORD_RECOVERY", SqlDbType.VarChar, 50, "PASSWORD_RECOVERY");
                        command.Parameters.Add("@PASSWORD", SqlDbType.VarChar, 50, "PASSWORD");     
                        command.Parameters.Add("@Id", SqlDbType.Int, 50, "Id");

                        command.Parameters["@PASSWORD_RECOVERY"].Value = newPassword;
                        command.Parameters["@PASSWORD"].Value = textBox_ChangePassword_Password.Text;
                        command.Parameters["@Id"].Value = i;
                        command.ExecuteNonQuery();
                        break;
                    }

                }
                connection.Close();


                if (EmailExists)
                {
                    // SEND EMAIL
                    EmailManager.sendEmail(currentEmail,
                        "FilManager - Account Recovery - Password changed",
                        "Hello! Your password has been changed for your account. \n" +
                        "IMPORTANT: If you didn't change the password we strongly " +
                        "recommend changing the password right away.\n" +
                        "\n" +
                        "You have been provided with a temporary password.\n" +
                        "in case you did not change the password.\n" +
                        "This password will last until the next successful login." +
                        "\nTEMPORARY PASSWORD: " + newPassword +
                        "\nYou may procced to log in your account with this password and your email." +
                        "\n" +
                        "\n" +
                        "We wish you all the best,\nFilManager Team");
                }
                label_ChangePassword_Error.Text = "Password changed!";
            }
            else
            {
                label_ChangePassword_Error.Text = "Invalid email. Please try again.";
                // DON'T
            }
        }

        private void Account_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
