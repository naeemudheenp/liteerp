Imports System.Data
Imports System.Data.OleDb
Public Class Form1
    Dim selecteditemadp As New OleDbDataAdapter
    Dim selecteditemds As New DataSet
    Dim adpfr As New OleDbDataAdapter
    Dim DT As String
    Dim salesval As Integer
    Dim cnt As Integer
    Dim dqty As Integer
    Dim TextToPrint As String = ""
    Dim str As String
    Dim str1 As String
    Dim str2 As String
    Dim str3 As String
    Dim str4 As String
    Dim adp3 As OleDbDataAdapter
    Dim ds2 As New DataSet
    Dim adp2 As OleDbDataAdapter
    Dim ds As New DataSet
    Dim adp As OleDbDataAdapter
    Dim cmdsr As New OleDbCommand
    Public cn As New OleDbConnection
    Dim selecteditem As Integer
    Dim sales As New OleDbDataAdapter
    Dim sds As New DataSet
    Dim strConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & System.Environment.CurrentDirectory & "\product.mdb;Jet OLEDB:Database Password=Carcarcar@1085;"

    Declare Function Wow64DisableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Private osk As String = "C:\Windows\System32\osk.exe"


    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProductDataSet5.ontime' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'ProductDataSet.ontime' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'ProductDataSet.products' table. You can move, or remove it, as needed.
        cn.ConnectionString = strconnectionstring
        cn.Open()
        Label7.Text = DateTime.Now
        cnt = 0
        button_disable()


    End Sub
    Public Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            DataGridView1.Refresh()
            ds.Reset()
            adp = New OleDbDataAdapter("SELECT * FROM SALES ", cn)
            adp.SelectCommand = New OleDbCommand("Select id,productname,price from products where productname Like '%" & TextBox1.Text & "%' ", cn)
            adp.SelectCommand.ExecuteNonQuery()

            adp.Fill(ds)

            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.Refresh()

            DataGridView1.Visible = True
        Catch ex As Exception
            MsgBox("SYNC ERROR")
        End Try


    End Sub
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        disable()

        Dim str As String
        Dim str1 As String
        Dim str2 As String
        Dim ps As Integer
        Dim LST As OleDbDataAdapter

        LST = New OleDbDataAdapter("SELECT * FROM ontime", cn)
        selecteditemadp = New OleDbDataAdapter("SELECT * FROM PRODUCTS", cn)
        adp2 = New OleDbDataAdapter("select * from onTIME", cn)

        If DataGridView1.Rows.Count = 0 Then 'CHECKING ANY CONTENT IS SELECTED
            MsgBox("NO ITEM SELECTED")
            TextBox1.Enabled = True
            Button1.Enabled = True
            Exit Sub
        End If

        ds2.Reset() 'RESETING DATASET TO GET DATA
        ps = DataGridView1.CurrentRow.Index 'CURRENT ROW

        str = DataGridView1.Rows(ps).Cells(0).Value 'RETREAVING VALUES
        str1 = DataGridView1.Rows(ps).Cells(1).Value
        str2 = DataGridView1.Rows(ps).Cells(2).Value

        Try ' checking wheter the slect product is available
            selecteditemadp.SelectCommand = New OleDbCommand("SELECT * FROM products WHERE ID= '" & str & "';", cn)
            selecteditemadp.SelectCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("UNABLE TO RETREAVE DATA FROM DATABASE ! TRY AGAIN OR CONTACT ADMIN")
            Exit Sub
        End Try

        selecteditemadp.Fill(selecteditemds)
        selecteditem = selecteditemds.Tables(0).Rows(0)("quantity")


        If selecteditem = 0 Then
            MsgBox("SELECTED ITEM IS NOT AVAILABLE")
            enable()
            selecteditemds.Reset()
            ds2.Reset()
            selecteditemadp.SelectCommand = New OleDbCommand("SELECT * FROM ontime;", cn)
            selecteditemadp.SelectCommand.ExecuteNonQuery()
            selecteditemadp.Fill(ds2)
            DataGridView2.DataSource = ds2.Tables(0)
            DataGridView2.Refresh()
            DataGridView1.Visible = False
            Exit Sub
        End If
        selecteditemds.Reset()
        Try 'checking the content is selected already
            LST.SelectCommand = New OleDbCommand("SELECT * FROM ontime WHERE ID = '" & str & "'", cn)
            LST.SelectCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("INTERNAL ERROR CONTACT ADMIN")
        End Try


        Dim rdrOLEDB As OleDbDataReader = LST.SelectCommand.ExecuteReader

        If rdrOLEDB.Read = True Then
            MsgBox("THIS ITEM IS ALREADY ADDED!")
            enable()
            ds2.Reset()
            Try
                adp2.SelectCommand = New OleDbCommand("select * from ontime", cn)
                adp.SelectCommand.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("INTERNAL ERROR CONTACT ADMIN")
            End Try
            adp2.Fill(ds2)
            DataGridView2.DataSource = ds2.Tables(0)
            Exit Sub
        End If

        'INSERTING VALUE
        adp2.InsertCommand = New OleDbCommand("INSERT INTO ontime (id,productname,price) VALUES('" & str & "','" & str1 & "','" & str2 & "')", cn)
        adp2.InsertCommand.ExecuteNonQuery()
        adp2.SelectCommand = New OleDbCommand("select * from ontime", cn)
        adp.SelectCommand.ExecuteNonQuery()
        adp2.Fill(ds2)
        DataGridView2.DataSource = ds2.Tables(0)
