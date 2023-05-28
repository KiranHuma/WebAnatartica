<%@ Page Title="Register" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" 
    
    CodeBehind="Register.aspx.vb"
    
    
    Inherits="WebAnatartica.Register" %>

    <asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <pstyle=" text-align: left;"><asp:Label ID="Label16" runat="server" Text="Label">Check</asp:Label> </pstyle=">
    
    <p style=" text-align: left;"><asp:Label ID="Label1" align="center" runat="server" Text="Label">First Name</asp:Label> </p>
   <p style=" text-align: left;"> <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></p>


    <p style=" text-align: left;"><asp:Label ID="Label2" runat="server" Text="Label">Last Name</asp:Label> </p>
    <p style=" text-align: left;"><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></p>

 <p style=" text-align: left;"><asp:Label ID="Label3" runat="server" Text="Label">User Name</asp:Label> </p>
 <p style=" text-align: left;"><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>   </p>

    <p style=" text-align: left;"><asp:Label ID="Label4" runat="server" Text="Label">Email</asp:Label> </p>
     <p style=" text-align: left;"><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></p>


        <p style=" text-align: left;"><asp:Label ID="Label5" runat="server" Text="Label">Password</asp:Label> </p>
    <p style=" text-align: left;"><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></p>
    
    
    <p style=" text-align: left;"><asp:Label ID="Label6" runat="server" Text="Label">Confirm Password</asp:Label> </p>
    <p style=" text-align: left;"><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></p>
     
     

  

  
</asp:Content>
