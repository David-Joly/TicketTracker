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
    public partial class People : Form
    {
        connection_class con = new connection_class();
        public People()
        {
            InitializeComponent();
            DisplayUsers();
        }
        public void DisplayUsers()
        {
            string query = "SELECT name, role, email FROM users";

            MySqlCommand com = new MySqlCommand(query, con.connectdb);
            MySqlDataAdapter adapter = new MySqlDataAdapter(com);
            DataTable table = new DataTable();
            adapter.Fill(table);

            foreach(DataRow row in table.Rows) // Traverses through the users table and adds name, email, and role rows to the PeopleView listview
            {
                ListViewItem item = new ListViewItem(row["name"].ToString());
                item.SubItems.Add(row["role"].ToString());
                item.SubItems.Add(row["email"].ToString());

                peopleView.Items.Add(item);
            }
        }
    }
}
