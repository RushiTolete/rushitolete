<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        txt_user = New TextBox()
        ico_user = New Label()
        lbl_login = New Label()
        txt_pass = New TextBox()
        Label1 = New Label()
        btn_login = New Button()
        Label2 = New Label()
        btn_reg = New Button()
        SuspendLayout()
        ' 
        ' txt_user
        ' 
        txt_user.Location = New Point(95, 161)
        txt_user.Name = "txt_user"
        txt_user.Size = New Size(267, 27)
        txt_user.TabIndex = 0
        ' 
        ' ico_user
        ' 
        ico_user.Image = CType(resources.GetObject("ico_user.Image"), Image)
        ico_user.Location = New Point(48, 151)
        ico_user.Name = "ico_user"
        ico_user.Size = New Size(41, 46)
        ico_user.TabIndex = 1
        ' 
        ' lbl_login
        ' 
        lbl_login.AutoSize = True
        lbl_login.Font = New Font("Cooper Black", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_login.ForeColor = SystemColors.ControlLightLight
        lbl_login.Location = New Point(54, 30)
        lbl_login.Name = "lbl_login"
        lbl_login.Size = New Size(267, 91)
        lbl_login.TabIndex = 2
        lbl_login.Text = "Login"
        ' 
        ' txt_pass
        ' 
        txt_pass.Location = New Point(95, 208)
        txt_pass.Name = "txt_pass"
        txt_pass.PasswordChar = "*"c
        txt_pass.Size = New Size(267, 27)
        txt_pass.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.Image = CType(resources.GetObject("Label1.Image"), Image)
        Label1.Location = New Point(54, 208)
        Label1.Name = "Label1"
        Label1.Size = New Size(35, 37)
        Label1.TabIndex = 4
        ' 
        ' btn_login
        ' 
        btn_login.BackColor = Color.FromArgb(CByte(226), CByte(209), CByte(249))
        btn_login.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_login.Location = New Point(216, 270)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(146, 41)
        btn_login.TabIndex = 5
        btn_login.Text = "Login"
        btn_login.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.Image = My.Resources.Resources.icons8_login_48
        Label2.Location = New Point(309, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 45)
        Label2.TabIndex = 6
        ' 
        ' btn_reg
        ' 
        btn_reg.BackColor = Color.FromArgb(CByte(226), CByte(209), CByte(249))
        btn_reg.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_reg.Location = New Point(54, 270)
        btn_reg.Name = "btn_reg"
        btn_reg.Size = New Size(146, 41)
        btn_reg.TabIndex = 7
        btn_reg.Text = "Register"
        btn_reg.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(49), CByte(119), CByte(115))
        ClientSize = New Size(601, 345)
        Controls.Add(btn_reg)
        Controls.Add(Label2)
        Controls.Add(btn_login)
        Controls.Add(Label1)
        Controls.Add(txt_pass)
        Controls.Add(lbl_login)
        Controls.Add(ico_user)
        Controls.Add(txt_user)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_user As TextBox
    Friend WithEvents ico_user As Label
    Friend WithEvents lbl_login As Label
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_login As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_reg As Button

End Class
