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
    public partial class AccountCreation : Form
    {
        connection_class con = new connection_class();
        public AccountCreation()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userLoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserLogin login = new UserLogin();
            this.Hide();
            login.Show();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            var newUser = new Users();

            newUser.Name = nameBox.Text;
            string name = newUser.Name;

            newUser.Username = usernameBox.Text;
            string user = newUser.Username;

            newUser.Password = passwordBox.Text;
            string pass = newUser.Password;

            newUser.Email = emailBox.Text;
            string email = newUser.Email;

            newUser.Role = roleBox.Text;
            string role = newUser.Role;

            if (name == "")
            {
                MessageBox.Show("You must enter a name.");
            }
            else if (user == "")
            {
                MessageBox.Show("You must enter a username.");
            }
            else if (pass == "")
            {
                MessageBox.Show("You must enter a password.");
            }
            else if (role == "")
            {
                MessageBox.Show("You must pick a role.");
            }
            else if (email == "")
            {
                MessageBox.Show("You must enter an email.");
            }
            else
            {
                string query = "SELECT * FROM users where username= @username";
                MySqlCommand com = new MySqlCommand(query, con.connectdb);
                com.Parameters.AddWithValue("@username", user);
                DataSet ds = new DataSet();
                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                adapter.Fill(ds);

                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("Username already exists. Please try again.");
                    usernameBox.Clear();
                } else
                {
                    CreateUser(name, user, pass, role, email);
                    ClearTextBoxes();
                    MessageBox.Show("Account created!");


                }
            }
            con.connectdb.Close();
        }
        public int CreateUser (string name, string user, string pass, string role, string email)
        {
            con.connectdb.Open();
            string query = "INSERT INTO tickets.users(name, username, password, role, email) VALUES (@name,@username,@password,@role,@email)";
            MySqlCommand com = new MySqlCommand(query, con.connectdb);
            com.Parameters.AddWithValue("@name", name);
            com.Parameters.AddWithValue("@username", user);
            com.Parameters.AddWithValue("@password", pass);
            com.Parameters.AddWithValue("@role", role);
            com.Parameters.AddWithValue("@email", email);

            return com.ExecuteNonQuery();
        } 
        public void ClearTextBoxes()
        {
            nameBox.Clear();
            usernameBox.Clear();
            passwordBox.Clear();
            emailBox.Clear();
        }
    }
}