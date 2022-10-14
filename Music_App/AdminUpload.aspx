<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminUpload.aspx.cs" Inherits="Music_App.AdminUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
       
            Song Name:
            <asp:TextBox ID="songName" runat="server"></asp:TextBox>
            <br />
            <br />
            Catagory:
            <asp:TextBox ID="catagory" runat="server"></asp:TextBox>
            <br />
            <br />
            Release Date:
            <asp:TextBox ID="releaseDate" runat="server" TextMode="Date"></asp:TextBox>
            <br />
            <br />
       
      Select Images  
      <asp:FileUpload ID="FileUpload1" runat="server" /> 
            <br />
            <br />
      Select Song
      <asp:FileUpload ID="FileUpload2" runat="server" />               
            <br />
            <br />
            <asp:Label ID="lblMessage" runat="server" Font-Bold="true"></asp:Label>
            <br />
       <br />   
       <asp:Button ID="Button1" runat="server"  
       Text="Upload" OnClick="Button1_Click" /> 
        </div>
    </form>
</body>
</html>
