Public Class page_3
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Role") = "Admin" Or Session("Role") = "Manager" Then

        Else
            Response.Redirect("login.aspx")
        End If
    End Sub

End Class