using DMS.DAC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DMS
{
    public partial class frmViewSalary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                DataTable dt;
                DAC_SalaryService oDAC_SalaryService = new DAC_SalaryService();
                dt = oDAC_SalaryService.Selectsalary();
                String StrInnserHtml = "";

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        StrInnserHtml = StrInnserHtml + "<tr><td>" + dt.Rows[i][0].ToString() +
                                                        "</td><td>" + dt.Rows[i][1].ToString() +
                                                        "</td><td>" + dt.Rows[i][2].ToString() +
                                                        "</td><td>" + dt.Rows[i][3].ToString() +
                                                        "</td><td>" + dt.Rows[i][4].ToString() +
                                                        "</td><td>" + dt.Rows[i][5].ToString() +
                                                        "</td><td><a href='frmSalaryCalculate.aspx?ID=" + dt.Rows[i][0].ToString() + "'>Edit</a></td></tr>";
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