<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        txt_math = New TextBox()
        txt_eng = New TextBox()
        txt_sci = New TextBox()
        btn_cal = New Button()
        btn_exit = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' txt_math
        ' 
        txt_math.Location = New Point(68, 165)
        txt_math.Name = "txt_math"
        txt_math.Size = New Size(284, 27)
        txt_math.TabIndex = 2
        ' 
        ' txt_eng
        ' 
        txt_eng.Location = New Point(68, 224)
        txt_eng.Name = "txt_eng"
        txt_eng.Size = New Size(284, 27)
        txt_eng.TabIndex = 3
        ' 
        ' txt_sci
        ' 
        txt_sci.Location = New Point(68, 290)
        txt_sci.Name = "txt_sci"
        txt_sci.Size = New Size(284, 27)
        txt_sci.TabIndex = 4
        ' 
        ' btn_cal
        ' 
        btn_cal.Location = New Point(68, 363)
        btn_cal.Name = "btn_cal"
        btn_cal.Size = New Size(94, 29)
        btn_cal.TabIndex = 5
        btn_cal.Text = "Calculate"
        btn_cal.UseVisualStyleBackColor = True
        ' 
        ' btn_exit
        ' 
        btn_exit.Location = New Point(258, 363)
        btn_exit.Name = "btn_exit"
        btn_exit.Size = New Size(94, 29)
        btn_exit.TabIndex = 6
        btn_exit.Text = "Back"
        btn_exit.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(24, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 20)
        Label1.TabIndex = 7
        Label1.Text = "Grade Calculator"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(68, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 20)
        Label2.TabIndex = 8
        Label2.Text = "Math"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(68, 201)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 20)
        Label3.TabIndex = 9
        Label3.Text = "English"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(68, 267)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 20)
        Label4.TabIndex = 10
        Label4.Text = "Science"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(441, 479)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_exit)
        Controls.Add(btn_cal)
        Controls.Add(txt_sci)
        Controls.Add(txt_eng)
        Controls.Add(txt_math)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_math As TextBox
    Friend WithEvents txt_eng As TextBox
    Friend WithEvents txt_sci As TextBox
    Friend WithEvents btn_cal As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
