<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Penerbit
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
        Me.ComboBox_Add_Penerbit_status = New System.Windows.Forms.ComboBox()
        Me.Button_Add_Penerbit_Add = New System.Windows.Forms.Button()
        Me.TextBox_Add_Penerbit_noHp = New System.Windows.Forms.TextBox()
        Me.TextBox_Add_Penerbit_tahunBerdiri = New System.Windows.Forms.TextBox()
        Me.TextBox_Add_Penerbit_nama = New System.Windows.Forms.TextBox()
        Me.TextBox_Add_Penerbit_id = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button_Edit_Penerbit_Delete = New System.Windows.Forms.Button()
        Me.ComboBox_Edit_Penerbit_id = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Edit_Penerbit_status = New System.Windows.Forms.ComboBox()
        Me.Button_Edit_Penerbit_Update = New System.Windows.Forms.Button()
        Me.TextBox_Edit_Penerbit_noHp = New System.Windows.Forms.TextBox()
        Me.TextBox_Edit_Penerbit_tahunBerdiri = New System.Windows.Forms.TextBox()
        Me.TextBox_Edit_Penerbit_nama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button_Penerbit_Exit = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView_DataPenerbit = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView_DataPenerbit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(227, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 39)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "FORM PENERBIT"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox_Add_Penerbit_status)
        Me.GroupBox1.Controls.Add(Me.Button_Add_Penerbit_Add)
        Me.GroupBox1.Controls.Add(Me.TextBox_Add_Penerbit_noHp)
        Me.GroupBox1.Controls.Add(Me.TextBox_Add_Penerbit_tahunBerdiri)
        Me.GroupBox1.Controls.Add(Me.TextBox_Add_Penerbit_nama)
        Me.GroupBox1.Controls.Add(Me.TextBox_Add_Penerbit_id)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 231)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TAMBAH PENERBIT"
        '
        'ComboBox_Add_Penerbit_status
        '
        Me.ComboBox_Add_Penerbit_status.FormattingEnabled = True
        Me.ComboBox_Add_Penerbit_status.Location = New System.Drawing.Point(135, 136)
        Me.ComboBox_Add_Penerbit_status.Name = "ComboBox_Add_Penerbit_status"
        Me.ComboBox_Add_Penerbit_status.Size = New System.Drawing.Size(117, 21)
        Me.ComboBox_Add_Penerbit_status.TabIndex = 18
        '
        'Button_Add_Penerbit_Add
        '
        Me.Button_Add_Penerbit_Add.Location = New System.Drawing.Point(283, 174)
        Me.Button_Add_Penerbit_Add.Name = "Button_Add_Penerbit_Add"
        Me.Button_Add_Penerbit_Add.Size = New System.Drawing.Size(75, 23)
        Me.Button_Add_Penerbit_Add.TabIndex = 15
        Me.Button_Add_Penerbit_Add.Text = "TAMBAH"
        Me.Button_Add_Penerbit_Add.UseVisualStyleBackColor = True
        '
        'TextBox_Add_Penerbit_noHp
        '
        Me.TextBox_Add_Penerbit_noHp.Location = New System.Drawing.Point(135, 109)
        Me.TextBox_Add_Penerbit_noHp.Name = "TextBox_Add_Penerbit_noHp"
        Me.TextBox_Add_Penerbit_noHp.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Add_Penerbit_noHp.TabIndex = 11
        '
        'TextBox_Add_Penerbit_tahunBerdiri
        '
        Me.TextBox_Add_Penerbit_tahunBerdiri.Location = New System.Drawing.Point(135, 82)
        Me.TextBox_Add_Penerbit_tahunBerdiri.Name = "TextBox_Add_Penerbit_tahunBerdiri"
        Me.TextBox_Add_Penerbit_tahunBerdiri.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Add_Penerbit_tahunBerdiri.TabIndex = 10
        '
        'TextBox_Add_Penerbit_nama
        '
        Me.TextBox_Add_Penerbit_nama.Location = New System.Drawing.Point(135, 57)
        Me.TextBox_Add_Penerbit_nama.Name = "TextBox_Add_Penerbit_nama"
        Me.TextBox_Add_Penerbit_nama.Size = New System.Drawing.Size(212, 20)
        Me.TextBox_Add_Penerbit_nama.TabIndex = 9
        '
        'TextBox_Add_Penerbit_id
        '
        Me.TextBox_Add_Penerbit_id.Location = New System.Drawing.Point(135, 32)
        Me.TextBox_Add_Penerbit_id.Name = "TextBox_Add_Penerbit_id"
        Me.TextBox_Add_Penerbit_id.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Add_Penerbit_id.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "STATUS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "NO HP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "TAHUN BERDIRI"
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
        Me.GroupBox2.Controls.Add(Me.Button_Edit_Penerbit_Delete)
        Me.GroupBox2.Controls.Add(Me.ComboBox_Edit_Penerbit_id)
        Me.GroupBox2.Controls.Add(Me.ComboBox_Edit_Penerbit_status)
        Me.GroupBox2.Controls.Add(Me.Button_Edit_Penerbit_Update)
        Me.GroupBox2.Controls.Add(Me.TextBox_Edit_Penerbit_noHp)
        Me.GroupBox2.Controls.Add(Me.TextBox_Edit_Penerbit_tahunBerdiri)
        Me.GroupBox2.Controls.Add(Me.TextBox_Edit_Penerbit_nama)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(405, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(387, 231)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "EDIT PENERBIT"
        '
        'Button_Edit_Penerbit_Delete
        '
        Me.Button_Edit_Penerbit_Delete.Location = New System.Drawing.Point(191, 174)
        Me.Button_Edit_Penerbit_Delete.Name = "Button_Edit_Penerbit_Delete"
        Me.Button_Edit_Penerbit_Delete.Size = New System.Drawing.Size(75, 23)
        Me.Button_Edit_Penerbit_Delete.TabIndex = 27
        Me.Button_Edit_Penerbit_Delete.Text = "DELETE"
        Me.Button_Edit_Penerbit_Delete.UseVisualStyleBackColor = True
        '
        'ComboBox_Edit_Penerbit_id
        '
        Me.ComboBox_Edit_Penerbit_id.FormattingEnabled = True
        Me.ComboBox_Edit_Penerbit_id.Location = New System.Drawing.Point(135, 32)
        Me.ComboBox_Edit_Penerbit_id.Name = "ComboBox_Edit_Penerbit_id"
        Me.ComboBox_Edit_Penerbit_id.Size = New System.Drawing.Size(117, 21)
        Me.ComboBox_Edit_Penerbit_id.TabIndex = 19
        '
        'ComboBox_Edit_Penerbit_status
        '
        Me.ComboBox_Edit_Penerbit_status.FormattingEnabled = True
        Me.ComboBox_Edit_Penerbit_status.Location = New System.Drawing.Point(135, 136)
        Me.ComboBox_Edit_Penerbit_status.Name = "ComboBox_Edit_Penerbit_status"
        Me.ComboBox_Edit_Penerbit_status.Size = New System.Drawing.Size(117, 21)
        Me.ComboBox_Edit_Penerbit_status.TabIndex = 18
        '
        'Button_Edit_Penerbit_Update
        '
        Me.Button_Edit_Penerbit_Update.Location = New System.Drawing.Point(283, 174)
        Me.Button_Edit_Penerbit_Update.Name = "Button_Edit_Penerbit_Update"
        Me.Button_Edit_Penerbit_Update.Size = New System.Drawing.Size(75, 23)
        Me.Button_Edit_Penerbit_Update.TabIndex = 15
        Me.Button_Edit_Penerbit_Update.Text = "UPDATE"
        Me.Button_Edit_Penerbit_Update.UseVisualStyleBackColor = True
        '
        'TextBox_Edit_Penerbit_noHp
        '
        Me.TextBox_Edit_Penerbit_noHp.Location = New System.Drawing.Point(135, 109)
        Me.TextBox_Edit_Penerbit_noHp.Name = "TextBox_Edit_Penerbit_noHp"
        Me.TextBox_Edit_Penerbit_noHp.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Edit_Penerbit_noHp.TabIndex = 11
        '
        'TextBox_Edit_Penerbit_tahunBerdiri
        '
        Me.TextBox_Edit_Penerbit_tahunBerdiri.Location = New System.Drawing.Point(135, 82)
        Me.TextBox_Edit_Penerbit_tahunBerdiri.Name = "TextBox_Edit_Penerbit_tahunBerdiri"
        Me.TextBox_Edit_Penerbit_tahunBerdiri.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Edit_Penerbit_tahunBerdiri.TabIndex = 10
        '
        'TextBox_Edit_Penerbit_nama
        '
        Me.TextBox_Edit_Penerbit_nama.Location = New System.Drawing.Point(135, 57)
        Me.TextBox_Edit_Penerbit_nama.Name = "TextBox_Edit_Penerbit_nama"
        Me.TextBox_Edit_Penerbit_nama.Size = New System.Drawing.Size(212, 20)
        Me.TextBox_Edit_Penerbit_nama.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "STATUS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "NO HP"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "TAHUN BERDIRI"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "NAMA"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "ID"
        '
        'Button_Penerbit_Exit
        '
        Me.Button_Penerbit_Exit.Location = New System.Drawing.Point(688, 528)
        Me.Button_Penerbit_Exit.Name = "Button_Penerbit_Exit"
        Me.Button_Penerbit_Exit.Size = New System.Drawing.Size(75, 23)
        Me.Button_Penerbit_Exit.TabIndex = 23
        Me.Button_Penerbit_Exit.Text = "EXIT"
        Me.Button_Penerbit_Exit.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView_DataPenerbit)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 305)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(780, 217)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DATA PENERBIT"
        '
        'DataGridView_DataPenerbit
        '
        Me.DataGridView_DataPenerbit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_DataPenerbit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView_DataPenerbit.Location = New System.Drawing.Point(12, 19)
        Me.DataGridView_DataPenerbit.Name = "DataGridView_DataPenerbit"
        Me.DataGridView_DataPenerbit.Size = New System.Drawing.Size(747, 177)
        Me.DataGridView_DataPenerbit.TabIndex = 0
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
        Me.Column3.HeaderText = "TAHUN BERDIRI"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "NO HP"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "STATUS"
        Me.Column5.Name = "Column5"
        '
        'Form_Penerbit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 571)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button_Penerbit_Exit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Penerbit"
        Me.Text = "FORM PENERBIT"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView_DataPenerbit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox_Add_Penerbit_status As ComboBox
    Friend WithEvents Button_Add_Penerbit_Add As Button
    Friend WithEvents TextBox_Add_Penerbit_noHp As TextBox
    Friend WithEvents TextBox_Add_Penerbit_tahunBerdiri As TextBox
    Friend WithEvents TextBox_Add_Penerbit_nama As TextBox
    Friend WithEvents TextBox_Add_Penerbit_id As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox_Edit_Penerbit_status As ComboBox
    Friend WithEvents Button_Edit_Penerbit_Update As Button
    Friend WithEvents TextBox_Edit_Penerbit_noHp As TextBox
    Friend WithEvents TextBox_Edit_Penerbit_tahunBerdiri As TextBox
    Friend WithEvents TextBox_Edit_Penerbit_nama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox_Edit_Penerbit_id As ComboBox
    Friend WithEvents Button_Penerbit_Exit As Button
    Friend WithEvents Button_Edit_Penerbit_Delete As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridView_DataPenerbit As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
