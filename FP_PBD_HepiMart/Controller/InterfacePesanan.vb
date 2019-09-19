Imports System.Data.OleDb

Public Interface InterfacePesanan
    Sub insertPesanan()
    Sub inputPelanggan()
    Function tampilDGVPesanan() As DataView
    Sub getIDDriver()
    Sub getIDMenu()
    Sub getStokMenu()
    Sub getUpdateStok(ob As Object)
    Function getListMenu(ByVal jenis As String) As OleDbCommand
    Function getListDriver() As OleDbCommand
End Interface