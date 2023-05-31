Imports System
Imports System.Data.Entity
Imports System.Linq

Public Class Model1
    Inherits DbContext

    ' Your context has been configured to use a 'Model1' connection string from your application's 
    ' configuration file (App.config or Web.config). By default, this connection string targets the 
    ' 'WebAnatartica.Model1' database on your LocalDb instance. 
    ' 
    ' If you wish to target a different database and/or database provider, modify the 'Model1' 
    ' connection string in the application configuration file.
    Public Sub New()
        ' MyBase.New(ConfigurationManager.ConnectionStrings("myConString").ConnectionString)
        MyBase.New("Data Source=DESKTOP-QH67LSN\SQLEXPRESS;Initial Catalog=antartica_animalsDB;Integrated Security=True")
    End Sub


    ' Add a DbSet for each entity type that you want to include in your model. For more information 
    ' on configuring and using a Code First model, see http:'go.microsoft.com/fwlink/?LinkId=390109.
    Public Overridable Property Users() As DbSet(Of User)

End Class

'Public Class MyEntity
'    Public Property Id() As Int32
'    Public Property Name() As String
'End Class
