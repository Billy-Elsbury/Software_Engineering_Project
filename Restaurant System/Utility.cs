using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                bool priceIsParsable = double.TryParse(price, out numberDouble);
                bool itemNameBlank = itemName.Equals("");
                bool itemNameContainsDigit = itemName.Any(char.IsDigit);
                bool itemDescriptionBlank = itemDescription.Equals("");
                bool itemDescriptionContainsDigit = itemName.Any(char.IsDigit);

                //https://learn.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex?view=net-8.0

                bool itemNameHasNoSpecial = !Regex.IsMatch(itemName, @"[^a-zA-Z\s]"); // Only allow letters and spaces
                bool itemDescriptionHasNoSpecial = !Regex.IsMatch(itemDescription, @"[^a-zA-Z\s]"); // Only allow letters and spaces

                if (itemNameBlank)
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

                if (itemDescriptionBlank)
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

                if (!priceIsParsable)
                {
                    errorMessage = "Item Price must be a number, cannot include letters.";
                    return false;
                }

                if (double.Parse(price) <= 0)
                {
                    errorMessage = "Item Price must be a positive number.";
                    return false;
                }

                if (string.IsNullOrEmpty(itemType))
                {
                    errorMessage = "Item Type cannot be empty.";
                    return false;
                }

                // If all validation passed, return true
                return true;
            }

            public static bool QueryValidFilter(string itemName, string itemDescription, string price, out string errorMessage)
            {
                // Initialize errorMessage to empty string
                errorMessage = string.Empty;

                double numberDouble;
                bool priceIsParseable = double.TryParse(price, out numberDouble);

                if (!string.IsNullOrEmpty(itemName))
                {
                    bool itemNameHasNoSpecial = !Regex.IsMatch(itemName, @"[^a-zA-Z\s]"); // Only allow letters and spaces
                    if (!itemNameHasNoSpecial)
                    {
                        errorMessage = "Item Name cannot include special characters or numbers.";
                        return false;
                    }
                }

                if (!string.IsNullOrEmpty(itemDescription))
                {
                    bool itemDescriptionHasNoSpecial = !Regex.IsMatch(itemDescription, @"[^a-zA-Z\s]"); // Only allow letters and spaces
                    if (!itemDescriptionHasNoSpecial)
                    {
                        errorMessage = "Item Description cannot include special characters or numbers.";
                        return false;
                    }
                }

                if (!string.IsNullOrEmpty(price))
                {
                    if (!priceIsParseable)
                    {
                        errorMessage = "Item Price must be a number, cannot include letters.";
                        return false;
                    }

                    if (double.Parse(price) <= 0)
                    {
                        errorMessage = "Item Price must be a positive number.";
                        return false;
                    }
                }

                // If all validation passed, return true
                return true;
            }


        }

        //Retrieve MenuItemID from database and ensure it is itterated and up to date.
        public static int GetNextMenuItemId()
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

        //Retrieve OrderItemID from database and ensure it is itterated and up to date.
        public static int GetNextOrderItemId()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //SQL query to be executed:
            String sqlQuery = "SELECT MAX(OrderId) FROM OrderItems";

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

                string sql = "SELECT SUM(OrderItems.Quantity * MenuItems.Price) AS TotalPrice " +
                             "FROM OrderItems " +
                             "JOIN MenuItems ON OrderItems.ItemId = MenuItems.ItemId " +
                             "WHERE OrderItems.OrderId = :OrderId";

                using (OracleCommand command = new OracleCommand(sql, connection))
                {
                    command.Parameters.Add(new OracleParameter(":OrderId", orderId));

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        // Test dataReader for NULL value
 
                        reader.Read();

                        if (reader.IsDBNull(0))
                        {
                            totalPrice = 0;
                        }
                        else 
                        { 
                            totalPrice = reader.GetDouble(0); 
                        }
                    }
                }
            }

            return totalPrice;
        }



        public static void ShowNextForm(Form currentForm, Form nextForm)
        {
            currentForm.Hide();

            //use FirstOrDefault to check if mainMenu is open, if already open show it or create a new one if not.
            //https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.firstordefault?view=net-8.0

            frmRestaurantTillMenu mainMenu = Application.OpenForms.OfType<frmRestaurantTillMenu>().FirstOrDefault();
            if (mainMenu != null)
            {
                mainMenu.Hide();
            }
            nextForm.ShowDialog();
            currentForm.Show();
            if (mainMenu != null)
            {
                mainMenu.Show();
            }
        }



        //Back Button Code
        public static void BackButton(Form currentForm)
        {
            currentForm.Hide();
            foreach (Form form in Application.OpenForms)
            {
                if (form is frmRestaurantTillMenu)
                {
                    form.Show();
                    return;
                }
            }
            frmRestaurantTillMenu nextForm = new frmRestaurantTillMenu();
            nextForm.Show();
        }
    }
}
