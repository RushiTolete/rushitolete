Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Text.RegularExpressions

Public Class Form1

    Private Sub txt_fstname_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_fstname.KeyUp
        epError.SetError(txt_fstname, String.Empty)
        If Not String.IsNullOrEmpty(txt_fstname.Text.Trim) Then
            epSuccess.SetError(txt_fstname, "Valid")
        Else
            epSuccess.SetError(txt_fstname, String.Empty)
        End If

    End Sub

    Private Sub txt_mdlname_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_mdlname.KeyUp
        epError.SetError(txt_mdlname, String.Empty)
        If Not String.IsNullOrEmpty(txt_mdlname.Text.Trim) Then
            epSuccess.SetError(txt_mdlname, "Valid")
        Else
            epSuccess.SetError(txt_mdlname, String.Empty)
        End If
    End Sub

    Private Sub txt_lstname_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_lstname.KeyUp
        epError.SetError(txt_lstname, String.Empty)
        If Not String.IsNullOrEmpty(txt_lstname.Text.Trim) Then
            epSuccess.SetError(txt_lstname, "Valid")
        Else
            epSuccess.SetError(txt_lstname, String.Empty)
        End If
    End Sub

    Private Sub txt_age_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_age.KeyUp
        epError.SetError(txt_age, String.Empty)
        If Not String.IsNullOrEmpty(txt_age.Text.Trim) Then
            epSuccess.SetError(txt_age, "Valid")
        Else
            epSuccess.SetError(txt_age, String.Empty)
        End If
    End Sub

    Private Sub txt_brtdate_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_brtdate.KeyUp
        epError.SetError(txt_brtdate, String.Empty)
        If Not String.IsNullOrEmpty(txt_brtdate.Text.Trim) Then
            epSuccess.SetError(txt_brtdate, "Valid")
        Else
            epSuccess.SetError(txt_brtdate, String.Empty)
        End If
    End Sub

    Private Sub txt_address_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_address.KeyUp
        epError.SetError(txt_address, String.Empty)
        If Not String.IsNullOrEmpty(txt_address.Text.Trim) Then
            epSuccess.SetError(txt_address, "Valid")
        Else
            epSuccess.SetError(txt_address, String.Empty)
        End If
    End Sub

    Dim Namevalid As Boolean
    Private Sub txt_fstname_Leave(sender As Object, e As EventArgs) Handles txt_fstname.Leave
        If Not Regex.Match(txt_fstname.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Alphabetic Characters Only!")


            txt_fstname.Focus()
            txt_fstname.Clear()
            Namevalid = False
        Else

            Namevalid = True

        End If
    End Sub



    Dim SurnameValid As Boolean

    Private Sub txt_mdlname_Leave(sender As Object, e As EventArgs) Handles txt_mdlname.Leave
        Dim strSurname As String = "^[a-zA-Z\s]+$"
        Dim reSurname As New Regex(strSurname)
        If Not reSurname.IsMatch(txt_mdlname.Text) Then

            MessageBox.Show("Please Enter Alphabetic Characters Only!")
            txt_mdlname.Focus()
            txt_mdlname.Clear()
            SurnameValid = False
        Else

            SurnameValid = True
        End If

    End Sub

    Private Sub txt_lstname_Leave(sender As Object, e As EventArgs) Handles txt_lstname.Leave
        Dim strSurname As String = "^[a-zA-Z\s]+$"
        Dim reSurname As New Regex(strSurname)
        If Not reSurname.IsMatch(txt_lstname.Text) Then

            MessageBox.Show("Please Enter Alphabetic Characters Only!")
            txt_lstname.Focus()
            txt_lstname.Clear()
            SurnameValid = False
        Else

            SurnameValid = True
        End If
    End Sub

    Private Sub txt_age_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_age.KeyPress
        Dim c As Char

        c = e.KeyChar
        If Not (Char.IsDigit(c) Or c = "." Or Char.IsControl(c)) Then
            e.Handled = True
            MsgBox("numeric texts only")

        End If

    End Sub

    Private Sub btn_signup_Click(sender As Object, e As EventArgs) Handles btn_signup.Click
        Dim filled As Boolean = True

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                If String.IsNullOrEmpty(CType(ctrl, TextBox).Text) Then
                    filled = False
                    Exit For
                End If
            End If
        Next
        If filled Then
            MsgBox("User " + txt_fstname.Text + "" + " has successfully signed up")
        Else
            MsgBox("Please fill in the requirements")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
