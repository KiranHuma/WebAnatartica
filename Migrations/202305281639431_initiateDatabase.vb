Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class initiateDatabase
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Users",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Username = c.String(),
                        .Password = c.String(),
                        .Email = c.String(),
                        .Firstname = c.String(),
                        .Lastname = c.String(),
                        .Role = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.Users")
        End Sub
    End Class
End Namespace
