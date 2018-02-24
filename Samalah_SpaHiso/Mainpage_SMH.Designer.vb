<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mainpage_SMH
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
        Me.components = New System.ComponentModel.Container()
        Me.LandingPage_Box = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Time_Proc = New System.Windows.Forms.Timer(Me.components)
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.LoginGroupbox = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Reset_Button = New System.Windows.Forms.Button()
        Me.Login_Button = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Password_Box = New System.Windows.Forms.TextBox()
        Me.UserName_Box = New System.Windows.Forms.TextBox()
        Me.LandingPage_Box.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LoginGroupbox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LandingPage_Box
        '
        Me.LandingPage_Box.Controls.Add(Me.ListBox1)
        Me.LandingPage_Box.Controls.Add(Me.PictureBox2)
        Me.LandingPage_Box.Location = New System.Drawing.Point(13, 11)
        Me.LandingPage_Box.Name = "LandingPage_Box"
        Me.LandingPage_Box.Size = New System.Drawing.Size(650, 492)
        Me.LandingPage_Box.TabIndex = 0
        Me.LandingPage_Box.TabStop = False
        Me.LandingPage_Box.Text = "ยินดีต้อนรับสู่ สมาหลาสปาไฮโซ"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(6, 331)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(631, 147)
        Me.ListBox1.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Samalah_SpaHiso.My.Resources.Resources.landing
        Me.PictureBox2.Location = New System.Drawing.Point(8, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(631, 307)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Time_Proc
        '
        Me.Time_Proc.Enabled = True
        Me.Time_Proc.Interval = 1
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TimeLabel.Location = New System.Drawing.Point(682, 9)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(128, 55)
        Me.TimeLabel.TabIndex = 1
        Me.TimeLabel.Text = "  :  :  "
        '
        'LoginGroupbox
        '
        Me.LoginGroupbox.Controls.Add(Me.Label3)
        Me.LoginGroupbox.Controls.Add(Me.PictureBox1)
        Me.LoginGroupbox.Controls.Add(Me.Reset_Button)
        Me.LoginGroupbox.Controls.Add(Me.Login_Button)
        Me.LoginGroupbox.Controls.Add(Me.Label2)
        Me.LoginGroupbox.Controls.Add(Me.Password_Box)
        Me.LoginGroupbox.Controls.Add(Me.UserName_Box)
        Me.LoginGroupbox.Location = New System.Drawing.Point(671, 86)
        Me.LoginGroupbox.Name = "LoginGroupbox"
        Me.LoginGroupbox.Size = New System.Drawing.Size(237, 417)
        Me.LoginGroupbox.TabIndex = 2
        Me.LoginGroupbox.TabStop = False
        Me.LoginGroupbox.Text = "Login"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "ชื่อผู้ใช้งาน"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Samalah_SpaHiso.My.Resources.Resources.default_avatar
        Me.PictureBox1.Location = New System.Drawing.Point(30, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(176, 173)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Reset_Button
        '
        Me.Reset_Button.Location = New System.Drawing.Point(138, 356)
        Me.Reset_Button.Name = "Reset_Button"
        Me.Reset_Button.Size = New System.Drawing.Size(79, 23)
        Me.Reset_Button.TabIndex = 5
        Me.Reset_Button.Text = "ล้างทั้งหมด"
        Me.Reset_Button.UseVisualStyleBackColor = True
        '
        'Login_Button
        '
        Me.Login_Button.Location = New System.Drawing.Point(21, 356)
        Me.Login_Button.Name = "Login_Button"
        Me.Login_Button.Size = New System.Drawing.Size(79, 23)
        Me.Login_Button.TabIndex = 4
        Me.Login_Button.Text = "เข้าสู่ระบบ"
        Me.Login_Button.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 307)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "รหัสผู้ใช้งาน"
        '
        'Password_Box
        '
        Me.Password_Box.Location = New System.Drawing.Point(21, 326)
        Me.Password_Box.Name = "Password_Box"
        Me.Password_Box.Size = New System.Drawing.Size(196, 20)
        Me.Password_Box.TabIndex = 1
        Me.Password_Box.UseSystemPasswordChar = True
        '
        'UserName_Box
        '
        Me.UserName_Box.Location = New System.Drawing.Point(21, 278)
        Me.UserName_Box.Name = "UserName_Box"
        Me.UserName_Box.Size = New System.Drawing.Size(196, 20)
        Me.UserName_Box.TabIndex = 0
        '
        'Mainpage_SMH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 513)
        Me.Controls.Add(Me.LoginGroupbox)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.LandingPage_Box)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Mainpage_SMH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ":: Welcome To Samalah Spa Hi-So"
        Me.LandingPage_Box.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LoginGroupbox.ResumeLayout(False)
        Me.LoginGroupbox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LandingPage_Box As GroupBox
    Friend WithEvents Time_Proc As Timer
    Friend WithEvents TimeLabel As Label
    Friend WithEvents LoginGroupbox As GroupBox
    Friend WithEvents Reset_Button As Button
    Friend WithEvents Login_Button As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Password_Box As TextBox
    Friend WithEvents UserName_Box As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RegisterButton As Button
    Friend WithEvents Label3 As Label
End Class
