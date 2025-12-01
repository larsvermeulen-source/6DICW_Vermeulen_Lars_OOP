Imports System

Module Program
    Public Class Deck
        '2, 3, 4, 5, 6, 7, 8, 9, 10, 11(Boer), 12(Dame), 13(Heer), 14(Aas)
        Private intCurrentValue As Integer = -1
        'Harten, Ruiten, Schoppen, Klaveren
        Private intCurrentSuit As Integer

        Public Sub ShowNextCard() 'Deze Methode toont de naam van de volgende kaart in het deck
            IncrementCard()
            Dim suits As String() = {"Harten", "Ruiten", "Schoppen", "Klaveren"}
            Dim values As String() = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Boer", "Dame", "Heer", "Aas"}
            Console.WriteLine(values(intCurrentValue) & suits(intCurrentSuit)) 'Error van de value, suit werkt ook niet perfect
        End Sub
        Private Sub IncrementCard() 'Deze methode berekent de volgende kaart op basis van intCurrentSuit en IntCurrentValue
            intCurrentSuit = 0 ' Bij harten beginnen
            intCurrentValue += 1 'Bij waarde 2 in de lijst beginnnen
            If intCurrentValue > 13 Then
                intCurrentValue += 1
            Else ' Wanneer we over 13 gaan ( Aas in de lijst ) moeten we naar kaart 2 gaan maar van de het volgende type 
                intCurrentValue -= 13
                intCurrentSuit += 1
            End If
        End Sub
    End Class
    Sub Main(args As String())
        'Maak een nieuw deck
        Dim myDeck As New Deck()

        'Trek 15 kaarten en toon deze
        Console.WriteLine("De getrokken kaarten zijn:")
        For i As Integer = 1 To 15
            myDeck.ShowNextCard()
        Next
    End Sub
End Module
