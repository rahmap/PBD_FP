Public Class FormDriver

    Private DTGrid As New DataTable
    Private SelectedRow As DataGridViewRow
    Private index As Integer
    Private null As Integer

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Try
            If String.IsNullOrEmpty(tbNama.Text) Or String.IsNullOrWhiteSpace(tbNama.Text) Then
                MsgBox("Lengkapi semua data dulu!", MsgBoxStyle.Exclamation, "Peringatan")
            ElseIf String.IsNullOrEmpty(tbTelp.Text) Or String.IsNullOrWhiteSpace(tbTelp.Text) Then
                MsgBox("Lengkapi semua data dulu!", MsgBoxStyle.Exclamation, "Peringatan")
            Else
                EntitasDriver.proNama = tbNama.Text
                EntitasDriver.proTelp = tbTelp.Text
                ControlDriver.insertDriver()
                tampilDriver()
            End If
        Catch ex As Exception
            MsgBox("Data gagal disimpan" + ex.Message, MsgBoxStyle.Critical)
        End Try
        resetTB()
    End Sub
    Private Sub cekValue()
        Dim TextBoxs = Me.Controls.OfType(Of TextBox)
        For Each tb In TextBoxs
            If String.IsNullOrEmpty(tb.Text) Or String.IsNullOrWhiteSpace(tb.Text) Then
                null = 1
            Else
                null = 0
            End If
        Next
    End Sub
    Private Sub FormDriver_Load(sender As Object, e As EventArgs) Handles Me.Load
        tampilDriver()
        aturDGV()
        btnNonaktifDriver.Enabled = False
    End Sub
    Public Sub aturDGV()
        Try
            dataDriver.Columns(0).HeaderText = "ID"
            dataDriver.Columns(1).HeaderText = "Nama"
            dataDriver.Columns(2).HeaderText = "Telepon"
        Catch ex As Exception
            MsgBox("Ada error " + ex.Message)
        End Try
    End Sub
    Public Sub tampilDriver()
        DTGrid = ControlDriver.tampilDriver.ToTable
        dataDriver.DataSource = DTGrid
    End Sub


    Private Sub dataDriver_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataDriver.CellClick
        btnNonaktifDriver.Enabled = True
        index = e.RowIndex
        If index = -1 Then
            index = 0
        End If
        SelectedRow = dataDriver.Rows(index)
        EntitasDriver.proID = SelectedRow.Cells(0).Value
        EntitasDriver.proNama = SelectedRow.Cells(1).Value
        tbShowID.Text = SelectedRow.Cells(0).Value
    End Sub

    Private Sub btnNonaktifDriver_Click(sender As Object, e As EventArgs) Handles btnNonaktifDriver.Click
        If tbShowID.Text = "" Then
            tampilDriver()
            MsgBox("Pilih driver dulu!", MsgBoxStyle.Critical, "Error")
        Else
            ControlDriver.hapusDriver()
            tampilDriver()
        End If
        tbShowID.Text = ""
        resetTB()
        If dataDriver.RowCount = 0 Then
            btnNonaktifDriver.Enabled = False
        End If
    End Sub


    Private Sub resetTB()
        tbNama.Clear()
        tbTelp.Clear()
    End Sub

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
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        FMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        conn.Close()
        Me.Hide()
        FLogin.Show()
    End Sub

    Private Sub btnLihatStatusDriver_Click(sender As Object, e As EventArgs) Handles btnLihatStatusDriver.Click
        FTD.Show()
    End Sub

End Class