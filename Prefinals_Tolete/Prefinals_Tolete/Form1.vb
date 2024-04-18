
Imports MySql.Data.MySqlClient
Public Class Form1


    Public DBServer As String
    Public DBPort As String
    Public DBName As String
    Public DBUser As String
    Public DBPass As String
    Public MysqlConn As New MySqlConnection
    Public sqL As String
    Public ds As New DataSet
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public Pos As Integer

    Private Sub btn_seedata_Click(sender As Object, e As EventArgs) Handles btn_seedata.Click
        Dim MysqlConnect = New MySqlConnection
        Dim MySqlCommand = New MySqlCommand
        Dim MysqlAdpater = New MySqlDataAdapter
        Dim MysqlTable = New DataTable

        Dim DBSTRING As String = "server=127.0.0.1;" & "user id=root;" & "password=;" & "database=dbbooks;"
        MysqlConnect.ConnectionString = DBSTRING
        Dim SlectStrng As String = "SELECT id as 'Book ID', title as 'Title', genre as 'Genre', qty as 'Qty', price as 'Price' FROM book_tbl"


        Try
            MysqlConnect.Open()
            MySqlCommand.Connection = MysqlConnect
            MySqlCommand.CommandText = SlectStrng
            MysqlAdpater.SelectCommand = MySqlCommand
            MysqlAdpater.Fill(MysqlTable)
            DataGridView1.DataSource = MysqlTable

        Catch ex As Exception
            MessageBox.Show("Cannot retrieve the data from Database. Error:" & ex.Message)
            MysqlConnect.Close()
        Finally
            MysqlConnect.Close()

        End Try
    End Sub






End Class
