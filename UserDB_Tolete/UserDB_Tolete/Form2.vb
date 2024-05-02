Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp

Public Class Form2
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Function validate(ByVal password As String, ByVal cpass As String) As Boolean


        Return String.IsNullOrEmpty(password) = False And password = cpass

    End Function
    Private Sub btn_signup_Click(sender As Object, e As EventArgs) Handles btn_signup.Click


        If validate(txt_password.Text, txt_cpass.Text) = False Then
            MsgBox("Password Do not Match, Try Again!")

        Else
            Dim mysqlconnect = New MySqlConnection
            Dim mysqlcommand = New MySqlCommand


            Dim servercon = "server=127.0.0.1;" & "user id=root;" & "password=;" & "database=userdb;"
            mysqlconnect.ConnectionString = servercon

            Try
                MySqlCommand.Connection = mysqlconnect

                mysqlcommand.CommandText = "INSERT INTO user_tbl(`fullname`,`username`,`password`,`isAdmin`) VALUES (@fullname,@username,@password,@isAdmin) "
                mysqlcommand.CommandType = CommandType.Text
                MySqlCommand.Parameters.AddWithValue("@fullname", txt_name.Text)
                MySqlCommand.Parameters.AddWithValue("@username", txt_user.Text)
                MySqlCommand.Parameters.AddWithValue("@password", txt_password.Text)
                MySqlCommand.Parameters.AddWithValue("@isAdmin", txt_isadmin.Text)



                mysqlconnect.Open()

                Dim isadded As Integer
                isadded = MySqlCommand.ExecuteNonQuery()

                If isadded > 0 Then
                    MsgBox("User added successfully!")
                    txt_name.Text = ""
                    txt_user.Text = ""
                    txt_password.Text = ""
                    txt_cpass.Text = ""
                    txt_isadmin.Text = ""

                Else
                    MsgBox("Error!")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString())
            Finally
                mysqlconnect.Close()

            End Try

        End If

    End Sub
End Class