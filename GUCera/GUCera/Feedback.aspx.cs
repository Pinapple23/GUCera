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
    public partial class Feedback : System.Web.UI.Page
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
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn3 = new SqlConnection(connStr);
                
                string StudentComment = your_Comment.Text;
                //int StudentID = Int32.Parse(Student_Id.Text);
                int CourseID = Int32.Parse(Course_Id.Text);
                

                SqlCommand AddYourFeedback = new SqlCommand("addFeedback", conn3);
                AddYourFeedback.CommandType = CommandType.StoredProcedure;
                AddYourFeedback.Parameters.Add(new SqlParameter("@comment", StudentComment));
                AddYourFeedback.Parameters.Add(new SqlParameter("@sid", Session["user"]));
                AddYourFeedback.Parameters.Add(new SqlParameter("@cid", CourseID));

                conn3.Open();
                AddYourFeedback.ExecuteNonQuery();
                conn3.Close();
                Label1.Text = " comment submitted ";
            }
            catch (Exception )
            {
                Label1.Text = " your inputs aren't correct";
            }



        }


    }
}