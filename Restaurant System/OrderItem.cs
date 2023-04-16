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
        public class OrderItem
        {
            private int orderId;
            private int itemId;
            private int quantity;

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

            // Save the order item to the database
            public void SaveOrderItem()
            {
                // Define the SQL query with placeholders
                string sqlQuery = "INSERT INTO OrderItems (OrderID, ItemID, Quantity) " +
                                  "VALUES (:orderId, :itemId, :quantity)";

                // Create a new OracleCommand object
                using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    // Set the parameterized values
                    cmd.Parameters.Add(new OracleParameter(":orderId", OrderId));
                    cmd.Parameters.Add(new OracleParameter(":itemId", ItemId));
                    cmd.Parameters.Add(new OracleParameter(":quantity", Quantity));

                    // Open the database connection
                    conn.Open();

                    // Execute the query
                    cmd.ExecuteNonQuery();
                }
            }

        internal static DataSet GetAllOrderItems()
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
    }
    }