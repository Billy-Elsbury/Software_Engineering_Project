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
        private int itemId;
        private String type;
        private String name;
        private String description;
        private decimal price;

        public MenuItem()
        {
            this.itemId = 0;
            this.type = "";
            this.name = "";
            this.description = "";
            this.price = 0;
        }

        public MenuItem(int itemId, string type, string name, string description, decimal price)
        {
            this.itemId = itemId;
            this.type = type;
            this.name = name;
            this.description = description;
            this.price = price;
        }

        //getters
        public int getItemId() { return this.itemId; }
        public String getType() { return this.type; }
        public String getName() { return this.name; }
        public String getDescription() { return this.description; }
        public decimal getPrice() { return this.price; }

        //setters
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
            String sqlQuery = "SELECT ItemId, , Type, Name, Description, Price " +
                "FROM Products ORDER BY Name";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "menuItem");

            //Close db connection
            conn.Close();

            return ds;
        }

        public static DataSet getAllProducts(String Type)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT ProductId, Name, Qty,Price " +
                "FROM Products WHERE ItemId = '" + Type + "' ORDER BY Name";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "menuItem");

            //Close db connection
            conn.Close();

            return ds;
        }

        public void getProduct(int Id)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Products WHERE ProductID = " + Id;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //set the instance variables with values from data reader
            setItemId(dr.GetInt32(0));
            setType(dr.GetString(1));
            setName(dr.GetString(1));
            setDescription(dr.GetString(2));
            setPrice(dr.GetDecimal(5));

            //close DB
            conn.Close();
        }

        public void addProduct()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Products Values (" +
                this.itemId + ",'" +
                this.type + "','" +
                this.name + "','" +
                this.description + "','" +
                this.price + ",')";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public void updateProduct()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE Products SET " +
                "ProductId = " + this.itemId + "," +
                "Name = '" + this.name + "'," +
                "Type = '" + this.type + "'," +
                "Description = '" + this.description + "'," +
                "Price = " + this.price + "," +
                "WHERE ProductId = " + this.itemId;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public static DataSet findProducts(String itemName)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT ProductId, Name, Manufacturer FROM Products " +
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

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(ProductId) FROM Products";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            //Does dr contain a value or NULL?
            int nextId;
            dr.Read();

            if (dr.IsDBNull(0))
                nextId = 1;
            else
            {
                nextId = dr.GetInt32(0) + 1;
            }

            //Close db connection
            conn.Close();

            return nextId;
        }
    }
}
