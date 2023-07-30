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
    public partial class InstViewAssignments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["type"] == null || Session["type"].ToString() != "0")
            {
                Response.Redirect("AccessDenied.aspx");
            }
            //loads list of all courses accepted 
            loadList();


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


        

        


        protected void loadTable()
        {

            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand assignLoadProc = new SqlCommand("InstructorViewAssignmentsStudents", conn);
            assignLoadProc.CommandType = CommandType.StoredProcedure;

            // getting the cid 
            String query = "SELECT id FROM Course WHERE Course.name =" + "'" + CourseList.SelectedItem.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            int id;

            if (reader.Read())
            {
                id = reader.GetInt32(reader.GetOrdinal("id"));
                assignLoadProc.Parameters.Add(new SqlParameter("@instrId", Session["user"]));
                assignLoadProc.Parameters.Add(new SqlParameter("@cid", id));
            }
            reader.Close();


            // populating the table
            SqlDataAdapter da = new SqlDataAdapter(assignLoadProc);
            DataTable dt = new DataTable();
            da.Fill(dt);
            studentAssignments.DataSource = dt;
            studentAssignments.DataBind();


        }


        







        protected void courseSelect(object sender, EventArgs e)
        {
            //when selecting a course show all students of this course 
            
            
           
            loadTable();
            

        }

        

        protected void studentAssignments_SelectedIndexChanged(object sender, EventArgs e)
        {
            //handling the selection of student to edit his grade 

        }

        

        protected void Grade(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            
            SqlCommand gradeProc = new SqlCommand("InstructorgradeAssignmentOfAStudent ", conn);
            gradeProc.CommandType = CommandType.StoredProcedure;

            
            //getting row values
            GridViewRow row = studentAssignments.SelectedRow;
            string AssignType = row.Cells[4].Text;
            int AssignNumber = Int32.Parse(row.Cells[3].Text);
            int CourseID = Int32.Parse(row.Cells[2].Text);
            int studId = Int32.Parse(row.Cells[1].Text);
            //-----------

            gradeProc.Parameters.Add(new SqlParameter("@instrId", Session["user"]));
            gradeProc.Parameters.Add(new SqlParameter("@cid", CourseID));
            gradeProc.Parameters.Add(new SqlParameter("@grade", Decimal.Parse(grade.Text.ToString())));
            gradeProc.Parameters.Add(new SqlParameter("@sid", studId));
            gradeProc.Parameters.Add(new SqlParameter("@assignmentNumber", AssignNumber));
            gradeProc.Parameters.Add(new SqlParameter("@type", AssignType));

            conn.Open();
            gradeProc.ExecuteNonQuery();
            loadTable();
            conn.Close();

        }
    }
}