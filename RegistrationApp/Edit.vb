Public Class Edit
    Private Sub Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TS_login.Visible = False

        ' PB_1.clic = ImageList1.Images(newUser.getCharacter)

        TB_firstname.Text = newUser.Firstname
        TB_lastname.Text = newUser.Lastname
        TB_address.Text = newUser.Address
        TB_telephone.Text = newUser.Telephone
        TB_school.Text = newUser.School
        TB_program.Text = newUser.Program


        'If x Then

        'End If
    End Sub

    Private Sub BTN_logout_Click(sender As Object, e As EventArgs) Handles TS_logout.Click

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

    Private Sub LBL_deleteProfil(sender As Object, e As EventArgs) Handles TS_deleteProfile.Click

        Select Case MsgBox("Are you sure you want to delete your account?", MsgBoxStyle.YesNoCancel)
            Case MsgBoxResult.Yes

                For Each x In MainMenu.newUserList
                    If x.Username = Login.online.Username Then
                        newUser = x
                    End If
                Next

                MainMenu.newUserList.Remove(newUser)

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

    Private Sub BTN_viewUser_Click(sender As Object, e As EventArgs) Handles TS_viewProfile.Click
        View.Visible = True
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

    Private Sub TS_backtoMainMenu_Click(sender As Object, e As EventArgs) Handles TS_backtoMainMenu.Click
        MainMenu.Visible = True
        Me.Close()
    End Sub

    Private Sub LBL_deleteProfile_LinkClicked(sender As Object, e As EventArgs) Handles TS_deleteProfile.Click

    End Sub

    Private Sub BTN_register_Click(sender As Object, e As EventArgs) Handles BTN_register.Click
        If TB_firstname.Text.Length <= 1 Then
            MsgBox("Enter a first name with two or more letters!", MsgBoxStyle.Exclamation, "Registration")
            Return
        End If

        If TB_lastname.Text.Length <= 1 Then
            MsgBox("Enter a last name with two or more letters!", MsgBoxStyle.Exclamation, "Registration")
            Return
        End If

        If TB_address.Text.Length <= 3 Then
            MsgBox("Enter a address with 4 or more letters!", MsgBoxStyle.Exclamation, "Registration")
            Return
        End If
        If TB_telephone.Text.Length >= 11 Or TB_telephone.Text.Length <= 5 Then
            MsgBox("Enter a valid phone number", MsgBoxStyle.Exclamation, "Registration")
            Return
        End If
        If TB_school.Text.Length <= 1 Then
            MsgBox("School must have a name...", MsgBoxStyle.Exclamation, "Registration")
            Return
        End If
        If TB_program.Text.Length <= 1 Then
            MsgBox("Program must have a name...", MsgBoxStyle.Exclamation, "Registration")
            Return
        End If

        MainMenu.newUserList.Add(New User('Login.online.Username,
                                TB_firstname.Text,
                                TB_lastname.Text,
                                TB_address.Text,
                                TB_telephone.Text,
                                TB_school.Text,
                                TB_program.Text
                                ))

        newUser.Firstname = TB_firstname.Text
        newUser.Lastname = TB_lastname.Text
        newUser.Address = TB_address.Text
        newUser.Telephone = TB_telephone.Text
        newUser.School = TB_school.Text
        newUser.Program = TB_program.Text

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



        MainMenu.Visible = True
        Me.Close()
    End Sub

End Class