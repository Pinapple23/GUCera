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
    public partial class IssueCertificate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["type"] == null || Session["type"].ToString() != "0")
            {
                Response.Redirect("AccessDenied.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            calcGrade();
            issuCertif();
        }

        protected void issuCertif()
        {
            try
            {


                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand issueCert = new SqlCommand("InstructorIssueCertificateToStudent", conn);
                issueCert.CommandType = CommandType.StoredProcedure;

                issueCert.Parameters.Add(new SqlParameter("@cid", Int32.Parse(cId.Text)));
                issueCert.Parameters.Add(new SqlParameter("@sid", Int32.Parse(sId.Text)));
                issueCert.Parameters.Add(new SqlParameter("@issueDate", DateTime.Parse(issDate.Text)));
                issueCert.Parameters.Add(new SqlParameter("@insId", Session["user"]));
                conn.Open();
                issueCert.ExecuteNonQuery();
                conn.Close();
                errMsg.Text = "Certificate issued successfully";
            }
            catch (Exception)
            {
                errMsg.Text = "something went wrong  , please check your inputs";
            }

        }

        protected void calcGrade()
        {
            try
            {


                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand calcG = new SqlCommand("calculateFinalGrade", conn);
                calcG.CommandType = CommandType.StoredProcedure;

                calcG.Parameters.Add(new SqlParameter("@cid", Int32.Parse(cId.Text)));
                calcG.Parameters.Add(new SqlParameter("@sid", Int32.Parse(sId.Text)));

                calcG.Parameters.Add(new SqlParameter("@insId", Session["user"]));
                conn.Open();
                calcG.ExecuteNonQuery();
                conn.Close();
                
            }
            catch (Exception)
            {
                errMsg.Text = "something went wrong  , please check your inputs";
            }

        }
    }
}