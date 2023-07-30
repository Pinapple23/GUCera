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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["type"] != null )
            {
               if(Session["type"].ToString() == "0")
                {
                    Response.Redirect("instructor.aspx");
                }else if (Session["type"].ToString() == "1")
                {
                    Response.Redirect("admin.aspx");
                }
                else
                {
                    Response.Redirect("viewprofile.aspx");
                }
            }
        }

     

        protected void RegisterUser(object sender, EventArgs e)
        {  
            //create a new connection 
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String fname = firstName.Text;
            String lname = lastName.Text;
            String pass = password.Text;
            String mail = Email.Text;
            String userGender = gender.SelectedValue.ToString();
            String Address = address.Text;
      

            SqlCommand regproc; 
            if (userType.SelectedValue.ToString() =="Student")
            {
                 regproc = new SqlCommand("studentRegister", conn);
            }
            else
            {
                 regproc = new SqlCommand("InstructorRegister", conn);
            }
           
            regproc.CommandType = CommandType.StoredProcedure;
            regproc.Parameters.Add(new SqlParameter("@first_Name", fname));
            regproc.Parameters.Add(new SqlParameter("@last_Name", lname));
            regproc.Parameters.Add(new SqlParameter("@password", pass));
            regproc.Parameters.Add(new SqlParameter("@email", mail));
            regproc.Parameters.Add(new SqlParameter("@address", Address));
            regproc.Parameters.Add(new SqlParameter("@gender", userGender));

            
            try
            {
                if (fname == "" || lname == "" || pass == "" || mail == "" || Address == "" )
                {
                    errorMsg.Text = "User data cannot be empty";
                    errorMsg.Visible = true;
                }
                else
                {
                conn.Open();
                regproc.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("login.aspx");
                }
                
            }
            catch ( Exception err )
            {
                errorMsg.Text = "Email Already Registered ! please use another Email";
                errorMsg.Visible = true; 
            }
           
            








        }
    }
}