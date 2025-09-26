Imports System

Module Program

    Class Voetballer
        Public StrNaam As String
        Public IntLeeftijd As Integer
        Public IntAantalGeleKaarten As Integer = 0


        Sub NaarKleedkamer()
            If IntAantalGeleKaarten > 1 Then
                Console.WriteLine("Moet ik naar de kleedkamer: KLEEDKAMER")
            Else
                Console.WriteLine("Moet ik naar de kleedkamer: SPELEN")
            End If
        End Sub
        Public Sub GeefKaart()
            Me.IntAantalGeleKaarten += 1
            If IntAantalGeleKaarten = 1 Then
                Console.WriteLine("Ik geef een kaart")
            Else
                Console.WriteLine("Ik geef nog een kaart")
            End If
        End Sub

    End Class
    Sub Main(args As String())
        Dim objMessi As New Voetballer()
        objMessi.NaarKleedkamer()
        objMessi.GeefKaart()
        objMessi.GeefKaart()
        objMessi.NaarKleedkamer()
    End Sub
End Module
