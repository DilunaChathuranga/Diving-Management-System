using DMS.DAC;
using DMS.REFClas;
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
    public partial class frmEnrollCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack) { 
            LoadCourse();
            LoadCustomer();
            LoadOffers();
            }
        }

        private void LoadOffers()
        {
            DataTable dt;
            DAV_Offers oDAV_Offers = new DAV_Offers();
            dt = oDAV_Offers.SelectOffers();

            if (dt.Rows.Count > 0)
            {
                dropoffers.DataSource = null;
                dropoffers.DataSource = dt;
                dropoffers.DataTextField = "offer_name";
                dropoffers.DataValueField = "idmainoffer";
                dropoffers.DataBind();
            }
        }
        private void LoadCustomer()
        {
            DataTable dt;
            DAC_Customer oDAC_Customer = new DAC_Customer();
            dt = oDAC_Customer.SelectCustomer();

            if (dt.Rows.Count > 0)
            {
                dropCusotmer.DataSource = null;
                dropCusotmer.DataSource = dt;
                dropCusotmer.DataTextField = "username";
                dropCusotmer.DataValueField = "user_id";
                dropCusotmer.DataBind();
            }
        }
        
       private void LoadCourse()
        {
            DataTable dt;
            DAV_Cources oDAV_Cources = new DAV_Cources();
            dt = oDAV_Cources.SelectCourse();

            if (dt.Rows.Count > 0)
            {
                dropCourse.DataSource = null;
                dropCourse.DataSource = dt;
                dropCourse.DataTextField = "course_name";
                dropCourse.DataValueField = "idmaincourse";
                dropCourse.DataBind();
            }
            LoadData();
        }

        protected void btnsubmitoffers_Click(object sender, EventArgs e)
        {
            DAC_EnrollCourse oDAC_EnrollCourse = new DAC_EnrollCourse();
            REF_EnrollCourse oREF_EnrollCourse = new REF_EnrollCourse();
            oREF_EnrollCourse.CusID =dropCusotmer.Value;
            oREF_EnrollCourse.CourseID = dropCourse.Value;
            oREF_EnrollCourse.OfferID = dropoffers.Value;
            DataTable dt;
            DAV_Offers oDAV_Offers = new DAV_Offers();
            REF_Offers oREF_Offers = new REF_Offers();
            oREF_Offers.ID = Convert.ToInt32(dropoffers.Value);
            dt = oDAV_Offers.SelectOffersByID(oREF_Offers);
            Double OfferPrice = Double.Parse(dt.Rows[0][6].ToString());
            oREF_EnrollCourse.offer_prices = dt.Rows[0][6].ToString();

            DAV_Cources oDAV_Cources = new DAV_Cources();
            REF_Course oREF_Course = new REF_Course();
            oREF_Course.ID = Convert.ToInt32(dropCourse.Value);
            dt = oDAV_Cources.SelectCourseByID(oREF_Course);
            Double CoursePrice = Double.Parse(dt.Rows[0][4].ToString());

            Double Total = CoursePrice - OfferPrice;
            oREF_EnrollCourse.Course_price = dt.Rows[0][3].ToString();

            oREF_EnrollCourse.Total = Total.ToString();
            oDAC_EnrollCourse.Insert(oREF_EnrollCourse);
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable dt;
            DAV_Offers oDAV_Offers = new DAV_Offers();
            REF_Offers oREF_Offers = new REF_Offers();
            oREF_Offers.ID = Convert.ToInt32(dropoffers.Value);
            dt = oDAV_Offers.SelectOffersByID(oREF_Offers);
            Double OfferPrice = Double.Parse(dt.Rows[0][6].ToString());
          

            DAV_Cources oDAV_Cources = new DAV_Cources();
            REF_Course oREF_Course = new REF_Course();
            oREF_Course.ID = Convert.ToInt32(dropCourse.Value);
            dt = oDAV_Cources.SelectCourseByID(oREF_Course);
            Double CoursePrice = Double.Parse(dt.Rows[0][4].ToString());

            Double Total = CoursePrice - OfferPrice;
            lbltotal.InnerText = "Total Cost Rs." + Total.ToString();
        }
    }
}