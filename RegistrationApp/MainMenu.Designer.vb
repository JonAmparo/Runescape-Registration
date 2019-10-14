<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.LBL_welcomeBlank = New System.Windows.Forms.Label()
        Me.PB_welcome = New System.Windows.Forms.PictureBox()
        Me.BTN_createUser = New System.Windows.Forms.Button()
        Me.BTN_editUser = New System.Windows.Forms.Button()
        Me.BTN_logout = New System.Windows.Forms.Button()
        Me.LBL_deleteProfile = New System.Windows.Forms.LinkLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TS_file = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_login = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_viewProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_createProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_editProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_deleteProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_close = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_about = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BTN_viewUser = New System.Windows.Forms.Button()
        CType(Me.PB_welcome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBL_welcomeBlank
        '
        Me.LBL_welcomeBlank.AutoSize = True
        Me.LBL_welcomeBlank.BackColor = System.Drawing.Color.Transparent
        Me.LBL_welcomeBlank.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_welcomeBlank.Location = New System.Drawing.Point(157, 97)
        Me.LBL_welcomeBlank.Name = "LBL_welcomeBlank"
        Me.LBL_welcomeBlank.Size = New System.Drawing.Size(213, 42)
        Me.LBL_welcomeBlank.TabIndex = 5
        Me.LBL_welcomeBlank.Text = "Welcome..."
        '
        'PB_welcome
        '
        Me.PB_welcome.BackColor = System.Drawing.Color.Transparent
        Me.PB_welcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_welcome.Image = Global.RegistrationApp.My.Resources.Resources.gnome
        Me.PB_welcome.Location = New System.Drawing.Point(125, 168)
        Me.PB_welcome.Name = "PB_welcome"
        Me.PB_welcome.Size = New System.Drawing.Size(255, 289)
        Me.PB_welcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_welcome.TabIndex = 6
        Me.PB_welcome.TabStop = False
        '
        'BTN_createUser
        '
        Me.BTN_createUser.BackColor = System.Drawing.Color.Transparent
        Me.BTN_createUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_createUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_createUser.Location = New System.Drawing.Point(413, 322)
        Me.BTN_createUser.Name = "BTN_createUser"
        Me.BTN_createUser.Size = New System.Drawing.Size(208, 41)
        Me.BTN_createUser.TabIndex = 7
        Me.BTN_createUser.Text = "Create User"
        Me.BTN_createUser.UseVisualStyleBackColor = False
        '
        'BTN_editUser
        '
        Me.BTN_editUser.BackColor = System.Drawing.Color.Transparent
        Me.BTN_editUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_editUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_editUser.Location = New System.Drawing.Point(413, 369)
        Me.BTN_editUser.Name = "BTN_editUser"
        Me.BTN_editUser.Size = New System.Drawing.Size(208, 41)
        Me.BTN_editUser.TabIndex = 8
        Me.BTN_editUser.Text = "Edit User"
        Me.BTN_editUser.UseVisualStyleBackColor = False
        '
        'BTN_logout
        '
        Me.BTN_logout.BackColor = System.Drawing.Color.Transparent
        Me.BTN_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_logout.Location = New System.Drawing.Point(413, 416)
        Me.BTN_logout.Name = "BTN_logout"
        Me.BTN_logout.Size = New System.Drawing.Size(208, 41)
        Me.BTN_logout.TabIndex = 9
        Me.BTN_logout.Text = "Logout"
        Me.BTN_logout.UseVisualStyleBackColor = False
        '
        'LBL_deleteProfile
        '
        Me.LBL_deleteProfile.AutoSize = True
        Me.LBL_deleteProfile.BackColor = System.Drawing.Color.Transparent
        Me.LBL_deleteProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_deleteProfile.ForeColor = System.Drawing.Color.Black
        Me.LBL_deleteProfile.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LBL_deleteProfile.Location = New System.Drawing.Point(469, 475)
        Me.LBL_deleteProfile.Name = "LBL_deleteProfile"
        Me.LBL_deleteProfile.Size = New System.Drawing.Size(96, 18)
        Me.LBL_deleteProfile.TabIndex = 10
        Me.LBL_deleteProfile.TabStop = True
        Me.LBL_deleteProfile.Text = "Delete Profile"
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
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TS_file
        '
        Me.TS_file.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TS_file.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_login, Me.TS_viewProfile, Me.TS_createProfile, Me.TS_editProfile, Me.TS_deleteProfile, Me.TS_logout, Me.TS_close})
        Me.TS_file.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TS_file.ForeColor = System.Drawing.Color.Yellow
        Me.TS_file.Name = "TS_file"
        Me.TS_file.Size = New System.Drawing.Size(40, 21)
        Me.TS_file.Text = "File"
        '
        'TS_login
        '
        Me.TS_login.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TS_login.Name = "TS_login"
        Me.TS_login.Size = New System.Drawing.Size(157, 22)
        Me.TS_login.Text = "Login"
        '
        'TS_viewProfile
        '
        Me.TS_viewProfile.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TS_viewProfile.Name = "TS_viewProfile"
        Me.TS_viewProfile.Size = New System.Drawing.Size(157, 22)
        Me.TS_viewProfile.Text = "View Profile"
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
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "gnome.png")
        Me.ImageList1.Images.SetKeyName(1, "avatar1.png")
        Me.ImageList1.Images.SetKeyName(2, "avatar2.png")
        Me.ImageList1.Images.SetKeyName(3, "avatar3.png")
        '
        'BTN_viewUser
        '
        Me.BTN_viewUser.BackColor = System.Drawing.Color.Transparent
        Me.BTN_viewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_viewUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_viewUser.Location = New System.Drawing.Point(413, 275)
        Me.BTN_viewUser.Name = "BTN_viewUser"
        Me.BTN_viewUser.Size = New System.Drawing.Size(208, 41)
        Me.BTN_viewUser.TabIndex = 12
        Me.BTN_viewUser.Text = "View User"
        Me.BTN_viewUser.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RegistrationApp.My.Resources.Resources.Scroll
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(774, 574)
        Me.Controls.Add(Me.BTN_viewUser)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.LBL_deleteProfile)
        Me.Controls.Add(Me.BTN_logout)
        Me.Controls.Add(Me.BTN_editUser)
        Me.Controls.Add(Me.BTN_createUser)
        Me.Controls.Add(Me.PB_welcome)
        Me.Controls.Add(Me.LBL_welcomeBlank)
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        CType(Me.PB_welcome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_welcomeBlank As Label
    Friend WithEvents PB_welcome As PictureBox
    Friend WithEvents BTN_createUser As Button
    Friend WithEvents BTN_editUser As Button
    Friend WithEvents BTN_logout As Button
    Friend WithEvents LBL_deleteProfile As LinkLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TS_file As ToolStripMenuItem
    Friend WithEvents TS_login As ToolStripMenuItem
    Friend WithEvents TS_createProfile As ToolStripMenuItem
    Friend WithEvents TS_editProfile As ToolStripMenuItem
    Friend WithEvents TS_deleteProfile As ToolStripMenuItem
    Friend WithEvents TS_logout As ToolStripMenuItem
    Friend WithEvents TS_close As ToolStripMenuItem
    Friend WithEvents TS_about As ToolStripMenuItem
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents BTN_viewUser As Button
    Friend WithEvents TS_viewProfile As ToolStripMenuItem
End Class
