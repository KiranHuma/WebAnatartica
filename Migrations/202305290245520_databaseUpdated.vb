Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class databaseUpdated
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Users", "ConfirmPassword", Function(c) c.String())
            AlterColumn("dbo.Users", "Username", Function(c) c.String(nullable := False))
            AlterColumn("dbo.Users", "Password", Function(c) c.String(nullable := False))
            AlterColumn("dbo.Users", "Email", Function(c) c.String(nullable := False))
        End Sub
        
        Public Overrides Sub Down()
            AlterColumn("dbo.Users", "Email", Function(c) c.String())
            AlterColumn("dbo.Users", "Password", Function(c) c.String())
            AlterColumn("dbo.Users", "Username", Function(c) c.String())
            DropColumn("dbo.Users", "ConfirmPassword")
        End Sub
    End Class
End Namespace
