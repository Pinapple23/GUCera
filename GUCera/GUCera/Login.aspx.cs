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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["type"] != null)
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

        protected void login(object sender, EventArgs e)
        {   
            //create a new connection 
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            int id = 0; 
            try
            {
            id = Int32.Parse(username.Text);
            String pass = password.Text;
            SqlCommand loginproc = new SqlCommand("userLogin", conn);
            loginproc.CommandType = CommandType.StoredProcedure; 
            loginproc.Parameters.Add(new SqlParameter("@id", id));
            loginproc.Parameters.Add(new SqlParameter("@password", pass));
            SqlParameter success = loginproc.Parameters.Add("@success", SqlDbType.Int);
            SqlParameter type = loginproc.Parameters.Add("@type", SqlDbType.Int);

            success.Direction = ParameterDirection.Output;
              //outputs the type of user : admin , inst , student 
            type.Direction = ParameterDirection.Output;

            conn.Open();
            loginproc.ExecuteNonQuery();
            conn.Close();

            if(success.Value.ToString()== "1")
            {
                    Session["user"] = id;
                    Session["type"] = type.Value.ToString();
                    // use type to check where to redirect to 
                    // inst 0 admin 1  student : 2 
                    if (type.Value.ToString() == "0")
                    {
                        Response.Redirect("Instructor.aspx");
                    }
                    else if (type.Value.ToString() == "1")
                    {
                        Response.Redirect("Admin.aspx");
                    }
                    else
                    {

                        Response.Redirect("viewprofile.aspx");

                    }

                    //this shoud be done for recording current user  session id 
                    

                    // instead am doing this for debugging in instructor add course
                    //Session["user"] = 24; 


                    //Response.Redirect("Phones.aspx");
                   

                }
            else
            {
                errMsg.Text = "User doesn't exist please register";
                errMsg.Visible = true; 
            }

            }
            catch (Exception ex)
            {
                errMsg.Text = "User id must be of type int";
                errMsg.Visible = true;
            }






        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }
    }
}