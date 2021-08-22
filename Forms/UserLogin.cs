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
    public partial class UserLogin : Form
    {
        connection_class con = new connection_class();
        
        public UserLogin()
        {
            this.Icon = Properties.Resources.ticket_4271;
            InitializeComponent();
        }
        
        private void backButton_Click(object sender, EventArgs e) // Will bring user back to account creation page if back button is clicked
        {
            AccountCreation createAccount = new AccountCreation();
            this.Hide();
            createAccount.Show();

        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            var currentUser = new Users();

            currentUser.Username = usernameBox.Text;
            string username = currentUser.Username;

            currentUser.Password = passwordBox.Text;
            string password = currentUser.Password;
            UserVerification(username, password);

        }
        public void UserVerification(string username, string password)
        {
            con.connectdb.Open();
            int i = 0;
            string query = "SELECT * FROM users WHERE username= @username AND password= @password";
            MySqlCommand com = new MySqlCommand(query, con.connectdb);
            com.Parameters.AddWithValue("@username", username);
            com.Parameters.AddWithValue("@password", password);

            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(com);
            adapter.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0) // If either username or password are not present in users table the user will receive a message and they will not be logged in
            {
                MessageBox.Show("You have entered an invalid username or password, please try again.");
            }
            else // If login is successful the user will continue to the dashboard form
            {
                this.Hide();
                Dashboard dashboard = new Dashboard(usernameBox.Text); // Passing current username to the dashboard form
                dashboard.Show();
            }
            con.connectdb.Close();
       
        }

    }
}
