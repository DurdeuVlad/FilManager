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
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        public string email;

        private void button_SendEmail_Click(object sender, EventArgs e)
        {
            if (textBox_YourMessage.Text.Length >= 10)
            {
                SendEmail("durdeuvladioan@gmail.com");
            }
            else
            {
                label_Feedback.Text = "Email could not be sent.";
            }
        }

        private void SendEmail(string supportEmail)
        {
            long a = RandomDataGenerator.NumberGenerator(1, 9999);
            button_SendEmail.Enabled = false;
            label_Feedback.Text = "Email successfully sent!";
            // confirmation email
            /*EmailManager.sendEmail(email, "Ticket #" 
                + a +" sent",
                "Ticket #" + a + " was sent to our support team.\n" 
                + "Your message:\n\""+ textBox_YourMessage.Text+"\""+
                "\n " +
                "\n " +
                "We wish you all the best,\nFilManager Team");
            // send email to support
            EmailManager.sendEmail(supportEmail, "Ticket #"
                + a + " has been received",
                "Ticket #" + a + " was sent to our support team by " + email
                + "\nMessage:\n\"" + textBox_YourMessage.Text + "\"" + 
                "\n " +
                "Please respond as soon as possible" +
                "\n " +
                "\n " +
                "We wish you all the best,\nFilManager Team");
            */
        }
    }
}
