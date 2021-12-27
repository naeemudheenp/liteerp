<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class donations_add
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
        Me.TextBox_name = New System.Windows.Forms.TextBox()
        Me.TextBox_amount = New System.Windows.Forms.TextBox()
        Me.TextBox_description = New System.Windows.Forms.TextBox()
        Me.Button_add = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox_name
        '
        Me.TextBox_name.Location = New System.Drawing.Point(270, 35)
        Me.TextBox_name.Multiline = True
        Me.TextBox_name.Name = "TextBox_name"
        Me.TextBox_name.Size = New System.Drawing.Size(165, 20)
        Me.TextBox_name.TabIndex = 0
        '
        'TextBox_amount
        '
        Me.TextBox_amount.Location = New System.Drawing.Point(270, 86)
        Me.TextBox_amount.Multiline = True
        Me.TextBox_amount.Name = "TextBox_amount"
        Me.TextBox_amount.Size = New System.Drawing.Size(165, 20)
        Me.TextBox_amount.TabIndex = 1
        '
        'TextBox_description
        '
        Me.TextBox_description.Location = New System.Drawing.Point(270, 132)
        Me.TextBox_description.Multiline = True
        Me.TextBox_description.Name = "TextBox_description"
        Me.TextBox_description.Size = New System.Drawing.Size(165, 76)
        Me.TextBox_description.TabIndex = 2
        '
        'Button_add
        '
        Me.Button_add.Location = New System.Drawing.Point(355, 214)
        Me.Button_add.Name = "Button_add"
        Me.Button_add.Size = New System.Drawing.Size(80, 30)
        Me.Button_add.TabIndex = 3
        Me.Button_add.Text = "Add"
        Me.Button_add.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(103, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Amount"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(103, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Description"
        '
        'donations_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(492, 256)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_add)
        Me.Controls.Add(Me.TextBox_description)
        Me.Controls.Add(Me.TextBox_amount)
        Me.Controls.Add(Me.TextBox_name)
        Me.Name = "donations_add"
        Me.Text = "donations_add"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_name As TextBox
    Friend WithEvents TextBox_amount As TextBox
    Friend WithEvents TextBox_description As TextBox
    Friend WithEvents Button_add As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
