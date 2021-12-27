<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stockmgmt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stockmgmt))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProductsBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button5 = New System.Windows.Forms.Button()
        Me.POOJAID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POOJANAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRICE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.POOJAID, Me.POOJANAME, Me.PRICE})
        Me.DataGridView1.DataSource = Me.ProductsBindingSource6
        Me.DataGridView1.Location = New System.Drawing.Point(126, 93)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(845, 636)
        Me.DataGridView1.TabIndex = 8
        '
        'ProductsBindingSource6
        '
        Me.ProductsBindingSource6.DataMember = "products"
        '
        'ProductsBindingSource3
        '
        Me.ProductsBindingSource3.DataMember = "products"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(122, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 23)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "STOCK MANAGMENT"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(101, 733)
        Me.Panel1.TabIndex = 17
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(125, 62)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(437, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(568, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 20)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "SEARCH"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(272, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 24)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "DELETE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(126, 32)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(67, 24)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "REFRESH"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(199, 32)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(67, 24)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "UPDATE"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "products"
        '
        'ProductsBindingSource1
        '
        Me.ProductsBindingSource1.DataMember = "products"
        '
        'ProductsBindingSource2
        '
        Me.ProductsBindingSource2.DataMember = "products"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Black
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(345, 32)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(71, 24)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "ADD PRODUCT"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'POOJAID
        '
        Me.POOJAID.DataPropertyName = "id"
        Me.POOJAID.HeaderText = "POOJAID"
        Me.POOJAID.Name = "POOJAID"
        Me.POOJAID.Width = 200
        '
        'POOJANAME
        '
        Me.POOJANAME.DataPropertyName = "productname"
        Me.POOJANAME.HeaderText = "POOJANAME"
        Me.POOJANAME.Name = "POOJANAME"
        Me.POOJANAME.Width = 400
        '
        'PRICE
        '
        Me.PRICE.DataPropertyName = "price"
        Me.PRICE.HeaderText = "POOJA PRICE"
        Me.PRICE.Name = "PRICE"
        Me.PRICE.Width = 200
        '
        'stockmgmt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1215, 733)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "stockmgmt"
        Me.Text = "Stock_Managment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ProductDataSet As productDataSet
    Friend WithEvents ProductsBindingSource As BindingSource
    Friend WithEvents ProductsTableAdapter As productDataSetTableAdapters.productsTableAdapter
    Friend WithEvents ProductsBindingSource2 As BindingSource
    Friend WithEvents ProductDataSet1 As productDataSet
    Friend WithEvents ProductsBindingSource1 As BindingSource

    Friend WithEvents ProductsBindingSource4 As BindingSource
    Friend WithEvents ProductsBindingSource5 As BindingSource
    Friend WithEvents ProductsBindingSource3 As BindingSource
    Friend WithEvents Button5 As Button
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrginalpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductDataSet2 As productDataSet
    Friend WithEvents ProductsBindingSource6 As BindingSource
    Friend WithEvents POOJAID As DataGridViewTextBoxColumn
    Friend WithEvents POOJANAME As DataGridViewTextBoxColumn
    Friend WithEvents PRICE As DataGridViewTextBoxColumn
End Class
