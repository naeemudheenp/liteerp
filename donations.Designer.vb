<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class donations
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
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DonationsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.DonationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DonationsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DonationsBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DonationsBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductDataSet2 = New WindowsApp1.productDataSet()
        Me.DonationsTableAdapter1 = New WindowsApp1.productDataSetTableAdapters.donationsTableAdapter()
        Me.donation_dataset = New WindowsApp1.productDataSet()
        Me.ProductDataSet3 = New WindowsApp1.productDataSet()
        Me.DonationsBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DonationsBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DonationsBindingSource7 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.customername = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button_report = New System.Windows.Forms.Button()
        CType(Me.DonationsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DonationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DonationsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DonationsBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DonationsBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.donation_dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DonationsBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DonationsBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DonationsBindingSource7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Black
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(-49, -202)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(71, 24)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "ADD PRODUCT"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(-195, -202)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(67, 24)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "UPDATE"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(-268, -202)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(67, 24)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "REFRESH"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(-122, -202)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 24)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "DELETE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(174, -172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 20)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "SEARCH"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(101, 733)
        Me.Panel1.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-272, -234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 23)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "STOCK MANAGMENT"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(-269, -172)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(437, 20)
        Me.TextBox1.TabIndex = 18
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Black
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(254, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(71, 24)
        Me.Button6.TabIndex = 32
        Me.Button6.Text = "ADD PRODUCT"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Black
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(108, 12)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(67, 24)
        Me.Button8.TabIndex = 29
        Me.Button8.Text = "REFRESH"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Black
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(181, 12)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(67, 24)
        Me.Button9.TabIndex = 31
        Me.Button9.Text = "DELETE"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'DonationsBindingSource4
        '
        Me.DonationsBindingSource4.DataMember = "donations"
        Me.DonationsBindingSource4.DataSource = Me.ProductDataSet2
        '
        'ProductDataSet2
        '
        Me.ProductDataSet2.DataSetName = "productDataSet"
        Me.ProductDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DonationsTableAdapter1
        '
        Me.DonationsTableAdapter1.ClearBeforeFill = True
        '
        'donation_dataset
        '
        Me.donation_dataset.DataSetName = "productDataSet"
        Me.donation_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductDataSet3
        '
        Me.ProductDataSet3.DataSetName = "productDataSet"
        Me.ProductDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DonationsBindingSource5
        '
        Me.DonationsBindingSource5.DataMember = "donations"
        Me.DonationsBindingSource5.DataSource = Me.ProductDataSet3
        '
        'DonationsBindingSource6
        '
        Me.DonationsBindingSource6.DataMember = "donations"
        Me.DonationsBindingSource6.DataSource = Me.ProductDataSet3
        '
        'DonationsBindingSource7
        '
        Me.DonationsBindingSource7.DataMember = "donations"
        Me.DonationsBindingSource7.DataSource = Me.donation_dataset
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.customername, Me.amount, Me.description})
        Me.DataGridView1.Location = New System.Drawing.Point(129, 90)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(492, 261)
        Me.DataGridView1.TabIndex = 33
        '
        'customername
        '
        Me.customername.DataPropertyName = "customername"
        Me.customername.HeaderText = "Name"
        Me.customername.Name = "customername"
        Me.customername.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.customername.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'amount
        '
        Me.amount.DataPropertyName = "amount"
        Me.amount.HeaderText = "AMOUNT"
        Me.amount.Name = "amount"
        '
        'description
        '
        Me.description.DataPropertyName = "description"
        Me.description.HeaderText = "DESCRIPTION"
        Me.description.Name = "description"
        '
        'Button_report
        '
        Me.Button_report.BackColor = System.Drawing.Color.Black
        Me.Button_report.FlatAppearance.BorderSize = 0
        Me.Button_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_report.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_report.ForeColor = System.Drawing.Color.White
        Me.Button_report.Location = New System.Drawing.Point(331, 12)
        Me.Button_report.Name = "Button_report"
        Me.Button_report.Size = New System.Drawing.Size(71, 24)
        Me.Button_report.TabIndex = 34
        Me.Button_report.Text = "REPORT"
        Me.Button_report.UseVisualStyleBackColor = False
        '
        'donations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 733)
        Me.Controls.Add(Me.Button_report)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "donations"
        Me.Text = "donations"
        CType(Me.DonationsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DonationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DonationsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DonationsBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DonationsBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.donation_dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DonationsBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DonationsBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DonationsBindingSource7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents DonationsBindingSource2 As BindingSource
    Friend WithEvents ProductDataSet12 As productDataSet
    Friend WithEvents DonationsBindingSource As BindingSource
    Friend WithEvents DonationsTableAdapter As productDataSetTableAdapters.donationsTableAdapter
    Friend WithEvents ProductDataSet1 As productDataSet
    Friend WithEvents DonationsBindingSource1 As BindingSource
    Friend WithEvents ProductDataSet As productDataSet
    Friend WithEvents DonationsBindingSource3 As BindingSource
    Friend WithEvents CustomernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductDataSet2 As productDataSet
    Friend WithEvents DonationsBindingSource4 As BindingSource
    Friend WithEvents DonationsTableAdapter1 As productDataSetTableAdapters.donationsTableAdapter
    Friend WithEvents donation_dataset As productDataSet
    Friend WithEvents ProductDataSet3 As productDataSet
    Friend WithEvents DonationsBindingSource5 As BindingSource
    Friend WithEvents DonationsBindingSource6 As BindingSource
    Friend WithEvents DonationsBindingSource7 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents customername As DataGridViewTextBoxColumn
    Friend WithEvents amount As DataGridViewTextBoxColumn
    Friend WithEvents description As DataGridViewTextBoxColumn
    Friend WithEvents Button_report As Button
End Class
