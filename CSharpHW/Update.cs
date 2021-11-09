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
    public partial class Update : Form
    {
        Login frmLogin;
        public Update(Login frmLog)
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string SearchConnectionString;

            SqlConnection OpenConnection;

            SqlDataAdapter ItemAdapter;
            ItemAdapter = new SqlDataAdapter();

            DataSet ItemDataSet;
            ItemDataSet = new DataSet();

            SearchConnectionString = frmLogin.Connect();
            OpenConnection = new SqlConnection(SearchConnectionString);

            ItemAdapter.SelectCommand = new SqlCommand();
            ItemAdapter.SelectCommand.Connection = OpenConnection;

            ItemAdapter.SelectCommand.CommandText = "update Item set Price = @NewPrice where Item_Num = @ItemNum ; ";
            ItemAdapter.SelectCommand.Parameters.AddWithValue("@NewPrice", newPriceTxt.Text);
            ItemAdapter.SelectCommand.Parameters.AddWithValue("@ItemNum", itemNumTxt.Text);

            OpenConnection.Open();
        }
    }
}
