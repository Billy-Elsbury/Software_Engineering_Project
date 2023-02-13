using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;

namespace MyTestApp2
{
    class Product
    {
        private int prodID;
        private String name;
        private String description;
        private string manufacturer;
        private int qty;
        private decimal price;
        private String typeCode;


        public Product()
        {
            this.prodID = 0;
            this.name = "";
            this.description = "";
            this.manufacturer = "";
            this.qty = 0;
            this.price = 0;
            this.typeCode = "";
        }

        public Product(int prodID, string name, string description, string manufacturer, int qty, decimal price, string typeCode)
        {
            this.prodID = prodID;
            this.name = name;
            this.description = description;
            this.manufacturer = manufacturer;
            this.qty = qty;
            this.price = price;
            this.typeCode = typeCode;
        }

        //getters
        public int getProdID() {return this.prodID; }
        public String getName() { return this.name; }
        public String getDescription() { return this.description; }
        public String getManufacturer() { return this.manufacturer; }
        public int getQty() { return this.qty; }
        public decimal getPrice() { return this.price; }
        public String getTypeCode() { return this.typeCode; }

        //setters
        public void setProdID(int ProdID) { prodID = ProdID; }
        public void setName(String Name) { name = Name; }
        public void setDescription (String Description) { description = Description; }
        public void setManufacturer(String Manufacturer) { manufacturer = Manufacturer; }
        public void setQty(int Qty) { qty = Qty; }
        public void setPrice(Decimal Price) { price = Price; }
        public void setTypeCode(String TypeCode) { typeCode = TypeCode; }

        public static DataSet getAllProducts()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT ProductId, Name, Qty,Price " +
                "FROM Products ORDER BY Name";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "prod");

            //Close db connection
            conn.Close();

            return ds;
        }
        public static DataSet getAllProducts(String TypeCode)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT ProductId, Name, Qty,Price " +
                "FROM Products WHERE TypeCode = '" + TypeCode + "' ORDER BY Name";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "prod");

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
            setProdID(dr.GetInt32(0));
            setName(dr.GetString(1));
            setDescription(dr.GetString(2));
            setManufacturer(dr.GetString(3));
            setQty(dr.GetInt32(4));
            setPrice(dr.GetDecimal(5));
            setTypeCode(dr.GetString(6));

            //close DB
            conn.Close();
        }
        public void addProduct()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Products Values (" + 
                this.prodID + ",'" + 
                this.name + "','" + 
                this.description + "','" + 
                this.manufacturer + "'," + 
                this.qty + "," + 
                this.price + ",'" + 
                this.typeCode + "')";

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
                "ProductId = " + this.prodID + "," +
                "Name = '" + this.name + "'," +
                "Description = '" + this.description + "'," +
                "Manufacturer = '" + this.manufacturer + "'," +
                "Qty = " + this.qty + "," +
                "Price = " + this.price + "," +
                "TypeCode = '" + this.typeCode + "' " +
                "WHERE ProductId = " + this.prodID;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public static DataSet findProducts(String prodName)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT ProductId, Name, Manufacturer FROM Products " +
                "WHERE Name LIKE '%" + prodName + "%' ORDER BY Name";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "prod");

            //Close db connection
            conn.Close();

            return ds;
        }

        public static int getNextProdID()
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
