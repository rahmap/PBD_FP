Public Class Login

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim query = "SELECT * FROM adminn WHERE username='" + tbUsername.Text + "' AND pass='" + tbPassword.Text + "'"
        CMD.Connection = conn
        CMD.CommandText = query
        DR = CMD.ExecuteReader()
        If DR.HasRows = True Then
            MsgBox("Berhasil Login", MsgBoxStyle.Information, "Horayy!")
            Try
                With DR
                    .Read()
                    EntitasAdmin.proID = .GetValue(0)
                    EntitasAdmin.proNama = .GetValue(1)
                End With
            Catch ex As Exception
                MsgBox("Error tak terduga " + ex.Message)
            End Try
            DR.Close()
            Me.Hide()
            Home.Show()
        Else
            MsgBox("Gagal Login", MsgBoxStyle.Critical, "Error!")
            tbPassword.Clear()
            tbUsername.Clear()
            DR.Close()
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        konek()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

End Class
