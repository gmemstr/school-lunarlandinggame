' Rocket Game by Gabriel Simmer, originally by Bill Gates (apparently)
' Created for IT 12 class
#Disable Warning BC42105 ' Function doesn't return a value on all code paths

Public Class GameWindow
    ' Functions for setting values as well as text boxes
    ' Helpful for keeping code cleaner
    Public Function AddToLog(val As String)
        GlobalVariables.log += val & vbNewLine
        LogBox.Text = GlobalVariables.log
    End Function

    Public Function SetTime(val As Integer)
        GlobalVariables.time = val
        TimeBox.Text = val.ToString
    End Function

    Public Function SetAlt(val As Integer)
        GlobalVariables.alt = val
        AltBox.Text = val.ToString
        ' Set picture box location at the same time
        RocketPicture.Top = RocketPicture.Top + GlobalVariables.speed / 3
    End Function

    Public Function SetSpeed(val As Integer)
        GlobalVariables.speed = val
        SpeedBox.Text = val.ToString
    End Function

    Public Function SetFuel(val As Integer)
        GlobalVariables.fuel = val
        FuelBox.Text = val.ToString
    End Function

    ' Set values for a new game
    Public Function NewGame()
        ' Stop audio if it's still playing for some reason?!
        My.Computer.Audio.Stop()
        RocketPicture.Image = My.Resources.ship
        BurnButton.Enabled = True
        AddToLog("------------ New Game ------------")
        ' Reset variables
        SetTime(0)
        SetAlt(1000)
        SetSpeed(40)
        SetFuel(400)
        RocketPicture.Top = Background.Top

        BurnRateSelector.Value = 0
    End Function

    Private Sub WindowLoads(sender As Object, e As EventArgs) Handles MyBase.Load
        ' On load, give rules and make new game
        AddToLog("The goal is to land with a speed of less than 10ft/s")
        NewGame()
    End Sub

    ' Reset game
    Private Sub NewGameButton_Click(sender As Object, e As EventArgs) Handles NewGameButton.Click
        NewGame()
    End Sub

    ' Handle burn button click, remove specified fuel and advance a tick
    Private Sub Burn_Click(sender As Object, e As EventArgs) Handles BurnButton.Click
        Dim BurntFuel As Integer = BurnRateSelector.Value

        ' Sophisticated anti-cheat
        If BurntFuel < 0 Then BurntFuel = 0 ' This is to prevent negative values giving user MORE fuel
        If BurntFuel > GlobalVariables.fuel Then BurntFuel = GlobalVariables.fuel ' This is to prevent negative fuel values
        ' Winners don't use drugs

        ' Difficulty for speed calculation
        SetSpeed(GlobalVariables.speed + (GlobalVariables.time / 4))

        ' Logic for figuring out speed, time, alt etc
        SetTime(GlobalVariables.time + 1)
        SetSpeed(GlobalVariables.speed - (BurntFuel * 0.75))
        SetFuel(GlobalVariables.fuel - BurntFuel)
        SetAlt(GlobalVariables.alt - GlobalVariables.speed)

        ' Check lose/win conditions (respectively)
        ' Add condition to log and disable "next turn" button
        If GlobalVariables.fuel <= 0 And GlobalVariables.alt > 0 Then
            My.Computer.Audio.Play(My.Resources.nofuel, AudioPlayMode.Background)
            AddToLog("You ran out of fuel!")
            BurnButton.Enabled = False
        End If
        If GlobalVariables.alt <= 0 And GlobalVariables.speed > 10 Then
            SetAlt(0)
            My.Computer.Audio.Play(My.Resources.CRASHCRASHCRASH, AudioPlayMode.Background)
            AddToLog("You crashed!")
            BurnButton.Enabled = False
        End If
        If GlobalVariables.alt <= 0 And GlobalVariables.speed < 10 Then
            SetAlt(0)
            My.Computer.Audio.Play(My.Resources.win, AudioPlayMode.Background)
            AddToLog("You Landed safely!")
            BurnButton.Enabled = False
        End If

    End Sub
End Class

' Global variables for keeping track of stats
Public Class GlobalVariables
    ' Define time, altitude, fuel and speed double variables
    Public Shared time, alt, fuel, speed As Double
    Public Shared log As String ' Log output
End Class