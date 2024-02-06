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
        Label1 = New Label()
        Label2 = New Label()
        txt_usern = New TextBox()
        txt_email = New TextBox()
        txt_pass = New TextBox()
        txt_conf = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        btn_create = New Button()
        btn_exit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cooper Black", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(49), CByte(119), CByte(115))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(286, 69)
        Label1.TabIndex = 0
        Label1.Text = "Register"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Label2.Location = New Point(286, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(141, 37)
        Label2.TabIndex = 1
        Label2.Text = "Account"
        ' 
        ' txt_usern
        ' 
        txt_usern.Location = New Point(76, 134)
        txt_usern.Name = "txt_usern"
        txt_usern.Size = New Size(241, 27)
        txt_usern.TabIndex = 2
        ' 
        ' txt_email
        ' 
        txt_email.Location = New Point(76, 175)
        txt_email.Name = "txt_email"
        txt_email.Size = New Size(241, 27)
        txt_email.TabIndex = 3
        ' 
        ' txt_pass
        ' 
        txt_pass.Location = New Point(76, 220)
        txt_pass.Multiline = True
        txt_pass.Name = "txt_pass"
        txt_pass.PasswordChar = "*"c
        txt_pass.Size = New Size(241, 27)
        txt_pass.TabIndex = 4
        ' 
        ' txt_conf
        ' 
        txt_conf.Location = New Point(76, 262)
        txt_conf.Name = "txt_conf"
        txt_conf.PasswordChar = "*"c
        txt_conf.Size = New Size(241, 27)
        txt_conf.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.Image = My.Resources.Resources.icons8_user_24__1_
        Label3.Location = New Point(31, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 26)
        Label3.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.Image = My.Resources.Resources.icons8_email_24
        Label4.Location = New Point(31, 178)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 25)
        Label4.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.Image = My.Resources.Resources.icons8_password_24__2_
        Label5.Location = New Point(31, 220)
        Label5.Name = "Label5"
        Label5.Size = New Size(39, 27)
        Label5.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.Image = My.Resources.Resources.icons8_password_24__2_
        Label6.Location = New Point(31, 262)
        Label6.Name = "Label6"
        Label6.Size = New Size(39, 27)
        Label6.TabIndex = 9
        ' 
        ' btn_create
        ' 
        btn_create.BackColor = Color.FromArgb(CByte(49), CByte(119), CByte(115))
        btn_create.ForeColor = Color.White
        btn_create.Location = New Point(180, 312)
        btn_create.Name = "btn_create"
        btn_create.Size = New Size(147, 40)
        btn_create.TabIndex = 10
        btn_create.Text = "Create Account"
        btn_create.UseVisualStyleBackColor = False
        ' 
        ' btn_exit
        ' 
        btn_exit.BackColor = Color.FromArgb(CByte(49), CByte(119), CByte(115))
        btn_exit.ForeColor = Color.White
        btn_exit.Location = New Point(333, 312)
        btn_exit.Name = "btn_exit"
        btn_exit.Size = New Size(94, 40)
        btn_exit.TabIndex = 11
        btn_exit.Text = "Cancel"
        btn_exit.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(226), CByte(209), CByte(249))
        ClientSize = New Size(667, 380)
        Controls.Add(btn_exit)
        Controls.Add(btn_create)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txt_conf)
        Controls.Add(txt_pass)
        Controls.Add(txt_email)
        Controls.Add(txt_usern)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_usern As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents txt_conf As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_create As Button
    Friend WithEvents btn_exit As Button
End Class
