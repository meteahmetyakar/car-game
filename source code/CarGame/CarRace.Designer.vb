<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarRace
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CarRace))
        Me.way2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.selectCarText = New System.Windows.Forms.Label()
        Me.pauseLabel = New System.Windows.Forms.Label()
        Me.yellowCar = New System.Windows.Forms.PictureBox()
        Me.blueCar = New System.Windows.Forms.PictureBox()
        Me.redCar = New System.Windows.Forms.PictureBox()
        Me.whiteCar = New System.Windows.Forms.PictureBox()
        Me.countDown = New System.Windows.Forms.Label()
        Me.enemy1 = New System.Windows.Forms.PictureBox()
        Me.enemy2 = New System.Windows.Forms.PictureBox()
        Me.enemy3 = New System.Windows.Forms.PictureBox()
        Me.rightWall = New System.Windows.Forms.Panel()
        Me.HighScoresButton = New System.Windows.Forms.PictureBox()
        Me.health3 = New System.Windows.Forms.PictureBox()
        Me.health2 = New System.Windows.Forms.PictureBox()
        Me.score = New System.Windows.Forms.Label()
        Me.scorText = New System.Windows.Forms.Label()
        Me.health1 = New System.Windows.Forms.PictureBox()
        Me.startButton = New System.Windows.Forms.PictureBox()
        Me.pauseButton = New System.Windows.Forms.PictureBox()
        Me.resetButton = New System.Windows.Forms.PictureBox()
        Me.TimerMoveRight = New System.Windows.Forms.Timer(Me.components)
        Me.TimerMoveLeft = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Time = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Start = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Cars = New System.Windows.Forms.Timer(Me.components)
        Me.way1 = New System.Windows.Forms.PictureBox()
        Me.car = New System.Windows.Forms.PictureBox()
        CType(Me.way2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.yellowCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blueCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.redCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.whiteCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemy3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rightWall.SuspendLayout()
        CType(Me.HighScoresButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.health3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.health2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.health1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.startButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pauseButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.resetButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.way1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'way2
        '
        Me.way2.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.way2.BackgroundImage = CType(resources.GetObject("way2.BackgroundImage"), System.Drawing.Image)
        Me.way2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.way2.Location = New System.Drawing.Point(-98, 244)
        Me.way2.Name = "way2"
        Me.way2.Size = New System.Drawing.Size(726, 540)
        Me.way2.TabIndex = 0
        Me.way2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.selectCarText)
        Me.Panel1.Controls.Add(Me.pauseLabel)
        Me.Panel1.Controls.Add(Me.yellowCar)
        Me.Panel1.Controls.Add(Me.blueCar)
        Me.Panel1.Controls.Add(Me.redCar)
        Me.Panel1.Controls.Add(Me.whiteCar)
        Me.Panel1.Location = New System.Drawing.Point(24, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(491, 343)
        Me.Panel1.TabIndex = 2
        '
        'selectCarText
        '
        Me.selectCarText.AutoSize = True
        Me.selectCarText.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.selectCarText.ForeColor = System.Drawing.Color.Red
        Me.selectCarText.Location = New System.Drawing.Point(139, 223)
        Me.selectCarText.Name = "selectCarText"
        Me.selectCarText.Size = New System.Drawing.Size(207, 46)
        Me.selectCarText.TabIndex = 4
        Me.selectCarText.Text = "Select Car"
        '
        'pauseLabel
        '
        Me.pauseLabel.AutoSize = True
        Me.pauseLabel.BackColor = System.Drawing.Color.Transparent
        Me.pauseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Bold)
        Me.pauseLabel.ForeColor = System.Drawing.Color.Red
        Me.pauseLabel.Location = New System.Drawing.Point(206, 269)
        Me.pauseLabel.Name = "pauseLabel"
        Me.pauseLabel.Size = New System.Drawing.Size(0, 54)
        Me.pauseLabel.TabIndex = 11
        Me.pauseLabel.Visible = False
        '
        'yellowCar
        '
        Me.yellowCar.BackColor = System.Drawing.Color.Transparent
        Me.yellowCar.BackgroundImage = CType(resources.GetObject("yellowCar.BackgroundImage"), System.Drawing.Image)
        Me.yellowCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.yellowCar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.yellowCar.Location = New System.Drawing.Point(378, 188)
        Me.yellowCar.Name = "yellowCar"
        Me.yellowCar.Size = New System.Drawing.Size(73, 139)
        Me.yellowCar.TabIndex = 3
        Me.yellowCar.TabStop = False
        '
        'blueCar
        '
        Me.blueCar.BackColor = System.Drawing.Color.Transparent
        Me.blueCar.BackgroundImage = CType(resources.GetObject("blueCar.BackgroundImage"), System.Drawing.Image)
        Me.blueCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.blueCar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.blueCar.Location = New System.Drawing.Point(271, 51)
        Me.blueCar.Name = "blueCar"
        Me.blueCar.Size = New System.Drawing.Size(73, 139)
        Me.blueCar.TabIndex = 2
        Me.blueCar.TabStop = False
        '
        'redCar
        '
        Me.redCar.BackColor = System.Drawing.Color.Transparent
        Me.redCar.BackgroundImage = CType(resources.GetObject("redCar.BackgroundImage"), System.Drawing.Image)
        Me.redCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.redCar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.redCar.Location = New System.Drawing.Point(147, 51)
        Me.redCar.Name = "redCar"
        Me.redCar.Size = New System.Drawing.Size(73, 139)
        Me.redCar.TabIndex = 1
        Me.redCar.TabStop = False
        '
        'whiteCar
        '
        Me.whiteCar.BackColor = System.Drawing.Color.Transparent
        Me.whiteCar.BackgroundImage = CType(resources.GetObject("whiteCar.BackgroundImage"), System.Drawing.Image)
        Me.whiteCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.whiteCar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.whiteCar.Location = New System.Drawing.Point(36, 188)
        Me.whiteCar.Name = "whiteCar"
        Me.whiteCar.Size = New System.Drawing.Size(73, 139)
        Me.whiteCar.TabIndex = 0
        Me.whiteCar.TabStop = False
        '
        'countDown
        '
        Me.countDown.AutoSize = True
        Me.countDown.BackColor = System.Drawing.Color.Transparent
        Me.countDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Bold)
        Me.countDown.ForeColor = System.Drawing.Color.Red
        Me.countDown.Location = New System.Drawing.Point(241, 246)
        Me.countDown.Name = "countDown"
        Me.countDown.Size = New System.Drawing.Size(0, 54)
        Me.countDown.TabIndex = 10
        '
        'enemy1
        '
        Me.enemy1.BackColor = System.Drawing.Color.Transparent
        Me.enemy1.BackgroundImage = CType(resources.GetObject("enemy1.BackgroundImage"), System.Drawing.Image)
        Me.enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.enemy1.Location = New System.Drawing.Point(71, 33)
        Me.enemy1.Name = "enemy1"
        Me.enemy1.Size = New System.Drawing.Size(71, 131)
        Me.enemy1.TabIndex = 3
        Me.enemy1.TabStop = False
        '
        'enemy2
        '
        Me.enemy2.BackColor = System.Drawing.Color.Transparent
        Me.enemy2.BackgroundImage = CType(resources.GetObject("enemy2.BackgroundImage"), System.Drawing.Image)
        Me.enemy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.enemy2.Location = New System.Drawing.Point(287, 99)
        Me.enemy2.Name = "enemy2"
        Me.enemy2.Size = New System.Drawing.Size(65, 144)
        Me.enemy2.TabIndex = 4
        Me.enemy2.TabStop = False
        '
        'enemy3
        '
        Me.enemy3.BackColor = System.Drawing.Color.Transparent
        Me.enemy3.BackgroundImage = CType(resources.GetObject("enemy3.BackgroundImage"), System.Drawing.Image)
        Me.enemy3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.enemy3.Location = New System.Drawing.Point(396, 18)
        Me.enemy3.Name = "enemy3"
        Me.enemy3.Size = New System.Drawing.Size(62, 146)
        Me.enemy3.TabIndex = 5
        Me.enemy3.TabStop = False
        '
        'rightWall
        '
        Me.rightWall.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.rightWall.Controls.Add(Me.HighScoresButton)
        Me.rightWall.Controls.Add(Me.health3)
        Me.rightWall.Controls.Add(Me.health2)
        Me.rightWall.Controls.Add(Me.score)
        Me.rightWall.Controls.Add(Me.scorText)
        Me.rightWall.Controls.Add(Me.health1)
        Me.rightWall.Controls.Add(Me.startButton)
        Me.rightWall.Controls.Add(Me.pauseButton)
        Me.rightWall.Controls.Add(Me.resetButton)
        Me.rightWall.Location = New System.Drawing.Point(530, -2)
        Me.rightWall.Name = "rightWall"
        Me.rightWall.Size = New System.Drawing.Size(244, 542)
        Me.rightWall.TabIndex = 7
        '
        'HighScoresButton
        '
        Me.HighScoresButton.BackgroundImage = CType(resources.GetObject("HighScoresButton.BackgroundImage"), System.Drawing.Image)
        Me.HighScoresButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.HighScoresButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HighScoresButton.Location = New System.Drawing.Point(14, 411)
        Me.HighScoresButton.Name = "HighScoresButton"
        Me.HighScoresButton.Size = New System.Drawing.Size(207, 56)
        Me.HighScoresButton.TabIndex = 11
        Me.HighScoresButton.TabStop = False
        '
        'health3
        '
        Me.health3.BackgroundImage = CType(resources.GetObject("health3.BackgroundImage"), System.Drawing.Image)
        Me.health3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.health3.Location = New System.Drawing.Point(154, 142)
        Me.health3.Name = "health3"
        Me.health3.Size = New System.Drawing.Size(67, 57)
        Me.health3.TabIndex = 9
        Me.health3.TabStop = False
        '
        'health2
        '
        Me.health2.BackgroundImage = CType(resources.GetObject("health2.BackgroundImage"), System.Drawing.Image)
        Me.health2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.health2.Location = New System.Drawing.Point(81, 142)
        Me.health2.Name = "health2"
        Me.health2.Size = New System.Drawing.Size(67, 57)
        Me.health2.TabIndex = 8
        Me.health2.TabStop = False
        '
        'score
        '
        Me.score.AutoSize = True
        Me.score.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.score.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.score.Location = New System.Drawing.Point(126, 321)
        Me.score.Name = "score"
        Me.score.Size = New System.Drawing.Size(36, 39)
        Me.score.TabIndex = 7
        Me.score.Text = "0"
        '
        'scorText
        '
        Me.scorText.AutoSize = True
        Me.scorText.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.scorText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.scorText.Location = New System.Drawing.Point(18, 321)
        Me.scorText.Name = "scorText"
        Me.scorText.Size = New System.Drawing.Size(115, 39)
        Me.scorText.TabIndex = 6
        Me.scorText.Text = "Score:"
        '
        'health1
        '
        Me.health1.BackgroundImage = CType(resources.GetObject("health1.BackgroundImage"), System.Drawing.Image)
        Me.health1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.health1.Location = New System.Drawing.Point(10, 142)
        Me.health1.Name = "health1"
        Me.health1.Size = New System.Drawing.Size(67, 57)
        Me.health1.TabIndex = 0
        Me.health1.TabStop = False
        '
        'startButton
        '
        Me.startButton.BackgroundImage = CType(resources.GetObject("startButton.BackgroundImage"), System.Drawing.Image)
        Me.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.startButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.startButton.Location = New System.Drawing.Point(154, 214)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(74, 72)
        Me.startButton.TabIndex = 5
        Me.startButton.TabStop = False
        '
        'pauseButton
        '
        Me.pauseButton.BackgroundImage = CType(resources.GetObject("pauseButton.BackgroundImage"), System.Drawing.Image)
        Me.pauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pauseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pauseButton.Location = New System.Drawing.Point(81, 214)
        Me.pauseButton.Name = "pauseButton"
        Me.pauseButton.Size = New System.Drawing.Size(74, 72)
        Me.pauseButton.TabIndex = 4
        Me.pauseButton.TabStop = False
        '
        'resetButton
        '
        Me.resetButton.BackgroundImage = CType(resources.GetObject("resetButton.BackgroundImage"), System.Drawing.Image)
        Me.resetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.resetButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.resetButton.Location = New System.Drawing.Point(10, 214)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(74, 72)
        Me.resetButton.TabIndex = 3
        Me.resetButton.TabStop = False
        '
        'TimerMoveRight
        '
        Me.TimerMoveRight.Interval = 10
        '
        'TimerMoveLeft
        '
        Me.TimerMoveLeft.Interval = 10
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Timer_Time
        '
        Me.Timer_Time.Interval = 1000
        '
        'Timer_Start
        '
        Me.Timer_Start.Interval = 1000
        '
        'Timer_Cars
        '
        Me.Timer_Cars.Interval = 30
        '
        'way1
        '
        Me.way1.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.way1.BackgroundImage = CType(resources.GetObject("way1.BackgroundImage"), System.Drawing.Image)
        Me.way1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.way1.Location = New System.Drawing.Point(-99, -296)
        Me.way1.Name = "way1"
        Me.way1.Size = New System.Drawing.Size(726, 540)
        Me.way1.TabIndex = 8
        Me.way1.TabStop = False
        '
        'car
        '
        Me.car.BackColor = System.Drawing.Color.Transparent
        Me.car.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.car.Location = New System.Drawing.Point(239, 386)
        Me.car.Name = "car"
        Me.car.Size = New System.Drawing.Size(73, 139)
        Me.car.TabIndex = 9
        Me.car.TabStop = False
        '
        'CarRace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(761, 540)
        Me.Controls.Add(Me.rightWall)
        Me.Controls.Add(Me.countDown)
        Me.Controls.Add(Me.car)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.enemy3)
        Me.Controls.Add(Me.enemy2)
        Me.Controls.Add(Me.enemy1)
        Me.Controls.Add(Me.way2)
        Me.Controls.Add(Me.way1)
        Me.DoubleBuffered = True
        Me.Name = "CarRace"
        Me.Text = "Car Race"
        CType(Me.way2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.yellowCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blueCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.redCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.whiteCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemy3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rightWall.ResumeLayout(False)
        Me.rightWall.PerformLayout()
        CType(Me.HighScoresButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.health3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.health2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.health1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.startButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pauseButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.resetButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.way1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents way2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents selectCarText As Label
    Friend WithEvents yellowCar As PictureBox
    Friend WithEvents blueCar As PictureBox
    Friend WithEvents redCar As PictureBox
    Friend WithEvents whiteCar As PictureBox
    Friend WithEvents enemy1 As PictureBox
    Friend WithEvents enemy2 As PictureBox
    Friend WithEvents enemy3 As PictureBox
    Friend WithEvents rightWall As Panel
    Friend WithEvents health3 As PictureBox
    Friend WithEvents health2 As PictureBox
    Friend WithEvents score As Label
    Friend WithEvents scorText As Label
    Friend WithEvents startButton As PictureBox
    Friend WithEvents pauseButton As PictureBox
    Friend WithEvents resetButton As PictureBox
    Friend WithEvents health1 As PictureBox
    Friend WithEvents TimerMoveRight As Timer
    Friend WithEvents TimerMoveLeft As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer_Time As Timer
    Friend WithEvents Timer_Start As Timer
    Friend WithEvents Timer_Cars As Timer
    Friend WithEvents way1 As PictureBox
    Friend WithEvents car As PictureBox
    Friend WithEvents countDown As Label
    Friend WithEvents pauseLabel As Label
    Friend WithEvents HighScoresButton As PictureBox
End Class
