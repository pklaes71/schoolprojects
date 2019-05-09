Public Class GameScoreForm

    'declare  and  set start quarter constant
    Const STARTQTR As Integer = 1

    'declare quarter length variable and quarter end time constant
    Dim QRTREND As Date = New Date(2016, 1, 1, 0, 0, 0)
    Dim qtrlngth As Date = New Date(2016, 1, 1, 0, 15, 0)

    'extra point constants array
    Dim epResults As String() = {"extra point made", "two point conversion made", "unsuccessful", "returned by opponent for 2 points"}

    'teams array
    Dim hometeams As String() = {"ARI", "ATL", "BAL", "BUF", "CAR", "CHI", "CIN", "CLE", "DAL", "DEN", "DET", "GB", "HOU", "IND", "JAK", "KC", "LA", "MIA", "MIN", "NE", "NO", "NYG", "NYJ", "OAK", "PHI", "PIT", "SD", "SEA", "SF", "TB", "TEN", "WASH"}
    Dim awayteams As String() = {"ARI", "ATL", "BAL", "BUF", "CAR", "CHI", "CIN", "CLE", "DAL", "DEN", "DET", "GB", "HOU", "IND", "JAK", "KC", "LA", "MIA", "MIN", "NE", "NO", "NYG", "NYJ", "OAK", "PHI", "PIT", "SD", "SEA", "SF", "TB", "TEN", "WASH"}
    Dim scoringteam As String() = {"HOME", "AWAY"}

    'Quarter scoring summary array
    Dim qrtrScoringarray As String() = {"1st Qtr", "2nd Qtr", "3rd Qtr", "4th Qtr", "OT"}

    'Team Mascot array
    Dim teamMascotarray As String() = {"Falcons", "Buccaneers", "Saints", "Panthers", "Cowboys", "Eagles", "Redskins", "Giants", "Cardinals", "Seahawks", "49s", "Rams", "Lions", "Packers", "Vikings", "Bears", "Raiders", "Broncos", "Chiefs", "Chargers", "Patriots", "Jets", "Dolphins", "Bills", "Jaguars", "Colts", "Titans", "Texans", "Browns", "Bengals", "Steelers", "Ravens"}

    'declare remaining variables
    Dim clock As Date = qtrlngth 'set the starting clock to the default quarter length
    Dim quarter As String
    Dim otPeriod As String
    Dim postSeason As Boolean
    Dim homeTeam As String
    Dim awayTeam As String
    Dim homeTeamscore As Integer = 0
    Dim awayTeamscore As Integer = 0
    Dim teamScoring As String
    Dim scoreSummary As String
    Dim quarterNumber As Integer
    Dim otNumber As Integer = 0







    Private Sub GameScoreForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'import the team selection boxes available values
        homeTeamComboBox.DataSource = hometeams
        awayTeamComboBox.DataSource = awayteams
        'import the extra point outcome possibilities and the team scoring possibilities
        epResultComboBox.DataSource = epResults
        teamScoringComboBox.DataSource = scoringteam
        'import and list the available team mascots
        scoresummaryTextBox.Text = "Pick the opposing teams from the following" & ControlChars.CrLf
        Dim p As Integer = 0
        Do
            scoresummaryTextBox.Text &= (teamMascotarray(p) & ControlChars.CrLf)
            p += 1
        Loop Until p = 32

    End Sub

    Private Sub newgameButton_Click(sender As Object, e As EventArgs) Handles newgameButton.Click

        'enable buttons and set game variables to their default values
        postSeasoncheckbox.Enabled = True
        quarterNumber = STARTQTR
        startclockButton.Enabled = True
        scoresummaryTextBox.Clear()
        quarter = Convert.ToString(quarterNumber)
        quarterTextBox.Text = quarter
        newgameButton.Enabled = False
        clock = qtrlngth
        clockLabel.Text = String.Format("{0:mm:ss}", clock)
        'reset teams, scores, scorelist, and score display
        homeTeam = ""
        awayTeam = ""
        homeTeamscore = 0
        awayTeamscore = 0
        homescoreTextBox.Text = "0"
        awayscoreTextBox.Text = "0"
        For i As Integer = 0 To 4
            qrtrScoringarray(i) = ""
        Next
        'display game instructions
        scoresummaryTextBox.Text = "Press New Game To Start. Then Select Home and Away Teams and Indicate Whether This Is A Post Season Game. To start, pause, or restart the clock press the Start and Stop buttons. To add a score, pause the clock, select the team scoring the points, select the type of points scored, and click the Add Score button. If a touchdown is scored; don't forget to select the extra point result from the drop-down list. The game will end automatically at the end of the fourth quarter if the score is not tied or at the end of any overtime period if the score is not tied. To end the game during an overtime quarter press the End Game button."


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        clock = clock.AddSeconds(-1)

        clockLabel.Text = String.Format("{0:mm:ss}", clock)
        'advance to next period at the end of the previous one
        If clock = QRTREND Then
            Timer1.Enabled = False
            startclockButton.Enabled = True
            clock = qtrlngth
            clockLabel.Text = String.Format("{0:mm:ss}", clock)

            QuarterChange()
        End If

    End Sub

    Sub QuarterChange()
        'if quarter is 1 through 3 advance to next quarter, and check to see if need to go to overtime at end of 4th quarter
        If quarterNumber < 4 Then
            quarterNumber += 1
            quarter = Convert.ToString(quarterNumber)
            quarterTextBox.Text = quarter
        ElseIf quarterNumber >= 4 And homeTeamscore = awayTeamscore Then 'if score is tie at end of 4th quarter, advance to overtime, if not go to end game
            quarterNumber += 1
            OvertimePeriod()
        Else
            EndGame()
        End If
    End Sub

    Sub OvertimePeriod()

        quarter = "OT"
        quarterTextBox.Text = quarter
        otNumber += 1
        otPeriod = Convert.ToString(otNumber)
        endGameButton.Enabled = True

        'play first overtime quarter
        If otNumber = 1 Then
            Exit Sub
        End If

        'check to see if game game needs to be continued if score is still tied at the end of the first OT period
        If postSeasoncheckbox.Checked = False And otNumber > 1 Then
            EndGame()
        End If
        If postSeasoncheckbox.Checked = True And otNumber > 1 And homeTeamscore = awayTeamscore Then 'post season games can not end in a tie
            Exit Sub
        Else
            EndGame()

        End If



    End Sub



    Private Sub addscoreButton_Click(sender As Object, e As EventArgs) Handles addscoreButton.Click


        If teamScoringComboBox.Text = scoringteam(0) Then
            If safetyRadioButton.Checked = True Then
                homeTeamscore += 2
                If quarterNumber = 1 Then
                    qrtrScoringarray(0) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & homeTeam & " " & "gets a safety")
                ElseIf quarterNumber = 2 Then
                    qrtrScoringarray(1) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & homeTeam & " " & "gets a safety")
                ElseIf quarterNumber = 3 Then
                    qrtrScoringarray(2) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & homeTeam & " " & "gets a safety")
                ElseIf quarterNumber = 4 Then
                    qrtrScoringarray(3) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & homeTeam & " " & "gets a safety")
                Else
                    qrtrScoringarray(4) &= (ControlChars.CrLf & "OT" & otPeriod & " " & clockLabel.Text & " " & homeTeam & " " & "gets a safety")
                End If
            End If
            If fgRadioButton.Checked = True Then
                homeTeamscore += 3
                If quarterNumber = 1 Then
                    qrtrScoringarray(0) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & homeTeam & " " & "field goal")
                ElseIf quarterNumber = 2 Then
                    qrtrScoringarray(1) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & homeTeam & " " & "field goal")
                ElseIf quarterNumber = 3 Then
                    qrtrScoringarray(2) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & homeTeam & " " & "field goal")
                ElseIf quarterNumber = 4 Then
                    qrtrScoringarray(3) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & homeTeam & " " & "field goal")
                Else
                    qrtrScoringarray(4) &= (ControlChars.CrLf & "OT" & otPeriod & " " & clockLabel.Text & " " & homeTeam & " " & "field goal")
                End If
            End If
            If tdRadioButton.Checked = True Then
                Select Case epResultComboBox.Text
                    Case Is = epResults(0)
                        homeTeamscore += 7
                        If quarterNumber = 1 Then
                            qrtrScoringarray(0) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & homeTeam & " " & "touchdown and exra point")
                        ElseIf quarterNumber = 2 Then
                            qrtrScoringarray(1) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & homeTeam & " " & "touchdown and exra point")
                        ElseIf quarterNumber = 3 Then
                            qrtrScoringarray(2) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & homeTeam & " " & "touchdown and exra point")
                        ElseIf quarterNumber = 4 Then
                            qrtrScoringarray(3) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & homeTeam & " " & "touchdown and exra point")
                        Else
                            qrtrScoringarray(4) &= (ControlChars.CrLf & "OT" & otPeriod & " " & clockLabel.Text & " " & homeTeam & " " & "touchdown and exra point")
                        End If
                    Case Is = epResults(1)
                        homeTeamscore += 8
                        If quarterNumber = 1 Then
                            qrtrScoringarray(0) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & homeTeam & " " & "touchdown and two point conversion")
                        ElseIf quarterNumber = 2 Then
                            qrtrScoringarray(1) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & homeTeam & " " & "touchdown and two point conversion")
                        ElseIf quarterNumber = 3 Then
                            qrtrScoringarray(2) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & homeTeam & " " & "touchdown and two point conversion")
                        ElseIf quarterNumber = 4 Then
                            qrtrScoringarray(3) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & homeTeam & " " & "touchdown and two point conversion")
                        Else
                            qrtrScoringarray(4) &= (ControlChars.CrLf & "OT" & otPeriod & " " & clockLabel.Text & " " & homeTeam & " " & "touchdown and two point conversion")
                        End If
                    Case Is = epResults(2)
                        homeTeamscore += 6
                        If quarterNumber = 1 Then
                            qrtrScoringarray(0) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & homeTeam & " " & "touchdown and missed extra point or two point conversion")
                        ElseIf quarterNumber = 2 Then
                            qrtrScoringarray(1) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & homeTeam & " " & "touchdown and missed extra point or two point conversion")
                        ElseIf quarterNumber = 3 Then
                            qrtrScoringarray(2) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & homeTeam & " " & "touchdown and missed extra point or two point conversion")
                        ElseIf quarterNumber = 4 Then
                            qrtrScoringarray(3) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & homeTeam & " " & "touchdown and missed extra point or two point conversion")
                        Else
                            qrtrScoringarray(4) &= (ControlChars.CrLf & "OT" & otPeriod & " " & clockLabel.Text & " " & homeTeam & " " & "touchdown and missed extra point or two point conversion")
                        End If
                    Case Is = epResults(3)
                        homeTeamscore += 6
                        awayTeamscore += 2
                        If quarterNumber = 1 Then
                            qrtrScoringarray(0) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & homeTeam & " " & "touchdown but extra point returned by opponent for 2")
                        ElseIf quarterNumber = 2 Then
                            qrtrScoringarray(1) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & homeTeam & " " & "touchdown but extra point returned by opponent for 2")
                        ElseIf quarterNumber = 3 Then
                            qrtrScoringarray(2) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & homeTeam & " " & "touchdown but extra point returned by opponent for 2")
                        ElseIf quarterNumber = 4 Then
                            qrtrScoringarray(3) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & homeTeam & " " & "touchdown but extra point returned by opponent for 2")
                        Else
                            qrtrScoringarray(4) &= (ControlChars.CrLf & "OT" & otPeriod & " " & clockLabel.Text & " " & homeTeam & " " & "touchdown but extra point returned by opponent for 2")
                        End If
                End Select
            End If

        End If

        If teamScoringComboBox.Text = scoringteam(1) Then
            If safetyRadioButton.Checked = True Then
                awayTeamscore += 2
                If quarterNumber = 1 Then
                    qrtrScoringarray(0) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & awayTeam & " " & "gets a safety")
                ElseIf quarterNumber = 2 Then
                    qrtrScoringarray(1) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & awayTeam & " " & "gets a safety")
                ElseIf quarterNumber = 3 Then
                    qrtrScoringarray(2) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & awayTeam & " " & "gets a safety")
                ElseIf quarterNumber = 4 Then
                    qrtrScoringarray(3) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & awayTeam & " " & "gets a safety")
                Else
                    qrtrScoringarray(4) &= (ControlChars.CrLf & "OT" & otPeriod & " " & clockLabel.Text & " " & awayTeam & " " & "gets a safety")
                End If
            End If
            If fgRadioButton.Checked = True Then
                awayTeamscore += 3
                If quarterNumber = 1 Then
                    qrtrScoringarray(0) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & awayTeam & " " & "field goal")
                ElseIf quarterNumber = 2 Then
                    qrtrScoringarray(1) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & awayTeam & " " & "field goal")
                ElseIf quarterNumber = 3 Then
                    qrtrScoringarray(2) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & awayTeam & " " & "field goal")
                ElseIf quarterNumber = 4 Then
                    qrtrScoringarray(3) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & awayTeam & " " & "field goal")
                Else
                    qrtrScoringarray(4) &= (ControlChars.CrLf & "OT" & otPeriod & " " & clockLabel.Text & " " & awayTeam & " " & "field goal")
                End If
            End If
            If tdRadioButton.Checked = True Then
                Select Case epResultComboBox.Text
                    Case Is = epResults(0)
                        awayTeamscore += 7
                        If quarterNumber = 1 Then
                            qrtrScoringarray(0) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & awayTeam & " " & "touchdown and exra point")
                        ElseIf quarterNumber = 2 Then
                            qrtrScoringarray(1) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & awayTeam & " " & "touchdown and exra point")
                        ElseIf quarterNumber = 3 Then
                            qrtrScoringarray(2) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & awayTeam & " " & "touchdown and exra point")
                        ElseIf quarterNumber = 4 Then
                            qrtrScoringarray(3) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & awayTeam & " " & "touchdown and exra point")
                        Else
                            qrtrScoringarray(4) &= (ControlChars.CrLf & "OT" & otPeriod & " " & clockLabel.Text & " " & awayTeam & " " & "touchdown and exra point")
                        End If
                    Case Is = epResults(1)
                        awayTeamscore += 8
                        If quarterNumber = 1 Then
                            qrtrScoringarray(0) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & awayTeam & " " & "touchdown and two point conversion")
                        ElseIf quarterNumber = 2 Then
                            qrtrScoringarray(1) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & awayTeam & " " & "touchdown and two point conversion")
                        ElseIf quarterNumber = 3 Then
                            qrtrScoringarray(2) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & awayTeam & " " & "touchdown and two point conversion")
                        ElseIf quarterNumber = 4 Then
                            qrtrScoringarray(3) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & awayTeam & " " & "touchdown and two point conversion")
                        Else
                            qrtrScoringarray(4) &= (ControlChars.CrLf & "OT" & otPeriod & " " & clockLabel.Text & " " & awayTeam & " " & "touchdown and two point conversion")
                        End If
                    Case Is = epResults(2)
                        awayTeamscore += 6
                        If quarterNumber = 1 Then
                            qrtrScoringarray(0) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & awayTeam & " " & "touchdown and missed extra point or two point conversion")
                        ElseIf quarterNumber = 2 Then
                            qrtrScoringarray(1) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & awayTeam & " " & "touchdown and missed extra point or two point conversion")
                        ElseIf quarterNumber = 3 Then
                            qrtrScoringarray(2) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & awayTeam & " " & "touchdown and missed extra point or two point conversion")
                        ElseIf quarterNumber = 4 Then
                            qrtrScoringarray(3) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & awayTeam & " " & "touchdown and missed extra point or two point conversion")
                        Else
                            qrtrScoringarray(4) &= (ControlChars.CrLf & "OT" & otPeriod & " " & clockLabel.Text & " " & awayTeam & " " & "touchdown and missed extra point or two point conversion")
                        End If
                    Case Is = epResults(3)
                        homeTeamscore += 2
                        awayTeamscore += 6
                        If quarterNumber = 1 Then
                            qrtrScoringarray(0) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & awayTeam & " " & "touchdown but extra point returned by opponent for 2")
                        ElseIf quarterNumber = 2 Then
                            qrtrScoringarray(1) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & awayTeam & " " & "touchdown but extra point returned by opponent for 2")
                        ElseIf quarterNumber = 3 Then
                            qrtrScoringarray(2) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & awayTeam & " " & "touchdown but extra point returned by opponent for 2")
                        ElseIf quarterNumber = 4 Then
                            qrtrScoringarray(3) &= (ControlChars.CrLf & "QTR" & quarter & " " & clockLabel.Text & " " & awayTeam & " " & "touchdown but extra point returned by opponent for 2")
                        Else
                            qrtrScoringarray(4) &= (ControlChars.CrLf & "OT" & otPeriod & " " & clockLabel.Text & " " & awayTeam & " " & "touchdown but extra point returned by opponent for 2")
                        End If

                End Select
            End If

        End If

        homescoreTextBox.Text = Convert.ToString(homeTeamscore)
        awayscoreTextBox.Text = Convert.ToString(awayTeamscore)
    End Sub

    Private Sub endGameButton_Click(sender As Object, e As EventArgs) Handles endGameButton.Click

        EndGame()



    End Sub

    Sub EndGame()

        'disable timer and in game buttons
        Timer1.Enabled = False
        startclockButton.Enabled = False
        stopButton.Enabled = False
        addscoreButton.Enabled = False
        endGameButton.Enabled = False

        'enable new game button
        newgameButton.Enabled = True
        For i As Integer = 0 To 4
            scoresummaryTextBox.Text &= (qrtrScoringarray(i)) & ControlChars.CrLf

        Next
    End Sub

    Private Sub startclockButton_Click(sender As Object, e As EventArgs) Handles startclockButton.Click

        'set home and away team values
        homeTeam = homeTeamComboBox.Text
        awayTeam = awayTeamComboBox.Text


        'display error message if home team and away team are the same
        If homeTeam = awayTeam Then

            MessageBox.Show("Home team and Away team cannot be the same", "Please correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Timer1.Enabled = True
            stopButton.Enabled = True
            startclockButton.Enabled = False

        End If

    End Sub

    Private Sub stopButton_Click(sender As Object, e As EventArgs) Handles stopButton.Click

        Timer1.Enabled = False
        stopButton.Enabled = False
        startclockButton.Enabled = True
        addscoreButton.Enabled = True
    End Sub
End Class
