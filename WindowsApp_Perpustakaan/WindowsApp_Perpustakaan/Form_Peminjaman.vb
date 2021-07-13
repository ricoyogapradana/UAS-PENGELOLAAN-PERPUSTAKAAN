Imports System.Data.Odbc
Public Class Form_Peminjaman
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

    Sub tampilpeminjaman()
        cmd = New OdbcCommand("select id_peminjaman from tbl_peminjaman", con)
        dr = cmd.ExecuteReader
        ComboBox_Edit_peminjaman_id.Items.Clear()
        Do While dr.Read
            ComboBox_Edit_peminjaman_id.Items.Add(dr.Item("id_peminjaman"))
        Loop
    End Sub

    Sub tampilPeminjam()
        cmd = New OdbcCommand("select nama_anggota from tbl_anggota ", con)
        dr = cmd.ExecuteReader
        ComboBox_Add_Peminjaman_namaPeminjam.Items.Clear()
        Do While dr.Read
            ComboBox_Add_Peminjaman_namaPeminjam.Items.Add(dr.Item("nama_anggota"))
            ComboBox_Edit_Peminjaman_namaPeminjam.Items.Add(dr.Item("nama_anggota"))
        Loop
    End Sub


    Sub tampilAdmin()
        cmd = New OdbcCommand("select nama_admin from tbl_admin ", con)
        dr = cmd.ExecuteReader
        ComboBox_Add_Peminjaman_namaAdmin.Items.Clear()
        Do While dr.Read
            ComboBox_Add_Peminjaman_namaAdmin.Items.Add(dr.Item("nama_admin"))
            ComboBox_Edit_Peminjaman_namaAdmin.Items.Add(dr.Item("nama_admin"))
        Loop
    End Sub

    Sub tampilBuku()
        cmd = New OdbcCommand("select id_buku from tbl_buku ", con)
        dr = cmd.ExecuteReader
        ComboBox_Add_Peminjaman_idBuku.Items.Clear()
        Do While dr.Read
            ComboBox_Add_Peminjaman_idBuku.Items.Add(dr.Item("id_buku"))
            ComboBox_Edit_Peminjaman_idBuku.Items.Add(dr.Item("id_buku"))
        Loop
    End Sub

    Private Sub Form_peminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilpeminjaman()
        tampilPeminjam()
        tampilAdmin()
        tampilBuku()
    End Sub

    'Tambah'
    Sub tambah()
        If TextBox_Add_Peminjaman_id.Text = "" Or ComboBox_Add_Peminjaman_namaPeminjam.Text = "" Or ComboBox_Add_Peminjaman_namaAdmin.Text = "" Or ComboBox_Add_Peminjaman_idBuku.Text = "" Or TextBox_Add_Peminjaman_penulis.Text = "" Or TextBox_Add_Peminjaman_penerbit.Text = "" Or DateTimePicker_Add_Peminjaman_tanggalPinjam.Text = "" Or DateTimePicker_Add_Peminjaman_tanggalPengembalian.Text = "" Or ComboBox_Add_Peminjaman_status.Text = "" Then
            MsgBox("Tolong isi semua form yang telah disediakan")
        Else
            koneksi()
            cmd = New OdbcCommand("select * from tbl_peminjaman where id_peminjaman='" & TextBox_Add_Peminjaman_id.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                MsgBox("Data peminjaman gagal disimpan (ID Sudah Pernah diinput)")
            Else
                koneksi()
                Dim sql As String = "insert into tbl_peminjaman values('" & TextBox_Add_Peminjaman_id.Text & "', '" & ComboBox_Add_Peminjaman_namaPeminjam.Text & "','" & ComboBox_Add_Peminjaman_namaAdmin.Text & "', '" & ComboBox_Add_Peminjaman_idBuku.Text & "', '" & TextBox_Add_Peminjaman_penulis.Text & "' , '" & TextBox_Add_Peminjaman_penerbit.Text & "' , '" & DateTimePicker_Add_Peminjaman_tanggalPinjam.Text & "' , '" & DateTimePicker_Add_Peminjaman_tanggalPengembalian.Text & "', '" & ComboBox_Add_Peminjaman_status.Text & "')"
                cmd = New OdbcCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
            End If
        End If
    End Sub

    Private Sub Button_Add_peminjaman_Add_Click(sender As Object, e As EventArgs) Handles Button_Add_Peminjaman_Add.Click
        tambah()
    End Sub

    Private Sub Button_Add_peminjaman_New_Click(sender As Object, e As EventArgs) Handles Button_Add_Peminjaman_New.Click
        TextBox_Add_Peminjaman_id.Text = ""
        ComboBox_Add_Peminjaman_namaPeminjam.Text = ""
        ComboBox_Add_Peminjaman_namaAdmin.Text = ""
        ComboBox_Add_Peminjaman_idBuku.Text = ""
        TextBox_Add_Peminjaman_penulis.Text = ""
        TextBox_Add_Peminjaman_penerbit.Text = ""
        DateTimePicker_Add_Peminjaman_tanggalPinjam.Text = ""
        DateTimePicker_Add_Peminjaman_tanggalPengembalian.Text = ""
        ComboBox_Add_Peminjaman_status.Text = ""
        TextBox_Add_Peminjaman_id.Focus()
    End Sub

    'Delete'
    Sub delete()
        koneksi()
        Dim delete As String = "delete  from tbl_peminjaman WHERE id_peminjaman = '" & ComboBox_Edit_peminjaman_id.Text & "'"
        cmd = New OdbcCommand(delete, con)
        cmd.ExecuteNonQuery()
        MsgBox("Menghapus data BERHASIL", vbInformation, "INFORMASI")
    End Sub

    'Edit'
    Sub edit()
        koneksi()
        Dim update As String = "update tbl_peminjaman set id_anggota ='" & ComboBox_Edit_Peminjaman_namaPeminjam.Text & "', id_admin = '" & ComboBox_Edit_Peminjaman_namaAdmin.Text & "', id_buku = '" & ComboBox_Edit_Peminjaman_idBuku.Text & "', id_penulis = '" & TextBox_Edit_Peminjaman_penulis.Text & "' , id_penerbit = '" & TextBox_Edit_Peminjaman_penerbit.Text & "' , tanggal_pinjam = '" & DateTimePicker_Edit_Peminjaman_tanggalPinjam.Text & "' , tanggal_pengembalian = '" & DateTimePicker_Edit_Peminjaman_tanggalPengembalian.Text & "' , status = '" & ComboBox_Edit_Peminjaman_status.Text & "' WHERE id_peminjaman = '" & ComboBox_Edit_Peminjaman_id.Text & "'"
        cmd = New OdbcCommand(update, con)
        cmd.ExecuteNonQuery()
        MsgBox("Update data BERHASIL", vbInformation, "INFORMASI")
    End Sub

    Private Sub ComboBox_Edit_peminjaman_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Edit_peminjaman_id.SelectedIndexChanged
        cmd = New OdbcCommand("select * from tbl_peminjaman where id_peminjaman='" & ComboBox_Edit_peminjaman_id.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            ComboBox_Edit_Peminjaman_namaPeminjam.Text = dr.Item("id_anggota")
            ComboBox_Edit_Peminjaman_namaAdmin.Text = dr.Item("id_admin")
            ComboBox_Edit_Peminjaman_idBuku.Text = dr.Item("id_buku")
            TextBox_Edit_Peminjaman_penulis.Text = dr.Item("id_penulis")
            TextBox_Edit_Peminjaman_penerbit.Text = dr.Item("id_penerbit")
            DateTimePicker_Edit_Peminjaman_tanggalPinjam.Text = dr.Item("tanggal_pinjam")
            DateTimePicker_Edit_Peminjaman_tanggalPengembalian.Text = dr.Item("tanggal_pengembalian")
            ComboBox_Edit_Peminjaman_status.Text = dr.Item("status")
        Else
            MsgBox("ID tidak ada")
        End If
    End Sub



    Private Sub Button_Edit_peminjaman_New_Click(sender As Object, e As EventArgs) Handles Button_Edit_Peminjaman_New.Click
        ComboBox_Edit_peminjaman_id.Text = ""
        ComboBox_Edit_Peminjaman_namaPeminjam.Text = ""
        ComboBox_Edit_Peminjaman_namaAdmin.Text = ""
        ComboBox_Edit_Peminjaman_idBuku.Text = ""
        TextBox_Edit_Peminjaman_penulis.Text = ""
        TextBox_Edit_Peminjaman_penerbit.Text = ""
        DateTimePicker_Edit_Peminjaman_tanggalPinjam.Text = ""
        DateTimePicker_Edit_Peminjaman_tanggalPengembalian.Text = ""
        ComboBox_Edit_Peminjaman_status.Text = ""
    End Sub

    Private Sub Button_Edit_peminjaman_Update_Click(sender As Object, e As EventArgs) Handles Button_Edit_Peminjaman_Update.Click
        edit()
    End Sub


    'Form peminjaman'
    Private Sub Button_peminjaman_Exit_Click(sender As Object, e As EventArgs) Handles Button_Peminjaman_Exit.Click
        Close()
    End Sub

    Private Sub Button_Edit_peminjaman_Refresh_Click(sender As Object, e As EventArgs) Handles Button_Edit_Peminjaman_Refresh.Click
        tampilpeminjaman()
    End Sub

    Private Sub Button_Edit_peminjaman_Delete_Click(sender As Object, e As EventArgs) Handles Button_Edit_Peminjaman_Delete.Click
        delete()
    End Sub

    Private Sub ComboBox_Add_Peminjaman_idBuku_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Add_Peminjaman_idBuku.SelectedIndexChanged
        cmd = New OdbcCommand("select * from tbl_buku where id_buku='" & ComboBox_Add_Peminjaman_idBuku.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then

            TextBox_Add_Peminjaman_penulis.Text = dr.Item("id_penulis")
            TextBox_Add_Peminjaman_penerbit.Text = dr.Item("id_penerbit")
        Else
            MsgBox("ID tidak ada")
        End If
    End Sub
End Class
