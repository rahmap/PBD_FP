Public Class Home
    Private totalPend, todayPend As Double

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getStatistik()
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

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        FReport.Show()
    End Sub

    Sub getStatistik()
        ControlHome.loadStatistik()
        txtTotTrx.Text = EntitasHome.proTotTrx
        txtTodayTrx.Text = EntitasHome.proTodayTrx
        todayPend = Convert.ToInt32(EntitasHome.proTodayPendapatan).ToString
        totalPend = Convert.ToInt32(EntitasHome.proTotPendapatan).ToString
        If todayPend = 0 Then
            txtProfitToday.Text = "Masih sepi.."
        Else
            txtProfitToday.Text = "Rp " + Format(todayPend, "#,##").ToString()
        End If

        If totalPend = 0 Then
            txtProfitTot.Text = "Toko tutup?"
        Else
            txtProfitTot.Text = "Rp " + Format(totalPend, "#,##").ToString()
        End If
    End Sub
End Class
