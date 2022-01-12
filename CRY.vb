Class Padrão
    Class TrocaDeCésar
        Enum Sentido As Integer
            Acima = 1
            Abaixo = -1
        End Enum
        Public Shared Function Criptografar(ByVal Texto As String, ByVal fluxo As Sentido, _
                                            ByVal Valor As Integer) As String
            On Error GoTo Erro
            Dim r As String = ""
            For Each c As Char In Texto
                r &= Chr(Asc(c) + (fluxo * Valor))
            Next
            Return r
Erro:
            Console.WriteLine("Não foi possível criptografar a expressão.")
        End Function
    End Class
End Class

Module CRY

    Sub Main()
        Dim tx As String
        Dim sc As Integer
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("SISTEMA DE CRIPTOGRAFIA NEW CRIPT")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine()
        Console.WriteLine("Texto para criptografar:")
        tx = Trim(Console.ReadLine())
        Console.WriteLine()
        Console.WriteLine("Selecione um sistema de criptografia:")
        Console.WriteLine("1. Troca de César")
        Console.WriteLine()
        sc = Int(Trim(Console.ReadLine))
        Console.WriteLine()
        Console.WriteLine("Resultado:")
        Console.WriteLine(Padrão.TrocaDeCésar.Criptografar(tx, 1, 1))
        Console.ReadKey()
    End Sub

End Module
