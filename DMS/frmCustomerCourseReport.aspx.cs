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
    public partial class frmReport : System.Web.UI.Page
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
                DAC_EnrollCourse oDAC_EnrollCourse = new DAC_EnrollCourse();
                dt = oDAC_EnrollCourse.SelectBookCourse();
                String StrInnserHtml = "";

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        StrInnserHtml = StrInnserHtml + "<tr><td>" + dt.Rows[i][1].ToString() + "</td><td>" + dt.Rows[i][2].ToString() + "</td><td> Rs." + dt.Rows[i][3].ToString() + "</td><td>" + dt.Rows[i][4].ToString() + "</td><td> Rs." + dt.Rows[i][5].ToString() + "</td><td> Rs." + dt.Rows[i][6].ToString() + "</td></tr>";
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