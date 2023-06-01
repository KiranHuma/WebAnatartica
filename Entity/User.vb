Imports System.ComponentModel.DataAnnotations

Public Class User
    Public Property Id As Integer
    <Required(ErrorMessage:="Username is required.")>
    Public Property Username As String
    <Required(ErrorMessage:="Password is required.")>
    Public Property Password As String

    <Compare("Password", ErrorMessage:="Passwords do not match.")>
    <RegularExpression("^.*(?=.{8,})(?=.*[@])(?=.*[0-9])(?=.*[a-zA-Z]).*$",
        ErrorMessage:="Password must contain at least 1 special character (@), 1 digit, and have a minimum length of 8 characters.")>
    Public Property ConfirmPassword As String

    <Required(ErrorMessage:="Email is required.")>
    <EmailAddress(ErrorMessage:="Invalid email address.")>
    Public Property Email As String
    Public Property Firstname As String
    Public Property Lastname As String
    <Required(ErrorMessage:="Date of birth is required.")>
    Public Property DateOfBirth As String
    Public Property City As String
    Public Property Country As String
    Public Property Details As String
    Public Property Gender As String
    Public Property Mobile As String
    Public Property Role As String

End Class
