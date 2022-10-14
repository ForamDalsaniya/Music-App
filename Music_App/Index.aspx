<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Music_App.Index" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<%@ Import Namespace="System.Configuration" %>
<%@ Import Namespace="System.Data" %>
<!DOCTYPE html>
<% string url; %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
                   <table style="width:100%">
                       
        <% 
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);

            using (conn)
            {
                string oString = "Select SongName,img from Songs";
                SqlCommand oCmd = new SqlCommand(oString, conn);
                //oCmd.Parameters.AddWithValue("@Fname", fName);
                conn.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    //     byte[] bytes = (byte[])oCmd.ExecuteScalar();
                    //string strBase64 = Convert.ToBase64String(bytes);
                    //Image1.ImageUrl = "data:Image/jpg;base64," + strBase64;
                    while (oReader.Read())
                    {
                        byte[] bytes = (byte[])oReader["img"];
                        string strBase64 = Convert.ToBase64String(bytes);
                        Image1.ImageUrl = "data:Image/jpg;base64," + strBase64;

                        //byte[] songByte = (byte[])oReader["song"];
                        //string strBase64_2 = Convert.ToBase64String(songByte);
                        //string url = "data:Song/mp3;base64," + strBase64_2;
                        Session["songName"] = oReader["SongName"].ToString();
                        %>
                       <tr style="border:1px solid black">
                             <td style="border:1px solid black">
                                 <asp:Image ID="Image1" runat="server" Height="90px" Width="90px" />
                             </td> 
                             <td style="border:1px solid black">
                                 <h1 id="songName" ><%=oReader["SongName"].ToString() %></h1>
                             </td>
                        
                             <td style="border:1px solid black"> 
                                 <asp:Button ID="Play" Text="Play" runat="server" OnClick="Play_Click" />
                             </td>
                             <td style="border:1px solid black">
                                 <asp:Button ID="Pause" Text="Pause" runat="server" OnClick="Pause_Click" />
                             </td>
                             <td style="border:1px solid black">  
                                 <asp:Button ID="Stop" Text="Stop" runat="server" OnClick="Stop_Click" style="width: 49px" />
                             </td>
                        </tr>
                         
                    <%
                    //matchingPerson.lastName = oReader["LastName"].ToString();
                    }

                    conn.Close();
                }
            }
            %>
            
          </table>
                       </div>
    
        <br />
   
          <%--  <asp:Button runat="server" OnClick="Get_Image"/>--%>
    </form>
</body>
</html>
