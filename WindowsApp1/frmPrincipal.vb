Imports System.Data.SqlClient

Public Class frmPrincipal
    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        frmLogin.Close()
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        cadfuncionario.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        cadcliente.Show()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        cadveiculos.Show()
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        help.Show()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        carregando.Show()
        carregando.Timer1.Enabled = True
        ' Informação da Connection String 
        Dim myConnectionString As String =
       "server = DESKTOP-4FNEASF\SQLEXPRESS; DataBase = Banco; uid= sa; pwd= 123456"
        ' Ligação à base de dados 
        Using connection As New SqlConnection(myConnectionString)
            connection.Open()
            ' Indica o nome do Stored Procedure e que o tipo do comando 
            Dim command As New SqlCommand("uspBackup", connection)
            command.CommandType = CommandType.StoredProcedure
            ' Executa o comando e guarda o resultado no SqlDataReader 
            Dim reader As SqlDataReader = command.ExecuteReader()
            reader.Close()
            reader = Nothing
        End Using   'connection
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class