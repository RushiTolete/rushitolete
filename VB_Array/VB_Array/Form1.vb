Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim intNum() As Integer = {1, 3, 5, 7, 9}
        'Dim strArray() As String = {"Rushi", "Jolene", "Steven"}
        ''For Each Val As String In intNum
        ''    MsgBox(Val.ToString())
        ''Next
        'MsgBox(strArray(0).ToString)
        'MsgBox(strArray(1).ToString)
        'MsgBox(strArray(2).ToString)
        'strArray(0) = "Tolete"
        'strArray(1) = "Altares"
        'MsgBox(strArray(0).ToString)

        Dim clrs() As String = {"Pink", "Purple", "Green", "Gold", "Red"}
        'Array.Sort(clrs)
        'MsgBox(clrs.ToString)

        'For Each Val As String In clrs
        '    MsgBox(Val.ToString)
        'Next

        Array.Reverse(clrs)
        For Each Val As String In clrs
            MsgBox(Val.ToString)
        Next


    End Sub

End Class
