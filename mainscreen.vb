Imports System.Data
Imports System.Data.OleDb
Public Class mainscreen
    Dim adp As OleDbDataAdapter
    Dim cn As New OleDbConnection
    Dim strConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & System.Environment.CurrentDirectory & "\product.mdb;Jet OLEDB:Database Password=Carcarcar@1085;"

    Private Sub mainscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Text = DateTime.Now
        cn.ConnectionString = strconnectionstring
        cn.Open()
        adp = New OleDbDataAdapter("SELECT * FROM ventureinfo", cn)
        adp.SelectCommand = New OleDbCommand("SELECT * FROM ventureinfo", cn)
        adp.SelectCommand.ExecuteNonQuery()
        Dim ds As New DataSet
        adp.Fill(ds)
        Label6.Text = ds.Tables(0).Rows(0)("shopname")
        Label7.Text = ds.Tables(0).Rows(0)("location")
        Label8.Text = ds.Tables(0).Rows(0)("mobile")
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        MsgBox("DEVELOPER : NAEEMUDHEEN ASLAM")
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) 
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        stockmgmt.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        addstock.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        EMPLOY.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        CUSTOMER.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AboutBox1.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form2.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        report.Show()
    End Sub
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams
            cp = MyBase.CreateParams
            cp.ExStyle = 0 * 2000000

            Return cp
        End Get
    End Property

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) 
        MsgBox("1.YOU CAN GIVE -1 TO QUANTITY WHEN YOUR ADDING THE PRODUCT WHICH IS NOT BASED ON QUANTITY(eg:in hotels most of the products does not need quantity).
2.INPUTING SAME ID NUMBER TO TWO PRODUCTS USING UPDATE BUTTON AFFECTS THE DATABASE.
3.NO APPLICATION IS FREE FROM BUGS IF YOU NOTICE ONE PLEASE INFORM.")
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click

        donations.Show()
    End Sub
End Class