using DMS.REFClas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DMS.DAC
{
    public class DAC_Customer
    {
        //public void Insert(REF_Customer oREF_Customer)
        //{
        //    DBConnecton db;
        //    db = new DBConnecton();
        //    string sqlQuery;
        //    SqlCommand oSqlCommand;
        //    try

        //    {

        //        sqlQuery = "INSERT INTO `tblOffers` (`ID`, `OFFER_TYPE`, `OFFER_NAME`, `START_DATE`, `END_DATE`, `[MIN_PRICE]`, `MAX_PRICE`, `DESCCRIPTION`, `STATUS`) VALUES (NULL, '" + oREF_Offers.OFFER_TYPE + "', '" + oREF_Offers.OFFER_NAME + "', '" + oREF_Offers.START_DATE + "','" + oREF_Offers.END_DATE + "', '" + oREF_Offers.MIN_PRICE + "', '" + oREF_Offers.MAX_PRICE + "', '" + oREF_Offers.DESCCRIPTION + "', '0');";

        //        //open connection
        //        if (db.OpenConnection() == true)
        //        {
        //            //create command and assign the query and connection from the constructor
        //            MySqlCommand cmd = new MySqlCommand(sqlQuery, db.getConnetion());

        //            //Execute command
        //            cmd.ExecuteNonQuery();

        //            //close connection
        //            db.CloseConnection();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public DataTable SelectCustomer()
        {
            DBConnecton db;
            db = new DBConnecton();
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM `users`";

            

            //Open connection
            if (db.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, db.getConnetion());
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                DataSet ds = new DataSet();

                ds.Tables.Add(dataTable);
                ds.EnforceConstraints = false;
                dataTable.Load(dataReader);
                dataReader.Close();

                //close Connection
                db.CloseConnection();

                //return list to be displayed
                return dataTable;
            }
            else
            {
                return dataTable;
            }
        }
    }
}