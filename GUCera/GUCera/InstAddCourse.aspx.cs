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
    public partial class AddCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["type"] == null || Session["type"].ToString() != "0")
            {
                Response.Redirect("AccessDenied.aspx");
            }
        }

        protected void addCourse(object sender, EventArgs e)
        {
            //create a new connection 
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            
            
           
                try
                {
                    String hrs = hours.Text;
                    String name = courseName.Text;
                    Double price = Double.Parse(coursePrice.Text.ToString());
                    SqlCommand addCourseProc;
                    addCourseProc = new SqlCommand("InstAddCourse", conn);
                    addCourseProc.CommandType = CommandType.StoredProcedure;
                    addCourseProc.Parameters.Add(new SqlParameter("@creditHours ", hrs));
                    addCourseProc.Parameters.Add(new SqlParameter("@name", name));
                    addCourseProc.Parameters.Add(new SqlParameter("@price", price));
                    addCourseProc.Parameters.Add(new SqlParameter("@instructorId ", Session["user"]));

                if (hrs.Length == 0 || name.Length == 0)
                {
                    errMsg.Text = "Course Details cannot be empty";
                    errMsg.Visible = true;
                }
                else if (price >= 9999.99)
                {
                    errMsg.Text = "Course price cannot exceed 9999.99";
                    errMsg.Visible = true;
                }
                else
                {

                    conn.Open();
                    addCourseProc.ExecuteNonQuery();
                    errMsg.Text = "Course Added successfully";
                    errMsg.Visible = true;
                    conn.Close();
                }
                }catch(Exception err)
                {
                    errMsg.Text = "Error Adding Course , check that course details meets specifications";
                    errMsg.Visible = true;
                }
                
            }

           






        }

       
    }
