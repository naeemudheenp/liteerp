Imports System.Data
Imports System.Data.OleDb
Public Class donations_add
    Dim connection_string = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & System.Environment.CurrentDirectory & "\product.mdb;Jet OLEDB:Database Password=Carcarcar@1085;"
    Dim connection As New OleDbConnection
    Dim databridge As OleDbDataAdapter

    Private Sub donations_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.ConnectionString = connection_string

        Try
            connection.Open()
        Catch ex As Exception
            MsgBox("Error101.Database not found")
        End Try


    End Sub

    Public Sub Button_add_Click(sender As Object, e As EventArgs) Handles Button_add.Click



        databridge = New OleDbDataAdapter("SELECT * FROM ventureinfo", connection)
        databridge.InsertCommand = New OleDbCommand("INSERT INTO donations(customername,amount,description) values ('" & TextBox_name.Text & "' ,'" & TextBox_amount.Text & "', '" & TextBox_description.Text & "' )", connection)

        databridge.InsertCommand.ExecuteNonQuery()
        MsgBox("Done")

    End Sub
End Class