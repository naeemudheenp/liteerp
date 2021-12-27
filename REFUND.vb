Imports System.Data
Imports System.Data.OleDb
Public Class REFUND
    Dim adp As OleDbDataAdapter
    Public cn As New OleDbConnection
    Dim sdataset As New DataSet
    Dim pdataset As New DataSet
    Dim strConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & System.Environment.CurrentDirectory & "\product.mdb;Jet OLEDB:Database Password=Carcarcar@1085;"
    Private Sub REFUND_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = strconnectionstring
        cn.Open()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            DataGridView1.Refresh()
            sdataset.Reset()
            adp = New OleDbDataAdapter("SELECT * FROM SALES ", cn)
            adp.SelectCommand = New OleDbCommand("Select * from sales where SALESNUMBER Like '%" & TextBox1.Text & "%' ", cn)
            adp.SelectCommand.ExecuteNonQuery()

            adp.Fill(sdataset)

            DataGridView1.DataSource = sdataset.Tables(0)
            DataGridView1.Refresh()

            DataGridView1.Visible = True
        Catch ex As Exception
            MsgBox("SYNC ERROR")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DataGridView1.RowCount = 0 Then  'AS YOU KNOW
            MsgBox("SELECTION EMPTY")
            Exit Sub
        End If
        Dim varid As String
        Dim varsn As String
        Dim vardi As String
        Dim quantity As Integer
        Dim pqty As Integer
        Dim prods As New DataSet
        Dim adpdlt As New OleDbDataAdapter
        Dim productadp As New OleDbDataAdapter

        If DataGridView1.RowCount = 1 Then
            MsgBox("SELECTION EMPTY!")
            Exit Sub
        End If
        vardi = DataGridView1.CurrentRow.Index
        varid = DataGridView1.Rows(vardi).Cells(1).Value
        varsn = DataGridView1.Rows(vardi).Cells(0).Value
        quantity = DataGridView1.Rows(vardi).Cells(4).Value
        adpdlt = New OleDbDataAdapter("SELECT * FROM sales;", cn)
        productadp = New OleDbDataAdapter("SELECT * FROM sales;", cn)
        'Try
        productadp.SelectCommand = New OleDbCommand("SELECT * FROM products WHERE ID= '" & varid & "'", cn)
        productadp.SelectCommand.ExecuteNonQuery()
            productadp.Fill(prods)
        pqty = prods.Tables(0).Rows(0)("quantity")
        pqty = pqty + quantity
            productadp.UpdateCommand = New OleDbCommand("UPDATE products SET quantity= '" & pqty & "' WHERE ID= '" & varid & "';", cn)
            productadp.UpdateCommand.ExecuteNonQuery()
        ' Catch ex As Exception

        'End Try
        Try
            adpdlt.DeleteCommand = New OleDbCommand("DELETE FROM sales WHERE SALESNUMBER= '" & varsn & "' AND id= '" & varid & "';", cn)
            adpdlt.DeleteCommand.ExecuteNonQuery()
            MsgBox("DELETED")
        Catch ex As Exception
            MsgBox("INTERNAL ERROR ! TRY AGAIN LATER")
        Exit Sub
        End Try
        adp.SelectCommand = New OleDbCommand("SELECT * FROM SALES;", cn)
        adp.SelectCommand.ExecuteNonQuery()
        sdataset.Reset()
        adp.Fill(sdataset)
        DataGridView1.DataSource = sdataset.Tables(0)
        DataGridView1.Refresh()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams
            cp = MyBase.CreateParams
            cp.ExStyle = 0 * 2000000

            Return cp
        End Get
    End Property
End Class