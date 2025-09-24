Imports System

Module Program
    Class auto
        Private Const MaxDruk As Double = 5.0
        Private Const MinimumDruk As Double = 3.0
        Private bandenspanning As Double

        Public Sub banden()
            bandenspanning = MaxDruk
        End Sub
        Public Sub VakantieGaan()
            bandenspanning += -1.0
        End Sub
        Public Sub Pompen()
            bandenspanning = MaxDruk
        End Sub
    End Class
End Module
