using NAudio.Wave;
using System;
using System.Threading;
using WMPLib;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Web.UI.WebControls;

namespace Music_App
{
    
    public partial class Index : System.Web.UI.Page
    {
        readonly private static WindowsMediaPlayer player = new WindowsMediaPlayer();
        static bool isFirstTime = true;
        //string url;
        //    public byte[] showImage(Int32 empid)
        //    {
        //        //SqlConnection myconnection = new SqlConnection('Server=localhost;uid=sa;password=;database=northwind;');
        //        SqlConnection myconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);

        //        SqlCommand mycommand = new SqlCommand("select img from Songs where Id=1", myconnection);
        //        myconnection.Open();
        //        SqlDataReader dr = mycommand.ExecuteReader();
        //        dr.Read();
        //        byte[] imgbyte = (byte[])dr["img"];
        //        return imgbyte;

        //    }
        protected void Page_Load(object sender, EventArgs e)
        { 
            //url = lblMsg.Text;
            
            //byte[] data = showImage(2);
            //Int32 offset = 78;
            //System.IO.MemoryStream mstream = new System.IO.MemoryStream();
            //mstream.Write(data, offset, data.Length - offset);
            //System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(mstream);
            //bmp.Save(Server.MapPath("sample.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg);
            //mstream.Close();
            //Image1.ImageUrl = Server.MapPath('sample.jpeg');

            //string cs = ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString;
            //using (SqlConnection con = new SqlConnection(cs))
            //{
            //    SqlCommand cmd = new SqlCommand("Select img from Songs where id=1", con);

            //    //cmd.CommandType = CommandType.StoredProcedure;
            //    con.Open();
            //    byte[] bytes = (byte[])cmd.ExecuteScalar();
            //    string strBase64 = Convert.ToBase64String(bytes);
            //    Image1.ImageUrl = "data:Image/jpg;base64," + strBase64;
               
            //}
        }
        protected void Get_Image(object sender, EventArgs e)
        {
            //string sConn = System.Configuration.ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ToString();
            //SqlConnection objConn = new SqlConnection(sConn);
            //objConn.Open();
            //string sTSQL = "select img from Songs where Id=1";
            //SqlCommand objCmd = new SqlCommand(sTSQL, objConn);
            //objCmd.CommandType = CommandType.Text;
            //object data = objCmd.ExecuteScalar();
            //objConn.Close();
            //objCmd.Dispose();

            //Context.Response.BinaryWrite((byte[])data);



        }

        protected void GetUrl(string url)
        {

        }
        protected void Play_Click(object sender, EventArgs e)
        {
            //Response.Write(player.playState);
            if (isFirstTime)
            {
                string url = Session["songName"].ToString();
                //Response.Write(url);
                string extention = ".mp3";
                url = String.Concat(url,extention);
                url = url.Replace(" ", "");
                //Response.Write(url);
                //player.URL = lblMsg.Text;
                //player.URL = "C:\\Users\\Dell\\source\\repos\\Music_App\\Music_App\\Static\\Songs\\" +url+".mp3";
                player.URL = "C:\\Users\\Dell\\source\\repos\\Music_App\\Music_App\\Static\\Songs\\" + url;
                //Response.Write(player.playState);
                isFirstTime = false;
            }
            else
            {
                player.controls.play();
                //Response.Write(player.playState);
            }
        }

        protected void Pause_Click(object sender, EventArgs e)
        {
            player.controls.pause();
        }

        protected void Stop_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }
    }
}