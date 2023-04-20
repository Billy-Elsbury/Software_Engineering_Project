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
    public class MenuItem
    {      
        private int itemId;
        private char availability;
        private String type;
        private String name;
        private String description;
        private decimal price;

        public MenuItem()
        {
            this.itemId = 0;
            this.availability = 'X';
            this.type = "";
            this.name = "";
            this.description = "";
            this.price = 0;
        }

        public MenuItem(int itemId, char availability, string type, string name, string description, decimal price)
        {
            this.itemId = itemId;
            this.availability = availability;
            this.type = type;
            this.name = name;
            this.description = description;
            this.price = price;
        }

        //getters
        public int getItemId() { return this.itemId; }
        public char getAvailability() { return this.availability; }
        public String getType() { return this.type; }
        public String getName() { return this.name; }
        public String getDescription() { return this.description; }
        public decimal getPrice() { return this.price; }

        //setters
        public void setItemId(int ItemId) { itemId = ItemId; }
        public void setAvailability(char Availability) { availability = Availability; }
        public void setType(String Type) { type = Type; }
        public void setName(String Name) { name = Name; }
        public void setDescription(String Description) { description = Description; }
        public void setPrice(Decimal Price) { price = Price; }

        public static DataSet GetSummarisedMenuItems()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT ItemId, Availability, Name FROM MenuItems ORDER BY ItemId";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "menuItem");

            //Close db connection
            conn.Close();

            return ds;
        }

        public static string GetAvailableMenuItemSummary(string menuItemType, string itemName)
        {
            string sql = "SELECT ItemId, Name, Type, Price FROM MenuItems WHERE Availability = 'A'";

            //cleaner method of constructing sql string allowing variable using:     $" SQL String '{variable}'"
            //https://learn.microsoft.com/en-us/dotnet/visual-basic/programming-guide/language-features/strings/interpolated-strings

            if (!string.IsNullOrEmpty(menuItemType))
            {
                sql += $" AND Type = '{menuItemType}'";
            }
            if (!string.IsNullOrEmpty(itemName))
            {
                sql += $" AND LOWER(Name) LIKE '%{itemName}%'";
            }

            sql += " ORDER BY Name";

            return sql;
        }


        public static DataSet GetAllMenuItems()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT ItemId, Availability, Type, Name, Description, Price FROM MenuItems ORDER BY ItemId";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "menuItem");

            //Close db connection
            conn.Close();

            return ds;
        }

        public void AddMenuItems()
        {
            // Open a db connection
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                conn.Open();

                // Define the SQL query to be executed with parameter placeholders
                string sqlQuery = "INSERT INTO MenuItems (ItemId, Availability, Type, Name, Description, Price) " +
                                  "VALUES (:itemId, :availability, :type, :name, :description, :price)";

                // Create a new OracleCommand object with the SQL query and connection
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    // Set the parameter values for the query
                    cmd.Parameters.Add("itemId", OracleDbType.Int32).Value = this.itemId;
                    cmd.Parameters.Add("availability", OracleDbType.Char).Value = this.availability;
                    cmd.Parameters.Add("type", OracleDbType.Varchar2).Value = this.type;
                    cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = this.name;
                    cmd.Parameters.Add("description", OracleDbType.Varchar2).Value = this.description;
                    cmd.Parameters.Add("price", OracleDbType.Decimal).Value = this.price;

                    // Execute the SQL query
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static MenuItem GetMenuItemById(int itemId)
        {
            // Open a db connection
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                conn.Open();

                // Define the SQL query to be executed with parameter placeholders
                string sqlQuery = "SELECT ItemId, Availability, Type, Name, Description, Price " +
                                  "FROM MenuItems " +
                                  "WHERE ItemId = :itemId";

                // Create a new OracleCommand object with the SQL query and connection
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    // Set the parameter values for the query
                    cmd.Parameters.Add("itemId", OracleDbType.Int32).Value = itemId;

                    // Execute the SQL query
                    using (OracleDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            MenuItem item = new MenuItem();
                            item.setItemId(dr.GetInt32(0));
                            item.setAvailability(dr.GetChar(1));
                            item.setType(dr.GetString(2));
                            item.setName(dr.GetString(3));
                            item.setDescription(dr.GetString(4));
                            item.setPrice(dr.GetDecimal(5));
                            return item;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }



        public static void UpdateMenuItem(int itemId, string availability, string type, string name, string description, decimal price)
        {
            //using parameterized query to avoid SQL Injection
            //https://www.c-sharpcorner.com/UploadFile/a20beb/why-should-always-use-the-parameterized-query-to-avoid-sql-i/

            //Open a db connection
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                try
                {
                    conn.Open();

                    //Define the SQL query with placeholders
                    String sqlQuery = "UPDATE MenuItems SET " +
                        "Availability = :availability," +
                        "Type = :type," +
                        "Name = :name," +
                        "Description = :description," +
                        "Price = :price" +
                        " WHERE ItemId = :itemId";

                    //Create a new OracleCommand object
                    OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                    //Set the parameterized values
                    cmd.Parameters.Add(new OracleParameter(":availability", availability));
                    cmd.Parameters.Add(new OracleParameter(":type", type));
                    cmd.Parameters.Add(new OracleParameter(":name", name));
                    cmd.Parameters.Add(new OracleParameter(":description", description));
                    cmd.Parameters.Add(new OracleParameter(":price", price));
                    cmd.Parameters.Add(new OracleParameter(":itemId", itemId));

                    //Execute the SQL query
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Handle any errors
                    Console.WriteLine("Error updating menu item: " + ex.Message);
                }
            }
        }

        public static void RemoveItem(int itemId)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            OracleCommand command = conn.CreateCommand();
            command.CommandText = "SELECT Availability FROM menuItems WHERE ItemId = " + itemId;

            conn.Open();

            // Execute the query to get the availability status of the item
            OracleDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string availability = reader.GetString(0);

                if (availability == "A")
                {
                    // If the item is available, update its availability status
                    reader.Close();
                    command.CommandText = "UPDATE menuItems SET Availability='U' WHERE ItemId = " + itemId;

                    int i = command.ExecuteNonQuery();
                    Console.WriteLine(Environment.NewLine + "Rows in menuItems updated: {0}", i + Environment.NewLine);

                    //display confirmation message
                    MessageBox.Show("Product Id: " + itemId + " removed from available Menu Items successfully", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // If the item is not available, display an error message
                    reader.Close();
                    MessageBox.Show("Product Id: " + itemId + " is already removed from available Menu Items", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // If the item is not found, display an error message
                reader.Close();
                MessageBox.Show("Product Id: " + itemId + " not found", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }

        public static string GenerateSqlFilterMenuItemQuery(string itemID, string availability, string type, string name, string description, string price)
        {
            //https://stackoverflow.com/questions/1264681/what-is-the-purpose-of-using-where-1-1-in-sql-statements

            string sql = "SELECT * FROM MenuItems WHERE 1=1";
            if (!string.IsNullOrEmpty(itemID))
            {
                sql += $" AND LOWER(ItemId) = {itemID}";
            }
            if (!string.IsNullOrEmpty(availability))
            {
                sql += $" AND (Availability) = '{availability}'";
            }
            if (!string.IsNullOrEmpty(type))
            {
                sql += $" AND (Type) = '{type}'";
            }
            if (!string.IsNullOrEmpty(name))
            {
                sql += $" AND LOWER(Name) LIKE '%{name}%'";
            }
            if (!string.IsNullOrEmpty(description))
            {
                sql += $" AND LOWER(Description) LIKE '%{description}%'";
            }
            if (!string.IsNullOrEmpty(price))
            {
                sql += $" AND LOWER(Price) LIKE '{price}%'";
            }

            return sql;
        }
    }
}


