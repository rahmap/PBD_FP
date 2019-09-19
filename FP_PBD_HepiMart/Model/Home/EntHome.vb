Public Class EntHome
    Private totPendapatan, totTrx, todayPendapatan, todayTrx As String

    Public Property proTodayPendapatan As String
        Get
            Return todayPendapatan
        End Get
        Set(value As String)
            todayPendapatan = value
        End Set
    End Property

    Public Property proTodayTrx As String
        Get
            Return todayTrx
        End Get
        Set(value As String)
            todayTrx = value
        End Set
    End Property

    Public Property proTotPendapatan As String
        Get
            Return totPendapatan
        End Get
        Set(value As String)
            totPendapatan = value
        End Set
    End Property

    Public Property proTotTrx As String
        Get
            Return totTrx
        End Get
        Set(value As String)
            totTrx = value
        End Set
    End Property
End Class
