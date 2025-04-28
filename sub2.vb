Public Class sub2

    Private Sub sub2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim response As Integer
        response = MsgBox("are you sure do you want to quit?", MessageBoxButtons.YesNo)

        If response = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sub3.Show()
        If sub3.Visible = True Then
            Me.Hide()
        End If
    End Sub
End Class