<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ProductDataSet = New WindowsApp1.productDataSet()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsTableAdapter = New WindowsApp1.productDataSetTableAdapters.productsTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.productDataSetTableAdapters.TableAdapterManager()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProductDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCTNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRICE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OntimeBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OntimeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.OntimeTableAdapter = New WindowsApp1.productDataSetTableAdapters.ontimeTableAdapter()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox_address = New System.Windows.Forms.TextBox()
        Me.TextBox_star = New System.Windows.Forms.TextBox()
        Me.TextBox_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ProductDataSet1 = New WindowsApp1.productDataSet()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.ProductDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OntimeBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OntimeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductDataSet
        '
        Me.ProductDataSet.DataSetName = "productDataSet"
        Me.ProductDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "products"
        Me.ProductsBindingSource.DataSource = Me.ProductDataSet
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.donationsTableAdapter = Nothing
        Me.TableAdapterManager.ontimeTableAdapter = Nothing
        Me.TableAdapterManager.productsTableAdapter = Me.ProductsTableAdapter
        Me.TableAdapterManager.runtimeTableAdapter = Nothing
        Me.TableAdapterManager.salesnoTableAdapter = Nothing
        Me.TableAdapterManager.salesTableAdapter = Nothing
        Me.TableAdapterManager.securityTableAdapter = Nothing
        Me.TableAdapterManager.trialTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.productDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ventureinfoTableAdapter = Nothing
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(48, 87)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(516, 20)
        Me.TextBox1.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(48, 113)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(516, 295)
        Me.DataGridView1.TabIndex = 3
        Me.DataGridView1.Visible = False
        '
        'ProductDataSetBindingSource
        '
        Me.ProductDataSetBindingSource.DataSource = Me.ProductDataSet
        Me.ProductDataSetBindingSource.Position = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(570, 87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 20)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "ചേർക്കുക"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.PRODUCTNAME, Me.quantity, Me.PRICE, Me.TOTAL})
        Me.DataGridView2.DataSource = Me.OntimeBindingSource2
        Me.DataGridView2.Location = New System.Drawing.Point(50, 127)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(945, 594)
        Me.DataGridView2.TabIndex = 2
        '
        'ID
        '
        Me.ID.DataPropertyName = "id"
        Me.ID.HeaderText = "POOJA ID"
        Me.ID.Name = "ID"
        Me.ID.Width = 150
        '
        'PRODUCTNAME
        '
        Me.PRODUCTNAME.DataPropertyName = "productname"
        Me.PRODUCTNAME.HeaderText = "POOJA NAME"
        Me.PRODUCTNAME.Name = "PRODUCTNAME"
        Me.PRODUCTNAME.Width = 250
        '
        'quantity
        '
        Me.quantity.DataPropertyName = "quantity"
        Me.quantity.HeaderText = "QUANTITY"
        Me.quantity.Name = "quantity"
        Me.quantity.Width = 150
        '
        'PRICE
        '
        Me.PRICE.DataPropertyName = "price"
        Me.PRICE.HeaderText = "PRICE"
        Me.PRICE.Name = "PRICE"
        Me.PRICE.Width = 150
        '
        'TOTAL
        '
        Me.TOTAL.DataPropertyName = "total"
        Me.TOTAL.HeaderText = "TOTAL"
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.Width = 200
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(999, 629)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(204, 92)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "PAY"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'OntimeTableAdapter
        '
        Me.OntimeTableAdapter.ClearBeforeFill = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(1001, 501)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(204, 39)
        Me.TextBox2.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1060, 459)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ആകെ തുക"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1044, 366)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "ആകെ അളവ്"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(999, 393)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(204, 39)
        Me.TextBox4.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1215, 33)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(51, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(281, 28)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "സെയിൽസ് വിൻഡോ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(46, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(217, 19)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "XBM : SALES BILLING SYSTEM"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning
        Me.NotifyIcon1.BalloonTipText = "SALES WINDOWS RUNNING!"
        Me.NotifyIcon1.BalloonTipTitle = "HBMGMT "
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(653, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Label7"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(48, 61)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(74, 20)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(668, 87)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(58, 20)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "HIDE SEARCH GRID"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TextBox_address
        '
        Me.TextBox_address.Location = New System.Drawing.Point(999, 295)
        Me.TextBox_address.Multiline = True
        Me.TextBox_address.Name = "TextBox_address"
        Me.TextBox_address.Size = New System.Drawing.Size(204, 39)
        Me.TextBox_address.TabIndex = 2
        '
        'TextBox_star
        '
        Me.TextBox_star.Location = New System.Drawing.Point(999, 213)
        Me.TextBox_star.Multiline = True
        Me.TextBox_star.Name = "TextBox_star"
        Me.TextBox_star.Size = New System.Drawing.Size(204, 39)
        Me.TextBox_star.TabIndex = 1
        '
        'TextBox_name
        '
        Me.TextBox_name.Location = New System.Drawing.Point(999, 138)
        Me.TextBox_name.Multiline = True
        Me.TextBox_name.Name = "TextBox_name"
        Me.TextBox_name.Size = New System.Drawing.Size(204, 39)
        Me.TextBox_name.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1075, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "പേര്"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1072, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "നക്ഷത്രം"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1075, 279)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "വിലാസം"
        '
        'ProductDataSet1
        '
        Me.ProductDataSet1.DataSetName = "productDataSet"
        Me.ProductDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Black
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(732, 87)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(101, 20)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "KEYBOARD"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1215, 733)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_name)
        Me.Controls.Add(Me.TextBox_star)
        Me.Controls.Add(Me.TextBox_address)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Sales_Window"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ProductDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OntimeBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OntimeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductDataSet As productDataSet
    Friend WithEvents ProductsBindingSource As BindingSource
    Friend WithEvents ProductsTableAdapter As productDataSetTableAdapters.productsTableAdapter
    Friend WithEvents TableAdapterManager As productDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ProductDataSetBindingSource As BindingSource
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents OntimeBindingSource As BindingSource
    Friend WithEvents OntimeTableAdapter As productDataSetTableAdapters.ontimeTableAdapter
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Label7 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents QtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button4 As Button

    Friend WithEvents OntimeBindingSource2 As BindingSource
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextBox_address As TextBox
    Friend WithEvents TextBox_star As TextBox
    Friend WithEvents TextBox_name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents PRODUCTNAME As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents PRICE As DataGridViewTextBoxColumn
    Friend WithEvents TOTAL As DataGridViewTextBoxColumn
    Friend WithEvents ProductDataSet1 As productDataSet
    Friend WithEvents Button5 As Button
End Class
