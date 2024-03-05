Imports System.Numerics

Public Class Form1

    Function msg() As String
        Return "Hello World"
    End Function

    Function num() As Double
        Return 2048
    End Function

    Function add(ByVal numone As Integer, ByVal numtwo As Integer) As Integer
        Dim total As Integer
        total = numone + numtwo
        Return total
    End Function

    Function helloser(ByVal name As String) As String
        Return "Good Evening " + name + "!!!"
    End Function

    Function factorial(ByVal num As Integer) As Integer
        Dim result As Integer

        If (num = 1) Then
            Return 1
        Else factorial(num - 1) * num
        End If
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(msg)
        MsgBox("Year: " + num.ToString)
        MsgBox("10 + 20 = " + add(10, 20).ToString)
        MsgBox(helloser("Jolene"))
        MsgBox(factorial(2).ToString())
    End Sub


End Class
