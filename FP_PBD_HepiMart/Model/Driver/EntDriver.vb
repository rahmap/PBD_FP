Public Class EntDriver

    Private nama, id, telp, randId As String

    Public Property proRandId As Integer
        Get
            Return randId
        End Get
        Set(value As Integer)
            randId = value
        End Set
    End Property
    Public Property proNama
        Get
            Return nama
        End Get
        Set(value)
            Me.nama = value
        End Set
    End Property
    Public ReadOnly Property getIDDriver As String
        Get
            Return "DRV-" + GenerateRandomString(4, True) + "-" + CStr(proRandId)
        End Get
    End Property
    Public Property proID
        Get
            Return id
        End Get
        Set(value)
            Me.id = value
        End Set
    End Property
    Public Property proTelp
        Get
            Return telp
        End Get
        Set(value)
            Me.telp = value
        End Set
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
