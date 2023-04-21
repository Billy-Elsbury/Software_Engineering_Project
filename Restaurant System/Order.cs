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

        public static void AddNewOrderItems(DataGridView orderItemsDataGridView)
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

        public static void EditOrderItems(DataRow orderItemsDataRow)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                conn.Open();

                int orderId = Convert.ToInt32(orderItemsDataRow["OrderId"]);
                int itemId = Convert.ToInt32(orderItemsDataRow["ItemId"]);
                double unitPrice = Convert.ToDouble(orderItemsDataRow["UnitPrice"]);
                int quantity = Convert.ToInt32(orderItemsDataRow["Quantity"]);

                string selectOrderItemSql = "SELECT Quantity FROM OrderItems WHERE OrderId = :OrderId AND ItemId = :ItemId";
                using (OracleCommand selectCmd = new OracleCommand(selectOrderItemSql, conn))
                {
                    selectCmd.Parameters.Add(":OrderId", orderId);
                    selectCmd.Parameters.Add(":ItemId", itemId);
                    object result = selectCmd.ExecuteScalar();
                    int quantityCount = Convert.ToInt32(result);

                    if (quantityCount >= 1)
                    {
                        // Item is already in the order, so update the quantity
                        int currentQuantity = Convert.ToInt32(result);
                        int newQuantity = quantity + currentQuantity;

                        string updateOrderItemSql = "UPDATE OrderItems SET Quantity = :Quantity WHERE OrderId = :OrderId AND ItemId = :ItemId";
                        using (OracleCommand updateCmd = new OracleCommand(updateOrderItemSql, conn))
                        {
                            updateCmd.Parameters.Add(":Quantity", newQuantity);
                            updateCmd.Parameters.Add(":OrderId", orderId);
                            updateCmd.Parameters.Add(":ItemId", itemId);
                            
                            updateCmd.ExecuteNonQuery();

                            var updateOuput = updateCmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // Item is not yet in the order, so insert a new row

                        string insertOrderItemSql = "INSERT INTO OrderItems (OrderId, ItemId, UnitPrice, Quantity) VALUES (:OrderId, :ItemId, :UnitPrice, :Quantity)";
                        using (OracleCommand insertCmd = new OracleCommand(insertOrderItemSql, conn))
                        {
                            insertCmd.Parameters.Add(":OrderId", orderId);
                            insertCmd.Parameters.Add(":ItemId", itemId);
                            insertCmd.Parameters.Add(":UnitPrice", unitPrice);
                            insertCmd.Parameters.Add(":Quantity", quantity);
                            insertCmd.ExecuteNonQuery();
                        }
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

        public static string GenerateSqlFilterOrderQuery(string orderId, string orderStatus)
        {
            //https://stackoverflow.com/questions/1264681/what-is-the-purpose-of-using-where-1-1-in-sql-statements

            string sql = "SELECT * FROM Orders WHERE 1=1";
            if (!string.IsNullOrEmpty(orderId))
            {
                sql += $" AND LOWER(OrderId) = {orderId}";
            }
            if (!string.IsNullOrEmpty(orderStatus))
            {
                sql += $" AND (OrderStatus) = '{orderStatus}'";
            }
            return sql;
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
                                "WHERE OrderID = :orderId";

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
                        "SET OrderPrice = :TotalPrice " +
                        "WHERE OrderID = :orderId";

                using (OracleCommand command = new OracleCommand(sql, connection))
                {
                    command.Parameters.Add(new OracleParameter(":totalPrice", totalPrice));
                    command.Parameters.Add(new OracleParameter(":orderId", orderId));

                    command.ExecuteNonQuery();
                }

            }
            return totalPrice;
        }

        public static DataTable GetOrderItemsByOrderId(int orderId)
        {
            DataTable dt = new DataTable();
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                string sql = "SELECT MenuItems.ItemId As ItemId, MenuItems.Name AS ItemName, MenuItems.Type AS ItemType, OrderItems.Quantity AS Quantity, OrderItems.unitPrice AS UnitPrice " +
                             "FROM OrderItems " +
                             "JOIN MenuItems ON OrderItems.ItemID = MenuItems.ItemID " +
                             "JOIN Orders ON OrderItems.OrderID = Orders.OrderID " +
                             "WHERE Orders.OrderID = :OrderId";

                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add(":OrderId", orderId);
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }
    }
}
