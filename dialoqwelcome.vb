Public Class dialoqwelcome
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        passwordwindow.Show()
        Me.Hide()

    End Sub

    Private Sub dialoqwelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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