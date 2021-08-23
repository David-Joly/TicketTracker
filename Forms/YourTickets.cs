using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TicketTracker.DatabaseHelper;

namespace TicketTracker.Forms
{
    public partial class YourTickets : Form
    {
        public string CurrentUser { get; set; } // Retrieves current user
        connection_class con = new connection_class();

        public YourTickets()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e) // Marks ticket as closed and refreshes the datagridview
        {
            UpdateStatus();
            Refreshing();

        }
        public void GetYourTickets()
        {
            string user = CurrentUser;
            userTicketView.DataSource = null;
            
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string query = "SELECT TicketID, Issue, Priority, Status, Creator FROM ticks WHERE Creator='" + user + "'AND Status= 'Open';"; // Retrieving all tickets marked "Open" that correlate with logged in user
            adapter.SelectCommand = new MySqlCommand(query, con.connectdb);

            DataTable table = new DataTable();
            adapter.Fill(table);

            BindingSource source = new BindingSource();
            source.DataSource = table;
            userTicketView.DataSource = source;
            this.userTicketView.AutoGenerateColumns = false; 

            DataGridViewLinkColumn createComment = new DataGridViewLinkColumn(); // Adding comments column with a clickable link that will allow users to post comments on each ticket
            userTicketView.Columns.Add(createComment);
            createComment.HeaderText = "Comments";
            createComment.Name = "View";
            createComment.Text = "View";
            createComment.UseColumnTextForLinkValue = true;

        }
        public void UpdateStatus()
        {
            con.connectdb.Open();
            string ticketID = closeBox.Text;
            string query = "UPDATE ticks SET Status= 'Closed' WHERE TicketID= @ticketID"; // Marks ticket that user has entered as "Closed"
            MySqlCommand com = new MySqlCommand(query, con.connectdb);
            com.Parameters.AddWithValue("@ticketID", ticketID);
            com.ExecuteNonQuery();
            con.connectdb.Close();
        }
        // Refreshes the userTicketView datagridview without adding additional "Comments" columns
        public void Refreshing()
        {
            con.connectdb.Open();
            string user = CurrentUser;
            userTicketView.DataSource = null;


            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string selectTickets = "SELECT TicketID, Issue, Priority, Status, Creator FROM ticks WHERE Creator='" + user + "'AND Status= 'Open';";
            adapter.SelectCommand = new MySqlCommand(selectTickets, con.connectdb);

            DataTable table = new DataTable();
            adapter.Fill(table);

            BindingSource source = new BindingSource();
            source.DataSource = table;

            userTicketView.DataSource = source;
            this.userTicketView.AutoGenerateColumns = false;
            con.connectdb.Close();
        }

        private void YourTickets_Load(object sender, EventArgs e)
        {
            userTicketView.RowHeadersVisible = false;
            GetYourTickets();
        }
        // When Comments column rows are clicked, user will be taken to a comments page that allows comments to be posted, which will correspond with tickets in said row
        private void userTicketView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ticketID = Convert.ToInt32(userTicketView.CurrentRow.Cells[0].Value);
            TicketComments comments = new TicketComments();
            comments.CurrentUser = CurrentUser;
            comments.TicketIdentification = ticketID;
            comments.Show();
        }
    }

}
