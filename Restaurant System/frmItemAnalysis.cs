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
    public partial class frmItemAnalysis : Form
    {
        public frmItemAnalysis()
        {
            InitializeComponent();
        }

        private void frmItemAnalysis_Load(object sender, EventArgs e)
        {
            //Fill in years
            cboSelectedYear.Items.Add("2023");
            cboSelectedYear.Items.Add("2024");
            cboSelectedYear.Items.Add("2025");
            cboSelectedYear.Items.Add("2026");

            chtItemAnalysis.Titles.Add("Menu Item Revenue");
            chtItemAnalysis.Visible = true;

        }

        private void cboSelectedYear_SelectedIndexChanged(object sender, EventArgs e)
        {

            string yearSelectedFullString = cboSelectedYear.Text;
            int yearSelectedSub = Convert.ToInt32(yearSelectedFullString.Substring(2));

            String strSQL = $"SELECT to_Char(o.OrderDate,'MM') AS Month, MAX(m.Name) AS MenuItem, SUM(oi.Quantity) AS QuantitySold" +
                " FROM Orders o" +
                " JOIN OrderItems oi ON o.OrderID = oi.OrderID" +
                " JOIN MenuItems m ON oi.ItemID = m.ItemID" +
                $" WHERE OrderDate LIKE '%{yearSelectedSub}'" +
                " GROUP BY to_Char(o.OrderDate, 'MM'), oi.ItemID" +
                " ORDER BY to_Char(o.OrderDate, 'MM'), SUM(oi.Quantity) DESC";


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
                    int month = Convert.ToInt32(dt.Rows[i]["month"]);
                    if (month >= 1 && month <= 12)
                    {
                        Amounts[month - 1] = Convert.ToDecimal(dt.Rows[i]["QuantitySold"]);
                    }
                }
            }

            chtItemAnalysis.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtItemAnalysis.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtItemAnalysis.Series[0].LegendText = "Quantity Sold";
            chtItemAnalysis.Series[0].Points.DataBindXY(Months, Amounts);
            chtItemAnalysis.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";
            chtItemAnalysis.Series[0].Points[0].AxisLabel = "JAN";
            chtItemAnalysis.Series[0].Label = "#VALY";

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
