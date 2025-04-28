Imports System.Data.OleDb


Public Class login

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        sub2.Show()
        If sub2.Visible = True Then
            Me.Hide()
        End If
    End Sub


    Public Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\New Microsoft Access Database.accdb"
        Dim conn As New OleDbConnection(connString)
        Dim cmd As New OleDbCommand()
        Dim username As String = TextBox2.Text
        Dim password As String = TextBox1.Text.Trim()
        Dim role As String = ComboBox1.Text


        Try
            conn.Open()
            If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Then
                MsgBox("Please fill details", MsgBoxStyle.Exclamation)


            ElseIf role = "ADMIN" Then
                cmd.CommandText = "SELECT * FROM projectdata WHERE Username = @username AND Password = @password"
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)
                cmd.Connection = conn
                Dim reader As OleDbDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    abc = 1

                    ' Login successful, open admin form
                    ADMIN.Show()

                    Me.Hide()
                Else
                    ' Invalid username or password for admin
                    MessageBox.Show("invalid admin")
                    TextBox1.Clear()
                    TextBox2.Clear()
                    ComboBox1.ResetText()

                End If
            ElseIf role = "USER" Then
                cmd.CommandText = "SELECT * FROM projectdata WHERE Username = @username AND Password = @password"
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)
                cmd.Connection = conn
                Dim reader As OleDbDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    ' Login successful, open form 4
                    Dim res As Integer = MsgBox("Login Success", MsgBoxStyle.OkOnly)
                    If res = vbOK Then

                        abc = 1
                        Form4.Show()
                        Me.Hide()
                    End If

                Else
                    ' Invalid username or password for user
                    Dim res1 As Integer = MsgBox("User Doesnot exists", MsgBoxStyle.OkCancel)
                    If res1 = vbOK Then
                        Dim res2 As Integer = MsgBox("login without userid", MsgBoxStyle.OkOnly)
                        If res2 = vbOK Then
                            Form4.Show()
                            Me.Hide()
                            abc = 2

                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'New_Microsoft_Access_DatabaseDataSet.projectdata' table. You can move, or remove it, as needed.
        TextBox1.Clear()
        TextBox2.Clear()
        ComboBox1.Refresh()

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim response As Integer
        response = MsgBox("are you sure do you want to quit?", MessageBoxButtons.YesNo)

        If response = vbYes Then
            Application.Exit()
        End If
    End Sub
End Class