Imports System.Data.OleDb

Public Class ContMenu : Implements InterfaceMenu

    Public Function cariMenu() As DataView Implements InterfaceMenu.cariMenu
        Try
            Using DA = New OleDbDataAdapter("CariMenu", conn)
                DA.SelectCommand.CommandType = CommandType.StoredProcedure
                DA.SelectCommand.Parameters.AddWithValue("@nama_menu", EntitasMenu.proCari.ToLower)
                DS = New DataSet
                DA.Fill(DS, "menu")
                Dim grid As New DataView(DS.Tables("menu"))
                Return grid
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
            MsgBox("Gagal menampilkan data " + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Function

    Public Function hapusMenu(ob As Object) As OleDbCommand Implements InterfaceMenu.hapusMenu
        Try
            Using CMD = New OleDbCommand("UpdateStatusMenu", conn)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@id_menu", ob.ToString)
                CMD.Parameters.AddWithValue("@status", "0")
                If CMD.ExecuteNonQuery = 1 Then
                    MsgBox("Berhasil Meng Nonaktifkan Menu", MsgBoxStyle.Information, "Informasi")
                End If
            End Using
        Catch ex As Exception
            MsgBox("Gagal Meng Nonaktifkan Menu " + ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            CMD.CommandType = CommandType.Text
        End Try
        Return CMD
    End Function

    Public Sub insertMenu() Implements InterfaceMenu.insertMenu
        EntitasMenu.proRandId = rand.Next(1, 999)
        Try
            CMD = New OleDbCommand("CekDuplikatMenu", conn)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@nama_menu", EntitasMenu.proNama.ToLower)
            DR = CMD.ExecuteReader()
            If DR.HasRows Then
                MsgBox("Nama menu sudah ada!", MsgBoxStyle.Critical)
            Else
                Using CMD = New OleDbCommand("InsertDataMenu", conn)
                    CMD.CommandType = CommandType.StoredProcedure
                    CMD.Parameters.AddWithValue("@id_menu", EntitasMenu.getIDMenu)
                    CMD.Parameters.AddWithValue("@nama_menu", EntitasMenu.proNama)
                    CMD.Parameters.AddWithValue("@jenis_menu", EntitasMenu.proJenis)
                    CMD.Parameters.AddWithValue("@harga_menu", EntitasMenu.proHarga)
                    CMD.Parameters.AddWithValue("@stok", EntitasMenu.proStok)
                    If CMD.ExecuteNonQuery = 1 Then
                        MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Informasi")
                    End If
                End Using
            End If
        Catch ex As Exception
            MsgBox("Data gagal disimpan" + ex.Message, MsgBoxStyle.Critical)
        Finally
            DR.Close()
            CMD.CommandType = CommandType.Text
        End Try
    End Sub

    Public Function tampilMenu() As DataView Implements InterfaceMenu.tampilMenu
        Try
            'id_menu, nama_menu, jenis_menu, harga_menu, stok
            DA = New OleDb.OleDbDataAdapter("SELECT * FROM [viewMenuAktif] ", conn)
            DS = New DataSet
            DA.Fill(DS, "menu")
            Dim grid As New DataView(DS.Tables("menu"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
            MsgBox("Gagal menampilkan data " + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Sub updateMenu() Implements InterfaceMenu.updateMenu
        Try
            CMD.Connection = conn
            CMD.CommandText = "UPDATE menu SET stok = '" + EntitasMenu.proStok + "' WHERE id_menu = '" + EntitasMenu.proID + "' "
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Data gagal diupdate" + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Sub stok100()
        Try
            Using CMD = New OleDbCommand("EditStokMenu", conn)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@jml", 100)
                CMD.ExecuteNonQuery()
                MsgBox("Berhasil memperbaruhi semua Stok menu menjadi 100!", MsgBoxStyle.Information, "Informasi")
            End Using
        Catch ex As Exception
            MsgBox("Data gagal diupdate " + ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            CMD.CommandType = CommandType.Text
        End Try
    End Sub

    Friend Sub stok0()
        Try
            Using CMD = New OleDbCommand("EditStokMenu", conn)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@jml", 0)
                CMD.ExecuteNonQuery()
                MsgBox("Berhasil memperbaruhi semua Stok menu menjadi 0!", MsgBoxStyle.Information, "Informasi")
            End Using
        Catch ex As Exception
            MsgBox("Data gagal diupdate " + ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            CMD.CommandType = CommandType.Text
        End Try
    End Sub
End Class
