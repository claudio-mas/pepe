' Verificacao de geometria do GerencialNovo, sem banco.
' Monta o relatorio vazio, gera o documento e exporta PDF.
' Compilado dentro de bin\Debug para que o probing do CLR ache o DevExpress.

Imports System
Imports System.IO

Module VerificaLayout

    Function Main(args As String()) As Integer
        Dim comBoutique As Boolean = (args.Length > 0 AndAlso args(0) = "bou")
        Dim saida As String = Path.Combine(
            Path.GetDirectoryName(Reflection.Assembly.GetExecutingAssembly().Location),
            If(comBoutique, "GerencialNovo_bou.pdf", "GerencialNovo.pdf"))

        Try
            Dim r As New Pepe.GerencialNovo()
            r.MontarLayout(comBoutique)
            r.CreateDocument()

            Console.WriteLine("PaperKind    : {0}", r.PaperKind)
            Console.WriteLine("Landscape    : {0}", r.Landscape)
            Console.WriteLine("Pagina (0,1mm): {0} x {1}", r.PageWidth, r.PageHeight)
            Console.WriteLine("ReportUnit   : {0}", r.ReportUnit)
            Console.WriteLine("Boutique     : {0}", comBoutique)
            Console.WriteLine("PAGINAS      : {0}", r.Pages.Count)
            Console.WriteLine("")

            Dim somaBandas As Single = 0
            For Each b As DevExpress.XtraReports.UI.Band In r.Bands
                Console.WriteLine("  banda {0,-14} altura {1,8:N1}", b.Name, b.HeightF)
                somaBandas += b.HeightF
            Next
            Console.WriteLine("  {0,-20} {1,8:N1}   (util A4 = 2810)", "SOMA", somaBandas)
            Console.WriteLine("")

            ' Nenhum controle pode passar da largura util de 1900
            Const LIMITE As Single = 1900.0F
            Dim estouros As Integer = 0
            For Each b As DevExpress.XtraReports.UI.Band In r.Bands
                For Each c As DevExpress.XtraReports.UI.XRControl In b.Controls
                    Dim dir As Single = c.LocationF.X + c.WidthF
                    If dir > LIMITE + 0.5F Then
                        Console.WriteLine("  ESTOURA {0}/{1}: x={2:N1} w={3:N1} -> {4:N1}",
                                          b.Name, c.Name, c.LocationF.X, c.WidthF, dir)
                        estouros += 1
                    End If
                Next
            Next
            Console.WriteLine("OVERFLOW HORIZ.: {0}", If(estouros = 0, "nenhum", estouros & " controle(s)"))

            ' Com WordWrap=False, texto que nao cabe e CORTADO em silencio.
            ' Mede cada rotulo e denuncia os que nao cabem na propria largura.
            Dim cortados As Integer = 0
            Using bmp As New System.Drawing.Bitmap(1, 1)
                Using g = System.Drawing.Graphics.FromImage(bmp)
                    g.PageUnit = System.Drawing.GraphicsUnit.Millimeter
                    For Each b As DevExpress.XtraReports.UI.Band In r.Bands
                        For Each c As DevExpress.XtraReports.UI.XRControl In b.Controls
                            Dim lbl = TryCast(c, DevExpress.XtraReports.UI.XRLabel)
                            If lbl Is Nothing OrElse String.IsNullOrEmpty(lbl.Text) Then Continue For
                            Dim f = lbl.Font
                            Using gdi As New System.Drawing.Font(f.Name, f.Size, CType(f.Style, System.Drawing.FontStyle))
                                ' largura do texto em mm -> decimos de mm
                                Dim mm = g.MeasureString(lbl.Text, gdi, Integer.MaxValue,
                                                         System.Drawing.StringFormat.GenericTypographic).Width
                                Dim precisa = mm * 10.0F + 30.0F      ' + padding 15+15
                                If precisa > lbl.WidthF Then
                                    Console.WriteLine("  CORTA {0,-22} disp={1,6:N0} precisa={2,6:N0}  '{3}'",
                                                      lbl.Name, lbl.WidthF, precisa, lbl.Text)
                                    cortados += 1
                                End If
                            End Using
                        Next
                    Next
                End Using
            End Using
            Console.WriteLine("TEXTO CORTADO  : {0}", If(cortados = 0, "nenhum", cortados & " rotulo(s)"))

            If args.Length > 0 AndAlso args(args.Length - 1) = "dump" Then
                Console.WriteLine("")
                Console.WriteLine("--- controles (banda | idx | y | x | w | h | canGrow | wordWrap | texto) ---")
                For Each b As DevExpress.XtraReports.UI.Band In r.Bands
                    Dim i As Integer = 0
                    For Each c As DevExpress.XtraReports.UI.XRControl In b.Controls
                        Dim lbl = TryCast(c, DevExpress.XtraReports.UI.XRLabel)
                        Console.WriteLine("{0,-13}|{1,3}|{2,7:N0}|{3,7:N0}|{4,6:N0}|{5,5:N0}|{6,-5}|{7,-5}| {8}",
                            b.Name, i, c.LocationF.Y, c.LocationF.X, c.WidthF, c.HeightF,
                            c.CanGrow, If(lbl IsNot Nothing, lbl.WordWrap.ToString(), "-"),
                            If(lbl IsNot Nothing, "'" & lbl.Text & "'", "[" & c.GetType().Name & "]"))
                        i += 1
                    Next
                Next
            End If

            r.ExportToPdf(saida)
            Console.WriteLine("PDF          : {0}", saida)
            r.Dispose()
            Return 0

        Catch ex As Exception
            Console.WriteLine("FALHOU: {0}", ex.ToString())
            Return 1
        End Try
    End Function

End Module
