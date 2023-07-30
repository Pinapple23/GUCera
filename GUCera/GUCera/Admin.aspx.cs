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
    public partial class AdminViewCourses : System.Web.UI.Page
    {

        
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["type"] == null || Session["type"].ToString() != "1")
            {
                Response.Redirect("AccessDenied.aspx");
            }
            loadTable();

            // load not accepted course here 
            loadNotAccepted();

            







        }

        protected void loadTable()
        {

            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand adminViewCourses = new SqlCommand("AdminViewAllCourses", conn);
            adminViewCourses.CommandType = CommandType.StoredProcedure;

            // getting 


            // populating the table
            SqlDataAdapter da = new SqlDataAdapter(adminViewCourses);
            DataTable dt = new DataTable();
            da.Fill(dt);
            allCourses.DataSource = dt;
            allCourses.DataBind();


        }

        protected void loadNotAccepted()
        {

            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand viewNotAccepted = new SqlCommand("AdminViewNonAcceptedCourses", conn);
            viewNotAccepted.CommandType = CommandType.StoredProcedure;

            

            // populating the table
            SqlDataAdapter da = new SqlDataAdapter(viewNotAccepted);
            DataTable dt = new DataTable();
            da.Fill(dt);
            notAccepted.DataSource = dt;
            notAccepted.DataBind();


        }


        protected void AcceptCourse(object sender, EventArgs e)
        {

            try
            {
                //create a new connection 
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                //sssssssssssssssssss
                SqlCommand acceptCourse = new SqlCommand("AdminAcceptRejectCourse", conn);
                acceptCourse.CommandType = CommandType.StoredProcedure;
                acceptCourse.Parameters.Add(new SqlParameter("@adminid", Session["user"]));
                //trial ---------------------------------
                GridViewRow row = notAccepted.SelectedRow;
                String query = "SELECT id FROM Course WHERE Course.name =" + "'" + row.Cells[1].Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                int id;

                if (reader.Read())
                {
                    id = reader.GetInt32(reader.GetOrdinal("id"));
                    acceptCourse.Parameters.Add(new SqlParameter("@courseId", id));
                }

                //------------------------------

                 

                conn.Close();
                conn.Open();
                acceptCourse.ExecuteNonQuery();
                loadNotAccepted();
                errMsg.Text = "Course Accepted successfully";
                conn.Close();
            }
            catch (Exception)
            {

               
            }
        }

        

       

        protected void addCode(object sender, EventArgs e)
        {

            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand addPromo = new SqlCommand("AdminCreatePromocode", conn);
                addPromo.CommandType = CommandType.StoredProcedure;


                addPromo.Parameters.Add(new SqlParameter("@code ", Code.Text));
                addPromo.Parameters.Add(new SqlParameter("@discount ", Discount.Text));


                addPromo.Parameters.Add(new SqlParameter("@isuueDate ", DateTime.Parse(Issue.Text)));
                addPromo.Parameters.Add(new SqlParameter("@expiryDate ", DateTime.Parse(Expiry.Text)));
                // edit this to session["user']****************************
                addPromo.Parameters.Add(new SqlParameter("@adminId", Session["user"]));
                conn.Open();
                addPromo.ExecuteNonQuery();
                currCode.Text = Code.Text;
                errMsg0.Text = "promo code created successfully";
                conn.Close();
            }
            catch (Exception)
            {

                errMsg0.Text = "something went wrong check your inputs";
            }
        }

        protected void issueCode(object sender, EventArgs e)
        {
            try
            {

            
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand issuePromo = new SqlCommand("AdminIssuePromocodeToStudent", conn);
            issuePromo.CommandType = CommandType.StoredProcedure;

            issuePromo.Parameters.Add(new SqlParameter("@sid  ", Int32.Parse(stId.Text ) ) ) ;
            issuePromo.Parameters.Add(new SqlParameter("@pid  ", Code.Text));
            conn.Open();
            issuePromo.ExecuteNonQuery();
            
            errMsg1.Text = "promo code issued successfully to student" ;
            conn.Close();
            }catch(Exception)
            {
                errMsg1.Text = "something went wrong  , please check your inputs";
            }

        }
    }
}