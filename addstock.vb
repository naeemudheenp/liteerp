Imports System.Data
Imports System.Data.OleDb
Public Class addstock
    Dim adp As OleDbDataAdapter
    Dim cn As New OleDbConnection
    Dim strConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & System.Environment.CurrentDirectory & "\product.mdb;Jet OLEDB:Database Password=Carcarcar@1085;"

    Private Sub MAINMENUToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles MAINMENUToolStripMenuItem.Click
        Me.Hide()
        mainscreen.Show()
    End Sub

    Private Sub addstock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = strconnectionstring
        cn.Open()
        adp = New OleDbDataAdapter("SELECT * FROM ventureinfo", cn)
        adp.SelectCommand = New OleDbCommand("SELECT * FROM ventureinfo", cn)
        adp.SelectCommand.ExecuteNonQuery()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Hide()
        mainscreen.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Please Enter All Values")
            Exit Sub
        End If
        adp.SelectCommand = New OleDbCommand("SELECT * FROM PRODUCTS WHERE id= '" & TextBox1.Text & "'", cn)
        adp.SelectCommand.ExecuteNonQuery()
        Dim ERRORCHCK As OleDbDataReader = adp.SelectCommand.ExecuteReader
        If ERRORCHCK.Read = True Then
            MsgBox("PRODUCT WITH THIS ITEM CODE ALREADY INPUTED")
            Exit Sub
        End If
        Try
            adp.InsertCommand = New OleDbCommand("INSERT INTO products values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')", cn)
            adp.InsertCommand.ExecuteNonQuery()
            MsgBox("DATA UPDATED")
        Catch ex As Exception
            MsgBox("DATA FAILED")
        End Try
        TextBox1.Text=""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox3.Text = -1
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = -1
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Hide()
        stockmgmt.Show()


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