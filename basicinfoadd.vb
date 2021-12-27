Imports System.Data
Imports System.Data.OleDb
Public Class basicinfoadd
    Dim adp As OleDbDataAdapter
    Dim cn As New OleDbConnection
    Dim strConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & System.Environment.CurrentDirectory & "\product.mdb;Jet OLEDB:Database Password=Carcarcar@1085;"


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("ALL THE FIELDS ARE IMPORTANT.")

            GoTo ed
        End If
        Try
            adp.InsertCommand = New OleDbCommand("INSERT INTO ventureinfo VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')", cn)
            adp.InsertCommand.ExecuteNonQuery()
            MsgBox("Information updated")
            Me.Hide()
            mainscreen.Show()
        Catch ex As Exception
            MsgBox("error")
        End Try


ed:
    End Sub

    Public Sub basicinfoadd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cn.ConnectionString = strconnectionstring
        cn.Open()
        adp = New OleDbDataAdapter("SELECT * FROM ventureinfo", cn)
        adp.SelectCommand = New OleDbCommand("SELECT * FROM ventureinfo", cn)
        adp.SelectCommand.ExecuteNonQuery()
        Dim ds As New DataSet
        adp.Fill(ds)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

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