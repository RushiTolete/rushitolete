Public Class Form3
    Dim mg As Double
    Dim eg As Double
    Dim sg As Double

    Private Sub txt_math_TextChanged(sender As Object, e As EventArgs) Handles txt_math.TextChanged
        'txt_math.Text = txt_math.Text
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub btn_cal_Click(sender As Object, e As EventArgs) Handles btn_cal.Click
        Dim add As Double
        Dim result As Double
        mg = Val(txt_math.Text)
        eg = Val(txt_eng.Text)
        sg = Val(txt_sci.Text)
        add = mg + eg + sg
        result = add / 3


        If (result >= 90) Then
            MsgBox("A+")
        ElseIf (result >= 80) Then
            MsgBox("B+")
        ElseIf (result >= 75) Then
            MsgBox("C+")

        Else
            MsgBox("F")
        End If


    End Sub
End Class