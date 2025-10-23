Imports System

Module Program
    Class Veelhoek
        Protected intAantalZijden As Integer
        Private random As New Random
        Public Sub New()
            Me.intAantalZijden = random.Next(3, 11)
        End Sub
        Public Function geefAantalZijden()
            Return intAantalZijden
        End Function

    End Class

    Class Vierhoek
        Inherits Veelhoek
        Private strBaasje As String
        Public Sub New()
            MyBase.New()
            intAantalZijden = 4
        End Sub

    End Class
    Sub Main(args As String())
        Dim objBob As New Vierhoek()
        Console.WriteLine(objBob.geefAantalZijden)
    End Sub
End Module