lt:
        TextBox1.Text = ""
        DataGridView1.Visible = False
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sales = New OleDbDataAdapter("SELECT * FROM salesno", cn)
        sales.SelectCommand = New OleDbCommand("SELECT * FROM salesno WHERE ID=1", cn)
        sales.SelectCommand.ExecuteNonQuery()

        Dim sds As New DataSet

        sales.Fill(sds)

        salesval = sds.Tables(0).Rows(0)("salesid")
        salesval = salesval + 1
        Dim i As Integer
        Dim dt As Date

        If DataGridView2.Rows.Count = 0 Then 'CHECKING DATA IS SELECTED
            MsgBox("NO ITEM SELECTED ")
            Exit Sub
        End If

        'PRINTING SHEET
        PrintHeader()
        ItemsToBePrinted()
        printFooter()
        'I JUST DONT KNOW WTF IS THIS
        Dim printControl = New Printing.StandardPrintController
        PrintDocument1.PrintController = printControl
        Try
            PrintDocument1.Print()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'INSERTING VALUE
        For i = 0 To DataGridView2.Rows.Count - 1
            str = DataGridView2.Rows(i).Cells(0).Value
            str1 = DataGridView2.Rows(i).Cells(1).Value
            str2 = DataGridView2.Rows(i).Cells(2).Value
            str3 = DataGridView2.Rows(i).Cells(3).Value
            str4 = DataGridView2.Rows(i).Cells(4).Value
            dt = DateTime.Today
            Try
                adp3 = New OleDbDataAdapter("select * from sales", cn)
                adp3.InsertCommand = New OleDbCommand("INSERT INTO sales (id,productname,price,quantity,total,hr,SALESNUMBER) VALUES('" & str & "','" & str1 & "','" & str3 & "','" & str2 & "','" & str4 & "','" & dt & "','" & salesval & "')", cn)
                adp3.InsertCommand.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("INTERNAL ERROR REPORT BUG")
            End Try
        Next

        'DELETING DATA
        Try
            adp3.DeleteCommand = New OleDbCommand("DELETE  FROM ontime;", cn)
            adp3.DeleteCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("INTERNAL ERROR REPORT BUG")
        End Try

        DataGridView2.DataSource = ""
        DataGridView2.Refresh()

        'GIVING SALES ID
        Try
            sales.UpdateCommand = New OleDbCommand("UPDATE salesno SET salesid= '" & salesval & "' WHERE ID=1 ;", cn)
            sales.UpdateCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("INTERNAL ERROR REPORT BUG")
        End Try
        MsgBox("PURCHASE COMPLETED ")
        TextBox1.Text = ""
        TextBox2.Text = ""

        TextBox4.Text = ""
    End Sub
    Public Sub PrintHeader()


        adp.Dispose()

    End Sub
    Public Sub ItemsToBePrinted()
        For i = 0 To 8
            TextToPrint &= "" & Environment.NewLine
        Next
        For i = 0 To DataGridView2.Rows.Count - 1


            str = DataGridView2.Rows(i).Cells(0).Value
            str1 = DataGridView2.Rows(i).Cells(1).Value
            str2 = DataGridView2.Rows(i).Cells(2).Value
            str3 = DataGridView2.Rows(i).Cells(3).Value
            str4 = DataGridView2.Rows(i).Cells(4).Value
            Dim name = TextBox_name.Text
            Dim star = TextBox_star.Text



            Dim StringToPrint As String = "       " & name & "         " & star & "         " & str1 & "                 " & str2 & "         " & str4 & "  "
            Dim LineLen As String = StringToPrint.Length




            TextToPrint &= StringToPrint & Environment.NewLine
        Next
    End Sub
    Public Sub printFooter()
        TextToPrint &= Environment.NewLine
        TextToPrint &= Environment.NewLine

        Dim Total As String = TextBox2.Text
        TextToPrint &= "                               Date: " & DateTime.Now & "                    Total =" & Total

    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Static currentChar As Integer
        Dim textfont As Font = New Font("Courier New", 10, FontStyle.Bold)

        Dim h, w As Integer
        Dim left, top As Integer
        With PrintDocument1.DefaultPageSettings
            h = 0
            w = 0
            left = 0
            top = 0
        End With


        Dim lines As Integer = CInt(Math.Round(h / 1))
        Dim b As New Rectangle(left, top, w, h)
        Dim format As StringFormat
        format = New StringFormat(StringFormatFlags.LineLimit)
        Dim line, chars As Integer


        e.Graphics.MeasureString(Mid(TextToPrint, currentChar + 1), textfont, New SizeF(w, h), format, chars, line)
        e.Graphics.DrawString(TextToPrint.Substring(currentChar, chars), New Font("Courier New", 10, FontStyle.Bold), Brushes.Black, b, format)


        currentChar = currentChar + chars
        If currentChar < TextToPrint.Length Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            currentChar = 0
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        PrintHeader()
        ItemsToBePrinted()
        printFooter()
        Dim printControl = New Printing.StandardPrintController
        PrintDocument1.PrintController = printControl
        Try
            PrintDocument1.Print()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs)
        Me.Hide()
        mainscreen.Show()
    End Sub
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dlt As Integer
        Dim cdlt As String
        Dim dtqty As Integer
        Dim qtyad As Integer
        Dim rd As New OleDbDataAdapter
        Dim rds As New DataSet

        rd = New OleDbDataAdapter("SELECT * FROM PRODUCTS", cn)

        If DataGridView2.RowCount = 0 Then  'AS YOU KNOW
            MsgBox("SELECTION EMPTY")
            Exit Sub
        End If

        dlt = DataGridView2.CurrentRow.Index 'RETREAVING DATA FROM DATAGRID
        cdlt = DataGridView2.Rows(dlt).Cells(0).Value
        dtqty = DataGridView2.Rows(dlt).Cells(2).Value

        Try
            adp.DeleteCommand = New OleDbCommand("DELETE FROM ontime WHERE ID= '" & cdlt & "';", cn)
            adp.DeleteCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("INTERNAL ERROR REPORT BUG")
        End Try

        Try
            rd.SelectCommand = New OleDbCommand("SELECT * FROM products WHERE ID= '" & cdlt & "';", cn)
            rd.SelectCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("INTERNAL ERROR")
        End Try

        rd.Fill(rds) 'READDING THE STOCK
        qtyad = rds.Tables(0).Rows(0)("quantity")
        dtqty = dtqty + qtyad
        'Try
        rd.UpdateCommand = New OleDbCommand("UPDATE products SET quantity='" & dtqty & "' WHERE ID= '" & cdlt & "';", cn)
            rd.UpdateCommand.ExecuteNonQuery()
            MsgBox("DATA DELETED")
        'Catch ex As Exception
        MsgBox("INTERNAL ERROR")
        ' End Try

        ds2.Reset()
        Try
            adp.SelectCommand = New OleDbCommand("SELECT * FROM ontime ;", cn)
            adp.SelectCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("INTERNAL ERROR REPORT BUG")
        End Try

        adp.Fill(ds2)
        DataGridView2.DataSource = ds2.Tables(0)
        DataGridView2.Refresh()

        enable()
    End Sub
    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        DataGridView1.Hide()
    End Sub
    Private Sub Button5_Click_1(sender As Object, e As EventArgs)
        REFUND.Show()
    End Sub
    Public Sub DataGridView2_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellEndEdit
        Try

            Dim d As Integer
        Dim fqty As Integer
        Dim minusdataset As New DataSet
        Dim minusadp As New OleDbDataAdapter
        Dim qval As Integer
        Dim sval As Integer
        Dim tSUM As Integer
        Dim tqty As Integer

        minusadp = New OleDbDataAdapter("SELECT * FROM PRODUCTS;", cn)

        d = DataGridView2.CurrentRow.Index
        DT = DataGridView2.Rows(d).Cells(0).Value
            If selecteditem = -1 Then
                GoTo ed
            End If
            If selecteditem < DT Then 'CHCKING WHETER THE ENTERED QUANTITY IS LESS THAN THE AVAILABLE
            MsgBox("SELECTED QUANTITY OVERFLOW")
            enable()

            Dim ovdlt As New OleDbDataAdapter
            ovdlt = New OleDbDataAdapter("SELECT * FROM ontime", cn)
            Try
                ovdlt.DeleteCommand = New OleDbCommand("DELETE FROM ontime WHERE ID='" & DT & "';", cn)

                ovdlt.DeleteCommand.ExecuteNonQuery()

                ovdlt.SelectCommand = New OleDbCommand("SELECT * FROM ontime", cn)

                ovdlt.SelectCommand.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("INTERNAL ERROR REPORT BUG")
            End Try

            Dim ovds As New DataSet
            ovdlt.Fill(ovds)
            DataGridView2.DataSource = ovds
            DataGridView2.Refresh()
            ovdlt.Dispose()

            Exit Sub
        End If
