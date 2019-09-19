Public Class ContPelanggan

    Public Function tampilDGVPelanggan() As DataView
        Try
            DA = New OleDb.OleDbDataAdapter("SELECT * FROM pelanggan", conn)
            DS = New DataSet
            DA.Fill(DS, "pelanggan")
            Dim grid As New DataView(DS.Tables("pelanggan"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
            MsgBox("Gagal menampilkan data " + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Function tampilDGVTransaksi() As DataView
        Try
            Using DA = New OleDb.OleDbDataAdapter("DataTransaksiPelanggan", conn)
                DA.SelectCommand.CommandType = CommandType.StoredProcedure
                DA.SelectCommand.Parameters.AddWithValue("@id_pelanggan", EntitasPel.proIDPelanggan)
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

    Public Function hapusPelanggan(ob As Object) As OleDb.OleDbCommand
        Try
            Dim q = "DELETE FROM transaksi WHERE id_pelanggan = '" + ob + "' "
            CMD = New OleDb.OleDbCommand(q, conn)
            CMD.ExecuteNonQuery()
            CMD = New OleDb.OleDbCommand("DELETE FROM pelanggan WHERE id_pelanggan = '" + ob + "' ", conn)
            If CMD.ExecuteNonQuery = 1 Then
                MsgBox("Hapus Pelanggan berserta transaksinya Berhasil!", MsgBoxStyle.Information, "Berhasil!")
            End If
            Return CMD
        Catch ex As Exception
            Throw New Exception(ex.Message)
            MsgBox("Gagal Menghapus Pelanggan " + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

End Class
