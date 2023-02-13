using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace MyTestApp2
{
    public partial class frmConnect : Form
    {
        OracleConnection conn = new OracleConnection(DBConnect.oradb);

        public frmConnect()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //open a connection to the database
            if (conn.State == ConnectionState.Open)
                return;
            conn.Open();
            lblStatus.Text = "Connection is now OPEN";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            conn.Close();
            lblStatus.Text = "Connection is now Closed";
        }
    }
}
