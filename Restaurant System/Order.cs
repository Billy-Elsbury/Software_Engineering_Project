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
        private int tableNo;
        private DateTime orderDate;
        private decimal orderPrice;
        private string orderStatus;
        private List<OrderItem> items;

        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        public int TableNo
        {
            get { return tableNo; }
            set { tableNo = value; }
        }

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        public decimal OrderPrice
        {
            get { return orderPrice; }
            set { orderPrice = value; }
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

        public void PlaceOrder()
        {
            // Define the SQL query with placeholders
            string sqlQuery = "INSERT INTO Orders (TableNo, OrderDate, OrderPrice, OrderStatus) " +
                              "VALUES (:tableNo, :orderDate, :orderPrice, :orderStatus); " +
                              "SELECT OrderId FROM Orders WHERE OrderId = SCOPE_IDENTITY()";

            // Create a new OracleCommand object
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
            {
                // Set the parameterized values
                cmd.Parameters.Add(new OracleParameter(":tableNo", TableNo));
                cmd.Parameters.Add(new OracleParameter(":orderDate", OrderDate));
                cmd.Parameters.Add(new OracleParameter(":orderPrice", CalculateTotalPrice(items)));
                cmd.Parameters.Add(new OracleParameter(":orderStatus", OrderStatus));

                // Open the database connection
                conn.Open();

                // Execute the query and retrieve the new OrderId
                OrderId = Convert.ToInt32(cmd.ExecuteScalar());

                // Save the order items to the database
                foreach (OrderItem item in items)
                {
                    // Define the SQL query with placeholders
                    sqlQuery = "INSERT INTO OrderItems (OrderId, ItemId, Quantity) " +
                               "VALUES (:orderId, :itemId, :quantity)";

                    // Create a new OracleCommand object
                    OracleCommand orderItemCmd = new OracleCommand(sqlQuery, conn);

                    // Set the parameterized values
                    orderItemCmd.Parameters.Add(new OracleParameter(":orderId", OrderId));
                    orderItemCmd.Parameters.Add(new OracleParameter(":itemId", item.ItemId)); // fixed property name
                    orderItemCmd.Parameters.Add(new OracleParameter(":quantity", item.Quantity)); // fixed property name

                    // Execute the query
                    orderItemCmd.ExecuteNonQuery();
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
        private decimal CalculateTotalPrice(List<OrderItem> items)
        {
            decimal totalPrice = 0;

            foreach (OrderItem item in items)
            {
                MenuItem menuItem = item.MenuItem;
                totalPrice += menuItem.getPrice() * item.Quantity;
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
