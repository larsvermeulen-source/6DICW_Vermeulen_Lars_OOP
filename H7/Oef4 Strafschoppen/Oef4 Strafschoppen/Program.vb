Imports System

Module Program
    Class Trapper
        Private strVoorkeur As String
        Private intRandomSchot As Integer
        Private richtingen As List(Of String) = New List(Of String) From {"links", "midden", "rechts"}

        Public Sub New(strVoorkeur As String)
            Me.strVoorkeur = strVoorkeur
        End Sub

        Public Function neemSchot() As String
            Dim opties As New List(Of String)(richtingen)
            opties.Remove(strVoorkeur)

            Dim r As Double = Rnd()

            If r < 0.4 Then
                Return strVoorkeur
            ElseIf r < 0.7 Then
                Return opties(0)
            Else
                Return opties(1)
            End If
        End Function

    End Class

    Class Keeper
        Private strVoorkeur As String
        Private intRandomKant As Integer
        Private richtingen As List(Of String) = New List(Of String) From {"links", "midden", "rechts"}

        Public Sub New(strVoorkeur As String)
            Me.strVoorkeur = strVoorkeur
        End Sub

        Public Function verdedigSchot() As String
            Dim opties As New List(Of String)(richtingen)
            opties.Remove(strVoorkeur)

            Dim r As Double = Rnd()

            If r < 0.4 Then
                Return strVoorkeur
            ElseIf r < 0.7 Then
                Return opties(0)
            Else
                Return opties(1)
            End If
        End Function
    End Class

    Sub Main(args As String())
        Randomize()
        Dim objDoku As New Trapper("rechts")
        Dim objCourtois As New Keeper("rechts")

        For aantalStrafSchoppen As Integer = 1 To 5
            Dim schot As String = objDoku.neemSchot()
            Dim redding As String = objCourtois.verdedigSchot()

            Console.WriteLine($"Strafschop {aantalStrafSchoppen}:")
            Console.WriteLine($"Doku schiet: {schot}")
            Console.WriteLine($"Courtois duikt: {redding}")


            If schot = redding Then
                Console.WriteLine("Keeper stopt de bal!")
            Else
                Console.WriteLine("GOAL!")
            End If
            Console.WriteLine("")
        Next

    End Sub


End Module

