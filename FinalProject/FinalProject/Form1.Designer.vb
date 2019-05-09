<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameScoreForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.clockLabel = New System.Windows.Forms.Label()
        Me.postSeasoncheckbox = New System.Windows.Forms.CheckBox()
        Me.clockmgtGroupBox = New System.Windows.Forms.GroupBox()
        Me.stopButton = New System.Windows.Forms.Button()
        Me.endGameButton = New System.Windows.Forms.Button()
        Me.addscoreButton = New System.Windows.Forms.Button()
        Me.startclockButton = New System.Windows.Forms.Button()
        Me.newgameButton = New System.Windows.Forms.Button()
        Me.homeTeamLabel = New System.Windows.Forms.Label()
        Me.homescoreTextBox = New System.Windows.Forms.TextBox()
        Me.awayscoreTextBox = New System.Windows.Forms.TextBox()
        Me.awayTeamLabel = New System.Windows.Forms.Label()
        Me.teamscoringLabel = New System.Windows.Forms.Label()
        Me.qtrLabel = New System.Windows.Forms.Label()
        Me.quarterTextBox = New System.Windows.Forms.TextBox()
        Me.ScoretypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.EpresultLabel = New System.Windows.Forms.Label()
        Me.epResultComboBox = New System.Windows.Forms.ComboBox()
        Me.tdRadioButton = New System.Windows.Forms.RadioButton()
        Me.safetyRadioButton = New System.Windows.Forms.RadioButton()
        Me.fgRadioButton = New System.Windows.Forms.RadioButton()
        Me.scoresummaryTextBox = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.homeTeamComboBox = New System.Windows.Forms.ComboBox()
        Me.awayTeamComboBox = New System.Windows.Forms.ComboBox()
        Me.teamScoringComboBox = New System.Windows.Forms.ComboBox()
        Me.clockmgtGroupBox.SuspendLayout()
        Me.ScoretypeGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'clockLabel
        '
        Me.clockLabel.AutoSize = True
        Me.clockLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clockLabel.Location = New System.Drawing.Point(120, 13)
        Me.clockLabel.Name = "clockLabel"
        Me.clockLabel.Size = New System.Drawing.Size(77, 31)
        Me.clockLabel.TabIndex = 0
        Me.clockLabel.Text = "clock"
        '
        'postSeasoncheckbox
        '
        Me.postSeasoncheckbox.AutoSize = True
        Me.postSeasoncheckbox.Location = New System.Drawing.Point(376, 13)
        Me.postSeasoncheckbox.Name = "postSeasoncheckbox"
        Me.postSeasoncheckbox.Size = New System.Drawing.Size(86, 17)
        Me.postSeasoncheckbox.TabIndex = 1
        Me.postSeasoncheckbox.Text = "Post Season"
        Me.postSeasoncheckbox.UseVisualStyleBackColor = True
        '
        'clockmgtGroupBox
        '
        Me.clockmgtGroupBox.Controls.Add(Me.stopButton)
        Me.clockmgtGroupBox.Controls.Add(Me.endGameButton)
        Me.clockmgtGroupBox.Controls.Add(Me.addscoreButton)
        Me.clockmgtGroupBox.Controls.Add(Me.startclockButton)
        Me.clockmgtGroupBox.Controls.Add(Me.newgameButton)
        Me.clockmgtGroupBox.Location = New System.Drawing.Point(489, 13)
        Me.clockmgtGroupBox.Name = "clockmgtGroupBox"
        Me.clockmgtGroupBox.Size = New System.Drawing.Size(178, 158)
        Me.clockmgtGroupBox.TabIndex = 2
        Me.clockmgtGroupBox.TabStop = False
        Me.clockmgtGroupBox.Text = "Clock Mgt"
        '
        'stopButton
        '
        Me.stopButton.Enabled = False
        Me.stopButton.Location = New System.Drawing.Point(89, 50)
        Me.stopButton.Name = "stopButton"
        Me.stopButton.Size = New System.Drawing.Size(75, 23)
        Me.stopButton.TabIndex = 4
        Me.stopButton.Text = "Stop Clock"
        Me.stopButton.UseVisualStyleBackColor = True
        '
        'endGameButton
        '
        Me.endGameButton.Enabled = False
        Me.endGameButton.Location = New System.Drawing.Point(7, 120)
        Me.endGameButton.Name = "endGameButton"
        Me.endGameButton.Size = New System.Drawing.Size(75, 23)
        Me.endGameButton.TabIndex = 3
        Me.endGameButton.Text = "End Game"
        Me.endGameButton.UseVisualStyleBackColor = True
        '
        'addscoreButton
        '
        Me.addscoreButton.Enabled = False
        Me.addscoreButton.Location = New System.Drawing.Point(7, 80)
        Me.addscoreButton.Name = "addscoreButton"
        Me.addscoreButton.Size = New System.Drawing.Size(75, 23)
        Me.addscoreButton.TabIndex = 2
        Me.addscoreButton.Text = "Add Score"
        Me.addscoreButton.UseVisualStyleBackColor = True
        '
        'startclockButton
        '
        Me.startclockButton.Enabled = False
        Me.startclockButton.Location = New System.Drawing.Point(7, 50)
        Me.startclockButton.Name = "startclockButton"
        Me.startclockButton.Size = New System.Drawing.Size(75, 23)
        Me.startclockButton.TabIndex = 1
        Me.startclockButton.Text = "Start Clock"
        Me.startclockButton.UseVisualStyleBackColor = True
        '
        'newgameButton
        '
        Me.newgameButton.Location = New System.Drawing.Point(7, 20)
        Me.newgameButton.Name = "newgameButton"
        Me.newgameButton.Size = New System.Drawing.Size(75, 23)
        Me.newgameButton.TabIndex = 0
        Me.newgameButton.Text = "New Game"
        Me.newgameButton.UseVisualStyleBackColor = True
        '
        'homeTeamLabel
        '
        Me.homeTeamLabel.AutoSize = True
        Me.homeTeamLabel.Location = New System.Drawing.Point(30, 63)
        Me.homeTeamLabel.Name = "homeTeamLabel"
        Me.homeTeamLabel.Size = New System.Drawing.Size(65, 13)
        Me.homeTeamLabel.TabIndex = 3
        Me.homeTeamLabel.Text = "Home Team"
        '
        'homescoreTextBox
        '
        Me.homescoreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homescoreTextBox.Location = New System.Drawing.Point(123, 71)
        Me.homescoreTextBox.Name = "homescoreTextBox"
        Me.homescoreTextBox.Size = New System.Drawing.Size(73, 44)
        Me.homescoreTextBox.TabIndex = 5
        Me.homescoreTextBox.Text = "0"
        Me.homescoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'awayscoreTextBox
        '
        Me.awayscoreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.awayscoreTextBox.Location = New System.Drawing.Point(324, 71)
        Me.awayscoreTextBox.Name = "awayscoreTextBox"
        Me.awayscoreTextBox.Size = New System.Drawing.Size(73, 44)
        Me.awayscoreTextBox.TabIndex = 6
        Me.awayscoreTextBox.Text = "0"
        Me.awayscoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'awayTeamLabel
        '
        Me.awayTeamLabel.AutoSize = True
        Me.awayTeamLabel.Location = New System.Drawing.Point(403, 63)
        Me.awayTeamLabel.Name = "awayTeamLabel"
        Me.awayTeamLabel.Size = New System.Drawing.Size(63, 13)
        Me.awayTeamLabel.TabIndex = 7
        Me.awayTeamLabel.Text = "Away Team"
        '
        'teamscoringLabel
        '
        Me.teamscoringLabel.AutoSize = True
        Me.teamscoringLabel.Location = New System.Drawing.Point(138, 128)
        Me.teamscoringLabel.Name = "teamscoringLabel"
        Me.teamscoringLabel.Size = New System.Drawing.Size(73, 13)
        Me.teamscoringLabel.TabIndex = 10
        Me.teamscoringLabel.Text = "Team Scoring"
        '
        'qtrLabel
        '
        Me.qtrLabel.AutoSize = True
        Me.qtrLabel.Location = New System.Drawing.Point(391, 133)
        Me.qtrLabel.Name = "qtrLabel"
        Me.qtrLabel.Size = New System.Drawing.Size(30, 13)
        Me.qtrLabel.TabIndex = 11
        Me.qtrLabel.Text = "QTR"
        '
        'quarterTextBox
        '
        Me.quarterTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quarterTextBox.Location = New System.Drawing.Point(427, 129)
        Me.quarterTextBox.Name = "quarterTextBox"
        Me.quarterTextBox.Size = New System.Drawing.Size(56, 31)
        Me.quarterTextBox.TabIndex = 12
        '
        'ScoretypeGroupBox
        '
        Me.ScoretypeGroupBox.Controls.Add(Me.EpresultLabel)
        Me.ScoretypeGroupBox.Controls.Add(Me.epResultComboBox)
        Me.ScoretypeGroupBox.Controls.Add(Me.tdRadioButton)
        Me.ScoretypeGroupBox.Controls.Add(Me.safetyRadioButton)
        Me.ScoretypeGroupBox.Controls.Add(Me.fgRadioButton)
        Me.ScoretypeGroupBox.Location = New System.Drawing.Point(33, 202)
        Me.ScoretypeGroupBox.Name = "ScoretypeGroupBox"
        Me.ScoretypeGroupBox.Size = New System.Drawing.Size(200, 195)
        Me.ScoretypeGroupBox.TabIndex = 13
        Me.ScoretypeGroupBox.TabStop = False
        Me.ScoretypeGroupBox.Text = "Score Type"
        '
        'EpresultLabel
        '
        Me.EpresultLabel.AutoSize = True
        Me.EpresultLabel.Location = New System.Drawing.Point(6, 135)
        Me.EpresultLabel.Name = "EpresultLabel"
        Me.EpresultLabel.Size = New System.Drawing.Size(96, 13)
        Me.EpresultLabel.TabIndex = 16
        Me.EpresultLabel.Text = "PT after TD Result"
        '
        'epResultComboBox
        '
        Me.epResultComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.epResultComboBox.FormattingEnabled = True
        Me.epResultComboBox.Location = New System.Drawing.Point(1, 168)
        Me.epResultComboBox.MaxDropDownItems = 4
        Me.epResultComboBox.Name = "epResultComboBox"
        Me.epResultComboBox.Size = New System.Drawing.Size(193, 21)
        Me.epResultComboBox.TabIndex = 15
        '
        'tdRadioButton
        '
        Me.tdRadioButton.AutoSize = True
        Me.tdRadioButton.Location = New System.Drawing.Point(7, 104)
        Me.tdRadioButton.Name = "tdRadioButton"
        Me.tdRadioButton.Size = New System.Drawing.Size(82, 17)
        Me.tdRadioButton.TabIndex = 2
        Me.tdRadioButton.TabStop = True
        Me.tdRadioButton.Text = "Touchdown"
        Me.tdRadioButton.UseVisualStyleBackColor = True
        '
        'safetyRadioButton
        '
        Me.safetyRadioButton.AutoSize = True
        Me.safetyRadioButton.Location = New System.Drawing.Point(7, 67)
        Me.safetyRadioButton.Name = "safetyRadioButton"
        Me.safetyRadioButton.Size = New System.Drawing.Size(55, 17)
        Me.safetyRadioButton.TabIndex = 1
        Me.safetyRadioButton.TabStop = True
        Me.safetyRadioButton.Text = "Safety"
        Me.safetyRadioButton.UseVisualStyleBackColor = True
        '
        'fgRadioButton
        '
        Me.fgRadioButton.AutoSize = True
        Me.fgRadioButton.Location = New System.Drawing.Point(7, 31)
        Me.fgRadioButton.Name = "fgRadioButton"
        Me.fgRadioButton.Size = New System.Drawing.Size(72, 17)
        Me.fgRadioButton.TabIndex = 0
        Me.fgRadioButton.TabStop = True
        Me.fgRadioButton.Text = "Field Goal"
        Me.fgRadioButton.UseVisualStyleBackColor = True
        '
        'scoresummaryTextBox
        '
        Me.scoresummaryTextBox.Location = New System.Drawing.Point(262, 202)
        Me.scoresummaryTextBox.Multiline = True
        Me.scoresummaryTextBox.Name = "scoresummaryTextBox"
        Me.scoresummaryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.scoresummaryTextBox.Size = New System.Drawing.Size(399, 416)
        Me.scoresummaryTextBox.TabIndex = 14
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'homeTeamComboBox
        '
        Me.homeTeamComboBox.FormattingEnabled = True
        Me.homeTeamComboBox.Location = New System.Drawing.Point(34, 80)
        Me.homeTeamComboBox.MaxDropDownItems = 32
        Me.homeTeamComboBox.Name = "homeTeamComboBox"
        Me.homeTeamComboBox.Size = New System.Drawing.Size(78, 21)
        Me.homeTeamComboBox.TabIndex = 15
        '
        'awayTeamComboBox
        '
        Me.awayTeamComboBox.FormattingEnabled = True
        Me.awayTeamComboBox.Location = New System.Drawing.Point(405, 79)
        Me.awayTeamComboBox.MaxDropDownItems = 32
        Me.awayTeamComboBox.Name = "awayTeamComboBox"
        Me.awayTeamComboBox.Size = New System.Drawing.Size(78, 21)
        Me.awayTeamComboBox.TabIndex = 16
        '
        'teamScoringComboBox
        '
        Me.teamScoringComboBox.FormattingEnabled = True
        Me.teamScoringComboBox.Location = New System.Drawing.Point(217, 128)
        Me.teamScoringComboBox.Name = "teamScoringComboBox"
        Me.teamScoringComboBox.Size = New System.Drawing.Size(88, 21)
        Me.teamScoringComboBox.TabIndex = 17
        '
        'GameScoreForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 630)
        Me.Controls.Add(Me.teamScoringComboBox)
        Me.Controls.Add(Me.awayTeamComboBox)
        Me.Controls.Add(Me.homeTeamComboBox)
        Me.Controls.Add(Me.scoresummaryTextBox)
        Me.Controls.Add(Me.ScoretypeGroupBox)
        Me.Controls.Add(Me.quarterTextBox)
        Me.Controls.Add(Me.qtrLabel)
        Me.Controls.Add(Me.teamscoringLabel)
        Me.Controls.Add(Me.awayTeamLabel)
        Me.Controls.Add(Me.awayscoreTextBox)
        Me.Controls.Add(Me.homescoreTextBox)
        Me.Controls.Add(Me.homeTeamLabel)
        Me.Controls.Add(Me.clockmgtGroupBox)
        Me.Controls.Add(Me.postSeasoncheckbox)
        Me.Controls.Add(Me.clockLabel)
        Me.Name = "GameScoreForm"
        Me.Text = "Game Tracker"
        Me.clockmgtGroupBox.ResumeLayout(False)
        Me.ScoretypeGroupBox.ResumeLayout(False)
        Me.ScoretypeGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents clockLabel As System.Windows.Forms.Label
    Friend WithEvents postSeasoncheckbox As System.Windows.Forms.CheckBox
    Friend WithEvents clockmgtGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents endGameButton As System.Windows.Forms.Button
    Friend WithEvents addscoreButton As System.Windows.Forms.Button
    Friend WithEvents startclockButton As System.Windows.Forms.Button
    Friend WithEvents newgameButton As System.Windows.Forms.Button
    Friend WithEvents homeTeamLabel As System.Windows.Forms.Label
    Friend WithEvents homescoreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents awayscoreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents awayTeamLabel As System.Windows.Forms.Label
    Friend WithEvents teamscoringLabel As System.Windows.Forms.Label
    Friend WithEvents qtrLabel As System.Windows.Forms.Label
    Friend WithEvents quarterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ScoretypeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents tdRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents safetyRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents fgRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents scoresummaryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents epResultComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EpresultLabel As System.Windows.Forms.Label
    Friend WithEvents homeTeamComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents awayTeamComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents stopButton As System.Windows.Forms.Button
    Friend WithEvents teamScoringComboBox As System.Windows.Forms.ComboBox

End Class
