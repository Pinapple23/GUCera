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
    public partial class EditCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["type"] == null || Session["type"].ToString() != "0")
            {
                Response.Redirect("AccessDenied.aspx");
            }
            loadList();
        }

        protected void Apply(object sender, EventArgs e)
        {

            try
            {
                //create a new connection 
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            //sssssssssssssssssss
            SqlCommand defineAssign = new SqlCommand("DefineAssignmentOfCourseOfCertianType", conn);
            defineAssign.CommandType = CommandType.StoredProcedure;
            defineAssign.Parameters.Add(new SqlParameter("@instId", Session["user"]));
           
            defineAssign.Parameters.Add(new SqlParameter("@number ", Number.Text));
            defineAssign.Parameters.Add(new SqlParameter("@type ", Type.SelectedItem.Text));
            defineAssign.Parameters.Add(new SqlParameter("@fullGrade ", Grade.Text));
            defineAssign.Parameters.Add(new SqlParameter("@weight ", Weight.Text));
            defineAssign.Parameters.Add(new SqlParameter("@deadline ", DateTime.Parse(Deadline.Text)));
            defineAssign.Parameters.Add(new SqlParameter("@content ", Content.Text));
            //---------------------------------
            String query = "SELECT id FROM Course WHERE Course.name =" + "'" + CoursesList.SelectedItem.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            int cid;

            if (reader.Read())
            {
                cid = reader.GetInt32(reader.GetOrdinal("id"));
                defineAssign.Parameters.Add(new SqlParameter("@cid ", cid));
            }

            //------------------------------

            //int id = Int32.Parse(NotAcceptedList.SelectedValue) ; 

            conn.Close();
            
            
                conn.Open();
                defineAssign.ExecuteNonQuery();
                errMsg.Text = "Assignment added successfully";
                conn.Close();
            }catch(Exception err)
            {
                errMsg.Text = "Something went wrong , please check your inputs are valid";
            }
            
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
                CoursesList.Items.Add(new ListItem(courseName));


            }
            conn.Close();
        }
    }
}