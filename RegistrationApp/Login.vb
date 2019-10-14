Public Class Login
    Public online As User

    Private Sub BTN_login_Click(sender As Object, e As EventArgs) Handles BTN_login.Click
        'TB_login.Text = Nothing
        'TB_password.Text = Nothing

        'If TB_login.Text.Length > 2 And TB_password.Text.Length > 2 Then
        '    For Each person In MainMenu.newUserList
        '        If TB_login.Text = person.Username AndAlso TB_password.Text = person.Password Then
        '            MsgBox("Signing you in...")
        '            'online = person
        '            MainMenu.Visible = True
        '            Me.Close()
        '        Else
        '            MsgBox("You've entered an incorrect login.")
        '            Return
        '        End If
        '    Next
        'End If

        If newUser.Username = TB_login.Text And newUser.Password = TB_password.Text Then
            MsgBox("Signing you in...")
            MainMenu.Visible = True
            Me.Close()
        Else
            MsgBox("You've entered an incorrect login.")
            Return
        End If

        'newUser.Password = TB_password.Text
    End Sub

    Private Sub BTN_cancel_Click(sender As Object, e As EventArgs) Handles BTN_cancel.Click
        Me.Close()
        Home.Visible = True
    End Sub
End Class