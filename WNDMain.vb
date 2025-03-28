Imports System.Drawing.Text

Public Class WNDMain
    Public QuestionPeriod As Boolean = False
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
    Public StrNumber1 As String = ""
    Public StrNumber2 As String = ""
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
        Console.WriteLine(CStr(TimeSec))
        If TimeMin < 10 & TimeSec >= 10 Then
            LBLTime.Text = "0" + CStr(TimeMin) + " : " + CStr(TimeSec)
        ElseIf TimeMin >= 10 & TimeSec < 10 Then
            LBLTime.Text = CStr(TimeMin) + " : 0" + CStr(TimeSec)
        ElseIf TimeMin < 10 & TimeSec < 10 Then
            LBLTime.Text = "0" + CStr(TimeMin) + " : 0" + CStr(TimeSec)
        Else
            LBLTime.Text = CStr(TimeMin) + " : " + CStr(TimeSec)
        End If
    End Sub

    Private Sub BTNContinue_Click(sender As Object, e As EventArgs) Handles BTNContinue.Click
        If IsNumeric(TBXAnswer.Text) Then
            LBLError.Visible = False
            Choice = CInt(TBXAnswer.Text)
            GamesPlayed += 1
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

                If Choice = Answer Then
                    GamesWon += 1
                End If
            Else
                Timer.Stop()
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
            End If
            TBXAnswer.Text = ""
        Else
            LBLError.Visible = True
        End If
    End Sub

    Private Sub TBXAnswer_TextChanged(sender As Object, e As EventArgs) Handles TBXAnswer.TextChanged
        LBLError.Visible = False
    End Sub
End Class
