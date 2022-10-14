<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Music_App.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        *{
             margin:0;
             padding:0;
             box-sizing:border-box;
             font-family: 'Popins',sans-serif;
         }
         body{
             display:flex;
             justify-content:center;
             align-items:center;
             min-height:100vh;
             background:#23242a;
         }
         #box{
             position:relative;
             width:380px;
             height: 490px;
             background: #1c1c1c;
             border-radius: 8px;
             overflow:hidden;
         }
         #box::before{
             content:'';
             position:absolute;
             top:-50%;
             left:-50%;
             width:380px;
             height:490px;
             background: linear-gradient(0deg,transparent,#45f3ff,#45f3ff);
             transform-origin:bottom right;
             animation: animate 6s linear infinite;
         }
         #box::after{
             content:'';
             position:absolute;
             top:-50%;
             left:-50%;
             width:380px;
             height:490px;
             background: linear-gradient(0deg,transparent,#45f3ff,#45f3ff);
             transform-origin:bottom right;
             animation: animate 6s linear infinite;
             animation-delay: -3s;
         }
         @keyframes animate{
             0%{
                 transform: rotate(0deg);
             }
             100%{
                 transform: rotate(360deg); 
             }
         }
         #form{
             position:absolute;
             inset:2px;
             border-radius: 8px;
             background: #28292d;
             z-index: 10;
             padding: 50px 40px;
             display:flex;
             flex-direction:column;
         }
         #form h2{
             color:#45f3ff;
             font-weight:500;
             text-align:center;
             letter-spacing:0.1em;
         }
         .inputBox{
             position:relative;
             width:300px;
             margin-top:35px;
         }
         .inputBox .input{
             position:relative;
             width:100%;
             padding:20px 10px 10px;
             background:transparent;
             border:none;
             outline:none;
             color:#23242a;
             font-size:1em;
             letter-spacing:0.05em;
             z-index:10;
         }
         .inputBox span{
             position:absolute;
             left:0;
             padding:13px 0px 10px;
             font-size:1em;
             color:#8f8f8f;
             pointer-events:none;
             letter-spacing:0.05em;
             transition:0.5s;
         }
         .inputBox .input:valid ~ span,
         .inputBox .input:focus ~ span{
             color:#45f3ff;
             transform: translateX(0px) translateY(-34px);
             font-size:0.75em;
         }
         .inputBox i{
             position:absolute;
             left:0;
             bottom:0;
             width:100%;
             height:2px;
             background: #45f3ff;
             border-radius:4px;
             transition:0.5s;
             pointer-events:none;
             z-index:9;
         }
         .inputBox .input:valid ~ i,
         .inputBox .input:focus ~ i{
             height:44px;
         }
         .links{
             display:flex;
             justify-content:space-between;
         }
         .links a{
             margin: 10px 0;
             font-size: 1em;
             color: #8f8f8f;
             text-decoration:none;
         }
         .links a:hover,
         .links a:nth-child(2){
             color: #45f3ff;
         }
         #Button_login[type="submit"]{
             border:none;
             outline:none;
             background: #45f3ff;
             padding: 11px 25px;
             width: 100px;
             margin-top: 10px;
             border-radius:4px;
             font-weight:600;
             cursor:pointer;
         }
         #Button_login{
             font-size:15px;
         }
         #Button_login[type="submit"]:active{
             opacity:0.8;
         }
    </style>
</head>
<body>
    <div id="box">
        <div id="form">
            <form id="form1" runat="server">
            <h2>Sign In</h2>
                <br />
            <div class="error" id="msg" runat="server">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Username is required" ControlToValidate="UserLogin" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="PasswordLogin" ErrorMessage="Password is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
                <div class="inputBox">
                 <%--   <input type="text" required="required" id="UserLogin" /> --%>
                    <asp:TextBox ID="UserLogin" CssClass="input" runat="server"></asp:TextBox>
                    <span style="font-size:15px">Username</span>
                    <i></i>
                </div>
                <div class="inputBox">
                   <%--   <input type="password" required="required" id="PasswordLogin" /> --%>
                    <asp:TextBox ID="PasswordLogin" CssClass="input" runat="server" TextMode="Password"></asp:TextBox>
                    <span style="font-size:15px">Password</span>
                    <i></i>
                </div>
                <div class="links">
                    <a href="#">Forgot Password</a>
                    <a href="Registration.aspx">SignUp</a>
                </div>
                <asp:Button ID="Button_login" runat="server" OnClick="Button_login_Click" Text="SignIn" Width="106px"></asp:Button>
            </form>
        </div>
    </div>
</body>
</html>
