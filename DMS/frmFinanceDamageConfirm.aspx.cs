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
    public partial class frmFinanceDamageConfirm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
            if (Request.QueryString["ID"] != null)
            {
                DAC_Damage oDAC_Damage = new DAC_Damage();
                REF_Damages oREF_Damages = new REF_Damages();
                oREF_Damages.id =Convert.ToInt32( Request.QueryString["ID"]);
                oDAC_Damage.UpdateFinance(oREF_Damages);
                LoadData();
            }
        }

        public void LoadData()
        {
            try
            {
                DataTable dt;
                DAC_Damage oDAC_Damage = new DAC_Damage();
                dt = oDAC_Damage.SelectDamages();
                String StrInnserHtml = "";

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        StrInnserHtml = StrInnserHtml + "<tr><td>" + dt.Rows[i][1].ToString() +
                                                        "</td><td>" + dt.Rows[i][2].ToString() +
                                                        "</td><td>" + dt.Rows[i][3].ToString() +
                                                        "</td><td><a href='frmFinanceDamageConfirm.aspx?id=" +
                                                                      dt.Rows[i][0].ToString() +
                                                         "'>Add Approve</a></td></tr>";
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