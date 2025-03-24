Public Class WNDMain
    Private Sub BTNStart_Click(sender As Object, e As EventArgs) Handles BTNStart.Click

    End Sub


    Private Sub BTNInstructions_Click(sender As Object, e As EventArgs) Handles BTNInstructions.Click
        LBLTitle.Visible = False
        BTNInstructions.Visible = False
        BackgroundImage = My.Resources.Page_2
        ' BTNStart.Location.Y = (38, 192)
    End Sub

    Private Sub PBXSound_Click(sender As Object, e As EventArgs) Handles PBXSound.Click

    End Sub

    Private Sub BTNStart_MouseHover(sender As Object, e As EventArgs) Handles BTNStart.MouseHover
        BTNStart.Cursor = Cursors.Hand
    End Sub
    Private Sub BTNInstructions_MouseHover(sender As Object, e As EventArgs) Handles BTNInstructions.MouseHover
        BTNInstructions.Cursor = Cursors.Hand
    End Sub

    Private Sub PBXSound_MouseHover(sender As Object, e As EventArgs) Handles PBXSound.MouseHover
        PBXSound.Cursor = Cursors.Hand
    End Sub
End Class
