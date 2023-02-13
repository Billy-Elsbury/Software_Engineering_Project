using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace MyTestApp2
{
    class Type
    {
        String typeCode;
        String meaning;

        public Type(string typeCode, string meaning)
        {
            this.typeCode = typeCode;
            this.meaning = meaning;
        }

        public static DataSet getTypes()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Types ORDER BY TypeCode";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "types");

            //Close db connection
            conn.Close();

            return ds;
        }
    }
}
