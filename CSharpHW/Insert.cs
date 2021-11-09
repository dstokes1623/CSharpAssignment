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

            SqlDataAdapter RepAdapter;
            RepAdapter = new SqlDataAdapter();

            DataSet RepDataSet;
            RepDataSet = new DataSet();

            SearchConnectionString = frmLogin.Connect();
            OpenConnection = new SqlConnection(SearchConnectionString);

            RepAdapter.SelectCommand = new SqlCommand();
            RepAdapter.SelectCommand.Connection = OpenConnection;

            RepAdapter.SelectCommand.CommandText = "Insert into Rep VALUES " +
                "(@RepNum, @LastName, @FirstName, @StreetAddress, @City, @State, @PostalCode, @Commission, @Rate); ";
            RepAdapter.SelectCommand.Parameters.AddWithValue("@RepNum", repNumTxt.Text);
            RepAdapter.SelectCommand.Parameters.AddWithValue("@LastName", lastNameTxt.Text);
            RepAdapter.SelectCommand.Parameters.AddWithValue("@FirstName", firstNameTxt.Text);
            RepAdapter.SelectCommand.Parameters.AddWithValue("@StreetAddress", addressTxt.Text);
            RepAdapter.SelectCommand.Parameters.AddWithValue("@City", cityTxt.Text);
            RepAdapter.SelectCommand.Parameters.AddWithValue("@State", stateTxt.Text);
            RepAdapter.SelectCommand.Parameters.AddWithValue("@PostalCode", zipCodeTxt.Text);
            RepAdapter.SelectCommand.Parameters.AddWithValue("@Commission", commissionTxt.Text);
            RepAdapter.SelectCommand.Parameters.AddWithValue("@Rate", rateTxt.Text);

            try
            {
                OpenConnection.Open();
                RepAdapter.SelectCommand.ExecuteNonQuery();

                RepAdapter.SelectCommand.CommandText = "select * from rep r where r.REP_NUM = @RepNum";
                RepAdapter.Fill(RepDataSet, "NewEmployee");

                dgvNewRep.AutoGenerateColumns = true;
                dgvNewRep.DataSource = RepDataSet;
                dgvNewRep.DataMember = "NewEmployee";

                dgvNewRep.Show();
                OpenConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                OpenConnection.Close();
            }

            RepAdapter.Dispose();
            RepDataSet.Dispose();
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
