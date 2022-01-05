using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace FilManager
{
    class EmailManager
    {
        /// <summary>
        /// Send an email to an email adress.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        public static bool sendEmail(string email, string subject, string body)
        {
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
            {
                UseDefaultCredentials = false,
                Port = 587,
                Credentials = new NetworkCredential("fil.manager.app@gmail.com",       "thebestapp!"),
                EnableSsl = true,
            };
            try
            {
                smtpClient.Send("fil.manager.app@gmail.com", email, subject, body);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
