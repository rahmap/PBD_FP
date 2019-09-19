Public Class EntTransaksi
    Private waktu, IDTrx As String

    Public Property proIDTrx As String
        Get
            Return IDTrx
        End Get
        Set(value As String)
            IDTrx = value
        End Set
    End Property

    Public Property proWaktu As String
        Get
            Return waktu
        End Get
        Set(value As String)
            waktu = value
        End Set
    End Property
End Class
