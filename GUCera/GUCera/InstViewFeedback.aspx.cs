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
    public partial class InstViewFeedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["type"] == null || Session["type"].ToString() != "0")
            {
                Response.Redirect("AccessDenied.aspx");
            }
            loadList();
        }
        protected void loadFeedback()
        {

            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand feedbackProc = new SqlCommand("ViewFeedbacksAddedByStudentsOnMyCourse ", conn);
            feedbackProc.CommandType = CommandType.StoredProcedure;

            // getting the cid 
            String query = "SELECT id FROM Course WHERE Course.name =" + "'" + CourseList.SelectedItem.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            int id;

            if (reader.Read())
            {
                id = reader.GetInt32(reader.GetOrdinal("id"));
                feedbackProc.Parameters.Add(new SqlParameter("@instrId", Session["user"]));
                feedbackProc.Parameters.Add(new SqlParameter("@cid", id));
            }
            reader.Close();


            // populating the table
            SqlDataAdapter da = new SqlDataAdapter(feedbackProc);
            DataTable dt = new DataTable();
            da.Fill(dt);
            studentFeedback.DataSource = dt;
            studentFeedback.DataBind();


        }
        protected void loadList()
        {

            //create a new connection 
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand instViewCoursesProc = new SqlCommand("InstructorViewAcceptedCoursesByAdmin", conn);
            instViewCoursesProc.Parameters.Add(new SqlParameter("@instrId", Session["user"]));

            instViewCoursesProc.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader rdr = instViewCoursesProc.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                String courseName = rdr.GetString(rdr.GetOrdinal("name"));
                CourseList.Items.Add(new ListItem(courseName));


            }
            conn.Close();
        }
        protected void courseSelect(object sender, EventArgs e)
        {
            //when selecting a course show all students of this course 

            loadFeedback();
            
            


        }
    }
}