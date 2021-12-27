Imports System.Data
Imports System.Data.OleDb
Public Class donations
    Dim adp As OleDbDataAdapter
    Dim cn As New OleDbConnection
    Dim strConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & System.Environment.CurrentDirectory & "\product.mdb;Jet OLEDB:Database Password=Carcarcar@1085;"
    Dim ds As New DataSet
    Private Sub donations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProductDataSet3.donations' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'ProductDataSet3.donations' table. You can move, or remove it, as needed.


        cn.ConnectionString = strConnectionString
        cn.Open()
        adp = New OleDbDataAdapter("SELECT * FROM donations", cn)
        adp.SelectCommand = New OleDbCommand("SELECT * FROM donations", cn)
        adp.SelectCommand.ExecuteNonQuery()
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)


    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If DataGridView1.RowCount = 1 Then
            MsgBox("NOTHING SELECTED")
            Exit Sub
        End If
        Try
            Dim nrow As String 'delete varaible
            Dim ncnt As String
            nrow = DataGridView1.CurrentRow.Index
            ncnt = DataGridView1.Rows(nrow).Cells(0).Value
            adp.DeleteCommand = New OleDbCommand("DELETE FROM donations WHERE customername = '" & ncnt & "';", cn)
            adp.DeleteCommand.ExecuteNonQuery()
            MsgBox("DATA DELETED")
            ds.Reset()
            adp.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.Refresh()





        Catch ex As Exception
            MsgBox("INTERNAL ERROR! TRY AGAIN LATER")
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        cn.Close()
        donations_add.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_2(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button_report_Click(sender As Object, e As EventArgs) Handles Button_report.Click
        donations_report.show
    End Sub
End Class