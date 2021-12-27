Imports System.Data
Imports System.Data.OleDb
Public Class report
    Dim mdate As String

    Dim odate As String
    Dim mds As New DataSet
    Dim adp As OleDbDataAdapter
    Dim cn As New OleDbConnection
    Dim strConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & System.Environment.CurrentDirectory & "\product.mdb;Jet OLEDB:Database Password=Carcarcar@1085;"
    Private Sub Label10_Click(sender As Object, e As EventArgs) 
        Me.Hide()
        mainscreen.Show()
    End Sub

    Private Sub report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProductDataSet6.sales' table. You can move, or remove it, as needed.

        cn.ConnectionString = strconnectionstring
        cn.Open()
        adp = New OleDbDataAdapter("SELECT * FROM ventureinfo", cn)
        adp.SelectCommand = New OleDbCommand("SELECT * FROM ventureinfo", cn)
        adp.SelectCommand.ExecuteNonQuery()
    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = ""

        TextBox4.Text = ""
        mds.Reset()
        DataGridView1.DataSource = ""
        DataGridView1.Refresh()



        mdate = DateTimePicker1.Value
        odate = DateTimePicker2.Value.Date
        Dim dtDate1 As DateTime = DateTime.Parse(mdate)
            Dim dtDate2 As DateTime = DateTime.Parse(odate)

            MsgBox(mdate)
            MsgBox(odate)
        adp.SelectCommand = New OleDbCommand("SELECT productname,quantity,hr,total from sales where hr Between #" &
                                            dtDate1.ToString("MM/dd/yyyy") & "# And #" &
                                            dtDate2.ToString("MM/dd/yyyy") & "#", cn)
        adp.SelectCommand.ExecuteNonQuery()
            adp.Fill(mds)
            DataGridView1.DataSource = mds.Tables(0)
            DataGridView1.Refresh()
            DataGridView1.Visible = True

        Dim qval As Integer
        Dim sval As Integer
        Dim tSUM As Integer
        Dim tqty As Integer
        For i = 0 To DataGridView1.Rows.Count - 1
            qval = DataGridView1.Rows(i).Cells(1).Value
            sval = DataGridView1.Rows(i).Cells(3).Value
            tSUM = tSUM + sval
            tqty = tqty + qval
        Next
        TextBox3.Text = tSUM

        TextBox4.Text = tqty
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class