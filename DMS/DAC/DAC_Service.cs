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
    public class DAC_Service
    {
        public void Insert(REF_Service oREF_Service)
        {
            DBConnecton db;
            db = new DBConnecton();
            string sqlQuery;
            SqlCommand oSqlCommand;
            try

            {

              
                sqlQuery = "INSERT INTO `mainservice` (`idmainservice`, `service_id`, `service_name`, `service_duration`, `price_per_hour`, `description`)" +
                    " VALUES(NULL, '"+ oREF_Service .ServiceiD+ "', '"+ oREF_Service .Service_Name+ "', '"+ oREF_Service .Service_Duration+ "', '"+ oREF_Service .Price_Per_Hour+ "', '"+ oREF_Service .Description+ "');";
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

        public DataTable SelectService()
        {
            DBConnecton db;
            db = new DBConnecton();
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM mainservice";

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

        public DataTable SelectServiceByID(REF_Service oREF_Service)
        {
            DBConnecton db;
            db = new DBConnecton();
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM `mainservice` WHERE `idmainservice` = '" + oREF_Service .ID+ "'";

           

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

        public void Update(REF_Service oREF_Service)
        {
            DBConnecton db;
            db = new DBConnecton();
            string sqlQuery;
            SqlCommand oSqlCommand;
            try

            {

                sqlQuery = "UPDATE `mainservice` SET `service_id` = '" + oREF_Service.ServiceiD + "', `service_name` = '" + oREF_Service.Service_Name + "', " +
                    "`service_duration` = '" + oREF_Service.Service_Duration + "', `price_per_hour` = '" + oREF_Service.Price_Per_Hour + "', `description` = '" + oREF_Service.Description + "' WHERE `mainservice`.`idmainservice` = " + oREF_Service.ID + "";

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

        public void Delete(REF_Service oREF_Service)
        {
            DBConnecton db;
            db = new DBConnecton();
            string sqlQuery;
            SqlCommand oSqlCommand;
            try

            {

                sqlQuery = "DELETE FROM `mainservice` WHERE `mainservice`.`idmainservice` = "+ oREF_Service .ID+ "";

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