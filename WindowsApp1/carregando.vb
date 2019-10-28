Public Class carregando
    Private Sub carregando_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 1
        lblBackup.Text = ProgressBar1.Value & "% " & ""

        If ProgressBar1.Value >= 100 Then
            Timer1.Enabled = False
            MsgBox("Backup Realizado com sucesso!!!", MsgBoxStyle.Information, "Informação")
            Me.Close()
        End If
    End Sub
End Class