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
    public class Order
    {
        private int orderId;
        private DateTime orderDate;
        private double orderPrice;
        private char orderStatus;

        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        public double OrderPrice
        {
            get { return orderPrice; }
            set { orderPrice = value; }
        }

        public char OrderStatus
        {
            get { return orderStatus; }
            set { orderStatus = value; }
        }

        // Save the order to the database
        public static void PlaceOrder()
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                conn.Open();

                // Create a new order in the database
                using (OracleCommand cmd = new OracleCommand())
                {
                    // Retrieve the next order ID
                    int nextOrderId = Utility.GetNextOrderItemId();


                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO Orders (OrderId, OrderDate, OrderStatus) " +
                        "VALUES (:orderId, :orderDate, :orderStatus)";

                    cmd.Parameters.Add(":orderId", nextOrderId);
                    cmd.Parameters.Add(":orderDate", DateTime.Now);
                    cmd.Parameters.Add(":orderStatus", 'O');

                    cmd.ExecuteNonQuery();
                }
            }
        }




        // Cancel the order
        public static void VoidOrder(int OrderId)
        {
            // Define the SQL query with placeholders
            string sqlQuery = "UPDATE Orders SET OrderStatus = 'V' WHERE OrderId = :orderId";

            // Create a new OracleCommand object
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
            {
                // Set the parameterized values
                cmd.Parameters.Add(new OracleParameter(":orderId", OrderId));

                // Open the database connection
                conn.Open();

                // Execute the query
                cmd.ExecuteNonQuery();
            }
        }

        // Get all orders
        public static DataSet GetAllOrders()
        {
            // Define the SQL query
            string sqlQuery = "SELECT * FROM Orders";

            // Create a new OracleCommand object
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
            {
                // Create a new OracleDataAdapter object
                using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                {
                    // Create a new DataSet object to hold the results
                    DataSet ds = new DataSet();

                    // Fill the DataSet with the results of the query
                    adapter.Fill(ds, "Orders");

                    // Return the DataSet
                    return ds;
                }
            }
        }
    }
}
