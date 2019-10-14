Public Class MainMenu
    'Private ReadOnly newUser As Object
    'Public newUser As User
    Public newUserList As New List(Of User)

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'newUser = New User("Murdaro", "asdf", "Jonathan", "Amparo", New Date(1994, 4, 16), "Avenue Du Parc", "5148907612", "Herzings", "Programmer", "RB_3")
        'newUserList.Add(newUser)
        'PB_welcome.Image = My.Resources.avatar2

        'Dim user = New User
        'newUser.Username = Login.online.Username
        'newUser.Password = Login.online.Password
        LBL_welcomeBlank.Text = "Welcome " & newUser.Username & "! "
        PB_welcome.Image = ImageList1.Images(newUser.getCharacter)

    End Sub

    Private Sub BTN_logout_Click(sender As Object, e As EventArgs) Handles BTN_logout.Click, TS_logout.Click

        Select Case MsgBox("Are you sure you want to logout?", MsgBoxStyle.YesNoCancel)
            Case MsgBoxResult.Yes

                Registration.TB_login.Text = Nothing
                Registration.TB_password.Text = Nothing
                Registration.TB_passwordConfirmation.Text = Nothing
                Registration.RB_1.Checked = False
                Registration.RB_2.Checked = False
                Registration.RB_3.Checked = False

                Me.Close()
                Home.Visible = True

            Case MsgBoxResult.No
                MsgBox("No")
                Return

            Case MsgBoxResult.Cancel
                MsgBox("Cancel")
                Return
        End Select

    End Sub

    Private Sub LBL_deleteProfile_LinkClicked(sender As Object, e As EventArgs) Handles LBL_deleteProfile.LinkClicked, TS_deleteProfile.Click

        Select Case MsgBox("Are you sure you want to delete your account?", MsgBoxStyle.YesNoCancel)
            Case MsgBoxResult.Yes

                For Each x In newUserList
                    If x.Username = newUser.Username Then
                        newUser = x
                    End If
                Next

                newUserList.Remove(newUser)

                Registration.TB_login.Text = Nothing
                Registration.TB_password.Text = Nothing
                Registration.TB_passwordConfirmation.Text = Nothing
                Registration.RB_1.Checked = False
                Registration.RB_2.Checked = False
                Registration.RB_3.Checked = False

                newUser.Username = Nothing
                newUser.Password = Nothing
                newUser.Firstname = Nothing
                newUser.Lastname = Nothing
                newUser.Address = Nothing
                newUser.Telephone = Nothing
                newUser.School = Nothing
                newUser.Program = Nothing

                Me.Close()
                Home.Visible = True

            Case MsgBoxResult.No
                MsgBox("No")
                Return

            Case MsgBoxResult.Cancel
                MsgBox("Cancel")
                Return
        End Select
    End Sub

    Private Sub BTN_viewUser_Click(sender As Object, e As EventArgs) Handles BTN_viewUser.Click, PB_welcome.Click, TS_viewProfile.Click
        View.Visible = True
        Me.Close()
    End Sub

    Private Sub BTN_createUser_Click(sender As Object, e As EventArgs) Handles BTN_createUser.Click, TS_createProfile.Click
        Create.Visible = True
        Me.Close()
    End Sub

    Private Sub BTN_editUser_Click(sender As Object, e As EventArgs) Handles BTN_editUser.Click, TS_editProfile.Click
        Edit.Visible = True
        Me.Close()
    End Sub

    Private Sub TS_close_Click(sender As Object, e As EventArgs) Handles TS_close.Click
        Me.Close()
    End Sub

    Private Sub TS_about_Click(sender As Object, e As EventArgs) Handles TS_about.Click
        MsgBox("This application was made for fun by Jonathan Amparo on October 2018. " & vbNewLine & vbNewLine &
         "The game RuneScape was created and owned by Jagex.  You can check out their amazing game at Runescape.com." & vbNewLine & vbNewLine &
         "Now... About the game... " & vbNewLine & vbNewLine &
         "This is RuneScape. The world's most popular free to play MMO. Join over 200,000,000 registered adventurers as you explore the land of Gielinor, learn new skills, complete challenging quests, slay foul beasts and more. Create your own unique hero and embark on your greatest adventure; skilling, questing and fighting your way through hours of content.")
    End Sub

End Class