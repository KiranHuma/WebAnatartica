Imports System.ComponentModel.DataAnnotations
Imports System.Data.SqlClient
Imports System.Reflection.Emit

Public Class Register
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub RegisterBtn_Click(sender As Object, e As EventArgs) Handles RegisterBtn.Click


        Dim newUser As New User()
        newUser.Firstname = firstNameTextBox.Text
        newUser.Lastname = lastNameTextBox.Text
        newUser.Username = userNameTextBox.Text
        newUser.Password = passwordTextBox.Text
        newUser.ConfirmPassword = confirmPasswordTextBox.Text
        newUser.Email = emailTextBox.Text

        'Dim selectedDate As Date
        'If Date.TryParse(Request.Form("myDateInput"), selectedDate) Then
        '    newUser.DateOfBirth = selectedDate
        'End If
        newUser.DateOfBirth = dob.Text
        newUser.City = city.Text
        newUser.Country = country.Text
        newUser.UserID = details.Text
        newUser.Gender = gender.Text
        newUser.Role = roleDropdown.Text


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
            Using dbContext As New Model1()
                Dim user = dbContext.Users.FirstOrDefault(Function(u) u.Username = newUser.Username)

                If user IsNot Nothing Then
                    Label16.Text = "Username already in the databse."
                Else
                    dbContext.Users.Add(newUser)
                    dbContext.SaveChanges()
                    ' Optionally, you can redirect the user to a different page after successful registration
                    Response.Redirect("Login.aspx")
                End If

            End Using

        End If





    End Sub


    Protected Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click

        firstNameTextBox.Text = ""
        lastNameTextBox.Text = ""
        userNameTextBox.Text = ""
        passwordTextBox.Text = ""
        confirmPasswordTextBox.Text = ""
        emailTextBox.Text = ""
        city.Text = ""
        country.Text = ""
        details.Text = ""
    End Sub
End Class


