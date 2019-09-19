Public Class FormToolsDriver

    Private DTGrid As New DataTable
    Private SelectedRow As DataGridViewRow
    Private index As Integer = 0

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub

    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub FormToolsDriver_Load(sender As Object, e As EventArgs) Handles Me.Load
        tampilDriver()
        aturDGV()
        btnAktifkanDriver.Enabled = False
    End Sub
    Sub aturDGV()
        Try
            dataDriverTidakAktif.Columns(0).HeaderText = "ID"
            dataDriverTidakAktif.Columns(1).HeaderText = "Nama"
            dataDriverTidakAktif.Columns(2).HeaderText = "Telepon"
        Catch ex As Exception
            MsgBox("Ada error " + ex.Message)
        End Try
    End Sub
    Sub tampilDriver()
        DTGrid = ControlFTD.tampilData.ToTable
        dataDriverTidakAktif.DataSource = DTGrid
    End Sub

    Private Sub btnAktifkanDriver_Click(sender As Object, e As EventArgs) Handles btnAktifkanDriver.Click

        If tbShowID.Text = "" Then
            MsgBox("Pilih driver dulu!", MsgBoxStyle.Critical, "Error")
        Else
            ControlFTD.aktifDriver(tbShowID.Text)
            tampilDriver()
            FDriver.tampilDriver()
        End If
        tbShowID.Text = ""
        If dataDriverTidakAktif.RowCount = 0 Then
            btnAktifkanDriver.Enabled = False
        End If
    End Sub

    Private Sub dataDriverTidakAktif_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataDriverTidakAktif.CellClick
        index = e.RowIndex
        If index = -1 Then
            index = 0
        End If
        SelectedRow = dataDriverTidakAktif.Rows(index)
        tbShowID.Text = SelectedRow.Cells(0).Value.ToString
        btnAktifkanDriver.Enabled = True
    End Sub

    Private Sub FormToolsDriver_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        tampilDriver()
        aturDGV()
        btnAktifkanDriver.Enabled = False
        tbShowID.Text = ""
    End Sub
End Class