Public Class FormReport

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub

    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub FormReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTPWaktu.Value = DateTime.Now
        CRV.Refresh()
        CRV.RefreshReport()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        CRV.SelectionFormula = "{transaksi.tgl_transaksi} >= '" & Format(DTPWaktu.Value, "MM-dd-yyyy") & " 00:00' AND " & vbCrLf &
        "{transaksi.tgl_transaksi} <= '" & Format(DTPWaktu.Value, "MM-dd-yyyy") & " 23:59' "
        CRV.Refresh()
        CRV.RefreshReport()
    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        CRV.SelectionFormula = "{transaksi.total_harga} > 0"
        CRV.Refresh()
        CRV.RefreshReport()
    End Sub

End Class