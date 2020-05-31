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
    public partial class frmAddItem : System.Web.UI.Page
    {
        String ItemID;
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
                    btnsave.Visible = false;
                    ItemID = Request.QueryString["ID"];
                    REF_Item oREF_Item = new REF_Item();
                    oREF_Item.ID = ItemID;
                    LoadData(oREF_Item);
                }
                else
                {

                }
            }
            ItemID = Request.QueryString["ID"];
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                DataTable dt;
                DAC_Item oDAC_Item = new DAC_Item();
                dt = oDAC_Item.SelectItem();
                String StrInnserHtml = "";

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                       

                        StrInnserHtml = StrInnserHtml + "<tr><td>" + dt.Rows[i][1].ToString() + "</td><td>" + dt.Rows[i][2].ToString() + "</td><td>" + dt.Rows[i][5].ToString() + "</td><td>" + ExpairOrnot(dt.Rows[i][4].ToString())+ "</td><td><a href='frmItem.aspx?ID=" + dt.Rows[i][0].ToString() + "'>Edit</a></td></tr>";
                    }

                }
                divInnerHtml.InnerHtml = StrInnserHtml;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        protected void ShowMessage(string Message)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Popup", "myFunction('" + Message + "');", true);

        }
        protected void btnsubmitoffers_Click(object sender, EventArgs e)
        {
            try
            {
                REF_Item oREF_Item = new REF_Item();
                DAC_Item oDAC_Item = new DAC_Item();
                oREF_Item.Name = ItemName.Text;
                oREF_Item.Price = ItemPrice.Text;
                oREF_Item.Delivary = DelivaryPrice.Text;
                oREF_Item.ExpiredDate = Request.Form["ExpairDate"];
                oDAC_Item.Insert(oREF_Item);
                Response.Redirect("./frmItem.aspx", true);
            }catch(Exception ex)
            {
                ShowMessage("Something went wrong! Please try again!");
            }
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            REF_Item oREF_Item = new REF_Item();
            DAC_Item oDAC_Item = new DAC_Item();
            oREF_Item.ID = ItemID;
            oREF_Item.Name = ItemName.Text;
            oREF_Item.Price = ItemPrice.Text;
            oREF_Item.Delivary = DelivaryPrice.Text;
            oDAC_Item.Update(oREF_Item);
            Response.Redirect("./frmItem.aspx", true);
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            REF_Item oREF_Item = new REF_Item();
            DAC_Item oDAC_Item = new DAC_Item();
            oREF_Item.ID = ItemID;
            oREF_Item.Name = ItemName.Text;
            oREF_Item.Price = ItemPrice.Text;
            oDAC_Item.Delete(oREF_Item);
            Response.Redirect("./frmItem.aspx", true);
        }

        public void LoadData(REF_Item oREF_Item)
        {
            try
            {
                DataTable dt;
                DAC_Item oDAC_Item = new DAC_Item();
                dt = oDAC_Item.SelectItemByID(oREF_Item);
                ItemName.Text = dt.Rows[0][1].ToString();
                ItemPrice.Text = dt.Rows[0][2].ToString();
                DelivaryPrice.Text = dt.Rows[0][5].ToString();

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public String   ExpairOrnot(String Date )
        {
            String Value;
            string iDate = Date;
            DateTime oDate = Convert.ToDateTime(iDate);
            DateTime dateTime = DateTime.UtcNow.Date;

            if(oDate<= dateTime)
            {
                Value = "Expired";
            }
            else
            {
                Value = "Not Expired";
            }
            return Value;
        }
    }
}