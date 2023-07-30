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
    public partial class viewprofile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["type"] == null || Session["type"].ToString() != "2")
            {
                Response.Redirect("AccessDenied.aspx");
            }

            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand profile = new SqlCommand("viewMyProfile", conn);
            profile.CommandType = CommandType.StoredProcedure;
            profile.Parameters.Add(new SqlParameter("@id", Session["user"]));

            conn.Open();

        
           SqlDataReader rdr = profile.ExecuteReader(CommandBehavior.CloseConnection);
           if (rdr.Read()) {
                String fname = rdr.GetString(rdr.GetOrdinal("firstName"));
                //Label pinfo = new Label();
                FNAME.Text = fname;
                //form1.Controls.Add(pinfo);

                String lname = rdr.GetString(rdr.GetOrdinal("lastName"));
                //Label lastn = new Label();
                LNAME.Text = lname;
               // form1.Controls.Add(lastn);

                String mail = rdr.GetString(rdr.GetOrdinal("email"));
                //Label m = new Label();
                EMAIL.Text = mail;

                String add = rdr.GetString(rdr.GetOrdinal("address"));
                ADDRESS.Text = add;
                Boolean gen =  rdr.GetBoolean(  rdr.GetOrdinal("gender")  );
                if(gen ==  true )
                {
                   gender.Text = "Male";
                }
                else
                { gender.Text = "Female";
                    
                }
               
                String pw = rdr.GetString(rdr.GetOrdinal("password"));
                pass.Text = pw;
            }
            conn.Close();

        }
    }
}