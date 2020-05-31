﻿using System;
using System.Data;
using DMS.DAC;

namespace DMS
{
    public partial class frmViewEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                DataTable dt;
                DAC_Employee oDAV_Employe = new DAC_Employee();
                dt = oDAV_Employe.SelectEmployee();
                String StrInnserHtml = "";

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        StrInnserHtml = StrInnserHtml + "<tr><td>" + dt.Rows[i][1].ToString() + 
                                                        "</td><td>" + dt.Rows[i][2].ToString() + 
                                                        "</td><td>" + dt.Rows[i][3].ToString() + 
                                                        "</td><td>" + dt.Rows[i][4].ToString() +
                                                        "</td><td>"+
                                                        "</td></tr>";
                    }

                }
                divInnerHtml.InnerHtml = StrInnserHtml;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}