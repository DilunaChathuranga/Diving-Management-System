using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DMS.REFClass
{
    public class DAC_Return
    {
        public void Insert(REF_Return oREF_Return)
        {
            DBConnecton db;
            db = new DBConnecton();
            string sqlQuery;
            SqlCommand oSqlCommand;
            try

            {

                sqlQuery = "INSERT INTO `tblreturn` (`ID`, `CusID`, `ItemID`, `Qty`, `Deposit`, `Addition`, `Refund`, `Status`)"
                    +"VALUES (NULL, '"+ oREF_Return .CusID+ "', '"+ oREF_Return .ItemID+ "', '"+ oREF_Return .Qty+ "', '"+ oREF_Return .Deposit+ "', '"+ oREF_Return .Addition+ "', '"+ oREF_Return .Refund+ "', '0');";

                //open connection
                if (db.OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(sqlQuery, db.getConnetion());

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    db.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}