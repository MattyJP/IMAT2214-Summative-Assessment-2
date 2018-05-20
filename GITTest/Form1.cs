using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GITTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonGetDates_Click(object sender, EventArgs e)
        {
            //Create a list to store the dates
            List<string> Dates = new List<string>();
            //Clear the listbox of existing contents
            listBoxDates.Items.Clear();

            //Create the database string for Set 1 and Set 2
            string connectionStringSet1 = Properties.Settings.Default.Data_set_1ConnectionString;
            string connectionStringSet2 = Properties.Settings.Default.Data_set_2ConnectionString;

            using (OleDbConnection connection = new OleDbConnection(connectionStringSet1))
            {
                connection.Open();
                OleDbDataReader reader = null;
                //Obtain the dates from Dataset1
                OleDbCommand getDates = new OleDbCommand("SELECT [Order Date], [Ship Date] from Sheet1", connection);

                reader = getDates.ExecuteReader();
                while (reader.Read())
                {
                    //Add the dates to the list
                    Dates.Add(reader[0].ToString());
                    Dates.Add(reader[1].ToString());
                }
                //Disables the button after use as the data is already taken
                buttonGetDates.Enabled = false;
            }

            using (OleDbConnection connection = new OleDbConnection(connectionStringSet2))
            {
                connection.Open();
                OleDbDataReader reader = null;
                //Obtain the dates from Dataset2 in entries where the row is properly formatted (row values match columns)
                OleDbCommand getDates = new OleDbCommand("SELECT [Order Date], [Ship Date] from [Student Sample 2 - Sheet1] WHERE [Field22] IS NULL", connection);

                reader = getDates.ExecuteReader();
                while (reader.Read())
                {
                    //Add the dates to the list
                    Dates.Add(reader[0].ToString());
                    Dates.Add(reader[1].ToString());
                }
            }

            //Create a new list for the formatted dates
            List<string> DatesFormatted = new List<string>();

            foreach (string date in Dates)
            {
                //Split the string on whitespace and remove anything thats blan.
                var dates = date.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                //Grab the first item (we know this is the date) and add it to our new list
                DatesFormatted.Add(dates[0]);
            }

            //Bind the listbox to the list.
            listBoxDates.DataSource = DatesFormatted;

            //Split the dates and insert every date in the list
            foreach (string date in DatesFormatted)
            {
                splitDates(date);
            }
        }

        private void buttonGetProducts_Click(object sender, EventArgs e)
        {
            //Create a list to store the products
            List<string> Products = new List<string>();
            //Clear the listbox of existing contents
            listBoxProducts.Items.Clear();

            //Create the database string for Set 1 and Set 2
            string connectionStringSet1 = Properties.Settings.Default.Data_set_1ConnectionString;
            string connectionStringSet2 = Properties.Settings.Default.Data_set_2ConnectionString;

            using (OleDbConnection connection = new OleDbConnection(connectionStringSet1))
            {
                connection.Open();
                OleDbDataReader reader = null;
                //Obtain the product category, subcategory and name from Dataset1
                OleDbCommand getProducts = new OleDbCommand("SELECT [Category], [Sub-Category], [Product Name] from Sheet1'", connection);
                reader = getProducts.ExecuteReader();
                while (reader.Read())
                {
                    //Add the results to the list, with category, subcategory and product name separated by an underscore
                    //This allows them to be separated and divided into their respective database columns through the split command later on
                    Products.Add(reader[0].ToString() + "_" + reader[1].ToString() + "_" + reader[2].ToString());
                }
            }

            using (OleDbConnection connection = new OleDbConnection(connectionStringSet2))
            {
                connection.Open();
                OleDbDataReader reader = null;
                //Obtain the product category, subcategory and name from Dataset2 in entries where the row is properly formatted (row values match columns)
                OleDbCommand getProducts = new OleDbCommand("SELECT [Category], [Sub-Category], [Product Name] from [Student Sample 2 - Sheet1] WHERE [Field22] IS NULL", connection);
                reader = getProducts.ExecuteReader();
                while (reader.Read())
                {
                    //Add the results to the list, with category, subcategory and product name separated by an underscore
                    //This allows them to be separated and divided into their respective database columns through the split command later on
                    Products.Add(reader[0].ToString() + "_" + reader[1].ToString() + "_" + reader[2].ToString());
                }
            }

            //Bind the listbox to the list
            listBoxProducts.DataSource = Products;
            //Split the products and insert every product in the list
            foreach (string product in Products)
            {
                splitProducts(product);
            }
            //Disables the button after use as the data is already taken
            buttonGetProducts.Enabled = false;
        }

        private void buttonGetCustomers_Click(object sender, EventArgs e)
        {
            //Create a list to store the customers
            List<string> Customers = new List<string>();
            //Clear the listbox of existing contents
            listBoxCustomers.Items.Clear();

            //Create the database string for Set 1 and Set 2
            string connectionStringSet1 = Properties.Settings.Default.Data_set_1ConnectionString;
            string connectionStringSet2 = Properties.Settings.Default.Data_set_2ConnectionString;

            using (OleDbConnection connection = new OleDbConnection(connectionStringSet1))
            {
                connection.Open();
                OleDbDataReader reader = null;
                //Obtain the customer name, country, city, state, postal code, region and segment from Sheet1
                OleDbCommand getCustomers = new OleDbCommand("SELECT [Customer Name], [Country], [City], [State], [Postal Code], [Region], [Segment] from Sheet1'", connection);

                reader = getCustomers.ExecuteReader();
                while (reader.Read())
                {
                    //Add the results to the list, with ceach segment separated by an underscore
                    //This allows them to be separated and divided into their respective database columns through the split command later on
                    Customers.Add(reader[0].ToString() + "_" + reader[1].ToString() + "_" + reader[2].ToString() + "_" +
                        reader[3].ToString() + "_" + reader[4].ToString() + "_" + reader[5].ToString() + "_" + reader[6].ToString());
                }
            }

            using (OleDbConnection connection = new OleDbConnection(connectionStringSet2))
            {
                connection.Open();
                OleDbDataReader reader = null;
                //Obtain the customer name, country, city, state, postal code, region and segment from Dataset2 in entries where the row is properly formatted (row values match columns)
                OleDbCommand getCustomers = new OleDbCommand("SELECT [Customer Name], [Country], [City], [State], [Postal Code], [Region], [Segment] from [Student Sample 2 - Sheet1] WHERE [Field22] IS NULL", connection);

                reader = getCustomers.ExecuteReader();
                while (reader.Read())
                {
                    //Add the results to the list, with ceach segment separated by an underscore
                    //This allows them to be separated and divided into their respective database columns through the split command later on
                    Customers.Add(reader[0].ToString() + "_" + reader[1].ToString() + "_" + reader[2].ToString() + "_" +
                        reader[3].ToString() + "_" + reader[4].ToString() + "_" + reader[5].ToString() + "_" + reader[6].ToString());
                }
            }

            //Bind the listbox to the list
            listBoxCustomers.DataSource = Customers;
            //Split the customers and insert every customer in the list
            foreach (string customer in Customers)
            {
                splitCustomers(customer);
            }
            //Disables the button after use as the data is already taken
            buttonGetCustomers.Enabled = false;
        }

        private void splitDates(string date)
        {
            //Split the date down and assign it to variables for later use
            string[] arrayDate = date.Split('/');
            int year = Convert.ToInt32(arrayDate[2]);
            int month = Convert.ToInt32(arrayDate[1]);
            int day = Convert.ToInt32(arrayDate[0]);

            DateTime dateTime = new DateTime(year, month, day);

            string dayOfWeek = dateTime.DayOfWeek.ToString();
            int dayOfYear = dateTime.DayOfYear;
            string monthName = dateTime.ToString("MMMM");
            int weekNumber = dayOfYear / 7;
            bool weekend = false;
            if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday") weekend = true;
            string dbDate = dateTime.ToString("M/dd/yyyy");
            //Add the entries to the database
            insertTimeDimension(dbDate, dayOfWeek, day, monthName, month, weekNumber, year, weekend, dayOfYear);
        }

        private void splitProducts(string product)
        {
            //Split the product list entry down and assign it to variables for later use
            string[] arrayProduct = product.Split('_');
            string category = arrayProduct[0];
            string subcategory = arrayProduct[1];
            string name = arrayProduct[2];

            //Add the entries to the database
            insertProductDimension(category, subcategory, name);
        }

        private void splitCustomers(string customer)
        {
            //Split the customer list entry down and assign it to variables for later use
            string[] arrayCustomer = customer.Split('_');
            string customerName = arrayCustomer[0];
            string country = arrayCustomer[1];
            string city = arrayCustomer[2];
            string state = arrayCustomer[3];
            string postalCode = arrayCustomer[4];
            string region = arrayCustomer[5];
            string reference = arrayCustomer[6];


            //Add the entries to the database
            insertCustomerDimension(customerName, country, city, state, postalCode, region, reference);
        }

        private void insertTimeDimension(string date, string dayName, int dayNumber, string monthName, int monthNumber, int weekNumber, int year, bool weekend, int dayOfYear)
        {
            //Create a connection to the MDF file
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {
                //Open the SqlConnection
                myConnection.Open();
                SqlCommand command = new SqlCommand("SELECT timeId FROM Time WHERE date = @date", myConnection);
                command.Parameters.Add(new SqlParameter("date", date));
                //Create a variable and assign it to false by default
                bool exists = false;
                //Run the command and read the results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //If there are rows, it means the date exists so change the exists variable
                    if (reader.HasRows) exists = true;
                }

                if (exists == false)
                {
                    //If the entry does not exist in the database, it is inserted
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO Time (dayName, dayNumber, monthName, monthNumber, weekNumber, year, weekend, date, dayOfyear) "
                        + " VALUES (@dayName, @dayNumber, @monthName, @monthNumber, @weekNumber, @year, @weekend, @date, @dayOfYear)", myConnection);
                    insertCommand.Parameters.Add(new SqlParameter("dayName", dayName));
                    insertCommand.Parameters.Add(new SqlParameter("dayNumber", dayNumber));
                    insertCommand.Parameters.Add(new SqlParameter("monthName", monthName));
                    insertCommand.Parameters.Add(new SqlParameter("monthNumber", monthNumber));
                    insertCommand.Parameters.Add(new SqlParameter("weekNumber", weekNumber));
                    insertCommand.Parameters.Add(new SqlParameter("year", year));
                    insertCommand.Parameters.Add(new SqlParameter("weekend", weekend));
                    insertCommand.Parameters.Add(new SqlParameter("date", date));
                    insertCommand.Parameters.Add(new SqlParameter("dayOfyear", dayOfYear));

                    try
                    {
                        //Insert the line
                        int recordsAffected = insertCommand.ExecuteNonQuery();
                        Console.WriteLine("Records affected: " + recordsAffected);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(dayName + " " + dayNumber + " " + monthName + " " + monthNumber + " " + weekNumber + " " + year + " " + weekend + " " + date + " " + dayOfYear);
                        throw;
                    }
                }
            }
        }

        private void insertProductDimension(string category, string subcategory, string productName)
        {
            //Create a connection to the MDF file
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {
                //Open the SqlConnection
                myConnection.Open();
                SqlCommand command = new SqlCommand("SELECT productId FROM Product WHERE productName = @productName", myConnection);
                command.Parameters.Add(new SqlParameter("productName", productName));
                //Create a variable and assign it to false by default
                bool exists = false;
                //Run the command and read the results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //If there are rows, it means the date exists so change the exists variable
                    if (reader.HasRows) exists = true;
                }

                if (exists == false)
                {
                    //If the entry does not exist in the database, it is inserted
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO Product (category, subcategory, productName) "
                        + " VALUES (@category, @subcategory, @productName)", myConnection);
                    insertCommand.Parameters.Add(new SqlParameter("category", category));
                    insertCommand.Parameters.Add(new SqlParameter("subcategory", subcategory));
                    insertCommand.Parameters.Add(new SqlParameter("productName", productName));

                    try
                    {
                        //Insert the line
                        int recordsAffected = insertCommand.ExecuteNonQuery();
                        Console.WriteLine("Records affected: " + recordsAffected);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(category + " " + subcategory + " " + productName);
                        throw;
                    }
                }
            }
        }

        private void insertCustomerDimension(string customerName, string country, string city, string state, string postalCode, string region, string reference)
        {
            //Create a connection to the MDF file
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {
                //Open the SqlConnection
                myConnection.Open();
                SqlCommand command = new SqlCommand("SELECT customerId FROM Customer WHERE customerName = @customerName", myConnection);
                command.Parameters.Add(new SqlParameter("customerName", customerName));
                //Create a variable and assign it to false by default
                bool exists = false;
                //Run the command and read the results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //If there are rows, it means the date exists so change the exists variable
                    if (reader.HasRows) exists = true;
                }

                if (exists == false)
                {
                    //If the entry does not exist in the database, it is inserted
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO Customer (customerName, country, city, state, postalCode, region, reference) "
                        + " VALUES (@customerName, @country, @city, @state, @postalCode, @region, @reference)", myConnection);
                    insertCommand.Parameters.Add(new SqlParameter("customerName", customerName));
                    insertCommand.Parameters.Add(new SqlParameter("country", country));
                    insertCommand.Parameters.Add(new SqlParameter("city", city));
                    insertCommand.Parameters.Add(new SqlParameter("state", state));
                    insertCommand.Parameters.Add(new SqlParameter("postalCode", postalCode));
                    insertCommand.Parameters.Add(new SqlParameter("region", region));
                    insertCommand.Parameters.Add(new SqlParameter("reference", reference));

                    try
                    {
                        //Insert the line
                        int recordsAffected = insertCommand.ExecuteNonQuery();
                        Console.WriteLine("Records affected: " + recordsAffected);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(customerName + " " + country + " " + city + " " + state + " " + postalCode + " " + region + " " + reference);
                        throw;
                    }
                }
            }
        }

        private void buttonGetFromDb_Click(object sender, EventArgs e)
        {
            //Create new lists to store the named results in
            List<string> DestinationDatesNamed = new List<string>();
            List<string> DestinationProductsNamed = new List<string>();
            List<string> DestinationCustomersNamed = new List<string>();
            List<string> DestinationFactTableNamed = new List<string>();

            //Create the database string
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionStringDestination))
            {
                //Create the separate SQL commands to pull the data from the tables.
                connection.Open();
                SqlCommand timeCommand = new SqlCommand("SELECT dayName, dayNumber, monthName, monthNumber, weekNumber, year, weekend," + "date, dayOfYear from Time", connection);
                SqlCommand productCommand = new SqlCommand("SELECT category, subcategory, productName from Product", connection);
                SqlCommand customerCommand = new SqlCommand("SELECT customerName, country, city, state, postalCode, region, reference from Customer", connection);
                SqlCommand factTableCommand = new SqlCommand("SELECT productId, timeId, customerId, value, discount, profit, quantity from FactTable", connection);

                using (SqlDataReader reader = timeCommand.ExecuteReader())
                {
                    //If there are rows, it means the date exists so change the exists variable
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DestinationDatesNamed.Add(reader["dayName"].ToString() + ", " + reader["dayNumber"].ToString() + ", " + reader["monthName"].ToString() + ", " + reader["monthNumber"].ToString() +
                                ", " + reader["weekNumber"].ToString() + ", " + reader["year"].ToString() + ", " + reader["weekend"].ToString() + ", " + reader["date"].ToString() + ", " + reader["dayofyear"].ToString());
                        }
                    }
                    else
                    {
                        DestinationDatesNamed.Add("No Data Present");
                    }
                }

                using (SqlDataReader reader = productCommand.ExecuteReader())
                {
                    //If there are rows, it means the date exists so change the exists variable
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DestinationProductsNamed.Add(reader["category"].ToString() + ", " + reader["subcategory"].ToString() + ", " + reader["productName"].ToString());
                        }
                    }
                    else
                    {
                        DestinationProductsNamed.Add("No Data Present");
                    }
                }

                using (SqlDataReader reader = customerCommand.ExecuteReader())
                {
                    //If there are rows, it means the date exists so change the exists variable
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DestinationCustomersNamed.Add(reader["customerName"].ToString() + ", " + reader["country"].ToString() + ", " + reader["city"].ToString() + ", " +
                                reader["state"].ToString() + ", " + reader["postalCode"].ToString() + ", " + reader["region"].ToString() + ", " + reader["reference"].ToString());
                        }
                    }
                    else
                    {
                        DestinationCustomersNamed.Add("No Data Present");
                    }
                }

                using (SqlDataReader reader = factTableCommand.ExecuteReader())
                {
                    //If there are rows, it means the date exists so change the exists variable
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DestinationFactTableNamed.Add("Product ID: " + reader["productId"].ToString() + ", Time ID: " + reader["timeId"].ToString() + ", Customer ID: " + reader["customerId"].ToString() + ", Value: " +
                                reader["value"].ToString() + ", Discount: " + reader["discount"].ToString() + ", Profit: " + reader["profit"].ToString() + ", Quantity: " + reader["quantity"].ToString());
                        }
                    }
                    else
                    {
                        DestinationFactTableNamed.Add("No Data Present");
                    }
                }
            }

            //Bind the listbox to the list
            listBoxDatesFromDbNamed.DataSource = DestinationDatesNamed;
            listBoxProductsFromDbNamed.DataSource = DestinationProductsNamed;
            listBoxCustomersFromDbNamed.DataSource = DestinationCustomersNamed;
            listBoxFactTableFromDbNamed.DataSource = DestinationFactTableNamed;
        }

        private void buttonGetFactTable_Click(object sender, EventArgs e)
        {
            //Create new list to store the results in.
            List<string> Orders = new List<string>();

            //Create the database string for Set 1 and Set 2
            string connectionStringSet1 = Properties.Settings.Default.Data_set_1ConnectionString;
            string connectionStringSet2 = Properties.Settings.Default.Data_set_2ConnectionString;

            using (OleDbConnection connection = new OleDbConnection(connectionStringSet1))
            {
                connection.Open();
                OleDbDataReader reader = null;
                //Obtains the relevant information for the fact table, using the dates, customer name and product name to find the primary keys in a layer function
                OleDbCommand getOrders = new OleDbCommand("SELECT [Order Date], [Customer Name], [Product Name], [Sales], [Discount], [Profit], [Quantity] from Sheet1", connection);

                reader = getOrders.ExecuteReader();
                while (reader.Read())
                {
                    //Data from different tables is separated with a #, while data from the same table is separated with an underscore
                    //This allows them to be split into smaller arrays later in the process
                    Orders.Add(reader[0].ToString() + "#" + reader[1].ToString() + "#" +
                        reader[2].ToString() + "#" + reader[3].ToString() + "_" + reader[4].ToString() + "_" + reader[5].ToString() + "_" + reader[6].ToString());
                }
            }

            using (OleDbConnection connection = new OleDbConnection(connectionStringSet2))
            {
                connection.Open();
                OleDbDataReader reader = null;
                //Obtains the relevant information for the fact table, using the dates, customer name and product name to find the primary keys in a layer function 
                //In entries where the row is properly formatted (row values match columns)
                OleDbCommand getOrders = new OleDbCommand("SELECT [Order Date], [Customer Name], [Product Name], [Sales], [Discount], [Profit], [Quantity] from [Student Sample 2 - Sheet1] WHERE [Field22] IS NULL", connection);

                reader = getOrders.ExecuteReader();
                while (reader.Read())
                {
                    //Data from different tables is separated with a #, while data from the same table is separated with an underscore
                    //This allows them to be split into smaller arrays later in the process
                    Orders.Add(reader[0].ToString() + "#" + reader[1].ToString() + "#" +
                        reader[2].ToString() + "#" + reader[3].ToString() + "_" + reader[4].ToString() + "_" + reader[5].ToString() + "_" + reader[6].ToString());
                }
            }
            //Split the orders and insert every order in the list
            foreach (string order in Orders)
            {
                populateFactTable(order);
            }
        }

        private void populateFactTable(string order)
        {
            //Create a list to store the order date
            List<string> Dates = new List<string>();

            //Split the received string into an array
            string[] arrayOrder = order.Split('#');
            //Split the array into smaller arrays where there is more than one data entry, and create strings to store customer and product name
            //string[] arrayDates = arrayOrder[0].Split('_');
            string customerName = arrayOrder[1];
            string productName = arrayOrder[2];
            string[] arraySales = arrayOrder[3].Split('_');

            //Prepare the numerical information to be added to the fact table entry
            decimal value = Convert.ToDecimal(arraySales[0]);
            decimal discount = Convert.ToDecimal(arraySales[1]);
            decimal profit = Convert.ToDecimal(arraySales[2]);
            Int32 quantity = Convert.ToInt32(arraySales[3]);


            //Add the date to the date list
            Dates.Add(arrayOrder[0].ToString());
            //Create a new list to format the dates
            List<string> DatesFormatted = new List<string>();
            foreach (string date in Dates)
            {
                //Split the string on whitespace and remove anything thats blank.
                var dates = date.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                //Grab the first item (we know this is the date) and add it to our new list.
                DatesFormatted.Add(dates[0]);
            }

            foreach (string date in DatesFormatted)
            {
                //Split the date down and assign it to variables for later use
                string[] arrayDate = date.Split('/');
                int year = Convert.ToInt32(arrayDate[2]);
                int month = Convert.ToInt32(arrayDate[1]);
                int day = Convert.ToInt32(arrayDate[0]);

                DateTime dateTime = new DateTime(year, month, day);

                string dbDate = dateTime.ToString("M/dd/yyyy");

                //Create a connection to the MDF file
                string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

                using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
                {

                    // Open the SqlConnection.
                    myConnection.Open();
                    // The following code uses an SqlCommand based on the SqlConnection
                    //It selects the primary keys from the three dimension tables
                    //This part is to check if the data exists within the table
                    SqlCommand command = new SqlCommand("SELECT timeId, productId, customerId FROM Time, Product, Customer WHERE date = @date AND productName = @productName AND customerName = @customerName", myConnection);
                    command.Parameters.Add(new SqlParameter("date", dbDate));
                    command.Parameters.Add(new SqlParameter("productName", productName));
                    command.Parameters.Add(new SqlParameter("customerName", customerName));

                    //Create Int32 values to store the primary keys
                    Int32 timeId = GetTimeId(dbDate);
                    Int32 productId = GetProductId(productName);
                    Int32 customerId = GetCustomerId(customerName);

                    //Run the command & read the results
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //If there are rows, it means the date exists so change the exists variable. 
                        if (reader.HasRows)
                        {
                            //Insert the entry into the fact table
                            Console.WriteLine("Data exists!");
                            SqlCommand insertCommand = new SqlCommand("INSERT INTO FactTable (productId, timeId, customerId, value, discount, profit, quantity) "
                        + " VALUES (@productId, @timeId, @customerId, @value, @discount, @profit, @quantity)", myConnection);
                            insertCommand.Parameters.Add(new SqlParameter("productId", productId));
                            insertCommand.Parameters.Add(new SqlParameter("timeId", timeId));
                            insertCommand.Parameters.Add(new SqlParameter("customerId", customerId));
                            insertCommand.Parameters.Add(new SqlParameter("value", value.ToString("0.00")));
                            insertCommand.Parameters.Add(new SqlParameter("discount", discount));
                            insertCommand.Parameters.Add(new SqlParameter("profit", profit.ToString("0.00")));
                            insertCommand.Parameters.Add(new SqlParameter("quantity", quantity));
                            reader.Close();
                            try
                            {
                                //Insert the line
                                int recordsAffected = insertCommand.ExecuteNonQuery();
                                Console.WriteLine("Records affected: " + recordsAffected);
                                //Disables the button after use as the fact table is already populated
                                buttonGetFactTable.Enabled = false;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine(productId + " " + timeId + " " + customerId + " " + value + " " + discount + " " + profit + " " + quantity);
                                throw;
                            }
                        }
                    }
                }
            }
        }

            private int GetTimeId(string dbDate)
        {
            //Create a variable to store the time ID
            int timeId = 0;
            //Create a connection to the MDF file
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {
                //Open the SqlConnection
                myConnection.Open();
                SqlCommand command = new SqlCommand("SELECT timeId FROM Time WHERE date = @date", myConnection);
                command.Parameters.Add(new SqlParameter("date", dbDate));
                //Run the command and read the results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //If there are rows, it means the date exists so change the exists variable
                    if (reader.HasRows)
                    {
                        reader.Read();
                        //Assign the time ID to the variable
                        timeId = reader.GetInt32(0);
                        Console.WriteLine("Data Exists!");
                    }
                }
            }
            return timeId;
        }

        private int GetProductId(string productName)
        {
            //Create a variable to store the product ID
            Int32 productId = 0;

            //Create a connection to the MDF file
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {
                //Open the SqlConnection
                myConnection.Open();
                SqlCommand command = new SqlCommand("SELECT productId FROM Product WHERE productName = @productName", myConnection);
                command.Parameters.Add(new SqlParameter("productName", productName));
                //Run the command and read the results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //If there are rows, it means the date exists so change the exists variable
                    if (reader.HasRows)
                    {
                        reader.Read();
                        //Assign the product ID to the variable
                        productId = reader.GetInt32(0);
                        Console.WriteLine("Data Exists!");
                    }
                }
            }
            return productId;
        }

        private int GetCustomerId(string customerName)
        {

            Int32 customerId = 0;

            //Create a connection to the MDF file
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {
                //Open the SqlConnection
                myConnection.Open();
                SqlCommand command = new SqlCommand("SELECT customerId FROM Customer WHERE customerName = @customerName", myConnection);
                command.Parameters.Add(new SqlParameter("customerName", customerName));
                //Run the command and read the results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //If there are rows, it means the date exists so change the exists variable
                    if (reader.HasRows)
                    {
                        reader.Read();
                        //Assign the customer ID to the variable
                        customerId = reader.GetInt32(0);
                        Console.WriteLine("Data Exists!");
                    }
                }
            }
            return customerId;
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            //This is a hardcoded week - the lowest grade.
            //Ideally this range would come from your database or elsewhere to allow the user to pick which
            //dates they want to see.
            List<string> dateList = new List<string>(new string[] {"06/01/2014", "05/08/1996", "02/04/1999"  });
            //I need somewhere to hold the information pulled from the database! This is an empty
            //dictionary.
            //I am using a dictionary as I can then manually set my own "key" so rather than it being
            //accessed through[0], [1] ect, i can access it via the date.
            //The dictionary type is string, int - date, number of sales.
            Dictionary<string, int> salesCount = new Dictionary<string, int>();


            //create a connection to the MDF file. we only need this once so its outsied of the loop
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            //run this code once for each date in my list - in my case 7 times
            foreach (string date in dateList)
            {
                using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
                {
                    //open the SqlConnection
                    myConnection.Open();
                    //the following code uses an SqlCommand based on the SQLConnection.
                    SqlCommand command = new SqlCommand("SELECT COUNT(*) AS SalesNumber FROM FactTable JOIN Time " + "ON FactTable.timeId WHERE Time.date = @date; ", myConnection);
                    command.Parameters.Add(new SqlParameter("date", date));

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //if there are rows, it means there were sales
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                //this line adds a dictionary item with the key if data, and the value being the sales number. 
                                //i could accedd this after by doing: int numberOfSales = salesCount["06/01/2014"];
                                salesCount.Add(date, Int32.Parse(reader["SalesNumber"].ToString()));
                            }
                        }
                        //if there are no rows it means there were 0 sales, so we need to handle this!
                        else
                        {
                            salesCount.Add(date, 0);
                        }
                    }
                }
            }
        }
    }
}
//End of foreach Loop. Should have a filled array

