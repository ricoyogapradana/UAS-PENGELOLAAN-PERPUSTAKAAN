Imports System.Data.Odbc
Public Class Form_Penulis
    Dim con As OdbcConnection
    Dim dr As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable
    Dim cmd As OdbcCommand
    Sub koneksi()
        con = New OdbcConnection
        con.ConnectionString = "dsn=db_perpustakaan"
        con.Open()
    End Sub

    Sub tampilPenulis()
        cmd = New OdbcCommand("select id_Penulis from tbl_Penulis", con)
        dr = cmd.ExecuteReader
        ComboBox_Edit_Penulis_id.Items.Clear()
        Do While dr.Read
            ComboBox_Edit_Penulis_id.Items.Add(dr.Item("id_Penulis"))
        Loop
    End Sub

    Private Sub Form_Penulis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilPenulis()
    End Sub
    'Tambah'
    Sub tambah()
        If TextBox_Add_Penulis_nama.Text = "" Or TextBox_Add_Penulis_tempatLahir.Text = "" Or DateTimePicker_Add_Penulis_tanggalLahir.Text = "" Or TextBox_Add_Penulis_noHp.Text = "" Or ComboBox_Add_Penulis_status.Text = "" Then
            MsgBox("Tolong isi semua form yang telah disediakan")
        Else
            koneksi()
            cmd = New OdbcCommand("select * from tbl_Penulis where id_Penulis='" & TextBox_Add_Penulis_id.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                MsgBox("Data Penulis gagal disimpan (ID Sudah Pernah diinput)")
            Else
                koneksi()
                Dim sql As String = "insert into tbl_Penulis values('" & TextBox_Add_Penulis_id.Text & "', '" & TextBox_Add_Penulis_nama.Text & "','" & TextBox_Add_Penulis_tempatLahir.Text & "', '" & DateTimePicker_Add_Penulis_tanggalLahir.Text & "', '" & TextBox_Add_Penulis_noHp.Text & "' , '" & ComboBox_Add_Penulis_status.Text & "')"
                cmd = New OdbcCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
            End If
        End If
    End Sub

    Private Sub Button_Add_Penulis_Add_Click(sender As Object, e As EventArgs) Handles Button_Add_Penulis_Add.Click
        tambah()
    End Sub

    Private Sub Button_Add_Penulis_New_Click(sender As Object, e As EventArgs) Handles Button_Add_Penulis_New.Click
        TextBox_Add_Penulis_id.Text = ""
        TextBox_Add_Penulis_nama.Text = ""
        TextBox_Add_Penulis_tempatLahir.Text = ""
        DateTimePicker_Add_Penulis_tanggalLahir.Text = ""
        TextBox_Add_Penulis_noHp.Text = ""
        ComboBox_Add_Penulis_status.Text = ""
        TextBox_Add_Penulis_id.Focus()
    End Sub

    'Delete'
    Sub delete()
        koneksi()
        Dim delete As String = "delete  from tbl_Penulis WHERE id_Penulis = '" & ComboBox_Edit_Penulis_id.Text & "'"
        cmd = New OdbcCommand(delete, con)
        cmd.ExecuteNonQuery()
        MsgBox("Menghapus data BERHASIL", vbInformation, "INFORMASI")
    End Sub

    'Edit'
    Sub edit()
        koneksi()
        Dim update As String = "update tbl_Penulis set nama_Penulis ='" & TextBox_Edit_Penulis_nama.Text & "', tempat_lahir = '" & TextBox_Edit_Penulis_tempatLahir.Text & "', tanggal_lahir = '" & DateTimePicker_Edit_Penulis_tanggalLahir.Text & "', no_hp = '" & TextBox_Edit_Penulis_noHp.Text & "' , status = '" & ComboBox_Edit_Penulis_status.Text & "' WHERE id_Penulis = '" & ComboBox_Edit_Penulis_id.Text & "'"
        cmd = New OdbcCommand(update, con)
        cmd.ExecuteNonQuery()
        MsgBox("Update data BERHASIL", vbInformation, "INFORMASI")
    End Sub

    Private Sub ComboBox_Edit_Penulis_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Edit_Penulis_id.SelectedIndexChanged
        cmd = New OdbcCommand("select * from tbl_Penulis where id_Penulis='" & ComboBox_Edit_Penulis_id.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            TextBox_Edit_Penulis_nama.Text = dr.Item("nama_Penulis")
            TextBox_Edit_Penulis_tempatLahir.Text = dr.Item("tempat_lahir")
            DateTimePicker_Edit_Penulis_tanggalLahir.Text = dr.Item("tanggal_lahir")
            TextBox_Edit_Penulis_noHp.Text = dr.Item("no_hp")
            ComboBox_Edit_Penulis_status.Text = dr.Item("status")
        Else
            MsgBox("ID tidak ada")
        End If
    End Sub



    Private Sub Button_Edit_Penulis_New_Click(sender As Object, e As EventArgs) Handles Button_Edit_Penulis_New.Click
        ComboBox_Edit_Penulis_id.Text = ""
        TextBox_Edit_Penulis_nama.Text = ""
        TextBox_Edit_Penulis_tempatLahir.Text = ""
        DateTimePicker_Edit_Penulis_tanggalLahir.Text = ""
        TextBox_Edit_Penulis_noHp.Text = ""
        ComboBox_Edit_Penulis_status.Text = ""
    End Sub

    Private Sub Button_Edit_Penulis_Update_Click(sender As Object, e As EventArgs) Handles Button_Edit_Penulis_Update.Click
        edit()
    End Sub


    'Form Penulis'
    Private Sub Button_Penulis_Exit_Click(sender As Object, e As EventArgs) Handles Button_Penulis_Exit.Click
        Close()
    End Sub

    Private Sub Button_Edit_Penulis_Refresh_Click(sender As Object, e As EventArgs) Handles Button_Edit_Penulis_Refresh.Click
        tampilPenulis()
    End Sub

    Private Sub Button_Edit_Penulis_Delete_Click(sender As Object, e As EventArgs) Handles Button_Edit_Penulis_Delete.Click
        delete()
    End Sub
End Class
