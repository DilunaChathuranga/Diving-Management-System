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
    public partial class frmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try {
                REF_User oUser = new REF_User();
                DAC_User oDAC_User = new DAC_User();
                oUser.USER_NAME = UserName.Text;
                oUser.PASSWORD = Password.Text;
                DataTable dt = oDAC_User.SelectByUserNameAndPasswordHash(oUser);
                oUser.Role = Convert.ToInt32(dt.Rows[0][3].ToString());
                Session["LoggedUser"] = oUser;
                Response.Redirect("./frmHome.aspx", true);
            }catch(Exception ex)
            {
                ShowMessage("Enter User name and password");
            }
        }

        protected void ShowMessage(string Message)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Popup", "myFunction('" + Message + "');", true);

        }
    }
}