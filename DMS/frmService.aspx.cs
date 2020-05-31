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
    public partial class frmService : System.Web.UI.Page
    {
        String ServiceID;
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
                    btnsubmitService.Visible = false;
                    ServiceID = Request.QueryString["ID"];
                    REF_Service oREF_Service = new REF_Service();
                    oREF_Service.ID =Convert.ToInt32( ServiceID);
                    LoadData(oREF_Service);
                }
                else
                {

                }
            }
            ServiceID = Request.QueryString["ID"];
            LoadData();
        }

        protected void btnsubmitService_Click(object sender, EventArgs e)
        {
            try
            {
                DAC_Service oDAC_Service = new DAC_Service();
                REF_Service oREF_Service = new REF_Service();
                oREF_Service.ServiceiD = serviceCode.Text;
                oREF_Service.Service_Name = ServiceName.Text;
                oREF_Service.Service_Duration = ServiceDuration.Text;
                oREF_Service.Price_Per_Hour = PricePerHour.Text;
                oREF_Service.Description = Description.Text;

                oDAC_Service.Insert(oREF_Service);
                ShowMessage("Data Insert successfully!");
                LoadData();
            }
            catch (Exception ex)
            {
                ShowMessage("Something went wrong! Please try again!");
            }
        }
        protected void ShowMessage(string Message)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Popup", "myFunction('" + Message + "');", true);

        }
        public void LoadData()
        {
            try
            {
                DataTable dt;
                DAC_Service oDAC_Service = new DAC_Service();
                dt = oDAC_Service.SelectService();
                String StrInnserHtml = "";

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        StrInnserHtml = StrInnserHtml + "<tr><td>" + dt.Rows[i][1].ToString() + "</td><td>" + dt.Rows[i][2].ToString() + "</td><td>" + dt.Rows[i][3].ToString() + "</td><td> " + dt.Rows[i][4].ToString() + " </td><td> " + dt.Rows[i][5].ToString() + " </td><td><a href='frmService.aspx?ID=" + dt.Rows[i][0].ToString() + "'>Edit</a></td></tr>";
                    }

                }
                divInnerHtml.InnerHtml = StrInnserHtml;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void LoadData(REF_Service oREF_Service)
        {
            try
            {
                DataTable dt;
                DAC_Service oDAC_Service = new DAC_Service();
               
                dt = oDAC_Service.SelectServiceByID(oREF_Service);
                serviceCode.Text = dt.Rows[0][1].ToString();
                ServiceName.Text = dt.Rows[0][2].ToString();
                ServiceDuration.Text = dt.Rows[0][3].ToString();
                PricePerHour.Text = dt.Rows[0][4].ToString();
                Description.Text = dt.Rows[0][5].ToString();


            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            DAC_Service oDAC_Service = new DAC_Service();
            REF_Service oREF_Service = new REF_Service();
            oREF_Service.ID =Convert.ToInt32( ServiceID);
            oREF_Service.ServiceiD = serviceCode.Text;
            oREF_Service.Service_Name = ServiceName.Text;
            oREF_Service.Service_Duration = ServiceDuration.Text;
            oREF_Service.Price_Per_Hour = PricePerHour.Text;
            oREF_Service.Description = Description.Text;

            oDAC_Service.Update(oREF_Service);
            Response.Redirect("./frmService.aspx", true);
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            DAC_Service oDAC_Service = new DAC_Service();
            REF_Service oREF_Service = new REF_Service();
            oREF_Service.ID = Convert.ToInt32(ServiceID);
            oREF_Service.ServiceiD = serviceCode.Text;
            oREF_Service.Service_Name = ServiceName.Text;
            oREF_Service.Service_Duration = ServiceDuration.Text;
            oREF_Service.Price_Per_Hour = PricePerHour.Text;
            oREF_Service.Description = Description.Text;

            oDAC_Service.Delete(oREF_Service);
            Response.Redirect("./frmService.aspx", true);
        }
    }
}