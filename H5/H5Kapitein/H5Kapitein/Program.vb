Imports System

Module Program
    Class Voetballer
        Public StrNaam As String
        Public BlnIsKapitein As Boolean

        Public Sub New(StrNaam As String)
            Me.StrNaam = StrNaam
            Me.BlnIsKapitein = False

        End Sub

        Sub geefKapitein()
            If BlnIsKapitein Then
                Console.WriteLine("Is de capitein")
            Else
                Console.WriteLine("Is niet de capitein")
            End If
        End Sub

        Public Sub ZetKapitein(BlnIsKapitein As Boolean)

            Me.BlnIsKapitein = BlnIsKapitein
        End Sub

    End Class
    Sub Main(args As String())

        Dim objMessi As New Voetballer("Messi")
        objMessi.geefKapitein()
        objMessi.ZetKapitein(True)
        objMessi.geefKapitein()
    End Sub
End Module
