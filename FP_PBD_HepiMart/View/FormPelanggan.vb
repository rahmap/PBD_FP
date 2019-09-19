Public Class FormPelanggan
    Private DTGrid As DataTable
    Private DTGTrx As DataTable
    Private index As Integer = 0
    Private SelectedRow As DataGridViewRow

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnPesanan_Click(sender As Object, e As EventArgs) Handles btnPesanan.Click
        FPesanan.Show()
        Me.Hide()
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        FTransaksi.Show()
        Me.Hide()
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        FMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnDriver_Click(sender As Object, e As EventArgs) Handles btnDriver.Click
        FDriver.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        conn.Close()
        Me.Hide()
        FLogin.Show()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        FHome.Show()
        Me.Hide()
    End Sub

    Private Sub FormPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbTotalHarga.Text = "Rp 0"
        Call tampilDataPel()
        Call aturDGVPel()
    End Sub

    Sub tampilDataPel()
        DTGrid = ControlPel.tampilDGVPelanggan.ToTable
        DGVPelanggan.DataSource = DTGrid
    End Sub
    Sub tampilDataTrx()
        DTGTrx = ControlPel.tampilDGVTransaksi.ToTable
        DGVTransaksi.DataSource = DTGTrx
        Call aturDGVTransaksi()
    End Sub
    Private Sub aturDGVPel()
        DGVPelanggan.Columns(0).HeaderText = "ID"
        DGVPelanggan.Columns(1).HeaderText = "Nama"
        DGVPelanggan.Columns(2).HeaderText = "Telepon"
        DGVPelanggan.Columns(3).HeaderText = "Alamat"
    End Sub
    Private Sub aturDGVTransaksi()
        DGVTransaksi.Columns(0).HeaderText = "ID"
        DGVTransaksi.Columns(1).HeaderText = "Nama Menu"
        DGVTransaksi.Columns(2).HeaderText = "Jumlah"
        DGVTransaksi.Columns(3).HeaderText = "Nama Kasir"
        DGVTransaksi.Columns(4).HeaderText = "Nama Driver"
        DGVTransaksi.Columns(5).HeaderText = "Tanggal"
        DGVTransaksi.Columns(6).HeaderText = "Sub Harga"
    End Sub

    Private Sub DGVPelanggan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPelanggan.CellClick
        Index = e.RowIndex
        If Index = -1 Then
            Index = 0
        End If
        SelectedRow = DGVPelanggan.Rows(Index)
        EntitasPel.proIDPelanggan = SelectedRow.Cells(0).Value.ToString
        If EntitasPel.proIDPelanggan IsNot "" Then
            Call tampilDataTrx()
            Dim total As Double
            For index As Integer = 0 To DGVTransaksi.RowCount - 1
                total += Convert.ToInt32(DGVTransaksi.Rows(index).Cells(6).Value).ToString
            Next
            tbTotalHarga.Text = "Rp " + Format(total, "#,##").ToString()
            tbShowID.Text = EntitasPel.proIDPelanggan
        End If
    End Sub

    Private Sub btnHapusPlg_Click(sender As Object, e As EventArgs) Handles btnHapusPlg.Click
        Dim tanya = MsgBox("Apakah akan yakin ingin menghapus data pelanggan bersama data transaksi nya?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Peringatan!")
        If tanya = 6 Then
            ControlPel.hapusPelanggan(EntitasPel.proIDPelanggan)
            tbShowID.Text = ""
            Call tampilDataPel()
            Call tampilDataTrx()
        End If
    End Sub

End Class