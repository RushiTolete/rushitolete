Public Class Form2
    Dim fname As String
    Dim lname As String
    Dim age As Integer
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btn_signup_Click(sender As Object, e As EventArgs) Handles btn_signup.Click
        fname = txt_fname.Text
        lname = txt_lname.Text
        MsgBox(fname + " " + lname + " has successfully signed up")
        Form3.Show()
        Me.Hide()

    End Sub
End Class