using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;


namespace Music_App
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender,EventArgs e)
        {

        }
        protected void Button_login_Click(object sender,EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
            conn.Open();

            string checkUser = "Select count(*) from UserData Where UserName= '" + UserLogin.Text + "'";
            SqlCommand cmd = new SqlCommand(checkUser, conn);
            int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            conn.Close();
            if (temp == 1)
            {
                conn.Open();
                string checkPassowrdQuery = "select Password from UserData where UserName='" + UserLogin.Text + "'";
                SqlCommand com = new SqlCommand(checkPassowrdQuery, conn);
                string password = com.ExecuteScalar().ToString().Replace(" ", "");
                if (password == PasswordLogin.Text)
                {
                    Response.Write("Hovlbnj,mnbv");
                    Session["UserName"] = UserLogin.Text;
                    /*Response.Write("Password is correct");*/
                    Response.Redirect("SongList.aspx");
                }
                else
                {
                    /*Response.Write("Password is not correct");*/
                    msg.InnerHtml = "<span style='color:red'>Password is not correct</span>";
                }


            }
            else
            {
               /* Response.Write("Username is not correct");*/
                msg.InnerHtml = "<span style='color:red'>Username is not correct</span>";
            }

            conn.Close();
        }
    }
}