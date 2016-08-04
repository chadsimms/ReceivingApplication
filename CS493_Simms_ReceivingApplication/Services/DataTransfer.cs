//*********************************************************************
// Filename: 	    DataTransfer.cs
//
// Description:     This is the DataTransfer Class which defines methods
//                  for accessing, retrieving, deleting, or editing data
//                  on a database defined in the DataAccess class.
//
// Author/Designer:	Chad Simms
//**********************************************************************

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS493_Simms_ReceivingApplication.Services
{
    class DataTransfer
    {

        //----------------------------------------------------------------------------
        // Function:    ADDOrderToDB
        // Description: Used to add an order and corresponding items to the 
        //              Transaction.Items database
        // Input:       List<ItemTrans> - a list of items to be stored
        // Return Val:  bool - if the order was successfully inserted, returns true
        //----------------------------------------------------------------------------
        public static bool AddOrderToDB(List<ItemTrans> list, int transNum)
        {
            bool state = false;
            int test = 0;
            int i = 1;              //for testing!

            //new query to add data
            string query = "INSERT INTO Items (transactionNumber, UPC12, quantity, cost, productName, size, perCase) " + 
                "VALUES (@transNumber, @UPC, @amt, @cost, @product, @size, @perCase)";

            SqlConnection connection = new SqlConnection(Services.DataAccess.GetConnectionString("TRANSACTIONS"));
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                //identify the type of each parameterized arg
                cmd.Parameters.Add("@transNumber", SqlDbType.Int);
                cmd.Parameters.Add("@UPC", SqlDbType.NVarChar);
                cmd.Parameters.Add("@amt", SqlDbType.Int);
                cmd.Parameters.Add("@cost", SqlDbType.Float);
                cmd.Parameters.Add("@product", SqlDbType.VarChar);
                cmd.Parameters.Add("@size", SqlDbType.VarChar);
                cmd.Parameters.Add("@perCase", SqlDbType.Int);

                connection.Open();

                foreach (ItemTrans obj in list)
                {
                    //set value of each parameter for each item on list
                    cmd.Parameters["@transNumber"].Value = transNum;
                    cmd.Parameters["@UPC"].Value = obj.UPC;
                    cmd.Parameters["@amt"].Value = obj.amount;
                    cmd.Parameters["@cost"].Value = obj.cost;
                    cmd.Parameters["@product"].Value = obj.product;
                    cmd.Parameters["@size"].Value = obj.size;
                    cmd.Parameters["@perCase"].Value = obj.perCase;

                    //execute the insertion
                    test = cmd.ExecuteNonQuery();
                }

                connection.Close();

                //if query updated any rows
                if (test != 0)
                {
                    state = true;
                }
            }

            return state;
        }

        //----------------------------------------------------------------------------
        // Function:    GetLastTransactionNumber
        // Description: Used to return the last transaction number inserted into the 
        //              Transactions.Transactions DB 
        // Return Val:  int - returns the transaction number of the last inserted row
        //----------------------------------------------------------------------------
        public static int GetLastTransactionNumber()
        {
            int rtnVal = 1;
            string getQuery = "SELECT TOP 1 * FROM Transactions ORDER BY transactionNumber DESC";

            //connect and get transaction number
            SqlConnection connection = new SqlConnection(Services.DataAccess.GetConnectionString("TRANSACTIONS"));
            using (SqlCommand cmd = new SqlCommand(getQuery, connection))
            {
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            rtnVal = reader.GetInt32(reader.GetOrdinal("transactionNumber"));
                        }
                    }
                }
            }

            return rtnVal;
        }

        //----------------------------------------------------------------------------
        // Function:    InsertIntoTransTable
        // Description: Used insert the Transaction information into the 
        //              Transactions.Transactions DB
        // Input:       invoice - int to correspond to the invoice number provided
        //              vendor - string to correspond to the vendor name of this transaction
        //              isComplete - bool to deteremine if suspended or completed order
        //              itemCost - the total cost calculated by item cost * quantity of items
        //              vendorCost - the vendor total given at the end of the transaction
        // Return Val:  bool - returns true if rows were updated in the database
        //----------------------------------------------------------------------------
        public static bool InsertIntoTransTable(int invoice, string vendor, bool isComplete, float itemCost, float vendorCost)
        {
            bool state = false;
            DateTime date = DateTime.Now;

            string insertQuery = "INSERT INTO Transactions " +
                "(invoiceNumber, vendorName, isComplete, datetime, totalCost, vendorCost) " + 
                "VALUES (@InvoiceNumber, @VendorName, @IsComplete, @DateTime, @ItemCost, @VendorCost)";

            //connect and add transaction to table
            SqlConnection connection = new SqlConnection(Services.DataAccess.GetConnectionString("TRANSACTIONS"));
            using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
            {
                connection.Open();

                //add the values for parameters being passed in
                cmd.Parameters.AddWithValue("@InvoiceNumber", invoice);
                cmd.Parameters.AddWithValue("@VendorName", vendor);
                cmd.Parameters.AddWithValue("@IsComplete", isComplete);
                cmd.Parameters.AddWithValue("@DateTime", date);
                cmd.Parameters.AddWithValue("@ItemCost", itemCost);
                cmd.Parameters.AddWithValue("@VendorCost", vendorCost);

                //execute insertion command/query and set test to value of rows updated
                int test = cmd.ExecuteNonQuery();

                //if query updated any rows
                if (test != 0)
                {
                    state = true;
                }

                connection.Close();
            }
            return state;
        }

        //----------------------------------------------------------------------------
        // Function:    RetrieveDBTransactionInfo
        // Description: Used to return the transaction info for a suspended transaction
        // Input:       transNum - the transaction number of the order being retrieved
        // Return Val:  List<string> - a list of information being returned in the 
        //              following order:
        //                      Index 0 = transactionNumber
        //                      Index 1 = vendorName
        //                      Index 2 = isComplete
        //                      Index 3 = dateTime
        //                      Index 4 = invoiceNumber
        //                      Index 5 = totalCost
        //                      Index 6 = vendorCost
        //----------------------------------------------------------------------------
        public static List<string> RetrieveDBTransactionInfo(int transNum)
        {
            List<string> retrieved = new List<string>();

            string query = "SELECT * FROM Transactions WHERE transactionNumber= @TransNum";

            //connect and get transaction number
            SqlConnection connection = new SqlConnection(Services.DataAccess.GetConnectionString("TRANSACTIONS"));
            using (SqlCommand cmd = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@TransNum", transNum);

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                //fill in the labels for each UPC with product info
                if (dataSet == null || dataSet.Tables == null || dataSet.Tables.Count == 0 || dataSet.Tables[0].Rows == null ||
                    dataSet.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("There are no Incomplete Orders at this time", "ERROR!");
                }
                else
                {
                    retrieved.Add(dataSet.Tables[0].Rows[0]["transactionNumber"].ToString());
                    retrieved.Add(dataSet.Tables[0].Rows[0]["vendorName"].ToString());
                    retrieved.Add(dataSet.Tables[0].Rows[0]["isComplete"].ToString());
                    retrieved.Add(dataSet.Tables[0].Rows[0]["dateTime"].ToString());
                    retrieved.Add(dataSet.Tables[0].Rows[0]["invoiceNumber"].ToString());
                    retrieved.Add(dataSet.Tables[0].Rows[0]["totalCost"].ToString());
                    retrieved.Add(dataSet.Tables[0].Rows[0]["vendorCost"].ToString());
                }
            }

            return retrieved;
        }

        //----------------------------------------------------------------------------
        // Function:    RetrieveItemsDB
        // Description: Used to return the items associated with the transaction number
        // Input:       transNum - the transaction number of the order being retrieved
        // Return Val:  List<ItemTrans> - a list of items associated with the
        //                  transaction number provided
        //----------------------------------------------------------------------------
        public static List<ItemTrans> RetrieveItemsDB(int transNum)
        {
            List<ItemTrans> dbList = new List<ItemTrans>();

            string query = "SELECT * FROM Items WHERE transactionNumber= @TransNum";

            //connect and get transaction number
            SqlConnection connection = new SqlConnection(Services.DataAccess.GetConnectionString("TRANSACTIONS"));
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@TransNum", transNum);

                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dbList.Add(new ItemTrans()
                            {
                                UPC = reader["UPC12"].ToString(),
                                amount = int.Parse(reader["quantity"].ToString()),
                                product = reader["productName"].ToString(),
                                size = reader["size"].ToString(),
                                cost = float.Parse(reader["cost"].ToString()),
                                perCase = int.Parse(reader["perCase"].ToString())
                            });
                        }
                    }
                }
            }

            return dbList;
        }

        //----------------------------------------------------------------------------
        // Function:    DeleteItemsWithTransNum
        // Description: Used to update the Transactions.Transactions table at transactionNumber
        // Input:       transNum - transactionNumber to delete all items associated with
        // Return Val:  bool - returns true if rows were deleted in the database
        //----------------------------------------------------------------------------
        public static bool DeleteItemsWithTransNum(int transNum)
        {

            bool state = false;

            string updateQuery = "Delete FROM Items WHERE transactionNumber= @transNum";

            //connect and add transaction to table
            SqlConnection connection = new SqlConnection(Services.DataAccess.GetConnectionString("TRANSACTIONS"));
            using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
            {
                connection.Open();

                //add the values for parameters being passed in
                cmd.Parameters.AddWithValue("@TransNum", transNum);

                //execute insertion command/query and set test to value of rows updated
                int test = cmd.ExecuteNonQuery();

                //--------------------------------------------------------------------------------------------TESTING!
                Console.WriteLine("NUMBER OF DELETED ROWS: " + test);

                //if query updated any rows
                if (test != 0)
                {
                    state = true;
                }

                connection.Close();
            }

            return state;
        }

        //----------------------------------------------------------------------------
        // Function:    DeleteTransaction
        // Description: Used to delete the transaction from the transaction list
        // Input:       transNum - transactionNumber to delete all transactions associated with
        // Return Val:  bool - returns true if rows were deleted in the database
        //----------------------------------------------------------------------------
        public static bool DeleteTransaction(int transNum)
        {
            bool state = false;

            string updateQuery = "Delete FROM Transactions WHERE transactionNumber= @transNum";

            //connect and add transaction to table
            SqlConnection connection = new SqlConnection(Services.DataAccess.GetConnectionString("TRANSACTIONS"));
            using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
            {
                connection.Open();

                //add the values for parameters being passed in
                cmd.Parameters.AddWithValue("@TransNum", transNum);

                //execute insertion command/query and set test to value of rows updated
                int test = cmd.ExecuteNonQuery();

                //--------------------------------------------------------------------------------------------TESTING!
                Console.WriteLine("NUMBER OF DELETED ROWS: " + test);

                //if query updated any rows
                if (test != 0)
                {
                    state = true;
                }

                connection.Close();
            }

            return state;
        }

        //----------------------------------------------------------------------------
        // Function:    AddQuantitiesOnHand
        // Description: Used to update the on hand quantities for products based on if
        //              they are returned(-) or delivered(+)
        // Input:       transactions - a list of ItemTrans objects 
        // Return Val:  bool - returns true if rows were updated in the database
        //----------------------------------------------------------------------------
        public static bool AddQuantitiesOnHand(List<ItemTrans> transactions)
        {
            bool state = false;
            int test = 0;
            int updatequantity;

            //update the on hand quantities with the accepted items amounts
            string updateQuery = "UPDATE Products SET OnHand= OnHand+ @AddAmount WHERE UPC12= @UPC2";

            SqlConnection connection = new SqlConnection(Services.DataAccess.GetConnectionString("ITEMS"));
            using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
            {
                cmd.Parameters.Add("@UPC2", SqlDbType.NVarChar);
                cmd.Parameters.Add("@AddAmount", SqlDbType.Int);

                connection.Open();

                foreach (ItemTrans obj in transactions)
                {
                    updatequantity = (obj.amount * obj.perCase);

                    //add the values for parameters being passed in
                    cmd.Parameters["@UPC2"].Value = obj.UPC;
                    cmd.Parameters["@AddAmount"].Value = updatequantity;

                    test = cmd.ExecuteNonQuery();

                    updatequantity = 0;
                }

                //if no rows were updated, display error message
                if (test != 0)
                {
                    state = true;
                }

                connection.Close();
            }

            return state;
        }

        //----------------------------------------------------------------------------
        // Function:    SubtractQuantitiesOnHand
        // Description: Used to update the on hand quantities for products based on if
        //              they are returned(-) or delivered(+)
        // Input:       transactions - a list of ItemTrans objects 
        // Return Val:  bool - returns true if rows were updated in the database
        //----------------------------------------------------------------------------
        public static bool SubtractQuantitiesOnHand(List<ItemTrans> transactions)
        {
            bool state = false;
            int test = 0;
            int updatequantity;

            //update the on hand quantities with the accepted items amounts
            string updateQuery = "UPDATE Products SET OnHand= OnHand- @AddAmount WHERE UPC12= @UPC2";

            SqlConnection connection = new SqlConnection(Services.DataAccess.GetConnectionString("ITEMS"));
            using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
            {
                cmd.Parameters.Add("@UPC2", SqlDbType.NVarChar);
                cmd.Parameters.Add("@AddAmount", SqlDbType.Int);

                connection.Open();

                foreach (ItemTrans obj in transactions)
                {
                    updatequantity = (obj.amount * obj.perCase);

                    //add the values for parameters being passed in
                    cmd.Parameters["@UPC2"].Value = obj.UPC;
                    cmd.Parameters["@AddAmount"].Value = updatequantity;

                    test = cmd.ExecuteNonQuery();

                    updatequantity = 0;
                }

                //if no rows were updated, display error message
                if (test != 0)
                {
                    state = true;
                }

                connection.Close();
            }

            return state;
        }

        //----------------------------------------------------------------------------
        // Function:    GetVendorNameFromNum
        // Description: Used to get the vendor name from the vendor number
        // Input:       vendorNum - the corresponding vendor number to look for
        // Return Val:  string - the vendorName corresponding to the vendorNum
        //----------------------------------------------------------------------------
        public static string GetVendorNameFromNum(int vendorNum)
        {
            string vendorName = "";
            string query = "SELECT Name FROM Vendor WHERE Id= @VendorID";

            SqlConnection conn = new SqlConnection(Services.DataAccess.GetConnectionString("ITEMS"));
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@VendorID", vendorNum);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            vendorName = reader["Name"].ToString();
                        }
                    }
                }
            }

            return vendorName;
        }

        //----------------------------------------------------------------------------
        // Function:    GetVendorNumFromName
        // Description: Used to get the vendor ID number from the vendor name
        // Input:       vendorName - the corresponding vendor name to look for
        // Return Val:  int - the vendor ID corresponding to the vendorName
        //----------------------------------------------------------------------------
        public static int GetVendorNumFromName(string vendorName)
        {
            int vendorNum = 0;
            string query = "SELECT Id FROM Vendor WHERE Name= @Vendor";

            SqlConnection conn = new SqlConnection(Services.DataAccess.GetConnectionString("ITEMS"));
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Vendor", vendorName);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            vendorNum = reader.GetInt32(reader.GetOrdinal("Id"));
                        }
                    }
                }
            }

            return vendorNum;
        }
    }
}
