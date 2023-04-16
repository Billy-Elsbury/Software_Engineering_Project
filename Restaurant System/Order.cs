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

        private MenuItem menuItem;
        private int quantity;

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
        // Calculate the total price of the order
        private decimal CalculateTotalPrice(List<OrderItem> items)
        {
            decimal totalPrice = 0;

            foreach (OrderItem item in items)
            {
                totalPrice += menuItem.getPrice() * item.Quantity;
            }

            return totalPrice;
        }

        // Get all orders
        public List<Order> GetAllOrders()
        {
            // Define the SQL query
            string sqlQuery = "SELECT * FROM Orders";

            // Create a new OracleCommand object
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
            {
                // Open the database connection
                conn.Open();

                // Execute the query and get the results
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    // Create a new list to hold the orders
                    List<Order> orders = new List<Order>();

                    // Loop through the results and add each order to the list
                    while (reader.Read())
                    {
                        Order order = new Order();
                        order.OrderId = Convert.ToInt32(reader["OrderId"]);
                        order.TableNo = Convert.ToInt32(reader["TableNo"]);
                        order.OrderDate = Convert.ToDateTime(reader["OrderDate"]);
                        order.OrderPrice = Convert.ToDecimal(reader["OrderPrice"]);
                        order.OrderStatus = reader["OrderStatus"].ToString();

                        // Get the order items for this order
                        order.Items = GetOrderItems(order.OrderId);

                        orders.Add(order);
                    }

                    // Return the list of orders
                    return orders;
                }
            }
        }

        // Get the order items for a given order ID
        private List<OrderItem> GetOrderItems(int orderId)
        {
            // Define the SQL query
            string sqlQuery = "SELECT * FROM OrderItems WHERE OrderId = :orderId";

            // Create a new OracleCommand object
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
            {
                // Set the parameterized values
                cmd.Parameters.Add(new OracleParameter(":orderId", orderId));

                // Open the database connection
                conn.Open();

                // Execute the query and get the results
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    // Create a new list to hold the order items
                    List<OrderItem> items = new List<OrderItem>();

                    // Loop through the results and add each order item to the list
                    while (reader.Read())
                    {
                        OrderItem item = new OrderItem();
                        item.ItemId = Convert.ToInt32(reader["ItemId"]);
                        item.Quantity = Convert.ToInt32(reader["Quantity"]);

                        items.Add(item);
                    }

                    // Return the list of order items
                    return items;
                }
            }
        }
    }
}
