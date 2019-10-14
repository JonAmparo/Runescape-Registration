<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.BTN_login = New System.Windows.Forms.Button()
        Me.BTN_cancel = New System.Windows.Forms.Button()
        Me.TB_login = New System.Windows.Forms.TextBox()
        Me.TB_password = New System.Windows.Forms.TextBox()
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
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTN_login
        '
        Me.BTN_login.BackgroundImage = Global.RegistrationApp.My.Resources.Resources.Login
        Me.BTN_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_login.Location = New System.Drawing.Point(230, 300)
        Me.BTN_login.Name = "BTN_login"
        Me.BTN_login.Size = New System.Drawing.Size(148, 44)
        Me.BTN_login.TabIndex = 1
        Me.BTN_login.TabStop = False
        Me.BTN_login.UseVisualStyleBackColor = True
        '
        'BTN_cancel
        '
        Me.BTN_cancel.BackgroundImage = Global.RegistrationApp.My.Resources.Resources.Cancel
        Me.BTN_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_cancel.Location = New System.Drawing.Point(388, 300)
        Me.BTN_cancel.Name = "BTN_cancel"
        Me.BTN_cancel.Size = New System.Drawing.Size(148, 44)
        Me.BTN_cancel.TabIndex = 2
        Me.BTN_cancel.TabStop = False
        Me.BTN_cancel.UseVisualStyleBackColor = True
        '
        'TB_login
        '
        Me.TB_login.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TB_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_login.Location = New System.Drawing.Point(320, 237)
        Me.TB_login.Name = "TB_login"
        Me.TB_login.Size = New System.Drawing.Size(216, 20)
        Me.TB_login.TabIndex = 3
        '
        'TB_password
        '
        Me.TB_password.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TB_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_password.Location = New System.Drawing.Point(344, 263)
        Me.TB_password.Name = "TB_password"
        Me.TB_password.Size = New System.Drawing.Size(192, 20)
        Me.TB_password.TabIndex = 4
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = Global.RegistrationApp.My.Resources.Resources.MenuSelection
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_file, Me.TS_about})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(766, 25)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TS_file
        '
        Me.TS_file.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_home, Me.TS_login, Me.TS_createProfile, Me.TS_editProfile, Me.TS_deleteProfile, Me.TS_logout, Me.TS_close})
        Me.TS_file.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TS_file.ForeColor = System.Drawing.Color.Yellow
        Me.TS_file.Name = "TS_file"
        Me.TS_file.Size = New System.Drawing.Size(40, 21)
        Me.TS_file.Text = "File"
        '
        'TS_home
        '
        Me.TS_home.BackColor = System.Drawing.Color.White
        Me.TS_home.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.TS_home.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TS_home.Name = "TS_home"
        Me.TS_home.Size = New System.Drawing.Size(157, 22)
        Me.TS_home.Text = "Home"
        '
        'TS_login
        '
        Me.TS_login.Name = "TS_login"
        Me.TS_login.Size = New System.Drawing.Size(157, 22)
        Me.TS_login.Text = "Login"
        '
        'TS_createProfile
        '
        Me.TS_createProfile.Name = "TS_createProfile"
        Me.TS_createProfile.Size = New System.Drawing.Size(157, 22)
        Me.TS_createProfile.Text = "Create Profile"
        '
        'TS_editProfile
        '
        Me.TS_editProfile.Name = "TS_editProfile"
        Me.TS_editProfile.Size = New System.Drawing.Size(157, 22)
        Me.TS_editProfile.Text = "Edit Profile"
        '
        'TS_deleteProfile
        '
        Me.TS_deleteProfile.Name = "TS_deleteProfile"
        Me.TS_deleteProfile.Size = New System.Drawing.Size(157, 22)
        Me.TS_deleteProfile.Text = "Delete Profile"
        '
        'TS_logout
        '
        Me.TS_logout.Name = "TS_logout"
        Me.TS_logout.Size = New System.Drawing.Size(157, 22)
        Me.TS_logout.Text = "Logout"
        '
        'TS_close
        '
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
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RegistrationApp.My.Resources.Resources.userPassword
        Me.ClientSize = New System.Drawing.Size(766, 499)
        Me.Controls.Add(Me.TB_password)
        Me.Controls.Add(Me.TB_login)
        Me.Controls.Add(Me.BTN_cancel)
        Me.Controls.Add(Me.BTN_login)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Login"
        Me.Text = "Login"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_login As Button
    Friend WithEvents BTN_cancel As Button
    Friend WithEvents TB_login As TextBox
    Friend WithEvents TB_password As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TS_file As ToolStripMenuItem
    Friend WithEvents TS_login As ToolStripMenuItem
    Friend WithEvents TS_createProfile As ToolStripMenuItem
    Friend WithEvents TS_editProfile As ToolStripMenuItem
    Friend WithEvents TS_deleteProfile As ToolStripMenuItem
    Friend WithEvents TS_logout As ToolStripMenuItem
    Friend WithEvents TS_close As ToolStripMenuItem
    Friend WithEvents TS_about As ToolStripMenuItem
    Friend WithEvents TS_home As ToolStripMenuItem
End Class
