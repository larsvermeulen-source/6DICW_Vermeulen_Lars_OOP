Imports System

Module Program
    Class Salamander
        Protected intAantalPoten As Integer
        Protected intStaartLengteInCm As Integer
        Protected dblLongCapaciteitInLiter As Double
        Public Sub New()
            Me.intAantalPoten = 4
            Me.intStaartLengteInCm = 6
            Me.dblLongCapaciteitInLiter = 0.5
        End Sub
        Public Function geefAantalPoten()
            Return intAantalPoten
        End Function
        Public Function geefLongCapaciteit()
            Return dblLongCapaciteitInLiter
        End Function
    End Class
    Class Tijger
        Inherits Salamander
        Protected strHaarKleur As String
        Public Sub New()
            MyBase.New()
            Me.strHaarKleur = "zwart"
            Me.dblLongCapaciteitInLiter = 2
        End Sub
        Public Function geefHaarKleur()
            Return strHaarKleur
        End Function
    End Class
    Class Mens
        Inherits Tijger
        Private intAantalBenen As Integer
        Private intAantalArmen As Integer
        Public Sub New(intAantalBenen As Integer, intAantalArmen As Integer, strHaarKleur As String)
            MyBase.New()
            Me.intAantalBenen = intAantalBenen
            Me.intAantalArmen = intAantalArmen
            Me.intAantalPoten = 0
            Me.intStaartLengteInCm = 0
            Me.dblLongCapaciteitInLiter = 7
            Me.strHaarKleur = strHaarKleur
        End Sub

        Public Function geefAantalArmenEnBenen()
            Return intAantalArmen And intAantalBenen
        End Function
    End Class
    Sub Main(args As String())
        Dim objHank As New Salamander()
        Dim objBagheera As New Tijger()
        Dim objMowgli As New Mens(2, 2, "Paars")

        Console.WriteLine($"De salamander heeft {objHank.geefAantalPoten()} poten")
        Console.WriteLine($"De Tijger heeft {objBagheera.geefAantalPoten()} poten")
        Console.WriteLine($"De Mens heeft {objMowgli.geefAantalPoten()} poten")
        Console.WriteLine("")
        Console.WriteLine($"De Tijger heeft {objBagheera.geefHaarKleur()} als haarkleur")
        Console.WriteLine($"De Mens heeft {objMowgli.geefHaarKleur()} als haarkleur")
        Console.WriteLine("")
        Console.WriteLine($"De Salamander heeft {objHank.geefLongCapaciteit()} als longcapaciteit")
        Console.WriteLine($"De Tijger heeft {objBagheera.geefLongCapaciteit()} als longcapaciteit")
        Console.WriteLine($"De Mens heeft {objMowgli.geefLongCapaciteit()} als longcapaciteit")

    End Sub
End Module
