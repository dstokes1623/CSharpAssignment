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
    public partial class Insert : Form
    {
        Login frmLogin;
        public Insert(Login frmLog)
        {
            InitializeComponent();
            this.frmLogin = frmLog;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main f1 = new Main(frmLogin);
            f1.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hireBtn_Click(object sender, EventArgs e)
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


            ItemAdapter.SelectCommand.CommandText = "Insert into Item VALUES " +
                "(@ItemNum, @Description, @OnHand, @Category, @Storehouse, @Price); ";
            ItemAdapter.SelectCommand.Parameters.AddWithValue("@ItemNum", itemNumTxt.Text);
            ItemAdapter.SelectCommand.Parameters.AddWithValue("@Description", descriptionTxt.Text);
            ItemAdapter.SelectCommand.Parameters.AddWithValue("@OnHand", onHandTxt.Text);
            ItemAdapter.SelectCommand.Parameters.AddWithValue("@Category", categoryTxt.Text);
            ItemAdapter.SelectCommand.Parameters.AddWithValue("@Storehouse", storehouseTxt.Text);
            ItemAdapter.SelectCommand.Parameters.AddWithValue("@Price", priceTxt.Text);

            try
            {
                OpenConnection.Open();
                ItemAdapter.SelectCommand.ExecuteNonQuery();

                ItemAdapter.SelectCommand.CommandText = "select * from item i where i.ITEM_NUM = @ItemNum";
                ItemAdapter.Fill(ItemDataSet, "NewItem");

                dgvNewItem.AutoGenerateColumns = true;
                dgvNewItem.DataSource = ItemDataSet;
                dgvNewItem.DataMember = "NewItem";

                dgvNewItem.Show();
                OpenConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                OpenConnection.Close();
            }

            ItemAdapter.Dispose();
            ItemDataSet.Dispose();
            OpenConnection.Close();
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete f1 = new Delete(frmLogin);
            f1.Show();
        }
    }
}
