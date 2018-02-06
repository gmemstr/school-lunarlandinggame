<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameWindow))
        Me.TimeBox = New System.Windows.Forms.TextBox()
        Me.AltBox = New System.Windows.Forms.TextBox()
        Me.SpeedBox = New System.Windows.Forms.TextBox()
        Me.FuelBox = New System.Windows.Forms.TextBox()
        Me.BurnButton = New System.Windows.Forms.Button()
        Me.NewGameButton = New System.Windows.Forms.Button()
        Me.LogBox = New System.Windows.Forms.RichTextBox()
        Me.Background = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BurnRateSelector = New System.Windows.Forms.NumericUpDown()
        Me.Floor = New System.Windows.Forms.PictureBox()
        Me.RocketPicture = New System.Windows.Forms.PictureBox()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BurnRateSelector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Floor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RocketPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimeBox
        '
        Me.TimeBox.Location = New System.Drawing.Point(160, 14)
        Me.TimeBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TimeBox.Name = "TimeBox"
        Me.TimeBox.ReadOnly = True
        Me.TimeBox.Size = New System.Drawing.Size(254, 26)
        Me.TimeBox.TabIndex = 0
        '
        'AltBox
        '
        Me.AltBox.Location = New System.Drawing.Point(160, 54)
        Me.AltBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AltBox.Name = "AltBox"
        Me.AltBox.ReadOnly = True
        Me.AltBox.Size = New System.Drawing.Size(254, 26)
        Me.AltBox.TabIndex = 1
        '
        'SpeedBox
        '
        Me.SpeedBox.Location = New System.Drawing.Point(160, 94)
        Me.SpeedBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SpeedBox.Name = "SpeedBox"
        Me.SpeedBox.ReadOnly = True
        Me.SpeedBox.Size = New System.Drawing.Size(254, 26)
        Me.SpeedBox.TabIndex = 2
        Me.SpeedBox.Text = " "
        '
        'FuelBox
        '
        Me.FuelBox.Location = New System.Drawing.Point(160, 134)
        Me.FuelBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FuelBox.Name = "FuelBox"
        Me.FuelBox.ReadOnly = True
        Me.FuelBox.Size = New System.Drawing.Size(254, 26)
        Me.FuelBox.TabIndex = 3
        '
        'BurnButton
        '
        Me.BurnButton.Location = New System.Drawing.Point(160, 214)
        Me.BurnButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BurnButton.Name = "BurnButton"
        Me.BurnButton.Size = New System.Drawing.Size(256, 35)
        Me.BurnButton.TabIndex = 5
        Me.BurnButton.Text = "Run Turn"
        Me.BurnButton.UseVisualStyleBackColor = True
        '
        'NewGameButton
        '
        Me.NewGameButton.Location = New System.Drawing.Point(12, 674)
        Me.NewGameButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NewGameButton.Name = "NewGameButton"
        Me.NewGameButton.Size = New System.Drawing.Size(112, 35)
        Me.NewGameButton.TabIndex = 7
        Me.NewGameButton.Text = "New Game"
        Me.NewGameButton.UseVisualStyleBackColor = True
        '
        'LogBox
        '
        Me.LogBox.Location = New System.Drawing.Point(12, 262)
        Me.LogBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LogBox.Name = "LogBox"
        Me.LogBox.ReadOnly = True
        Me.LogBox.Size = New System.Drawing.Size(463, 401)
        Me.LogBox.TabIndex = 8
        Me.LogBox.Text = "Please click 'New Game'"
        '
        'Background
        '
        Me.Background.BackColor = System.Drawing.Color.Black
        Me.Background.Location = New System.Drawing.Point(492, 14)
        Me.Background.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Background.Name = "Background"
        Me.Background.Size = New System.Drawing.Size(306, 695)
        Me.Background.TabIndex = 9
        Me.Background.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(58, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Time (s)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(58, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Altitude (ft)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(58, 94)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Speed (ft/s)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(58, 138)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Fuel (lb)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(58, 180)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Burn Rate"
        '
        'BurnRateSelector
        '
        Me.BurnRateSelector.Location = New System.Drawing.Point(162, 174)
        Me.BurnRateSelector.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BurnRateSelector.Name = "BurnRateSelector"
        Me.BurnRateSelector.Size = New System.Drawing.Size(255, 26)
        Me.BurnRateSelector.TabIndex = 15
        '
        'Floor
        '
        Me.Floor.BackColor = System.Drawing.Color.Red
        Me.Floor.Location = New System.Drawing.Point(492, 668)
        Me.Floor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Floor.Name = "Floor"
        Me.Floor.Size = New System.Drawing.Size(306, 41)
        Me.Floor.TabIndex = 16
        Me.Floor.TabStop = False
        '
        'RocketPicture
        '
        Me.RocketPicture.BackColor = System.Drawing.Color.Transparent
        Me.RocketPicture.Image = CType(resources.GetObject("RocketPicture.Image"), System.Drawing.Image)
        Me.RocketPicture.Location = New System.Drawing.Point(618, 18)
        Me.RocketPicture.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RocketPicture.Name = "RocketPicture"
        Me.RocketPicture.Size = New System.Drawing.Size(46, 84)
        Me.RocketPicture.TabIndex = 17
        Me.RocketPicture.TabStop = False
        '
        'GameWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(816, 728)
        Me.Controls.Add(Me.RocketPicture)
        Me.Controls.Add(Me.Floor)
        Me.Controls.Add(Me.BurnRateSelector)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Background)
        Me.Controls.Add(Me.LogBox)
        Me.Controls.Add(Me.NewGameButton)
        Me.Controls.Add(Me.BurnButton)
        Me.Controls.Add(Me.FuelBox)
        Me.Controls.Add(Me.SpeedBox)
        Me.Controls.Add(Me.AltBox)
        Me.Controls.Add(Me.TimeBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GameWindow"
        Me.Text = "Rocket Game"
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BurnRateSelector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Floor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RocketPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TimeBox As TextBox
    Friend WithEvents AltBox As TextBox
    Friend WithEvents SpeedBox As TextBox
    Friend WithEvents FuelBox As TextBox
    Friend WithEvents BurnButton As Button
    Friend WithEvents NewGameButton As Button
    Friend WithEvents LogBox As RichTextBox
    Friend WithEvents Background As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BurnRateSelector As NumericUpDown
    Friend WithEvents RocketPicture As PictureBox
    Friend WithEvents Floor As PictureBox
End Class
