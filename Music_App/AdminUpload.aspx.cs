using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Music_App
{
    public partial class AdminUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(FileUpload1.HasFile && FileUpload2.HasFile)
            {
                string fileExtention1 = System.IO.Path.GetExtension(FileUpload1.FileName);
                string fileExtention2 = System.IO.Path.GetExtension(FileUpload2.FileName);

                if (fileExtention2.ToLower() != ".mp3")
                {
                    lblMessage.Text = "Only files with .mp3 extention is allowed";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    FileUpload1.SaveAs(Server.MapPath("~/Static/Images/" + FileUpload1.FileName));
                    FileUpload2.SaveAs(Server.MapPath("~/Static/Songs/" + FileUpload2.FileName));

                    string path1 = Server.MapPath("~/Static/Images/" + FileUpload1.FileName);
                    //string path2 = Server.MapPath("~/Static/Songs/" + FileUpload2.FileName);

                    byte[] imageByte = System.IO.File.ReadAllBytes(path1);
                    //byte[] songByte = System.IO.File.ReadAllBytes(path2);

                    using (SqlConnection connection = new SqlConnection())
                    {
                        connection.ConnectionString = ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ToString();
                        connection.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;

                        //string commandText = "Insert into Images values (@Rollno,@image,getdate())";
                        //string commandText1 = "update Songs set img=@image where id=1";
                        //string commandText2 = "update Songs set song=@song where id=1";
                        string commandText = "Insert into Songs values(@songName,@catagory,@releaseDate,@img)";
                        cmd.CommandText = commandText;
                        cmd.Parameters.Add("@songName", songName.Text);
                        cmd.Parameters.Add("@catagory", catagory.Text);
                        cmd.Parameters.Add("@releaseDate", releaseDate.Text);
                        cmd.Parameters.Add("@img", SqlDbType.VarBinary);
                        //cmd.CommandText = commandText1;
                        //cmd.CommandText = commandText2;
                        //cmd.CommandType = CommandType.Text;
                        //cmd.Parameters.Add("@image", SqlDbType.VarBinary);
                        //cmd.Parameters.Add("@song", SqlDbType.VarBinary);
                        cmd.Parameters["@img"].Value = imageByte;
                        //cmd.Parameters["@song"].Value = songByte;
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        connection.Close();
                    }
                    Response.Redirect("Index.aspx");
                }
            }
            else
            {
                lblMessage.Text = "Please, Select file for upload";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
            //if (!FileUpload1.HasFile || !FileUpload2.HasFile) //Validation  
            //{
            //    Response.Write("No file Selected"); return;
            //}
            //else
            //{
                //string filename = FileUpload1.PostedFile.FileName;
                //string filename = (FileUpload1.PostedFile.FileName);
                //string filename2 = (FileUpload2.PostedFile.FileName);
                //string ath = HttpContext.Current.Request.PhysicalApplicationPath + FileUpload1.FileName;
                //Response.Write(ath);
                //string path = Path.GetFileName(FileUpload1.PostedFile.FileName);
                //FileUpload1.SaveAs(Server.MapPath("Static/" + path));
                //string path2 = Path.GetFileName(FileUpload2.PostedFile.FileName);
                //FileUpload2.SaveAs(Server.MapPath("Static/" + path2));
                //string filepath = Server.MapPath(path);
                //string filepath2 =Server.MapPath(path2);

                ////convert the image into the byte  
                //byte[] imageByte = System.IO.File.ReadAllBytes(filepath);
                //byte[] imageByte2 = System.IO.File.ReadAllBytes(filepath2);

                ////Insert the Data in the Table  
                //using (SqlConnection connection = new SqlConnection())
                //{
                //    connection.ConnectionString = ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ToString();
                //    connection.Open();
                //    SqlCommand cmd = new SqlCommand();
                //    cmd.Connection = connection;

                //    //string commandText = "Insert into Images values (@Rollno,@image,getdate())";
                //    string commandText = "update Songs set img=@image where id=1";
                //    string commandText2 = "update Songs set song=@song where id=1";

                //    cmd.CommandText = commandText;
                //    cmd.CommandText = commandText2;
                //    cmd.CommandType = CommandType.Text;
                //    //cmd.CommandType = CommandType.Text;
                //    cmd.Parameters.Add("@image", SqlDbType.VarBinary);
                //    cmd.Parameters.Add("@song", SqlDbType.VarBinary);
                //    cmd.Parameters["@image"].Value = imageByte;
                //    cmd.Parameters["@song"].Value = imageByte2;
                //    //cmd.Parameters.Add("@Rollno", SqlDbType.VarChar);
                //    //cmd.Parameters["@Rollno"].Value = txtrollno.Text;
                //    cmd.ExecuteNonQuery();
                //    cmd.Dispose();
                //    connection.Close();
                   

                //    Response.Write("Data has been Added");
                //}
            //}
        }
    }
}