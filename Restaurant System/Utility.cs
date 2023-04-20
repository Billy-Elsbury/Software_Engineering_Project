using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
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
                bool itemNameBlank = (string.IsNullOrWhiteSpace(itemName)) ;
                bool itemNameContainsDigit = itemName.Any(char.IsDigit);
                bool itemDescriptionBlank = (string.IsNullOrWhiteSpace(itemDescription)) ;
                bool itemDescriptionContainsDigit = itemName.Any(char.IsDigit);

                //https://learn.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex?view=net-8.0

                bool itemNameHasNoSpecial = !Regex.IsMatch(itemName, @"[^a-zA-Z\s]"); // Only allow letters and spaces
                bool itemDescriptionHasNoSpecial = !Regex.IsMatch(itemDescription, @"[^a-zA-Z\s]"); // Only allow letters and spaces

                if (itemNameBlank)
                {
                    errorMessage = "Item Name cannot be blank.";
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
                    errorMessage = "Description cannot be blank.";
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

            public static bool QueryMenuItemValidFilter(string itemName, string itemDescription, string price, out string errorMessage)
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

            public static bool ValidItemName(string itemName, out string errorMessage)
            {
                // Initialize errorMessage to empty string
                errorMessage = string.Empty;

                if (!string.IsNullOrEmpty(itemName))
                {
                    // Only allow letters and spaces
                    bool itemNameHasNoSpecial = !Regex.IsMatch(itemName, @"[^a-zA-Z\s]"); 
                    if (!itemNameHasNoSpecial)
                    {
                        errorMessage = "Item Name cannot include special characters or numbers.";
                        return false;
                    }
                }

                // If name validation passes, return true
                return true;
            }

        }

        //input sql and recieve dataSet, if data set is empty an empty dataSet will be returned
        public static DataSet GetFilteredResult(string sql)
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
