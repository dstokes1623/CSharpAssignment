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
    public partial class Main : Form
    {
        Login frmLogin;
        public Main(Login frmLog)
        {
            InitializeComponent();
            this.frmLogin = frmLog;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            Select f1 = new Select(frmLogin);

            f1.Show();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            this.Hide();

            Update f1 = new Update(frmLogin);

            f1.Show();
        }
    }
}
