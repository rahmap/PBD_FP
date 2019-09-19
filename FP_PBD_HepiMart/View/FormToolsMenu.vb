Public Class FormToolsMenu
    Private DTGrid As New DataTable
    Private SelectedRow As DataGridViewRow
    Private index As Integer = 0

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub

    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnAktifkanMenu_Click(sender As Object, e As EventArgs) Handles btnAktifkanMenu.Click
        If tbShowID.Text = "" Then
            MsgBox("Pilih Menu Dulu!", MsgBoxStyle.Critical, "Error")
        Else
            ControlFTM.aktifMenu(tbShowID.Text)
            Call tampilData()
            FMenu.tampilData()
            MsgBox("Berhasil Mengaktifkan Menu", MsgBoxStyle.Information, "Informasi")
        End If
        tbShowID.Text = ""
        If dataMenuTidakAktif.RowCount = 0 Then
            btnAktifkanMenu.Enabled = False
        End If
    End Sub

    Private Sub setDGV()
        Try
            dataMenuTidakAktif.Columns(0).HeaderText = "ID"
            dataMenuTidakAktif.Columns(1).HeaderText = "Nama"
            dataMenuTidakAktif.Columns(2).HeaderText = "Jenis"
            dataMenuTidakAktif.Columns(3).HeaderText = "Harga"
            dataMenuTidakAktif.Columns(4).HeaderText = "Stok"
        Catch ex As Exception
            MsgBox("Ada error " + ex.Message)
        End Try
    End Sub
    Private Sub tampilData()
        DTGrid = ControlFTM.tampilData.ToTable
        dataMenuTidakAktif.DataSource = DTGrid
    End Sub

    Private Sub FormToolsMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call tampilData()
        Call setDGV()
    End Sub

    Private Sub dataMenuTidakAktif_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataMenuTidakAktif.CellClick
        index = e.RowIndex
        If index = -1 Then
            index = 0
        End If
        SelectedRow = dataMenuTidakAktif.Rows(index)
        tbShowID.Text = SelectedRow.Cells(0).Value.ToString
        btnAktifkanMenu.Enabled = True
    End Sub

    Private Sub FormToolsMenu_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        tampilData()
        setDGV()
        btnAktifkanMenu.Enabled = False
        tbShowID.Text = ""
    End Sub
End Class