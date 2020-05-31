using DMS.DAC;
using DMS.REFClas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DMS
{
    public partial class frmOffers : System.Web.UI.Page
    {
        String OffersID;
        public enum MessageType { Success, Error, Info, Warning };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btndelete.Visible = false;
                btnupdate.Visible = false;
                if (Request.QueryString["ID"] != null)
                {
                    btndelete.Visible = true;
                    btnupdate.Visible = true;
                    btnsubmitoffers.Visible = false;
                    OffersID = Request.QueryString["ID"];
                    REF_Offers oREF_Offers = new REF_Offers();
                    oREF_Offers.ID = Convert.ToInt32(OffersID);
                    LoadData(oREF_Offers);
                }
                else
                {

                }
            }
            OffersID = Request.QueryString["ID"];
            LoadData();



        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            try
            {
                DAV_Offers oDAV_Offers = new DAV_Offers();
                REF_Offers oREF_Offers = new REF_Offers();
                oREF_Offers.OFFER_TYPE = drpofferType.Value;
                oREF_Offers.Offer_ID = offerID.Text;
                oREF_Offers.OFFER_NAME = offersName.Text;
                oREF_Offers.START_DATE = Request.Form["start"];
                oREF_Offers.END_DATE = Request.Form["end"];
                oREF_Offers.MIN_PRICE = MimumPrice.Text;
                oREF_Offers.MAX_PRICE = MaxmumPrice.Text;
                oREF_Offers.DESCCRIPTION = offerDesc.Text;
                oDAV_Offers.Insert(oREF_Offers);
                ShowMessage("Data Insert successfully!");
            }catch(Exception ex)
            {
                ShowMessage("Something went wrong! Please try again!");
            }
            
        }

        protected void ShowMessage(string Message)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Popup", "myFunction('" + Message + "');", true);

        }
        public void LoadData(REF_Offers oREF_Offers)
        {
            
                DataTable dt;
                DAV_Offers oDAV_Offers = new DAV_Offers();
                
                oREF_Offers.ID = Convert.ToInt32(OffersID);
                dt = oDAV_Offers.SelectOffersByID(oREF_Offers);
                
                drpofferType.Value = dt.Rows[0][1].ToString();
                offerID.Text = dt.Rows[0][2].ToString();
                offersName.Text = dt.Rows[0][3].ToString();
                //Request.Form["start"] = dt.Rows[0][4].ToString();
                //Request.Form["end"] = dt.Rows[0][5].ToString();
                MimumPrice.Text = dt.Rows[0][6].ToString();
                MaxmumPrice.Text = dt.Rows[0][7].ToString();
                offerDesc.Text = dt.Rows[0][8].ToString();
                btnupdate.Visible = true;
                btndelete.Visible = true;
                btnsubmitoffers.Visible = false;
           
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
                        StrInnserHtml = StrInnserHtml + "<tr><td>" + dt.Rows[i][1].ToString() + "</td><td>" + dt.Rows[i][2].ToString() + "</td><td>" + dt.Rows[i][3].ToString() + "</td><td> " + dt.Rows[i][4].ToString() + " </td><td> " + dt.Rows[i][5].ToString() + " </td><td> " + dt.Rows[i][6].ToString() + " </td><td> " + dt.Rows[i][7].ToString() + " </td><td> " + dt.Rows[i][8].ToString() + " </td><td><a href='frmOffers.aspx?ID=" + dt.Rows[i][0].ToString() + "'>Edit</a></td></tr>";
                    }

                }
                divInnerHtml.InnerHtml = StrInnserHtml;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            DAV_Offers oDAV_Offers = new DAV_Offers();
            REF_Offers oREF_Offers = new REF_Offers();
            oREF_Offers.ID = Convert.ToInt32(OffersID); ;
            oREF_Offers.OFFER_TYPE = drpofferType.Value;
            oREF_Offers.Offer_ID = offerID.Text;
            oREF_Offers.OFFER_NAME = offersName.Text;
            oREF_Offers.START_DATE = Request.Form["start"];
            oREF_Offers.END_DATE = Request.Form["end"];
            oREF_Offers.MIN_PRICE = MimumPrice.Text;
            oREF_Offers.MAX_PRICE = MaxmumPrice.Text;
            oREF_Offers.DESCCRIPTION = offerDesc.Text;
            oDAV_Offers.Update(oREF_Offers);
            Response.Redirect("./frmOffers.aspx", true);
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            DAV_Offers oDAV_Offers = new DAV_Offers();
            REF_Offers oREF_Offers = new REF_Offers();
            oREF_Offers.ID = Convert.ToInt32(OffersID); ;
        
            oDAV_Offers.Delete(oREF_Offers);
            Response.Redirect("./frmOffers.aspx", true);
        }
    }
}