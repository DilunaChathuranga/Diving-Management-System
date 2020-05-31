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
    public partial class frmBookService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadService();
                LoadOffers();
                LoadCustomer();
            }
            LoadData();
        }

        private void LoadService()
        {
            DataTable dt;
            DAC_Service oDAC_Service = new DAC_Service();
            dt = oDAC_Service.SelectService();

            if (dt.Rows.Count > 0)
            {
                dropService.DataSource = null;
                dropService.DataSource = dt;
                dropService.DataTextField = "service_name";
                dropService.DataValueField = "idmainservice";
                dropService.DataBind();
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
                dropCusotmer.DataTextField = "name";
                dropCusotmer.DataValueField = "user_id";
                dropCusotmer.DataBind();
            }
        }

        protected void btnsubmitoffers_Click(object sender, EventArgs e)
        {
            DAC_BookServices oDAC_BookServices = new DAC_BookServices();
            REF_BookServices oREF_BookServices = new REF_BookServices();
            oREF_BookServices.CusID =Convert.ToInt32( dropCusotmer.Value);
            oREF_BookServices.ServiceID = Convert.ToInt32(dropService.Value);
            oREF_BookServices.OfferID= Convert.ToInt32(dropoffers.Value);
            DataTable dt;
            DAV_Offers oDAV_Offers = new DAV_Offers();
            REF_Offers oREF_Offers = new REF_Offers();
            oREF_Offers.ID = Convert.ToInt32(dropoffers.Value);
            dt = oDAV_Offers.SelectOffersByID(oREF_Offers);
            Double OfferPrice = Double.Parse(dt.Rows[0][6].ToString());
            oREF_BookServices.OfferPrice = dt.Rows[0][6].ToString();

            DAC_Service oDAC_Service = new DAC_Service();
            REF_Service oREF_Service = new REF_Service();
            oREF_Service.ID = Convert.ToInt32(dropService.Value);
            dt = oDAC_Service.SelectServiceByID(oREF_Service);
            Double ServicePrice = Double.Parse(dt.Rows[0][4].ToString());

            Double Total = ServicePrice - OfferPrice;
            oREF_BookServices.ServicePrice= dt.Rows[0][3].ToString();
            
            oREF_BookServices.TotalPrice= Total.ToString();
            oDAC_BookServices.Insert(oREF_BookServices);
            LoadData();
        }

        public void LoadData()
        {
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
            oREF_Offers.ID= Convert.ToInt32(dropoffers.Value);
            dt = oDAV_Offers.SelectOffersByID(oREF_Offers);
            Double OfferPrice = Double.Parse(dt.Rows[0][6].ToString());

           
            DAC_Service oDAC_Service = new DAC_Service();
            REF_Service oREF_Service = new REF_Service();
            oREF_Service.ID = Convert.ToInt32(dropService.Value);
            dt = oDAC_Service.SelectServiceByID(oREF_Service);
            Double ServicePrice = Double.Parse(dt.Rows[0][4].ToString());
            Double Total = ServicePrice - OfferPrice;
            lbltotal.InnerText ="Total Cost Rs."+ Total.ToString();
        }
    }
}