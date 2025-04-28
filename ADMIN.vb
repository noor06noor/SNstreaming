Public Class ADMIN

   
    Private Sub ADMIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'New_Microsoft_Access_DatabaseDataSet.projectdata' table. You can move, or remove it, as needed.
        Me.ProjectdataTableAdapter.Fill(Me.New_Microsoft_Access_DatabaseDataSet.projectdata)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim response As Integer
        response = MsgBox("are you sure do you want to quit?", MessageBoxButtons.YesNo)

        If response = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form4.Show()
        If Form4.Visible = True Then
            Me.Hide()
        End If
    End Sub

   
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ProjectdataBindingSource.MovePrevious()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox3.Text = "ADMIN" Then
            MsgBox("Cannot Delete Admin", MsgBoxStyle.Exclamation)

        Else
            ProjectdataBindingSource.RemoveCurrent()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ProjectdataBindingSource.MoveNext()

    End Sub
End Class