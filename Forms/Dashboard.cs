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
using MySql.Data.MySqlClient;
using TicketTracker.Classes;
using TicketTracker.DatabaseHelper;

namespace TicketTracker
{
    public partial class Dashboard : Form
    {
        connection_class con = new connection_class();
        private Form currentChildForm;
        private Button currentButton;
        public Dashboard(string user)
        {
            InitializeComponent();
            string name;
            string username = user;

            string query = "SELECT name from users WHERE username= @username";
            MySqlCommand com = new MySqlCommand(query, con.connectdb);
            com.Parameters.AddWithValue("@username", username);
            con.connectdb.Open();

            var reader = com.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                name = reader.GetString(0);
                userLabel.Text = name;
            }
            con.connectdb.Close();

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
            ContactUs contactUs = new ContactUs();
            contactUs.CurrentUser = userLabel.Text;
            OpenChildForm(contactUs);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createTicketButton_Click(object sender, EventArgs e)
        {
            SelectedButton(sender, Colours.clickedColour);
            TicketCreation ticketCreation = new TicketCreation();
            ticketCreation.CurrentUser = userLabel.Text;
            OpenChildForm(ticketCreation);
        }

        private void closedTickButton_Click(object sender, EventArgs e)
        {
            SelectedButton(sender, Colours.clickedColour);
            OpenChildForm(new ClosedTickets());
        }

        private void yourTicketsButton_Click(object sender, EventArgs e)
        {
            SelectedButton(sender, Colours.clickedColour);
            YourTickets yourTickets = new YourTickets();
            yourTickets.CurrentUser = userLabel.Text;
            OpenChildForm(yourTickets);
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            SelectedButton(sender, Colours.clickedColour);
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                Refreshing();
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

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ticketGridView.RowHeadersVisible = false;
            GetTickets();

        }
        public void GetTickets()
        {
            ticketGridView.DataSource = null;
            ticketGridView.Rows.Clear();
            ticketGridView.Update();
            ticketGridView.Refresh();
            string status = "Open";


            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string selectTickets = "SELECT TicketID, Issue, Priority, Status, Creator FROM ticks WHERE Status='" + status + "';";
            adapter.SelectCommand = new MySqlCommand(selectTickets, con.connectdb);

            DataTable table = new DataTable();
            adapter.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            ticketGridView.DataSource = bSource;
            this.ticketGridView.AutoGenerateColumns = false;


            DataGridViewLinkColumn createComment = new DataGridViewLinkColumn();
            ticketGridView.Columns.Add(createComment);
            createComment.HeaderText = "Comments";
            createComment.Name = "View";
            createComment.Text = "View";
            createComment.UseColumnTextForLinkValue = true;

        }
        public void Refreshing()
        {
            ticketGridView.DataSource = null;
            ticketGridView.Rows.Clear();
            ticketGridView.Update();
            ticketGridView.Refresh();
            string status = "Open";


            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string query = "SELECT TicketID, Issue, Priority, Status, Creator FROM ticks WHERE Status='" + status + "';";
            adapter.SelectCommand = new MySqlCommand(query, con.connectdb);

            DataTable table = new DataTable();
            adapter.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            ticketGridView.DataSource = bSource;
            this.ticketGridView.AutoGenerateColumns = false;
        }
    }
}

       
  



