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
    public class DAC_User
    {
        public DataTable SelectByUserNameAndPasswordHash(REF_User oREF_User)
        {
            
            DBConnecton db;
            db = new DBConnecton();
            DataTable dataTable = new DataTable();
            string sqlQuery = "SELECT * FROM `tbluser` WHERE `UserName` LIKE '" + oREF_User.USER_NAME + "' AND `password` LIKE '" + oREF_User.PASSWORD + "'";
            //Open connection
            if (db.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(sqlQuery, db.getConnetion());
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