using DMS.DAC;
using DMS.REFClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DMS
{
    public partial class frmRentInvoice : System.Web.UI.Page
    {
        protected string Date { get; set; }
        protected string Name { get; set; }
        protected string RentINumber { get; set; }
        protected string DepostiAmount { get; set; }
        protected string RateAmount { get; set; }
        protected string Total { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ID"] != null)
            {
                DateTime dateTime = DateTime.Today;
                Date = "Date :" + dateTime.ToString("d");
                REF_Rent oREF_Rent = new REF_Rent();
                oREF_Rent.ID = Request.QueryString["ID"];
                LoadData(oREF_Rent);
            }
        }
        public void LoadData(REF_Rent oREF_Rent)
        {
           
                DataTable dt;

                DAC_Rent oDAC_Rent = new DAC_Rent();
                dt = oDAC_Rent.SelectRentDetailsByID(oREF_Rent);
                String StrInnserHtml = "";

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {


                        StrInnserHtml = StrInnserHtml + "<tr><td>" + dt.Rows[i][15].ToString() + "</td><td>" + dt.Rows[i][4].ToString() + "</td></tr>";
                    }

                }
            divInnerHtml.InnerHtml = StrInnserHtml;
            Name = dt.Rows[0][12].ToString();
            RentINumber = dt.Rows[0][0].ToString();
            DepostiAmount = dt.Rows[0][4].ToString();
            RateAmount= dt.Rows[0][5].ToString();
            Total= dt.Rows[0][6].ToString();




        }
    }
}