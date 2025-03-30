Imports System.Drawing.Text

Public Class WNDMain
    Public Time As Integer = 0
    Public TimeMin As Integer = 0
    Public TimeSec As Integer = 0
    Public OperatorVal As Integer = 0
    Public Number1 As Integer = 0
    Public Number2 As Integer = 0
    Public Answer As Integer = 0
    Public QuestionNumber As Integer = 0
    Public GamesPlayed As Integer = 0
    Public GamesWon As Integer = 0
    Public Choice As Integer = 0
    Public StrMin As String = ""
    Public StrSec As String = ""
    Public Sound As Boolean = True
    Private Sub BTNStart_Click(sender As Object, e As EventArgs) Handles BTNStart.Click
        Timer.Start()
        ' Hide unused elements
        LBLTitle.Visible = False
        BTNStart.Visible = False
        BTNInstructions.Visible = False
        LBLInstructions.Visible = False
        BackgroundImage = My.Resources.Page_3

        ' Set the question number to 1
        QuestionNumber = 1

        LBLTime.Visible = True
        LBLQuestionNumber.Visible = True

        Randomize()
        OperatorVal = Fix(Rnd() * 4)
        If OperatorVal = 0 Then
            LBLOperator.Text = "+"
            Number1 = Fix(Rnd() * 21)
            Number2 = Fix(Rnd() * 21)
            Answer = Number1 + Number2
        ElseIf OperatorVal = 1 Then
            LBLOperator.Text = "-"
            Answer = Fix(Rnd() * 21)
            Number2 = Fix(Rnd() * 21)
            Number1 = Answer + Number2
        ElseIf OperatorVal = 2 Then
            LBLOperator.Text = "×"
            Number1 = Fix(Rnd() * 21)
            Number2 = Fix(Rnd() * 21)
            Answer = Number1 * Number2
        ElseIf OperatorVal = 3 Then
            LBLOperator.Text = "÷"
            Answer = Fix(Rnd() * 21)
            Number2 = Fix((Rnd() * 21) + 1)
            Number1 = Answer * Number2
        End If


        LBLNumber1.Text = CStr(Number1)
        LBLNumber2.Text = CStr(Number2)

        LBLNumber1.Visible = True
        LBLOperator.Visible = True
        LBLNumber2.Visible = True
        LBLEqual.Visible = True
        TBXAnswer.Visible = True
        BTNContinue.Visible = True
        If Sound = True Then
            ' Play the click sound
            My.Computer.Audio.Play(My.Resources.Click, AudioPlayMode.Background)
        End If
    End Sub
    Private Sub BTNInstructions_Click(sender As Object, e As EventArgs) Handles BTNInstructions.Click
        BTNInstructions.Visible = False
        BackgroundImage = My.Resources.Page_2
        BTNStart.Location = New Point(38, 192)
        LBLInstructions.Visible = True
        If Sound = True Then
            ' Play the click sound
            My.Computer.Audio.Play(My.Resources.Click, AudioPlayMode.Background)
        End If
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
    Private Sub BTNContinue_MouseHover(sender As Object, e As EventArgs) Handles BTNContinue.MouseHover
        BTNContinue.Cursor = Cursors.Hand
    End Sub
    Private Sub BTNRestart_MouseHover(sender As Object, e As EventArgs) Handles BTNRestart.MouseHover
        BTNRestart.Cursor = Cursors.Hand
    End Sub
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Time += 1
        TimeMin = Fix(Time / 60)
        TimeSec = Time - (60 * TimeMin)
        If TimeMin < 10 Then
            StrMin = "0" + CStr(TimeMin)
        Else
            StrMin = CStr(TimeMin)
        End If
        If TimeSec < 10 Then
            StrSec = "0" + CStr(TimeSec)
        Else
            StrSec = CStr(TimeSec)
        End If
        LBLTime.Text = StrMin + " : " + StrSec
    End Sub

    Private Sub BTNContinue_Click(sender As Object, e As EventArgs) Handles BTNContinue.Click
        If IsNumeric(TBXAnswer.Text) Then
            LBLError.Visible = False
            Choice = CInt(TBXAnswer.Text)
            GamesPlayed += 1
            If Choice = Answer Then
                GamesWon += 1
            End If
            If QuestionNumber < 10 Then
                QuestionNumber += 1
                LBLQuestionNumber.Text = "#" + CStr(QuestionNumber)
                OperatorVal = Fix(Rnd() * 4)
                If OperatorVal = 0 Then
                    LBLOperator.Text = "+"
                    Number1 = Fix(Rnd() * 21)
                    Number2 = Fix(Rnd() * 21)
                    Answer = Number1 + Number2
                ElseIf OperatorVal = 1 Then
                    LBLOperator.Text = "-"
                    Answer = Fix(Rnd() * 21)
                    Number2 = Fix(Rnd() * 21)
                    Number1 = Answer + Number2
                ElseIf OperatorVal = 2 Then
                    LBLOperator.Text = "×"
                    Number1 = Fix(Rnd() * 21)
                    Number2 = Fix(Rnd() * 21)
                    Answer = Number1 * Number2
                ElseIf OperatorVal = 3 Then
                    LBLOperator.Text = "÷"
                    Answer = Fix(Rnd() * 21)
                    Number2 = Fix((Rnd() * 20) + 1)
                    Number1 = Answer * Number2
                End If
                LBLNumber1.Text = CStr(Number1)
                LBLNumber2.Text = CStr(Number2)
            Else
                If Time <= 15 Then
                    PBXStars.Image = My.Resources.Étoiles_5
                ElseIf Time <= 30 Then
                    PBXStars.Image = My.Resources.Étoiles_4
                ElseIf Time <= 60 Then
                    PBXStars.Image = My.Resources.Étoiles_3
                ElseIf Time <= 90 Then
                    PBXStars.Image = My.Resources.Étoiles_2
                ElseIf Time <= 135 Then
                    PBXStars.Image = My.Resources.Étoiles_1
                Else
                    PBXStars.Image = My.Resources.Étoiles_0
                End If
                Timer.Stop()
                PBXStars.Visible = True
                LBLQuestionNumber.Visible = False
                LBLNumber1.Visible = False
                LBLOperator.Visible = False
                LBLNumber2.Visible = False
                TBXAnswer.Visible = False
                BTNContinue.Visible = False
                LBLEqual.Visible = False
                LBLTime.Location = New Point(367, 31)
                LBLTime.Size = New Point(226, 94)
                BackgroundImage = My.Resources.Page_4
                LBLWonQuestionsInfo.Visible = True
                LBLWonQuestions.Text = CStr(GamesWon)
                LBLWonQuestions.Visible = True
                LBLWonPercentageInfo.Visible = True
                LBLWonPercentage.Text = CStr((GamesWon / GamesPlayed) * 100) + "%"
                LBLWonPercentage.Visible = True
                BTNRestart.Visible = True
            End If
            TBXAnswer.Text = ""
        Else
            LBLError.Visible = True
        End If
        If Sound = True Then
            ' Play the click sound
            My.Computer.Audio.Play(My.Resources.Click, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub TBXAnswer_TextChanged(sender As Object, e As EventArgs) Handles TBXAnswer.TextChanged
        LBLError.Visible = False
    End Sub

    Private Sub BTNRestart_Click(sender As Object, e As EventArgs) Handles BTNRestart.Click
        LBLTime.Visible = False
        PBXStars.Visible = False
        LBLWonQuestionsInfo.Visible = False
        LBLWonQuestions.Visible = False
        LBLWonPercentageInfo.Visible = False
        LBLWonPercentage.Visible = False
        BTNRestart.Visible = False
        BackgroundImage = My.Resources.Page_1
        LBLTitle.Visible = True
        BTNStart.Visible = True
        BTNInstructions.Visible = True
        LBLTime.Location = New Point(366, 92)
        LBLTime.Size = New Point(228, 97)
        BTNStart.Location = New Point(38, 260)

        LBLTime.Text = "00 : 00"
        TBXAnswer.Text = ""
        LBLQuestionNumber.Text = "#1"
        LBLNumber1.Text = "1"
        LBLNumber2.Text = "1"
        LBLOperator.Text = "+"
        LBLWonQuestions.Text = 0
        LBLWonPercentage.Text = 0%

        Time = 0
        TimeMin = 0
        TimeSec = 0
        OperatorVal = 0
        Number1 = 0
        Number2 = 0
        Answer = 0
        QuestionNumber = 0
        GamesPlayed = 0
        GamesWon = 0
        Choice = 0
        StrMin = ""
        StrSec = ""
        If Sound = True Then
            ' Play the click sound
            My.Computer.Audio.Play(My.Resources.Click, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub PBXSound_Click(sender As Object, e As EventArgs) Handles PBXSound.Click
        ' Change the sound status
        Sound = Not Sound

        If Sound = True Then
            ' Play the click sound
            My.Computer.Audio.Play(My.Resources.Click, AudioPlayMode.Background)

            ' Set the image to the green speaker
            PBXSound.Image = My.Resources.Unmute
        Else
            ' Stop all audio
            My.Computer.Audio.Stop()

            ' Set the image to the red speaker
            PBXSound.Image = My.Resources.Mute
        End If
    End Sub
End Class
