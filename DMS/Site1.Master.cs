using DMS.REFClas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DMS
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                REF_User oUser = new REF_User();
                oUser = (REF_User)Session["LoggedUser"];
                if (oUser.Role == 1)
                {
                    liAddEmployee.Visible = true;
                    liviewEmployee.Visible = true;
                    liSalaryEmployee.Visible = true;
                    liDamageConfirm.Visible = true;
                    liaddDamages.Visible = true;
                    liItem.Visible = true;
                    liStocks.Visible = true;
                    lireport.Visible = true;
                    liRent.Visible = true;
                    liRetun.Visible = true;
                    liAddOffers.Visible = true;
                    liiewOffers.Visible = true;
                    
                    liaddcourse.Visible = true;
                    liviewcourse.Visible = true;
                    liaddustomertocourset.Visible = true;
                    licoursereport.Visible = true;
                    liAddService.Visible = true;
                    liViewService.Visible = true;
                    liAddCustome.Visible = true;
                    lifrmViewSalary.Visible = true;
                    liReturnReports.Visible = true;
                    lireport.Visible = true;
                    liFinanceReport.Visible = true;

                }
                else if (oUser.Role == 2)
                {
                    liAddEmployee.Visible = false;
                    liSalaryEmployee.Visible = false;
                    liDamageConfirm.Visible = false;
                    liaddDamages.Visible = false;
                    liItem.Visible = false;
                    lireport.Visible = false;
                    liRent.Visible = true;
                    liRetun.Visible = true;
                    liAddOffers.Visible = false;
                    liiewOffers.Visible = true;
                    
                    liaddcourse.Visible = false;
                    liviewcourse.Visible = true;
                    liaddustomertocourset.Visible = true;
                    licoursereport.Visible = false;
                    liAddService.Visible = false;
                    liViewService.Visible = true;
                    liAddCustome.Visible = true;
                    lifrmViewSalary.Visible = false;
                    liReturnReports.Visible = false;
                    lireport.Visible = false;
                    liFinanceReport.Visible = false;

                    liStocks.Visible = true;
                    liviewEmployee.Visible = true;

                }
                else if (oUser.Role == 3)
                {
                    liAddEmployee.Visible = false;
                    liSalaryEmployee.Visible = false;
                    liviewEmployee.Visible = false;
                    liDamageConfirm.Visible = false;
                    liaddDamages.Visible = false;
                    liItem.Visible = false;
                    liStocks.Visible = false;
                    lireport.Visible = false;
                    liRent.Visible = false;
                    liRetun.Visible = false;
                    liAddOffers.Visible = false;
                    liiewOffers.Visible = false;
                   
                    liaddcourse.Visible = false;
                    liviewcourse.Visible = false;
                    liaddustomertocourset.Visible = false;
                    licoursereport.Visible = false;
                    liAddService.Visible = false;
                    liViewService.Visible = false;
                    liAddCustome.Visible = false;
                    lifrmViewSalary.Visible = false;
                    liReturnReports.Visible = false;
                    lireport.Visible = false;
                    liFinanceReport.Visible = false;

                    liViewRepair.Visible = true;


                }
            }
            catch
            {
                Response.Redirect("./frmLogin.aspx", true);
            }
        }
    }
}