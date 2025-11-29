Imports System

Module Program
    Class Laptop
        Private strMerk As String
        Private intRAM As Integer
        Private dblBatterijUren As Double
        Public Sub New(strMerk As String, intRAM As Integer, dblBatterijUren As Double)
            Me.strMerk = strMerk
            Me.intRAM = intRAM
            Me.dblBatterijUren = dblBatterijUren
        End Sub
        Public Function GeefMerk() As String
            Return strMerk
        End Function

        Public Function GeefRAM() As Integer
            Return intRAM
        End Function

        Public Function GeefBatterijUren() As Double
            Return dblBatterijUren
        End Function
    End Class

    Sub Main(args As String())
        Dim objMacbook As New Laptop("apple", 16, 2.5)
        Console.WriteLine("Het merk is " & objMacbook.GeefMerk)
        Console.WriteLine("Het aantal RAM is " & objMacbook.GeefRAM)
        Console.WriteLine("Hij kan " & objMacbook.GeefBatterijUren & " uren mee")
    End Sub
End Module
