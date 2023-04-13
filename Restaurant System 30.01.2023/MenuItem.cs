﻿using Oracle.ManagedDataAccess.Client;
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

        public static DataSet getSummarisedMenuItems()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT ItemId, Name FROM MenuItems ORDER BY ItemId";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "menuItem");

            //Close db connection
            conn.Close();

            return ds;
        }

        public static DataSet getAllMenuItems()
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

        public static DataSet getAllMenuItemsByType(String Type)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MenuItems, Name, Qty,Price " +
                "FROM MenuItems WHERE ItemId = '" + Type + "' ORDER BY Type";

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

        public static void updateMenuItems(int itemId, string type, string name, string description, decimal price)
        {
            //Open a db connection
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                try
                {
                    conn.Open();

                    // Sanitize input parameters
                    type = type.Replace("'", "''");
                    name = name.Replace("'", "''");
                    description = description.Replace("'", "''");

                    //Define the SQL query to be executed
                    String sqlQuery = "UPDATE MenuItems SET " +
                        "Type = '" + type + "'," +
                        "Name = '" + name + "'," +
                        "Description = '" + description + "'," +
                        "Price = " + price +
                        " WHERE ItemId = " + itemId;

                    //Execute the SQL query (OracleCommand)
                    OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Handle any errors
                    Console.WriteLine("Error updating menu item: " + ex.Message);
                }
            }
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

        //Retrieve MenuItemID from database and ensure it is itterated and up to date.
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

        public static void RemoveItem (int itemId)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            OracleCommand command = conn.CreateCommand();
            command.CommandText = "UPDATE menuItems SET Availability='U' WHERE ItemId = " + itemId + "";

            // return value of ExecuteNonQuery (i) is the number of rows affected by the command
            conn.Open();

            int i = command.ExecuteNonQuery();
            Console.WriteLine(Environment.NewLine + "Rows in menuItems updated: {0}", i + Environment.NewLine);

            //Close db connection
            conn.Close();
        }
    }
}


