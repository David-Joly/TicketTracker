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
using TicketTracker.Classes;
using TicketTracker.DatabaseHelper;

namespace TicketTracker.Forms
{
    public partial class TicketCreation : Form
    {
        public string CurrentUser { get; set; } // Retrieves current users name
        connection_class con = new connection_class();
        public TicketCreation()
        {
            InitializeComponent();
        }

        private void createTicketButton_Click(object sender, EventArgs e)
        {
            var newTicket = new Tickets();

            newTicket.Issue = issueBox.Text;
            string issue = newTicket.Issue;

            newTicket.Priority = priorityBox.Text;
            string priority = newTicket.Priority;

            newTicket.Status = "Open";
            string status = newTicket.Status;

            newTicket.Creator = CurrentUser;
            string creator = newTicket.Creator;

            if (issue == "") // Ensures user is filling all input methods and cannot leave them blank
            {
                MessageBox.Show("You must enter an issue.");
            }
            else if (priority == "")
            {
                MessageBox.Show("You must enter a priority.");

            }
            else
            {
                CreateTicket(issue, priority, status, creator);
                con.connectdb.Close();
                issueBox.Clear();
                MessageBox.Show("Ticket created!");

            }
        }
        public int CreateTicket (string issue, string priority, string status, string creator)
        {
            con.connectdb.Open();
            string query = "INSERT into tickets.ticks (Issue, Priority, Status, Creator) VALUES (@issue,@priority,@status,@creator)"; // Insert query to save the ticket to database
            MySqlCommand com = new MySqlCommand(query, con.connectdb);
            com.Parameters.AddWithValue("@issue", issue);
            com.Parameters.AddWithValue("@priority", priority);
            com.Parameters.AddWithValue("@status", status);
            com.Parameters.AddWithValue("@creator", creator);
            return com.ExecuteNonQuery();
        }
    }
}
