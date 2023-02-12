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

namespace Restuarant_System
{
    public partial class DB_Connection_Test : Form
    {
        OracleConnection conn = new OracleConnection(DBConnect.oradb);

        public DB_Connection_Test()
        {
            InitializeComponent();
        }

        private void openConnect_Click(object sender, EventArgs e)
        {
            //open database connection
            conn.Open();
            lblMessage.Text = "OPEN";
            
        }

        private void closeConnect_Click(object sender, EventArgs e)
        {
            conn.Close();
            lblMessage.Text = "CLOSED";

        }
    }
}
