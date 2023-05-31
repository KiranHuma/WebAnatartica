Public Class SiteMaster
    Inherits MasterPage
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Session("Authenticated") = "true" Then
            loginBtn.Visible = False ' Show the button if the session value exists
            logoutBtn.Visible = True ' Show the button if the session value exists
            usernameLbl.Visible = True
            usernameLbl.Text = "Hi! " + Session("Name")
            aboutmenu.Visible = True
        Else
            loginBtn.Visible = True ' Show the button if the session value exists
            logoutBtn.Visible = False ' Show the button if the session value exists
            usernameLbl.Visible = False
            usernameLbl.Text = ""
            aboutmenu.Visible = False
        End If
    End Sub
End Class