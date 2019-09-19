Public Class FormMenu

    Private DTGrid As New DataTable
    Private SelectedRow As DataGridViewRow
    Private index As Integer = 0

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

    Private Sub btnPesanan_Click(sender As Object, e As EventArgs) Handles btnPesanan.Click
        FPesanan.Show()
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

    Private Sub btnDriver_Click(sender As Object, e As EventArgs) Handles btnDriver.Click
        FDriver.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        conn.Close()
        Me.Hide()
        FLogin.Show()
    End Sub

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        tampilData()
        aturDGV()
        btnSwitchUpdate.Checked = False
    End Sub
    Public Sub tampilData()
        DTGrid = ControlMenu.tampilMenu.ToTable
        dataMenu.DataSource = DTGrid

        resetTB()
    End Sub
    Sub aturDGV()
        Try
            dataMenu.Columns(0).HeaderText = "ID"
            dataMenu.Columns(1).HeaderText = "Nama"
            dataMenu.Columns(2).HeaderText = "Jenis"
            dataMenu.Columns(3).HeaderText = "Harga"
            dataMenu.Columns(4).HeaderText = "Stok"

        Catch ex As Exception
            MsgBox("Ada error " + ex.Message)
        End Try
    End Sub

    Private Sub resetTB()
        tbNama.Clear()
        tbHarga.Clear()
        tbStok.Clear()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        setEntitas()
        ControlMenu.insertMenu()
        tampilData()
    End Sub

    Sub setEntitas()
        If rbMakanan.Checked Then
            EntitasMenu.proJenis = rbMakanan.Text
        Else
            EntitasMenu.proJenis = rbMinuman.Text
        End If
        EntitasMenu.proNama = tbNama.Text
        EntitasMenu.proStok = tbStok.Text
        EntitasMenu.proHarga = tbHarga.Text
    End Sub

    Private Sub dataMenu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataMenu.CellClick

        index = e.RowIndex
        If index = -1 Then
            index = 0
        End If
        SelectedRow = dataMenu.Rows(index)
        If SelectedRow.Cells(2).Value.ToString = "Makanan" Then
            rbMakanan.Select()
            EntitasMenu.proJenis = rbMakanan.Text
        Else
            rbMinuman.Select()
            EntitasMenu.proJenis = rbMinuman.Text
        End If

        EntitasMenu.proID = SelectedRow.Cells(0).Value.ToString
        tbNama.Text = SelectedRow.Cells(1).Value.ToString
        tbHarga.Text = SelectedRow.Cells(3).Value
        tbStok.Text = SelectedRow.Cells(4).Value
        tbShowID.Text = EntitasMenu.proID
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        If tbShowID.Text = "" Then
            MsgBox("Pilih Menu Dulu!", MsgBoxStyle.Critical, "Error")
        Else
            ControlMenu.hapusMenu(EntitasMenu.proID)
            tampilData()
        End If
        tbShowID.Text = ""
        If dataMenu.RowCount = 0 Then
            btnHapus.Enabled = False
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        setEntitas()
        Dim tanya = MsgBox("Data yang diperbaruhi hanyalah data Stok saja!", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Peringatan!")
        If tanya = 6 Then
            ControlMenu.updateMenu()
            MsgBox("Berhasil memperbaruhi Stok menu!", MsgBoxStyle.Information, "Informasi")
        End If

        tampilData()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        EntitasMenu.proCari = tbCari.Text
        DTGrid = ControlMenu.cariMenu.ToTable
        dataMenu.DataSource = DTGrid
        tbCari.Clear()
    End Sub

    Private Sub btnTampil_Click(sender As Object, e As EventArgs) Handles btnTampil.Click
        tampilData()
    End Sub

    Private Sub btnSwitchUpdate_CheckedChanged(sender As Object, e As Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs) Handles btnSwitchUpdate.CheckedChanged
        If e.Checked = True Then
            btnUpdate.Enabled = True
            btnSimpan.Enabled = False
            btnHapus.Enabled = False
            tbHarga.Enabled = False
            tbNama.Enabled = False
            rbMakanan.Enabled = False
            rbMinuman.Enabled = False
        Else
            btnUpdate.Enabled = False
            btnSimpan.Enabled = True
            btnHapus.Enabled = True
            tbHarga.Enabled = True
            tbNama.Enabled = True
            rbMakanan.Enabled = True
            rbMinuman.Enabled = True
        End If
    End Sub

    Private Sub btnLihatStatusMenu_Click(sender As Object, e As EventArgs) Handles btnLihatStatusMenu.Click
        FTM.Show()
    End Sub

    Private Sub btnStok100_Click(sender As Object, e As EventArgs) Handles btnStok100.Click
        Dim tanya = MsgBox("Apakah anda yakin ingin merubah semua stok menjadi 100?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Peringatan!")
        If tanya = 6 Then
            ControlMenu.stok100()
            tampilData()
        End If
    End Sub

    Private Sub btnStok0_Click(sender As Object, e As EventArgs) Handles btnStok0.Click
        Dim tanya = MsgBox("Apakah anda yakin ingin merubah semua stok menjadi 0?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Peringatan!")
        If tanya = 6 Then
            ControlMenu.stok0()
            tampilData()
        End If
    End Sub
End Class