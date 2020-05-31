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
    public class DAV_Offers
    {
        public void Insert(REF_Offers oREF_Offers)
        {
            DBConnecton db;
            db = new DBConnecton();
            string sqlQuery;
            SqlCommand oSqlCommand;
            try

            {
             
                sqlQuery = "INSERT INTO `mainoffer` (`idmainoffer`, `offer_type`, `offer_id`, `offer_name`, `offer_start_date`, `offer_end_date`, `offer_price_min`, `offer_price_max`, `offer_description`)"+
                    " VALUES (NULL, '"+ oREF_Offers .OFFER_TYPE+ "', '"+ oREF_Offers.Offer_ID+ "', '"+ oREF_Offers.OFFER_NAME + "', '"+ oREF_Offers.START_DATE+ "', '"+ oREF_Offers .END_DATE+ "', '"+ oREF_Offers .MIN_PRICE+ "', '"+ oREF_Offers.MAX_PRICE+ "', '"+ oREF_Offers.DESCCRIPTION+ "');";

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

        public DataTable SelectOffers()
        {
            DBConnecton db;
            db = new DBConnecton();
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM `mainoffer`";
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

        public DataTable SelectOffersByID(REF_Offers oREF_Offers)
        {
            DBConnecton db;
            db = new DBConnecton();
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM `mainoffer` WHERE `idmainoffer`='" + oREF_Offers .ID+ "'";
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

        public void Update(REF_Offers oREF_Offers)
        {
            DBConnecton db;
            db = new DBConnecton();
            string sqlQuery;
            SqlCommand oSqlCommand;
            try

            {

                sqlQuery = "UPDATE `mainoffer` SET `offer_type` = '"+ oREF_Offers .OFFER_TYPE+ "', `offer_id` = '"+ oREF_Offers .Offer_ID+ "', `offer_name` = '"+ oREF_Offers .OFFER_NAME+ "', `offer_start_date` = '"+ oREF_Offers .START_DATE+ "', "+
                    "`offer_end_date` = '"+ oREF_Offers .END_DATE+ "', `offer_price_min` = '"+ oREF_Offers .MIN_PRICE+ "', `offer_price_max` = '"+ oREF_Offers .MAX_PRICE+ "', `offer_description` = '"+ oREF_Offers .DESCCRIPTION+ "' WHERE `mainoffer`.`idmainoffer` = "+ oREF_Offers .ID+ "";

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

        public void Delete(REF_Offers oREF_Offers)
        {
            DBConnecton db;
            db = new DBConnecton();
            string sqlQuery;
            SqlCommand oSqlCommand;
            try

            {

                sqlQuery = "DELETE FROM `mainoffer` WHERE `mainoffer`.`idmainoffer` = "+ oREF_Offers .ID+ "";

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