ed:
            DataGridView2.Rows(d).Cells(4).Value = DataGridView2.Rows(d).Cells(2).Value * DataGridView2.Rows(d).Cells(3).Value

        If selecteditem = -1 Then 'SKIPING FOR PRODUCTS WHICH ARE NOT AFFCETED BY QUANTITY
            GoTo skp
        End If


        Try
            minusadp.SelectCommand = New OleDbCommand("SELECT * FROM PRODUCTS WHERE ID= '" & DT & "';", cn)

            minusadp.SelectCommand.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("INTERNAL ERROR REPORT BUG")
        End Try


        minusadp.Fill(minusdataset)
        fqty = minusdataset.Tables(0).Rows(0)("quantity")
        minusadp.Dispose()

        If cnt = 0 Then 'MINUS THE PRODUCT
            dqty = fqty
        End If

        If cnt > 0 Then
            fqty = dqty
        End If

        adpfr = New OleDbDataAdapter("SELECT * FROM ontime ;", cn)
        fqty = fqty - DataGridView2.Rows(d).Cells(2).Value

        Try
            adpfr.UpdateCommand = New OleDbCommand("UPDATE products SET quantity='" & fqty & "'WHERE ID ='" & DT & "';", cn)
            adpfr.UpdateCommand.ExecuteNonQuery()
            adpfr.Dispose()

        Catch ex As Exception
            MsgBox("INTERNAL ERROR REPORT BUG")
        End Try

