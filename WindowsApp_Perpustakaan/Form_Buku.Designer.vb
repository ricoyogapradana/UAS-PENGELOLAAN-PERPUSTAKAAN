<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Buku
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
        Me.ComboBox_Add_Buku_penerbit = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Add_Buku_penulis = New System.Windows.Forms.ComboBox()
        Me.TextBox_Add_Buku_tahunTerbit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox_Add_Buku_status = New System.Windows.Forms.ComboBox()
        Me.Button_Add_Buku_Add = New System.Windows.Forms.Button()
        Me.TextBox_Add_Buku_nama = New System.Windows.Forms.TextBox()
        Me.TextBox_Add_Buku_id = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox_Edit_Buku_id = New System.Windows.Forms.ComboBox()
        Me.Button_Edit_Buku_Delete = New System.Windows.Forms.Button()
        Me.ComboBox_Edit_Buku_penerbit = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Edit_Buku_penulis = New System.Windows.Forms.ComboBox()
        Me.TextBox_Edit_Buku_tahunTerbit = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox_Edit_Buku_status = New System.Windows.Forms.ComboBox()
        Me.Button_Edit_Buku_Update = New System.Windows.Forms.Button()
        Me.TextBox_Edit_Buku_nama = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button_Buku_Exit = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView_DataBuku = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView_DataBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(275, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 39)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "FORM BUKU"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox_Add_Buku_penerbit)
        Me.GroupBox1.Controls.Add(Me.ComboBox_Add_Buku_penulis)
        Me.GroupBox1.Controls.Add(Me.TextBox_Add_Buku_tahunTerbit)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBox_Add_Buku_status)
        Me.GroupBox1.Controls.Add(Me.Button_Add_Buku_Add)
        Me.GroupBox1.Controls.Add(Me.TextBox_Add_Buku_nama)
        Me.GroupBox1.Controls.Add(Me.TextBox_Add_Buku_id)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 281)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TAMBAH BUKU"
        '
        'ComboBox_Add_Buku_penerbit
        '
        Me.ComboBox_Add_Buku_penerbit.FormattingEnabled = True
        Me.ComboBox_Add_Buku_penerbit.Location = New System.Drawing.Point(135, 108)
        Me.ComboBox_Add_Buku_penerbit.Name = "ComboBox_Add_Buku_penerbit"
        Me.ComboBox_Add_Buku_penerbit.Size = New System.Drawing.Size(117, 21)
        Me.ComboBox_Add_Buku_penerbit.TabIndex = 22
        '
        'ComboBox_Add_Buku_penulis
        '
        Me.ComboBox_Add_Buku_penulis.FormattingEnabled = True
        Me.ComboBox_Add_Buku_penulis.Location = New System.Drawing.Point(135, 82)
        Me.ComboBox_Add_Buku_penulis.Name = "ComboBox_Add_Buku_penulis"
        Me.ComboBox_Add_Buku_penulis.Size = New System.Drawing.Size(117, 21)
        Me.ComboBox_Add_Buku_penulis.TabIndex = 21
        '
        'TextBox_Add_Buku_tahunTerbit
        '
        Me.TextBox_Add_Buku_tahunTerbit.Location = New System.Drawing.Point(135, 135)
        Me.TextBox_Add_Buku_tahunTerbit.Name = "TextBox_Add_Buku_tahunTerbit"
        Me.TextBox_Add_Buku_tahunTerbit.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Add_Buku_tahunTerbit.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "TAHUN TERBIT"
        '
        'ComboBox_Add_Buku_status
        '
        Me.ComboBox_Add_Buku_status.FormattingEnabled = True
        Me.ComboBox_Add_Buku_status.Items.AddRange(New Object() {"PEMBELAJARAN", "EKONOMI", "PERTANIAN", "KEHUTANAN", "TEKNOLOGI"})
        Me.ComboBox_Add_Buku_status.Location = New System.Drawing.Point(135, 161)
        Me.ComboBox_Add_Buku_status.Name = "ComboBox_Add_Buku_status"
        Me.ComboBox_Add_Buku_status.Size = New System.Drawing.Size(117, 21)
        Me.ComboBox_Add_Buku_status.TabIndex = 18
        '
        'Button_Add_Buku_Add
        '
        Me.Button_Add_Buku_Add.Location = New System.Drawing.Point(272, 209)
        Me.Button_Add_Buku_Add.Name = "Button_Add_Buku_Add"
        Me.Button_Add_Buku_Add.Size = New System.Drawing.Size(75, 23)
        Me.Button_Add_Buku_Add.TabIndex = 15
        Me.Button_Add_Buku_Add.Text = "TAMBAH"
        Me.Button_Add_Buku_Add.UseVisualStyleBackColor = True
        '
        'TextBox_Add_Buku_nama
        '
        Me.TextBox_Add_Buku_nama.Location = New System.Drawing.Point(135, 57)
        Me.TextBox_Add_Buku_nama.Name = "TextBox_Add_Buku_nama"
        Me.TextBox_Add_Buku_nama.Size = New System.Drawing.Size(212, 20)
        Me.TextBox_Add_Buku_nama.TabIndex = 9
        '
        'TextBox_Add_Buku_id
        '
        Me.TextBox_Add_Buku_id.Location = New System.Drawing.Point(135, 32)
        Me.TextBox_Add_Buku_id.Name = "TextBox_Add_Buku_id"
        Me.TextBox_Add_Buku_id.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Add_Buku_id.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "TEMA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "PENERBIT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "PENULIS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "NAMA"
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
        Me.GroupBox2.Controls.Add(Me.ComboBox_Edit_Buku_id)
        Me.GroupBox2.Controls.Add(Me.Button_Edit_Buku_Delete)
        Me.GroupBox2.Controls.Add(Me.ComboBox_Edit_Buku_penerbit)
        Me.GroupBox2.Controls.Add(Me.ComboBox_Edit_Buku_penulis)
        Me.GroupBox2.Controls.Add(Me.TextBox_Edit_Buku_tahunTerbit)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.ComboBox_Edit_Buku_status)
        Me.GroupBox2.Controls.Add(Me.Button_Edit_Buku_Update)
        Me.GroupBox2.Controls.Add(Me.TextBox_Edit_Buku_nama)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(405, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(387, 281)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "EDIT BUKU"
        '
        'ComboBox_Edit_Buku_id
        '
        Me.ComboBox_Edit_Buku_id.FormattingEnabled = True
        Me.ComboBox_Edit_Buku_id.Location = New System.Drawing.Point(135, 32)
        Me.ComboBox_Edit_Buku_id.Name = "ComboBox_Edit_Buku_id"
        Me.ComboBox_Edit_Buku_id.Size = New System.Drawing.Size(117, 21)
        Me.ComboBox_Edit_Buku_id.TabIndex = 31
        '
        'Button_Edit_Buku_Delete
        '
        Me.Button_Edit_Buku_Delete.Location = New System.Drawing.Point(191, 209)
        Me.Button_Edit_Buku_Delete.Name = "Button_Edit_Buku_Delete"
        Me.Button_Edit_Buku_Delete.Size = New System.Drawing.Size(75, 23)
        Me.Button_Edit_Buku_Delete.TabIndex = 29
        Me.Button_Edit_Buku_Delete.Text = "DELETE"
        Me.Button_Edit_Buku_Delete.UseVisualStyleBackColor = True
        '
        'ComboBox_Edit_Buku_penerbit
        '
        Me.ComboBox_Edit_Buku_penerbit.FormattingEnabled = True
        Me.ComboBox_Edit_Buku_penerbit.Location = New System.Drawing.Point(135, 108)
        Me.ComboBox_Edit_Buku_penerbit.Name = "ComboBox_Edit_Buku_penerbit"
        Me.ComboBox_Edit_Buku_penerbit.Size = New System.Drawing.Size(117, 21)
        Me.ComboBox_Edit_Buku_penerbit.TabIndex = 22
        '
        'ComboBox_Edit_Buku_penulis
        '
        Me.ComboBox_Edit_Buku_penulis.FormattingEnabled = True
        Me.ComboBox_Edit_Buku_penulis.Location = New System.Drawing.Point(135, 82)
        Me.ComboBox_Edit_Buku_penulis.Name = "ComboBox_Edit_Buku_penulis"
        Me.ComboBox_Edit_Buku_penulis.Size = New System.Drawing.Size(117, 21)
        Me.ComboBox_Edit_Buku_penulis.TabIndex = 21
        '
        'TextBox_Edit_Buku_tahunTerbit
        '
        Me.TextBox_Edit_Buku_tahunTerbit.Location = New System.Drawing.Point(135, 135)
        Me.TextBox_Edit_Buku_tahunTerbit.Name = "TextBox_Edit_Buku_tahunTerbit"
        Me.TextBox_Edit_Buku_tahunTerbit.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Edit_Buku_tahunTerbit.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "TAHUN TERBIT"
        '
        'ComboBox_Edit_Buku_status
        '
        Me.ComboBox_Edit_Buku_status.FormattingEnabled = True
        Me.ComboBox_Edit_Buku_status.Items.AddRange(New Object() {"PEMBELAJARAN", "EKONOMI", "PERTANIAN", "KEHUTANAN", "TEKNOLOGI"})
        Me.ComboBox_Edit_Buku_status.Location = New System.Drawing.Point(135, 161)
        Me.ComboBox_Edit_Buku_status.Name = "ComboBox_Edit_Buku_status"
        Me.ComboBox_Edit_Buku_status.Size = New System.Drawing.Size(117, 21)
        Me.ComboBox_Edit_Buku_status.TabIndex = 18
        '
        'Button_Edit_Buku_Update
        '
        Me.Button_Edit_Buku_Update.Location = New System.Drawing.Point(272, 209)
        Me.Button_Edit_Buku_Update.Name = "Button_Edit_Buku_Update"
        Me.Button_Edit_Buku_Update.Size = New System.Drawing.Size(75, 23)
        Me.Button_Edit_Buku_Update.TabIndex = 15
        Me.Button_Edit_Buku_Update.Text = "UPDATE"
        Me.Button_Edit_Buku_Update.UseVisualStyleBackColor = True
        '
        'TextBox_Edit_Buku_nama
        '
        Me.TextBox_Edit_Buku_nama.Location = New System.Drawing.Point(135, 57)
        Me.TextBox_Edit_Buku_nama.Name = "TextBox_Edit_Buku_nama"
        Me.TextBox_Edit_Buku_nama.Size = New System.Drawing.Size(212, 20)
        Me.TextBox_Edit_Buku_nama.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "TEMA"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 112)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "PENERBIT"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 85)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "PENULIS"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "NAMA"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(18, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "ID"
        '
        'Button_Buku_Exit
        '
        Me.Button_Buku_Exit.Location = New System.Drawing.Point(713, 586)
        Me.Button_Buku_Exit.Name = "Button_Buku_Exit"
        Me.Button_Buku_Exit.Size = New System.Drawing.Size(75, 23)
        Me.Button_Buku_Exit.TabIndex = 24
        Me.Button_Buku_Exit.Text = "EXIT"
        Me.Button_Buku_Exit.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView_DataBuku)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 363)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(780, 217)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DATA BUKU"
        '
        'DataGridView_DataBuku
        '
        Me.DataGridView_DataBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_DataBuku.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView_DataBuku.Location = New System.Drawing.Point(12, 19)
        Me.DataGridView_DataBuku.Name = "DataGridView_DataBuku"
        Me.DataGridView_DataBuku.Size = New System.Drawing.Size(747, 177)
        Me.DataGridView_DataBuku.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "NAMA"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "PENULIS"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "PENERBIT"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "TAHUN TERBIT"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "TEMA"
        Me.Column6.Name = "Column6"
        '
        'Form_Buku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 626)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button_Buku_Exit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Buku"
        Me.Text = "FORM BUKU"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView_DataBuku, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox_Add_Buku_status As ComboBox
    Friend WithEvents Button_Add_Buku_Add As Button
    Friend WithEvents TextBox_Add_Buku_nama As TextBox
    Friend WithEvents TextBox_Add_Buku_id As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_Add_Buku_tahunTerbit As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox_Add_Buku_penerbit As ComboBox
    Friend WithEvents ComboBox_Add_Buku_penulis As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox_Edit_Buku_penerbit As ComboBox
    Friend WithEvents ComboBox_Edit_Buku_penulis As ComboBox
    Friend WithEvents TextBox_Edit_Buku_tahunTerbit As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox_Edit_Buku_status As ComboBox
    Friend WithEvents Button_Edit_Buku_Update As Button
    Friend WithEvents TextBox_Edit_Buku_nama As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Button_Buku_Exit As Button
    Friend WithEvents Button_Edit_Buku_Delete As Button
    Friend WithEvents ComboBox_Edit_Buku_id As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridView_DataBuku As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
