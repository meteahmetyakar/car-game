Imports System.Data.SqlClient

Public Class CarRace
    'variable initializing start
    Dim way(2) As PictureBox
    Dim point As Integer
    Dim Start As Integer = 5
    Dim isMove As Boolean = False
    Dim health As Integer
    Dim enemy(2) As PictureBox
    Dim h(2) As PictureBox
    Dim TimerStartE As Boolean
    Dim GameOver As Boolean = False
    Dim oldCoordinate As Integer
    Dim newCoordinate As Integer
    Dim nick As String
    Dim isCarSelected As Boolean = False
    Dim conn As New SqlConnection
    Dim cmd As New SqlCommand

    'variable initializing start

    Private Sub TimerMoveRight_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerMoveRight.Tick
        If Not car.Bounds.IntersectsWith(rightWall.Bounds) Then 'if car do not collide to wall
            car.Left += 5
        End If

    End Sub

    Private Sub TimerMoveLeft_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerMoveLeft.Tick
        If car.Left > 0 Then 'if car is not on left side of window
            car.Left -= 5
        End If

    End Sub

    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Right And isMove = True Then 'when pressed right arrow
            TimerMoveRight.Start()
        End If
        If e.KeyCode = Keys.Left And isMove = True Then 'when pressed left arrow
            TimerMoveLeft.Start()
        End If
    End Sub

    Private Sub Form1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        TimerMoveLeft.Stop()
        TimerMoveRight.Stop()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        For x = 0 To 1
            way(x).Top += 4

            If way(x).Top >= Me.Height + 10 Then
                way(x).Top = -way(x).Height + 50
            End If
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '        conn.ConnectionString = "data source=desktop-5eıu9kb\sqlexpress;ınitial catalog=arabayarisi;ıntegrated security=true"


        '        nick = InputBox("Kullanıcı Adı Giriniz.")


        '        If nick <> "" Then
        '       cmd.CommandText = "Select * from oyuncular where kullaniciadi='" + nick + "'"
        ' cmd.Connection = conn

        '  conn.Open()

        ' Dim sr As SqlDataReader = cmd.ExecuteReader()

        '  If sr.Read() = False Then
        '  conn.Close()
        ' cmd.CommandText = "insert into oyuncular (kullaniciadi) values ('" + nick + "')"
        ' cmd.Connection = conn
        '  conn.Open()
        '  cmd.ExecuteNonQuery()
        '   End If

        ' conn.Close()
        ' End If


        way(0) = way2
        way(1) = way1

        enemy(0) = enemy1
        enemy(1) = enemy2
        enemy(2) = enemy3

        h(0) = health1
        h(1) = health2
        h(2) = health3

        For y = 0 To 2
            enemy(y).Top = -Int(Rnd() * 500) 'creating a enemy on random position
        Next
        GameOver = False
    End Sub

    Private Sub Timer_Time_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Time.Tick
        point += 1 'points increase during surviving
        score.Text = point
    End Sub

    Private Sub Timer_Start_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Start.Tick

        If Start > 0 Then
            Start -= 1
        End If
        countDown.Text = Start
        If Start = 0 Then
            'starting game, setting starting settings
            Timer_Time.Start()
            Timer1.Start()
            Timer_Cars.Start()
            countDown.Visible = False
            isMove = True
            Timer_Start.Stop()
            TimerStartE = True
        End If
        TimerStartE = True
    End Sub

    Private Sub Timer_Cars_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Cars.Tick
        For y = 0 To 2
            enemy(y).Top += 15 'enemies moving on game

            If enemy(y).Top > Me.Height Then
                Dim rand As New Random
                Dim carSpawnCoordinates() As Integer = {90, 146, 239, 332, 425}
                Dim num

                'A new spawn location is determined, provided that it does not start from the previous location
                Do While newCoordinate = oldCoordinate
                    num = rand.Next(0, 5)
                    newCoordinate = carSpawnCoordinates(num)
                Loop
                oldCoordinate = newCoordinate

                enemy(y).Location = New Point(newCoordinate, -Int(Rnd() * 600))

            End If

            If car.Bounds.IntersectsWith(enemy(y).Bounds) Then 'if car crash to enemy
                health += 1
                enemy(y).Top = -Int(Rnd() * 500) 'enemy goes outside the window
                h(health - 1).Hide() 'decrease the health
                If health = 3 Then 'if health equal to 3 this mean is all healths of player is over and then game will finish
                    Timer_Cars.Stop()
                    Timer_Time.Stop()
                    TimerMoveLeft.Stop()
                    TimerMoveRight.Stop()
                    Timer1.Stop()
                    isMove = False

                    ' -- DATABASE PART -- I CLOSED DATABASSE PART BECAUSE THIS PROJECT IS REALLY OLD AND I DID NOT WANT CREATE A NEW DATABASE FOR TRY THE GAME
                    'conn.ConnectionString = "Data Source=DESKTOP-5EIU9KB\SQLEXPRESS;Initial Catalog=ArabaYarisi;Integrated Security=True"
                    ' cmd.CommandText = "update oyuncular set puan=" + Label3.Text + " where kullaniciadi='" + nick + "'"
                    ' cmd.Connection = conn

                    ' conn.Open()
                    ' cmd.ExecuteNonQuery()
                    '  conn.Close()

                    MsgBox("Score = " + point.ToString(),, "GAME OVER")
                    reset() 'reseting game area

                End If
            End If

        Next

    End Sub

    Private Sub resetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetButton.Click
        reset() 'reseting game area
    End Sub
    Private Sub pauseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pauseButton.Click
        'stopping game
        pauseLabel.Visible = True
        Timer_Time.Stop()
        Timer1.Stop()
        Timer_Cars.Stop()
        TimerStartE = False
        isMove = False
    End Sub

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        'if car is selected game start
        If isCarSelected Then
            If TimerStartE = False Then
                Panel1.Visible = False
                pauseLabel.Visible = False
                TimerStartE = True
                countDown.Visible = True
                Start = 3
                countDown.Text = 3
                Timer_Start.Start()
            End If
        Else
            MsgBox("Select a car")
        End If



    End Sub

    Private Sub redCar_Click(sender As Object, e As EventArgs) Handles redCar.Click
        car.BackgroundImage = redCar.BackgroundImage
        isCarSelected = True
    End Sub

    Private Sub whiteCar_Click(sender As Object, e As EventArgs) Handles whiteCar.Click
        car.BackgroundImage = whiteCar.BackgroundImage
        isCarSelected = True
    End Sub

    Private Sub blueCar_Click(sender As Object, e As EventArgs) Handles blueCar.Click
        car.BackgroundImage = blueCar.BackgroundImage
        isCarSelected = True
    End Sub

    Private Sub yellowCar_Click(sender As Object, e As EventArgs) Handles yellowCar.Click
        car.BackgroundImage = yellowCar.BackgroundImage
        isCarSelected = True
    End Sub

    Function reset()
        'resetting everything, 
        point = 0
        score.Text = point
        For y = 0 To 2
            enemy(y).Top = -Int(Rnd() * 500)
        Next
        TimerStartE = True
        car.Location = New Point(239, 386)
        Start = 3
        Timer_Time.Stop()
        Timer1.Stop()
        Timer_Cars.Stop()
        isMove = False
        TimerStartE = False
        GameOver = False
        TimerMoveLeft.Stop()
        TimerMoveRight.Stop()
        Timer1.Stop()
        health = 0
        GameOver = True
        point = 0
        score.Text = point
        Panel1.Visible = True
        health = 0

        For Index = 0 To 2
            h(Index).Show()
        Next
        Return 1
    End Function

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles HighScoresButton.Click
        'Dim frm As HighScores
        'frm = New HighScores
        'frm.Show()

        MsgBox("The game use MSSQL for database and high score feature has deactivated because of database connection necessary")
    End Sub

End Class

