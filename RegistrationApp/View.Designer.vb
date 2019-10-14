<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(View))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TS_file = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_backtoMainMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_login = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_createProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_editProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_deleteProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_close = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_about = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LBL_viewUsername = New System.Windows.Forms.Label()
        Me.LBL_viewFirstname = New System.Windows.Forms.Label()
        Me.LBL_viewLastname = New System.Windows.Forms.Label()
        Me.LBL_viewAddress = New System.Windows.Forms.Label()
        Me.LBL_viewTelephone = New System.Windows.Forms.Label()
        Me.LBL_viewSchool = New System.Windows.Forms.Label()
        Me.LBL_viewProgram = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.PB_welcome = New System.Windows.Forms.PictureBox()
        Me.LBL_viewProfile = New System.Windows.Forms.Label()
        Me.BTN_editUser = New System.Windows.Forms.Button()
        Me.BTN_createUser = New System.Windows.Forms.Button()
        Me.BTN_logout = New System.Windows.Forms.Button()
        Me.LBL_deleteProfile = New System.Windows.Forms.LinkLabel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PB_welcome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TS_file
        '
        Me.TS_file.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TS_file.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_backtoMainMenu, Me.TS_login, Me.TS_createProfile, Me.TS_editProfile, Me.TS_deleteProfile, Me.TS_logout, Me.TS_close})
        Me.TS_file.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TS_file.ForeColor = System.Drawing.Color.Yellow
        Me.TS_file.Name = "TS_file"
        Me.TS_file.Size = New System.Drawing.Size(40, 21)
        Me.TS_file.Text = "File"
        '
        'TS_backtoMainMenu
        '
        Me.TS_backtoMainMenu.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TS_backtoMainMenu.Name = "TS_backtoMainMenu"
        Me.TS_backtoMainMenu.Size = New System.Drawing.Size(195, 22)
        Me.TS_backtoMainMenu.Text = "Back To Main Menu"
        '
        'TS_login
        '
        Me.TS_login.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TS_login.Name = "TS_login"
        Me.TS_login.Size = New System.Drawing.Size(195, 22)
        Me.TS_login.Text = "Login"
        '
        'TS_createProfile
        '
        Me.TS_createProfile.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TS_createProfile.Name = "TS_createProfile"
        Me.TS_createProfile.Size = New System.Drawing.Size(195, 22)
        Me.TS_createProfile.Text = "Create Profile"
        '
        'TS_editProfile
        '
        Me.TS_editProfile.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TS_editProfile.Name = "TS_editProfile"
        Me.TS_editProfile.Size = New System.Drawing.Size(195, 22)
        Me.TS_editProfile.Text = "Edit Profile"
        '
        'TS_deleteProfile
        '
        Me.TS_deleteProfile.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TS_deleteProfile.Name = "TS_deleteProfile"
        Me.TS_deleteProfile.Size = New System.Drawing.Size(195, 22)
        Me.TS_deleteProfile.Text = "Delete Profile"
        '
        'TS_logout
        '
        Me.TS_logout.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TS_logout.Name = "TS_logout"
        Me.TS_logout.Size = New System.Drawing.Size(195, 22)
        Me.TS_logout.Text = "Logout"
        '
        'TS_close
        '
        Me.TS_close.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TS_close.Name = "TS_close"
        Me.TS_close.Size = New System.Drawing.Size(195, 22)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(119, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Username: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(117, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "First name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(117, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Last name: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(119, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(117, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Telephone: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(117, 279)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "School: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(119, 311)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 20)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Program: "
        '
        'LBL_viewUsername
        '
        Me.LBL_viewUsername.AutoSize = True
        Me.LBL_viewUsername.BackColor = System.Drawing.Color.Transparent
        Me.LBL_viewUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_viewUsername.Location = New System.Drawing.Point(226, 131)
        Me.LBL_viewUsername.Name = "LBL_viewUsername"
        Me.LBL_viewUsername.Size = New System.Drawing.Size(0, 20)
        Me.LBL_viewUsername.TabIndex = 20
        '
        'LBL_viewFirstname
        '
        Me.LBL_viewFirstname.AutoSize = True
        Me.LBL_viewFirstname.BackColor = System.Drawing.Color.Transparent
        Me.LBL_viewFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_viewFirstname.Location = New System.Drawing.Point(226, 161)
        Me.LBL_viewFirstname.Name = "LBL_viewFirstname"
        Me.LBL_viewFirstname.Size = New System.Drawing.Size(0, 20)
        Me.LBL_viewFirstname.TabIndex = 21
        '
        'LBL_viewLastname
        '
        Me.LBL_viewLastname.AutoSize = True
        Me.LBL_viewLastname.BackColor = System.Drawing.Color.Transparent
        Me.LBL_viewLastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_viewLastname.Location = New System.Drawing.Point(226, 190)
        Me.LBL_viewLastname.Name = "LBL_viewLastname"
        Me.LBL_viewLastname.Size = New System.Drawing.Size(0, 20)
        Me.LBL_viewLastname.TabIndex = 22
        '
        'LBL_viewAddress
        '
        Me.LBL_viewAddress.AutoSize = True
        Me.LBL_viewAddress.BackColor = System.Drawing.Color.Transparent
        Me.LBL_viewAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_viewAddress.Location = New System.Drawing.Point(226, 219)
        Me.LBL_viewAddress.Name = "LBL_viewAddress"
        Me.LBL_viewAddress.Size = New System.Drawing.Size(0, 20)
        Me.LBL_viewAddress.TabIndex = 23
        '
        'LBL_viewTelephone
        '
        Me.LBL_viewTelephone.AutoSize = True
        Me.LBL_viewTelephone.BackColor = System.Drawing.Color.Transparent
        Me.LBL_viewTelephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_viewTelephone.Location = New System.Drawing.Point(226, 250)
        Me.LBL_viewTelephone.Name = "LBL_viewTelephone"
        Me.LBL_viewTelephone.Size = New System.Drawing.Size(0, 20)
        Me.LBL_viewTelephone.TabIndex = 24
        '
        'LBL_viewSchool
        '
        Me.LBL_viewSchool.AutoSize = True
        Me.LBL_viewSchool.BackColor = System.Drawing.Color.Transparent
        Me.LBL_viewSchool.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_viewSchool.Location = New System.Drawing.Point(226, 279)
        Me.LBL_viewSchool.Name = "LBL_viewSchool"
        Me.LBL_viewSchool.Size = New System.Drawing.Size(0, 20)
        Me.LBL_viewSchool.TabIndex = 25
        '
        'LBL_viewProgram
        '
        Me.LBL_viewProgram.AutoSize = True
        Me.LBL_viewProgram.BackColor = System.Drawing.Color.Transparent
        Me.LBL_viewProgram.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_viewProgram.Location = New System.Drawing.Point(226, 311)
        Me.LBL_viewProgram.Name = "LBL_viewProgram"
        Me.LBL_viewProgram.Size = New System.Drawing.Size(0, 20)
        Me.LBL_viewProgram.TabIndex = 26
        '
        'PB_welcome
        '
        Me.PB_welcome.BackColor = System.Drawing.Color.Transparent
        Me.PB_welcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_welcome.Image = Global.RegistrationApp.My.Resources.Resources.gnome
        Me.PB_welcome.Location = New System.Drawing.Point(370, 131)
        Me.PB_welcome.Name = "PB_welcome"
        Me.PB_welcome.Size = New System.Drawing.Size(255, 289)
        Me.PB_welcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_welcome.TabIndex = 27
        Me.PB_welcome.TabStop = False
        '
        'LBL_viewProfile
        '
        Me.LBL_viewProfile.AutoSize = True
        Me.LBL_viewProfile.BackColor = System.Drawing.Color.Transparent
        Me.LBL_viewProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_viewProfile.Location = New System.Drawing.Point(284, 63)
        Me.LBL_viewProfile.Name = "LBL_viewProfile"
        Me.LBL_viewProfile.Size = New System.Drawing.Size(166, 55)
        Me.LBL_viewProfile.TabIndex = 28
        Me.LBL_viewProfile.Text = "Profile"
        Me.LBL_viewProfile.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BTN_editUser
        '
        Me.BTN_editUser.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.BTN_editUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_editUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_editUser.Location = New System.Drawing.Point(298, 450)
        Me.BTN_editUser.Name = "BTN_editUser"
        Me.BTN_editUser.Size = New System.Drawing.Size(152, 32)
        Me.BTN_editUser.TabIndex = 29
        Me.BTN_editUser.Text = "Edit User"
        Me.BTN_editUser.UseVisualStyleBackColor = False
        '
        'BTN_createUser
        '
        Me.BTN_createUser.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.BTN_createUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_createUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_createUser.Location = New System.Drawing.Point(140, 450)
        Me.BTN_createUser.Name = "BTN_createUser"
        Me.BTN_createUser.Size = New System.Drawing.Size(152, 32)
        Me.BTN_createUser.TabIndex = 30
        Me.BTN_createUser.Text = "Create User"
        Me.BTN_createUser.UseVisualStyleBackColor = False
        '
        'BTN_logout
        '
        Me.BTN_logout.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.BTN_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_logout.Location = New System.Drawing.Point(456, 450)
        Me.BTN_logout.Name = "BTN_logout"
        Me.BTN_logout.Size = New System.Drawing.Size(152, 32)
        Me.BTN_logout.TabIndex = 31
        Me.BTN_logout.Text = "Logout"
        Me.BTN_logout.UseVisualStyleBackColor = False
        '
        'LBL_deleteProfile
        '
        Me.LBL_deleteProfile.ActiveLinkColor = System.Drawing.Color.Red
        Me.LBL_deleteProfile.AutoSize = True
        Me.LBL_deleteProfile.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LBL_deleteProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_deleteProfile.ForeColor = System.Drawing.Color.Black
        Me.LBL_deleteProfile.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LBL_deleteProfile.Location = New System.Drawing.Point(323, 527)
        Me.LBL_deleteProfile.Name = "LBL_deleteProfile"
        Me.LBL_deleteProfile.Size = New System.Drawing.Size(96, 18)
        Me.LBL_deleteProfile.TabIndex = 32
        Me.LBL_deleteProfile.TabStop = True
        Me.LBL_deleteProfile.Text = "Delete Profile"
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
        'View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.RegistrationApp.My.Resources.Resources.Scroll
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(774, 574)
        Me.Controls.Add(Me.LBL_deleteProfile)
        Me.Controls.Add(Me.BTN_logout)
        Me.Controls.Add(Me.BTN_createUser)
        Me.Controls.Add(Me.BTN_editUser)
        Me.Controls.Add(Me.LBL_viewProfile)
        Me.Controls.Add(Me.PB_welcome)
        Me.Controls.Add(Me.LBL_viewProgram)
        Me.Controls.Add(Me.LBL_viewSchool)
        Me.Controls.Add(Me.LBL_viewTelephone)
        Me.Controls.Add(Me.LBL_viewAddress)
        Me.Controls.Add(Me.LBL_viewLastname)
        Me.Controls.Add(Me.LBL_viewFirstname)
        Me.Controls.Add(Me.LBL_viewUsername)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "View"
        Me.Text = "View"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PB_welcome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TS_file As ToolStripMenuItem
    Friend WithEvents TS_login As ToolStripMenuItem
    Friend WithEvents TS_createProfile As ToolStripMenuItem
    Friend WithEvents TS_editProfile As ToolStripMenuItem
    Friend WithEvents TS_deleteProfile As ToolStripMenuItem
    Friend WithEvents TS_logout As ToolStripMenuItem
    Friend WithEvents TS_close As ToolStripMenuItem
    Friend WithEvents TS_about As ToolStripMenuItem
    Friend WithEvents TS_backtoMainMenu As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LBL_viewUsername As Label
    Friend WithEvents LBL_viewFirstname As Label
    Friend WithEvents LBL_viewLastname As Label
    Friend WithEvents LBL_viewAddress As Label
    Friend WithEvents LBL_viewTelephone As Label
    Friend WithEvents LBL_viewSchool As Label
    Friend WithEvents LBL_viewProgram As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PB_welcome As PictureBox
    Friend WithEvents LBL_viewProfile As Label
    Friend WithEvents BTN_editUser As Button
    Friend WithEvents BTN_createUser As Button
    Friend WithEvents BTN_logout As Button
    Friend WithEvents LBL_deleteProfile As LinkLabel
    Friend WithEvents ImageList1 As ImageList
End Class
