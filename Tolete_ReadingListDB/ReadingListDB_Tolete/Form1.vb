
Public Class Form1


    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If txt_user.Text = "Shimarue" And txt_pass.Text = "1104" Then
            MsgBox("Welcome User! ")
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect Username or Password! ")
            txt_user.Text = ""
            txt_pass.Text = ""
        End If


    End Sub




End Class
