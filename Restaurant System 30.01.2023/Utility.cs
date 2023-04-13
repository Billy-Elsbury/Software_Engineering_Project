using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_System
{
    class Utility
    {
        public static class ValidationUtility
        {
            public static bool IsMenuItemValid(string itemType, string itemName, string itemDescription, string price, out string errorMessage)
            {
                // Initialize errorMessage to empty string
                errorMessage = string.Empty;

                double numberDouble;
                bool priceIsParcable = double.TryParse(price, out numberDouble);
                bool itemNameContainsDigit = itemName.Any(char.IsDigit);
                bool itemDescriptionContainsDigit = itemDescription.Any(char.IsDigit);
                bool itemNameHasNoSpecial = itemName.All(char.IsLetter);
                bool itemDescriptionHasNoSpecial = itemDescription.All(char.IsLetter);

                if (string.IsNullOrEmpty(itemType))
                {
                    errorMessage = "A Menu Item Type must be selected.";
                    return false;
                }

                if (string.IsNullOrEmpty(itemName))
                {
                    errorMessage = "Name must be entered.";
                    return false;
                }

                if (itemNameContainsDigit)
                {
                    errorMessage = "Item Name cannot include numbers.";
                    return false;
                }

                if (!itemNameHasNoSpecial)
                {
                    errorMessage = "Item Name cannot include special characters.";
                    return false;
                }

                if (string.IsNullOrEmpty(itemDescription))
                {
                    errorMessage = "Description must be entered.";
                    return false;
                }

                if (itemDescriptionContainsDigit)
                {
                    errorMessage = "Item Description cannot include numbers.";
                    return false;
                }

                if (!itemDescriptionHasNoSpecial)
                {
                    errorMessage = "Item Description cannot include special characters.";
                    return false;
                }

                if (!priceIsParcable)
                {
                    errorMessage = "Item Price must be a number, cannot include letters.";
                    return false;
                }

                if (string.IsNullOrEmpty(price))
                {
                    errorMessage = "Item Price cannot be empty.";
                    return false;
                }

                if (double.Parse(price) <= 0)
                {
                    errorMessage = "Item Price must be a positive number.";
                    return false;
                }

                // If all validation passed, return true
                return true;
            }

        }

        //Retrieve MenuItemID from database and ensure it is itterated and up to date.
        public static int GetNextmenuItemId()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //SQL query to be executed:
            String sqlQuery = "SELECT MAX(ItemId) FROM MenuItems";

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
    }
}
