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
        btn_add = New Button()
        btn_update = New Button()
        btn_delete = New Button()
        Panel1 = New Panel()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        txt_title = New TextBox()
        Label2 = New Label()
        txt_genre = New TextBox()
        txt_chap = New TextBox()
        txt_stat = New TextBox()
        txt_rstat = New TextBox()
        btn_refresh = New Button()
        Panel2 = New Panel()
        LinkLabel1 = New LinkLabel()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btn_add
        ' 
        btn_add.BackColor = Color.Yellow
        btn_add.Location = New Point(704, 441)
        btn_add.Name = "btn_add"
        btn_add.Size = New Size(94, 29)
        btn_add.TabIndex = 1
        btn_add.Text = "Add"
        btn_add.UseVisualStyleBackColor = False
        ' 
        ' btn_update
        ' 
        btn_update.BackColor = Color.Yellow
        btn_update.Location = New Point(932, 441)
        btn_update.Name = "btn_update"
        btn_update.Size = New Size(94, 29)
        btn_update.TabIndex = 2
        btn_update.Text = "Update"
        btn_update.UseVisualStyleBackColor = False
        ' 
        ' btn_delete
        ' 
        btn_delete.BackColor = Color.Orange
        btn_delete.Location = New Point(140, 441)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(94, 29)
        btn_delete.TabIndex = 3
        btn_delete.Text = "Delete"
        btn_delete.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-2, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1211, 86)
        Panel1.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe Script", 22.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(3, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(297, 61)
        Label1.TabIndex = 5
        Label1.Text = "Reading List "
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 106)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(660, 314)
        DataGridView1.TabIndex = 5
        ' 
        ' txt_title
        ' 
        txt_title.Location = New Point(704, 142)
        txt_title.Multiline = True
        txt_title.Name = "txt_title"
        txt_title.Size = New Size(322, 54)
        txt_title.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bahnschrift SemiLight", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(834, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 28)
        Label2.TabIndex = 7
        Label2.Text = "Title"
        ' 
        ' txt_genre
        ' 
        txt_genre.Location = New Point(704, 230)
        txt_genre.Multiline = True
        txt_genre.Name = "txt_genre"
        txt_genre.Size = New Size(322, 58)
        txt_genre.TabIndex = 8
        ' 
        ' txt_chap
        ' 
        txt_chap.Location = New Point(704, 336)
        txt_chap.Name = "txt_chap"
        txt_chap.Size = New Size(106, 27)
        txt_chap.TabIndex = 9
        ' 
        ' txt_stat
        ' 
        txt_stat.Location = New Point(834, 337)
        txt_stat.Name = "txt_stat"
        txt_stat.Size = New Size(192, 27)
        txt_stat.TabIndex = 10
        ' 
        ' txt_rstat
        ' 
        txt_rstat.Location = New Point(877, 395)
        txt_rstat.Name = "txt_rstat"
        txt_rstat.Size = New Size(149, 27)
        txt_rstat.TabIndex = 11
        ' 
        ' btn_refresh
        ' 
        btn_refresh.BackColor = Color.Yellow
        btn_refresh.Location = New Point(13, 439)
        btn_refresh.Name = "btn_refresh"
        btn_refresh.Size = New Size(121, 29)
        btn_refresh.TabIndex = 12
        btn_refresh.Text = "Refresh Table"
        btn_refresh.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Teal
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(LinkLabel1)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(2, 498)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1237, 47)
        Panel2.TabIndex = 13
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.LinkColor = Color.White
        LinkLabel1.Location = New Point(473, 7)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(74, 20)
        LinkLabel1.TabIndex = 1
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "click here."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(300, 7)
        Label3.Name = "Label3"
        Label3.Size = New Size(178, 60)
        Label3.TabIndex = 0
        Label3.Text = "To get to Novel Updates, " & vbCrLf & vbCrLf & vbCrLf
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Bahnschrift SemiLight", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(704, 199)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 28)
        Label4.TabIndex = 14
        Label4.Text = "Genre"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Bahnschrift SemiLight", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(704, 305)
        Label5.Name = "Label5"
        Label5.Size = New Size(106, 28)
        Label5.TabIndex = 15
        Label5.Text = "Chapters"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Bahnschrift SemiLight", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(704, 389)
        Label6.Name = "Label6"
        Label6.Size = New Size(167, 28)
        Label6.TabIndex = 16
        Label6.Text = "Reading Status"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Bahnschrift SemiLight", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(834, 305)
        Label7.Name = "Label7"
        Label7.Size = New Size(79, 28)
        Label7.TabIndex = 17
        Label7.Text = "Status"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.White
        Label8.Location = New Point(11, 7)
        Label8.Name = "Label8"
        Label8.Size = New Size(295, 20)
        Label8.TabIndex = 18
        Label8.Text = "These titles are found in novelupdates.com." & vbCrLf
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(1058, 543)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Panel2)
        Controls.Add(btn_refresh)
        Controls.Add(txt_rstat)
        Controls.Add(txt_stat)
        Controls.Add(txt_chap)
        Controls.Add(txt_genre)
        Controls.Add(Label2)
        Controls.Add(txt_title)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        Controls.Add(btn_delete)
        Controls.Add(btn_update)
        Controls.Add(btn_add)
        Name = "Form2"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txt_title As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_genre As TextBox
    Friend WithEvents txt_chap As TextBox
    Friend WithEvents txt_stat As TextBox
    Friend WithEvents txt_rstat As TextBox
    Friend WithEvents btn_refresh As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lnk_nu As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label8 As Label
End Class
