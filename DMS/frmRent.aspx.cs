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
    public partial class frmRent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCustomer();
            LoadDataItem();
            LoadData();
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
        public void LoadDataItem()
        {

            DataTable dt;
            DAC_Rent oDAC_Rent = new DAC_Rent();
            dt = oDAC_Rent.Selectstock();
            if (dt.Rows.Count > 0)
            {
                dropItem.DataSource = null;
                dropItem.DataSource = dt;
                dropItem.DataTextField = "Name";
                dropItem.DataValueField = "ID";
                dropItem.DataBind();
            }
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                REF_Rent oREF_Rent = new REF_Rent();
                DAC_Rent oDAC_Rent = new DAC_Rent();
                oREF_Rent.CusID = dropCusotmer.SelectedValue.ToString(); ;
                oREF_Rent.ItemID = dropItem.SelectedValue.ToString();
                oREF_Rent.Deposit = Deposit.Text;
                oREF_Rent.Qty = Quentity.Text;
                oREF_Rent.DaliyRate = DailyRate.Text;
                oREF_Rent.TotalCost = (Double.Parse(DailyRate.Text) * Double.Parse(NumberOfDay.Text)).ToString();
                oREF_Rent.NumberOfDay = NumberOfDay.Text;

                int RID = oDAC_Rent.Insert(oREF_Rent);
                Response.Redirect("./frmRentInvoice.aspx?ID=" + RID, true);
            }catch(Exception ex)
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
            
                DAC_Rent oDAC_Rent = new DAC_Rent();
                dt = oDAC_Rent.SelectItem();
                String StrInnserHtml = "";

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {


                        StrInnserHtml = StrInnserHtml + "<tr><td>" + dt.Rows[i][5].ToString() + "</td><td>" + dt.Rows[i][2].ToString() + "</td></tr>";
                    }

                }
                divInnerHtml.InnerHtml = StrInnserHtml;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected void NumberOfDay_TextChanged(object sender, EventArgs e)
        {
            TotalCost.Text = (Double.Parse(DailyRate.Text) * Double.Parse(NumberOfDay.Text)).ToString();
        }

        protected void Cal_Click(object sender, EventArgs e)
        {
            TotalCost.Text = (Double.Parse(DailyRate.Text) * Double.Parse(NumberOfDay.Text)).ToString();
        }
    }
}