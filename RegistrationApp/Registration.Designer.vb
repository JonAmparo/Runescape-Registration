<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration
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
        Me.GB_registration = New System.Windows.Forms.GroupBox()
        Me.LBL_registrationPage = New System.Windows.Forms.Label()
        Me.LBL_passwordConfirmation = New System.Windows.Forms.Label()
        Me.LBL_password = New System.Windows.Forms.Label()
        Me.LBL_login = New System.Windows.Forms.Label()
        Me.TB_login = New System.Windows.Forms.TextBox()
        Me.TB_password = New System.Windows.Forms.TextBox()
        Me.TB_passwordConfirmation = New System.Windows.Forms.TextBox()
        Me.GB_avatars = New System.Windows.Forms.GroupBox()
        Me.PB_3 = New System.Windows.Forms.PictureBox()
        Me.PB_2 = New System.Windows.Forms.PictureBox()
        Me.PB_1 = New System.Windows.Forms.PictureBox()
        Me.RB_3 = New System.Windows.Forms.RadioButton()
        Me.RB_2 = New System.Windows.Forms.RadioButton()
        Me.RB_1 = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TS_file = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_home = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_login = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_createProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_editProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_deleteProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_close = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_about = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTN_register = New System.Windows.Forms.Button()
        Me.GB_registration.SuspendLayout()
        Me.GB_avatars.SuspendLayout()
        CType(Me.PB_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_registration
        '
        Me.GB_registration.BackColor = System.Drawing.Color.Transparent
        Me.GB_registration.Controls.Add(Me.LBL_registrationPage)
        Me.GB_registration.Controls.Add(Me.LBL_passwordConfirmation)
        Me.GB_registration.Controls.Add(Me.LBL_password)
        Me.GB_registration.Controls.Add(Me.LBL_login)
        Me.GB_registration.Controls.Add(Me.TB_login)
        Me.GB_registration.Controls.Add(Me.TB_password)
        Me.GB_registration.Controls.Add(Me.TB_passwordConfirmation)
        Me.GB_registration.Location = New System.Drawing.Point(126, 46)
        Me.GB_registration.Name = "GB_registration"
        Me.GB_registration.Size = New System.Drawing.Size(522, 161)
        Me.GB_registration.TabIndex = 0
        Me.GB_registration.TabStop = False
        '
        'LBL_registrationPage
        '
        Me.LBL_registrationPage.AutoSize = True
        Me.LBL_registrationPage.BackColor = System.Drawing.Color.Transparent
        Me.LBL_registrationPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_registrationPage.Location = New System.Drawing.Point(123, 16)
        Me.LBL_registrationPage.Name = "LBL_registrationPage"
        Me.LBL_registrationPage.Size = New System.Drawing.Size(211, 55)
        Me.LBL_registrationPage.TabIndex = 7
        Me.LBL_registrationPage.Text = "Register"
        '
        'LBL_passwordConfirmation
        '
        Me.LBL_passwordConfirmation.AutoSize = True
        Me.LBL_passwordConfirmation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_passwordConfirmation.Location = New System.Drawing.Point(6, 132)
        Me.LBL_passwordConfirmation.Name = "LBL_passwordConfirmation"
        Me.LBL_passwordConfirmation.Size = New System.Drawing.Size(193, 20)
        Me.LBL_passwordConfirmation.TabIndex = 9
        Me.LBL_passwordConfirmation.Text = "Password Confirmation"
        '
        'LBL_password
        '
        Me.LBL_password.AutoSize = True
        Me.LBL_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_password.Location = New System.Drawing.Point(6, 106)
        Me.LBL_password.Name = "LBL_password"
        Me.LBL_password.Size = New System.Drawing.Size(86, 20)
        Me.LBL_password.TabIndex = 8
        Me.LBL_password.Text = "Password"
        '
        'LBL_login
        '
        Me.LBL_login.AutoSize = True
        Me.LBL_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_login.Location = New System.Drawing.Point(6, 83)
        Me.LBL_login.Name = "LBL_login"
        Me.LBL_login.Size = New System.Drawing.Size(91, 20)
        Me.LBL_login.TabIndex = 7
        Me.LBL_login.Text = "Username"
        '
        'TB_login
        '
        Me.TB_login.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TB_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_login.Location = New System.Drawing.Point(201, 83)
        Me.TB_login.Name = "TB_login"
        Me.TB_login.Size = New System.Drawing.Size(192, 20)
        Me.TB_login.TabIndex = 1
        '
        'TB_password
        '
        Me.TB_password.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TB_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_password.Location = New System.Drawing.Point(201, 109)
        Me.TB_password.Name = "TB_password"
        Me.TB_password.Size = New System.Drawing.Size(192, 20)
        Me.TB_password.TabIndex = 2
        '
        'TB_passwordConfirmation
        '
        Me.TB_passwordConfirmation.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TB_passwordConfirmation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_passwordConfirmation.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TB_passwordConfirmation.Location = New System.Drawing.Point(201, 135)
        Me.TB_passwordConfirmation.Name = "TB_passwordConfirmation"
        Me.TB_passwordConfirmation.Size = New System.Drawing.Size(192, 20)
        Me.TB_passwordConfirmation.TabIndex = 3
        '
        'GB_avatars
        '
        Me.GB_avatars.BackColor = System.Drawing.Color.Transparent
        Me.GB_avatars.Controls.Add(Me.PB_3)
        Me.GB_avatars.Controls.Add(Me.PB_2)
        Me.GB_avatars.Controls.Add(Me.PB_1)
        Me.GB_avatars.Controls.Add(Me.RB_3)
        Me.GB_avatars.Controls.Add(Me.RB_2)
        Me.GB_avatars.Controls.Add(Me.RB_1)
        Me.GB_avatars.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_avatars.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_avatars.Location = New System.Drawing.Point(117, 207)
        Me.GB_avatars.Name = "GB_avatars"
        Me.GB_avatars.Size = New System.Drawing.Size(531, 283)
        Me.GB_avatars.TabIndex = 4
        Me.GB_avatars.TabStop = False
        Me.GB_avatars.Text = "Choose your character"
        '
        'PB_3
        '
        Me.PB_3.Image = Global.RegistrationApp.My.Resources.Resources.avatar3
        Me.PB_3.Location = New System.Drawing.Point(339, 58)
        Me.PB_3.Name = "PB_3"
        Me.PB_3.Size = New System.Drawing.Size(161, 189)
        Me.PB_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_3.TabIndex = 5
        Me.PB_3.TabStop = False
        '
        'PB_2
        '
        Me.PB_2.Image = Global.RegistrationApp.My.Resources.Resources.avatar2
        Me.PB_2.Location = New System.Drawing.Point(181, 58)
        Me.PB_2.Name = "PB_2"
        Me.PB_2.Size = New System.Drawing.Size(152, 189)
        Me.PB_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_2.TabIndex = 4
        Me.PB_2.TabStop = False
        '
        'PB_1
        '
        Me.PB_1.BackColor = System.Drawing.Color.Transparent
        Me.PB_1.Image = Global.RegistrationApp.My.Resources.Resources.avatar11
        Me.PB_1.Location = New System.Drawing.Point(9, 58)
        Me.PB_1.Name = "PB_1"
        Me.PB_1.Size = New System.Drawing.Size(164, 189)
        Me.PB_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_1.TabIndex = 3
        Me.PB_1.TabStop = False
        '
        'RB_3
        '
        Me.RB_3.AutoSize = True
        Me.RB_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_3.Location = New System.Drawing.Point(339, 28)
        Me.RB_3.Name = "RB_3"
        Me.RB_3.Size = New System.Drawing.Size(98, 24)
        Me.RB_3.TabIndex = 6
        Me.RB_3.TabStop = True
        Me.RB_3.Text = "GnomeD"
        Me.RB_3.UseVisualStyleBackColor = True
        '
        'RB_2
        '
        Me.RB_2.AutoSize = True
        Me.RB_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_2.Location = New System.Drawing.Point(179, 28)
        Me.RB_2.Name = "RB_2"
        Me.RB_2.Size = New System.Drawing.Size(85, 24)
        Me.RB_2.TabIndex = 5
        Me.RB_2.TabStop = True
        Me.RB_2.Text = "Warrior"
        Me.RB_2.UseVisualStyleBackColor = True
        '
        'RB_1
        '
        Me.RB_1.AutoSize = True
        Me.RB_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_1.Location = New System.Drawing.Point(24, 28)
        Me.RB_1.Name = "RB_1"
        Me.RB_1.Size = New System.Drawing.Size(82, 24)
        Me.RB_1.TabIndex = 4
        Me.RB_1.TabStop = True
        Me.RB_1.Text = "Wizard"
        Me.RB_1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.MenuStrip1.BackgroundImage = Global.RegistrationApp.My.Resources.Resources.file
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_file, Me.TS_about})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(774, 25)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TS_file
        '
        Me.TS_file.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TS_file.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_home, Me.TS_login, Me.TS_createProfile, Me.TS_editProfile, Me.TS_deleteProfile, Me.TS_logout, Me.TS_close})
        Me.TS_file.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TS_file.ForeColor = System.Drawing.Color.Yellow
        Me.TS_file.Name = "TS_file"
        Me.TS_file.Size = New System.Drawing.Size(40, 21)
        Me.TS_file.Text = "File"
        '
        'TS_home
        '
        Me.TS_home.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TS_home.Name = "TS_home"
        Me.TS_home.Size = New System.Drawing.Size(157, 22)
        Me.TS_home.Text = "Home"
        '
        'TS_login
        '
        Me.TS_login.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TS_login.Name = "TS_login"
        Me.TS_login.Size = New System.Drawing.Size(157, 22)
        Me.TS_login.Text = "Login"
        '
        'TS_createProfile
        '
        Me.TS_createProfile.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TS_createProfile.Name = "TS_createProfile"
        Me.TS_createProfile.Size = New System.Drawing.Size(157, 22)
        Me.TS_createProfile.Text = "Create Profile"
        '
        'TS_editProfile
        '
        Me.TS_editProfile.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TS_editProfile.Name = "TS_editProfile"
        Me.TS_editProfile.Size = New System.Drawing.Size(157, 22)
        Me.TS_editProfile.Text = "Edit Profile"
        '
        'TS_deleteProfile
        '
        Me.TS_deleteProfile.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TS_deleteProfile.Name = "TS_deleteProfile"
        Me.TS_deleteProfile.Size = New System.Drawing.Size(157, 22)
        Me.TS_deleteProfile.Text = "Delete Profile"
        '
        'TS_logout
        '
        Me.TS_logout.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TS_logout.Name = "TS_logout"
        Me.TS_logout.Size = New System.Drawing.Size(157, 22)
        Me.TS_logout.Text = "Logout"
        '
        'TS_close
        '
        Me.TS_close.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TS_close.Name = "TS_close"
        Me.TS_close.Size = New System.Drawing.Size(157, 22)
        Me.TS_close.Text = "Close"
        '
        'TS_about
        '
        Me.TS_about.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TS_about.ForeColor = System.Drawing.Color.Yellow
        Me.TS_about.Name = "TS_about"
        Me.TS_about.Size = New System.Drawing.Size(52, 21)
        Me.TS_about.Text = "About"
        '
        'BTN_register
        '
        Me.BTN_register.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.BTN_register.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_register.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_register.Location = New System.Drawing.Point(298, 508)
        Me.BTN_register.Name = "BTN_register"
        Me.BTN_register.Size = New System.Drawing.Size(152, 32)
        Me.BTN_register.TabIndex = 7
        Me.BTN_register.Text = "Register"
        Me.BTN_register.UseVisualStyleBackColor = False
        '
        'Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RegistrationApp.My.Resources.Resources.Scroll
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(774, 574)
        Me.Controls.Add(Me.BTN_register)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GB_avatars)
        Me.Controls.Add(Me.GB_registration)
        Me.Name = "Registration"
        Me.Text = "Registration"
        Me.GB_registration.ResumeLayout(False)
        Me.GB_registration.PerformLayout()
        Me.GB_avatars.ResumeLayout(False)
        Me.GB_avatars.PerformLayout()
        CType(Me.PB_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GB_registration As GroupBox
    Friend WithEvents TB_passwordConfirmation As TextBox
    Friend WithEvents TB_password As TextBox
    Friend WithEvents TB_login As TextBox
    Friend WithEvents LBL_passwordConfirmation As Label
    Friend WithEvents LBL_password As Label
    Friend WithEvents LBL_login As Label
    Friend WithEvents GB_avatars As GroupBox
    Friend WithEvents PB_3 As PictureBox
    Friend WithEvents PB_2 As PictureBox
    Friend WithEvents PB_1 As PictureBox
    Friend WithEvents RB_3 As RadioButton
    Friend WithEvents RB_2 As RadioButton
    Friend WithEvents RB_1 As RadioButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TS_file As ToolStripMenuItem
    Friend WithEvents TS_login As ToolStripMenuItem
    Friend WithEvents TS_createProfile As ToolStripMenuItem
    Friend WithEvents TS_editProfile As ToolStripMenuItem
    Friend WithEvents TS_deleteProfile As ToolStripMenuItem
    Friend WithEvents TS_logout As ToolStripMenuItem
    Friend WithEvents TS_close As ToolStripMenuItem
    Friend WithEvents TS_about As ToolStripMenuItem
    Friend WithEvents LBL_registrationPage As Label
    Friend WithEvents TS_home As ToolStripMenuItem
    Friend WithEvents BTN_register As Button
End Class
