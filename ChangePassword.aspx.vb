Imports System.ComponentModel.DataAnnotations

Public Class ChangePassword
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    Protected Sub ChangeBtn_Click(sender As Object, e As EventArgs) Handles ChangeBtn.Click
        Using dbContext As New Model1()
            Dim username As String = Session("Name")
            Dim newUser = dbContext.Users.FirstOrDefault(Function(u) u.Username = username)

            If newUser.Password <> oldpass.Text Then
                Label16.Text = "old password doesn't match"
            Else

                newUser.Password = passwordTextBox.Text
                newUser.ConfirmPassword = confirmPasswordTextBox.Text


                Dim validationResults As New List(Of ValidationResult)()
                Dim validationContext As New ValidationContext(newUser, Nothing, Nothing)
                Validator.TryValidateObject(newUser, validationContext, validationResults, True)

                If validationResults.Count > 0 Then
                    ' Validation failed, handle the errors
                    Dim validationMessages As New StringBuilder()
                    For Each result As ValidationResult In validationResults
                        validationMessages.Append(result.ErrorMessage)
                        validationMessages.Append("<br>")
                    Next

                    Label16.Text = validationMessages.ToString()

                    'Dim validationMessagesDiv As Literal = DirectCast(FindControl("validationMessages"), Literal)
                    'If validationMessagesDiv IsNot Nothing Then
                    '    validationMessagesDiv.Text = validationMessages.ToString()
                    'End If
                Else
                    dbContext.SaveChanges()
                    ' Optionally, you can redirect the user to a different page after successful registration
                    Response.Redirect("Login.aspx")

                End If

            End If

        End Using



    End Sub

End Class