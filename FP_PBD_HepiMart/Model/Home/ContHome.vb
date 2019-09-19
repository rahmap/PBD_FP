Imports AppStyle

Public Class ContHome : Implements InterfaceHome

    Public Sub getPendapatanToday() Implements InterfaceHome.getPendapatanToday
        'Dim q = "SELECT SUM(total_harga) AS [jumlah] FROM transaksi WHERE " & vbCrLf &
        '"tgl_transaksi BETWEEN '" + String.Format("{0:MM-dd-yyyy}", DateTime.Now)
        '+ " 00:00' AND '" + String.Format("{0:MM-dd-yyyy}", DateTime.Now) + " 23:59' "
        Try
            CMD = New OleDb.OleDbCommand("SELECT * FROM [viewGetPendapatanToday]", conn)
            If IsDBNull(CMD.ExecuteScalar()) Then
                EntitasHome.proTodayPendapatan = 0
            Else
                EntitasHome.proTodayPendapatan = Convert.ToInt32(CMD.ExecuteScalar())
            End If
        Catch ex As Exception
            MsgBox("ERROR " + ex.Message)
        End Try
    End Sub

    Public Sub getPendapatan() Implements InterfaceHome.getPendapatan
        Dim q = "SELECT SUM(total_harga) As [jml] FROM transaksi"
        Try
            CMD = New OleDb.OleDbCommand(q, conn)

            If IsDBNull(CMD.ExecuteScalar()) Then
                EntitasHome.proTotPendapatan = 0
            Else
                EntitasHome.proTotPendapatan = Convert.ToInt32(CMD.ExecuteScalar())
            End If
        Catch ex As Exception
            MsgBox("ERROR " + ex.Message)
        End Try
    End Sub

    Public Sub getTrx() Implements InterfaceHome.getTrx
        Dim q = "SELECT COUNT(id_transaksi) AS [jumlah] FROM transaksi"
        Try
            CMD = New OleDb.OleDbCommand(q, conn)

            If IsDBNull(CMD.ExecuteScalar()) Then
                EntitasHome.proTotTrx = 0
            Else
                EntitasHome.proTotTrx = Convert.ToInt32(CMD.ExecuteScalar())
            End If
        Catch ex As Exception
            MsgBox("ERROR " + ex.Message)
        End Try
    End Sub

    Public Sub getTrxToday() Implements InterfaceHome.getTrxToday
        'Dim q = "SELECT COUNT(id_transaksi) AS [jumlah] FROM transaksi WHERE " & vbCrLf &
        '"tgl_transaksi BETWEEN '" + String.Format("{0:MM-dd-yyyy}", DateTime.Now) + " 00:00' AND '" +
        'String.Format("{0:MM-dd-yyyy}", DateTime.Now) + " 23:59' "
        Try
            Using CMD = New OleDb.OleDbCommand("SELECT * FROM [viewGetTrxToday]", conn)
                If IsDBNull(CMD.ExecuteScalar()) Then
                    EntitasHome.proTodayTrx = 0
                Else
                    EntitasHome.proTodayTrx = Convert.ToInt32(CMD.ExecuteScalar())
                End If
            End Using
        Catch ex As Exception
            MsgBox("ERROR " + ex.Message)
        End Try
    End Sub

    Public Sub loadStatistik() Implements InterfaceHome.loadStatistik
        Call getTrx()
        Call getTrxToday()
        Call getPendapatan()
        Call getPendapatanToday()
    End Sub
End Class
