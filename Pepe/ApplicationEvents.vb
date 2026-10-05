Namespace My
    ' Eventos de aplicação (Startup, Shutdown, StartupNextInstance, UnhandledException, NetworkAvailabilityChanged).
    Partial Friend Class MyApplication

        ''' <summary>
        ''' Antes de abrir o frmAcesso: define a conexão com o banco para o sistema inteiro
        ''' (arquivo local criptografado, ou pede na primeira execução). Ver modConexao.
        ''' </summary>
        Private Sub MyApplication_Startup(sender As Object, e As ApplicationServices.StartupEventArgs) Handles Me.Startup
            If Not PrepararConexao() Then e.Cancel = True

            ' O validador de SQL do DevExpress 25.2 confunde a função REPLACE( com o comando
            ' REPLACE INTO e recusa queries legítimas (PeçasEmEstoqueNovo, PeçasReg). As queries
            ' ficam fixas nos relatórios e o usuário não edita SQL, então a validação é dispensável.
            DevExpress.DataAccess.Sql.SqlDataSource.DisableCustomQueryValidation = True
        End Sub

    End Class
End Namespace
