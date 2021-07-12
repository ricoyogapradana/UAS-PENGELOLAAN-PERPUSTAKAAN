<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Peminjaman
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
        Me.ComboBox_Add_Peminjaman_idBuku = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Add_Peminjaman_namaAdmin = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_Add_Peminjaman_Add = New System.Windows.Forms.Button()
        Me.Button_Add_Peminjaman_New = New System.Windows.Forms.Button()
        Me.TextBox_Add_Peminjaman_id = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox_Add_Peminjaman_namaPeminjam = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker_Add_Peminjaman_tanggalPinjam = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_Add_Peminjaman_tanggalPengembalian = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox_Add_Peminjaman_penulis = New System.Windows.Forms.TextBox()
        Me.TextBox_Add_Peminjaman_penerbit = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox_Edit_Peminjaman_penerbit = New System.Windows.Forms.TextBox()
        Me.TextBox_Edit_Peminjaman_penulis = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateTimePicker_Edit_Peminjaman_tanggalPengembalian = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_Edit_Peminjaman_tanggalPinjam = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox_Edit_Peminjaman_namaPeminjam = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Edit_Peminjaman_idBuku = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Edit_Peminjaman_namaAdmin = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button_Edit_Peminjaman_Update = New System.Windows.Forms.Button()
        Me.Button_Edit_Peminjaman_New = New System.Windows.Forms.Button()
        Me.TextBox_Edit_Peminjaman_id = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ComboBox_Edit_Peminjaman_status = New System.Windows.Forms.ComboBox()
        Me.Button_Peminjam_Exit = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ComboBox_Add_Peminjaman_status = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(223, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(370, 39)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "FORM PEMINJAMAN"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox_Add_Peminjaman_status)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.TextBox_Add_Peminjaman_penerbit)
        Me.GroupBox1.Controls.Add(Me.TextBox_Add_Peminjaman_penulis)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker_Add_Peminjaman_tanggalPengembalian)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker_Add_Peminjaman_tanggalPinjam)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ComboBox_Add_Peminjaman_namaPeminjam)
        Me.GroupBox1.Controls.Add(Me.ComboBox_Add_Peminjaman_idBuku)
        Me.GroupBox1.Controls.Add(Me.ComboBox_Add_Peminjaman_namaAdmin)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button_Add_Peminjaman_Add)
        Me.GroupBox1.Controls.Add(Me.Button_Add_Peminjaman_New)
        Me.GroupBox1.Controls.Add(Me.TextBox_Add_Peminjaman_id)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 351)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TAMBAH PEMINJAMAN"
        '
        'ComboBox_Add_Peminjaman_idBuku
        '
        Me.ComboBox_Add_Peminjaman_idBuku.FormattingEnabled = True
        Me.ComboBox_Add_Peminjaman_idBuku.Location = New System.Drawing.Point(135, 108)
        Me.ComboBox_Add_Peminjaman_idBuku.Name = "ComboBox_Add_Peminjaman_idBuku"
        Me.ComboBox_Add_Peminjaman_idBuku.Size = New System.Drawing.Size(212, 21)
        Me.ComboBox_Add_Peminjaman_idBuku.TabIndex = 22
        '
        'ComboBox_Add_Peminjaman_namaAdmin
        '
        Me.ComboBox_Add_Peminjaman_namaAdmin.FormattingEnabled = True
        Me.ComboBox_Add_Peminjaman_namaAdmin.Location = New System.Drawing.Point(135, 82)
        Me.ComboBox_Add_Peminjaman_namaAdmin.Name = "ComboBox_Add_Peminjaman_namaAdmin"
        Me.ComboBox_Add_Peminjaman_namaAdmin.Size = New System.Drawing.Size(212, 21)
        Me.ComboBox_Add_Peminjaman_namaAdmin.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "NAMA PENULIS"
        '
        'Button_Add_Peminjaman_Add
        '
        Me.Button_Add_Peminjaman_Add.Location = New System.Drawing.Point(272, 306)
        Me.Button_Add_Peminjaman_Add.Name = "Button_Add_Peminjaman_Add"
        Me.Button_Add_Peminjaman_Add.Size = New System.Drawing.Size(75, 23)
        Me.Button_Add_Peminjaman_Add.TabIndex = 15
        Me.Button_Add_Peminjaman_Add.Text = "TAMBAH"
        Me.Button_Add_Peminjaman_Add.UseVisualStyleBackColor = True
        '
        'Button_Add_Peminjaman_New
        '
        Me.Button_Add_Peminjaman_New.Location = New System.Drawing.Point(21, 306)
        Me.Button_Add_Peminjaman_New.Name = "Button_Add_Peminjaman_New"
        Me.Button_Add_Peminjaman_New.Size = New System.Drawing.Size(75, 23)
        Me.Button_Add_Peminjaman_New.TabIndex = 14
        Me.Button_Add_Peminjaman_New.Text = "BARU"
        Me.Button_Add_Peminjaman_New.UseVisualStyleBackColor = True
        '
        'TextBox_Add_Peminjaman_id
        '
        Me.TextBox_Add_Peminjaman_id.Location = New System.Drawing.Point(135, 32)
        Me.TextBox_Add_Peminjaman_id.Name = "TextBox_Add_Peminjaman_id"
        Me.TextBox_Add_Peminjaman_id.Size = New System.Drawing.Size(127, 20)
        Me.TextBox_Add_Peminjaman_id.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 211)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "TANGGAL PINJAM"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "ID BUKU"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "NAMA ADMIN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "NAMA PEMINJAM"
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
        'ComboBox_Add_Peminjaman_namaPeminjam
        '
        Me.ComboBox_Add_Peminjaman_namaPeminjam.FormattingEnabled = True
        Me.ComboBox_Add_Peminjaman_namaPeminjam.Location = New System.Drawing.Point(135, 57)
        Me.ComboBox_Add_Peminjaman_namaPeminjam.Name = "ComboBox_Add_Peminjaman_namaPeminjam"
        Me.ComboBox_Add_Peminjaman_namaPeminjam.Size = New System.Drawing.Size(212, 21)
        Me.ComboBox_Add_Peminjaman_namaPeminjam.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "TANGGAL PENGEMBALIAN"
        '
        'DateTimePicker_Add_Peminjaman_tanggalPinjam
        '
        Me.DateTimePicker_Add_Peminjaman_tanggalPinjam.Location = New System.Drawing.Point(169, 205)
        Me.DateTimePicker_Add_Peminjaman_tanggalPinjam.Name = "DateTimePicker_Add_Peminjaman_tanggalPinjam"
        Me.DateTimePicker_Add_Peminjaman_tanggalPinjam.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker_Add_Peminjaman_tanggalPinjam.TabIndex = 26
        '
        'DateTimePicker_Add_Peminjaman_tanggalPengembalian
        '
        Me.DateTimePicker_Add_Peminjaman_tanggalPengembalian.Location = New System.Drawing.Point(169, 231)
        Me.DateTimePicker_Add_Peminjaman_tanggalPengembalian.Name = "DateTimePicker_Add_Peminjaman_tanggalPengembalian"
        Me.DateTimePicker_Add_Peminjaman_tanggalPengembalian.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker_Add_Peminjaman_tanggalPengembalian.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "NAMA PENERBIT"
        '
        'TextBox_Add_Peminjaman_penulis
        '
        Me.TextBox_Add_Peminjaman_penulis.Location = New System.Drawing.Point(135, 135)
        Me.TextBox_Add_Peminjaman_penulis.Name = "TextBox_Add_Peminjaman_penulis"
        Me.TextBox_Add_Peminjaman_penulis.Size = New System.Drawing.Size(177, 20)
        Me.TextBox_Add_Peminjaman_penulis.TabIndex = 29
        '
        'TextBox_Add_Peminjaman_penerbit
        '
        Me.TextBox_Add_Peminjaman_penerbit.Location = New System.Drawing.Point(135, 161)
        Me.TextBox_Add_Peminjaman_penerbit.Name = "TextBox_Add_Peminjaman_penerbit"
        Me.TextBox_Add_Peminjaman_penerbit.Size = New System.Drawing.Size(177, 20)
        Me.TextBox_Add_Peminjaman_penerbit.TabIndex = 30
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox_Edit_Peminjaman_status)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.TextBox_Edit_Peminjaman_penerbit)
        Me.GroupBox2.Controls.Add(Me.TextBox_Edit_Peminjaman_penulis)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker_Edit_Peminjaman_tanggalPengembalian)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker_Edit_Peminjaman_tanggalPinjam)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.ComboBox_Edit_Peminjaman_namaPeminjam)
        Me.GroupBox2.Controls.Add(Me.ComboBox_Edit_Peminjaman_idBuku)
        Me.GroupBox2.Controls.Add(Me.ComboBox_Edit_Peminjaman_namaAdmin)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Button_Edit_Peminjaman_Update)
        Me.GroupBox2.Controls.Add(Me.Button_Edit_Peminjaman_New)
        Me.GroupBox2.Controls.Add(Me.TextBox_Edit_Peminjaman_id)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Location = New System.Drawing.Point(405, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(387, 351)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TAMBAH PEMINJAMAN"
        '
        'TextBox_Edit_Peminjaman_penerbit
        '
        Me.TextBox_Edit_Peminjaman_penerbit.Location = New System.Drawing.Point(135, 161)
        Me.TextBox_Edit_Peminjaman_penerbit.Name = "TextBox_Edit_Peminjaman_penerbit"
        Me.TextBox_Edit_Peminjaman_penerbit.Size = New System.Drawing.Size(177, 20)
        Me.TextBox_Edit_Peminjaman_penerbit.TabIndex = 30
        '
        'TextBox_Edit_Peminjaman_penulis
        '
        Me.TextBox_Edit_Peminjaman_penulis.Location = New System.Drawing.Point(135, 135)
        Me.TextBox_Edit_Peminjaman_penulis.Name = "TextBox_Edit_Peminjaman_penulis"
        Me.TextBox_Edit_Peminjaman_penulis.Size = New System.Drawing.Size(177, 20)
        Me.TextBox_Edit_Peminjaman_penulis.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "NAMA PENERBIT"
        '
        'DateTimePicker_Edit_Peminjaman_tanggalPengembalian
        '
        Me.DateTimePicker_Edit_Peminjaman_tanggalPengembalian.Location = New System.Drawing.Point(169, 231)
        Me.DateTimePicker_Edit_Peminjaman_tanggalPengembalian.Name = "DateTimePicker_Edit_Peminjaman_tanggalPengembalian"
        Me.DateTimePicker_Edit_Peminjaman_tanggalPengembalian.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker_Edit_Peminjaman_tanggalPengembalian.TabIndex = 27
        '
        'DateTimePicker_Edit_Peminjaman_tanggalPinjam
        '
        Me.DateTimePicker_Edit_Peminjaman_tanggalPinjam.Location = New System.Drawing.Point(169, 205)
        Me.DateTimePicker_Edit_Peminjaman_tanggalPinjam.Name = "DateTimePicker_Edit_Peminjaman_tanggalPinjam"
        Me.DateTimePicker_Edit_Peminjaman_tanggalPinjam.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker_Edit_Peminjaman_tanggalPinjam.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 237)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(145, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "TANGGAL PENGEMBALIAN"
        '
        'ComboBox_Edit_Peminjaman_namaPeminjam
        '
        Me.ComboBox_Edit_Peminjaman_namaPeminjam.FormattingEnabled = True
        Me.ComboBox_Edit_Peminjaman_namaPeminjam.Location = New System.Drawing.Point(135, 57)
        Me.ComboBox_Edit_Peminjaman_namaPeminjam.Name = "ComboBox_Edit_Peminjaman_namaPeminjam"
        Me.ComboBox_Edit_Peminjaman_namaPeminjam.Size = New System.Drawing.Size(212, 21)
        Me.ComboBox_Edit_Peminjaman_namaPeminjam.TabIndex = 23
        '
        'ComboBox_Edit_Peminjaman_idBuku
        '
        Me.ComboBox_Edit_Peminjaman_idBuku.FormattingEnabled = True
        Me.ComboBox_Edit_Peminjaman_idBuku.Location = New System.Drawing.Point(135, 108)
        Me.ComboBox_Edit_Peminjaman_idBuku.Name = "ComboBox_Edit_Peminjaman_idBuku"
        Me.ComboBox_Edit_Peminjaman_idBuku.Size = New System.Drawing.Size(212, 21)
        Me.ComboBox_Edit_Peminjaman_idBuku.TabIndex = 22
        '
        'ComboBox_Edit_Peminjaman_namaAdmin
        '
        Me.ComboBox_Edit_Peminjaman_namaAdmin.FormattingEnabled = True
        Me.ComboBox_Edit_Peminjaman_namaAdmin.Location = New System.Drawing.Point(135, 82)
        Me.ComboBox_Edit_Peminjaman_namaAdmin.Name = "ComboBox_Edit_Peminjaman_namaAdmin"
        Me.ComboBox_Edit_Peminjaman_namaAdmin.Size = New System.Drawing.Size(212, 21)
        Me.ComboBox_Edit_Peminjaman_namaAdmin.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 138)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "NAMA PENULIS"
        '
        'Button_Edit_Peminjaman_Update
        '
        Me.Button_Edit_Peminjaman_Update.Location = New System.Drawing.Point(272, 306)
        Me.Button_Edit_Peminjaman_Update.Name = "Button_Edit_Peminjaman_Update"
        Me.Button_Edit_Peminjaman_Update.Size = New System.Drawing.Size(75, 23)
        Me.Button_Edit_Peminjaman_Update.TabIndex = 15
        Me.Button_Edit_Peminjaman_Update.Text = "UPDATE"
        Me.Button_Edit_Peminjaman_Update.UseVisualStyleBackColor = True
        '
        'Button_Edit_Peminjaman_New
        '
        Me.Button_Edit_Peminjaman_New.Location = New System.Drawing.Point(21, 306)
        Me.Button_Edit_Peminjaman_New.Name = "Button_Edit_Peminjaman_New"
        Me.Button_Edit_Peminjaman_New.Size = New System.Drawing.Size(75, 23)
        Me.Button_Edit_Peminjaman_New.TabIndex = 14
        Me.Button_Edit_Peminjaman_New.Text = "BARU"
        Me.Button_Edit_Peminjaman_New.UseVisualStyleBackColor = True
        '
        'TextBox_Edit_Peminjaman_id
        '
        Me.TextBox_Edit_Peminjaman_id.Location = New System.Drawing.Point(135, 32)
        Me.TextBox_Edit_Peminjaman_id.Name = "TextBox_Edit_Peminjaman_id"
        Me.TextBox_Edit_Peminjaman_id.Size = New System.Drawing.Size(127, 20)
        Me.TextBox_Edit_Peminjaman_id.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 211)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "TANGGAL PINJAM"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(18, 112)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 13)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "ID BUKU"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(18, 85)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 13)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "NAMA ADMIN"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(18, 60)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "NAMA PEMINJAM"
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
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(19, 269)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(50, 13)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "STATUS"
        '
        'ComboBox_Edit_Peminjaman_status
        '
        Me.ComboBox_Edit_Peminjaman_status.FormattingEnabled = True
        Me.ComboBox_Edit_Peminjaman_status.Location = New System.Drawing.Point(135, 266)
        Me.ComboBox_Edit_Peminjaman_status.Name = "ComboBox_Edit_Peminjaman_status"
        Me.ComboBox_Edit_Peminjaman_status.Size = New System.Drawing.Size(127, 21)
        Me.ComboBox_Edit_Peminjaman_status.TabIndex = 32
        '
        'Button_Peminjam_Exit
        '
        Me.Button_Peminjam_Exit.Location = New System.Drawing.Point(366, 429)
        Me.Button_Peminjam_Exit.Name = "Button_Peminjam_Exit"
        Me.Button_Peminjam_Exit.Size = New System.Drawing.Size(75, 23)
        Me.Button_Peminjam_Exit.TabIndex = 32
        Me.Button_Peminjam_Exit.Text = "EXIT"
        Me.Button_Peminjam_Exit.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(19, 269)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(50, 13)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "STATUS"
        '
        'ComboBox_Add_Peminjaman_status
        '
        Me.ComboBox_Add_Peminjaman_status.FormattingEnabled = True
        Me.ComboBox_Add_Peminjaman_status.Location = New System.Drawing.Point(135, 266)
        Me.ComboBox_Add_Peminjaman_status.Name = "ComboBox_Add_Peminjaman_status"
        Me.ComboBox_Add_Peminjaman_status.Size = New System.Drawing.Size(127, 21)
        Me.ComboBox_Add_Peminjaman_status.TabIndex = 33
        '
        'Form_Peminjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 475)
        Me.Controls.Add(Me.Button_Peminjam_Exit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Peminjaman"
        Me.Text = "FORM PEMINJAMAN"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox_Add_Peminjaman_penerbit As TextBox
    Friend WithEvents TextBox_Add_Peminjaman_penulis As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DateTimePicker_Add_Peminjaman_tanggalPengembalian As DateTimePicker
    Friend WithEvents DateTimePicker_Add_Peminjaman_tanggalPinjam As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox_Add_Peminjaman_namaPeminjam As ComboBox
    Friend WithEvents ComboBox_Add_Peminjaman_idBuku As ComboBox
    Friend WithEvents ComboBox_Add_Peminjaman_namaAdmin As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button_Add_Peminjaman_Add As Button
    Friend WithEvents Button_Add_Peminjaman_New As Button
    Friend WithEvents TextBox_Add_Peminjaman_id As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox_Edit_Peminjaman_status As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBox_Edit_Peminjaman_penerbit As TextBox
    Friend WithEvents TextBox_Edit_Peminjaman_penulis As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DateTimePicker_Edit_Peminjaman_tanggalPengembalian As DateTimePicker
    Friend WithEvents DateTimePicker_Edit_Peminjaman_tanggalPinjam As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox_Edit_Peminjaman_namaPeminjam As ComboBox
    Friend WithEvents ComboBox_Edit_Peminjaman_idBuku As ComboBox
    Friend WithEvents ComboBox_Edit_Peminjaman_namaAdmin As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Button_Edit_Peminjaman_Update As Button
    Friend WithEvents Button_Edit_Peminjaman_New As Button
    Friend WithEvents TextBox_Edit_Peminjaman_id As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Button_Peminjam_Exit As Button
    Friend WithEvents ComboBox_Add_Peminjaman_status As ComboBox
    Friend WithEvents Label19 As Label
End Class
