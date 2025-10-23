Imports System
Module Program
    Class Speler
        Protected strNaam As String
        Public Sub New(strNaam As String)
            Me.strNaam = strNaam
        End Sub
        Public Overridable Sub TrapBal()
            Console.WriteLine("Ik pass de bal.")
        End Sub

    End Class

    Class Verdediger
        Inherits Speler
        Private random As New Random

        Public Sub New(strNaam As String)
            MyBase.New(strNaam)
            Me.strNaam = strNaam
        End Sub

        Public Overrides Sub TrapBal()
            Dim getal As Double = random.NextDouble()

            If getal <= 0.5 Then
                Console.WriteLine("Verdedigt")
            Else
                Console.WriteLine("Bal kwijt")
            End If
            Console.WriteLine()
        End Sub

    End Class
    Class Aanvaller
        Inherits Speler
        Private random As New Random
        Public Sub New(strNaam As String)
            MyBase.New(strNaam)
            Me.strNaam = strNaam
        End Sub
        Public Overrides Sub TrapBal()
            Dim getal As Double = random.NextDouble()

            If getal <= 0.3 Then
                Console.WriteLine("GOAL")
            Else
                Console.WriteLine("MIS")
            End If
            Console.WriteLine()
        End Sub

    End Class
    Sub Main(args As String())
        Dim objStones As New Verdediger("stones")
        objStones.TrapBal()

        Dim objDoku As New Aanvaller("doku")
        objDoku.TrapBal()


    End Sub
End Module
