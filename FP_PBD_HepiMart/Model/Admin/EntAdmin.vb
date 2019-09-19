Public Class EntAdmin
    Private nama, id, username, password As String
    Public Property proNama As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property
    Public Property proID As String
        Get
            Return id
        End Get
        Set(value As String)
            id = value
        End Set
    End Property
    Public Property proUsername As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property
    Public Property proPassword As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property
End Class
