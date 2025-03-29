<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WNDMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WNDMain))
        PBXSound = New PictureBox()
        LBLTitle = New Label()
        BTNInstructions = New Label()
        BTNStart = New Label()
        LBLInstructions = New Label()
        LBLTime = New Label()
        LBLQuestionNumber = New Label()
        LBLNumber1 = New Label()
        LBLOperator = New Label()
        LBLNumber2 = New Label()
        LBLEqual = New Label()
        TBXAnswer = New TextBox()
        BTNContinue = New Label()
        Timer = New Timer(components)
        LBLError = New Label()
        BTNRestart = New Label()
        LBLWonQuestionsInfo = New Label()
        LBLWonPercentageInfo = New Label()
        LBLWonQuestions = New Label()
        LBLWonPercentage = New Label()
        PBXStars = New PictureBox()
        CType(PBXSound, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBXStars, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PBXSound
        ' 
        PBXSound.BackColor = Color.Transparent
        PBXSound.Image = My.Resources.Resources.Unmute
        PBXSound.Location = New Point(896, 12)
        PBXSound.Name = "PBXSound"
        PBXSound.Size = New Size(50, 50)
        PBXSound.SizeMode = PictureBoxSizeMode.Zoom
        PBXSound.TabIndex = 0
        PBXSound.TabStop = False
        ' 
        ' LBLTitle
        ' 
        LBLTitle.BackColor = Color.Transparent
        LBLTitle.Font = New Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LBLTitle.ForeColor = Color.White
        LBLTitle.Location = New Point(27, 12)
        LBLTitle.Name = "LBLTitle"
        LBLTitle.Size = New Size(293, 134)
        LBLTitle.TabIndex = 1
        LBLTitle.Text = "L’empire arithmétique"
        LBLTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BTNInstructions
        ' 
        BTNInstructions.BackColor = Color.Transparent
        BTNInstructions.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNInstructions.ForeColor = Color.White
        BTNInstructions.Location = New Point(38, 504)
        BTNInstructions.Name = "BTNInstructions"
        BTNInstructions.Size = New Size(268, 113)
        BTNInstructions.TabIndex = 3
        BTNInstructions.Text = "Instructions"
        BTNInstructions.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BTNStart
        ' 
        BTNStart.BackColor = Color.Transparent
        BTNStart.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNStart.ForeColor = Color.White
        BTNStart.Location = New Point(38, 260)
        BTNStart.Name = "BTNStart"
        BTNStart.Size = New Size(268, 114)
        BTNStart.TabIndex = 2
        BTNStart.Text = "Débuter"
        BTNStart.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LBLInstructions
        ' 
        LBLInstructions.BackColor = Color.Transparent
        LBLInstructions.Font = New Font("Comic Sans MS", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLInstructions.ForeColor = Color.White
        LBLInstructions.Location = New Point(36, 341)
        LBLInstructions.Name = "LBLInstructions"
        LBLInstructions.Padding = New Padding(15)
        LBLInstructions.Size = New Size(271, 342)
        LBLInstructions.TabIndex = 4
        LBLInstructions.Text = resources.GetString("LBLInstructions.Text")
        LBLInstructions.Visible = False
        ' 
        ' LBLTime
        ' 
        LBLTime.BackColor = Color.Transparent
        LBLTime.Font = New Font("Comic Sans MS", 40F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLTime.ForeColor = Color.White
        LBLTime.Location = New Point(366, 92)
        LBLTime.Name = "LBLTime"
        LBLTime.Size = New Size(228, 97)
        LBLTime.TabIndex = 5
        LBLTime.Text = "00 : 00"
        LBLTime.TextAlign = ContentAlignment.MiddleCenter
        LBLTime.Visible = False
        ' 
        ' LBLQuestionNumber
        ' 
        LBLQuestionNumber.BackColor = Color.Transparent
        LBLQuestionNumber.Font = New Font("Comic Sans MS", 19F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLQuestionNumber.ForeColor = Color.White
        LBLQuestionNumber.Location = New Point(16, 15)
        LBLQuestionNumber.Name = "LBLQuestionNumber"
        LBLQuestionNumber.Size = New Size(67, 39)
        LBLQuestionNumber.TabIndex = 6
        LBLQuestionNumber.Text = "#1"
        LBLQuestionNumber.TextAlign = ContentAlignment.MiddleCenter
        LBLQuestionNumber.Visible = False
        ' 
        ' LBLNumber1
        ' 
        LBLNumber1.BackColor = Color.Transparent
        LBLNumber1.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLNumber1.Location = New Point(71, 319)
        LBLNumber1.Name = "LBLNumber1"
        LBLNumber1.Size = New Size(130, 82)
        LBLNumber1.TabIndex = 7
        LBLNumber1.Text = "1"
        LBLNumber1.TextAlign = ContentAlignment.MiddleCenter
        LBLNumber1.Visible = False
        ' 
        ' LBLOperator
        ' 
        LBLOperator.BackColor = Color.Transparent
        LBLOperator.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLOperator.Location = New Point(221, 319)
        LBLOperator.Name = "LBLOperator"
        LBLOperator.Size = New Size(130, 82)
        LBLOperator.TabIndex = 8
        LBLOperator.Text = "+"
        LBLOperator.TextAlign = ContentAlignment.MiddleCenter
        LBLOperator.Visible = False
        ' 
        ' LBLNumber2
        ' 
        LBLNumber2.BackColor = Color.Transparent
        LBLNumber2.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLNumber2.Location = New Point(371, 319)
        LBLNumber2.Name = "LBLNumber2"
        LBLNumber2.Size = New Size(130, 82)
        LBLNumber2.TabIndex = 9
        LBLNumber2.Text = "1"
        LBLNumber2.TextAlign = ContentAlignment.MiddleCenter
        LBLNumber2.Visible = False
        ' 
        ' LBLEqual
        ' 
        LBLEqual.BackColor = Color.Transparent
        LBLEqual.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLEqual.Location = New Point(521, 319)
        LBLEqual.Name = "LBLEqual"
        LBLEqual.Size = New Size(130, 82)
        LBLEqual.TabIndex = 10
        LBLEqual.Text = "="
        LBLEqual.TextAlign = ContentAlignment.MiddleCenter
        LBLEqual.Visible = False
        ' 
        ' TBXAnswer
        ' 
        TBXAnswer.BackColor = Color.FromArgb(CByte(207), CByte(226), CByte(243))
        TBXAnswer.BorderStyle = BorderStyle.None
        TBXAnswer.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBXAnswer.Location = New Point(671, 329)
        TBXAnswer.Margin = New Padding(0)
        TBXAnswer.Name = "TBXAnswer"
        TBXAnswer.Size = New Size(219, 56)
        TBXAnswer.TabIndex = 11
        TBXAnswer.TextAlign = HorizontalAlignment.Center
        TBXAnswer.Visible = False
        ' 
        ' BTNContinue
        ' 
        BTNContinue.BackColor = Color.Transparent
        BTNContinue.Font = New Font("Comic Sans MS", 40F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNContinue.ForeColor = Color.White
        BTNContinue.Location = New Point(326, 538)
        BTNContinue.Name = "BTNContinue"
        BTNContinue.Size = New Size(307, 93)
        BTNContinue.TabIndex = 12
        BTNContinue.Text = "Continuer"
        BTNContinue.TextAlign = ContentAlignment.MiddleCenter
        BTNContinue.Visible = False
        ' 
        ' Timer
        ' 
        Timer.Interval = 1000
        ' 
        ' LBLError
        ' 
        LBLError.BackColor = Color.Transparent
        LBLError.Font = New Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLError.ForeColor = Color.Navy
        LBLError.Location = New Point(297, 659)
        LBLError.Name = "LBLError"
        LBLError.Size = New Size(380, 24)
        LBLError.TabIndex = 13
        LBLError.Text = "Veuillez entrer une valeure numérique!"
        LBLError.TextAlign = ContentAlignment.MiddleCenter
        LBLError.Visible = False
        ' 
        ' BTNRestart
        ' 
        BTNRestart.BackColor = Color.Transparent
        BTNRestart.Font = New Font("Comic Sans MS", 40F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNRestart.ForeColor = Color.White
        BTNRestart.Location = New Point(283, 576)
        BTNRestart.Name = "BTNRestart"
        BTNRestart.Size = New Size(395, 95)
        BTNRestart.TabIndex = 14
        BTNRestart.Text = "Recommencer"
        BTNRestart.TextAlign = ContentAlignment.MiddleCenter
        BTNRestart.Visible = False
        ' 
        ' LBLWonQuestionsInfo
        ' 
        LBLWonQuestionsInfo.BackColor = Color.Transparent
        LBLWonQuestionsInfo.Font = New Font("Comic Sans MS", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLWonQuestionsInfo.ForeColor = Color.White
        LBLWonQuestionsInfo.Location = New Point(242, 326)
        LBLWonQuestionsInfo.Name = "LBLWonQuestionsInfo"
        LBLWonQuestionsInfo.Size = New Size(354, 81)
        LBLWonQuestionsInfo.TabIndex = 15
        LBLWonQuestionsInfo.Text = "Questions correctes"
        LBLWonQuestionsInfo.TextAlign = ContentAlignment.MiddleCenter
        LBLWonQuestionsInfo.Visible = False
        ' 
        ' LBLWonPercentageInfo
        ' 
        LBLWonPercentageInfo.BackColor = Color.Transparent
        LBLWonPercentageInfo.Font = New Font("Comic Sans MS", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLWonPercentageInfo.ForeColor = Color.White
        LBLWonPercentageInfo.Location = New Point(242, 429)
        LBLWonPercentageInfo.Name = "LBLWonPercentageInfo"
        LBLWonPercentageInfo.Size = New Size(354, 81)
        LBLWonPercentageInfo.TabIndex = 16
        LBLWonPercentageInfo.Text = "Pourcentage de réussite"
        LBLWonPercentageInfo.TextAlign = ContentAlignment.MiddleCenter
        LBLWonPercentageInfo.Visible = False
        ' 
        ' LBLWonQuestions
        ' 
        LBLWonQuestions.BackColor = Color.Transparent
        LBLWonQuestions.Font = New Font("Comic Sans MS", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLWonQuestions.ForeColor = Color.White
        LBLWonQuestions.Location = New Point(618, 326)
        LBLWonQuestions.Name = "LBLWonQuestions"
        LBLWonQuestions.Size = New Size(100, 81)
        LBLWonQuestions.TabIndex = 17
        LBLWonQuestions.Text = "0"
        LBLWonQuestions.TextAlign = ContentAlignment.MiddleCenter
        LBLWonQuestions.Visible = False
        ' 
        ' LBLWonPercentage
        ' 
        LBLWonPercentage.BackColor = Color.Transparent
        LBLWonPercentage.Font = New Font("Comic Sans MS", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLWonPercentage.ForeColor = Color.White
        LBLWonPercentage.Location = New Point(618, 429)
        LBLWonPercentage.Name = "LBLWonPercentage"
        LBLWonPercentage.Size = New Size(100, 81)
        LBLWonPercentage.TabIndex = 18
        LBLWonPercentage.Text = "0%"
        LBLWonPercentage.TextAlign = ContentAlignment.MiddleCenter
        LBLWonPercentage.Visible = False
        ' 
        ' PBXStars
        ' 
        PBXStars.BackColor = Color.Transparent
        PBXStars.Image = My.Resources.Resources.Étoiles_0
        PBXStars.Location = New Point(221, 176)
        PBXStars.Name = "PBXStars"
        PBXStars.Size = New Size(532, 90)
        PBXStars.SizeMode = PictureBoxSizeMode.Zoom
        PBXStars.TabIndex = 19
        PBXStars.TabStop = False
        PBXStars.Visible = False
        ' 
        ' WNDMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Page_1
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(958, 718)
        Controls.Add(PBXStars)
        Controls.Add(LBLWonPercentage)
        Controls.Add(LBLWonQuestions)
        Controls.Add(LBLWonPercentageInfo)
        Controls.Add(LBLWonQuestionsInfo)
        Controls.Add(BTNRestart)
        Controls.Add(LBLError)
        Controls.Add(BTNContinue)
        Controls.Add(TBXAnswer)
        Controls.Add(LBLEqual)
        Controls.Add(LBLNumber2)
        Controls.Add(LBLOperator)
        Controls.Add(LBLNumber1)
        Controls.Add(LBLQuestionNumber)
        Controls.Add(LBLTime)
        Controls.Add(LBLInstructions)
        Controls.Add(LBLTitle)
        Controls.Add(BTNInstructions)
        Controls.Add(BTNStart)
        Controls.Add(PBXSound)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "WNDMain"
        Text = "L'empire arithmétique"
        CType(PBXSound, ComponentModel.ISupportInitialize).EndInit()
        CType(PBXStars, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PBXSound As PictureBox
    Friend WithEvents LBLTitle As Label
    Friend WithEvents BTNStart As Label
    Friend WithEvents BTNInstructions As Label
    Friend WithEvents LBLInstructions As Label
    Friend WithEvents LBLTime As Label
    Friend WithEvents LBLQuestionNumber As Label
    Friend WithEvents LBLNumber1 As Label
    Friend WithEvents LBLOperator As Label
    Friend WithEvents LBLNumber2 As Label
    Friend WithEvents LBLEqual As Label
    Friend WithEvents TBXAnswer As TextBox
    Friend WithEvents BTNContinue As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents LBLError As Label
    Friend WithEvents BTNRestart As Label
    Friend WithEvents LBLWonQuestionsInfo As Label
    Friend WithEvents LBLWonPercentageInfo As Label
    Friend WithEvents LBLWonQuestions As Label
    Friend WithEvents LBLWonPercentage As Label
    Friend WithEvents PBXStars As PictureBox

End Class
