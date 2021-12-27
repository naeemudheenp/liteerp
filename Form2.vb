Imports System.Data
Imports System.Data.OleDb
Public Class Form2
    Dim adp As OleDbDataAdapter
    Dim cn As New OleDbConnection
    Dim strConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & System.Environment.CurrentDirectory & "\product.mdb;Jet OLEDB:Database Password=Carcarcar@1085;"
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Hide()
        mainscreen.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("PLEASE FILL THE FIELDS")
            GoTo lt
        End If

        adp = New OleDbDataAdapter("SELECT * FROM SECURITY", cn)
        adp.UpdateCommand = New OleDbCommand("UPDATE security SET username = '" & TextBox1.Text & "' WHERE ID=1;", cn)
        adp.UpdateCommand.ExecuteNonQuery()
        adp.UpdateCommand = New OleDbCommand("UPDATE security SET pin = '" & TextBox2.Text & "' WHERE ID=1;", cn)
        adp.UpdateCommand.ExecuteNonQuery()
        MsgBox("PASSWORD UPDATED")
        TextBox1.Text = ""
        TextBox2.Text = ""
        Me.Hide()
lt:
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = strconnectionstring
        cn.Open()
        adp = New OleDbDataAdapter("SELECT * FROM ventureinfo", cn)
        adp.SelectCommand = New OleDbCommand("SELECT * FROM ventureinfo", cn)
        adp.SelectCommand.ExecuteNonQuery()
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