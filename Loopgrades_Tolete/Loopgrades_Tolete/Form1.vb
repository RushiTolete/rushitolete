Public Class Form1
    Function math() As Double
        Return Val(txt_math.Text)
    End Function

    Function english() As Double
        Return Val(txt_eng.Text)
    End Function

    Function science() As Double
        Return Val(txt_sci.Text)
    End Function

    Function pe() As Double
        Return Val(txt_pe.Text)
    End Function

    Function add() As Double
        Return math() + english() + science() + pe()
    End Function

    Function ave() As Double
        Return add() / 4
    End Function

    Private Sub btn_ave_Click(sender As Object, e As EventArgs) Handles btn_ave.Click
        Dim a As Integer = 0
        MsgBox("Your grade is: " + ave().ToString)

        If (ave() >= 90) Then
            Do
                MsgBox("A+")
                a += 1
            Loop While (a <= 4)

        ElseIf (ave() >= 79) Then
            Do
                MsgBox("B+")
                a += 1
            Loop While (a <= 2)
        ElseIf (ave() >= 75) Then
            Do
                MsgBox("C+")
                a += 1
            Loop While (a <= 1)
        Else
            Do
                MsgBox("Failed")
                a += 1
            Loop While (a <= 9)
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_math.Focus()
    End Sub


End Class
