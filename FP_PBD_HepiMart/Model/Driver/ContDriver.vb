Public Class ContDriver : Implements InterfaceDriver

    Public Sub hapusDriver() Implements InterfaceDriver.hapusDriver
        Try
            CMD = New OleDb.OleDbCommand("updateStatusDriver", conn)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@id_driver", EntitasDriver.proID)
            CMD.Parameters.AddWithValue("@status", "0")
            If CMD.ExecuteNonQuery = 1 Then
                MsgBox("Berhasil Meng Nonaktifkan driver bernama " + EntitasDriver.proNama, MsgBoxStyle.Information, "Success")
            End If
        Catch ex As Exception
            MsgBox("Gagal Meng Nonaktifkan Driver " + ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            CMD.CommandType = CommandType.Text
        End Try
    End Sub

    Public Sub insertDriver() Implements InterfaceDriver.insertDriver
        Try
            EntitasDriver.proRandId = rand.Next(1, 999)
            CMD = New OleDb.OleDbCommand("InsertDriver", conn)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@id_driver", EntitasDriver.getIDDriver)
            CMD.Parameters.AddWithValue("@nama_driver", EntitasDriver.proNama)
            CMD.Parameters.AddWithValue("@telp", EntitasDriver.proTelp)
            CMD.ExecuteNonQuery()
            MsgBox("Berhasil Manambakan Driver", MsgBoxStyle.Information, "Informasi")
        Catch ex As Exception

        Finally
            CMD.CommandType = CommandType.Text
        End Try

    End Sub

    Public Function tampilDriver() As DataView Implements InterfaceDriver.tampilDriver
        Try
            DA = New OleDb.OleDbDataAdapter("SELECT * FROM [viewDriverAktif]", conn)
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
