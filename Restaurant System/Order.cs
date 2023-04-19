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
                    order.OrderPrice = 0; //initilize to 0 so the order can be made, order items added into the database, and then the price can be calculated after
                    order.OrderStatus = 'O';

                    // Insert the order into the database
                    string insertOrderSql = "INSERT INTO Orders (OrderId, OrderDate, OrderPrice, OrderStatus) VALUES (:OrderId, :OrderDate, :OrderPrice, :OrderStatus)";

                    using (OracleCommand cmd = new OracleCommand(insertOrderSql, conn))
                    {
                        cmd.Parameters.Add(":OrderId", order.OrderId);
                        cmd.Parameters.Add(":OrderDate", order.OrderDate);
                        cmd.Parameters.Add(":OrderPrice", order.OrderPrice);
                        cmd.Parameters.Add(":OrderStatus", order.OrderStatus);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public static void AddOrderItems(DataGridView orderItemsDataGridView)
        {
            int orderId = Order.GetNextOrderId() - 1;

            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                conn.Open();
                // Loop through each row in the datagridview
                foreach (DataGridViewRow row in orderItemsDataGridView.Rows)
                {
                    double price = (Convert.ToDouble(row.Cells["Price"].Value.ToString()));



                    // Get the item id and quantity from the row
                    int itemId = Convert.ToInt32(row.Cells["ItemId"].Value);
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);

                    double unitPrice = price / quantity;

                    // Insert the order item into the database
                    string insertOrderItemSql = "INSERT INTO OrderItems (OrderId, ItemId, UnitPrice, Quantity) VALUES (:OrderId, :ItemId, :UnitPrice, :Quantity)";
                    using (OracleCommand cmd = new OracleCommand(insertOrderItemSql, conn))
                    {
                        cmd.Parameters.Add(":OrderId", orderId);
                        cmd.Parameters.Add(":ItemId", itemId);
                        cmd.Parameters.Add(":UnitPrice", unitPrice);
                        cmd.Parameters.Add(":Quantity", quantity);
                        cmd.ExecuteNonQuery();
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

                // Calculate the total price of the order items
                string sql = "SELECT SUM(UnitPrice * Quantity) AS TotalPrice " +
                                "FROM OrderItems " +
                                "WHERE OrderID = :orderId;";

                using (OracleCommand command = new OracleCommand(sql, connection))
                {
                    command.Parameters.Add(new OracleParameter(":orderId", orderId));

                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        totalPrice = Convert.ToDouble(result);
                    }
                }

                // Update the order table with the calculated total price
                sql = "UPDATE Orders " +
                        "SET TotalPrice = :totalPrice " +
                        "WHERE OrderID = :orderId;";

                using (OracleCommand command = new OracleCommand(sql, connection))
                {
                    command.Parameters.Add(new OracleParameter(":totalPrice", totalPrice));
                    command.Parameters.Add(new OracleParameter(":orderId", orderId));

                    command.ExecuteNonQuery();
                }

            }
            return totalPrice;
        }
    }
}
