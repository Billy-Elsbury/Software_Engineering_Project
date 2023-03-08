using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_System
{
    public class MenuItem
    {
        private char availability;
        private int itemId;
        private String type;
        private String name;
        private String description;
        private decimal price;

        public MenuItem()
        {
            this.availability = 'X';
            this.itemId = 0;
            this.type = "";
            this.name = "";
            this.description = "";
            this.price = 0;
        }

        public MenuItem(char availability, int itemId, string type, string name, string description, decimal price)
        {
            this.availability = availability;
            this.itemId = itemId;
            this.type = type;
            this.name = name;
            this.description = description;
            this.price = price;
        }

        //getters
        public char getAvailability() { return this.availability; }
        public int getItemId() { return this.itemId; }
        public String getType() { return this.type; }
        public String getName() { return this.name; }
        public String getDescription() { return this.description; }
        public decimal getPrice() { return this.price; }

        //setters
        public void setAvailability(char Availability) { availability = Availability; }
        public void setItemId(int ItemId) { itemId = ItemId; }
        public void setType(String Type) { type = Type; }
        public void setName(String Name) { name = Name; }
        public void setDescription(String Description) { description = Description; }
        public void setPrice(Decimal Price) { price = Price; }

        public static DataSet getAllMenuItems()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT Availability ,ItemId, Type, Name, Description, Price " +
                "FROM MenuItems ORDER BY Name";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "menuItem");

            //Close db connection
            conn.Close();

            return ds;
        }

        public static DataSet getAllMenuItems(String Type)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MenuItems, Name, Qty,Price " +
                "FROM MenuItems WHERE ItemId = '" + Type + "' ORDER BY Name";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "menuItem");

            //Close db connection
            conn.Close();

            return ds;
        }

        public void getMenuItems(int Id)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM MenuItems WHERE ItemId = " + Id;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //set the instance variables with values from data reader
            setAvailability(dr.GetChar(0));
            setItemId(dr.GetInt32(1));
            setType(dr.GetString(2));
            setName(dr.GetString(3));
            setDescription(dr.GetString(4));
            setPrice(dr.GetDecimal(5));

            //close DB
            conn.Close();
        }

        public void addMenuItems()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            string sqlQuery = "INSERT INTO MenuItems VALUES ('" + 
                this.availability + "', " + 
                this.itemId + ", '" + 
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

        public void updateMenuItems()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE MenuItems SET " +
                "ItemId = " + this.itemId + "," +
                "Name = '" + this.name + "'," +
                "Type = '" + this.type + "'," +
                "Description = '" + this.description + "'," +
                "Price = " + this.price + "," +
                "WHERE ItemId = " + this.itemId;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public static DataSet findMenuItems(String itemName)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT ItemId, Name, Manufacturer FROM Products " +
                "WHERE Name LIKE '%" + itemName + "%' ORDER BY Name";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "menuItem");

            //Close db connection
            conn.Close();

            return ds;
        }

        public static int getNextmenuItemId()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //SQL query to be executed:
            String sqlQuery = "SELECT MAX(ItemId) FROM MenuItems";

            //Execute the SQL query (OracleCommand())
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader reader = cmd.ExecuteReader();

            //Test dataReader for NULL value?
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
    }
}
