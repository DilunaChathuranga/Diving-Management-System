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
    public partial class frmStock : System.Web.UI.Page
    {
        String StockID;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                btnupdate.Visible = false;
                ItemName.Visible = false;
                lblnewqty.Visible = false;
                newQty.Visible = false;
                LoadData();
                LoadDataItem();

                if (Request.QueryString["ID"] != null)
                {
                    ItemName.Visible = true;
                    Quentity.Enabled = false;
                    dropItem.Visible = false;
                    btnupdate.Visible = true;
                    lblnewqty.Visible = true;
                    newQty.Visible = true;
                    btnsave.Visible = false;
                    StockID = Request.QueryString["ID"];
                    REF_Stock oREF_Stock = new REF_Stock();
                    oREF_Stock.ID = StockID;
                    LoadData(oREF_Stock);
                }
                else
                {

                }
               
            }
            StockID = Request.QueryString["ID"];
        }

        public void LoadDataItem()
        {
            
                DataTable dt;
                DAC_Item oDAC_Item = new DAC_Item();
                dt = oDAC_Item.SelectItem();
                if (dt.Rows.Count > 0)
                {
                dropItem.DataSource = null;
                dropItem.DataSource = dt;
                dropItem.DataTextField = "Name";
                dropItem.DataValueField = "ID";
                dropItem.DataBind();
                }
            }
        public void LoadData(REF_Stock oREF_Stock)
        {
            try
            {
                DataTable dt;
                DAC_Stock oDAC_Stock = new DAC_Stock();
                dt = oDAC_Stock.SelectStockID(oREF_Stock);
                ItemName.Enabled = false;
                ItemName.Text = dt.Rows[0][1].ToString();
                Quentity.Text = dt.Rows[0][2].ToString();


            }
            catch (Exception ex)
            {
                throw;
            }
        }
        protected void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                REF_Stock oREF_Stock = new REF_Stock();
                DAC_Stock oDAC_Stock = new DAC_Stock();

                oREF_Stock.ItemID = dropItem.Value;
                oREF_Stock.Qty = Quentity.Text;
                oDAC_Stock.Insert(oREF_Stock);
                Response.Redirect("./frmStock.aspx", true);
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
        protected void btnupdate_Click(object sender, EventArgs e)
        {
            REF_Stock oREF_Stock = new REF_Stock();
            DAC_Stock oDAC_Stock = new DAC_Stock();
            oREF_Stock.ID = StockID;
            oREF_Stock.ItemID = ItemName.Text;
            int Qty = Convert.ToInt32(Quentity.Text) + Convert.ToInt32(newQty.Text);
            oREF_Stock.Qty =Qty.ToString();
            oDAC_Stock.Update(oREF_Stock);
            Response.Redirect("./frmStock.aspx", true);
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
                        StrInnserHtml = StrInnserHtml + "<tr><td>" + dt.Rows[i][5].ToString() + "</td><td>" + dt.Rows[i][2].ToString() + "</td><td><a href='frmStock.aspx?ID=" + dt.Rows[i][0].ToString() + "'>Edit</a></td></tr>";
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