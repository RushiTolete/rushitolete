Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim mysqlconnect = New MySqlConnection
        Dim mysqlcommand = New MySqlCommand
        Dim mysqldatareader As MySqlDataReader

        Dim servercon = "server=127.0.0.1;" & "user id=root;" & "password=;" & "database=userdb;"
        mysqlconnect.ConnectionString = servercon

        Try
            mysqlconnect.Open()
            Dim stringquery = "SELECT * FROM user_tbl WHERE username='" & txt_user.Text & "' AND password='" & txt_password.Text & "'"
            mysqlcommand = New MySqlCommand(stringquery, mysqlconnect)
            mysqldatareader = mysqlcommand.ExecuteReader(CommandBehavior.CloseConnection)

            If mysqldatareader.Read = True Then
                MsgBox("Welcome User!")
            Else
                MsgBox("Invalid username and password!")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            mysqlconnect.Close()
        End Try
    End Sub

    Private Sub btn_setting_Click(sender As Object, e As EventArgs) Handles btn_setting.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class