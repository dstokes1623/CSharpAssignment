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
    public partial class Delete : Form
    {
        Login frmLogin;
        public Delete(Login frmLog)
        {
            InitializeComponent();
            this.frmLogin = frmLog;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main f1 = new Main(frmLogin);
            f1.Show();
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Select f1 = new Select(frmLogin);
            f1.Show();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update f1 = new Update(frmLogin);
            f1.Show();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Insert f1 = new Insert(frmLogin);
            f1.Show();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            string SearchConnectionString;

            SqlConnection OpenConnection;

            SqlDataAdapter ItemAdapter;
            ItemAdapter = new SqlDataAdapter();


            SearchConnectionString = frmLogin.Connect();
            OpenConnection = new SqlConnection(SearchConnectionString);

            ItemAdapter.SelectCommand = new SqlCommand();
            ItemAdapter.SelectCommand.Connection = OpenConnection;

            ItemAdapter.SelectCommand.CommandText = "DELETE FROM Item WHERE Item_Num = @ItemNum;";
            ItemAdapter.SelectCommand.Parameters.AddWithValue("@ItemNum", itemNumTxt.Text);

            try
            {
                OpenConnection.Open();
                ItemAdapter.SelectCommand.ExecuteNonQuery();

                MessageBox.Show("Deletion Successful");

                OpenConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                OpenConnection.Close();
            }

            ItemAdapter.Dispose();
            OpenConnection.Close();
        }
    }
}
