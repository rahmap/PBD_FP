Public Class EntPelanggan
    Private id_pelanggan, id_transaksi As String

    Public Property proIDPelanggan As String
        Get
            Return id_pelanggan
        End Get
        Set(value As String)
            id_pelanggan = value
        End Set
    End Property

    Public Property proIDTransaksi As String
        Get
            Return id_transaksi
        End Get
        Set(value As String)
            id_transaksi = value
        End Set
    End Property
End Class
