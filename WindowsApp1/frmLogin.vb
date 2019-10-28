Public Class frmLogin
    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Dim chamarlogin As New logins
        chamarlogin.consulta_login()
    End Sub
End Class
