Imports MySql.Data.MySqlClient

Public Class Form2
    Public server As String
    Public port As String
    Public nme As String
    Public user As String
    Public pass As String
    Public con As New MySqlConnection
    Public sql As String
    Public ds As New DataSet
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public Pos As Integer

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con = New MySqlConnection
        Dim cmd = New MySqlCommand
        Dim da = New MySqlDataAdapter
        Dim MysqlTable = New DataTable

        Dim DBSTRING As String = "server=localhost;" & "user id=root;" & "password=;" & "database=reading_list;"
        con.ConnectionString = DBSTRING
        Dim SlectStrng As String = "SELECT title as 'Title', genre as 'Genre' , chapters as 'No. of Chapters', status as 'Status', rstat as 'Reading Status' FROM tbl_titles"


        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandText = SlectStrng
            da.SelectCommand = cmd
            da.Fill(MysqlTable)
            DataGridView1.DataSource = MysqlTable

        Catch ex As Exception
            MessageBox.Show("Cannot retrieve the data from Database. Error:" & ex.Message)
            con.Close()
        Finally
            con.Close()

        End Try


    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txt_title.Text = DataGridView1.CurrentRow.Cells(0).Value
        txt_genre.Text = DataGridView1.CurrentRow.Cells(1).Value
        txt_chap.Text = DataGridView1.CurrentRow.Cells(2).Value
        txt_stat.Text = DataGridView1.CurrentRow.Cells(3).Value
        txt_rstat.Text = DataGridView1.CurrentRow.Cells(4).Value
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim con = New MySqlConnection
        Dim cmd = New MySqlCommand
        Dim DBSTRING As String = "server=localhost;user id=root;password=;database=reading_list;"
        con.ConnectionString = DBSTRING

        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "UPDATE tbl_titles SET genre = @genre, chapters = @chapters, status = @status, rstat = @rstat WHERE title = @title"

            cmd.Parameters.AddWithValue("@title", txt_title.Text)
            cmd.Parameters.AddWithValue("@genre", txt_genre.Text)
            cmd.Parameters.AddWithValue("@chapters", txt_chap.Text)
            cmd.Parameters.AddWithValue("@status", txt_stat.Text)
            cmd.Parameters.AddWithValue("@rstat", txt_rstat.Text)

            Dim ius As Integer = cmd.ExecuteNonQuery()

            If ius > 0 Then
                MsgBox("Update Successfully!")
            Else
                MsgBox("Update Failed!")
            End If
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        Dim con = New MySqlConnection
        Dim cmd = New MySqlCommand
        Dim da = New MySqlDataAdapter
        Dim MysqlTable = New DataTable

        Dim DBSTRING As String = "server=localhost;" & "user id=root;" & "password=;" & "database=reading_list;"
        con.ConnectionString = DBSTRING
        Dim SlectStrng As String = "SELECT title as 'Title', genre as 'Genre' , chapters as 'No. of Chapters', status as 'Status', rstat as 'Reading Status' FROM tbl_titles"


        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandText = SlectStrng
            da.SelectCommand = cmd
            da.Fill(MysqlTable)
            DataGridView1.DataSource = MysqlTable

        Catch ex As Exception
            MessageBox.Show("Cannot retrieve the data from Database. Error:" & ex.Message)
            con.Close()
        Finally
            con.Close()

        End Try

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim con = New MySqlConnection
        Dim cmd = New MySqlCommand
        Dim da = New MySqlDataAdapter
        Dim MysqlTable = New DataTable

        Dim DBSTRING As String = "server=localhost;" & "user id=root;" & "password=;" & "database=reading_list;"
        con.ConnectionString = DBSTRING

        Try
            con.Open()
            cmd.Connection = con
            Dim delete = "DELETE FROM tbl_titles WHERE title = '" & DataGridView1.CurrentRow.Cells(0).Value.ToString() & "'"
            cmd = New MySqlCommand(delete, con)
            cmd.ExecuteNonQuery()
            MsgBox("Deleted Successfully!")

        Catch ex As MySqlException
            MsgBox(ex.ToString())
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim con = New MySqlConnection
        Dim cmd = New MySqlCommand
        Dim da = New MySqlDataAdapter
        Dim MysqlTable = New DataTable

        Dim DBSTRING As String = "server=localhost;" & "user id=root;" & "password=;" & "database=reading_list;"
        con.ConnectionString = DBSTRING

        Try
            cmd.Connection = con

            cmd.CommandText = "INSERT INTO tbl_titles(`title`,`genre`,`chapters`,`status`,`rstat`) VALUES (@title,@genre,@chapters,@status,@rstat) "
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@title", txt_title.Text)
            cmd.Parameters.AddWithValue("@genre", txt_genre.Text)
            cmd.Parameters.AddWithValue("@chapters", txt_chap.Text)
            cmd.Parameters.AddWithValue("@status", txt_stat.Text)
            cmd.Parameters.AddWithValue("@rstat", txt_rstat.Text)




            con.Open()

            Dim isadded As Integer
            isadded = cmd.ExecuteNonQuery()

            If isadded > 0 Then
                MsgBox("Title added successfully!")
                txt_title.Text = ""
                txt_genre.Text = ""
                txt_chap.Text = ""
                txt_stat.Text = ""
                txt_rstat.Text = ""


            Else
                MsgBox("Error!")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            con.Close()

        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim url As String = "https://www.novelupdates.com/"

        Process.Start(url)
        LinkLabel1.LinkVisited = True
    End Sub

End Class