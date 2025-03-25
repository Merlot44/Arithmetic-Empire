Public Class WNDMain
    Private Sub BTNStart_Click(sender As Object, e As EventArgs) Handles BTNStart.Click
        LBLTitle.Visible = False
        BTNStart.Visible = False
        BTNInstructions.Visible = False
        LBLInstructions.Visible = False
        BackgroundImage = My.Resources.Page_3
    End Sub
    Private Sub BTNInstructions_Click(sender As Object, e As EventArgs) Handles BTNInstructions.Click
        BTNInstructions.Visible = False
        BackgroundImage = My.Resources.Page_2
        BTNStart.Location = New Point(38, 192)
        LBLInstructions.Visible = True
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
