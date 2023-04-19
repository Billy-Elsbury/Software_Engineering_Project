using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restuarant_System
{
    public class OrderItems
    {
        private int orderId;
        private int itemId;
        private int quantity;
        private double orderItemPrice;

        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        public int ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double OrderItemPrice
        {
            get { return orderItemPrice; }
            set { orderItemPrice = value; }
        }

        public static DataSet GetAllOrderItems()
        {
                {
                    //Open a db connection
                    OracleConnection conn = new OracleConnection(DBConnect.oradb);

                    //Define the SQL query to be executed
                    String sqlQuery = "SELECT OrderId, ItemId, Quantity FROM OrderItems ORDER BY OrderId";

                    //Execute the SQL query (OracleCommand)
                    OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                    OracleDataAdapter da = new OracleDataAdapter(cmd);

                    DataSet ds = new DataSet();
                    da.Fill(ds, "menuItem");

                    //Close db connection
                    conn.Close();

                    return ds;
                }
        }

        public static DataSet GetActiveOrderItems(int orderId)
        {
            // Define the SQL query
            string sqlQuery = "SELECT * FROM OrderItems WHERE OrderID = :orderId";

            // Create a new OracleCommand object
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
            {
                // Add the parameter for the order ID
                cmd.Parameters.Add(new OracleParameter("orderId", orderId));

                // Create a new OracleDataAdapter object
                using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                {
                    // Create a new DataSet object to hold the results
                    DataSet ds = new DataSet();

                    // Fill the DataSet with the results of the query
                    adapter.Fill(ds, "OrderItems");

                    // Return the DataSet
                    return ds;
                }
            }
        }
    }
}