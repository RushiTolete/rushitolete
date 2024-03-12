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
        txt_math = New TextBox()
        txt_eng = New TextBox()
        txt_sci = New TextBox()
        txt_pe = New TextBox()
        btn_ave = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' txt_math
        ' 
        txt_math.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_math.Location = New Point(59, 140)
        txt_math.Name = "txt_math"
        txt_math.Size = New Size(268, 31)
        txt_math.TabIndex = 0
        ' 
        ' txt_eng
        ' 
        txt_eng.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_eng.Location = New Point(59, 202)
        txt_eng.Name = "txt_eng"
        txt_eng.Size = New Size(268, 31)
        txt_eng.TabIndex = 1
        ' 
        ' txt_sci
        ' 
        txt_sci.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_sci.Location = New Point(59, 264)
        txt_sci.Name = "txt_sci"
        txt_sci.Size = New Size(268, 31)
        txt_sci.TabIndex = 2
        ' 
        ' txt_pe
        ' 
        txt_pe.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_pe.Location = New Point(59, 326)
        txt_pe.Name = "txt_pe"
        txt_pe.Size = New Size(268, 31)
        txt_pe.TabIndex = 3
        ' 
        ' btn_ave
        ' 
        btn_ave.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_ave.Location = New Point(109, 387)
        btn_ave.Name = "btn_ave"
        btn_ave.Size = New Size(151, 55)
        btn_ave.TabIndex = 4
        btn_ave.Text = "Evaluate"
        btn_ave.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(54, 349)
        Button2.Name = "Button2"
        Button2.Size = New Size(8, 8)
        Button2.TabIndex = 5
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(54, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(254, 28)
        Label1.TabIndex = 6
        Label1.Text = "Average Grade Calculator"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(59, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 25)
        Label2.TabIndex = 7
        Label2.Text = "Math"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(54, 174)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 25)
        Label3.TabIndex = 8
        Label3.Text = "English"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(54, 236)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 25)
        Label4.TabIndex = 9
        Label4.Text = "Science"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(54, 298)
        Label5.Name = "Label5"
        Label5.Size = New Size(37, 25)
        Label5.TabIndex = 10
        Label5.Text = "P.E."
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(454, 503)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(btn_ave)
        Controls.Add(txt_pe)
        Controls.Add(txt_sci)
        Controls.Add(txt_eng)
        Controls.Add(txt_math)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_math As TextBox
    Friend WithEvents txt_eng As TextBox
    Friend WithEvents txt_sci As TextBox
    Friend WithEvents txt_pe As TextBox
    Friend WithEvents btn_ave As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label

End Class
