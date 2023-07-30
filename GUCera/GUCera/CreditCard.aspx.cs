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
    public partial class CreditCard : System.Web.UI.Page
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

        }

        protected void add_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
               
                string number = ccNO.Text;
                string cardH = CHname.Text;
    
                string cvv = CV.Text;
                SqlCommand Card = new SqlCommand("addCreditCard", conn);
                Card.CommandType = CommandType.StoredProcedure;
                Card.Parameters.Add(new SqlParameter("@sid", Session["user"]));
                Card.Parameters.Add(new SqlParameter("@number", number));
                Card.Parameters.Add(new SqlParameter("@cardHolderName", cardH));
                Card.Parameters.Add(new SqlParameter("@expiryDate", DateTime.Parse(EXP.Text) ));
                Card.Parameters.Add(new SqlParameter("@cvv", cvv));

                conn.Open();
                Card.ExecuteNonQuery();
                conn.Close();

                errMsg.Text = "card added successfully";
            }
            catch (Exception)
            {
                errMsg.Text = "something went wrong";
            }

        }
    }
}