Imports System
Imports System.Reflection.Emit
Imports System.Security.Cryptography

Module Program
    Public Class Dobbelsteen
        Private intWaarde As Integer
        ' BELANGRIJK: Maak de Random-instantie één keer aan als Shared veld
        ' Dit zorgt ervoor dat alle dobbelstenen dezelfde, unieke generator gebruiken
        ' en voorkomt dat ze dezelfde 'willekeurige' getallen genereren.
        Private Shared generator As New Random()

        'sub gooi met AI gedaan, wist niet meer hoe
        Public Sub gooi()
            ' Moderne, leesbare VB.NET manier:
            intWaarde = generator.Next(1, 7)
            ' ^-- Minimum is inclusief, maximum is exclusief
        End Sub
        Public Function GeefWaarde() ' Geeft het private veld intWaarde terug
            Return intWaarde
        End Function

    End Class
    Sub Main(args As String())
        Dim zesOgen As New Dobbelsteen

        ' Eerste keer gooien
        zesOgen.gooi()
        Console.WriteLine("Eerste gooi: " & zesOgen.GeefWaarde())

        ' Tweede keer gooien
        zesOgen.gooi()
        Console.WriteLine("Tweede gooi: " & zesOgen.GeefWaarde())

        ' Derde keer gooien
        zesOgen.gooi()
        Console.WriteLine("Derde gooi: " & zesOgen.GeefWaarde())
    End Sub
End Module
