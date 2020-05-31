using DMS.REFClas;
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
    public class DAC_BookServices
    {
        public void Insert(REF_BookServices oREF_BookServices)
        {
            DBConnecton db;
            db = new DBConnecton();
            string sqlQuery;
            SqlCommand oSqlCommand;
            try

            {

                sqlQuery = "INSERT INTO `tblbookservice` (`ID`, `CusID`, `ServiceID`, `Status`, `OfferID`, `ServicePrice`, `OfferPrice`, `TotalPrice`)"+
                "VALUES (NULL, '"+oREF_BookServices.CusID+"', '"+oREF_BookServices.ServiceID+"', '0', '"+oREF_BookServices.OfferID+"', '"+oREF_BookServices.ServicePrice+"', '"+oREF_BookServices.OfferPrice+"', '"+oREF_BookServices.TotalPrice+"');";

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

        public DataTable SelectBookServices()
        {
            DBConnecton db;
            db = new DBConnecton();
            DataTable dataTable = new DataTable();
            string query = "SELECT B.ID, C.name, S.service_name,`ServicePrice`, O.offer_name ,`OfferPrice`,`TotalPrice` FROM `tblbookservice` B , users C, mainservice S,mainoffer O WHERE B.CusID = C.user_id AND B.ServiceID = S.idmainservice AND B.OfferID = O.idmainoffer";

            

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