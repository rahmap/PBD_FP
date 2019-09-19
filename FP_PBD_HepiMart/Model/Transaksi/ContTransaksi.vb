Imports System.Data.OleDb

Public Class ContTransaksi : Implements InterfaceTransaksi
    Function dataDGVTrx() As DataView Implements InterfaceTransaksi.dataDGVTrx
        Try
            DA = New OleDbDataAdapter("SELECT * FROM [viewDataTransaksi]", conn)
            DS = New DataSet
            DA.Fill(DS, "transaksi")
            Dim grid As New DataView(DS.Tables("transaksi"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
            MsgBox("Gagal menampilkan data " + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Function dataDGVTrxSpesifikTanggal() As DataView Implements InterfaceTransaksi.dataDGVTrxSpesifikTanggal
        Try
            Using DA = New OleDbDataAdapter("DataTransaksiTanggal", conn)
                DA.SelectCommand.CommandType = CommandType.StoredProcedure
                DA.SelectCommand.Parameters.AddWithValue("@waktuAwal", EntitasTransaksi.proWaktu + " 00:00")
                DA.SelectCommand.Parameters.AddWithValue("@waktuAkhir", EntitasTransaksi.proWaktu + " 23:59")
                DS = New DataSet
                DA.Fill(DS, "transaksi")
                Dim grid As New DataView(DS.Tables("transaksi"))
                Return grid
            End Using

        Catch ex As Exception
            Throw New Exception(ex.Message)
            MsgBox("Gagal menampilkan data " + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function


    Public Function hapusTransaksi(ob As Object) As OleDbCommand Implements InterfaceTransaksi.hapusTransaksi
        Dim query = "DELETE transaksi WHERE id_transaksi = '" + ob + "' "
        Try
            CMD = New OleDbCommand(query, conn)
            MsgBox("Berhasil Menghapus Transaksi!", MsgBoxStyle.Information, "Sukses!")
            CMD.ExecuteNonQuery()
            Return CMD
        Catch ex As Exception
            Throw New Exception(ex.Message)
            MsgBox("Gagal Menghapus Transaksi " + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

End Class
