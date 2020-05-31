using DMS.DAC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DMS
{
    public partial class frmViewOffers : System.Web.UI.Page
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
                DAV_Offers oDAV_Offers = new DAV_Offers();
                dt = oDAV_Offers.SelectOffers();
                String StrInnserHtml = "";

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        StrInnserHtml = StrInnserHtml + "<tr><td>" + dt.Rows[i][1].ToString() + "</td><td>" + dt.Rows[i][2].ToString() + "</td><td>" + dt.Rows[i][3].ToString() + "</td><td> " + dt.Rows[i][4].ToString() + " </td><td> " + dt.Rows[i][5].ToString() + " </td><td> " + dt.Rows[i][6].ToString() + " </td><td> " + dt.Rows[i][7].ToString() + " </td><td> " + dt.Rows[i][8].ToString() + " </td></tr>";
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