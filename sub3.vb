Imports System.Text.RegularExpressions

Public Class sub3

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim response As Integer
        response = MsgBox("are you sure do you want to quit?", MessageBoxButtons.YesNo)

        If response = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim emailPattern As String = "^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"
        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Then
            MsgBox("Please enter email and password")
        ElseIf Regex.IsMatch(TextBox1.Text, emailPattern) Then




            uname = TextBox1.Text
            upass = TextBox2.Text

            sub4.Show()
            If sub4.Visible = True Then
                Me.Hide()
            End If
        Else
            MsgBox("please enter correct email address")

        End If
    End Sub

    Public Sub sub3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim emailPattern As String = "^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"

    End Sub
   
End Class