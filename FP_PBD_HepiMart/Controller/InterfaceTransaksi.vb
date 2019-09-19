Public Interface InterfaceTransaksi
    Function dataDGVTrx() As DataView
    Function hapusTransaksi(ob As Object) As OleDb.OleDbCommand
    Function dataDGVTrxSpesifikTanggal() As DataView
End Interface
