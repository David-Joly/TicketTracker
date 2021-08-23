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
using TicketTracker.Classes;

namespace TicketTracker.Forms
{
    public partial class TicketComments : Form
    {
        public string CurrentUser { get; set; } // Retrieving current users name
        public int TicketIdentification { get; set; } // Retrieving ticketID that corresponds with row
        connection_class con = new connection_class();
        public TicketComments()
        {
            this.Icon = Properties.Resources.ticket_4271; // Program icon
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Comments userComment = new Comments();
            
            DateTime date = DateTime.Now; // Creating comment date

            userComment.Comment = commentBox.Text;
            string comments = userComment.Comment;

            userComment.TicketID = TicketIdentification;
            int ticketID = userComment.TicketID;

            userComment.Creator = CurrentUser;
            string submitter = userComment.Creator;

            CreateComment(comments, submitter, date.ToString("yyyy-MM-dd H:mm:ss"), ticketID);
            MessageBox.Show("Comment added!");
            commentBox.Clear();
            GetComments();
            con.connectdb.Close();

        }
        public int CreateComment (string comments, string submitter, string date, int ticketID)
        {
            con.connectdb.Open();
            string query = "INSERT INTO tickets.comments(Comments, Submitted, Date, TicketID) VALUES (@comments,@submitter,@date,@ticketID)"; // Insert query that will save the comment to database
            MySqlCommand com = new MySqlCommand(query, con.connectdb);
            com.Parameters.AddWithValue("@comments", comments);
            com.Parameters.AddWithValue("@submitter", submitter);
            com.Parameters.AddWithValue("@date", date);
            com.Parameters.AddWithValue("@ticketID", ticketID);

            return com.ExecuteNonQuery();
        }
        public void GetComments()
        {
            int ticketID = TicketIdentification;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string selectComments = "SELECT Comments, Submitted, Date FROM comments WHERE TicketID='" + ticketID + "';"; // Select query that will retrieve comments from database and fill commentGridView datagridview
            adapter.SelectCommand = new MySqlCommand(selectComments, con.connectdb);

            DataTable table = new DataTable();
            adapter.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            commentGridView.DataSource = bSource;

        }

        private void TicketComments_Load(object sender, EventArgs e)
        {
            commentGridView.RowHeadersVisible = false;
            GetComments();
        }
    }
}
