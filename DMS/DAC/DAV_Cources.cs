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
    public class DAV_Cources
    {
        public void Insert(REF_Course oREF_Course)
        {
            DBConnecton db;
            db = new DBConnecton();
            string sqlQuery;
            SqlCommand oSqlCommand;
            try

            {

                sqlQuery = "INSERT INTO `maincourse` (`idmaincourse`, `course_id`, `course_name`, `course_duration`, `course_price`, `description`) VALUES" +
                    " (NULL, '" + oREF_Course.COURSECODE + "', '" + oREF_Course.COURSENAME + "', '" + oREF_Course.COURSEDURATION + "', '" + oREF_Course.COURSEPRICE + "', '" + oREF_Course.DESCRIPTION + "');";

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

        public DataTable SelectCourse()
        {
            DBConnecton db;
            db = new DBConnecton();
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM maincourse";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

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

        public DataTable SelectCourseByID(REF_Course oREF_Course)
        {
            DBConnecton db;
            db = new DBConnecton();
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM `maincourse` WHERE `idmaincourse`='" + oREF_Course.ID + "'";
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


        public void Update(REF_Course oREF_Course)
        {
            DBConnecton db;
            db = new DBConnecton();
            string sqlQuery;
            SqlCommand oSqlCommand;
            try

            {

                sqlQuery = "UPDATE `maincourse` SET `course_id` = '"+ oREF_Course .COURSECODE+ "', `course_name` = '"+ oREF_Course .COURSENAME+ "',"+
                    " `course_duration` = '"+ oREF_Course .COURSEDURATION+ "', `course_price` = '"+ oREF_Course .COURSEPRICE+ "', `description` = '"+ oREF_Course .DESCRIPTION+ "' WHERE `maincourse`.`idmaincourse` = "+ oREF_Course .ID+ ";";

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

        public void Delete(REF_Course oREF_Course)
        {
            DBConnecton db;
            db = new DBConnecton();
            string sqlQuery;
            SqlCommand oSqlCommand;
            try

            {

                sqlQuery = "DELETE FROM `maincourse` WHERE `maincourse`.`idmaincourse` = "+ oREF_Course .ID+ "";

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