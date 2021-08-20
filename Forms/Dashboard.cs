using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using TicketTracker.Forms;

namespace TicketTracker
{
    public partial class Dashboard : Form
    {
        private Form currentChildForm;
        public Dashboard()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            desktopPanel.Controls.Add(childForm);
            desktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();



        }

        private void ContactUs_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ContactUs());
        }
    }
}
