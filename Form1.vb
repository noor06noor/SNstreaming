Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)
        PictureBox1.Width = 0 + ProgressBar1.Value * 5


        If ProgressBar1.Value = 100 Then
            Timer1.Stop()

            welcome.Show()
            If welcome.Visible = True Then
                Me.Hide()

            End If
        End If
    End Sub

    
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class
