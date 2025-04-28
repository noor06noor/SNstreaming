Imports System.Data.OleDb
Public Class sub7



    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim response As Integer
        response = MsgBox("are you sure do you want to quit?", MessageBoxButtons.YesNo)

        If response = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sub5.Show()
        If sub5.Visible = True Then
            Me.Hide()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Button5.Visible = False
        Button1.Visible = False
        Label5.Visible = False
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        TextBox1.Visible = True
        TextBox2.Visible = True
        TextBox3.Visible = True
        PictureBox1.Visible = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        PictureBox4.Visible = True
        PictureBox5.Visible = True
        DateTimePicker1.Visible = True
        Button2.Visible = True
        ProjectdataBindingSource.AddNew()
        TextBox4.Text = uname
        TextBox5.Text = upass
        TextBox6.Text = subscription
        TextBox7.Text = "USER"
       
    End Sub

    Private Sub sub7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'New_Microsoft_Access_DatabaseDataSet.projectdata' table. You can move, or remove it, as needed.
        Me.ProjectdataTableAdapter.Fill(Me.New_Microsoft_Access_DatabaseDataSet.projectdata)
        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        DateTimePicker1.Visible = False
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Button2.Visible = False



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim systemdate As DateTime = DateTime.Now
        Dim selecteddate As DateTime = DateTimePicker1.Value
        Dim diff As TimeSpan = selecteddate - systemdate

        If TextBox2.Text = Nothing Or TextBox2.Text = Nothing Then
            MsgBox("enter proper name and last name")

        ElseIf TextBox1.Text.Length > 16 Or TextBox1.TextLength < 16 Then
            MsgBox("enter proper card number of 16 digits", MsgBoxStyle.Exclamation)


        ElseIf diff.TotalDays < 91 Then
            MsgBox("card to be expired soon, enter another card with expiry more than 3 months", MsgBoxStyle.Exclamation)

        Else



            On Error GoTo saveerror
            ProjectdataBindingSource.EndEdit()
            ProjectdataTableAdapter.Update(New_Microsoft_Access_DatabaseDataSet.projectdata)
            Dim response = MsgBox("Membership started", MsgBoxStyle.OkOnly)
            If response = vbOK Then
                abc = 1

                Form4.Show()
                Me.Hide()

            End If


saveerror:
            Exit Sub
        End If

    End Sub
End Class