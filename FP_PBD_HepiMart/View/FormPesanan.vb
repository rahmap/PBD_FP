Imports System.Data.OleDb

Public Class FormPesanan

    Private DTGrid As DataTable

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        FHome.Show()
        Me.Hide()
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        FTransaksi.Show()
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

    Private Sub FormPesanan_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Home.Show()
    End Sub

    Private Sub FormPesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbMakanan.Select()
        tbSubHarga.Text = "Rp 0"
        tbTotalHarga.Text = "Rp 0"
        DR = ControlPesanan.getListDriver.ExecuteReader()
        If DR.HasRows Then
            While DR.Read()
                cbDriver.Items.Add(DR("nama_driver"))
            End While
            DR.Close()
        End If
        EntitasPesanan.proRandId = rand.Next(1, 999)
    End Sub

    Private Sub btnResetPesanan_Click(sender As Object, e As EventArgs) Handles btnResetPesanan.Click
        tbIDPesanan.Text = ""
        tbSubHarga.Text = "Rp 0"
        cbDriver.SelectedIndex = -1
        cbMenu.SelectedIndex = -1
        jmlPesan.Value = 0
        rbMakanan.Select()
        lblStok.Text = 0
    End Sub

    Private Sub btnResetPelanggan_Click(sender As Object, e As EventArgs) Handles btnResetPelanggan.Click
        tbIDpel.Text = ""
        tbAlamat.Text = ""
        tbNama.Text = ""
        tbTelp.Text = ""
        tbSubHarga.Text = "Rp 0"
        tbTotalHarga.Text = "Rp 0"
        cbDriver.SelectedIndex = -1
        cbMenu.SelectedIndex = -1
        jmlPesan.Value = 0
        tbAlamat.Enabled = True
        tbNama.Enabled = True
        tbTelp.Enabled = True
        btnInsertPlg.Enabled = True
        dgvPemesanan.DataSource = Nothing
        btnInput.Enabled = False
        btnResetPesanan.Enabled = False
        btnResetPelanggan.Enabled = False
        lblStok.Text = 0
    End Sub
    Sub setEntitasPlg()
        EntitasPesanan.proAlamatPlg = tbAlamat.Text
        EntitasPesanan.proNamaPlg = tbNama.Text
        EntitasPesanan.proTlpPlg = tbTelp.Text
    End Sub

    Private Sub btnInsertPlg_Click(sender As Object, e As EventArgs) Handles btnInsertPlg.Click
        Call setEntitasPlg()
        ControlPesanan.inputPelanggan()
        tbAlamat.Enabled = False
        tbNama.Enabled = False
        tbTelp.Enabled = False
        btnInsertPlg.Enabled = False
        tbIDpel.Text = ControlPesanan.idPel
        btnInput.Enabled = True
        btnResetPelanggan.Enabled = True
        Call onTBPesanan()
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        DTPWaktu.Value = DateTime.Now
        EntitasPesanan.proWaktu = Format(DTPWaktu.Value, "MM-dd-yyyy HH:mm")
        EntitasPesanan.proJml = Convert.ToInt16(jmlPesan.Value)
        EntitasPesanan.proNamaDriver = cbDriver.Text.ToString
        EntitasPesanan.proNamaMenu = cbMenu.Text.ToString
        ControlPesanan.insertPesanan()
        tbSubHarga.Text = "Rp " + Format((EntitasPesanan.proJml * EntitasPesanan.proSubHarga), "#,##").ToString()
        tbIDPesanan.Text = ControlPesanan.idTrx
        btnResetPesanan.Enabled = True
        btnResetPelanggan.Enabled = True
        Call tampilDataDgv()
        Call aturDGV()

        Dim total As Double
        For index As Integer = 0 To dgvPemesanan.RowCount - 1
            total += Convert.ToInt32(dgvPemesanan.Rows(index).Cells(3).Value).ToString
        Next
        tbTotalHarga.Text = "Rp " + Format(total, "#,##").ToString()
        ControlPesanan.getUpdateStok(EntitasPesanan.proJml)
        EntitasPesanan.proNamaMenu = cbMenu.Text
        ControlPesanan.getIDMenu()
        ControlPesanan.getStokMenu()
        lblStok.Text = EntitasPesanan.proStokMenu
        jmlPesan.Maximum = Convert.ToDecimal(EntitasPesanan.proStokMenu)
        jmlPesan.Value = 0
        If jmlPesan.Maximum = 0 Then
            btnInput.Enabled = False
        Else
            btnInput.Enabled = True
        End If
    End Sub
    Sub aturDGV()
        Try
            dgvPemesanan.Columns(0).HeaderText = "ID Transaksi"
            dgvPemesanan.Columns(1).HeaderText = "Nama Menu"
            dgvPemesanan.Columns(2).HeaderText = "Jumlah Pesanan"
            dgvPemesanan.Columns(3).HeaderText = "Sub Harga"
        Catch ex As Exception
            MsgBox("Ada error " + ex.Message)
        End Try
    End Sub
    Sub tampilDataDgv()
        DTGrid = ControlPesanan.tampilDGVPesanan.ToTable
        dgvPemesanan.DataSource = DTGrid
    End Sub
    Sub onTBPesanan()
        DTPWaktu.Enabled = True
        jmlPesan.Enabled = True
        cbDriver.Enabled = True
        cbMenu.Enabled = True
        rbMakanan.Enabled = True
        rbMinuman.Enabled = True
    End Sub
    Sub offTBPesanan()
        DTPWaktu.Enabled = False
        jmlPesan.Enabled = False
        cbDriver.Enabled = False
        cbMenu.Enabled = False
        rbMakanan.Enabled = False
        rbMinuman.Enabled = False
    End Sub

    Private Sub DTPWaktu_ValueChanged(sender As Object, e As EventArgs) Handles DTPWaktu.ValueChanged
        EntitasPesanan.proWaktu = Format(DTPWaktu.Value, "MM-dd-yyyy HH:mm")
    End Sub

    Private Sub FormPesanan_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        tbAlamat.Enabled = True
        tbNama.Enabled = True
        tbTelp.Enabled = True
        tbIDPesanan.Text = ""
        tbSubHarga.Text = "Rp 0"
        cbDriver.SelectedIndex = -1
        cbMenu.SelectedIndex = -1
        jmlPesan.Value = 0
        tbIDpel.Text = ""
        tbAlamat.Text = ""
        tbNama.Text = ""
        tbTelp.Text = ""
        btnInsertPlg.Enabled = True
        btnResetPelanggan.Enabled = False
        btnResetPesanan.Enabled = False
        btnInput.Enabled = False
        rbMakanan.Select()
        tbTotalHarga.Text = "Rp 0"
        dgvPemesanan.DataSource = Nothing
        lblStok.Text = 0
        Call offTBPesanan()
    End Sub
    Private Sub setCBJenis(Optional ByVal jenisMenu = "Makanan")
        DR = ControlPesanan.getListMenu(jenisMenu).ExecuteReader()
        If DR.HasRows Then
            While DR.Read()
                cbMenu.Items.Add(DR("nama_menu"))
            End While
            DR.Close()
        End If
    End Sub

    Private Sub rbMakanan_CheckedChanged(sender As Object, e As EventArgs) Handles rbMakanan.CheckedChanged
        cbMenu.Items.Clear()
        tbSubHarga.Text = "Rp 0"
        Call setCBJenis("Makanan")
    End Sub

    Private Sub rbMinuman_CheckedChanged(sender As Object, e As EventArgs) Handles rbMinuman.CheckedChanged
        cbMenu.Items.Clear()
        tbSubHarga.Text = "Rp 0"
        Call setCBJenis("Minuman")
    End Sub

    Private Sub cbMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMenu.SelectedIndexChanged
        EntitasPesanan.proNamaMenu = cbMenu.Text
        ControlPesanan.getIDMenu()
        ControlPesanan.getStokMenu()
        jmlPesan.Value = 0
        EntitasPesanan.proJml = Convert.ToInt16(jmlPesan.Value)
        jmlPesan.Maximum = Convert.ToDecimal(EntitasPesanan.proStokMenu)
        tbSubHarga.Text = "Rp " + Format((EntitasPesanan.proJml * EntitasPesanan.proSubHarga), "#,##").ToString()
        lblStok.Text = EntitasPesanan.proStokMenu
        If jmlPesan.Maximum = 0 Then
            btnInput.Enabled = False
        Else
            btnInput.Enabled = True
        End If
    End Sub

    Private Sub jmlPesan_ValueChanged(sender As Object, e As EventArgs) Handles jmlPesan.ValueChanged
        EntitasPesanan.proNamaMenu = cbMenu.Text
        ControlPesanan.getIDMenu()
        EntitasPesanan.proJml = Convert.ToInt16(jmlPesan.Value)
        tbSubHarga.Text = "Rp " + Format((EntitasPesanan.proJml * EntitasPesanan.proSubHarga), "#,##").ToString()
    End Sub

End Class