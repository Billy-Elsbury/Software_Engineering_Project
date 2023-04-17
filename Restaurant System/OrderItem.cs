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
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                conn.Open();

                // Create a new order and save it to the database
                Order order = new Order();
                order.OrderDate = DateTime.Now;
                order.OrderStatus = "O";

                order.PlaceOrder();

                // Create a new order item and save it to the database
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO OrderItems (OrderId, ItemId, Quantity, ItemPrice) " +
                        "VALUES (:orderId, :itemId, :quantity, :itemPrice)";

                    cmd.Parameters.Add(":orderId", this.OrderId);
                    cmd.Parameters.Add(":itemId", this.ItemId);
                    cmd.Parameters.Add(":quantity", this.Quantity);

                    cmd.ExecuteNonQuery();
                }
            }
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
        }
    }