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
        PBXSound = New PictureBox()
        LBLTitle = New Label()
        BTNInstructions = New Label()
        BTNStart = New Label()
        CType(PBXSound, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PBXSound
        ' 
        PBXSound.BackColor = Color.Transparent
        PBXSound.Image = My.Resources.Resources.Unmute
        PBXSound.Location = New Point(882, 12)
        PBXSound.Name = "PBXSound"
        PBXSound.Size = New Size(50, 50)
        PBXSound.SizeMode = PictureBoxSizeMode.Zoom
        PBXSound.TabIndex = 0
        PBXSound.TabStop = False
        ' 
        ' LBLTitle
        ' 
        LBLTitle.BackColor = Color.Transparent
        LBLTitle.Font = New Font("Viner Hand ITC", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        ' WNDMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Page_1
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(944, 681)
        Controls.Add(BTNInstructions)
        Controls.Add(LBLTitle)
        Controls.Add(BTNStart)
        Controls.Add(PBXSound)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "WNDMain"
        Text = "L'empire arithmétique"
        CType(PBXSound, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PBXSound As PictureBox
    Friend WithEvents LBLTitle As Label
    Friend WithEvents BTNStart As Label
    Friend WithEvents BTNInstructions As Label

End Class
