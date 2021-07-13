Imports System.Data.Odbc
Public Class Form_Buku
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

    Sub tampilbuku()
        cmd = New OdbcCommand("select id_buku from tbl_buku", con)
        dr = cmd.ExecuteReader
        ComboBox_Edit_buku_id.Items.Clear()
        Do While dr.Read
            ComboBox_Edit_buku_id.Items.Add(dr.Item("id_buku"))
        Loop
    End Sub

    Sub tampilDataBuku()
        DataGridView_DataBuku.Rows.Clear()
        Try
            koneksi()
            da = New OdbcDataAdapter("select *from tbl_buku order by id_buku asc", con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                DataGridView_DataBuku.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data GAGAL")
        End Try
    End Sub

    Sub tampilPenulis()
        cmd = New OdbcCommand("select nama_penulis from tbl_penulis ", con)
        dr = cmd.ExecuteReader
        ComboBox_Add_Buku_penulis.Items.Clear()
        Do While dr.Read
            ComboBox_Add_Buku_penulis.Items.Add(dr.Item("nama_penulis"))
            ComboBox_Edit_Buku_penulis.Items.Add(dr.Item("nama_penulis"))
        Loop
    End Sub


    Sub tampilPenerbit()
        cmd = New OdbcCommand("select nama_penerbit from tbl_penerbit ", con)
        dr = cmd.ExecuteReader
        ComboBox_Add_Buku_penerbit.Items.Clear()
        Do While dr.Read
            ComboBox_Add_Buku_penerbit.Items.Add(dr.Item("nama_penerbit"))
            ComboBox_Edit_Buku_penerbit.Items.Add(dr.Item("nama_penerbit"))
        Loop
    End Sub

    Private Sub Form_buku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilbuku()
        tampilPenulis()
        tampilPenerbit()
        tampilDataBuku()
    End Sub

    'Tambah'
    Sub tambah()
        If TextBox_Add_Buku_nama.Text = "" Or ComboBox_Add_Buku_penulis.Text = "" Or ComboBox_Add_Buku_penerbit.Text = "" Or TextBox_Add_Buku_tahunTerbit.Text = "" Or ComboBox_Add_Buku_status.Text = "" Then
            MsgBox("Tolong isi semua form yang telah disediakan")
        Else
            koneksi()
            cmd = New OdbcCommand("select * from tbl_buku where id_buku='" & TextBox_Add_Buku_id.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                MsgBox("Data buku gagal disimpan (ID Sudah Pernah diinput)")
            Else
                koneksi()
                Dim sql As String = "insert into tbl_buku values('" & TextBox_Add_Buku_id.Text & "', '" & TextBox_Add_Buku_nama.Text & "','" & ComboBox_Add_Buku_penulis.Text & "', '" & ComboBox_Add_Buku_penerbit.Text & "', '" & TextBox_Add_Buku_tahunTerbit.Text & "' , '" & ComboBox_Add_Buku_status.Text & "')"
                cmd = New OdbcCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
            End If
        End If
    End Sub

    Private Sub Button_Add_buku_Add_Click(sender As Object, e As EventArgs) Handles Button_Add_Buku_Add.Click
        tambah()
        resetTambah()
        tampilbuku()
        tampilDataBuku()
    End Sub

    Sub resetTambah()
        TextBox_Add_Buku_id.Text = ""
        TextBox_Add_Buku_nama.Text = ""
        ComboBox_Add_Buku_penulis.Text = ""
        ComboBox_Add_Buku_penerbit.Text = ""
        TextBox_Add_Buku_tahunTerbit.Text = ""
        ComboBox_Add_Buku_status.Text = ""
        TextBox_Add_Buku_id.Focus()
    End Sub

    'Delete'
    Sub delete()
        koneksi()
        Dim delete As String = "delete  from tbl_buku WHERE id_buku = '" & ComboBox_Edit_buku_id.Text & "'"
        cmd = New OdbcCommand(delete, con)
        cmd.ExecuteNonQuery()
        MsgBox("Menghapus data BERHASIL", vbInformation, "INFORMASI")
    End Sub

    'Edit'
    Sub edit()
        koneksi()
        Dim update As String = "update tbl_buku set nama_buku ='" & TextBox_Edit_Buku_nama.Text & "', id_penulis = '" & ComboBox_Edit_Buku_penulis.Text & "', id_penerbit = '" & ComboBox_Edit_Buku_penerbit.Text & "', tahun_terbit = '" & TextBox_Edit_Buku_tahunTerbit.Text & "' , status = '" & ComboBox_Edit_Buku_status.Text & "' WHERE id_buku = '" & ComboBox_Edit_Buku_id.Text & "'"
        cmd = New OdbcCommand(update, con)
        cmd.ExecuteNonQuery()
        MsgBox("Update data BERHASIL", vbInformation, "INFORMASI")
    End Sub

    Private Sub ComboBox_Edit_buku_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Edit_buku_id.SelectedIndexChanged
        cmd = New OdbcCommand("select * from tbl_buku where id_buku='" & ComboBox_Edit_buku_id.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            TextBox_Edit_Buku_nama.Text = dr.Item("nama_buku")
            ComboBox_Edit_Buku_penulis.Text = dr.Item("id_penulis")
            ComboBox_Edit_Buku_penerbit.Text = dr.Item("id_penerbit")
            TextBox_Edit_Buku_tahunTerbit.Text = dr.Item("tahun_terbit")
            ComboBox_Edit_Buku_status.Text = dr.Item("status")
        Else
            MsgBox("ID tidak ada")
        End If
    End Sub


    Sub resetEdit()
        ComboBox_Edit_Buku_id.Text = ""
        TextBox_Edit_Buku_nama.Text = ""
        ComboBox_Edit_Buku_penulis.Text = ""
        ComboBox_Edit_Buku_penerbit.Text = ""
        TextBox_Edit_Buku_tahunTerbit.Text = ""
        ComboBox_Edit_Buku_status.Text = ""
    End Sub
    Private Sub Button_Edit_buku_New_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button_Edit_buku_Update_Click(sender As Object, e As EventArgs) Handles Button_Edit_Buku_Update.Click
        edit()
        tampilDataBuku()
    End Sub


    'Form buku'
    Private Sub Button_buku_Exit_Click(sender As Object, e As EventArgs) Handles Button_Buku_Exit.Click
        Close()
    End Sub

    Private Sub Button_Edit_buku_Delete_Click(sender As Object, e As EventArgs) Handles Button_Edit_Buku_Delete.Click
        delete()
        tampilbuku()
        resetEdit()
        tampilDataBuku()
    End Sub
End Class
