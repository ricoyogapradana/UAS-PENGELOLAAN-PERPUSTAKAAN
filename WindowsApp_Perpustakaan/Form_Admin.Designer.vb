<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Admin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox_Add_Admin_status = New System.Windows.Forms.ComboBox()
        Me.Button_Add_Admin_Add = New System.Windows.Forms.Button()
        Me.Button_Add_Admin_New = New System.Windows.Forms.Button()
        Me.DateTimePicker_Add_Admin_tanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.TextBox_Add_Admin_noHp = New System.Windows.Forms.TextBox()
        Me.TextBox_Add_Admin_tempatLahir = New System.Windows.Forms.TextBox()
        Me.TextBox_Add_Admin_nama = New System.Windows.Forms.TextBox()
        Me.TextBox_Add_Admin_username = New System.Windows.Forms.TextBox()
        Me.TextBox_Add_Admin_id = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button_Edit_Admin_Refresh = New System.Windows.Forms.Button()
        Me.Button_Edit_Admin_Delete = New System.Windows.Forms.Button()
        Me.ComboBox_Edit_Admin_status = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Edit_Admin_id = New System.Windows.Forms.ComboBox()
        Me.Button_Edit_Admin_Update = New System.Windows.Forms.Button()
        Me.Button_Edit_Admin_New = New System.Windows.Forms.Button()
        Me.DateTimePicker_Edit_Admin_tanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.TextBox_Edit_Admin_noHp = New System.Windows.Forms.TextBox()
        Me.TextBox_Edit_Admin_tempatLahir = New System.Windows.Forms.TextBox()
        Me.TextBox_Edit_Admin_nama = New System.Windows.Forms.TextBox()
        Me.TextBox_Edit_Admin_username = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button_Admin_Exit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(265, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FORM ADMIN"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox_Add_Admin_status)
        Me.GroupBox1.Controls.Add(Me.Button_Add_Admin_Add)
        Me.GroupBox1.Controls.Add(Me.Button_Add_Admin_New)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker_Add_Admin_tanggalLahir)
        Me.GroupBox1.Controls.Add(Me.TextBox_Add_Admin_noHp)
        Me.GroupBox1.Controls.Add(Me.TextBox_Add_Admin_tempatLahir)
        Me.GroupBox1.Controls.Add(Me.TextBox_Add_Admin_nama)
        Me.GroupBox1.Controls.Add(Me.TextBox_Add_Admin_username)
        Me.GroupBox1.Controls.Add(Me.TextBox_Add_Admin_id)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 281)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TAMBAH ADMIN"
        '
        'ComboBox_Add_Admin_status
        '
        Me.ComboBox_Add_Admin_status.FormattingEnabled = True
        Me.ComboBox_Add_Admin_status.Items.AddRange(New Object() {"ADMIN", "PENGELOLA", "STAFF"})
        Me.ComboBox_Add_Admin_status.Location = New System.Drawing.Point(135, 185)
        Me.ComboBox_Add_Admin_status.Name = "ComboBox_Add_Admin_status"
        Me.ComboBox_Add_Admin_status.Size = New System.Drawing.Size(117, 21)
        Me.ComboBox_Add_Admin_status.TabIndex = 17
        '
        'Button_Add_Admin_Add
        '
        Me.Button_Add_Admin_Add.Location = New System.Drawing.Point(295, 229)
        Me.Button_Add_Admin_Add.Name = "Button_Add_Admin_Add"
        Me.Button_Add_Admin_Add.Size = New System.Drawing.Size(75, 23)
        Me.Button_Add_Admin_Add.TabIndex = 15
        Me.Button_Add_Admin_Add.Text = "TAMBAH"
        Me.Button_Add_Admin_Add.UseVisualStyleBackColor = True
        '
        'Button_Add_Admin_New
        '
        Me.Button_Add_Admin_New.Location = New System.Drawing.Point(21, 229)
        Me.Button_Add_Admin_New.Name = "Button_Add_Admin_New"
        Me.Button_Add_Admin_New.Size = New System.Drawing.Size(75, 23)
        Me.Button_Add_Admin_New.TabIndex = 14
        Me.Button_Add_Admin_New.Text = "BARU"
        Me.Button_Add_Admin_New.UseVisualStyleBackColor = True
        '
        'DateTimePicker_Add_Admin_tanggalLahir
        '
        Me.DateTimePicker_Add_Admin_tanggalLahir.Location = New System.Drawing.Point(135, 134)
        Me.DateTimePicker_Add_Admin_tanggalLahir.Name = "DateTimePicker_Add_Admin_tanggalLahir"
        Me.DateTimePicker_Add_Admin_tanggalLahir.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker_Add_Admin_tanggalLahir.TabIndex = 13
        '
        'TextBox_Add_Admin_noHp
        '
        Me.TextBox_Add_Admin_noHp.Location = New System.Drawing.Point(135, 161)
        Me.TextBox_Add_Admin_noHp.Name = "TextBox_Add_Admin_noHp"
        Me.TextBox_Add_Admin_noHp.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Add_Admin_noHp.TabIndex = 11
        '
        'TextBox_Add_Admin_tempatLahir
        '
        Me.TextBox_Add_Admin_tempatLahir.Location = New System.Drawing.Point(135, 108)
        Me.TextBox_Add_Admin_tempatLahir.Name = "TextBox_Add_Admin_tempatLahir"
        Me.TextBox_Add_Admin_tempatLahir.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Add_Admin_tempatLahir.TabIndex = 10
        '
        'TextBox_Add_Admin_nama
        '
        Me.TextBox_Add_Admin_nama.Location = New System.Drawing.Point(135, 82)
        Me.TextBox_Add_Admin_nama.Name = "TextBox_Add_Admin_nama"
        Me.TextBox_Add_Admin_nama.Size = New System.Drawing.Size(212, 20)
        Me.TextBox_Add_Admin_nama.TabIndex = 9
        '
        'TextBox_Add_Admin_username
        '
        Me.TextBox_Add_Admin_username.Location = New System.Drawing.Point(135, 56)
        Me.TextBox_Add_Admin_username.Name = "TextBox_Add_Admin_username"
        Me.TextBox_Add_Admin_username.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Add_Admin_username.TabIndex = 8
        '
        'TextBox_Add_Admin_id
        '
        Me.TextBox_Add_Admin_id.Location = New System.Drawing.Point(135, 32)
        Me.TextBox_Add_Admin_id.Name = "TextBox_Add_Admin_id"
        Me.TextBox_Add_Admin_id.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Add_Admin_id.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "STATUS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "NO HP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "TANGGAL LAHIR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "TEMPAT LAHIR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "NAMA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "USERNAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button_Edit_Admin_Refresh)
        Me.GroupBox2.Controls.Add(Me.Button_Edit_Admin_Delete)
        Me.GroupBox2.Controls.Add(Me.ComboBox_Edit_Admin_status)
        Me.GroupBox2.Controls.Add(Me.ComboBox_Edit_Admin_id)
        Me.GroupBox2.Controls.Add(Me.Button_Edit_Admin_Update)
        Me.GroupBox2.Controls.Add(Me.Button_Edit_Admin_New)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker_Edit_Admin_tanggalLahir)
        Me.GroupBox2.Controls.Add(Me.TextBox_Edit_Admin_noHp)
        Me.GroupBox2.Controls.Add(Me.TextBox_Edit_Admin_tempatLahir)
        Me.GroupBox2.Controls.Add(Me.TextBox_Edit_Admin_nama)
        Me.GroupBox2.Controls.Add(Me.TextBox_Edit_Admin_username)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Location = New System.Drawing.Point(407, 84)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(387, 281)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "EDIT ADMIN"
        '
        'Button_Edit_Admin_Refresh
        '
        Me.Button_Edit_Admin_Refresh.Location = New System.Drawing.Point(203, 229)
        Me.Button_Edit_Admin_Refresh.Name = "Button_Edit_Admin_Refresh"
        Me.Button_Edit_Admin_Refresh.Size = New System.Drawing.Size(75, 23)
        Me.Button_Edit_Admin_Refresh.TabIndex = 25
        Me.Button_Edit_Admin_Refresh.Text = "REFRESH"
        Me.Button_Edit_Admin_Refresh.UseVisualStyleBackColor = True
        '
        'Button_Edit_Admin_Delete
        '
        Me.Button_Edit_Admin_Delete.Location = New System.Drawing.Point(113, 229)
        Me.Button_Edit_Admin_Delete.Name = "Button_Edit_Admin_Delete"
        Me.Button_Edit_Admin_Delete.Size = New System.Drawing.Size(75, 23)
        Me.Button_Edit_Admin_Delete.TabIndex = 24
        Me.Button_Edit_Admin_Delete.Text = "DELETE"
        Me.Button_Edit_Admin_Delete.UseVisualStyleBackColor = True
        '
        'ComboBox_Edit_Admin_status
        '
        Me.ComboBox_Edit_Admin_status.FormattingEnabled = True
        Me.ComboBox_Edit_Admin_status.Items.AddRange(New Object() {"ADMIN", "PENGELOLA", "STAFF"})
        Me.ComboBox_Edit_Admin_status.Location = New System.Drawing.Point(135, 185)
        Me.ComboBox_Edit_Admin_status.Name = "ComboBox_Edit_Admin_status"
        Me.ComboBox_Edit_Admin_status.Size = New System.Drawing.Size(117, 21)
        Me.ComboBox_Edit_Admin_status.TabIndex = 18
        '
        'ComboBox_Edit_Admin_id
        '
        Me.ComboBox_Edit_Admin_id.FormattingEnabled = True
        Me.ComboBox_Edit_Admin_id.Location = New System.Drawing.Point(135, 27)
        Me.ComboBox_Edit_Admin_id.Name = "ComboBox_Edit_Admin_id"
        Me.ComboBox_Edit_Admin_id.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox_Edit_Admin_id.TabIndex = 16
        '
        'Button_Edit_Admin_Update
        '
        Me.Button_Edit_Admin_Update.Location = New System.Drawing.Point(295, 229)
        Me.Button_Edit_Admin_Update.Name = "Button_Edit_Admin_Update"
        Me.Button_Edit_Admin_Update.Size = New System.Drawing.Size(75, 23)
        Me.Button_Edit_Admin_Update.TabIndex = 15
        Me.Button_Edit_Admin_Update.Text = "UPDATE"
        Me.Button_Edit_Admin_Update.UseVisualStyleBackColor = True
        '
        'Button_Edit_Admin_New
        '
        Me.Button_Edit_Admin_New.Location = New System.Drawing.Point(21, 229)
        Me.Button_Edit_Admin_New.Name = "Button_Edit_Admin_New"
        Me.Button_Edit_Admin_New.Size = New System.Drawing.Size(75, 23)
        Me.Button_Edit_Admin_New.TabIndex = 14
        Me.Button_Edit_Admin_New.Text = "BARU"
        Me.Button_Edit_Admin_New.UseVisualStyleBackColor = True
        '
        'DateTimePicker_Edit_Admin_tanggalLahir
        '
        Me.DateTimePicker_Edit_Admin_tanggalLahir.Location = New System.Drawing.Point(135, 134)
        Me.DateTimePicker_Edit_Admin_tanggalLahir.Name = "DateTimePicker_Edit_Admin_tanggalLahir"
        Me.DateTimePicker_Edit_Admin_tanggalLahir.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker_Edit_Admin_tanggalLahir.TabIndex = 13
        '
        'TextBox_Edit_Admin_noHp
        '
        Me.TextBox_Edit_Admin_noHp.Location = New System.Drawing.Point(135, 161)
        Me.TextBox_Edit_Admin_noHp.Name = "TextBox_Edit_Admin_noHp"
        Me.TextBox_Edit_Admin_noHp.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Edit_Admin_noHp.TabIndex = 11
        '
        'TextBox_Edit_Admin_tempatLahir
        '
        Me.TextBox_Edit_Admin_tempatLahir.Location = New System.Drawing.Point(135, 108)
        Me.TextBox_Edit_Admin_tempatLahir.Name = "TextBox_Edit_Admin_tempatLahir"
        Me.TextBox_Edit_Admin_tempatLahir.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Edit_Admin_tempatLahir.TabIndex = 10
        '
        'TextBox_Edit_Admin_nama
        '
        Me.TextBox_Edit_Admin_nama.Location = New System.Drawing.Point(135, 82)
        Me.TextBox_Edit_Admin_nama.Name = "TextBox_Edit_Admin_nama"
        Me.TextBox_Edit_Admin_nama.Size = New System.Drawing.Size(212, 20)
        Me.TextBox_Edit_Admin_nama.TabIndex = 9
        '
        'TextBox_Edit_Admin_username
        '
        Me.TextBox_Edit_Admin_username.Location = New System.Drawing.Point(135, 56)
        Me.TextBox_Edit_Admin_username.Name = "TextBox_Edit_Admin_username"
        Me.TextBox_Edit_Admin_username.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Edit_Admin_username.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 188)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "STATUS"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "NO HP"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 138)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "TANGGAL LAHIR"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 111)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "TEMPAT LAHIR"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 85)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "NAMA"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(18, 59)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "USERNAME"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(18, 35)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(18, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "ID"
        '
        'Button_Admin_Exit
        '
        Me.Button_Admin_Exit.Location = New System.Drawing.Point(368, 382)
        Me.Button_Admin_Exit.Name = "Button_Admin_Exit"
        Me.Button_Admin_Exit.Size = New System.Drawing.Size(75, 23)
        Me.Button_Admin_Exit.TabIndex = 17
        Me.Button_Admin_Exit.Text = "EXIT"
        Me.Button_Admin_Exit.UseVisualStyleBackColor = True
        '
        'Form_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 431)
        Me.Controls.Add(Me.Button_Admin_Exit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Admin"
        Me.Text = "FORM ADMIN"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button_Add_Admin_Add As Button
    Friend WithEvents Button_Add_Admin_New As Button
    Friend WithEvents DateTimePicker_Add_Admin_tanggalLahir As DateTimePicker
    Friend WithEvents TextBox_Add_Admin_noHp As TextBox
    Friend WithEvents TextBox_Add_Admin_tempatLahir As TextBox
    Friend WithEvents TextBox_Add_Admin_nama As TextBox
    Friend WithEvents TextBox_Add_Admin_username As TextBox
    Friend WithEvents TextBox_Add_Admin_id As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox_Edit_Admin_id As ComboBox
    Friend WithEvents Button_Edit_Admin_Update As Button
    Friend WithEvents Button_Edit_Admin_New As Button
    Friend WithEvents DateTimePicker_Edit_Admin_tanggalLahir As DateTimePicker
    Friend WithEvents TextBox_Edit_Admin_noHp As TextBox
    Friend WithEvents TextBox_Edit_Admin_tempatLahir As TextBox
    Friend WithEvents TextBox_Edit_Admin_nama As TextBox
    Friend WithEvents TextBox_Edit_Admin_username As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Button_Admin_Exit As Button
    Friend WithEvents ComboBox_Add_Admin_status As ComboBox
    Friend WithEvents ComboBox_Edit_Admin_status As ComboBox
    Friend WithEvents Button_Edit_Admin_Delete As Button
    Friend WithEvents Button_Edit_Admin_Refresh As Button
End Class
