<%@ Page Title="Register" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" 
    
    CodeBehind="Register.aspx.vb"
    Inherits="WebAnatartica.Register" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
   
    <div class="container">
       <div class="text-danger"> <asp:Label ID="Label16" runat="server" Text=""></asp:Label> </div>
        
            
        
    <asp:Label ID="Label1" align="center" runat="server" Text="Label">First Name</asp:Label> 
<asp:TextBox ID="firstNameTextBox" runat="server" CssClass="form-control"></asp:TextBox>


    <asp:Label ID="Label2" runat="server" Text="Label">Last Name</asp:Label> 
   <asp:TextBox ID="lastNameTextBox" runat="server"  CssClass="form-control"></asp:TextBox>

 <asp:Label ID="Label3" runat="server" Text="Label">User Name</asp:Label> 
 <asp:TextBox ID="userNameTextBox" runat="server"  CssClass="form-control"></asp:TextBox>   
    
        <asp:Label ID="Label4" runat="server" Text="Label">Email</asp:Label> 
    <asp:TextBox ID="emailTextBox"  runat="server"  CssClass="form-control"></asp:TextBox>


     <asp:Label ID="Label5" runat="server" Text="Label">Password</asp:Label>
    <asp:TextBox ID="passwordTextBox" TextMode="Password" runat="server"  CssClass="form-control"></asp:TextBox>
    
    
    <asp:Label ID="Label6" runat="server" Text="Label">Confirm Password</asp:Label> 
    <asp:TextBox ID="confirmPasswordTextBox" TextMode="Password" runat="server"  CssClass="form-control"></asp:TextBox>
      <asp:Label ID="Label7" runat="server" Text="Label">Date of Birth</asp:Label> 
    <asp:TextBox ID="dob" TextMode="Date" runat="server"  CssClass="form-control"></asp:TextBox>
      
        <asp:Label ID="Label8" runat="server" Text="Label">City</asp:Label> 
    <asp:TextBox ID="city"  runat="server"  CssClass="form-control"></asp:TextBox>
     
          <asp:Label ID="Label9" runat="server" Text="Label">Country</asp:Label> 
    <asp:TextBox ID="country"  runat="server"  CssClass="form-control"></asp:TextBox>


         <asp:Label ID="Label11" runat="server" Text="Label">Details</asp:Label> 
    <asp:TextBox ID="details"  runat="server"  CssClass="form-control"></asp:TextBox>

        <asp:DropDownList CssClass="form-control" ID="gender" runat="server">
            <asp:ListItem Text="Male" Value="Male"/>
            <asp:ListItem Text= "Female" Value="Female"/>
        </asp:DropDownList>

        <asp:DropDownList CssClass="form-control" ID="roleDropdown" runat="server">
            <asp:ListItem Text="Manager" Value="Manager"/>
            <asp:ListItem Text= "Admin" Value="Admin"/>
        </asp:DropDownList>
        <asp:Button CssClass="btn btn-primary"  ID="ResetBtn" runat="server" Text="Reset" />
        <asp:Button CssClass="btn btn-primary" ID="RegisterBtn" runat="server" Text="Register" />
        
</div>
    
     
     

  

  
</asp:Content>
