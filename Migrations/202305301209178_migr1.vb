Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class migr1
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Users", "DateOfBirth", Function(c) c.DateTime(nullable := False))
            AddColumn("dbo.Users", "City", Function(c) c.String())
            AddColumn("dbo.Users", "Country", Function(c) c.String())
            AddColumn("dbo.Users", "Details", Function(c) c.String())
            AddColumn("dbo.Users", "Gender", Function(c) c.String())
            AddColumn("dbo.Users", "Mobile", Function(c) c.String())
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.Users", "Mobile")
            DropColumn("dbo.Users", "Gender")
            DropColumn("dbo.Users", "Details")
            DropColumn("dbo.Users", "Country")
            DropColumn("dbo.Users", "City")
            DropColumn("dbo.Users", "DateOfBirth")
        End Sub
    End Class
End Namespace
