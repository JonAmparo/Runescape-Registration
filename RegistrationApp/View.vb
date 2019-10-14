Public Class View
    Private Sub View_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' If MainMenu.BTN_viewUser Then

        TS_login.Visible = False

        PB_welcome.Image = ImageList1.Images(newUser.getCharacter)

        LBL_viewUsername.Text = newUser.Username
        LBL_viewUsername.Text = newUser.Username
        LBL_viewFirstname.Text = newUser.Firstname
        LBL_viewLastname.Text = newUser.Lastname
        LBL_viewAddress.Text = newUser.Address
        LBL_viewTelephone.Text = newUser.Telephone
        LBL_viewSchool.Text = newUser.School
        LBL_viewProgram.Text = newUser.Program
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

    Private Sub TS_backtoMainMenu_Click(sender As Object, e As EventArgs) Handles TS_backtoMainMenu.Click
        MainMenu.Visible = True
        Me.Close()
    End Sub
End Class