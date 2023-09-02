using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using MimeKit;
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
        /// 
        public static bool sendEmail(string recipientEmail, string subject, string body)
        {
<<<<<<< HEAD
=======
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
            {
                UseDefaultCredentials = false,
                Port = 587,
                //Credentials = new NetworkCredential(""),
                EnableSsl = true,
            };
>>>>>>> NEWMAIN
            try
            {
                // Use your own OAuth 2.0 credentials JSON file
                string credentialsJsonFile = "client_secret.json";

                // Create OAuth 2.0 credential object
                GoogleCredential credential;
                using (var stream = new System.IO.FileStream(credentialsJsonFile, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                {
                    credential = GoogleCredential.FromStream(stream)
                        .CreateScoped(GmailService.Scope.MailGoogleCom);
                }

                // Create Gmail service using the OAuth 2.0 credential
                using (var service = new GmailService(new BaseClientService.Initializer
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Filmanager"
                }))
                {
                    // Create a new email message
                    var email = new MimeMessage();
                    email.From.Add(new MailboxAddress("Filmanager Team", "fil.manager.app@gmail.com"));
                    email.To.Add(new MailboxAddress("Filmanager User", recipientEmail));
                    email.Subject = subject;
                    email.Body = new TextPart("plain")
                    {
                        Text = body
                    };

                    // Send the email
                    SendEmail(service, "fil.manager.app@gmail.com", email);

                    return true; // Email sent successfully
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, e.g., log the error
                Console.WriteLine("Error sending email: " + ex.Message);
                return false; // Failed to send email
            }
        }

        private static void SendEmail(GmailService service, string userId, MimeMessage email)
        {
            var emailContent = email.ToString();
            var base64Email = Base64UrlEncode(emailContent);
            var message = new Message
            {
                Raw = base64Email
            };
            service.Users.Messages.Send(message, userId).Execute();
        }

        private static string Base64UrlEncode(string input)
        {
            var inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(inputBytes)
                .Replace('+', '-')
                .Replace('/', '_')
                .Replace("=", "");
        }
        /*
               public static bool sendEmail(string email, string subject, string body)
               {
                   SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                   {
                       UseDefaultCredentials = false,
                       Port = 587,
                       Credentials = new NetworkCredential(""),
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
               */

    }
    }
