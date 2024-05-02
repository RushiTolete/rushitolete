<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txt_name = New TextBox()
        txt_user = New TextBox()
        txt_password = New TextBox()
        txt_cpass = New TextBox()
        txt_isadmin = New TextBox()
        btn_signup = New Button()
        btn_cancel = New Button()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(75, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 26)
        Label2.TabIndex = 5
        Label2.Text = "Full Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(75, 141)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 26)
        Label1.TabIndex = 6
        Label1.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(75, 214)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 26)
        Label3.TabIndex = 7
        Label3.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(75, 285)
        Label4.Name = "Label4"
        Label4.Size = New Size(198, 26)
        Label4.TabIndex = 8
        Label4.Text = "Confirm Password"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(75, 361)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 26)
        Label5.TabIndex = 9
        Label5.Text = "Is Admin"
        ' 
        ' txt_name
        ' 
        txt_name.Location = New Point(75, 95)
        txt_name.Name = "txt_name"
        txt_name.Size = New Size(370, 27)
        txt_name.TabIndex = 10
        ' 
        ' txt_user
        ' 
        txt_user.Location = New Point(75, 171)
        txt_user.Name = "txt_user"
        txt_user.Size = New Size(370, 27)
        txt_user.TabIndex = 11
        ' 
        ' txt_password
        ' 
        txt_password.Location = New Point(75, 244)
        txt_password.Name = "txt_password"
        txt_password.PasswordChar = "*"c
        txt_password.Size = New Size(370, 27)
        txt_password.TabIndex = 12
        ' 
        ' txt_cpass
        ' 
        txt_cpass.Location = New Point(75, 315)
        txt_cpass.Name = "txt_cpass"
        txt_cpass.PasswordChar = "*"c
        txt_cpass.Size = New Size(370, 27)
        txt_cpass.TabIndex = 13
        ' 
        ' txt_isadmin
        ' 
        txt_isadmin.Location = New Point(75, 391)
        txt_isadmin.Name = "txt_isadmin"
        txt_isadmin.Size = New Size(370, 27)
        txt_isadmin.TabIndex = 14
        ' 
        ' btn_signup
        ' 
        btn_signup.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_signup.Location = New Point(143, 453)
        btn_signup.Name = "btn_signup"
        btn_signup.Size = New Size(138, 40)
        btn_signup.TabIndex = 15
        btn_signup.Text = "Sign Up"
        btn_signup.UseVisualStyleBackColor = True
        ' 
        ' btn_cancel
        ' 
        btn_cancel.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_cancel.Location = New Point(307, 453)
        btn_cancel.Name = "btn_cancel"
        btn_cancel.Size = New Size(138, 40)
        btn_cancel.TabIndex = 16
        btn_cancel.Text = "Cancel"
        btn_cancel.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(519, 537)
        Controls.Add(btn_cancel)
        Controls.Add(btn_signup)
        Controls.Add(txt_isadmin)
        Controls.Add(txt_cpass)
        Controls.Add(txt_password)
        Controls.Add(txt_user)
        Controls.Add(txt_name)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_user As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_cpass As TextBox
    Friend WithEvents txt_isadmin As TextBox
    Friend WithEvents btn_signup As Button
    Friend WithEvents btn_cancel As Button
End Class
