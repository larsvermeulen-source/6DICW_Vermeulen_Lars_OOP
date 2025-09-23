Imports System

Module Program

    Class Wielrenner
        Public intLeeftijd As Integer
        Public strGeboorteplaats As String
        Public intGewicht As Integer
        Public boo25Plusser As Boolean
        Public intLengte As Integer
        Public intTijdritten As Integer
    End Class
    Sub Main(args As String())

        Dim objWielrenner As New Wielrenner()
        objWielrenner.intLeeftijd = 28
        objWielrenner.strGeboorteplaats = "Herentals"
        objWielrenner.intGewicht = 78
        objWielrenner.boo25Plusser = True
        objWielrenner.intLengte = 190
        objWielrenner.intTijdritten = 2216
    End Sub
End Module
