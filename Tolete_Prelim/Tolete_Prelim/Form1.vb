Public Class Form1
    Dim username As String = "root"
    Dim password As String = "root"

    Private Sub txt_user_TextChanged(sender As Object, e As EventArgs) Handles txt_user.TextChanged
        'txt_user.Text = txt_user.Text
        'txt_pass.Focus()

    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        txt_user.Text = username
        txt_pass.Text = password
        MsgBox("Welcome Admin")
        Form2.Show()
        Me.Hide()


    End Sub
End Class
