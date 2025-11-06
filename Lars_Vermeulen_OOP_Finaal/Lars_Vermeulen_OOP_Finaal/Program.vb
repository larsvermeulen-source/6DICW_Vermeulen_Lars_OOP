Imports System

Module Program
    Class Bestelling
        Protected strKlantNaam As String
        Protected dblTotaalBedrag As Double

        Public Sub New(strKlantNaam As String, dblTotaalBedrag As Double)
            Me.strKlantNaam = strKlantNaam
            Me.dblTotaalBedrag = dblTotaalBedrag
        End Sub

        Public Sub ToonBestelDetails()
            Console.WriteLine($"Klant met naam: {strKlantNaam}")
            Console.WriteLine($"Totaal bedrag van bestellingen: {dblTotaalBedrag}")
        End Sub

        Overridable Function BerekenVerzendkosten() As Double
            Return 5
        End Function
    End Class

    Class SnelleLevering
        Inherits Bestelling

        Private dblSpoedToeslag As Double

        Public Sub New(strKlantNaam As String, dblTotaalBedrag As Double)
            MyBase.New(strKlantNaam, dblTotaalBedrag)
            dblSpoedToeslag = 10
        End Sub

        Public Overrides Function BerekenVerzendkosten() As Double
            Return MyBase.BerekenVerzendkosten() + dblSpoedToeslag
        End Function
    End Class
    Class InternationaleBestelling
        Inherits Bestelling

        Private strLand As String

        Public Sub New(strKlantNaam As String, dblTotaalBedrag As Double, strLand As String)
            MyBase.New(strKlantNaam, dblTotaalBedrag)
            Me.strLand = strLand
        End Sub

        Public Function BerekenDouaneKosten() As Double
            Return dblTotaalBedrag * 0.1
        End Function

        Public Overrides Function BerekenVerzendkosten() As Double
            Return MyBase.BerekenVerzendkosten() + BerekenDouaneKosten()
        End Function
    End Class

    Class Verzendingen
        Protected strVerzendType As String

        Public Sub New(strVerzendType As String)
            Me.strVerzendType = strVerzendType
        End Sub

        Public Overridable Function BerekenVerzendKosten() As Double
            Return 3
        End Function
    End Class

    Class PakketVerzending
        Inherits Verzendingen

        Private strPakketgrootte As String

        Public Sub New(strVerzendType As String, strPakketgrootte As String)
            MyBase.New(strVerzendType)
            Me.strPakketgrootte = strPakketgrootte
        End Sub

        Public Overrides Function BerekenVerzendKosten() As Double
            If strPakketgrootte.Equals("klein") Then
                Return 3
            ElseIf strPakketgrootte.Equals("middelgroot") Then
                Return 5
            ElseIf strPakketgrootte.Equals("groot") Then
                Return 8
            Else
                Return 8
            End If
        End Function
    End Class

    Class Luchtpost
        Inherits Verzendingen

        Private dblLuchttarief As Double

        Public Sub New(strVerzendType As String)
            MyBase.New(strVerzendType)
            dblLuchttarief = 15
        End Sub

        Public Overrides Function BerekenVerzendKosten() As Double
            Return MyBase.BerekenVerzendKosten() + dblLuchttarief
        End Function
    End Class
    Sub Main(args As String())

        Dim objJansen As New SnelleLevering("Jansen", 100)
        Dim objMartinez As New InternationaleBestelling("Martinez", 200, "Frankrijk")
        Dim objPakket As New PakketVerzending("Standaard", "middelgroot")
        Dim objLucht As New Luchtpost("Luchtpost")


        objJansen.ToonBestelDetails()
        Console.WriteLine($"Totale verzenkosten zijn: {objJansen.BerekenVerzendkosten}")

        Console.WriteLine()

        objMartinez.ToonBestelDetails()
        Console.WriteLine($"dounejkosten zijn:{objMartinez.BerekenDouaneKosten()}")
        Console.WriteLine($"Totale verzendkosten zijn: {objMartinez.BerekenVerzendkosten}")

        Console.WriteLine()

        Console.WriteLine($"Verzendkosten voor pakket met grootte: .. is ({objPakket.BerekenVerzendKosten()} euro)")
        Console.WriteLine($"Luchtpost ({objLucht.BerekenVerzendKosten()} euro)")


    End Sub

End Module
