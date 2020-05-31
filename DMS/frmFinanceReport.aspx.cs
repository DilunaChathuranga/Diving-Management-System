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
    public partial class frmFinanceReport : System.Web.UI.Page
    {
    
        protected string Service { get; set; }
        protected string Course { get; set; }
        protected string Total { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            Double serviceValue = 0.0;
            Double CourseValue = 0.0;
            Double TotalValue = 0.0;

            DataTable dt;
                DAC_Finance oDAV_Offers = new DAC_Finance();
                dt = oDAV_Offers.SelectCourseFinance();
                rptdata.DataSource = dt;
                rptdata.DataBind();
                serviceValue = Double.Parse(dt.Rows[0][1].ToString());
               
                dt = oDAV_Offers.SelectCourseFinance2();
                rptdata2.DataSource = dt;
                rptdata2.DataBind();
                CourseValue= Double.Parse(dt.Rows[0][1].ToString());
            TotalValue = serviceValue + CourseValue;
            Total = TotalValue.ToString();
            Service = serviceValue.ToString();
            Course = CourseValue.ToString();
        }
    }
}