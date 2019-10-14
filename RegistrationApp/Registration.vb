Public Class Registration
    'Public newUser As New User
    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'pb

        'TS_logout.Enabled = False

        'If TS_logout.Enabled = False Then
        '    TB_login.Text = "bob"
        '    TB_password.Text = ""
        'End If



        TS_createProfile.Visible = False
        TS_editProfile.Visible = False
        TS_deleteProfile.Visible = False
        TS_logout.Visible = False

    End Sub

    Private Sub TS_home_Click(sender As Object, e As EventArgs) Handles TS_home.Click
        Home.Visible = True
        Me.Visible = False
    End Sub

    Private Sub TS_login_Click(sender As Object, e As EventArgs) Handles TS_login.Click
        Login.Visible = True
        Me.Visible = False
    End Sub

    Private Sub TS_about_Click(sender As Object, e As EventArgs) Handles TS_about.Click
        MsgBox("This application was made for fun by Jonathan Amparo on October 2018. " & vbNewLine & vbNewLine &
                 "The game RuneScape was created and owned by Jagex.  You can check out their amazing game at Runescape.com." & vbNewLine & vbNewLine &
                 "Now... About the game... " & vbNewLine & vbNewLine &
                 "This is RuneScape. The world's most popular free to play MMO. Join over 200,000,000 registered adventurers as you explore the land of Gielinor, learn new skills, complete challenging quests, slay foul beasts and more. Create your own unique hero and embark on your greatest adventure; skilling, questing and fighting your way through hours of content.")
    End Sub

    Private Sub BTN_submit_Click(sender As Object, e As EventArgs) Handles BTN_register.Click


        If TB_login.Text.Length <= 1 Then
            MsgBox("Enter a username with two or more letters!", MsgBoxStyle.Exclamation, "Registration")
            Return
        End If

        If TB_password.Text.Length <= 1 Then
            MsgBox("Enter a password with two or more letters!", MsgBoxStyle.Exclamation, "Registration")
            Return
        End If

        If TB_password.Text <> TB_passwordConfirmation.Text Then
            MsgBox("The password doesn't seem to match...", MsgBoxStyle.Exclamation, "Registration")
            Return
        End If

        If RB_1.Checked = False AndAlso RB_2.Checked = False AndAlso RB_3.Checked = False Then
            MsgBox("Please choose a character.", MsgBoxStyle.Exclamation, "Registration")
            Return
        End If

        If RB_1.Checked Then
            newUser.SetCharacter(1)

        End If
        If RB_2.Checked Then
            newUser.SetCharacter(2)
        End If
        If RB_3.Checked Then
            newUser.SetCharacter(3)
        End If

        newUser.Username = TB_login.Text
        newUser.Password = TB_password.Text

        MainMenu.newUserList.Add(New User(TB_login.Text, TB_password.Text, newUser.getCharacter))

        MainMenu.Visible = True
        Me.Close()
    End Sub

    Private Sub TS_close_Click(sender As Object, e As EventArgs) Handles TS_close.Click
        Me.Close()
    End Sub
End Class