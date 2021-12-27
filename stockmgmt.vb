Imports System.Data
Imports System.Data.OleDb
Public Class stockmgmt
    Dim adp As OleDbDataAdapter
    Dim cn As New OleDbConnection
    Dim strConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & System.Environment.CurrentDirectory & "\product.mdb;Jet OLEDB:Database Password=Carcarcar@1085;"
    Dim ds As New DataSet
    Private Sub Label7_Click(sender As Object, e As EventArgs)
        Me.Hide()
        mainscreen.Show()
    End Sub

    Public Sub stockmgmt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'ProductDataSet11.products' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'ProductDataSet.products' table. You can move, or remove it, as needed.

        cn.ConnectionString = strconnectionstring
        cn.Open()
        adp = New OleDbDataAdapter("SELECT * FROM PRODUCTS", cn)
        adp.SelectCommand = New OleDbCommand("SELECT * FROM PRODUCTS", cn)
        adp.SelectCommand.ExecuteNonQuery()
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        DataGridView1.Refresh()
        ds.Reset()
        adp = New OleDbDataAdapter("SELECT * FROM SALES ", cn)
        adp.SelectCommand = New OleDbCommand("Select * from products where productname Like '%" & TextBox1.Text & "%' ", cn)
        adp.SelectCommand.ExecuteNonQuery()

        adp.Fill(ds)

        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Refresh()


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Button2.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DataGridView1.RowCount = 1 Then
            MsgBox("NOTHING SELECTED")
            Exit Sub
        End If
        Try
            Dim nrow As String 'delete varaible
            Dim ncnt As String
            nrow = DataGridView1.CurrentRow.Index
            ncnt = DataGridView1.Rows(nrow).Cells(0).Value
            adp.DeleteCommand = New OleDbCommand("DELETE FROM products WHERE id = '" & ncnt & "';", cn)
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If DataGridView1.RowCount = 1 Then
            MsgBox("NOTHING SELECTED")
            Exit Sub
        End If
        Dim nrow As String 'delete varaible
            Dim ncnt As String
            nrow = DataGridView1.CurrentRow.Index
            ncnt = DataGridView1.Rows(nrow).Cells(0).Value
        adp.UpdateCommand = New OleDbCommand("UPDATE products SET productname= '" & DataGridView1.Rows(nrow).Cells(1).Value & "',quantity= '" & DataGridView1.Rows(nrow).Cells(2).Value & "',price= '" & DataGridView1.Rows(nrow).Cells(4).Value & "', orginalprice = '" & DataGridView1.Rows(nrow).Cells(3).Value & "' WHERE id = '" & ncnt & "';", cn)
        adp.UpdateCommand.ExecuteNonQuery()
            MsgBox("DATA UPDATED!")
            ds.Reset()
            adp.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.Refresh()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try


            adp.SelectCommand = New OleDbCommand("SELECT * FROM products", cn)
            adp.SelectCommand.ExecuteNonQuery()
            MsgBox("DATA REFREASH")
            ds.Reset()
            adp.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.Refresh()





        Catch ex As Exception
            MsgBox("INTERNAL ERROR! TRY AGAIN LATER")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        addstock.Show()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

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