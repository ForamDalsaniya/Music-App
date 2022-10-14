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
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*if (IsPostBack)
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
                conn.Open();

                string checkUser = "Select count(*) from UserData Where UserName= '" + UserName.Text + "'";
                SqlCommand cmd = new SqlCommand(checkUser, conn);
                int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                Response.Write("Hello everyone....." + temp);
                if (temp == 1)
                {
                    Response.Write("<span style='color:white'>Username already taken</span>");
                }

                conn.Close();
            }*/
        }

        protected void Button_signup_Click(object sender, EventArgs e)
        {
            try
            {
                Guid newGUID = Guid.NewGuid();
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
                conn.Open();
                string checkUser = "Select count(*) from UserData Where UserName= '" + UserName.Text + "'";
                SqlCommand com = new SqlCommand(checkUser, conn);
                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            /*    Response.Write("Hello everyone....." + temp);*/
                if (temp == 1)
                {
                    /*Response.Write("<span style='color:white'>Username already taken</span>");*/
                    error.InnerHtml = "<span style='color:red'>Username already taken</span>";
                }
                else if (temp == 0)
                {
                string insertQuery = "Insert into UserData (Id,UserName, Email, Password) values (@ID, @uname, @emailID, @Password)";

                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@ID", newGUID.ToString());
                    cmd.Parameters.AddWithValue("@uname", UserName.Text);
                    cmd.Parameters.AddWithValue("@emailID", Email.Text);
                    cmd.Parameters.AddWithValue("@Password", Password.Text);
                    cmd.ExecuteNonQuery();
                   /*Response.Write("<span style='color:red'>Username already taken</span>");*/

                   /* Response.Write("Registration Successful");*/
                    Response.Redirect("Login.aspx");

                    conn.Close();
//
                }
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.ToString());
            }
        }
    }
}