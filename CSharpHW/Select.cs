using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpHW
{
    public partial class Select : Form
    {
        Login frmLogin;
        public Select(Login frmLog)
        {
            InitializeComponent();
            this.frmLogin = frmLog;
        }

        private void exitSelectBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Select_Load(object sender, EventArgs e)
        {
            itemNameLbl.Hide();
            onHandValueLbl.Hide();
        }

        private void searchBtn_Click(object sender, EventArgs e)
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

            ItemAdapter.SelectCommand.CommandText = "select i.DESCRIPTION " + "from item i " +
                "where i.ITEM_NUM = '" + itemNumTxt.Text + "'; ";

            OpenConnection.Open();
            ItemAdapter.Fill(ItemDataSet, "Description");

            itemNameLbl.DataBindings.Add("Text", ItemDataSet, "Description.DESCRIPTION");
            itemNameLbl.Show();

            ItemAdapter.SelectCommand.CommandText = "select i.ON_HAND, i.PRICE, o.ORDER_NUM, o.ORDER_DATE, ol.NUM_ORDERED, ol.QUOTED_PRICE, c.CUSTOMER_NAME" +
                                                    " from item i, orders o, ORDER_LINE ol, customer c" +
                                            "where i.ITEM_NUM = ol.ITEM_NUM and o.ORDER_NUM = ol.ORDER_NUM and c.CUSTOMER_NUM = o.CUSTOMER_NUM and i.ITEM_NUM = '" + itemNumTxt.Text + "'; ";

            ItemAdapter.Fill(ItemDataSet, "ItemDetails");

            itemDetailsDGV.AutoGenerateColumns = true;
            itemDetailsDGV.DataSource = ItemDataSet;
            itemDetailsDGV.DataMember = "ItemDetails";

            ItemAdapter.SelectCommand.CommandText = "select (i.ON_HAND * i.PRICE) 'On_Hand_Value'" +
                                                    " from item i" +
                                            "where i.ITEM_NUM = '" + itemNumTxt.Text + "'; ";

            ItemAdapter.Fill(ItemDataSet, "OnHandValue");
            onHandValueLbl.DataBindings.Add("Text", ItemDataSet, "OnHandValue.On_Hand_Value");
            onHandValueLbl.Show();

            ItemAdapter.Dispose();
            ItemDataSet.Dispose();
            OpenConnection.Close();

        }

        private void backFromSelectBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main f1 = new Main(frmLogin);
            f1.Show();
        }
    }
}
