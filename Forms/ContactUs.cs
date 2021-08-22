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
        public string CurrentUser { get; set; }
        public ContactUs()
        {
            InitializeComponent();
        }

        private void mailButton_Click(object sender, EventArgs e)
        {
            try
            {

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                if (subjectBox.Text == "" || messageBox.Text == "")
                {
                    MessageBox.Show("Please fill in the subject box and the message box.");
                }else
                {
                    mail.From = new MailAddress("thetickettrackingemail@gmail.com");
                    mail.To.Add("thetickettrackingemail@gmail.com");
                    mail.Subject = subjectBox.Text;
                    mail.Body = "From: " + CurrentUser + "\n" + messageBox.Text;

                    SmtpServer.Port = 587;
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
