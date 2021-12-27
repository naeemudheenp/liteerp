Imports System.Data
Imports System.Data.OleDb
Public Class donations_report
    Dim connection_string = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & System.Environment.CurrentDirectory & "\product.mdb;Jet OLEDB:Database Password=Carcarcar@1085;"
    Dim connection As New OleDbConnection
    Dim databridge As OleDbDataAdapter
    Dim dataset As New DataSet
    Dim sum = 0

    Private Sub donations_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.ConnectionString = connection_string
        connection.Open()
        databridge = New OleDbDataAdapter("SELECT * FROM donation", connection)
        databridge.SelectCommand = New OleDbCommand("SELECT amount FROM donations", connection)
        databridge.SelectCommand.ExecuteNonQuery()
        databridge.Fill(dataset)
        datagrid.DataSource = dataset.Tables(0)
        For i = 0 To datagrid.Rows.Count - 1
            sum = sum + datagrid.Rows(i).Cells(0).Value
        Next
        TextBox1.Text = sum

    End Sub
End Class