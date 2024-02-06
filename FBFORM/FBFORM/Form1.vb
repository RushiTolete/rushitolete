Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_reg.Click

    End Sub
    Dim Users As User = New User()
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim username As String = txt_user.Text
        Dim password As String = txt_pass.Text

        If Not String.IsNullOrEmpty(txt_user.Text) And Not String.IsNullOrEmpty(txt_pass.Text) Then

            If username = "Admin" And password = "123" Then

                MsgBox("Hello " + username.ToString(), vbInformation, " Welcome!")
                Me.Hide()
                Form2.Show()

            Else

                MsgBox("Please Try Again! ", vbCritical, " Invalid User!")
                txt_user.Text = ""
                txt_pass.Text = ""
            End If
        Else
            MsgBox("Input User and Password! ", vbCritical, "Invalid!")
        End If


    End Sub

    Private Sub txt_user_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_user.KeyPress
        'txt_pass.Focus()

    End Sub

    Private Sub txt_user_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_user.KeyUp
        If e.KeyCode = Keys.Enter Then
            txt_pass.Focus()
        End If


    End Sub

    Private Sub txt_pass_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_pass.KeyUp
        If e.KeyCode = Keys.Enter Then
            btn_login.PerformClick()

        End If
    End Sub
End Class
