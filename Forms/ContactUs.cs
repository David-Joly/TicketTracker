using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail; 

namespace TicketTracker.Forms
{
    public partial class ContactUs : Form
    {
        public string CurrentUser { get; set; } // Retrieves the current users name
        public ContactUs()
        {
            InitializeComponent();
        }

        private void mailButton_Click(object sender, EventArgs e)
        {
            try
            {

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com"); // Setting smpt to google

                if (subjectBox.Text == "" || messageBox.Text == "") // Prevents users from sending without entering both a subject and a message
                {
                    MessageBox.Show("Please fill in the subject box and the message box.");
                }else
                {
                    mail.From = new MailAddress("thetickettrackingemail@gmail.com"); // Email that will both send and receive all messages
                    mail.To.Add("thetickettrackingemail@gmail.com");
                    mail.Subject = subjectBox.Text;
                    mail.Body = "From: " + CurrentUser + "\n" + messageBox.Text; // Attaches sending users name to the message

                    SmtpServer.Port = 587; // Google port
                    SmtpServer.UseDefaultCredentials = false;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("thetickettrackingemail@gmail.com", "mA2tfnCe2SpWZ6X");
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);

                    MessageBox.Show("Thank you for contacting us. We will review your message shortly.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
