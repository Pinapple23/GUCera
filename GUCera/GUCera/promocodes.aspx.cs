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
    public partial class promocodes : System.Web.UI.Page
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
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand promocode = new SqlCommand("viewPromocode", conn);
                promocode.CommandType = CommandType.StoredProcedure;
                promocode.Parameters.Add(new SqlParameter("@sid", Session["user"]));

                conn.Open();


                SqlDataReader rdr = promocode.ExecuteReader(CommandBehavior.CloseConnection);

                errMsg.Text = "No Promocodes to be found";
                errMsg.Visible = true;
                while (rdr.Read())
                {
                    String co = rdr.GetString(rdr.GetOrdinal("code"));
                    
                    
                    DateTime idate = rdr.GetDateTime(rdr.GetOrdinal("isuueDate"));
                    
                   

                    DateTime edate = rdr.GetDateTime(rdr.GetOrdinal("expiryDate"));
                   
                    

                    decimal dis = rdr.GetDecimal(rdr.GetOrdinal("discount"));
                    
                   

                    Label promoCode = new Label();
                    promoCode.Text = "Code Name : "+ co + "   Issue Date : " + idate + "   End Date : " +edate + "   Discount : " + dis +"<br>" + "<br>"; 
                    form1.Controls.Add(promoCode);
                    errMsg.Text = "found these promocodes ";
                }
                
                errMsg.Visible = true;
            }
            catch (Exception)
            {
                 errMsg.Text = "No Promocodes found";
                 errMsg.Visible = true;
            }


            }
        }
    }
