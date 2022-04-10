using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;

namespace FilManager
{
    public partial class Recovery : Form
    {
        SqlConnection connection = new SqlConnection(DatabaseCommands.sqlConnection);

        public Recovery()
        {
            InitializeComponent();
            connection.Open();
        }
                   
        bool Email => textBox_Email.Text.Contains("@") 
            && textBox_Email.Text.Contains(".") && textBox_Email.Text.Length > 5;

        private void button_SendEmail_Click(object sender, EventArgs e)
        {
            if (Email)
            {
                label_Feedback.Text = "Email sent! Open your email\n" +
                    "for further instructions.";
                // CHECK IF EMAIL EXISTS
                bool EmailExists = false;
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM dbo.[Table]", connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = sqlCommand;
                DataTable data = new DataTable();
                sqlDataAdapter.Fill(data);

                string newPassword = RandomDataGenerator.AutoPasswordGenerator();

                for (int i = 0; i < data.Rows.Count; i++)
                {
                    string email = data.Rows[i][1].ToString();
                    if (email.Contains(textBox_Email.Text))

                    {
                        EmailExists = true;
                        //update temp password
                        SqlCommand command = new SqlCommand(
                            "UPDATE dbo.[Table] " +
                            "SET PASSWORD_RECOVERY=@PASSWORD_RECOVERY " +
                            "WHERE Id=@Id",
                            connection);
                        sqlDataAdapter.UpdateCommand = command;
                        command.Parameters.Add("@PASSWORD_RECOVERY", SqlDbType.VarChar, 50, "PASSWORD_RECOVERY");
                        command.Parameters.Add("@Id", SqlDbType.Int, 50, "Id");
                        
                        command.Parameters["@PASSWORD_RECOVERY"].Value = newPassword;
                        command.Parameters["@Id"].Value = i;
                        command.ExecuteNonQuery();
                        break;
                    }
                }

                
                if (EmailExists)
                {
                    // SEND EMAIL
                    if(EmailManager.sendEmail(textBox_Email.Text,
                        "FilManager - Account Recovery - Further Intructions",
                        "Hello! We have received recovery request for your account. \n" +
                        "IMPORTANT: If you didn't request an account recovery we strongly " +
                        "recommend changing the password right away.\n" +
                        "\n" +
                        "You have been provided with a temporary password. " +
                        "This password will last until the next successful login." +
                        "\nTEMPORARY PASSWORD: " + newPassword +
                        "\nYou may procced to log in your account with this password and your email." +
                        "\n" +
                        "\n" +
                        "We wish you all the best,\nFilManager Team")) 
                    { }
                    else
                    {
                        label_Feedback.Text = "An internal error has occurred. Please try again later."; 
                    }
                }
            }
            else
            {
                label_Feedback.Text = "Invalid email. Please try again.";
                // DON'T
            }
        }


        private void Recovery_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }


    }
}
