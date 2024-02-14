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
        txt_fname = New TextBox()
        txt_lname = New TextBox()
        txt_age = New TextBox()
        btn_signup = New Button()
        btn_exit = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' txt_fname
        ' 
        txt_fname.Location = New Point(74, 175)
        txt_fname.Name = "txt_fname"
        txt_fname.Size = New Size(284, 27)
        txt_fname.TabIndex = 1
        ' 
        ' txt_lname
        ' 
        txt_lname.Location = New Point(74, 237)
        txt_lname.Name = "txt_lname"
        txt_lname.Size = New Size(284, 27)
        txt_lname.TabIndex = 2
        ' 
        ' txt_age
        ' 
        txt_age.Location = New Point(74, 304)
        txt_age.Name = "txt_age"
        txt_age.Size = New Size(284, 27)
        txt_age.TabIndex = 3
        ' 
        ' btn_signup
        ' 
        btn_signup.Location = New Point(74, 371)
        btn_signup.Name = "btn_signup"
        btn_signup.Size = New Size(94, 29)
        btn_signup.TabIndex = 4
        btn_signup.Text = "Sign Up"
        btn_signup.UseVisualStyleBackColor = True
        ' 
        ' btn_exit
        ' 
        btn_exit.Location = New Point(264, 371)
        btn_exit.Name = "btn_exit"
        btn_exit.Size = New Size(94, 29)
        btn_exit.TabIndex = 5
        btn_exit.Text = "Back"
        btn_exit.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(29, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 20)
        Label1.TabIndex = 6
        Label1.Text = "Sign Up"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(74, 152)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 20)
        Label2.TabIndex = 7
        Label2.Text = "First Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(74, 214)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 20)
        Label3.TabIndex = 8
        Label3.Text = "Last Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(74, 281)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 20)
        Label4.TabIndex = 9
        Label4.Text = "Age"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(432, 458)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_exit)
        Controls.Add(btn_signup)
        Controls.Add(txt_age)
        Controls.Add(txt_lname)
        Controls.Add(txt_fname)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_fname As TextBox
    Friend WithEvents txt_lname As TextBox
    Friend WithEvents txt_age As TextBox
    Friend WithEvents btn_signup As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
