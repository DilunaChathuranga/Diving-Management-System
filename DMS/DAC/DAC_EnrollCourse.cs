using DMS.REFClass;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DMS.DAC
{
    public class DAC_EnrollCourse
    {
        public void Insert(REF_EnrollCourse oREF_EnrollCourse)
        {
            DBConnecton db;
            db = new DBConnecton();
            string sqlQuery;
            SqlCommand oSqlCommand;
            try

            {

                sqlQuery = "INSERT INTO `tblenrollcourse` (`ID`, `CusID`, `CourseID`, `Status`, `OfferID`, `offer_prices`, `Course_price`, `Total`)"+
                    "VALUES (NULL, '"+ oREF_EnrollCourse.CusID + "', '"+ oREF_EnrollCourse.CourseID + "', '0', '"+ oREF_EnrollCourse.OfferID + "', '"+ oREF_EnrollCourse.offer_prices + "', '"+ oREF_EnrollCourse.Course_price + "', '"+ oREF_EnrollCourse.Total + "');";

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

        public DataTable SelectBookCourse()
        {
            DBConnecton db;
            db = new DBConnecton();
            DataTable dataTable = new DataTable();
            string query = "SELECT B.ID, C.name, S.course_name,B.`Course_price`, O.offer_name ,B.`offer_prices`,`Total` FROM `tblenrollcourse` B , users C, maincourse S,mainoffer O WHERE B.CusID = C.user_id AND B.CourseID = S.idmaincourse AND B.OfferID = O.idmainoffer";



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