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
    public partial class frmReturn : System.Web.UI.Page
    {
        String UID;
        String ItemID;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
            LoadRent();
            }
        }
        private void LoadRent()
        {
            DataTable dt;
            DAC_Rent oDAC_Rent = new DAC_Rent();
            dt = oDAC_Rent.SelectRent();

            if (dt.Rows.Count > 0)
            {
                dropRent.DataSource = null;
                dropRent.DataSource = dt;
                dropRent.DataTextField = "ID";
                dropRent.DataValueField = "ID";
                dropRent.DataBind();
            }
        }

        protected void dropRent_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt;
            DAC_Rent oDAC_Rent = new DAC_Rent();
            REF_Rent oREF_Rent = new REF_Rent();
            oREF_Rent.ID = dropRent.SelectedValue;
            dt = oDAC_Rent.SelectRentByID(oREF_Rent);


            CustomerName.Text= dt.Rows[0][0].ToString();
            ItemName.Text= dt.Rows[0][1].ToString();
            Deposit.Text= dt.Rows[0][2].ToString();
            Quentity.Text= dt.Rows[0][3].ToString();
            UID = dt.Rows[0][4].ToString();
            ItemID = dt.Rows[0][5].ToString();
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt;
                REF_Return oREF_Return = new REF_Return();
                DAC_Return oDAC_Return = new DAC_Return();
                DAC_Rent oDAC_Rent = new DAC_Rent();
                REF_Rent oREF_Rent = new REF_Rent();
                oREF_Rent.ID = dropRent.SelectedValue;
                dt = oDAC_Rent.SelectRentByID(oREF_Rent);


                CustomerName.Text = dt.Rows[0][0].ToString();
                ItemName.Text = dt.Rows[0][1].ToString();
                Deposit.Text = dt.Rows[0][2].ToString();
                Quentity.Text = dt.Rows[0][3].ToString();
                UID = dt.Rows[0][4].ToString();
                ItemID = dt.Rows[0][5].ToString();
                refundAmount.Text = (Double.Parse(Deposit.Text) - Double.Parse(AdditionAmount.Text)).ToString();

                oREF_Return.CusID = UID;
                oREF_Return.ItemID = ItemID;
                oREF_Return.Deposit = Deposit.Text;
                oREF_Return.Qty = Quentity.Text;
                oREF_Return.Addition = AdditionAmount.Text;
                oREF_Return.Refund = refundAmount.Text;
                oDAC_Return.Insert(oREF_Return);
                Response.Redirect("./frmRent.aspx", true);
            }
            catch(Exception ex)
            {
                ShowMessage("Something went wrong! Please try again!");
            }

            
        }
        protected void ShowMessage(string Message)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Popup", "myFunction('" + Message + "');", true);

        }
        protected void Cal_Click(object sender, EventArgs e)
        {
            DataTable dt;
            DAC_Rent oDAC_Rent = new DAC_Rent();
            REF_Rent oREF_Rent = new REF_Rent();
            oREF_Rent.ID = dropRent.SelectedValue;
            dt = oDAC_Rent.SelectRentByID(oREF_Rent);


            CustomerName.Text = dt.Rows[0][0].ToString();
            ItemName.Text = dt.Rows[0][1].ToString();
            Deposit.Text = dt.Rows[0][2].ToString();
            Quentity.Text = dt.Rows[0][3].ToString();
            UID= dt.Rows[0][4].ToString();
            ItemID = dt.Rows[0][5].ToString();
            refundAmount.Text = (Double.Parse(Deposit.Text) - Double.Parse(AdditionAmount.Text)).ToString();

        }
    }
}