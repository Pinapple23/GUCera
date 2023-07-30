using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class ListCertificate : System.Web.UI.Page
    {
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if (Session["type"].ToString() == "0")
            {
                Response.Redirect("instructor.aspx");
            }
            else if (Session["type"].ToString() == "1")
            {
                Response.Redirect("admin.aspx");
            }
            else
            {
                Response.Redirect("viewprofile.aspx");
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["type"] == null || Session["type"].ToString() != "2")
            {
                Response.Redirect("AccessDenied.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            

            loadTable();



        }
        protected void loadTable()
        {
            try
            {
                String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                
                int CourseID = Int32.Parse(Course_Id.Text);

                SqlCommand SeeYourCertificate = new SqlCommand("viewCertificate", conn);
                SeeYourCertificate.CommandType = CommandType.StoredProcedure;

                SeeYourCertificate.Parameters.Add(new SqlParameter("@sid", Session["user"]));
                SeeYourCertificate.Parameters.Add(new SqlParameter("@cid", CourseID));





                // populating the table
                SqlDataAdapter da = new SqlDataAdapter(SeeYourCertificate);
                DataTable dt = new DataTable();
                da.Fill(dt);
                CertificateNow.DataSource = dt;
                CertificateNow.DataBind();
                conn.Close();
            }
            catch(Exception NoC)
            {
                Label1.Text = "there's no certificate registered with those inputs"; 

            }


        }
    }
}