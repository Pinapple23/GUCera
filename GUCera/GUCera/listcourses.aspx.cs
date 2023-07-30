using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace GUCERA
{
    public partial class listcourses : System.Web.UI.Page
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
            loadList();

            

        }
        protected void loadList()
        {

            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand viewNotAccepted = new SqlCommand("availableCourses", conn);
            viewNotAccepted.CommandType = CommandType.StoredProcedure;

            conn.Open();
            SqlDataReader rdr2 = viewNotAccepted.ExecuteReader(CommandBehavior.CloseConnection);

            ListItem def = new ListItem();
            def.Text = "Choose a course :";
            courseList.Items.Add(def);
            while (rdr2.Read())
            {
                String courseName2 = rdr2.GetString(rdr2.GetOrdinal("name"));

                ListItem li = new ListItem();
                li.Text = courseName2;

                courseList.Items.Add(li);


            }
            conn.Close();
        }

        protected void courseList_SelectedIndexChanged(object sender, EventArgs e)

        {   loadTable();
            courseList.Items.Clear();
            loadList();
            
        }
        protected void loadTable()
        {

            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand studentLoadProc = new SqlCommand("courseInformation", conn);
            studentLoadProc.CommandType = CommandType.StoredProcedure;

            // getting the cid 
            String query = "SELECT id FROM Course WHERE Course.name =" + "'" + courseList.SelectedItem.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            int id;

            if (reader.Read())
            {
                id = reader.GetInt32(reader.GetOrdinal("id"));
                studentLoadProc.Parameters.Add(new SqlParameter("@id", id));
                //studentLoadProc.Parameters.Add(new SqlParameter("@cid", id));
            }
            reader.Close();


            // populating the table
            SqlDataAdapter da = new SqlDataAdapter(studentLoadProc);
            DataTable dt = new DataTable();
            da.Fill(dt);
            courseInfo.DataSource = dt;
            courseInfo.DataBind();


        }

        protected void Enroll(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand EN = new SqlCommand("enrollInCourse", conn);
                EN.CommandType = CommandType.StoredProcedure;
                // Get the currently selected row using the SelectedRow property.
                GridViewRow row = courseInfo.SelectedRow;

                // And you respective cell's value
                int cId = Int32.Parse(row.Cells[1].Text);
                int instId = Int32.Parse(row.Cells[8].Text);
                EN.Parameters.Add(new SqlParameter("@sid", Session["user"]));
                EN.Parameters.Add(new SqlParameter("@cid", cId));
                EN.Parameters.Add(new SqlParameter("@instr", instId));
                conn.Open();
                EN.ExecuteNonQuery();
                conn.Close();
                errMsg.Text = "enrolled successfully in course "; 
            }catch(Exception err)
            {
                errMsg.Text = "something went wrong , check that you are not already enrolled";
            }
            
        }
    }
}