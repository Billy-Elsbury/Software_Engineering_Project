using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restuarant_System
{
    public partial class frmRevenueAnalysis : Form
    {
        public frmRevenueAnalysis()
        {
            InitializeComponent();
        }

        private void frmRevenueAnalysis_Load(object sender, EventArgs e)
        {
            //Fill in years
            cboSelectedYear.Items.Add("2023");
            cboSelectedYear.Items.Add("2024");
            cboSelectedYear.Items.Add("2025");
            cboSelectedYear.Items.Add("2026");

            chtRevenueAnalysis.Titles.Add("Yearly Revenue");
            chtRevenueAnalysis.Visible = true;

        }

        private void cboSelectedYear_SelectedIndexChanged(object sender, EventArgs e)
        {

            string yearSelectedFullString = cboSelectedYear.Text;
            int yearSelectedSub = Convert.ToInt32(yearSelectedFullString.Substring(2));

            String strSQL = "SELECT to_Char(OrderDate,'MM'), SUM(OrderPrice)  FROM " +
                $"Orders WHERE OrderDate LIKE '%{yearSelectedSub}' GROUP BY to_Char(OrderDate,'MM') ORDER BY to_char(OrderDate, 'MM')";

            DataTable dt = new DataTable();
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            myConn.Close();

            //Array size 12 since there are 12 months in a year
            string[] Months = new string[12];
            decimal[] Amounts = new decimal[12];

            //pre-fill each array; Months[] with month name; Amounts[] with zero values
            for (int i = 0; i < Months.Length; i++)
            {
                Months[i] = getMonth(i + 1);
                Amounts[i] = 0;
            }


            //Next, save the amounts returned in Query to the appropriate element in Amounts[]
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int month = Convert.ToInt32(dt.Rows[i][0]);
                    if (month >= 1 && month <= 12)
                    {
                        Amounts[month - 1] = Convert.ToDecimal(dt.Rows[i][1]);
                    }
                }
            }

            chtRevenueAnalysis.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtRevenueAnalysis.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtRevenueAnalysis.Series[0].LegendText = "Income in €";
            chtRevenueAnalysis.Series[0].Points.DataBindXY(Months, Amounts);
            chtRevenueAnalysis.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";
            chtRevenueAnalysis.Series[0].Points[0].AxisLabel = "JAN";
            chtRevenueAnalysis.Series[0].Label = "#VALY";
            
        }

        public String getMonth(int month)
        {
            string[] monthNames = new string[] {"JAN", "FEB", "MAR", "APR", "MAY", "JUN",
        "JUL", "AUG", "SEP", "OCT", "NOV", "DEC"};

            if (month >= 1 && month <= 12)
            {
                return monthNames[month - 1];
            }
            else
            {
                return "OTH";
            }
        }

    }
}
