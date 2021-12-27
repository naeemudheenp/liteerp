Imports System.Data
Imports System.Data.OleDb
Public Class password
    Dim adp As OleDbDataAdapter
    Dim cn As New OleDbConnection
    Dim strConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & System.Environment.CurrentDirectory & "\product.mdb;Jet OLEDB:Database Password=Carcarcar@1085;"
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        End
    End Sub

    Private Sub password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = strconnectionstring
        cn.Open()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        adp = New OleDbDataAdapter("SELECT * FROM PRODUCTS", cn)
        adp.SelectCommand = New OleDbCommand("SELECT * FROM SECURITY WHERE ID=1", cn)
        adp.SelectCommand.ExecuteNonQuery()
        Dim DS As New DataSet
        adp.Fill(DS)
        Dim US As String
        Dim PS As String
        US = DS.Tables(0).Rows(0)("username")
        PS = DS.Tables(0).Rows(0)("pin")
        If US = TextBox1.Text And PS = TextBox2.Text Then
            mainscreen.Show()
            Me.Hide()
        Else
            MsgBox("INVALID CREDENTIALS")
            Exit Sub
        End If
    End Sub
End Class