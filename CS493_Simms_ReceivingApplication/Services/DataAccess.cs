
//*********************************************************************
// Filename: 	    DataAccess.cs
//
// Description:     This is the DataAccess Class used to return a
//                  Connection String and Handle Connections as needed.
//
// Author/Designer:	Chad Simms
//**********************************************************************


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CS493_Simms_ReceivingApplication.Services
{
    class DataAccess
    {

        //----------------------------------------------------------------------------
        // Function:    GetConnectionString
        // Description: Used to return a connection string based on the name passed in
        //              (For multiple connection strings)
        // Input:       string strConnection:
        //                      Used to identify which connection string is needed
        // Return Val:  str strReturn:
        //                      The connection string value of the specified connection
        //                      name
        //----------------------------------------------------------------------------
        public static string GetConnectionString(string strConnection)
        {
            string strReturn = "";  //variable to hold connection string for returning it

            //if accessing the login DB return this connection string
            if (strConnection == "LOGIN")
            {
                strReturn = ConfigurationManager.ConnectionStrings
                    ["CS493_Simms_ReceivingApplication.Properties.Settings.DataConnectionString"].ConnectionString;
            }
            else if (strConnection == "TRANSACTIONS")
            {
                strReturn = ConfigurationManager.ConnectionStrings
                    ["CS493_Simms_ReceivingApplication.Properties.Settings.TransactionsConnectionString"].ConnectionString;
            }
            //else return the DEFAULT connection string:
            else
            {
                strReturn = ConfigurationManager.ConnectionStrings
                    ["CS493_Simms_ReceivingApplication.Properties.Settings.VendorProductsConnectionString"].ConnectionString;
            }

            //return the connection string
            return strReturn;
        }
    }
}
