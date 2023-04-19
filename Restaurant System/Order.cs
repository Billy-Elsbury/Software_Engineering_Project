using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
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

        public static void CreateOrder()
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                conn.Open();
                {
                    // Create new order and add item
                    Order order = new Order();
                    order.OrderId = Order.GetNextOrderId();
                    order.OrderDate = DateTime.Now;
                    order.OrderPrice = Order.CalculateOrderPrice(Utility.GetNextMenuItemId());
                    order.OrderStatus = 'O';

                    // Insert the order into the database
                    string insertOrderSql = "INSERT INTO Orders (OrderId, OrderDate, OrderPrice, OrderStatus) VALUES (:OrderId, :OrderDate, :OrderPrice, :OrderStatus)";
                    using (OracleCommand insertCmd = new OracleCommand(insertOrderSql))
                    {
                        insertCmd.Parameters.Add(":OrderId", order.OrderId);
                        insertCmd.Parameters.Add(":OrderDate", order.OrderDate);
                        insertCmd.Parameters.Add(":OrderPrice", order.OrderPrice);
                        insertCmd.Parameters.Add(":OrderStatus", order.OrderStatus);
                        insertCmd.ExecuteNonQuery();
                    }


                }
            }
        }

        public static void AddOrderItems(DataGridView dataGridView)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                int orderId = Order.GetNextOrderId();

                conn.Open();
                // Loop through each row in the datagridview
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    // Get the item id and quantity from the row
                    int itemId = Convert.ToInt32(row.Cells["ItemId"].Value);
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);

                    // Insert the order item into the database
                    string insertOrderItemSql = "INSERT INTO OrderItems (OrderId, ItemId, Quantity) VALUES (:OrderId, :ItemId, :Quantity)";
                    using (OracleCommand insertCmd = new OracleCommand(insertOrderItemSql, conn))
                    {
                        insertCmd.Parameters.Add(":OrderId", orderId);
                        insertCmd.Parameters.Add(":ItemId", itemId);
                        insertCmd.Parameters.Add(":Quantity", quantity);
                        insertCmd.ExecuteNonQuery();
                    }
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

        //Retrieve OrderItemID from database and ensure it is itterated and up to date.
        public static int GetNextOrderId()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //SQL query to be executed:
            String sqlQuery = "SELECT MAX(OrderId) FROM Orders";

            //Execute the SQL query (OracleCommand())
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader reader = cmd.ExecuteReader();

            //Test dataReader for NULL value
            int nextId;
            reader.Read();

            if (reader.IsDBNull(0))
                nextId = 1;
            else
            {
                nextId = reader.GetInt32(0) + 1;
            }

            //Close db connection
            conn.Close();

            return nextId;
        }

        // Calculate the total price of the order
        public static double CalculateOrderPrice(int orderId)
        {
            double totalPrice = 0;

            using (OracleConnection connection = new OracleConnection(DBConnect.oradb))
            {
                connection.Open();

                string sql = "SELECT SUM(OrderItems.Quantity * MenuItems.Price) AS TotalPrice " +
                             "FROM OrderItems " +
                             "JOIN MenuItems ON OrderItems.ItemId = MenuItems.ItemId " +
                             "WHERE OrderItems.OrderId = :OrderId";

                using (OracleCommand command = new OracleCommand(sql, connection))
                {
                    command.Parameters.Add(new OracleParameter(":OrderId", orderId));

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        // Test dataReader for NULL value

                        reader.Read();

                        if (reader.IsDBNull(0))
                        {
                            totalPrice = 0;
                        }
                        else
                        {
                            totalPrice = reader.GetDouble(0);
                        }
                    }
                }
            }
            return totalPrice;
        }
    }
}