skp:


        Try
            adpfr.UpdateCommand = New OleDbCommand("UPDATE ontime SET quantity='" & DataGridView2.Rows(d).Cells(2).Value & "',total='" & DataGridView2.Rows(d).Cells(4).Value & "' WHERE ID ='" & DT & "';", cn)
            adpfr.UpdateCommand.ExecuteNonQuery()

            adpfr.Dispose()
        Catch ex As Exception
            MsgBox("INTERNAL ERROR REPORT BUG")
        End Try


        For i = 0 To DataGridView2.Rows.Count - 1
            qval = DataGridView2.Rows(i).Cells(2).Value
            sval = DataGridView2.Rows(i).Cells(4).Value
            tSUM = tSUM + sval
            tqty = tqty + qval
        Next

        TextBox2.Text = tSUM

            TextBox4.Text = tqty
        enable()


        Catch ex As Exception
            MsgBox("PLEASE GIVE A VALUE TO QUANTITY BEFORE YOU DELETE")
        End Try


    End Sub
    Public Sub enable()
        TextBox1.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True

    End Sub
    Public Sub disable()
        TextBox1.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False

    End Sub
    Public Sub button_disable()
        Button2.Enabled = False
    End Sub
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams
            cp = MyBase.CreateParams
            cp.ExStyle = 0 * 2000000

            Return cp
        End Get
    End Property

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Wow64DisableWow64FsRedirection(0)
        Process.Start(osk)
    End Sub
End Class
