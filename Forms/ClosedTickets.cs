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
using TicketTracker.Forms;

namespace TicketTracker.Forms
{
    public partial class ClosedTickets : Form
    {
        connection_class con = new connection_class();
        public ClosedTickets()
        {
            InitializeComponent();
        }

        private void ClosedTickets_Load(object sender, EventArgs e)
        {
            closedTicketView.RowHeadersVisible = false;
            GetClosedTickets();

        }
        public void GetClosedTickets()
        {
            string status = "Closed";
            closedTicketView.DataSource = null;
            closedTicketView.Rows.Clear(); // Resets the closed tickets datagridview
            closedTicketView.Update();
            closedTicketView.Refresh();


            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string selectTickets = "SELECT TicketID, Issue, Priority, Status, Creator FROM ticks WHERE Status='" + status + "';"; // Retrieving tickets marked "Closed" from MySQL 
            adapter.SelectCommand = new MySqlCommand(selectTickets, con.connectdb);

            DataTable table = new DataTable();
            adapter.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            closedTicketView.DataSource = bSource;
            this.closedTicketView.AutoGenerateColumns = false;

        }
    }
}
