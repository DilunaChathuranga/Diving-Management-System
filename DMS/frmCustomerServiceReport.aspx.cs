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
    public partial class frmCustomerServiceReport : System.Web.UI.Page
    {
    
        protected string TotalOfferCharge { get; set; }
        protected string TotalServicecharge { get; set; }
        protected string Total { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            Double servie=0.0;
            Double Offer = 0.0;
            try
            {
                DataTable dt;
                DAC_BookServices oDAC_BookServices = new DAC_BookServices();
                dt = oDAC_BookServices.SelectBookServices();
                String StrInnserHtml = "";

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        StrInnserHtml = StrInnserHtml + "<tr><td>" + dt.Rows[i][1].ToString() + "</td><td>" + dt.Rows[i][2].ToString() + "</td><td> Rs." + dt.Rows[i][3].ToString() + "</td><td>" + dt.Rows[i][4].ToString() + "</td><td> Rs." + dt.Rows[i][5].ToString() + "</td><td> Rs." + dt.Rows[i][6].ToString() + "</td></tr>";
                        servie += Double.Parse(dt.Rows[i][3].ToString());
                        Offer += Double.Parse(dt.Rows[i][3].ToString());
                    }

                }
                divInnerHtml.InnerHtml = StrInnserHtml;

            }
            catch (Exception ex)
            {
                throw;
            }
            TotalServicecharge = "Rs." + servie.ToString();
                TotalOfferCharge="Rs." + Offer.ToString();
            Total = "Rs."+(servie+ Offer).ToString();
        }
    }
}