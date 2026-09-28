Namespace My
    ' Eventos de aplicação (Startup, Shutdown, StartupNextInstance, UnhandledException, NetworkAvailabilityChanged).
    Partial Friend Class MyApplication

        ''' <summary>
        ''' Antes de abrir o frmAcesso: define a conexão com o banco para o sistema inteiro
        ''' (arquivo local criptografado, ou pede na primeira execução). Ver modConexao.
        ''' </summary>
        Private Sub MyApplication_Startup(sender As Object, e As ApplicationServices.StartupEventArgs) Handles Me.Startup
            If Not PrepararConexao() Then e.Cancel = True
        End Sub

    End Class
End Namespace
