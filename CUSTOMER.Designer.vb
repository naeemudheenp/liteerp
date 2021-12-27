<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CUSTOMER
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CUSTOMER))
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ename = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.erating = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ecrdit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edebit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emobile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(124, 34)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(67, 24)
        Me.Button4.TabIndex = 5
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
        Me.Button3.Location = New System.Drawing.Point(51, 34)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(67, 24)
        Me.Button3.TabIndex = 4
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
        Me.Button2.Location = New System.Drawing.Point(197, 34)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 24)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "DELETE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(943, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "CUSTOMER NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(943, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "CUSTOMER ID"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(1149, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 21)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(1048, 71)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(152, 20)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(1047, 45)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(152, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(251, 23)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "CUSTOMER MANAGMENT"
        '
        'DataGridView1
        '
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.ename, Me.erating, Me.ecrdit, Me.edebit, Me.emobile})
        Me.DataGridView1.Location = New System.Drawing.Point(51, 87)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(899, 642)
        Me.DataGridView1.TabIndex = 7
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Width = 150
        '
        'ename
        '
        Me.ename.DataPropertyName = "ename"
        Me.ename.HeaderText = "NAME"
        Me.ename.Name = "ename"
        Me.ename.Width = 150
        '
        'erating
        '
        Me.erating.DataPropertyName = "erating"
        Me.erating.HeaderText = "PRIORITY"
        Me.erating.Name = "erating"
        Me.erating.Width = 150
        '
        'ecrdit
        '
        Me.ecrdit.DataPropertyName = "ecredit"
        Me.ecrdit.HeaderText = "CREDIT"
        Me.ecrdit.Name = "ecrdit"
        Me.ecrdit.Width = 150
        '
        'edebit
        '
        Me.edebit.DataPropertyName = "edebit"
        Me.edebit.HeaderText = "DEBIT"
        Me.edebit.Name = "edebit"
        Me.edebit.Width = 150
        '
        'emobile
        '
        Me.emobile.DataPropertyName = "emobile"
        Me.emobile.HeaderText = "MOBILE"
        Me.emobile.Name = "emobile"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(38, 741)
        Me.Panel1.TabIndex = 30
        '
        'CUSTOMER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1215, 741)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CUSTOMER"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer_Information"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel

    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EratingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EcreditDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EdebitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmobileDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents ename As DataGridViewTextBoxColumn
    Friend WithEvents erating As DataGridViewTextBoxColumn
    Friend WithEvents ecrdit As DataGridViewTextBoxColumn
    Friend WithEvents edebit As DataGridViewTextBoxColumn
    Friend WithEvents emobile As DataGridViewTextBoxColumn
End Class
