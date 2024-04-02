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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        txt_fstname = New TextBox()
        txt_lstname = New TextBox()
        txt_mdlname = New TextBox()
        txt_age = New TextBox()
        txt_address = New TextBox()
        txt_brtdate = New TextBox()
        btn_signup = New Button()
        epError = New ErrorProvider(components)
        epSuccess = New ErrorProvider(components)
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        CType(epError, ComponentModel.ISupportInitialize).BeginInit()
        CType(epSuccess, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_fstname
        ' 
        txt_fstname.Location = New Point(98, 155)
        txt_fstname.Name = "txt_fstname"
        txt_fstname.Size = New Size(261, 27)
        txt_fstname.TabIndex = 0
        ' 
        ' txt_lstname
        ' 
        txt_lstname.Location = New Point(98, 261)
        txt_lstname.Name = "txt_lstname"
        txt_lstname.Size = New Size(261, 27)
        txt_lstname.TabIndex = 1
        ' 
        ' txt_mdlname
        ' 
        txt_mdlname.Location = New Point(98, 208)
        txt_mdlname.Name = "txt_mdlname"
        txt_mdlname.Size = New Size(261, 27)
        txt_mdlname.TabIndex = 2
        ' 
        ' txt_age
        ' 
        txt_age.Location = New Point(98, 314)
        txt_age.Name = "txt_age"
        txt_age.Size = New Size(261, 27)
        txt_age.TabIndex = 3
        ' 
        ' txt_address
        ' 
        txt_address.Location = New Point(98, 420)
        txt_address.Name = "txt_address"
        txt_address.Size = New Size(261, 27)
        txt_address.TabIndex = 4
        ' 
        ' txt_brtdate
        ' 
        txt_brtdate.Location = New Point(98, 367)
        txt_brtdate.Name = "txt_brtdate"
        txt_brtdate.Size = New Size(261, 27)
        txt_brtdate.TabIndex = 5
        ' 
        ' btn_signup
        ' 
        btn_signup.BackColor = Color.FromArgb(CByte(255), CByte(219), CByte(88))
        btn_signup.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_signup.Location = New Point(155, 485)
        btn_signup.Name = "btn_signup"
        btn_signup.Size = New Size(149, 43)
        btn_signup.TabIndex = 6
        btn_signup.Text = "Sign Up"
        btn_signup.UseVisualStyleBackColor = False
        ' 
        ' epError
        ' 
        epError.ContainerControl = Me
        ' 
        ' epSuccess
        ' 
        epSuccess.ContainerControl = Me
        epSuccess.Icon = CType(resources.GetObject("epSuccess.Icon"), Icon)
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Font = New Font("Cooper Black", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(255), CByte(219), CByte(88))
        Label1.Location = New Point(120, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(269, 69)
        Label1.TabIndex = 7
        Label1.Text = "Sign Up"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(98, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 20)
        Label2.TabIndex = 8
        Label2.Text = "First Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(98, 185)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 20)
        Label3.TabIndex = 9
        Label3.Text = "Middle Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(98, 238)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 20)
        Label4.TabIndex = 10
        Label4.Text = "Last Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(98, 291)
        Label5.Name = "Label5"
        Label5.Size = New Size(36, 20)
        Label5.TabIndex = 11
        Label5.Text = "Age"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(98, 344)
        Label6.Name = "Label6"
        Label6.Size = New Size(70, 20)
        Label6.TabIndex = 12
        Label6.Text = "Birthdate"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(98, 397)
        Label7.Name = "Label7"
        Label7.Size = New Size(62, 20)
        Label7.TabIndex = 13
        Label7.Text = "Address"
        ' 
        ' Label8
        ' 
        Label8.Image = CType(resources.GetObject("Label8.Image"), Image)
        Label8.Location = New Point(27, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(97, 113)
        Label8.TabIndex = 14
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(140), CByte(138), CByte(147))
        ClientSize = New Size(473, 596)
        Controls.Add(Label8)
        Controls.Add(Label1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btn_signup)
        Controls.Add(txt_brtdate)
        Controls.Add(txt_address)
        Controls.Add(txt_age)
        Controls.Add(txt_mdlname)
        Controls.Add(txt_lstname)
        Controls.Add(txt_fstname)
        Name = "Form1"
        Text = "Form1"
        CType(epError, ComponentModel.ISupportInitialize).EndInit()
        CType(epSuccess, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_fstname As TextBox
    Friend WithEvents txt_lstname As TextBox
    Friend WithEvents txt_mdlname As TextBox
    Friend WithEvents txt_age As TextBox
    Friend WithEvents txt_address As TextBox
    Friend WithEvents txt_brtdate As TextBox
    Friend WithEvents btn_signup As Button
    Friend WithEvents epError As ErrorProvider
    Friend WithEvents epSuccess As ErrorProvider
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label

End Class
