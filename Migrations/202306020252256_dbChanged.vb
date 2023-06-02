Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class dbChanged
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Users", "UserID", Function(c) c.String())
            DropColumn("dbo.Users", "Details")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.Users", "Details", Function(c) c.String())
            DropColumn("dbo.Users", "UserID")
        End Sub
    End Class
End Namespace
