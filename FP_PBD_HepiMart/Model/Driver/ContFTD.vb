Imports System.Data.OleDb

Public Class ContFTD : Implements InterfaceFTD

    Public Function aktifDriver(ob As Object) As OleDbCommand Implements InterfaceFTD.aktifDriver
        Try
            'Dim query = "UPDATE driver SET aktif = '1' WHERE id_driver = '" + ob + "' "
            CMD = New OleDbCommand("UpdateStatusDriver", conn)
            With CMD
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@id_driver", ob.ToString)
                .Parameters.AddWithValue("@status", "1")
                If .ExecuteNonQuery = 1 Then
                    MsgBox("Berhasil Mengaktifkan Driver", MsgBoxStyle.Information, "Informasi")
                End If
            End With
        Catch ex As Exception
            MsgBox("Gagal Mengaktifkan Driver " + ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            CMD.CommandType = CommandType.Text
        End Try

        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InterfaceFTD.tampilData
        Try
            DA = New OleDbDataAdapter("SELECT * FROM [viewDriverNonaktif]", conn)
            DS = New DataSet
            DA.Fill(DS, "driver")
            Dim grid As New DataView(DS.Tables("driver"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
            MsgBox("Gagal menampilkan data " + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
End Class
