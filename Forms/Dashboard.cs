using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketTracker.Forms;
using MySql.Data.MySqlClient;
using TicketTracker.Classes;
using TicketTracker.DatabaseHelper;


namespace TicketTracker
{
    public partial class Dashboard : Form
    {
        // Connection class 
        connection_class con = new connection_class();
        private Form currentChildForm;
        private Button currentButton;

        private Point mouseLock;


        public Dashboard(string user)
        {
            this.Icon = Properties.Resources.ticket_4271; // Adding icon to application
            InitializeComponent();
            string name;
            string username = user;

            string query = "SELECT name from users WHERE username= @username";
            MySqlCommand com = new MySqlCommand(query, con.connectdb);
            com.Parameters.AddWithValue("@username", username);
            con.connectdb.Open();

            var reader = com.ExecuteReader();

            if (reader.HasRows) // Retrieves current users name by pulling the value that corresponds with the searched username in MySQL
            {
                reader.Read();
                name = reader.GetString(0);
                userLabel.Text = name;
            }
            con.connectdb.Close();

        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null) // If a new child form is opened, the previous will close
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            desktopPanel.Controls.Add(childForm);
            desktopPanel.Tag = childForm;
            childForm.BringToFront(); // Ensures that child form is docked within the Dashboard.cs parent form 
            childForm.Show();



        }
        // Opens ContactUs.cs child form
        private void ContactUs_Click(object sender, EventArgs e)
        {
            SelectedButton(sender, Colours.clickedColour);
            ContactUs contactUs = new ContactUs();
            contactUs.CurrentUser = userLabel.Text;
            OpenChildForm(contactUs);
        }
        // Exits application when clicked
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Opens TicketCreation.cs child form
        private void createTicketButton_Click(object sender, EventArgs e)
        {
            SelectedButton(sender, Colours.clickedColour);
            TicketCreation ticketCreation = new TicketCreation();
            ticketCreation.CurrentUser = userLabel.Text;
            OpenChildForm(ticketCreation);
        }
        // Opens ClosedTickets.cs child form
        private void closedTickButton_Click(object sender, EventArgs e)
        {
            SelectedButton(sender, Colours.clickedColour);
            OpenChildForm(new ClosedTickets());
        }
        // Opens YourTickets.cs child form 
        private void yourTicketsButton_Click(object sender, EventArgs e)
        {
            SelectedButton(sender, Colours.clickedColour);
            YourTickets yourTickets = new YourTickets();
            yourTickets.CurrentUser = userLabel.Text;
            OpenChildForm(yourTickets);
        }

        //Refreshes the dashboard if dashboard button is clicked
        private void dashboardButton_Click(object sender, EventArgs e)
        {
            SelectedButton(sender, Colours.clickedColour);
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                Refreshing();
                UserStats();
            }
            else
            {
                this.Refresh();
            }
        }
        // Opens People.cs child form
        private void usersButton_Click(object sender, EventArgs e)
        {
            SelectedButton(sender, Colours.clickedColour);
            OpenChildForm(new People());
        }

        private void ResetButton()
        {
            if (currentButton != null) // Resets the button to default colour when another button is clicked
            {
                currentButton.ForeColor = Colours.defaultColour;
            }

        }
        private void SelectedButton(object senderBtn, Color colour)
        {
            if (senderBtn != null)  // Sets selected button to a new colour when clicked
            {
                ResetButton();
                currentButton = (Button)senderBtn;
                currentButton.ForeColor = colour;
            }
        }
        // Colours for dashboard buttons. Used to change button colours depending on whether they are clicked
        private struct Colours
        {
            public static Color defaultColour = Color.FromArgb(47, 72, 88);
            public static Color clickedColour = Color.FromArgb(53, 208, 186);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ticketGridView.RowHeadersVisible = false;
            GetTickets();
            UserStats();

        }
        // Populates the dashboard datagridview and displays all open tickets to the user
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

            // Adds a comments column that contains a view link which can be opened to add comments to tickets
            DataGridViewLinkColumn createComment = new DataGridViewLinkColumn();
            ticketGridView.Columns.Add(createComment);
            createComment.HeaderText = "Comments";
            createComment.Name = "View";
            createComment.Text = "View";
            createComment.UseColumnTextForLinkValue = true;

        }
        // Refreshes the datagridview on the dashboard without adding a comments column
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
        // Opens each individual tickets comments section when the view link is clicked inside the datagridview
        private void ticketGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string user = userLabel.Text;
            int ticketID = Convert.ToInt32(ticketGridView.CurrentRow.Cells[0].Value);

            TicketComments commentPage = new TicketComments();
            commentPage.CurrentUser = user;
            commentPage.TicketIdentification = ticketID;
            commentPage.Show();

        }
        public void UserStats()
        {

            string openCount;
            string closedCount;
            string commentCount;

            con.connectdb.Open();
            string openedTickets = "SELECT COUNT(*) FROM ticks WHERE Creator= @user AND Status='Open'";
            MySqlCommand openCom = new MySqlCommand(openedTickets, con.connectdb);
            openCom.Parameters.AddWithValue("@user", userLabel.Text);

            var reader = openCom.ExecuteReader();

            if (reader.HasRows) // Counts the current users number of open tickets and returns the count
            {
                reader.Read();
                openCount = reader.GetString(0);
                openTicketLabel.Text = "Open tickets: " + openCount;
                con.connectdb.Close();
            }
            con.connectdb.Open();
            string closedTickets = "SELECT COUNT(*) FROM ticks WHERE Creator= @user AND Status= 'Closed'";
            MySqlCommand closedcom = new MySqlCommand(closedTickets, con.connectdb);
            closedcom.Parameters.AddWithValue("@user", userLabel.Text);

            var reader2 = closedcom.ExecuteReader();

            if (reader2.HasRows) // Counts the current users number of closed tickets and returns the count
            {
                reader2.Read();
                closedCount = reader2.GetString(0);
                completedTickLabel.Text = "Completed tickets: " + closedCount;
                con.connectdb.Close();
            }
            con.connectdb.Open();
            string totalComments = "SELECT COUNT(*) FROM comments WHERE Submitted= @user";
            MySqlCommand commentcom = new MySqlCommand(totalComments, con.connectdb);
            commentcom.Parameters.AddWithValue("@user", userLabel.Text);

            var reader3 = commentcom.ExecuteReader();

            if (reader3.HasRows) // Counts the current users comments made and returns the count
            {
                reader3.Read();
                commentCount = reader3.GetString(0);
                commentsMadeLabel.Text = "Comments made: " + commentCount;
                con.connectdb.Close();
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Minimizes the window on click
        }

        private void desktopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLock = e.Location;
        }

        private void desktopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // If left button is held user will be able to drag form around
            {
                int dx = e.Location.X - mouseLock.X;
                int dy = e.Location.Y - mouseLock.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }
    }
}




