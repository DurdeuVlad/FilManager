using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace FilManager
{
    public partial class Login : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GitHub Project\FilManager\FilManager\userList.mdf;Integrated Security=True;Connect Timeout=30");

        public MainPage _MainPage;

        public Login()
        {
            InitializeComponent();
            connection.Open();
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            Register _Register = new Register();
            _Register.ShowDialog();

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM dbo.[Table]", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);



            for (int i = 0; i < data.Rows.Count; i++) 
            {
                string email = data.Rows[i][1].ToString();
                if (email.Contains(textBox_Email.Text))

                {
                    if (data.Rows[i][2].ToString().Contains(textBox_Password.Text))
                    {
                        if (data.Rows[i][4] == DBNull.Value)
                        {
                            label_Error.Text = 
                                "Please use the password provided to\n" +
                                "you by email for your first login.";
                            break;
                        }
                        else
                        {
                            UpdateLoginData(sqlDataAdapter, i);
                            _MainPage.LoginEmail = textBox_Email.Text;
                            _MainPage.Password = textBox_Password.Text;
                            _MainPage.UserId = i;
                            this.Close();
                        }
                    }
                    else if (data.Rows[i][5]!=null && data.Rows[i][5].ToString().Contains(textBox_Password.Text))
                    {
                        UpdateLoginData(sqlDataAdapter, i);
                        // SEND EMAIL
                        EmailManager.sendEmail(textBox_Email.Text,
                            "FilManager - Account Recovery - Successful Login Detected",
                            "Hello! We have detected a successful login attempt on your account.\n" +
                            "IMPORTANT: If you didn't log in at this time we strongly " +
                            "recommend changing the password right away.\n" +
                            "\n" +
                            "Please read the information below and check if this was your login attempt:" +
                            "\n" +
                            "\nEMAIL: " + textBox_Email.Text +
                            "\nUSED THIS TEMPORARY PASSWORD TO LOG IN: " + textBox_Password.Text +
                            "\n" +
                            "\nLOCAL DATE: " + DateTime.Now +
                            "\nUTC DATE: " + DateTime.UtcNow +
                            "\n " +
                            "\n " +
                            "We wish you all the best,\nFilManager Team");
                    
                        _MainPage.LoginEmail = textBox_Email.Text;
                        _MainPage.Password = textBox_Password.Text;
                        this.Close();
                    }
                    else
                    {
                        label_Error.Text = "Invalid password";
                        break;
                    }
                }
                else if(!(i+1 < data.Rows.Count))
                {
                    label_Error.Text = "Invalid email";
                    break;
                }
            


            }
        }

        bool Email => textBox_Email.Text.Contains("@") 
            && textBox_Email.Text.Contains(".") && textBox_Email.Text.Length > 5;
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

        private void Login_Load(object sender, EventArgs e)
        {
            

        }

        private void Login_Enter(object sender, EventArgs e)
        {
            
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void linkLabel_Recovery_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Recovery recovery = new Recovery();
            recovery.ShowDialog();
        }

        private void UpdateLoginData(SqlDataAdapter sqlDataAdapter, int i)
        {
            //delete temp password update password
            SqlCommand command = new SqlCommand(
                "UPDATE dbo.[Table] " +
                "SET PASSWORD_RECOVERY=@PASSWORD_RECOVERY,DATE_LAST_LOGIN=@DATE_LAST_LOGIN " +
                "WHERE Id=@Id",
                connection);
            sqlDataAdapter.UpdateCommand = command;
            command.Parameters.Add("@PASSWORD_RECOVERY", SqlDbType.VarChar, 50, "PASSWORD_RECOVERY");
            command.Parameters.Add("@DATE_LAST_LOGIN", SqlDbType.DateTime, 50, "DATE_LAST_LOGIN");
            command.Parameters.Add("@Id", SqlDbType.Int, 50, "Id");

            command.Parameters["@PASSWORD_RECOVERY"].Value = DBNull.Value;
            command.Parameters["@DATE_LAST_LOGIN"].Value = DateTime.Now;
            command.Parameters["@Id"].Value = i;
            command.ExecuteNonQuery();
        }

        private void checkBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPassword.Checked)
            {
                textBox_Password.PasswordChar = (char)0;
            }
            else
            {
                textBox_Password.PasswordChar = '*';
            }
        }
    }
}
