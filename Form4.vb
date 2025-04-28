Public Class Form4

    Private Sub HorrorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub AwardWinningToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AwardWinningToolStripMenuItem.Click
        Form5.Show()
        If Form5.Visible = True Then
            Me.Hide()

        End If
    End Sub


    Private Sub HorrorToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HorrorToolStripMenuItem.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub BiographyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BiographyToolStripMenuItem.Click
        Me.Hide()
        bio.Show()

    End Sub

    Private Sub AnimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnimeToolStripMenuItem.Click
        Me.Hide()
        Anime.Show()

    End Sub

    Private Sub DramaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DramaToolStripMenuItem.Click
        Me.Hide()
        drama.Show()

    End Sub

    Private Sub DocumentaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DocumentaryToolStripMenuItem.Click
        Me.Hide()
        docu.Show()

    End Sub

    Private Sub AdventureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdventureToolStripMenuItem.Click
        Me.Hide()
        Adventure.Show()

    End Sub

    Private Sub KidsAndFamilyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KidsAndFamilyToolStripMenuItem.Click
        Me.Hide()
        kidsandfamily.Show()

    End Sub

    Private Sub SciFiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SciFiToolStripMenuItem.Click
        Me.Hide()
        scifi.Show()

    End Sub

    Private Sub ThrillerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThrillerToolStripMenuItem.Click
        Me.Hide()
        Thriller.Show()

    End Sub

    Private Sub RomanticToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RomanticToolStripMenuItem.Click
        Me.Hide()
        Romantic.Show()

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim response As Integer
        response = MsgBox("are you sure do you want to quit?", MessageBoxButtons.YesNo)

        If response = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub MoviesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoviesToolStripMenuItem.Click

    End Sub
End Class