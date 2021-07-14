<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Anggota
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
        Me.TextBox_Add_Anggota_bergabung = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox_Add_Anggota_status = New System.Windows.Forms.ComboBox()
        Me.Button_Add_Anggota_Add = New System.Windows.Forms.Button()
        Me.Button_Add_Anggota_New = New System.Windows.Forms.Button()
        Me.DateTimePicker_Add_Anggota_tanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.TextBox_Add_Anggota_noHp = New System.Windows.Forms.TextBox()
        Me.TextBox_Add_Anggota_tempatLahir = New System.Windows.Forms.TextBox()
        Me.TextBox_Add_Anggota_nama = New System.Windows.Forms.TextBox()
        Me.TextBox_Add_Anggota_username = New System.Windows.Forms.TextBox()
        Me.TextBox_Add_Anggota_id = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button_Edit_Anggota_Delete = New System.Windows.Forms.Button()
        Me.Button_Edit_Anggota_Refresh = New System.Windows.Forms.Button()
        Me.ComboBox_Edit_Anggota_id = New System.Windows.Forms.ComboBox()
        Me.TextBox_Edit_Anggota_bergabung = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox_Edit_Anggota_status = New System.Windows.Forms.ComboBox()
        Me.Button_Edit_Anggota_Update = New System.Windows.Forms.Button()
        Me.Button_Edit_Anggota_New = New System.Windows.Forms.Button()
        Me.DateTimePicker_Edit_Anggota_tanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.TextBox_Edit_Anggota_noHp = New System.Windows.Forms.TextBox()
        Me.TextBox_Edit_Anggota_tempatLahir = New System.Windows.Forms.TextBox()
        Me.TextBox_Edit_Anggota_nama = New System.Windows.Forms.TextBox()
        Me.TextBox_Edit_Anggota_username = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button_Anggota_Exit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(248, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FORM ANGGOTA"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox_Add_Anggota_bergabung)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.ComboBox_Add_Anggota_status)
        Me.GroupBox1.Controls.Add(Me.Button_Add_Anggota_Add)
        Me.GroupBox1.Controls.Add(Me.Button_Add_Anggota_New)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker_Add_Anggota_tanggalLahir)
        Me.GroupBox1.Controls.Add(Me.TextBox_Add_Anggota_noHp)
        Me.GroupBox1.Controls.Add(Me.TextBox_Add_Anggota_tempatLahir)
        Me.GroupBox1.Controls.Add(Me.TextBox_Add_Anggota_nama)
        Me.GroupBox1.Controls.Add(Me.TextBox_Add_Anggota_username)
        Me.GroupBox1.Controls.Add(Me.TextBox_Add_Anggota_id)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 309)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TAMBAH ANGGOTA"
        '
        'TextBox_Add_Anggota_bergabung
        '
        Me.TextBox_Add_Anggota_bergabung.Enabled = False
        Me.TextBox_Add_Anggota_bergabung.Location = New System.Drawing.Point(135, 186)
        Me.TextBox_Add_Anggota_bergabung.Name = "TextBox_Add_Anggota_bergabung"
        Me.TextBox_Add_Anggota_bergabung.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Add_Anggota_bergabung.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 189)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "BERGABUNG"
        '
        'ComboBox_Add_Anggota_status
        '
        Me.ComboBox_Add_Anggota_status.FormattingEnabled = True
        Me.ComboBox_Add_Anggota_status.Items.AddRange(New Object() {"MAHASISWA", "MEMBER", "UMUM"})
        Me.ComboBox_Add_Anggota_status.Location = New System.Drawing.Point(135, 211)
        Me.ComboBox_Add_Anggota_status.Name = "ComboBox_Add_Anggota_status"
        Me.ComboBox_Add_Anggota_status.Size = New System.Drawing.Size(117, 21)
        Me.ComboBox_Add_Anggota_status.TabIndex = 18
        '
        'Button_Add_Anggota_Add
        '
        Me.Button_Add_Anggota_Add.Location = New System.Drawing.Point(294, 258)
        Me.Button_Add_Anggota_Add.Name = "Button_Add_Anggota_Add"
        Me.Button_Add_Anggota_Add.Size = New System.Drawing.Size(75, 23)
        Me.Button_Add_Anggota_Add.TabIndex = 15
        Me.Button_Add_Anggota_Add.Text = "TAMBAH"
        Me.Button_Add_Anggota_Add.UseVisualStyleBackColor = True
        '
        'Button_Add_Anggota_New
        '
        Me.Button_Add_Anggota_New.Location = New System.Drawing.Point(21, 258)
        Me.Button_Add_Anggota_New.Name = "Button_Add_Anggota_New"
        Me.Button_Add_Anggota_New.Size = New System.Drawing.Size(75, 23)
        Me.Button_Add_Anggota_New.TabIndex = 14
        Me.Button_Add_Anggota_New.Text = "BARU"
        Me.Button_Add_Anggota_New.UseVisualStyleBackColor = True
        '
        'DateTimePicker_Add_Anggota_tanggalLahir
        '
        Me.DateTimePicker_Add_Anggota_tanggalLahir.Location = New System.Drawing.Point(135, 134)
        Me.DateTimePicker_Add_Anggota_tanggalLahir.Name = "DateTimePicker_Add_Anggota_tanggalLahir"
        Me.DateTimePicker_Add_Anggota_tanggalLahir.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker_Add_Anggota_tanggalLahir.TabIndex = 13
        '
        'TextBox_Add_Anggota_noHp
        '
        Me.TextBox_Add_Anggota_noHp.Location = New System.Drawing.Point(135, 161)
        Me.TextBox_Add_Anggota_noHp.Name = "TextBox_Add_Anggota_noHp"
        Me.TextBox_Add_Anggota_noHp.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Add_Anggota_noHp.TabIndex = 11
        '
        'TextBox_Add_Anggota_tempatLahir
        '
        Me.TextBox_Add_Anggota_tempatLahir.Location = New System.Drawing.Point(135, 108)
        Me.TextBox_Add_Anggota_tempatLahir.Name = "TextBox_Add_Anggota_tempatLahir"
        Me.TextBox_Add_Anggota_tempatLahir.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Add_Anggota_tempatLahir.TabIndex = 10
        '
        'TextBox_Add_Anggota_nama
        '
        Me.TextBox_Add_Anggota_nama.Location = New System.Drawing.Point(135, 82)
        Me.TextBox_Add_Anggota_nama.Name = "TextBox_Add_Anggota_nama"
        Me.TextBox_Add_Anggota_nama.Size = New System.Drawing.Size(212, 20)
        Me.TextBox_Add_Anggota_nama.TabIndex = 9
        '
        'TextBox_Add_Anggota_username
        '
        Me.TextBox_Add_Anggota_username.Location = New System.Drawing.Point(135, 56)
        Me.TextBox_Add_Anggota_username.Name = "TextBox_Add_Anggota_username"
        Me.TextBox_Add_Anggota_username.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Add_Anggota_username.TabIndex = 8
        '
        'TextBox_Add_Anggota_id
        '
        Me.TextBox_Add_Anggota_id.Location = New System.Drawing.Point(135, 32)
        Me.TextBox_Add_Anggota_id.Name = "TextBox_Add_Anggota_id"
        Me.TextBox_Add_Anggota_id.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Add_Anggota_id.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 214)
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
        Me.GroupBox2.Controls.Add(Me.Button_Edit_Anggota_Delete)
        Me.GroupBox2.Controls.Add(Me.Button_Edit_Anggota_Refresh)
        Me.GroupBox2.Controls.Add(Me.ComboBox_Edit_Anggota_id)
        Me.GroupBox2.Controls.Add(Me.TextBox_Edit_Anggota_bergabung)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.ComboBox_Edit_Anggota_status)
        Me.GroupBox2.Controls.Add(Me.Button_Edit_Anggota_Update)
        Me.GroupBox2.Controls.Add(Me.Button_Edit_Anggota_New)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker_Edit_Anggota_tanggalLahir)
        Me.GroupBox2.Controls.Add(Me.TextBox_Edit_Anggota_noHp)
        Me.GroupBox2.Controls.Add(Me.TextBox_Edit_Anggota_tempatLahir)
        Me.GroupBox2.Controls.Add(Me.TextBox_Edit_Anggota_nama)
        Me.GroupBox2.Controls.Add(Me.TextBox_Edit_Anggota_username)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Location = New System.Drawing.Point(405, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(387, 309)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "EDIT ANGGOTA"
        '
        'Button_Edit_Anggota_Delete
        '
        Me.Button_Edit_Anggota_Delete.Location = New System.Drawing.Point(111, 258)
        Me.Button_Edit_Anggota_Delete.Name = "Button_Edit_Anggota_Delete"
        Me.Button_Edit_Anggota_Delete.Size = New System.Drawing.Size(75, 23)
        Me.Button_Edit_Anggota_Delete.TabIndex = 23
        Me.Button_Edit_Anggota_Delete.Text = "DELETE"
        Me.Button_Edit_Anggota_Delete.UseVisualStyleBackColor = True
        '
        'Button_Edit_Anggota_Refresh
        '
        Me.Button_Edit_Anggota_Refresh.Location = New System.Drawing.Point(201, 258)
        Me.Button_Edit_Anggota_Refresh.Name = "Button_Edit_Anggota_Refresh"
        Me.Button_Edit_Anggota_Refresh.Size = New System.Drawing.Size(75, 23)
        Me.Button_Edit_Anggota_Refresh.TabIndex = 22
        Me.Button_Edit_Anggota_Refresh.Text = "REFRESH"
        Me.Button_Edit_Anggota_Refresh.UseVisualStyleBackColor = True
        '
        'ComboBox_Edit_Anggota_id
        '
        Me.ComboBox_Edit_Anggota_id.FormattingEnabled = True
        Me.ComboBox_Edit_Anggota_id.Location = New System.Drawing.Point(135, 29)
        Me.ComboBox_Edit_Anggota_id.Name = "ComboBox_Edit_Anggota_id"
        Me.ComboBox_Edit_Anggota_id.Size = New System.Drawing.Size(117, 21)
        Me.ComboBox_Edit_Anggota_id.TabIndex = 21
        '
        'TextBox_Edit_Anggota_bergabung
        '
        Me.TextBox_Edit_Anggota_bergabung.Enabled = False
        Me.TextBox_Edit_Anggota_bergabung.Location = New System.Drawing.Point(135, 186)
        Me.TextBox_Edit_Anggota_bergabung.Name = "TextBox_Edit_Anggota_bergabung"
        Me.TextBox_Edit_Anggota_bergabung.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Edit_Anggota_bergabung.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 189)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "BERGABUNG"
        '
        'ComboBox_Edit_Anggota_status
        '
        Me.ComboBox_Edit_Anggota_status.FormattingEnabled = True
        Me.ComboBox_Edit_Anggota_status.Items.AddRange(New Object() {"MAHASISWA", "MEMBER", "UMUM"})
        Me.ComboBox_Edit_Anggota_status.Location = New System.Drawing.Point(135, 211)
        Me.ComboBox_Edit_Anggota_status.Name = "ComboBox_Edit_Anggota_status"
        Me.ComboBox_Edit_Anggota_status.Size = New System.Drawing.Size(117, 21)
        Me.ComboBox_Edit_Anggota_status.TabIndex = 18
        '
        'Button_Edit_Anggota_Update
        '
        Me.Button_Edit_Anggota_Update.Location = New System.Drawing.Point(294, 258)
        Me.Button_Edit_Anggota_Update.Name = "Button_Edit_Anggota_Update"
        Me.Button_Edit_Anggota_Update.Size = New System.Drawing.Size(75, 23)
        Me.Button_Edit_Anggota_Update.TabIndex = 15
        Me.Button_Edit_Anggota_Update.Text = "UPDATE"
        Me.Button_Edit_Anggota_Update.UseVisualStyleBackColor = True
        '
        'Button_Edit_Anggota_New
        '
        Me.Button_Edit_Anggota_New.Location = New System.Drawing.Point(21, 258)
        Me.Button_Edit_Anggota_New.Name = "Button_Edit_Anggota_New"
        Me.Button_Edit_Anggota_New.Size = New System.Drawing.Size(75, 23)
        Me.Button_Edit_Anggota_New.TabIndex = 14
        Me.Button_Edit_Anggota_New.Text = "BARU"
        Me.Button_Edit_Anggota_New.UseVisualStyleBackColor = True
        '
        'DateTimePicker_Edit_Anggota_tanggalLahir
        '
        Me.DateTimePicker_Edit_Anggota_tanggalLahir.Location = New System.Drawing.Point(135, 134)
        Me.DateTimePicker_Edit_Anggota_tanggalLahir.Name = "DateTimePicker_Edit_Anggota_tanggalLahir"
        Me.DateTimePicker_Edit_Anggota_tanggalLahir.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker_Edit_Anggota_tanggalLahir.TabIndex = 13
        '
        'TextBox_Edit_Anggota_noHp
        '
        Me.TextBox_Edit_Anggota_noHp.Location = New System.Drawing.Point(135, 161)
        Me.TextBox_Edit_Anggota_noHp.Name = "TextBox_Edit_Anggota_noHp"
        Me.TextBox_Edit_Anggota_noHp.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Edit_Anggota_noHp.TabIndex = 11
        '
        'TextBox_Edit_Anggota_tempatLahir
        '
        Me.TextBox_Edit_Anggota_tempatLahir.Location = New System.Drawing.Point(135, 108)
        Me.TextBox_Edit_Anggota_tempatLahir.Name = "TextBox_Edit_Anggota_tempatLahir"
        Me.TextBox_Edit_Anggota_tempatLahir.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Edit_Anggota_tempatLahir.TabIndex = 10
        '
        'TextBox_Edit_Anggota_nama
        '
        Me.TextBox_Edit_Anggota_nama.Location = New System.Drawing.Point(135, 82)
        Me.TextBox_Edit_Anggota_nama.Name = "TextBox_Edit_Anggota_nama"
        Me.TextBox_Edit_Anggota_nama.Size = New System.Drawing.Size(212, 20)
        Me.TextBox_Edit_Anggota_nama.TabIndex = 9
        '
        'TextBox_Edit_Anggota_username
        '
        Me.TextBox_Edit_Anggota_username.Location = New System.Drawing.Point(135, 56)
        Me.TextBox_Edit_Anggota_username.Name = "TextBox_Edit_Anggota_username"
        Me.TextBox_Edit_Anggota_username.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Edit_Anggota_username.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 214)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "STATUS"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 164)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "NO HP"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 138)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "TANGGAL LAHIR"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(18, 111)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "TEMPAT LAHIR"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(18, 85)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "NAMA"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(18, 59)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "USERNAME"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(18, 35)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(18, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "ID"
        '
        'Button_Anggota_Exit
        '
        Me.Button_Anggota_Exit.Location = New System.Drawing.Point(366, 393)
        Me.Button_Anggota_Exit.Name = "Button_Anggota_Exit"
        Me.Button_Anggota_Exit.Size = New System.Drawing.Size(75, 23)
        Me.Button_Anggota_Exit.TabIndex = 22
        Me.Button_Anggota_Exit.Text = "EXIT"
        Me.Button_Anggota_Exit.UseVisualStyleBackColor = True
        '
        'Form_Anggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 428)
        Me.Controls.Add(Me.Button_Anggota_Exit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Anggota"
        Me.Text = "FORM ANGGOTA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button_Add_Anggota_Add As Button
    Friend WithEvents Button_Add_Anggota_New As Button
    Friend WithEvents DateTimePicker_Add_Anggota_tanggalLahir As DateTimePicker
    Friend WithEvents TextBox_Add_Anggota_noHp As TextBox
    Friend WithEvents TextBox_Add_Anggota_tempatLahir As TextBox
    Friend WithEvents TextBox_Add_Anggota_nama As TextBox
    Friend WithEvents TextBox_Add_Anggota_username As TextBox
    Friend WithEvents TextBox_Add_Anggota_id As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_Add_Anggota_bergabung As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox_Add_Anggota_status As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox_Edit_Anggota_bergabung As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox_Edit_Anggota_status As ComboBox
    Friend WithEvents Button_Edit_Anggota_Update As Button
    Friend WithEvents Button_Edit_Anggota_New As Button
    Friend WithEvents DateTimePicker_Edit_Anggota_tanggalLahir As DateTimePicker
    Friend WithEvents TextBox_Edit_Anggota_noHp As TextBox
    Friend WithEvents TextBox_Edit_Anggota_tempatLahir As TextBox
    Friend WithEvents TextBox_Edit_Anggota_nama As TextBox
    Friend WithEvents TextBox_Edit_Anggota_username As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents ComboBox_Edit_Anggota_id As ComboBox
    Friend WithEvents Button_Anggota_Exit As Button
    Friend WithEvents Button_Edit_Anggota_Refresh As Button
    Friend WithEvents Button_Edit_Anggota_Delete As Button
End Class
