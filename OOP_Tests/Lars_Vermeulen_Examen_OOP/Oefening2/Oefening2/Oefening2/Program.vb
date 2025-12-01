Imports System

Module Program
    Public Class Organisme
        Protected strNaam As String 'Dit veld houdt de naam van het object bij
        Protected strLeeftijd As Integer 'Dit veld houdt de leeftijd van het object bij
        Overridable Sub Groei() 'Een methode die hier nog niks moet doen
        End Sub
        'Een methode voor de leeftijd aanmaken
        Public Sub GeefLeeftijd()
            If (strLeeftijd * 365) < 30 Then
                strLeeftijd = strLeeftijd * 365 'Je doet aantal jaren maal dagen in een jaar om aantal dagen uit te komen
                Console.WriteLine(strNaam & " is zo oud (in dagen): " & strLeeftijd)
            ElseIf strLeeftijd < 1 Then
                strLeeftijd = strLeeftijd * 52 'aantal jaren maal aantal weken in 1 jaar voor leeftijd in weken te weten
                Console.WriteLine(strNaam & " is zo oud (in weken): " & strLeeftijd)
            Else
                Console.WriteLine(strNaam & " is zo oud (in jaar): " & strLeeftijd)
            End If
        End Sub
    End Class
    Public Class Plant
        Inherits Organisme
        Protected dblHoogte As Double 'Nieuw veld aanmaken voor bij de methode Groei()
        Public Sub New(strNaam As String, strLeeftijd As Integer, dblHoogte As Double) 'Overerving
            MyBase.New()
            Me.dblHoogte = dblHoogte
            Me.strNaam = strNaam
            Me.strLeeftijd = strLeeftijd
        End Sub
        Public Overrides Sub Groei() 'Deze methode zorgt dat een plant zal groeien met 1 mm en roept de leeftijd op van de plant
            MyBase.Groei()
            dblHoogte += 0.001 'Met 1 mm groeien, maar staat in meter; 1mm = 0,001 m
            Console.WriteLine(strNaam & " is gegroeid, het is nu: " & dblHoogte & " meter hoog.")
            GeefLeeftijd()
        End Sub
        Overridable Sub FotoSynthese()
            Console.WriteLine(strNaam & " is bezig met fotosynthese!")
        End Sub
    End Class
    Public Class Boom
        Inherits Plant
        Private strTypeBlad As String 'Veld voor het blad soort bij te houden
        Public Sub New(strNaam As String, strLeeftijd As Integer, dblHoogte As Double, strTypeBlad As String) 'overerving
            MyBase.New(strNaam, strLeeftijd, dblHoogte)
            Me.strTypeBlad = strTypeBlad
        End Sub
        Public Overrides Sub Groei()  'Deze methode zorgt dat een plant zal groeien met 2 mm en roept de leeftijd op van de boom
            Console.WriteLine(strNaam & " is gegroeid met type blad: " & strTypeBlad)
            dblHoogte += 0.002
            Console.WriteLine("De nieuwe hoogte van de boom is: " & dblHoogte & " meter.")
            GeefLeeftijd()
        End Sub
    End Class
    Public Class Dier
        Inherits Organisme
        Protected strGeluid As String 'veld voor welk geluid het dier maakt
        Public Sub New(strNaam As String, strLeeftijd As Integer, strGeluid As String) 'overerving
            MyBase.New()
        End Sub
        Public Overrides Sub Groei() 'Groei aanpassen zodat het klopt voor dieren
            Console.WriteLine(strNaam & " is gegroeid, op een unieke dierlijke manier.")
        End Sub
        Overridable Sub MaakGeluid() 'Geluid wordt pas toegevoegd bij het diersoort zelf
        End Sub
    End Class
    Public Class Vogel
        Inherits Dier
        Private dblSpanwijdte As Double 'veld dat de spanwijdte van de vogels bijhoud
        Public Sub New(strNaam As String, strLeeftijd As Integer, strGeluid As String, dblSpanwijdte As Double) 'overerving
            MyBase.New(strNaam, strLeeftijd, strGeluid)
            Me.dblSpanwijdte = dblSpanwijdte
        End Sub
        Public Overrides Sub MaakGeluid() 'Geluid toevoegen
            MyBase.MaakGeluid()
            Console.WriteLine(strNaam & " met vleugelspanwijdte: " & dblSpanwijdte & " meter zingt: " & strGeluid)
        End Sub
    End Class
    Sub Main(args As String())
        'Volgende object heeft volgende velden: (Naam,Leeftijd,Hoogte)
        Dim objBlauweKorenBloem As New Plant("Blauwe korenbloem", 0.1, 0.05 / 100)
        'Volgende object heeft volgende velden: (Naam,Leeftijd,Hoogte,Type v/h blad)
        Dim objEik As New Boom("Eik", 50, 15, "Eivormig")
        'Volgende object heeft volgende velden: (Naam,Leeftijd,Geluid,Spanwijdte)
        Dim objAdelaar As New Vogel("Zeearend", 5, "Krijs", 2)

        objEik.Groei()
        objEik.FotoSynthese()
        Console.WriteLine("---")

        objBlauweKorenBloem.Groei()
        objBlauweKorenBloem.FotoSynthese()
        Console.WriteLine("---")

        objAdelaar.Groei()
        objAdelaar.MaakGeluid()
        Console.WriteLine("---")
    End Sub
End Module
