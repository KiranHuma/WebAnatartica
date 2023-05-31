Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Reflection.Emit

Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Session.Clear()
    End Sub

    Protected Sub LoginButton_Click(sender As Object, e As EventArgs)

        Dim username As String = LoginUser.UserName
        Dim password As String = LoginUser.Password

        Using dbContext As New Model1()
            Dim user = dbContext.Users.FirstOrDefault(Function(u) u.Username = username And u.Password = password)

            If user IsNot Nothing Then
                Session("Name") = user.Username
                Session("Role") = user.Role
                Session("Email") = user.Email
                Session("Authenticated") = "true"
                If user.Role = "Admin" Then
                    Response.Redirect("admin.aspx")
                Else
                    Response.Redirect("default.aspx")
                End If

            Else
                LoginUser.FailureText = "Username or password is incorrect"
            End If

        End Using
    End Sub
End Class