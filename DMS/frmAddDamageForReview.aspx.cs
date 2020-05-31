using System;
using System.Linq;
using System.Web.UI;
using DMS.DAC;
using DMS.REFClass;
using System.Data;

namespace DMS
{
    public partial class frmAddDamageForReview : System.Web.UI.Page
    {
        String damageID;
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
            if (!IsPostBack)
            {
                btndelete.Visible = false;
                btnupdate.Visible = false;
                Approvedid.Visible = false;
                Repairedid.Visible = false;
                Repairedidd.Visible = false;
                Repairedidd.Visible = false;
                if (Request.QueryString["id"] != null)
                {
                    btndelete.Visible = true;
                    btnupdate.Visible = true;
                    Button1.Visible = false;
                    damageID = Request.QueryString["id"];
                    REF_Damages oREF_Damages = new REF_Damages();
                    oREF_Damages.id = Convert.ToInt32(damageID);
                   
                }
                else
                {

                }
                LoadService();
            }
            damageID = Request.QueryString["id"];
           
            
        }

        protected void dropService_SelectedIndexChanged(object sender, EventArgs e)
        {
            REF_Damages oREF_Damages = new REF_Damages();
            oREF_Damages.id = Convert.ToInt32(dropService.SelectedValue.ToString());

            DAC_Damage oDAC_Damage = new DAC_Damage();
            
        }

        private void LoadService()
        {
            DataTable dt;
            DAC_Damage oDAC_Damage = new DAC_Damage();
            dt = oDAC_Damage.SelectItems();

            if (dt.Rows.Count > 0)
            {
                dropService.DataSource = null;
                dropService.DataSource = dt;
                dropService.DataTextField = "Name";
                dropService.DataValueField = "id";
                dropService.DataBind();
            }
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            DAC_Damage oDAC_Damage = new DAC_Damage();
            REF_Damages oREF_Damages = new REF_Damages();

            oREF_Damages.id = Convert.ToInt32(damageID);
            oREF_Damages.itemname = dropService.SelectedItem.Text;
            oREF_Damages.discription = Discriptionid.Text;
            oDAC_Damage.Update(oREF_Damages);
            LoadData();
            Response.Redirect("./frmAddDamageForReview.aspx", true);
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            DAC_Damage oDAC_Damage = new DAC_Damage();
            REF_Damages oREF_Damages = new REF_Damages();
            oREF_Damages.id = Convert.ToInt32(damageID);
            oDAC_Damage.Delete(oREF_Damages);
            LoadData();
            Response.Redirect("./frmAddDamageForReview.aspx", true);
        }

        protected void btnsubmitDamage_Click(object sender, EventArgs e)
        {
            try
            {
                DAC_Damage oDAC_Damage = new DAC_Damage();
                REF_Damages oREF_Damages = new REF_Damages();
                oREF_Damages.itemname = dropService.SelectedItem.Text;
                oREF_Damages.discription = Discriptionid.Text;
                oDAC_Damage.Insert(oREF_Damages);
               // ShowMessage("Data Insert successfully!", MessageType.Success);
            }
            catch (Exception ex)
            {
                //ShowMessage("Something went wrong! Please try again!", MessageType.Error);
            }
            LoadData();
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
                                                        "</td><td><a href='frmAddDamageForReview.aspx?id=" +
                                                                      dt.Rows[i][0].ToString() +
                                                         "'>Edit</a></td></tr>";
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