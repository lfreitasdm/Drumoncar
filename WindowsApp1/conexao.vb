Imports System.Data.SqlClient

Public Class conexao

    Public cn As New SqlConnection
    Public status As String = ""
    Public Sub conectar()
        Dim stringconexao As String = ""
        stringconexao = "server = DESKTOP-4FNEASF\SQLEXPRESS; DataBase = Banco; uid= sa; pwd= 123456"
        cn.ConnectionString = stringconexao
        cn.open
    End Sub

    Public Sub desconectar()
        cn.Close()
        status = "Conexão Fechada"
    End Sub

End Class
