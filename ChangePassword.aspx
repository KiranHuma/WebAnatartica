<%@ Page Title="Register" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" 
    
    CodeBehind="ChangePassword.aspx.vb"
    Inherits="WebAnatartica.ChangePassword" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
   
    <div class="container">
       <div class="text-danger"> <asp:Label ID="Label16" runat="server" Text=""></asp:Label> </div>
        

     <asp:Label ID="Label1" runat="server" Text="Label">Old Password</asp:Label>
    <asp:TextBox ID="oldpass" TextMode="Password" runat="server"  CssClass="form-control"></asp:TextBox>

     <asp:Label ID="Label5" runat="server" Text="Label">Password</asp:Label>
    <asp:TextBox ID="passwordTextBox" TextMode="Password" runat="server"  CssClass="form-control"></asp:TextBox>
    
    
    <asp:Label ID="Label6" runat="server" Text="Label">Confirm Password</asp:Label> 
    <asp:TextBox ID="confirmPasswordTextBox" TextMode="Password" runat="server"  CssClass="form-control"></asp:TextBox>
   
        
        <asp:Button CssClass="btn btn-primary" ID="ChangeBtn" runat="server" Text="ChangePassword" />
        
</div>
    
     
     

  

  
</asp:Content>
