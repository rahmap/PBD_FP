Public Class EntMenu
    Private nama, jenis, id, cari, randId As String
    Private stok, harga As Integer
    Private gambar As Image
    Private dbGambar As Byte
    Public Property proGambar As Image
        Get
            Return gambar
        End Get
        Set(value As Image)
            gambar = value
        End Set
    End Property
    Public Property proGambarDB As Byte
        Get
            Return dbGambar
        End Get
        Set(value As Byte)
            dbGambar = value
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
    Public Property proCari() As String
        Get
            Return cari
        End Get
        Set(value As String)
            cari = value
        End Set
    End Property
    Public Property proID() As String
        Get
            Return id
        End Get
        Set(value As String)
            id = value
        End Set
    End Property

    Public Property proNama() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property

    Public Property proJenis() As String
        Get
            Return jenis
        End Get
        Set(value As String)
            jenis = value
        End Set
    End Property

    Public Property proHarga() As String
        Get
            Return harga
        End Get
        Set(value As String)
            harga = value
        End Set
    End Property

    Public Property proStok() As String
        Get
            Return stok
        End Get
        Set(value As String)
            stok = value
        End Set
    End Property
    Public ReadOnly Property getIDMenu As String
        Get
            Return "MENU-" + GenerateRandomString(4, True) + "-" + CStr(proRandId)
        End Get
    End Property
    Public Function GenerateRandomString(ByRef len As Integer, ByRef upper As Boolean) As String
        Dim rand As New Random()
        Dim allowableChars() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLOMNOPQRSTUVWXYZ0123456789".ToCharArray()
        Dim final As String = String.Empty
        For i As Integer = 0 To len - 1
            final += allowableChars(rand.Next(allowableChars.Length - 1))
        Next

        Return IIf(upper, final.ToUpper(), final)
    End Function

End Class
