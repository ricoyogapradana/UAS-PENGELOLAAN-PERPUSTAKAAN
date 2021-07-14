Public Class HalamanDepan
    Private Sub AdminToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem2.Click
        Form_Admin.Show()
    End Sub

    Private Sub AnggotaToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AnggotaToolStripMenuItem2.Click
        Form_Anggota.Show()
    End Sub

    Private Sub TambahBukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahBukuToolStripMenuItem.Click
        Form_Buku.Show()
    End Sub

    Private Sub PenerbitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenerbitToolStripMenuItem.Click
        Form_Penerbit.Show()
    End Sub

    Private Sub PenulisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenulisToolStripMenuItem.Click
        Form_Penulis.Show()
    End Sub

    Private Sub TambahPeminjamanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahPeminjamanToolStripMenuItem.Click
        Form_Peminjaman.Show()
    End Sub

    Private Sub AplikasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AplikasiToolStripMenuItem.Click
        MsgBox("Pengelolaan Data Perpustakaan by Rico Yoga Pradana", Title:="Tentang Aplikasi")
    End Sub

    Private Sub PembuatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembuatToolStripMenuItem.Click
        Form_AboutMe.Show()
    End Sub
End Class