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
    public partial class Phones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["type"] == null )
            {
                Response.Redirect("AccessDenied.aspx");
            }
        }

        protected void add_number(object sender, EventArgs e)
        {
            //create a new connection 
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String number = phoneNumber.Text;
            SqlCommand phoneproc;
            phoneproc = new SqlCommand("addMobile", conn);
            phoneproc.CommandType = CommandType.StoredProcedure;
            phoneproc.Parameters.Add(new SqlParameter("@id", Session["user"]));
            phoneproc.Parameters.Add(new SqlParameter("@mobile_number", number));
            if(phoneNumber.Text == "")
            {
                errorMsg.Text = "Cannot add empty number";
                errorMsg.Visible = true;
            }else if (phoneNumber.Text.Length > 11)
            {
                errorMsg.Text = "Number cannot exceed 11 digits ";
                errorMsg.Visible = true;
            }
            else
            {
                conn.Open();
                phoneproc.ExecuteNonQuery();
                errorMsg.Text = "Number Added successfully";
                errorMsg.Visible = true;
                conn.Close();
            }
           
            



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