Public Class EntPesanan
    Private randId, jumlah, subHarga, totHarga As Integer
    Private stokMenu As String
    Private nama, noTelp, alamat, idTransaksi, idAdmin, idDriver, namaDriver, idMenu, namaMenu, idPlg As String
    Private waktu As String
    Public Property proNamaMenu As String
        Get
            Return namaMenu
        End Get
        Set(value As String)
            namaMenu = value
        End Set
    End Property
    Public Property proNamaDriver As String
        Get
            Return namaDriver
        End Get
        Set(value As String)
            namaDriver = value
        End Set
    End Property
    Public Property proIdDriver As String
        Get
            Return idDriver
        End Get
        Set(value As String)
            idDriver = value
        End Set
    End Property
    Public Property proIdMenu As String
        Get
            Return idMenu
        End Get
        Set(value As String)
            idMenu = value
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
    Public Property proAlamatPlg As String
        Get
            Return alamat
        End Get
        Set(value As String)
            alamat = value
        End Set
    End Property
    Public Property proTlpPlg As String
        Get
            Return noTelp
        End Get
        Set(value As String)
            noTelp = value
        End Set
    End Property
    Public Property proNamaPlg As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property
    Public Property proTotHarga As String
        Get
            Return totHarga
        End Get
        Set(value As String)
            totHarga = value
        End Set
    End Property
    Public Property proSubHarga As String
        Get
            Return subHarga
        End Get
        Set(value As String)
            subHarga = value
        End Set
    End Property
    Public Property proJml As String
        Get
            Return jumlah
        End Get
        Set(value As String)
            jumlah = value
        End Set
    End Property
    Public Property proRandId As Integer
        Get
            Return randId
        End Get
        Set(value As Integer)
            randId = value
        End Set
    End Property
    Public ReadOnly Property getIDTransaksi As String
        Get
            Return "TRX-" + GenerateRandomStringTrx(4, True) + "-" + CStr(proRandId)
        End Get
    End Property
    Public ReadOnly Property getIDPesanan As String
        Get
            Return "ORD-" + GenerateRandomStringOrd(4, True) + "-" + CStr(proRandId)
        End Get
    End Property
    Public ReadOnly Property getIDPelanggan As String
        Get
            Return "PLG-" + GenerateRandomStringPlg(4, True) + "-" + CStr(proRandId)
        End Get
    End Property

    Public Property proStokMenu As String
        Get
            Return stokMenu
        End Get
        Set(value As String)
            stokMenu = value
        End Set
    End Property

    Public Function GenerateRandomStringPlg(ByRef len As Integer, ByRef upper As Boolean) As String
        Dim rand As New Random()
        Dim allowableChars() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLOMNOPQRSTUVWXYZ0123456789".ToCharArray()
        Dim final As String = String.Empty
        For i As Integer = 0 To len - 1
            final += allowableChars(rand.Next(allowableChars.Length - 1))
        Next

        Return IIf(upper, final.ToUpper(), final)
    End Function
    Public Function GenerateRandomStringOrd(ByRef len As Integer, ByRef upper As Boolean) As String
        Dim rand As New Random()
        Dim allowableChars() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLOMNOPQRSTUVWXYZ0123456789".ToCharArray()
        Dim final As String = String.Empty
        For i As Integer = 0 To len - 1
            final += allowableChars(rand.Next(allowableChars.Length - 1))
        Next

        Return IIf(upper, final.ToUpper(), final)
    End Function
    Public Function GenerateRandomStringTrx(ByRef len As Integer, ByRef upper As Boolean) As String
        Dim rand As New Random()
        Dim allowableChars() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLOMNOPQRSTUVWXYZ0123456789".ToCharArray()
        Dim final As String = String.Empty
        For i As Integer = 0 To len - 1
            final += allowableChars(rand.Next(allowableChars.Length - 1))
        Next

        Return IIf(upper, final.ToUpper(), final)
    End Function
End Class
