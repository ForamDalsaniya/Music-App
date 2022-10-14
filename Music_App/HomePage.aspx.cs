using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
//using Windows.UI.Xaml;
//using Windows.UI.Xaml.Controls;
//using Windows.UI.Xaml.Controls.Primitives;
/*using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;*/
//using Windows.UI.Xaml.Media;
using WMPLib;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;
using System.Reflection;

namespace Music_App
{
    public partial class HomePage : System.Web.UI.Page
    {
        readonly private static WindowsMediaPlayer player = new WindowsMediaPlayer();
        static bool isFirstTime = true;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write("<span style='color:white'>Hellooo</span>");
            //WindowsMediaPlayer winmp = new WindowsMediaPlayer();
            //winmp.URL = "Static/Songs/RaatBhar.mp3";
            //winmp.controls.play();
            //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
            //conn.Open();

            //string checkUser = "Select count(*) from Artist";
            //SqlCommand cmd = new SqlCommand(checkUser, conn);
            //int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            //conn.Close();
        }

        protected void Play_Button(object sender, EventArgs e)
        
        {
            Response.Write(player.playState);
            if (isFirstTime)
            {
                player.URL = "C:\\Users\\Dell\\source\\repos\\Music_App\\Music_App\\Static\\Songs\\RaatBhar.mp3";
                //Response.Write(player.playState);
                isFirstTime = false;
            }
            else
            {
                player.controls.play();
                //Response.Write(player.playState);
            }
    
            //Response.Write("<span style='color:white'>Hellooo</span>");
            //WindowsMediaPlayer winmp = new WindowsMediaPlayer();
            //winmp.URL = "Static/Songs/RaatBhar.mp3";
            //winmp.controls.play();
        }
        protected void Pause_Button(object sender, EventArgs e)
        {
            //if (player.playState == WMPPlayState.wmppsPlaying)
            //{
                player.controls.pause();
                //Response.Write(player.playState);
            //}
        }

        protected void Stop_Button(object sender, EventArgs e)
        {
            player.controls.stop();
        }
    }
}