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
    public partial class frmStockreport : System.Web.UI.Page
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
            try
            {
                DataTable dt;
                DAC_Stock oDAC_Stock = new DAC_Stock();
                dt = oDAC_Stock.Select();
                String StrInnserHtml = "";

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        StrInnserHtml = StrInnserHtml + "<tr><td>" + dt.Rows[i][1].ToString() +
                                                        "</td><td>" + dt.Rows[i][2].ToString() +
                                                        "</td><td>" + dt.Rows[i][3].ToString() +
                                                        "</td><td>" + dt.Rows[i][4].ToString() +
                                                        "</td><td>" + dt.Rows[i][5].ToString() +
                                                        "</td><td>" + dt.Rows[i][6].ToString() +
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