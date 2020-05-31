using System;
using System.Web.UI;
using DMS.DAC;
using DMS.REFClass;
using System.Data;

namespace DMS
{
    public partial class frmSalaryCalculate : System.Web.UI.Page
    {
        String salaryID;
        String EmpID;
        String EmpName;
        public enum MessageType { Success, Error, Info, Warning };
        Double BasicSalary = 0.0;
        Double Bonous = 0.0;
        Double othours = 0.0;
        Double salary = 0.0;

        protected void Page_Load(object sender, EventArgs e)
        {
            nameid.Visible = false;
            btnupdate.Visible = false;
            if (!IsPostBack)
            {
                if (Request.QueryString["ID"] != null)
                {
                  
                    btnupdate.Visible = true;
                    Button1.Visible = false;
                    nameid.Visible = true;
                    dropService.Visible = false;
                    
                    DataTable dt;
                    DAC_SalaryService oDAC_SalaryService = new DAC_SalaryService();
                    REF_Employee oREF_Employee = new REF_Employee();
                    oREF_Employee.salaryID = Request.QueryString["ID"];
                    salaryID= Request.QueryString["ID"];
                    dt = oDAC_SalaryService.SelectsalaryByID(oREF_Employee);
                    oREF_Employee.id=Convert.ToInt32( dt.Rows[0][1].ToString());
                    nameid.Text = dt.Rows[0][2].ToString();
                    EmpID = dt.Rows[0][1].ToString();
                    OTid.Text = dt.Rows[0][3].ToString();
                    Bonousid.Text = dt.Rows[0][4].ToString();
                    netsalid.Text = dt.Rows[0][5].ToString();

                    DataTable tdt = oDAC_SalaryService.SelectsalaryByID(oREF_Employee);
                    BasicSalary = Double.Parse(tdt.Rows[0][4].ToString());
                    Basicsalid.Text = tdt.Rows[0][4].ToString();

                }
                else
                {
                    LoadService();
                }
                salaryID = Request.QueryString["ID"];

            }
        }

        protected void btnsubmitEmployee_Click1(object sender, EventArgs e)
        {
            try
            {
                DAC_SalaryService oDAV_Empsalary = new DAC_SalaryService();
                REF_Employee oREF_Employee = new REF_Employee();
                oREF_Employee.id = Convert.ToInt32(dropService.SelectedValue.ToString());
                oREF_Employee.name = dropService.SelectedItem.ToString();
                oREF_Employee.othours = OTid.Text;
                oREF_Employee.bonous = Bonousid.Text;
                oREF_Employee.salary = netsalid.Text;
                oDAV_Empsalary.Insert(oREF_Employee);
                ShowMessage("Data Insert successfully!");
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
        protected void btnsubmitEmployee_Click2(object sender, EventArgs e)
        {
            BasicSalary = Double.Parse(Basicsalid.Text);
          

            try
            {

                if (CheckBox1.Checked)
                {
                    othours = Convert.ToDouble(OTid.Text);
                    Bonous = (BasicSalary * 5) / 100;
                    othours = Convert.ToDouble(OTid.Text);
                    salary = (othours * 1000) + (BasicSalary - Bonous);
                    Bonousid.Text = Bonous.ToString();
                    netsalid.Text = salary.ToString();
                }
                else
                {
                    othours = Convert.ToDouble(OTid.Text);
                    Bonous = (BasicSalary * 5) / 100;
                    othours = Convert.ToDouble(OTid.Text);
                    salary = (othours * 1000) + (BasicSalary + Bonous);
                    Bonousid.Text = Bonous.ToString();
                    netsalid.Text = salary.ToString();
                }
             
            }
            catch (Exception ex)
            {
                ShowMessage("Something went wrong! Please try again!", MessageType.Error);
            }
        }

        protected void ShowMessage(string Message, MessageType type)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), System.Guid.NewGuid().ToString(), "ShowMessage('" + Message + "','" + type + "');", true);
        }

        private void LoadService()
        {
            DataTable dt;
            DAC_SalaryService oDAC_SalaryService = new DAC_SalaryService();
            dt = oDAC_SalaryService.SelectServiceSalary();

            if (dt.Rows.Count > 0)
            {
                dropService.DataSource = null;
                dropService.DataSource = dt;
                dropService.DataTextField = "name";
                dropService.DataValueField = "id";
                dropService.DataBind();
            }
        }

        protected void dropService_SelectedIndexChanged(object sender, EventArgs e)
        {
            REF_Employee oREF_Employee = new REF_Employee();
            oREF_Employee.id =Convert.ToInt32( dropService.SelectedValue.ToString());

            DAC_SalaryService oDAC_SalaryService = new DAC_SalaryService();
           DataTable dt= oDAC_SalaryService.Selectbasicsalary(oREF_Employee);
            BasicSalary =Double.Parse( dt.Rows[0][4].ToString());
            Basicsalid.Text = dt.Rows[0][4].ToString();


        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            try {
                DAC_SalaryService oDAV_Empsalary = new DAC_SalaryService();
                REF_Employee oREF_Employee = new REF_Employee();
                oREF_Employee.salaryID = Request.QueryString["ID"];
                oREF_Employee.id = Convert.ToInt32(EmpID);
                oREF_Employee.name = nameid.Text;
                oREF_Employee.othours = OTid.Text;
                oREF_Employee.bonous = Bonousid.Text;
                oREF_Employee.salary = netsalid.Text;
                oDAV_Empsalary.Update(oREF_Employee);
                btnupdate.Visible = false;
                Button1.Visible = true;
                nameid.Visible = false;
                dropService.Visible = true;
                ShowMessage("Data Insert successfully!");
            }catch(Exception ex)
            {

            }
            
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {

        }
    }
}