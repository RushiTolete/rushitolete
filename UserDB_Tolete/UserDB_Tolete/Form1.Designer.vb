<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        txt_user = New TextBox()
        txt_password = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        btn_login = New Button()
        btn_setting = New Button()
        SuspendLayout()
        ' 
        ' txt_user
        ' 
        txt_user.Location = New Point(34, 141)
        txt_user.Name = "txt_user"
        txt_user.Size = New Size(311, 27)
        txt_user.TabIndex = 11
        ' 
        ' txt_password
        ' 
        txt_password.Location = New Point(34, 222)
        txt_password.Name = "txt_password"
        txt_password.PasswordChar = "*"c
        txt_password.Size = New Size(311, 27)
        txt_password.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(34, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 26)
        Label2.TabIndex = 13
        Label2.Text = "Username"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(34, 193)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 26)
        Label1.TabIndex = 14
        Label1.Text = "Password"
        ' 
        ' btn_login
        ' 
        btn_login.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_login.Location = New Point(207, 278)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(138, 40)
        btn_login.TabIndex = 16
        btn_login.Text = "Login"
        btn_login.UseVisualStyleBackColor = True
        ' 
        ' btn_setting
        ' 
        btn_setting.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_setting.Location = New Point(369, 385)
        btn_setting.Name = "btn_setting"
        btn_setting.Size = New Size(138, 40)
        btn_setting.TabIndex = 17
        btn_setting.Text = "Settings"
        btn_setting.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(588, 482)
        Controls.Add(btn_setting)
        Controls.Add(btn_login)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(txt_password)
        Controls.Add(txt_user)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_user As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_setting As Button
End Class
