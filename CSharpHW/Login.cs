using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace CSharpHW
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public string Connect()
        {
            string ConnectionString, ServerName, DatabaseName, UserId, Password;

            ServerName = serverNameTxt.Text;
            DatabaseName = databaseTxt.Text;
            UserId = userTxt.Text;
            Password = passwordTxt.Text;

            ConnectionString = "Data Source=" + ServerName + "; " + "initial catalog= " + DatabaseName +
                "; User ID=" + UserId + "; Password=" + Password + ";";

            return ConnectionString;
        }

        public bool checkConnection()
        {
            bool worked = false;
            string ConnectionStr;

            SqlConnection OpenConnection;

            ConnectionStr = Connect();

            OpenConnection = new SqlConnection(ConnectionStr);

            try
            {
                OpenConnection.Open();
                worked = true;

                OpenConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                OpenConnection.Close();
            }

            return worked;
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            bool ConnectionOpened;

            ConnectionOpened = checkConnection();

            if (ConnectionOpened)
            {
                this.Hide();
                Main f1 = new Main(this);

                f1.Show();
            }
            else
            {
                MessageBox.Show("Please try again!");
            }
        }
    }
}
