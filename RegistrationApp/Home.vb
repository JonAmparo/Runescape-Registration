Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TS_createProfile.Visible = False
        TS_editProfile.Visible = False
        TS_deleteProfile.Visible = False
        TS_logout.Visible = False

    End Sub

    Public Sub TS_about_Click(sender As Object, e As EventArgs) Handles TS_about.Click

        MsgBox("This application was made for fun by Jonathan Amparo on October 2018. " & vbNewLine & vbNewLine &
               "The game RuneScape was created and owned by Jagex.  You can check out their amazing game at Runescape.com." & vbNewLine & vbNewLine &
               "Now... About the game... " & vbNewLine & vbNewLine &
               "This is RuneScape. The world's most popular free to play MMO. Join over 200,000,000 registered adventurers as you explore the land of Gielinor, learn new skills, complete challenging quests, slay foul beasts and more. Create your own unique hero and embark on your greatest adventure; skilling, questing and fighting your way through hours of content.")
    End Sub

    Private Sub TS_login_Click(sender As Object, e As EventArgs) Handles TS_login.Click
        Login.Visible = True
        Me.Visible = False
    End Sub

    Private Sub TS_close_Click(sender As Object, e As EventArgs) Handles TS_close.Click
        Me.Close()
    End Sub

    Private Sub BTN_newUser_Click(sender As Object, e As EventArgs) Handles BTN_newUser.Click
        Registration.Visible = True
        Me.Visible = False
    End Sub

    Private Sub BTN_existingUser_Click(sender As Object, e As EventArgs) Handles BTN_existingUser.Click
        Login.Visible = True
        Me.Visible = False
    End Sub

    Private Sub TS_newUser_Click(sender As Object, e As EventArgs) Handles TS_newUser.Click
        Registration.Visible = True
        Me.Visible = False
    End Sub
End Class
