Imports System.Data.Odbc
Public Class Form_Penerbit
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

    Sub tampilPenerbit()
        cmd = New OdbcCommand("select id_Penerbit from tbl_Penerbit", con)
        dr = cmd.ExecuteReader
        ComboBox_Edit_Penerbit_id.Items.Clear()
        Do While dr.Read
            ComboBox_Edit_Penerbit_id.Items.Add(dr.Item("id_Penerbit"))
        Loop
    End Sub

    Private Sub Form_Penerbit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilPenerbit()
        tampilDataPenerbit()
    End Sub
    'Tambah'
    Sub tambah()
        If TextBox_Add_Penerbit_id.Text = "" Or TextBox_Add_Penerbit_nama.Text = "" Or TextBox_Add_Penerbit_noHp.Text = "" Or ComboBox_Add_Penerbit_status.Text = "" Or TextBox_Add_Penerbit_tahunBerdiri.Text = "" Then
            MsgBox("Tolong isi semua form yang telah disediakan")
        Else
            koneksi()
            cmd = New OdbcCommand("select * from tbl_Penerbit where id_Penerbit='" & TextBox_Add_Penerbit_id.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                MsgBox("Data Penerbit gagal disimpan (ID Sudah Pernah diinput)")
            Else
                koneksi()
                Dim sql As String = "insert into tbl_Penerbit values('" & TextBox_Add_Penerbit_id.Text & "','" & TextBox_Add_Penerbit_nama.Text & "','" & TextBox_Add_Penerbit_tahunBerdiri.Text & "', '" & TextBox_Add_Penerbit_noHp.Text & "' , '" & ComboBox_Add_Penerbit_status.Text & "')"
                cmd = New OdbcCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
            End If
        End If
    End Sub

    Private Sub Button_Add_Penerbit_Add_Click(sender As Object, e As EventArgs) Handles Button_Add_Penerbit_Add.Click
        tambah()
        resetAdd()
        tampilDataPenerbit()
        tampilPenerbit()
    End Sub

    Sub resetAdd()
        TextBox_Add_Penerbit_id.Text = ""
        TextBox_Add_Penerbit_nama.Text = ""
        TextBox_Add_Penerbit_tahunBerdiri.Text = ""
        TextBox_Add_Penerbit_noHp.Text = ""
        ComboBox_Add_Penerbit_status.Text = ""
        TextBox_Add_Penerbit_id.Focus()
    End Sub

    'Delete'
    Sub delete()
        koneksi()
        Dim delete As String = "delete  from tbl_Penerbit WHERE id_Penerbit = '" & ComboBox_Edit_Penerbit_id.Text & "'"
        cmd = New OdbcCommand(delete, con)
        cmd.ExecuteNonQuery()
        MsgBox("Menghapus data BERHASIL", vbInformation, "INFORMASI")
    End Sub

    'Edit'
    Sub edit()
        koneksi()
        Dim update As String = "update tbl_Penerbit set nama_Penerbit ='" & TextBox_Edit_Penerbit_nama.Text & "', tahun_berdiri = '" & TextBox_Edit_Penerbit_tahunBerdiri.Text & "', no_hp = '" & TextBox_Edit_Penerbit_noHp.Text & "' , status = '" & ComboBox_Edit_Penerbit_status.Text & "' WHERE id_Penerbit = '" & ComboBox_Edit_Penerbit_id.Text & "'"
        cmd = New OdbcCommand(update, con)
        cmd.ExecuteNonQuery()
        MsgBox("Update data BERHASIL", vbInformation, "INFORMASI")
    End Sub

    Private Sub ComboBox_Edit_Penerbit_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Edit_Penerbit_id.SelectedIndexChanged
        cmd = New OdbcCommand("select * from tbl_Penerbit where id_Penerbit='" & ComboBox_Edit_Penerbit_id.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            TextBox_Edit_Penerbit_nama.Text = dr.Item("nama_Penerbit")
            TextBox_Edit_Penerbit_tahunBerdiri.Text = dr.Item("tahun_berdiri")
            TextBox_Edit_Penerbit_noHp.Text = dr.Item("no_hp")
            ComboBox_Edit_Penerbit_status.Text = dr.Item("status")
        Else
            MsgBox("ID tidak ada")
        End If
    End Sub

    Sub resetEdit()
        ComboBox_Edit_Penerbit_id.Text = ""
        TextBox_Edit_Penerbit_nama.Text = ""
        TextBox_Edit_Penerbit_tahunBerdiri.Text = ""
        TextBox_Edit_Penerbit_noHp.Text = ""
        ComboBox_Edit_Penerbit_status.Text = ""
    End Sub

    Private Sub Button_Edit_Penerbit_Update_Click(sender As Object, e As EventArgs) Handles Button_Edit_Penerbit_Update.Click
        edit()
        tampilPenerbit()
        tampilDataPenerbit()
    End Sub

    'Form Penerbit'
    Private Sub Button_Penerbit_Exit_Click(sender As Object, e As EventArgs) Handles Button_Penerbit_Exit.Click
        Close()
    End Sub

    Private Sub Button_Edit_Penerbit_Delete_Click(sender As Object, e As EventArgs) Handles Button_Edit_Penerbit_Delete.Click
        delete()
        resetEdit()
        tampilPenerbit()
        tampilDataPenerbit()
    End Sub

    Sub tampilDataPenerbit()
        DataGridView_DataPenerbit.Rows.Clear()
        Try
            koneksi()
            da = New OdbcDataAdapter("select *from tbl_penerbit order by id_penerbit asc", con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                DataGridView_DataPenerbit.Rows.Add(row(0), row(1), row(2), row(3), row(4))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data GAGAL")
        End Try
    End Sub

End Class
