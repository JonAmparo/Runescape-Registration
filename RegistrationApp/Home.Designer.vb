<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.BTN_newUser = New System.Windows.Forms.Button()
        Me.BTN_existingUser = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TS_file = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_login = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_createProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_editProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_deleteProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_close = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_about = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_newUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTN_newUser
        '
        Me.BTN_newUser.BackgroundImage = Global.RegistrationApp.My.Resources.Resources.NewUser
        Me.BTN_newUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_newUser.Location = New System.Drawing.Point(229, 271)
        Me.BTN_newUser.Name = "BTN_newUser"
        Me.BTN_newUser.Size = New System.Drawing.Size(148, 44)
        Me.BTN_newUser.TabIndex = 0
        Me.BTN_newUser.TabStop = False
        Me.BTN_newUser.UseVisualStyleBackColor = True
        '
        'BTN_existingUser
        '
        Me.BTN_existingUser.BackgroundImage = Global.RegistrationApp.My.Resources.Resources.ExistingUser
        Me.BTN_existingUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_existingUser.Location = New System.Drawing.Point(388, 271)
        Me.BTN_existingUser.Name = "BTN_existingUser"
        Me.BTN_existingUser.Size = New System.Drawing.Size(148, 44)
        Me.BTN_existingUser.TabIndex = 0
        Me.BTN_existingUser.TabStop = False
        Me.BTN_existingUser.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = Global.RegistrationApp.My.Resources.Resources.MenuSelection
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_file, Me.TS_about})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(765, 25)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TS_file
        '
        Me.TS_file.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_newUser, Me.TS_login, Me.TS_createProfile, Me.TS_editProfile, Me.TS_deleteProfile, Me.TS_logout, Me.TS_close})
        Me.TS_file.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TS_file.ForeColor = System.Drawing.Color.Yellow
        Me.TS_file.Name = "TS_file"
        Me.TS_file.Size = New System.Drawing.Size(40, 21)
        Me.TS_file.Text = "File"
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
        'TS_newUser
        '
        Me.TS_newUser.Name = "TS_newUser"
        Me.TS_newUser.Size = New System.Drawing.Size(157, 22)
        Me.TS_newUser.Text = "New User"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RegistrationApp.My.Resources.Resources.Default_login_screen
        Me.ClientSize = New System.Drawing.Size(765, 502)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.BTN_existingUser)
        Me.Controls.Add(Me.BTN_newUser)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_newUser As Button
    Friend WithEvents BTN_existingUser As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TS_file As ToolStripMenuItem
    Friend WithEvents TS_login As ToolStripMenuItem
    Friend WithEvents TS_createProfile As ToolStripMenuItem
    Friend WithEvents TS_editProfile As ToolStripMenuItem
    Friend WithEvents TS_deleteProfile As ToolStripMenuItem
    Friend WithEvents TS_logout As ToolStripMenuItem
    Friend WithEvents TS_close As ToolStripMenuItem
    Friend WithEvents TS_about As ToolStripMenuItem
    Friend WithEvents TS_newUser As ToolStripMenuItem
End Class
