<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Create
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
        Me.LBL_program = New System.Windows.Forms.Label()
        Me.LBL_school = New System.Windows.Forms.Label()
        Me.LBL_telephone = New System.Windows.Forms.Label()
        Me.LBL_day = New System.Windows.Forms.Label()
        Me.LBL_month = New System.Windows.Forms.Label()
        Me.LBL_year = New System.Windows.Forms.Label()
        Me.CB_day = New System.Windows.Forms.ComboBox()
        Me.CB_month = New System.Windows.Forms.ComboBox()
        Me.CB_year = New System.Windows.Forms.ComboBox()
        Me.TB_school = New System.Windows.Forms.TextBox()
        Me.TB_telephone = New System.Windows.Forms.TextBox()
        Me.TB_program = New System.Windows.Forms.TextBox()
        Me.TB_address = New System.Windows.Forms.TextBox()
        Me.LBL_address = New System.Windows.Forms.Label()
        Me.LBL_dob = New System.Windows.Forms.Label()
        Me.LBL_lastName = New System.Windows.Forms.Label()
        Me.LBL_firstname = New System.Windows.Forms.Label()
        Me.TB_firstname = New System.Windows.Forms.TextBox()
        Me.TB_lastname = New System.Windows.Forms.TextBox()
        Me.LBL_createYourProfile = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TS_file = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_backtoMainMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_login = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_viewProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_createProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_editProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_deleteProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_close = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_about = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTN_register = New System.Windows.Forms.Button()
        Me.GB_registration.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_registration
        '
        Me.GB_registration.BackColor = System.Drawing.Color.Transparent
        Me.GB_registration.Controls.Add(Me.LBL_program)
        Me.GB_registration.Controls.Add(Me.LBL_school)
        Me.GB_registration.Controls.Add(Me.LBL_telephone)
        Me.GB_registration.Controls.Add(Me.LBL_day)
        Me.GB_registration.Controls.Add(Me.LBL_month)
        Me.GB_registration.Controls.Add(Me.LBL_year)
        Me.GB_registration.Controls.Add(Me.CB_day)
        Me.GB_registration.Controls.Add(Me.CB_month)
        Me.GB_registration.Controls.Add(Me.CB_year)
        Me.GB_registration.Controls.Add(Me.TB_school)
        Me.GB_registration.Controls.Add(Me.TB_telephone)
        Me.GB_registration.Controls.Add(Me.TB_program)
        Me.GB_registration.Controls.Add(Me.TB_address)
        Me.GB_registration.Controls.Add(Me.LBL_address)
        Me.GB_registration.Controls.Add(Me.LBL_dob)
        Me.GB_registration.Controls.Add(Me.LBL_lastName)
        Me.GB_registration.Controls.Add(Me.LBL_firstname)
        Me.GB_registration.Controls.Add(Me.TB_firstname)
        Me.GB_registration.Controls.Add(Me.TB_lastname)
        Me.GB_registration.Location = New System.Drawing.Point(124, 163)
        Me.GB_registration.Name = "GB_registration"
        Me.GB_registration.Size = New System.Drawing.Size(534, 237)
        Me.GB_registration.TabIndex = 1
        Me.GB_registration.TabStop = False
        '
        'LBL_program
        '
        Me.LBL_program.AutoSize = True
        Me.LBL_program.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_program.Location = New System.Drawing.Point(6, 203)
        Me.LBL_program.Name = "LBL_program"
        Me.LBL_program.Size = New System.Drawing.Size(76, 20)
        Me.LBL_program.TabIndex = 26
        Me.LBL_program.Text = "Program"
        '
        'LBL_school
        '
        Me.LBL_school.AutoSize = True
        Me.LBL_school.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_school.Location = New System.Drawing.Point(6, 179)
        Me.LBL_school.Name = "LBL_school"
        Me.LBL_school.Size = New System.Drawing.Size(64, 20)
        Me.LBL_school.TabIndex = 25
        Me.LBL_school.Text = "School"
        '
        'LBL_telephone
        '
        Me.LBL_telephone.AutoSize = True
        Me.LBL_telephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_telephone.Location = New System.Drawing.Point(6, 151)
        Me.LBL_telephone.Name = "LBL_telephone"
        Me.LBL_telephone.Size = New System.Drawing.Size(93, 20)
        Me.LBL_telephone.TabIndex = 24
        Me.LBL_telephone.Text = "Telephone"
        '
        'LBL_day
        '
        Me.LBL_day.AutoSize = True
        Me.LBL_day.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_day.Location = New System.Drawing.Point(339, 110)
        Me.LBL_day.Name = "LBL_day"
        Me.LBL_day.Size = New System.Drawing.Size(26, 13)
        Me.LBL_day.TabIndex = 23
        Me.LBL_day.Text = "Day"
        Me.LBL_day.Visible = False
        '
        'LBL_month
        '
        Me.LBL_month.AutoSize = True
        Me.LBL_month.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_month.Location = New System.Drawing.Point(281, 110)
        Me.LBL_month.Name = "LBL_month"
        Me.LBL_month.Size = New System.Drawing.Size(37, 13)
        Me.LBL_month.TabIndex = 22
        Me.LBL_month.Text = "Month"
        Me.LBL_month.Visible = False
        '
        'LBL_year
        '
        Me.LBL_year.AutoSize = True
        Me.LBL_year.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_year.Location = New System.Drawing.Point(198, 110)
        Me.LBL_year.Name = "LBL_year"
        Me.LBL_year.Size = New System.Drawing.Size(29, 13)
        Me.LBL_year.TabIndex = 21
        Me.LBL_year.Text = "Year"
        Me.LBL_year.Visible = False
        '
        'CB_day
        '
        Me.CB_day.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.CB_day.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_day.FormattingEnabled = True
        Me.CB_day.Location = New System.Drawing.Point(342, 86)
        Me.CB_day.Name = "CB_day"
        Me.CB_day.Size = New System.Drawing.Size(51, 23)
        Me.CB_day.TabIndex = 20
        Me.CB_day.Visible = False
        '
        'CB_month
        '
        Me.CB_month.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.CB_month.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_month.FormattingEnabled = True
        Me.CB_month.Location = New System.Drawing.Point(284, 86)
        Me.CB_month.Name = "CB_month"
        Me.CB_month.Size = New System.Drawing.Size(51, 23)
        Me.CB_month.TabIndex = 19
        Me.CB_month.Visible = False
        '
        'CB_year
        '
        Me.CB_year.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.CB_year.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_year.FormattingEnabled = True
        Me.CB_year.Location = New System.Drawing.Point(201, 86)
        Me.CB_year.Name = "CB_year"
        Me.CB_year.Size = New System.Drawing.Size(77, 23)
        Me.CB_year.TabIndex = 18
        Me.CB_year.Visible = False
        '
        'TB_school
        '
        Me.TB_school.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TB_school.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_school.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_school.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TB_school.Location = New System.Drawing.Point(201, 178)
        Me.TB_school.Name = "TB_school"
        Me.TB_school.Size = New System.Drawing.Size(192, 21)
        Me.TB_school.TabIndex = 14
        '
        'TB_telephone
        '
        Me.TB_telephone.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TB_telephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_telephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_telephone.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TB_telephone.Location = New System.Drawing.Point(201, 152)
        Me.TB_telephone.Name = "TB_telephone"
        Me.TB_telephone.Size = New System.Drawing.Size(192, 21)
        Me.TB_telephone.TabIndex = 13
        '
        'TB_program
        '
        Me.TB_program.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TB_program.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_program.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_program.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TB_program.Location = New System.Drawing.Point(201, 204)
        Me.TB_program.Name = "TB_program"
        Me.TB_program.Size = New System.Drawing.Size(192, 21)
        Me.TB_program.TabIndex = 12
        '
        'TB_address
        '
        Me.TB_address.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TB_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_address.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TB_address.Location = New System.Drawing.Point(201, 126)
        Me.TB_address.Name = "TB_address"
        Me.TB_address.Size = New System.Drawing.Size(192, 21)
        Me.TB_address.TabIndex = 11
        '
        'LBL_address
        '
        Me.LBL_address.AutoSize = True
        Me.LBL_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_address.Location = New System.Drawing.Point(6, 123)
        Me.LBL_address.Name = "LBL_address"
        Me.LBL_address.Size = New System.Drawing.Size(75, 20)
        Me.LBL_address.TabIndex = 10
        Me.LBL_address.Text = "Address"
        '
        'LBL_dob
        '
        Me.LBL_dob.AutoSize = True
        Me.LBL_dob.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_dob.Location = New System.Drawing.Point(6, 84)
        Me.LBL_dob.Name = "LBL_dob"
        Me.LBL_dob.Size = New System.Drawing.Size(110, 20)
        Me.LBL_dob.TabIndex = 9
        Me.LBL_dob.Text = "Date of birth"
        Me.LBL_dob.Visible = False
        '
        'LBL_lastName
        '
        Me.LBL_lastName.AutoSize = True
        Me.LBL_lastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_lastName.Location = New System.Drawing.Point(6, 58)
        Me.LBL_lastName.Name = "LBL_lastName"
        Me.LBL_lastName.Size = New System.Drawing.Size(93, 20)
        Me.LBL_lastName.TabIndex = 8
        Me.LBL_lastName.Text = "Last name"
        '
        'LBL_firstname
        '
        Me.LBL_firstname.AutoSize = True
        Me.LBL_firstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_firstname.Location = New System.Drawing.Point(6, 32)
        Me.LBL_firstname.Name = "LBL_firstname"
        Me.LBL_firstname.Size = New System.Drawing.Size(94, 20)
        Me.LBL_firstname.TabIndex = 7
        Me.LBL_firstname.Text = "First name"
        '
        'TB_firstname
        '
        Me.TB_firstname.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TB_firstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_firstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_firstname.Location = New System.Drawing.Point(201, 35)
        Me.TB_firstname.Name = "TB_firstname"
        Me.TB_firstname.Size = New System.Drawing.Size(192, 21)
        Me.TB_firstname.TabIndex = 6
        '
        'TB_lastname
        '
        Me.TB_lastname.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TB_lastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_lastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_lastname.Location = New System.Drawing.Point(201, 61)
        Me.TB_lastname.Name = "TB_lastname"
        Me.TB_lastname.Size = New System.Drawing.Size(192, 21)
        Me.TB_lastname.TabIndex = 5
        '
        'LBL_createYourProfile
        '
        Me.LBL_createYourProfile.AutoSize = True
        Me.LBL_createYourProfile.BackColor = System.Drawing.Color.Transparent
        Me.LBL_createYourProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_createYourProfile.Location = New System.Drawing.Point(156, 90)
        Me.LBL_createYourProfile.Name = "LBL_createYourProfile"
        Me.LBL_createYourProfile.Size = New System.Drawing.Size(438, 55)
        Me.LBL_createYourProfile.TabIndex = 2
        Me.LBL_createYourProfile.Text = "Create your profile"
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
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TS_file
        '
        Me.TS_file.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TS_file.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_backtoMainMenu, Me.TS_login, Me.TS_viewProfile, Me.TS_createProfile, Me.TS_editProfile, Me.TS_deleteProfile, Me.TS_logout, Me.TS_close})
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
        'TS_viewProfile
        '
        Me.TS_viewProfile.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TS_viewProfile.Name = "TS_viewProfile"
        Me.TS_viewProfile.Size = New System.Drawing.Size(195, 22)
        Me.TS_viewProfile.Text = "View Profile"
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
        'BTN_register
        '
        Me.BTN_register.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.BTN_register.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_register.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_register.Location = New System.Drawing.Point(290, 438)
        Me.BTN_register.Name = "BTN_register"
        Me.BTN_register.Size = New System.Drawing.Size(152, 32)
        Me.BTN_register.TabIndex = 8
        Me.BTN_register.Text = "Submit"
        Me.BTN_register.UseVisualStyleBackColor = False
        '
        'Create
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RegistrationApp.My.Resources.Resources.Scroll
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(774, 574)
        Me.Controls.Add(Me.BTN_register)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.LBL_createYourProfile)
        Me.Controls.Add(Me.GB_registration)
        Me.Name = "Create"
        Me.Text = "Create"
        Me.GB_registration.ResumeLayout(False)
        Me.GB_registration.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GB_registration As GroupBox
    Friend WithEvents LBL_program As Label
    Friend WithEvents LBL_school As Label
    Friend WithEvents LBL_telephone As Label
    Friend WithEvents LBL_day As Label
    Friend WithEvents LBL_month As Label
    Friend WithEvents LBL_year As Label
    Friend WithEvents CB_day As ComboBox
    Friend WithEvents CB_month As ComboBox
    Friend WithEvents CB_year As ComboBox
    Friend WithEvents TB_school As TextBox
    Friend WithEvents TB_telephone As TextBox
    Friend WithEvents TB_program As TextBox
    Friend WithEvents TB_address As TextBox
    Friend WithEvents LBL_address As Label
    Friend WithEvents LBL_dob As Label
    Friend WithEvents LBL_lastName As Label
    Friend WithEvents LBL_firstname As Label
    Friend WithEvents TB_firstname As TextBox
    Friend WithEvents TB_lastname As TextBox
    Friend WithEvents LBL_createYourProfile As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TS_file As ToolStripMenuItem
    Friend WithEvents TS_login As ToolStripMenuItem
    Friend WithEvents TS_createProfile As ToolStripMenuItem
    Friend WithEvents TS_editProfile As ToolStripMenuItem
    Friend WithEvents TS_deleteProfile As ToolStripMenuItem
    Friend WithEvents TS_logout As ToolStripMenuItem
    Friend WithEvents TS_close As ToolStripMenuItem
    Friend WithEvents TS_about As ToolStripMenuItem
    Friend WithEvents BTN_register As Button
    Friend WithEvents TS_backtoMainMenu As ToolStripMenuItem
    Friend WithEvents TS_viewProfile As ToolStripMenuItem
End Class
