Imports System.Data.OleDb

Public Class ContFTM : Implements InterfaceFTM

    Public Function aktifMenu(ob As Object) As OleDbCommand Implements InterfaceFTM.aktifMenu
        Try
            Using CMD = New OleDbCommand("UpdateStatusMenu", conn)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@id_menu", ob.ToString)
                CMD.Parameters.AddWithValue("@status", "1")
                If CMD.ExecuteNonQuery = 1 Then
                    MsgBox("Berhasil Meng Aktifkan Menu", MsgBoxStyle.Information, "Informasi")
                End If
            End Using

        Catch ex As Exception
            MsgBox("Gagal Mengaktifkan Menu " + ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            CMD.CommandType = CommandType.Text
        End Try
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InterfaceFTM.tampilData
        Try
            'id_menu, nama_menu, jenis_menu, harga_menu, stok
            DA = New OleDbDataAdapter("SELECT * FROM [viewMenuNonaktif] ", conn)
            DS = New DataSet
            DA.Fill(DS, "menu")
            Dim grid As New DataView(DS.Tables("menu"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
            MsgBox("Gagal menampilkan data " + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
End Class
