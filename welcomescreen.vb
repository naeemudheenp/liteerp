Imports System.Data
Imports System.Data.OleDb
Public Class welcomescreen
    Dim adp As OleDbDataAdapter
    Dim cn As New OleDbConnection
    Dim strConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & System.Environment.CurrentDirectory & "\product.mdb;Jet OLEDB:Database Password=Carcarcar@1085;"
    Dim run As String
    Dim dt As OleDbDataAdapter


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dt = New OleDbDataAdapter("SELECT * FROM trial;", cn)
        adp = New OleDbDataAdapter("SELECT * FROM runtime", cn)
        adp.InsertCommand = New OleDbCommand("SELECT * FROM runtime", cn)
        adp.InsertCommand.ExecuteNonQuery()
        Dim ds As New DataSet
        adp.Fill(ds)
        run = ds.Tables(0).Rows(0)("ID").ToString

        If run = 0 Then


            dt = New OleDbDataAdapter("SELECT * FROM trial;", cn)
            dt.UpdateCommand = New OleDbCommand("UPDATE trial SET hr= '" & DateTime.Today & "' WHERE ID =1 ;", cn)
            dt.UpdateCommand.ExecuteNonQuery()
            Me.Hide()
            dialoqwelcome.Show()
        Else


            Me.Hide()
            password.Show()
            cn.Close()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub welcomescreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = strconnectionstring
        cn.Open()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        cn.Close()
        End

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

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