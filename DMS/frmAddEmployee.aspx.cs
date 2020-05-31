using System;
using DMS.DAC;
using DMS.REFClass;
using System.Web.UI;
using System.Data;

namespace DMS
{
    public partial class frmAddEmployee : System.Web.UI.Page
    {
        String empID;
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
                    Button1.Visible = false;
                    empID = Request.QueryString["ID"];
                    REF_Employee oREF_Employee = new REF_Employee();
                    oREF_Employee.id = Convert.ToInt32(empID);
                    LoadData(oREF_Employee);
                }
                else
                {

                }
            }
            empID = Request.QueryString["ID"];
        }
        protected void ShowMessage(string Message)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Popup", "myFunction('" + Message + "');", true);

        }

        public void LoadData(REF_Employee oREF_Employee)
        {

            DataTable dt;
            DAC_Employee oDAV_Employee = new DAC_Employee();

            oREF_Employee.id = Convert.ToInt32(empID);
            dt = oDAV_Employee.SelectEmployeesByID(oREF_Employee);

            nameid.Text = dt.Rows[0][1].ToString();
            addressid.Text = dt.Rows[0][2].ToString();
            jobtyid.Text = dt.Rows[0][3].ToString();
            bsalid.Text = dt.Rows[0][4].ToString();
     
            btnupdate.Visible = true;
            btndelete.Visible = true;
            Button1.Visible = false;

        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            DAC_Employee oDAC_Employee = new DAC_Employee();
            REF_Employee oREF_Employee = new REF_Employee();

            oREF_Employee.id = Convert.ToInt32(empID);
            oREF_Employee.name = nameid.Text;
            oREF_Employee.address = addressid.Text;
            oREF_Employee.jobtype = jobtyid.Text;
            oREF_Employee.basicsal = bsalid.Text;

            oDAC_Employee.Update(oREF_Employee);
            Response.Redirect("./frmViewEmployee.aspx", true);
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            DAC_Employee oDAC_Employee = new DAC_Employee();
            REF_Employee oREF_Employee = new REF_Employee();
            oREF_Employee.id = Convert.ToInt32(empID);
            oDAC_Employee.Delete(oREF_Employee);
            Response.Redirect("./frmViewEmployee.aspx", true);
        }

        protected void btnsubmitEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                DAC_Employee oDAV_Employee = new DAC_Employee();
                REF_Employee oREF_Employee = new REF_Employee();
                oREF_Employee.name = nameid.Text;
                oREF_Employee.address = addressid.Text;
                oREF_Employee.jobtype = jobtyid.Text;
                oREF_Employee.basicsal = bsalid.Text;
                if (!oREF_Employee.name.Equals(""))
                {
                    
                    oDAV_Employee.Insert(oREF_Employee);
                    ShowMessage("Data Insert Successfully!");
                }else
                {
                    ShowMessage("Something went wrong! Please try again!");
                }
            }
            catch (Exception ex)
            {
                ShowMessage("Something went wrong! Please try again!");
            }
        }

       
    }
}