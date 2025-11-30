Imports System

Module Program
    'Algemene Class die we overerven
    Public Class Dier
        Protected strNaam As String 'Een naam voor het dier
        Public Sub New(strNaam As String) 'Constructor
            Me.strNaam = strNaam
        End Sub
        Overridable Sub MaakGeluid()
            Console.WriteLine("")
        End Sub
    End Class

    'Overgerfde class hond van dier
    Public Class Hond
        Inherits Dier
        Public Sub New(strNaam As String) 'Niks veranderen
            MyBase.New(strNaam)
        End Sub

        Public Overrides Sub MaakGeluid() ' Methode overeveren en aanpassen
            Console.WriteLine("Kef Kef Kef KEF KEF!")
        End Sub
    End Class
    'Overgerfde class koe van dier
    Public Class Koe
        Inherits Dier
        Public Sub New(strNaam As String) 'Niks veranderen
            MyBase.New(strNaam)
        End Sub

        Public Overrides Sub MaakGeluid() ' Methode overeveren en aanpassen
            Console.WriteLine("Moe!")
        End Sub
    End Class

    Sub Main(args As String())
        ' 2 dieren aanmaken onder de sub classes
        Dim Keffer As New Hond("Rex")
        Dim Bella As New Koe("Bella")

        Keffer.MaakGeluid()
        Bella.MaakGeluid()
    End Sub
End Module