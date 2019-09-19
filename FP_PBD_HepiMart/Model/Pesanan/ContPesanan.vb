Imports System.Data.OleDb

Public Class ContPesanan : Implements InterfacePesanan

    Public idPel, idTrx As String

    Public Sub insertPesanan() Implements InterfacePesanan.insertPesanan
        EntitasPesanan.proRandId = rand.Next(1, 999)
        idTrx = EntitasPesanan.getIDTransaksi
        Call getIDDriver()
        Call getIDMenu()
        Using CMD = New OleDbCommand("InsertPesanan", conn)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@idTrx", idTrx)
            CMD.Parameters.AddWithValue("@waktu", EntitasPesanan.proWaktu)
            CMD.Parameters.AddWithValue("@totHarga", EntitasPesanan.proTotHarga)
            CMD.Parameters.AddWithValue("@idPel", idPel)
            CMD.Parameters.AddWithValue("@id_menu", EntitasPesanan.proIdMenu)
            CMD.Parameters.AddWithValue("@jmlPesan", EntitasPesanan.proJml)
            CMD.Parameters.AddWithValue("@id_admin", EntitasAdmin.proID)
            CMD.Parameters.AddWithValue("@id_driver", EntitasPesanan.proIdDriver)
            If CMD.ExecuteNonQuery = 1 Then
                MsgBox("Berhasil Input Data Pesanan!", MsgBoxStyle.Information, "Info")
            Else
                MsgBox("Gagal Input Data!", MsgBoxStyle.Critical, "Error")
            End If
            CMD.CommandType = CommandType.Text
        End Using
    End Sub

    Public Sub inputPelanggan() Implements InterfacePesanan.inputPelanggan
        EntitasPesanan.proRandId = rand.Next(1, 999)
        idPel = EntitasPesanan.getIDPelanggan
        Using CMD = New OleDbCommand("InsertPelanggan", conn)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@idPel", idPel)
            CMD.Parameters.AddWithValue("@nama_pelanggan", EntitasPesanan.proNamaPlg)
            CMD.Parameters.AddWithValue("@telp_pelanggan", EntitasPesanan.proTlpPlg)
            CMD.Parameters.AddWithValue("@alamat_pelanggan", EntitasPesanan.proAlamatPlg)
            If CMD.ExecuteNonQuery = 1 Then
                MsgBox("Berhasil Input Data Pelanggan!", MsgBoxStyle.Information, "Informasi")
                EntitasPesanan.proRandId = rand.Next(1, 999)
            Else
                MsgBox("Gagal Input Data!", MsgBoxStyle.Critical, "Error")
            End If
            CMD.CommandType = CommandType.Text
        End Using

    End Sub

    Public Sub getIDDriver() Implements InterfacePesanan.getIDDriver
        Dim query = "SELECT * FROM driver WHERE nama_driver='" + EntitasPesanan.proNamaDriver + "' "
        CMD.Connection = conn
        CMD.CommandText = query
        DR = CMD.ExecuteReader()
        If DR.HasRows = True Then
            Try
                With DR
                    .Read()
                    EntitasPesanan.proIdDriver = .GetValue(0)
                End With
            Catch ex As Exception
                MsgBox("Error tak terduga " + ex.Message)
            End Try
        End If
        DR.Close()
    End Sub
    Public Sub getIDMenu() Implements InterfacePesanan.getIDMenu
        Dim queryMenu = "SELECT * FROM menu WHERE nama_menu='" + EntitasPesanan.proNamaMenu + "' "
        CMD.Connection = conn
        CMD.CommandText = queryMenu
        DR = CMD.ExecuteReader()
        If DR.HasRows = True Then
            Try
                With DR
                    .Read()
                    EntitasPesanan.proIdMenu = .GetValue(0)
                    EntitasPesanan.proSubHarga = .GetValue(3)
                End With
                EntitasPesanan.proTotHarga = EntitasPesanan.proJml * EntitasPesanan.proSubHarga
            Catch ex As Exception
                MsgBox("Error tak terduga " + ex.Message)
            End Try
        End If
        DR.Close()
    End Sub
    Public Function tampilDGVPesanan() As DataView Implements InterfacePesanan.tampilDGVPesanan
        Try
            Using DA = New OleDbDataAdapter("PesananPelanggan", conn)
                DA.SelectCommand.CommandType = CommandType.StoredProcedure
                DA.SelectCommand.Parameters.AddWithValue("@id_pelanggan", idPel)
                DS = New DataSet
                DA.Fill(DS, "transaksi")
                Dim grid As New DataView(DS.Tables("transaksi"))
                Return grid
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
            MsgBox("Gagal menampilkan data " + ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            'DA.SelectCommand.CommandType = CommandType.Text
        End Try
    End Function

    Public Sub getStokMenu() Implements InterfacePesanan.getStokMenu
        Try
            CMD = New OleDbCommand("SELECT stok FROM menu WHERE id_menu = '" + EntitasPesanan.proIdMenu + "' ", conn)

            If IsDBNull(CMD.ExecuteScalar()) = False Then
                EntitasPesanan.proStokMenu = CMD.ExecuteScalar().ToString
            Else
                EntitasPesanan.proStokMenu = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub getUpdateStok(ob As Object) Implements InterfacePesanan.getUpdateStok
        Dim stokBaru As Integer
        Try
            stokBaru = (Convert.ToInt32(EntitasPesanan.proStokMenu) - Convert.ToInt32(ob))
            CMD = New OleDbCommand("UpdateStok", conn)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@stokBaru", stokBaru.ToString)
            CMD.Parameters.AddWithValue("@idMenu", EntitasPesanan.proIdMenu)

            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Gagal Memperbarui stok menu " + ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            CMD.CommandType = CommandType.Text
        End Try
    End Sub

    Friend Function getListDriver() As OleDbCommand Implements InterfacePesanan.getListDriver
        CMD = New OleDbCommand("SELECT * FROM driver WHERE aktif = 1", conn)
        Return CMD
    End Function

    Friend Function getListMenu(ByVal jenis As String) As OleDbCommand Implements InterfacePesanan.getListMenu
        CMD = New OleDbCommand("select * from menu WHERE jenis_menu = '" + jenis + "' AND aktif = '1' ", conn)
        Return CMD
    End Function
End Class
