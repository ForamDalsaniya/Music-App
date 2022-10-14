<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SongList.aspx.cs" Inherits="Music_App.SongList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RegistrationConnectionString %>" SelectCommand="SELECT * FROM [Songs]"></asp:SqlDataSource>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" DataKeyNames="Id">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" InsertVisible="False" ReadOnly="True" />
                    <asp:BoundField DataField="SongName" HeaderText="SongName" SortExpression="SongName" />
                    <asp:BoundField DataField="Catagory" HeaderText="Catagory" SortExpression="Catagory" />
                    <asp:BoundField DataField="ReleaseDate" HeaderText="ReleaseDate" SortExpression="ReleaseDate" />
                    <%--<asp:BoundField DataField="img" HeaderText="img" />--%>
                    <asp:TemplateField HeaderText="Image">
                                    <ItemTemplate>
                                        <asp:Image ID="woundimage" runat="server" ImageUrl='<%# "data:image/png;base64," + Convert.ToBase64String((byte[])Eval("img"))%>' Height="150px" Width="150px"></asp:Image>
                                    </ItemTemplate>
                                </asp:TemplateField>
                    <asp:ButtonField CommandName="Play_Click" Text="Play"/>
                    <asp:ButtonField CommandName="Pause_Click" Text="Pasue"/>
                    <asp:ButtonField CommandName="Stop_Click" Text="Stop"/>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
