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
    public partial class frmAddCourse : System.Web.UI.Page
    {
        String CourseID;
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
                    btnsubmitCource.Visible = false;
                    CourseID = Request.QueryString["ID"];
                    REF_Course oREF_Course = new REF_Course();
                    oREF_Course.ID = Convert.ToInt32(CourseID);
                    LoadData(oREF_Course);
                }
                else
                {

                }
            }
            CourseID = Request.QueryString["ID"];
            LoadData();
        }

        protected void btnsubmitCource_Click(object sender, EventArgs e)
        {
            try
            {
                DAV_Cources oDAV_Cources = new DAV_Cources();
                REF_Course oREF_Course = new REF_Course();
                oREF_Course.COURSENAME = CourseName.Text;
                oREF_Course.COURSEDURATION = CourceDuration.Text;
                oREF_Course.COURSEPRICE = CourcePrice.Text;
                oREF_Course.DESCRIPTION = Description.Text;
                oREF_Course.STATUS = 0;
                oREF_Course.COURSECODE = CourseCode.Text;
                oDAV_Cources.Insert(oREF_Course);
                ShowMessage("Data Insert successfully!");
                LoadData();
            }
            catch (Exception ex)
            {
                ShowMessage("Something went wrong! Please try again!");
            }
        }

        protected void ShowMessage(string Message)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Popup", "myFunction('"+Message+"');", true);
          
        }

        public void LoadData()
        {
            try
            {
                DataTable dt;
                DAV_Cources oDAV_Cources = new DAV_Cources();
                dt = oDAV_Cources.SelectCourse();
                String StrInnserHtml = "";

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        StrInnserHtml = StrInnserHtml + "<tr><td>" + dt.Rows[i][1].ToString() + "</td><td>" + dt.Rows[i][2].ToString() + "</td><td>" + dt.Rows[i][3].ToString() + "</td><td> " + dt.Rows[i][4].ToString() + " </td><td> " + dt.Rows[i][5].ToString() + " </td><td><a href='frmAddCourse.aspx?ID=" + dt.Rows[i][0].ToString() + "'>Edit</a></td></tr>";
                    }

                }
                divInnerHtml.InnerHtml = StrInnserHtml;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            DAV_Cources oDAV_Cources = new DAV_Cources();
            REF_Course oREF_Course = new REF_Course();
            oREF_Course.ID = Convert.ToInt32(CourseID); ;
            oREF_Course.COURSENAME = CourseName.Text;
            oREF_Course.COURSEDURATION = CourceDuration.Text;
            oREF_Course.COURSEPRICE = CourcePrice.Text;
            oREF_Course.DESCRIPTION = Description.Text;
            oREF_Course.STATUS = 0;
            oREF_Course.COURSECODE = CourseCode.Text;
            oDAV_Cources.Update(oREF_Course);
            Response.Redirect("./frmAddCourse.aspx", true);
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            DAV_Cources oDAV_Cources = new DAV_Cources();
            REF_Course oREF_Course = new REF_Course();
            oREF_Course.ID = Convert.ToInt32(CourseID); ;

            oDAV_Cources.Delete(oREF_Course);
            Response.Redirect("./frmAddCourse.aspx", true);
        }

        public void LoadData(REF_Course oREF_Course)
        {

            DataTable dt;
            DAV_Cources oDAV_Cources = new DAV_Cources();
            dt = oDAV_Cources.SelectCourseByID(oREF_Course);

            CourseName.Text = dt.Rows[0][2].ToString();
            CourceDuration.Text = dt.Rows[0][3].ToString(); ;
            CourcePrice.Text = dt.Rows[0][4].ToString(); ;
            Description.Text = dt.Rows[0][5].ToString(); ;
            CourseCode.Text= dt.Rows[0][1].ToString();
         
            btnupdate.Visible = true;
            btndelete.Visible = true;
            btnsubmitCource.Visible = false;

        }
    }
}