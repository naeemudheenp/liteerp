Imports System.Data
Imports System.Data.OleDb
Public Class CUSTOMER
    Dim adp As OleDbDataAdapter
    Dim cn As New OleDbConnection
    Dim strConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & System.Environment.CurrentDirectory & "\product.mdb;Jet OLEDB:Database Password=Carcarcar@1085;"
    Dim ds As New DataSet
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        adp.SelectCommand = New OleDbCommand("SELECT * FROM  cus ;", cn)
        adp.SelectCommand.ExecuteNonQuery()
        ds.Reset()
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
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
        adp.UpdateCommand = New OleDbCommand("UPDATE cus SET ename= '" & DataGridView1.Rows(nrow).Cells(1).Value & "',erating= '" & DataGridView1.Rows(nrow).Cells(2).Value & "',ecredit= '" & DataGridView1.Rows(nrow).Cells(3).Value & "', edebit = '" & DataGridView1.Rows(nrow).Cells(4).Value & "',emobile = '" & DataGridView1.Rows(nrow).Cells(5).Value & "' WHERE id = '" & ncnt & "';", cn)
        adp.UpdateCommand.ExecuteNonQuery()
        MsgBox("DATA UPDATED!")
        ds.Reset()
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Refresh()
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
            adp.DeleteCommand = New OleDbCommand("DELETE FROM cus WHERE id = '" & ncnt & "';", cn)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("COMPLETE THE BOXES ")
            Exit Sub
        End If
        adp.SelectCommand = New OleDbCommand("SELECT * FROM  cus WHERE ID= '" & TextBox1.Text & "';", cn)
        adp.SelectCommand.ExecuteNonQuery()
        Dim ERRORCHCK As OleDbDataReader = adp.SelectCommand.ExecuteReader
        If ERRORCHCK.Read = True Then
            MsgBox("EMPLOYEE WITH THIS ITEM CODE ALREADY INPUTED")
            Exit Sub
        End If
        ERRORCHCK.Close()
        adp.InsertCommand = New OleDbCommand("INSERT INTO cus(ID,ename) values('" & TextBox1.Text & "','" & TextBox2.Text & "')", cn)
        adp.InsertCommand.ExecuteNonQuery()
        MsgBox("DATA UPDATED")
        adp.SelectCommand = New OleDbCommand("SELECT * FROM  cus;", cn)
        adp.SelectCommand.ExecuteNonQuery()
        ds.Reset()
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)

        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)
        Me.Hide()
        mainscreen.Show()
    End Sub

    Private Sub CUSTOMER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProductDataSet4.cus' table. You can move, or remove it, as needed.

        cn.ConnectionString = strconnectionstring
        cn.Open()
        adp = New OleDbDataAdapter("SELECT * FROM cus", cn)
        adp.SelectCommand = New OleDbCommand("SELECT * FROM cus", cn)
        adp.SelectCommand.ExecuteNonQuery()

        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams
            cp = MyBase.CreateParams
            cp.ExStyle = 0 * 2000000

            Return cp
        End Get
    End Property

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class