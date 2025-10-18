Imports System

Module Program
    Class Dier
        Protected intKleur As Integer
        Public Sub New(intkleur As Integer)
            Me.intKleur = intkleur
        End Sub

        Public Sub eet()
            Console.WriteLine("hhhmm lekker")
        End Sub
        Public Sub slaap()
            Console.WriteLine("zzzz z z z z zzz zzz ")
        End Sub
    End Class

    Class Hond
        Inherits Dier
        Private strBaasje As String
        Public Sub New(intkleur As Integer, strBaasje As String)
            MyBase.New(intkleur)
            Me.strBaasje = strBaasje
        End Sub

        Public Sub Blaf()
            Console.WriteLine("woef woef")
        End Sub
        Public Function geefEigenaar()
            Return strBaasje
        End Function
        Public Sub zetEigenaar(eigenaar)
            Me.strBaasje = eigenaar
        End Sub

    End Class
    Class Leeuw
        Inherits Dier
        Private strJungleNaam As String
        Public Sub New(intkleur As Integer, strJungleNaam As String)
            MyBase.New(intkleur)
            Me.strJungleNaam = strJungleNaam
        End Sub

        Public Sub Brult()
            Console.WriteLine("rawrr")
        End Sub
        Public Function geefJungle()
            Return strJungleNaam
        End Function
        Public Sub zetJungle(jungle)
            Me.strJungleNaam = jungle
        End Sub
        Sub Main(args As String())
            Console.WriteLine("Hello World!")
        End Sub
    End Class
    Sub Main(args As String())
        Dim objWhoLetTheDogsOut As New Hond("Zwart", "America")
        objWhoLetTheDogsOut.Blaf()
        objWhoLetTheDogsOut.geefEigenaar()
        objWhoLetTheDogsOut.zetEigenaar("rusland")
        objWhoLetTheDogsOut.geefEigenaar()
        Dim objSimba As New Leeuw("geel", "brazil")
        objSimba.Brult()
        objSimba.geefJungle()
        objSimba.zetJungle("mijn tuin")
        objSimba.geefJungle()
    End Sub
End Module

