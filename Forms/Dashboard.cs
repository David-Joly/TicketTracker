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
        private Button currentButton;
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
            SelectedButton(sender, Colours.clickedColour);
            OpenChildForm(new ContactUs());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createTicketButton_Click(object sender, EventArgs e)
        {
            SelectedButton(sender, Colours.clickedColour);
            OpenChildForm(new TicketCreation());
        }

        private void closedTickButton_Click(object sender, EventArgs e)
        {
            SelectedButton(sender, Colours.clickedColour);
            OpenChildForm(new ClosedTickets());
        }

        private void yourTicketsButton_Click(object sender, EventArgs e)
        {
            SelectedButton(sender, Colours.clickedColour);
            OpenChildForm(new YourTickets());
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            SelectedButton(sender, Colours.clickedColour);
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            else
            {
                this.Refresh();
            }
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            SelectedButton(sender, Colours.clickedColour);
            OpenChildForm(new People());
        }

        private void ResetButton()
        {
            if (currentButton != null)
            {
                currentButton.ForeColor = Colours.defaultColour;
            }

        }
        private void SelectedButton(object senderBtn, Color colour)
        {
            if (senderBtn != null)
            {
                ResetButton();
                currentButton = (Button)senderBtn;
                currentButton.ForeColor = colour;
            }
        }
        private struct Colours
        {
            public static Color defaultColour = Color.FromArgb(47, 72, 88);
            public static Color clickedColour = Color.FromArgb(53, 208, 186);
        }
    }
}
       
  



