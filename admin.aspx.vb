Imports System.Data.Entity
Imports Microsoft.VisualBasic.ApplicationServices

Public Class admin
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Role") = "Admin" Then
            BindGridData()
        Else
            Response.Redirect("login.aspx")
        End If
    End Sub

    Protected Sub BindGridData()
        Dim dt As New DataTable()
        Using dbContext As New Model1()
            Dim data = dbContext.Users.ToList()
            users.Text = data.Count.ToString()


            If data IsNot Nothing AndAlso data.Count > 0 Then

                dt.Columns.Add("Action", "Action".GetType)
                ' Add columns to the DataTable based on the properties of your entity
                For Each propInfo As Reflection.PropertyInfo In data(0).GetType().GetProperties()
                    ' Skip specific properties by checking their names

                    If propInfo.Name <> "Password" AndAlso propInfo.Name <> "ConfirmPassword" Then
                        dt.Columns.Add(propInfo.Name, propInfo.PropertyType)
                    End If
                    'Dim deleteButton As New Button()
                    'deleteButton.Text = "Delete"
                    'deleteButton.CommandName = "Delete"
                    'deleteButton.CommandArgument = e.Row.RowIndex.ToString()
                    'AddHandler deleteButton.Command, AddressOf DeleteButton_Command
                    'e.Row.Cells(0).Controls.Add(deleteButton)
                Next

                ' Add rows to the DataTable
                For Each entity As User In data
                    Dim row As DataRow = dt.NewRow()

                    For Each propInfo As Reflection.PropertyInfo In entity.GetType().GetProperties()
                        ' Skip specific properties by checking their names
                        If propInfo.Name <> "Password" AndAlso propInfo.Name <> "ConfirmPassword" Then
                            row(propInfo.Name) = propInfo.GetValue(entity)
                        End If
                    Next

                    dt.Rows.Add(row)
                Next
            End If

            GridView1.DataSource = dt
            GridView1.CssClass = "table table-striped table-bordered"
            GridView1.DataBind()

            GridView1.HeaderRow.TableSection = TableRowSection.TableHeader
            GridView1.UseAccessibleHeader = True
            GridView1.HeaderRow.CssClass = "header-class"
        End Using
    End Sub
    Protected Sub GridView1_RowDataBound(ByVal sender As Object, ByVal e As GridViewRowEventArgs) Handles GridView1.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            ' Add Delete button
            Dim deleteButton As New Button()
            deleteButton.Text = "Delete"
            deleteButton.CommandName = "Delete"
            Dim idValue As String = DataBinder.Eval(e.Row.DataItem, "Id").ToString()

            ' Set the CommandArgument for the edit button as a combination of rowIndex and Id
            Dim rowIndex As Integer = e.Row.RowIndex
            deleteButton.CommandArgument = rowIndex.ToString() & "|" & idValue

            'deleteButton.CommandArgument = e.Row.RowIndex.ToString()
            AddHandler deleteButton.Command, AddressOf DeleteButton_Command
            e.Row.Cells(0).Controls.Add(deleteButton)

            ' Add Edit button
            Dim editButton As New Button()
            editButton.Text = "Change Role"
            editButton.CommandName = "Delete"
            'editButton.CommandArgument = e.Row.RowIndex.ToString()
            editButton.CommandArgument = e.Row.RowIndex.ToString() & "|" & idValue
            AddHandler editButton.Command, AddressOf EditButton_Command
            e.Row.Cells(0).Controls.Add(editButton)
        End If
    End Sub

    Protected Sub DeleteButton_Command(ByVal sender As Object, ByVal e As CommandEventArgs)
        Dim arguments As String() = e.CommandArgument.ToString().Split("|"c)
        Dim rowIndex As Integer = Convert.ToInt32(arguments(0))
        Dim idValue As Integer = arguments(1)
        Using dbContext As New Model1()
            Dim userToDelete = dbContext.Users.Find(idValue)
            If userToDelete IsNot Nothing Then
                dbContext.Users.Remove(userToDelete)
                dbContext.SaveChanges()
            End If
        End Using

    End Sub

    Protected Sub EditButton_Command(ByVal sender As Object, ByVal e As CommandEventArgs)
        Dim arguments As String() = e.CommandArgument.ToString().Split("|"c)
        Dim rowIndex As Integer = Convert.ToInt32(arguments(0))
        Dim idValue As Integer = arguments(1)

        Using dbContext As New Model1()
            Dim userToEdit = dbContext.Users.Find(idValue)
            If userToEdit IsNot Nothing Then
                If (userToEdit.Role = "Admin") Then
                    userToEdit.Role = "Manager"  ' Modify the properties as needed
                Else
                    userToEdit.Role = "Admin"
                End If
                dbContext.SaveChanges()
            End If
        End Using
    End Sub
    Protected Sub GridView1_RowEditing(ByVal sender As Object, ByVal e As GridViewEditEventArgs) Handles GridView1.RowEditing
        'GridView1.EditIndex = e.NewEditIndex
        'BindGridView()
        BindGridData()
    End Sub
    Protected Sub GridView1_RowDeleting(ByVal sender As Object, ByVal e As GridViewDeleteEventArgs) Handles GridView1.RowDeleting
        Dim rowIndex As Integer = e.RowIndex
        'Dim arguments As String() = e.CommandArgument.ToString().Split("|"c)
        'Dim rowIndex As Integer = Convert.ToInt32(arguments(0))
        'Dim idValue As String = arguments(1)
        ' Delete logic here based on the row index or data keys
        ' For example, you can retrieve the data key value and perform the delete operation
        'Dim keyValue As String = GridView1.DataKeys(rowIndex).Value.ToString()
        'DeleteData(keyValue)
        'BindGridView()
        BindGridData()
    End Sub
End Class