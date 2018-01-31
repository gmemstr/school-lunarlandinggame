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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BurnRateSelector = New System.Windows.Forms.NumericUpDown()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BurnRateSelector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimeBox
        '
        Me.TimeBox.Location = New System.Drawing.Point(107, 9)
        Me.TimeBox.Name = "TimeBox"
        Me.TimeBox.ReadOnly = True
        Me.TimeBox.Size = New System.Drawing.Size(171, 20)
        Me.TimeBox.TabIndex = 0
        '
        'AltBox
        '
        Me.AltBox.Location = New System.Drawing.Point(107, 35)
        Me.AltBox.Name = "AltBox"
        Me.AltBox.ReadOnly = True
        Me.AltBox.Size = New System.Drawing.Size(171, 20)
        Me.AltBox.TabIndex = 1
        '
        'SpeedBox
        '
        Me.SpeedBox.Location = New System.Drawing.Point(107, 61)
        Me.SpeedBox.Name = "SpeedBox"
        Me.SpeedBox.ReadOnly = True
        Me.SpeedBox.Size = New System.Drawing.Size(171, 20)
        Me.SpeedBox.TabIndex = 2
        '
        'FuelBox
        '
        Me.FuelBox.Location = New System.Drawing.Point(107, 87)
        Me.FuelBox.Name = "FuelBox"
        Me.FuelBox.ReadOnly = True
        Me.FuelBox.Size = New System.Drawing.Size(171, 20)
        Me.FuelBox.TabIndex = 3
        '
        'BurnButton
        '
        Me.BurnButton.Location = New System.Drawing.Point(107, 139)
        Me.BurnButton.Name = "BurnButton"
        Me.BurnButton.Size = New System.Drawing.Size(172, 23)
        Me.BurnButton.TabIndex = 5
        Me.BurnButton.Text = "Run Turn"
        Me.BurnButton.UseVisualStyleBackColor = True
        '
        'NewGameButton
        '
        Me.NewGameButton.Location = New System.Drawing.Point(8, 438)
        Me.NewGameButton.Name = "NewGameButton"
        Me.NewGameButton.Size = New System.Drawing.Size(75, 23)
        Me.NewGameButton.TabIndex = 7
        Me.NewGameButton.Text = "New Game"
        Me.NewGameButton.UseVisualStyleBackColor = True
        '
        'LogBox
        '
        Me.LogBox.Location = New System.Drawing.Point(8, 170)
        Me.LogBox.Name = "LogBox"
        Me.LogBox.Size = New System.Drawing.Size(310, 262)
        Me.LogBox.TabIndex = 8
        Me.LogBox.Text = "Please click 'New Game'"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(328, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(204, 452)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(39, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Time (s)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(39, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Altitude (ft)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(39, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Speed (ft/s)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(39, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Fuel (lb)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(39, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Burn Rate"
        '
        'BurnRateSelector
        '
        Me.BurnRateSelector.Location = New System.Drawing.Point(108, 113)
        Me.BurnRateSelector.Name = "BurnRateSelector"
        Me.BurnRateSelector.Size = New System.Drawing.Size(171, 20)
        Me.BurnRateSelector.TabIndex = 15
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Red
        Me.PictureBox2.Location = New System.Drawing.Point(328, 389)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(204, 72)
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(410, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(38, 53)
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        '
        'GameWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(544, 473)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BurnRateSelector)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LogBox)
        Me.Controls.Add(Me.NewGameButton)
        Me.Controls.Add(Me.BurnButton)
        Me.Controls.Add(Me.FuelBox)
        Me.Controls.Add(Me.SpeedBox)
        Me.Controls.Add(Me.AltBox)
        Me.Controls.Add(Me.TimeBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GameWindow"
        Me.Text = "Rocket Game"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BurnRateSelector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BurnRateSelector As NumericUpDown
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
