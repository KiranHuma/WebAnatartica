Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class migr11
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AlterColumn("dbo.Users", "DateOfBirth", Function(c) c.String(nullable := False))
        End Sub
        
        Public Overrides Sub Down()
            AlterColumn("dbo.Users", "DateOfBirth", Function(c) c.DateTime(nullable := False))
        End Sub
    End Class
End Namespace
