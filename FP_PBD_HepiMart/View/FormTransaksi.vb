Public Class FormTransaksi

    Private DTGrid As New DataTable
    Private SelectedRow As DataGridViewRow
    Private index As Integer = 0

    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilData()
        Call aturDGVTransaksi()
        DTPWaktu.Value = DateTime.Now
    End Sub
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

    Private Sub btnPelanggan_Click(sender As Object, e As EventArgs) Handles btnPelanggan.Click
        FPelanggan.Show()
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

    Private Sub aturDGVTransaksi()
        DGVTransaksi.Columns(0).HeaderText = "ID"
        DGVTransaksi.Columns(1).HeaderText = "Pelanggan"
        DGVTransaksi.Columns(2).HeaderText = "Driver"
        DGVTransaksi.Columns(3).HeaderText = "Admin"
        DGVTransaksi.Columns(4).HeaderText = "Menu"
        DGVTransaksi.Columns(5).HeaderText = "Jumlah"
        DGVTransaksi.Columns(6).HeaderText = "Total Harga"
        DGVTransaksi.Columns(7).HeaderText = "Alamat"
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        EntitasTransaksi.proWaktu = Format(DTPWaktu.Value, "MM-dd-yyyy")
        DTGrid = ControlTransaksi.dataDGVTrxSpesifikTanggal.ToTable
        DGVTransaksi.DataSource = DTGrid
    End Sub
    Sub tampilData()
        DTGrid = ControlTransaksi.dataDGVTrx.ToTable
        DGVTransaksi.DataSource = DTGrid
    End Sub
    Private Sub btnTampil_Click(sender As Object, e As EventArgs) Handles btnTampil.Click
        Call tampilData()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        ControlTransaksi.hapusTransaksi(EntitasTransaksi.proIDTrx)
        Call tampilData()
    End Sub

    Private Sub DGVTransaksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVTransaksi.CellClick

        index = e.RowIndex
        If index = -1 Then
            index = 0
        End If
        SelectedRow = DGVTransaksi.Rows(index)
        EntitasTransaksi.proIDTrx = SelectedRow.Cells(0).Value.ToString
        tbShowID.Text = SelectedRow.Cells(0).Value.ToString

    End Sub
End Class