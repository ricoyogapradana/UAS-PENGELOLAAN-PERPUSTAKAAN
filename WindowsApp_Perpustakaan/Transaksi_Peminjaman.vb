Imports System.Data.Odbc
Imports Microsoft.Reporting.WinForms

Public Class Transaksi_Peminjaman
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

    Private Sub Transaksi_Peminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim id_peminjaman As New ReportParameter("id_peminjaman", Form_Peminjaman.TextBox_Add_Peminjaman_id.Text)
        Me.ReportViewer1.LocalReport.SetParameters(id_peminjaman)

        Dim nama_peminjam As New ReportParameter("nama_peminjam", Form_Peminjaman.ComboBox_Add_Peminjaman_namaPeminjam.Text)
        Me.ReportViewer1.LocalReport.SetParameters(nama_peminjam)

        Dim nama_admin As New ReportParameter("nama_admin", Form_Peminjaman.ComboBox_Add_Peminjaman_namaAdmin.Text)
        Me.ReportViewer1.LocalReport.SetParameters(nama_admin)

        Dim id_buku As New ReportParameter("id_buku", Form_Peminjaman.ComboBox_Add_Peminjaman_idBuku.Text)
        Me.ReportViewer1.LocalReport.SetParameters(id_buku)

        Dim nama_buku As New ReportParameter("nama_buku", Form_Peminjaman.TextBox_Add_Peminjaman_namaBuku.Text)
        Me.ReportViewer1.LocalReport.SetParameters(nama_buku)

        Dim nama_penulis As New ReportParameter("nama_penulis", Form_Peminjaman.TextBox_Add_Peminjaman_penulis.Text)
        Me.ReportViewer1.LocalReport.SetParameters(nama_penulis)

        Dim nama_penerbit As New ReportParameter("nama_penerbit", Form_Peminjaman.TextBox_Add_Peminjaman_penerbit.Text)
        Me.ReportViewer1.LocalReport.SetParameters(nama_penerbit)

        Dim tanggal_pinjam As New ReportParameter("tanggal_pinjam", Form_Peminjaman.DateTimePicker_Add_Peminjaman_tanggalPinjam.Text)
        Me.ReportViewer1.LocalReport.SetParameters(tanggal_pinjam)

        Dim tanggal_pengembalian As New ReportParameter("tanggal_pengembalian", Form_Peminjaman.DateTimePicker_Add_Peminjaman_tanggalPengembalian.Text)
        Me.ReportViewer1.LocalReport.SetParameters(tanggal_pengembalian)

        Dim status As New ReportParameter("status", Form_Peminjaman.ComboBox_Add_Peminjaman_status.Text)
        Me.ReportViewer1.LocalReport.SetParameters(status)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class