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
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            string sqlQuery = "INSERT INTO MenuItems VALUES (" +

                this.itemId + " , '" +
                this.availability + "' , '" +
                this.type + "', '" +
                this.name + "', '" +
                this.description + "', " +
                this.price + ")";


            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
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

        public static DataSet FilterMenuItems(string sql)
        {
            DataSet dataSet = new DataSet();
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            try
            {
                OracleDataAdapter adapter = new OracleDataAdapter(sql, conn);
                adapter.Fill(dataSet);

                // Check if the dataset has any tables
                if (dataSet.Tables.Count > 0)
                {
                    DataTable dataTable = dataSet.Tables[0];

                    // Check if the table exists in the Tables collection
                    if (dataTable.Rows.Count > 0)
                    {
                        return dataSet;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately
                throw new Exception("Error executing SQL query", ex);
            }
        }



    }
}


