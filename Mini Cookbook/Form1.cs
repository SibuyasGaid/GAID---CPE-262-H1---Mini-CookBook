using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mini_Cookbook
{
    public partial class Form1 : Form
    {
        // string connectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";

        OleDbConnection myConn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        int indexRow;

        string CookbookAccess = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source= C:\\Users\\Owner\\Desktop\\Mini Cookbook.accdb";
        string UserAccesss = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source= C:\\Users\\Owner\\Desktop\\Cookbook Users.accdb";
        public string MostRecentUsername { get; set; }

        

        public Form1()
        {
            InitializeComponent();
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source= C:\\Users\\Owner\\Desktop\\Mini Cookbook.accdb");

            da = new OleDbDataAdapter("SELECT * FROM SignUp", myConn);

            ds = new DataSet();
            myConn.Open();
        }

        private void txbSignName_MouseClick(object sender, MouseEventArgs e)
        {
            txbSignName.Text = "";
        }
        private void txbSignPass_MouseClick(object sender, MouseEventArgs e)
        {
            txbSignPass.Text = "";
        }

        private void txbLoginName_MouseClick(object sender, MouseEventArgs e)
        {
            txbLoginName.Text = "";
        }

        private void txbLoginPass_MouseClick(object sender, MouseEventArgs e)
        {
            txbLoginPass.Text = "";
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string tableName = txbSignName.Text;
            string password = txbSignPass.Text;

            try
            {
                using (OleDbConnection connection = new OleDbConnection(UserAccesss))
                {
                    connection.Open();

                    // Create a parameterized query with the table name and fields as parameters
                    string query = $"CREATE TABLE {tableName} (ID AUTOINCREMENT PRIMARY KEY, Pass TEXT, RecipeName TEXT, " +
                        $"Description TEXT, Ingredients TEXT, Owner TEXT, VideoLink TEXT, Views NUMBER, Rating TEXT, Thumbnail TEXT, CuisineType TEXT)";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Table " + tableName + " created successfully!");
                    }

                    // Insert the password into the Pass column
                    string insertQuery = $"INSERT INTO {tableName} (Pass) VALUES (?)";
                    using (OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@Pass", password);
                        insertCommand.ExecuteNonQuery();
                        MessageBox.Show("Password inserted successfully!");
                    }

                    txbSignName.Text = null;
                    txbSignPass.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
           
        }
            


        private void btnLogin_Click(object sender, EventArgs e)
        {
       
            string username = txbLoginName.Text;
            string password = txbLoginPass.Text;

            if (username == "Admin" && password == "123456")
            {
                // Open the specific form
                Admin specificForm = new Admin();
                specificForm.Show();
                this.Hide();
            }
           
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter both username and password.");
                    return;
                }

                try
                {
                    using (OleDbConnection connection = new OleDbConnection(UserAccesss))
                    {
                        connection.Open();

                        // Construct the SQL query to select the password for the provided username
                        string query = "SELECT Pass FROM " + username + " WHERE ID = 1";
                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            using (OleDbDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Check if the password retrieved from the database matches the entered password
                                    string storedPassword = reader.GetString(0);
                                    if (password == storedPassword)
                                    {
                                        MessageBox.Show("Login successful!");
                                        this.Hide();

                                        MostRecentUsername = txbLoginName.Text;
                                        MainPage form7 = new MainPage(MostRecentUsername); //change this back to include most recent username
                                        form7.Show();

                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid password.");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Username not found.");
                                }
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
           
                try
                {
                    myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source= C:\\Users\\Owner\\Desktop\\Mini Cookbook.accdb");
                    ds = new DataSet();
                    myConn.Open();
                    MessageBox.Show("Connection Successfully!");
                    myConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
   
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txbLoginName_TextChanged(object sender, EventArgs e)
        {
            MostRecentUsername = txbLoginName.Text;
        }

        string value;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            MostRecentUsername = "Charles";

            MainPage form7 = new MainPage(MostRecentUsername); //change this back to include most recent username
            form7.Show();

 
        }

        private void button2_Click(object sender, EventArgs e)
        {

           
        }
    }
}

