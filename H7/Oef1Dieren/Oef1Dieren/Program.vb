Imports System

Module Program
    Class Dier
        Protected intKleur As String
        Public Sub New(intkleur As String)
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
        Public Sub New(intkleur As String, strBaasje As String)
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
        Public Sub New(intkleur As String, strJungleNaam As String)
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
        
    End Class
    Sub Main(args As String())
        Dim objWhoLetTheDogsOut As New Hond("Zwart", "America")
        objWhoLetTheDogsOut.Blaf()
        Console.WriteLine(objWhoLetTheDogsOut.geefEigenaar())
        objWhoLetTheDogsOut.zetEigenaar("rusland")
        Console.WriteLine(objWhoLetTheDogsOut.geefEigenaar())
        Dim objSimba As New Leeuw("geel", "brazil")
        objSimba.Brult()
        Console.WriteLine(objSimba.geefJungle())
        objSimba.zetJungle("mijn tuin")
        Console.WriteLine(objSimba.geefJungle())
        objSimba.slaap()
    End Sub
End Module

