Imports System.Data.Odbc
Public Class Form_Anggota
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

    Sub tampilAnggota()
        cmd = New OdbcCommand("select id_anggota from tbl_anggota", con)
        dr = cmd.ExecuteReader
        ComboBox_Edit_Anggota_id.Items.Clear()
        Do While dr.Read
            ComboBox_Edit_Anggota_id.Items.Add(dr.Item("id_anggota"))
        Loop
    End Sub

    Private Sub Form_Anggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilAnggota()
        generateTahun()
    End Sub

    'Tambah'
    Sub tambah()
        If TextBox_Add_Anggota_id.Text = "" Or TextBox_Add_Anggota_username.Text = "" Or TextBox_Add_Anggota_nama.Text = "" Or TextBox_Add_Anggota_tempatLahir.Text = "" Or DateTimePicker_Add_Anggota_tanggalLahir.Text = "" Or TextBox_Add_Anggota_noHp.Text = "" Or TextBox_Add_Anggota_bergabung.Text = "" Or ComboBox_Add_Anggota_status.Text = "" Then
            MsgBox("Tolong isi semua form yang telah disediakan")
        Else
            koneksi()
            cmd = New OdbcCommand("select * from tbl_anggota where id_anggota='" & TextBox_Add_Anggota_id.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                MsgBox("Data Anggota gagal disimpan (ID Sudah Pernah diinput)")
            Else
                koneksi()
                Dim sql As String = "insert into tbl_anggota values('" & TextBox_Add_Anggota_id.Text & "','" & TextBox_Add_Anggota_username.Text & "','" & TextBox_Add_Anggota_nama.Text & "','" & TextBox_Add_Anggota_tempatLahir.Text & "', '" & DateTimePicker_Add_Anggota_tanggalLahir.Text & "', '" & TextBox_Add_Anggota_noHp.Text & "' , '" & TextBox_Add_Anggota_bergabung.Text & "', '" & ComboBox_Add_Anggota_status.Text & "')"
                cmd = New OdbcCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
            End If
        End If
    End Sub

    Private Sub Button_Add_Anggota_Add_Click(sender As Object, e As EventArgs) Handles Button_Add_Anggota_Add.Click
        tambah()
    End Sub

    Private Sub Button_Add_Anggota_New_Click(sender As Object, e As EventArgs) Handles Button_Add_Anggota_New.Click
        TextBox_Add_Anggota_id.Text = ""
        TextBox_Add_Anggota_username.Text = ""
        TextBox_Add_Anggota_nama.Text = ""
        TextBox_Add_Anggota_tempatLahir.Text = ""
        DateTimePicker_Add_Anggota_tanggalLahir.Text = ""
        TextBox_Add_Anggota_noHp.Text = ""
        TextBox_Add_Anggota_bergabung.Text = ""
        ComboBox_Add_Anggota_status.Text = ""
        TextBox_Add_Anggota_id.Focus()
    End Sub

    'Edit'
    Sub edit()
        koneksi()
        Dim update As String = "update tbl_anggota set username = '" & TextBox_Edit_Anggota_username.Text & "', nama_anggota ='" & TextBox_Edit_Anggota_nama.Text & "', tempat_lahir = '" & TextBox_Edit_Anggota_tempatLahir.Text & "', tanggal_lahir = '" & DateTimePicker_Edit_Anggota_tanggalLahir.Text & "', no_hp = '" & TextBox_Edit_Anggota_noHp.Text & "' , tahun_bergabung = '" & TextBox_Edit_Anggota_bergabung.Text & "', status = '" & ComboBox_Edit_Anggota_status.Text & "' WHERE id_anggota = '" & ComboBox_Edit_Anggota_id.Text & "'"
        cmd = New OdbcCommand(update, con)
        cmd.ExecuteNonQuery()
        MsgBox("Update data BERHASIL", vbInformation, "INFORMASI")
    End Sub

    'Delete'
    Sub delete()
        koneksi()
        Dim delete As String = "delete  from tbl_anggota WHERE id_anggota = '" & ComboBox_Edit_Anggota_id.Text & "'"
        cmd = New OdbcCommand(delete, con)
        cmd.ExecuteNonQuery()
        MsgBox("Menghapus data BERHASIL", vbInformation, "INFORMASI")
    End Sub

    Private Sub ComboBox_Edit_Anggota_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Edit_Anggota_id.SelectedIndexChanged
        cmd = New OdbcCommand("select * from tbl_anggota where id_anggota='" & ComboBox_Edit_Anggota_id.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            TextBox_Edit_Anggota_username.Text = dr.Item("username")
            TextBox_Edit_Anggota_nama.Text = dr.Item("nama_anggota")
            TextBox_Edit_Anggota_tempatLahir.Text = dr.Item("tempat_lahir")
            DateTimePicker_Edit_Anggota_tanggalLahir.Text = dr.Item("tanggal_lahir")
            TextBox_Edit_Anggota_noHp.Text = dr.Item("no_hp")
            TextBox_Edit_Anggota_bergabung.Text = dr.Item("tahun_bergabung")
            ComboBox_Edit_Anggota_status.Text = dr.Item("status")
        Else
            MsgBox("ID tidak ada")
        End If
    End Sub

    Sub generateTahun()
        Dim tahun As String = Date.Now.Year
        TextBox_Add_Anggota_bergabung.Text = tahun
    End Sub
    Private Sub Button_Edit_Anggota_New_Click(sender As Object, e As EventArgs) Handles Button_Edit_Anggota_New.Click
        ComboBox_Edit_Anggota_id.Text = ""
        TextBox_Edit_Anggota_username.Text = ""
        TextBox_Edit_Anggota_username.Text = ""
        TextBox_Edit_Anggota_nama.Text = ""
        TextBox_Edit_Anggota_tempatLahir.Text = ""
        DateTimePicker_Edit_Anggota_tanggalLahir.Text = ""
        TextBox_Edit_Anggota_noHp.Text = ""
        TextBox_Edit_Anggota_bergabung.Text = ""
        ComboBox_Edit_Anggota_status.Text = ""
    End Sub

    Private Sub Button_Edit_Anggota_Update_Click(sender As Object, e As EventArgs) Handles Button_Edit_Anggota_Update.Click
        edit()
    End Sub


    'Form Anggota'
    Private Sub Button_Anggota_Exit_Click(sender As Object, e As EventArgs) Handles Button_Anggota_Exit.Click
        Close()
    End Sub

    Private Sub Button_Edit_Anggota_Refresh_Click(sender As Object, e As EventArgs) Handles Button_Edit_Anggota_Refresh.Click
        tampilAnggota()
    End Sub

    Private Sub Button_Edit_Anggota_Delete_Click(sender As Object, e As EventArgs) Handles Button_Edit_Anggota_Delete.Click
        delete()
    End Sub
End Class