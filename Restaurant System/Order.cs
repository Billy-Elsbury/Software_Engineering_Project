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
        private string orderStatus;
        private List<OrderItem> items;

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

        public string OrderStatus
        {
            get { return orderStatus; }
            set { orderStatus = value; }
        }

        public List<OrderItem> Items
        {
            get { return items; }
            set { items = value; }
        }

        // Save the order to the database
        public void PlaceOrder()
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                conn.Open();

                // Create a new order in the database
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO Orders (OrderDate, OrderStatus) " +
                        "VALUES (:orderDate, :orderStatus)";

                    cmd.Parameters.Add(":orderDate", this.OrderDate);
                    cmd.Parameters.Add(":orderStatus", this.OrderStatus);

                    cmd.ExecuteNonQuery();
                }

                // Retrieve the generated order ID
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT SEQ_ORDERS.CURRVAL FROM DUAL";
                    this.OrderId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                // Save each order item to the database
                foreach (OrderItem item in this.Items)
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO OrderItems (OrderId, ItemId, Quantity) " +
                            "VALUES (:orderId, :itemId, :quantity)";

                        cmd.Parameters.Add(":orderId", this.OrderId);
                        cmd.Parameters.Add(":itemId", item.ItemId);
                        cmd.Parameters.Add(":quantity", item.Quantity);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }




        // Cancel the order
        public void CancelOrder()
        {
            // Define the SQL query with placeholders
            string sqlQuery = "UPDATE Orders SET OrderStatus = 'C' WHERE OrderId = :orderId";

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

        // Calculate the total price of the order
        private decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (OrderItem item in items)
            {
                // Retrieve the MenuItem object for this OrderItem from the database
                MenuItem menuItem = MenuItem.GetMenuItemById(item.ItemId);

                // Calculate the price for this OrderItem based on the quantity and menu item price
                decimal itemPrice = menuItem.getPrice() * item.Quantity;

                totalPrice += itemPrice;
            }

            return totalPrice;
        }



        // Get all orders
        public DataSet GetAllOrders()
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
