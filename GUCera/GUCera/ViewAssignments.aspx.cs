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
    public partial class ViewAssignments : System.Web.UI.Page
    {
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
                loadTable();

                errMsg.Text = "";
            }
            catch(Exception)
            {
                errMsg.Text = "please enter a valid course id ";
               
            }
           

        }
        //------------------------------------------------------------------
        protected void loadTable()
        {

            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand viewAssignments = new SqlCommand("viewAssign", conn);
            viewAssignments.CommandType = CommandType.StoredProcedure;




            //studentLoadProc.Parameters.Add(new SqlParameter("@instrId", 24));
            //studentLoadProc.Parameters.Add(new SqlParameter("@cid", id));
            //string StudentId = Student_Id.Text;

            int CourseId = Int32.Parse(Course_Id.Text);
            viewAssignments.Parameters.Add(new SqlParameter("@Sid", Session["user"] ));
            viewAssignments.Parameters.Add(new SqlParameter("@courseId", CourseId));
            // populating the table
            SqlDataAdapter da = new SqlDataAdapter(viewAssignments);
            DataTable dt = new DataTable();
            da.Fill(dt);
            showMeNow.DataSource = dt;
            showMeNow.DataBind();
            conn.Close();


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

                SqlConnection conn1 = new SqlConnection(connStr);

                // Get the currently selected row using the SelectedRow property.
                GridViewRow row = showMeNow.SelectedRow;

                // And you respective cell's value
                    
                string AssignType = row.Cells[3].Text;
                int AssignNumber = Int32.Parse(row.Cells[2].Text);
                
                int CourseID = Int32.Parse(row.Cells[1].Text);

                SqlCommand SubmitAssignments = new SqlCommand("submitAssign", conn1);
                SubmitAssignments.CommandType = CommandType.StoredProcedure;
                SubmitAssignments.Parameters.Add(new SqlParameter("@assignType", AssignType));
                SubmitAssignments.Parameters.Add(new SqlParameter("@assignnumber", AssignNumber));
                SubmitAssignments.Parameters.Add(new SqlParameter("@sid", Session["user"]));
                SubmitAssignments.Parameters.Add(new SqlParameter("@cid", CourseID));

                conn1.Open();
                SubmitAssignments.ExecuteNonQuery();
                conn1.Close();
                errMsg.Text = "asignment submitted";
                
            }
            catch (Exception )
            {
                errMsg.Text = "cannot submit , please make sure you are selecting an assignment you haven't submitted already";

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
           try { 
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

                SqlConnection conn2 = new SqlConnection(connStr);

                GridViewRow row = showMeNow.SelectedRow;

                // And you respective cell's value

                string AssignType = row.Cells[3].Text;
                int AssignNumber = Int32.Parse(row.Cells[2].Text);

                int CourseID = Int32.Parse(row.Cells[1].Text);


                SqlCommand viewAssignmentGrades = new SqlCommand("viewAssignGrades", conn2);
                viewAssignmentGrades.CommandType = CommandType.StoredProcedure;
                viewAssignmentGrades.Parameters.Add(new SqlParameter("@assignType", AssignType));
                viewAssignmentGrades.Parameters.Add(new SqlParameter("@assignnumber", AssignNumber));
                viewAssignmentGrades.Parameters.Add(new SqlParameter("@sid", Session["user"]));
                viewAssignmentGrades.Parameters.Add(new SqlParameter("@cid", CourseID));



                SqlParameter AssignmetGrade = viewAssignmentGrades.Parameters.Add("@assignGrade", SqlDbType.Decimal);
                AssignmetGrade.Direction = ParameterDirection.Output;
                conn2.Open();
                viewAssignmentGrades.ExecuteNonQuery();
                conn2.Close();
                errMsg2.Text = "your grade is : "+ AssignmetGrade.Value.ToString();
            } catch (Exception err )
            {
                errMsg2.Text = "something went wrong, make sure you are selecting an assignment you submitted to view its grade";
            }


        }

        protected void showMeNow_SelectedIndexChanged(object sender, EventArgs e)
        {
            Button2.Enabled = true;
            Button3.Enabled = true;
        }

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
    }
}