Imports System.Data.OleDb

Module koneksi
    Public DS As New DataSet
    Public conn As New OleDbConnection
    Public DR As OleDbDataReader
    Public CMD As New OleDbCommand
    Public DA As New OleDbDataAdapter

    Public Sub konek()
        If conn.State = ConnectionState.Closed Then
            'Dim myString As String = "server=" & server & ";user=" & user & ";password=" & pass & ";database=" & db
            Dim str As String = "Provider=SQLNCLI11;Data Source=DESKTOP-KSR30U7\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=PBD_FIX"
            Try
                conn.ConnectionString = str
                conn.Open()
            Catch ex As Data.SqlClient.SqlException
                MessageBox.Show("Koneksi Gagal" & vbCrLf & "Mohon cek apakah server sudah siap!", "Koneksi ke server", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    Public Sub disconnect()
        Try
            conn.Close()
        Catch ex As System.Data.SqlClient.SqlException
            MsgBox("Error! " + ex.Message)
        End Try
    End Sub
End Module
