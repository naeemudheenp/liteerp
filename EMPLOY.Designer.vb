<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EMPLOY
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EMPLOY))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ename = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.esalary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ecredit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edebit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emobile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EsalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EcreditDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EdebitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmobileDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(85, 741)
        Me.Panel1.TabIndex = 18
        '
        'DataGridView1
        '
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.ename, Me.esalary, Me.ecredit, Me.edebit, Me.emobile})
        Me.DataGridView1.Location = New System.Drawing.Point(91, 102)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(895, 627)
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
        'esalary
        '
        Me.esalary.DataPropertyName = "esalary"
        Me.esalary.HeaderText = " SALARY"
        Me.esalary.Name = "esalary"
        Me.esalary.Width = 150
        '
        'ecredit
        '
        Me.ecredit.DataPropertyName = "ecredit"
        Me.ecredit.HeaderText = "CREDIT"
        Me.ecredit.Name = "ecredit"
        Me.ecredit.Width = 150
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
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(1036, 49)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(152, 20)
        Me.TextBox2.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(1137, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 21)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(931, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "EMPLOYEE ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(931, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "EMPLOYEE NAME"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(167, 33)
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
        Me.Button3.Location = New System.Drawing.Point(94, 33)
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
        Me.Button2.Location = New System.Drawing.Point(240, 33)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 24)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "DELETE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "EMPLOYEE ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'EnameDataGridViewTextBoxColumn
        '
        Me.EnameDataGridViewTextBoxColumn.DataPropertyName = "ename"
        Me.EnameDataGridViewTextBoxColumn.HeaderText = "EMPLOYEE NAME"
        Me.EnameDataGridViewTextBoxColumn.Name = "EnameDataGridViewTextBoxColumn"
        '
        'EsalaryDataGridViewTextBoxColumn
        '
        Me.EsalaryDataGridViewTextBoxColumn.DataPropertyName = "esalary"
        Me.EsalaryDataGridViewTextBoxColumn.HeaderText = "EMPLOYEE SALARY"
        Me.EsalaryDataGridViewTextBoxColumn.Name = "EsalaryDataGridViewTextBoxColumn"
        '
        'EcreditDataGridViewTextBoxColumn
        '
        Me.EcreditDataGridViewTextBoxColumn.DataPropertyName = "ecredit"
        Me.EcreditDataGridViewTextBoxColumn.HeaderText = "EMPLOYEE CREDIT"
        Me.EcreditDataGridViewTextBoxColumn.Name = "EcreditDataGridViewTextBoxColumn"
        '
        'EdebitDataGridViewTextBoxColumn
        '
        Me.EdebitDataGridViewTextBoxColumn.DataPropertyName = "edebit"
        Me.EdebitDataGridViewTextBoxColumn.HeaderText = "EMPLOYEE DEBIT"
        Me.EdebitDataGridViewTextBoxColumn.Name = "EdebitDataGridViewTextBoxColumn"
        '
        'EmobileDataGridViewTextBoxColumn
        '
        Me.EmobileDataGridViewTextBoxColumn.DataPropertyName = "emobile"
        Me.EmobileDataGridViewTextBoxColumn.HeaderText = "EMPLOYEE MOBILE"
        Me.EmobileDataGridViewTextBoxColumn.Name = "EmobileDataGridViewTextBoxColumn"
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Location = New System.Drawing.Point(1036, 16)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(154, 20)
        Me.TextBox3.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(91, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(233, 23)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "EMPLOYEE MANAGMENT"
        '
        'EMPLOY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1215, 741)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EMPLOY"
        Me.Text = "Employee_Information"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EsalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EcreditDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EdebitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmobileDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents ename As DataGridViewTextBoxColumn
    Friend WithEvents esalary As DataGridViewTextBoxColumn
    Friend WithEvents ecredit As DataGridViewTextBoxColumn
    Friend WithEvents edebit As DataGridViewTextBoxColumn
    Friend WithEvents emobile As DataGridViewTextBoxColumn
End Class
