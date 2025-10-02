Imports System
Imports System.IO
Imports System.Security.Cryptography.X509Certificates

Module Program
    Class Dier
        Public StrNaam As String
        Public IntLeeftijd As Integer
        Public blnIsAanwezig As Boolean
        Public IntGewicht As Integer

        Public Sub New(StrNaam As String, IntLeeftijd As Integer, IntGewicht As Integer)
            Me.StrNaam = StrNaam
            Me.IntLeeftijd = IntLeeftijd
            Me.blnIsAanwezig = True
            Me.IntGewicht = IntGewicht
        End Sub
        Public Sub ZetAanwezig(blnIsAanwezig As Boolean)
            Me.blnIsAanwezig = blnIsAanwezig
        End Sub
        Sub GeefAanwezig()
            If blnIsAanwezig() Then
                Console.WriteLine("Aanwezig")
            Else
                Console.WriteLine("Afwezig")
            End If
        End Sub
        Sub GeefNaam()

        End Sub
    End Class
    Sub Main()
        Dim objDier As New Dier("Joske de leeuw", 12 False, 280, 2)
        objDier.ZetAanwezig(True)
        If objDier.GeefAanwezig() Then
            Console.WriteLine("Dier met naam: " & objDier.GeefNaam() & " is aanwezig")
        Else
            Console.WriteLine("Dier met naam: " & objDier.GeefNaam() & " is afwezig")
        End If
    End Sub
End Module
