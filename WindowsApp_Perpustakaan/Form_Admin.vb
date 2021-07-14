Imports System.Data.Odbc
Public Class Form_Admin
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

    Sub tampilAdmin()
        cmd = New OdbcCommand("select id_admin from tbl_admin", con)
        dr = cmd.ExecuteReader
        ComboBox_Edit_Admin_id.Items.Clear()
        Do While dr.Read
            ComboBox_Edit_Admin_id.Items.Add(dr.Item("id_Admin"))
        Loop
    End Sub

    Private Sub Form_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilAdmin()
    End Sub
    'Tambah'
    Sub tambah()
        If TextBox_Add_Admin_username.Text = "" Or TextBox_Add_Admin_nama.Text = "" Or TextBox_Add_Admin_tempatLahir.Text = "" Or DateTimePicker_Add_Admin_tanggalLahir.Text = "" Or TextBox_Add_Admin_noHp.Text = "" Or ComboBox_Add_Admin_status.Text = "" Then
            MsgBox("Tolong isi semua form yang telah disediakan")
        Else
            koneksi()
            cmd = New OdbcCommand("select * from tbl_Admin where id_Admin='" & TextBox_Add_Admin_id.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                MsgBox("Data Admin gagal disimpan (ID Sudah Pernah diinput)")
            Else
                koneksi()
                Dim sql As String = "insert into tbl_Admin values('" & TextBox_Add_Admin_id.Text & "','" & TextBox_Add_Admin_username.Text & "','" & TextBox_Add_Admin_nama.Text & "','" & TextBox_Add_Admin_tempatLahir.Text & "', '" & DateTimePicker_Add_Admin_tanggalLahir.Text & "', '" & TextBox_Add_Admin_noHp.Text & "' , '" & ComboBox_Add_Admin_status.Text & "')"
                cmd = New OdbcCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
            End If
        End If
    End Sub

    Private Sub Button_Add_Admin_Add_Click(sender As Object, e As EventArgs) Handles Button_Add_Admin_Add.Click
        tambah()
    End Sub

    Private Sub Button_Add_Admin_New_Click(sender As Object, e As EventArgs) Handles Button_Add_Admin_New.Click
        TextBox_Add_Admin_id.Text = ""
        TextBox_Add_Admin_username.Text = ""
        TextBox_Add_Admin_nama.Text = ""
        TextBox_Add_Admin_tempatLahir.Text = ""
        DateTimePicker_Add_Admin_tanggalLahir.Text = ""
        TextBox_Add_Admin_noHp.Text = ""
        ComboBox_Add_Admin_status.Text = ""
        TextBox_Add_Admin_id.Focus()
    End Sub

    'Delete'
    Sub delete()
        koneksi()
        Dim delete As String = "delete  from tbl_admin WHERE id_admin = '" & ComboBox_Edit_Admin_id.Text & "'"
        cmd = New OdbcCommand(delete, con)
        cmd.ExecuteNonQuery()
        MsgBox("Menghapus data BERHASIL", vbInformation, "INFORMASI")
    End Sub

    'Edit'
    Sub edit()
        koneksi()
        Dim update As String = "update tbl_admin set username = '" & TextBox_Edit_Admin_username.Text & "', nama_Admin ='" & TextBox_Edit_Admin_nama.Text & "', tempat_lahir = '" & TextBox_Edit_Admin_tempatLahir.Text & "', tanggal_lahir = '" & DateTimePicker_Edit_Admin_tanggalLahir.Text & "', no_hp = '" & TextBox_Edit_Admin_noHp.Text & "' , status = '" & ComboBox_Edit_Admin_status.Text & "' WHERE id_Admin = '" & ComboBox_Edit_Admin_id.Text & "'"
        cmd = New OdbcCommand(update, con)
        cmd.ExecuteNonQuery()
        MsgBox("Update data BERHASIL", vbInformation, "INFORMASI")
    End Sub

    Private Sub ComboBox_Edit_Admin_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Edit_Admin_id.SelectedIndexChanged
        cmd = New OdbcCommand("select * from tbl_Admin where id_Admin='" & ComboBox_Edit_Admin_id.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            TextBox_Edit_Admin_username.Text = dr.Item("username")
            TextBox_Edit_Admin_nama.Text = dr.Item("nama_Admin")
            TextBox_Edit_Admin_tempatLahir.Text = dr.Item("tempat_lahir")
            DateTimePicker_Edit_Admin_tanggalLahir.Text = dr.Item("tanggal_lahir")
            TextBox_Edit_Admin_noHp.Text = dr.Item("no_hp")
            ComboBox_Edit_Admin_status.Text = dr.Item("status")
        Else
            MsgBox("ID tidak ada")
        End If
    End Sub



    Private Sub Button_Edit_Admin_New_Click(sender As Object, e As EventArgs) Handles Button_Edit_Admin_New.Click
        ComboBox_Edit_Admin_id.Text = ""
        TextBox_Edit_Admin_username.Text = ""
        TextBox_Edit_Admin_nama.Text = ""
        TextBox_Edit_Admin_tempatLahir.Text = ""
        DateTimePicker_Edit_Admin_tanggalLahir.Text = ""
        TextBox_Edit_Admin_noHp.Text = ""
        ComboBox_Edit_Admin_status.Text = ""
    End Sub

    Private Sub Button_Edit_Admin_Update_Click(sender As Object, e As EventArgs) Handles Button_Edit_Admin_Update.Click
        edit()
    End Sub


    'Form Admin'
    Private Sub Button_Admin_Exit_Click(sender As Object, e As EventArgs) Handles Button_Admin_Exit.Click
        Close()
    End Sub

    Private Sub Button_Edit_Admin_Refresh_Click(sender As Object, e As EventArgs) Handles Button_Edit_Admin_Refresh.Click
        tampilAdmin()
    End Sub

    Private Sub Button_Edit_Admin_Delete_Click(sender As Object, e As EventArgs) Handles Button_Edit_Admin_Delete.Click
        delete()
    End Sub
End Class
