Imports System

Module Program
    Public Class Bankrekening
        Private dblSaldo As Double
        Public Sub New()
            dblSaldo = 0
        End Sub
        Public Function GeefSaldo()
            Return dblSaldo
        End Function
        Public Sub StortBedrag(dblBedrag As Double)
            dblSaldo += dblBedrag
        End Sub
        Public Sub NeemAf(dblBedrag As Double)
            If dblBedrag < dblSaldo Then
                dblSaldo -= dblBedrag
            Else
                Console.WriteLine("U heeft niet genoeg saldo, sorry")
            End If
        End Sub
    End Class
    Sub Main(args As String())
        Dim objRik As New Bankrekening()
        objRik.StortBedrag(100)
        Console.WriteLine(objRik.GeefSaldo() & " euro")

        objRik.NeemAf(40)
        Console.WriteLine(objRik.GeefSaldo() & " euro")

        objRik.NeemAf(100)
        Console.WriteLine(objRik.GeefSaldo()&" euro")
    End Sub
End Module
