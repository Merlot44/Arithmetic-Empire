﻿' Arithmetic Empire
' By Merlot44
' Date: 4/1/2025
' Version: 1.0.0
' Github Repository : www.github.com/Merlot44/Arithmetic-Empire/

Imports System.Drawing.Text

Public Class WNDMain
    ' Define game variables
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
    Public Score As Integer = 0
    Private Sub BTNStart_Click(sender As Object, e As EventArgs) Handles BTNStart.Click
        ' Verify sound status
        If Sound = True Then
            ' Play the click sound
            My.Computer.Audio.Play(My.Resources.Click, AudioPlayMode.Background)
        End If
        ' Start the timer
        Timer.Start()
        ' Hide unused elements
        LBLTitle.Visible = False
        BTNStart.Visible = False
        BTNInstructions.Visible = False
        LBLInstructions.Visible = False
        BackgroundImage = My.Resources.Page_3

        ' Set the question number to 1
        QuestionNumber = 1

        ' Show new elements
        LBLTime.Visible = True
        LBLQuestionNumber.Visible = True

        ' Initialize Randomisation function
        Randomize()

        ' Calculate random values
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

        ' Display the values
        LBLNumber1.Text = CStr(Number1)
        LBLNumber2.Text = CStr(Number2)

        ' Display the values for the question
        LBLNumber1.Visible = True
        LBLOperator.Visible = True
        LBLNumber2.Visible = True
        LBLEqual.Visible = True
        TBXAnswer.Visible = True
        BTNContinue.Visible = True
    End Sub
    Private Sub BTNInstructions_Click(sender As Object, e As EventArgs) Handles BTNInstructions.Click
        ' Verify sound status
        If Sound = True Then
            ' Play the click sound
            My.Computer.Audio.Play(My.Resources.Click, AudioPlayMode.Background)
        End If

        ' Show instructions
        BTNInstructions.Visible = False
        BackgroundImage = My.Resources.Page_2
        BTNStart.Location = New Point(38, 192)
        LBLInstructions.Visible = True
    End Sub

    ' Set labels to act as buttons
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

    ' Setup timer
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        ' Calculate time
        Time += 1
        TimeMin = Fix(Time / 60)
        TimeSec = Time - (60 * TimeMin)

        ' Display time
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
        ' Verify sound status
        If Sound = True Then
            ' Play the click sound
            My.Computer.Audio.Play(My.Resources.Click, AudioPlayMode.Background)
        End If

        ' Verify that the value is numeric
        If IsNumeric(TBXAnswer.Text) Then
            LBLError.Visible = False

            ' Store the user's choice
            Choice = CInt(TBXAnswer.Text)

            ' Increment the games played statistic
            GamesPlayed += 1

            ' Verify that the answer is right
            If Choice = Answer Then

                ' Increment the games won statistic
                GamesWon += 1
            End If

            ' Verify that it's not the last question
            If QuestionNumber < 10 Then
                ' Increment the number of the question
                QuestionNumber += 1

                ' Display the number of the question
                LBLQuestionNumber.Text = "#" + CStr(QuestionNumber)

                ' Calculate random values
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

                ' Display the values
                LBLNumber1.Text = CStr(Number1)
                LBLNumber2.Text = CStr(Number2)
            Else
                ' Stop playing sound
                Timer.Stop()

                ' Calculate a score based on elapsed time and correctly answered questions
                If Time <= 30 Then
                    Score = (GamesWon * 0.25) + 2.5
                ElseIf Time <= 45 Then
                    Score = (GamesWon * 0.25) + 2
                ElseIf Time <= 60 Then
                    Score = (GamesWon * 0.25) + 1.5
                ElseIf Time <= 75 Then
                    Score = (GamesWon * 0.25) + 1
                ElseIf Time <= 90 Then
                    Score = (GamesWon * 0.25) + 0.5
                Else
                    Score = GamesWon * 0.25
                End If

                ' Display a star-based score
                If Score > 4 And Score <= 5 Then
                    PBXStars.Image = My.Resources.Étoiles_5
                ElseIf Score > 3 And Score <= 4 Then
                    PBXStars.Image = My.Resources.Étoiles_4
                ElseIf Score > 2 And Score <= 3 Then
                    PBXStars.Image = My.Resources.Étoiles_3
                ElseIf Score > 1 And Score <= 2 Then
                    PBXStars.Image = My.Resources.Étoiles_2
                ElseIf Score > 0 And Score <= 1 Then
                    PBXStars.Image = My.Resources.Étoiles_1
                ElseIf Score <= 0 Then
                    PBXStars.Image = My.Resources.Étoiles_0
                End If

                ' Hide unnecessary elements
                LBLQuestionNumber.Visible = False
                LBLNumber1.Visible = False
                LBLOperator.Visible = False
                LBLNumber2.Visible = False
                TBXAnswer.Visible = False
                BTNContinue.Visible = False
                LBLEqual.Visible = False

                ' Reposition the chronometer
                LBLTime.Location = New Point(367, 31)
                LBLTime.Size = New Point(226, 94)

                ' Change the bachground
                BackgroundImage = My.Resources.Page_4

                ' Display statistics
                PBXStars.Visible = True
                LBLWonQuestionsInfo.Visible = True
                LBLWonQuestions.Text = CStr(GamesWon)
                LBLWonQuestions.Visible = True
                LBLWonPercentageInfo.Visible = True
                LBLWonPercentage.Text = CStr((GamesWon / GamesPlayed) * 100) + "%"
                LBLWonPercentage.Visible = True

                ' Display restart button
                BTNRestart.Visible = True
            End If
            ' Clear the answer field
            TBXAnswer.Text = ""
        Else
            ' Hide the error message
            LBLError.Visible = True
        End If
    End Sub

    Private Sub TBXAnswer_TextChanged(sender As Object, e As EventArgs) Handles TBXAnswer.TextChanged
        ' Hide the error message
        LBLError.Visible = False
    End Sub

    Private Sub BTNRestart_Click(sender As Object, e As EventArgs) Handles BTNRestart.Click
        ' Verify sound status
        If Sound = True Then
            ' Play the click sound
            My.Computer.Audio.Play(My.Resources.Click, AudioPlayMode.Background)
        End If

        ' Reset elements to starting state
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

        ' Clear Variables
        LBLTime.Text = "00 : 00"
        TBXAnswer.Text = ""
        LBLQuestionNumber.Text = "#1"
        LBLNumber1.Text = "1"
        LBLNumber2.Text = "1"
        LBLOperator.Text = "+"
        LBLWonQuestions.Text = "0"
        LBLWonPercentage.Text = "0%"
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
        Score = 0
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
