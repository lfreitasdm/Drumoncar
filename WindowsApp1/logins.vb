Imports System.Data.SqlClient

Public Class logins
    Public Sub consulta_login()
        Dim cx As New conexao
        Dim sql As String = ""
        cx.conectar()
        sql = "Select * from Funcionarios where login='" & frmLogin.txtLogin.Text & "' And Senha= '" & frmLogin.txtSenha.Text & "'"
        Dim cmd As New SqlCommand
        cmd.CommandText = sql
        cmd.Connection = cx.cn

        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            frmLogin.Visible = False
            frmPrincipal.Show()

        Else
            MessageBox.Show("Login ou Senha incorretos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
