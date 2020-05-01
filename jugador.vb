Public Class jugador
    Private pganadas As Integer
    Private pperdidas As Integer
    Private num As carta_1
    Private jugador As String

    Public Sub New(pganadas As Integer, pperdidas As Integer, num As carta_1, jugador As String)

        Me.setpganadas(pganadas)
        Me.setpganadas(pperdidas)
        Me.setnum(num)
        Me.setjugador(jugador)

    End Sub

    Public Function getpganadas() As Integer

        Return Me.getpganadas

    End Function
    Public Function getpperdidas() As Integer

        Return Me.getpperdidas

    End Function

    Public Function getjugador() As String
        Return Me.getjugador
    End Function

    Public Sub setpganadas(pganadas As Integer)
        Me.pganadas = pganadas

    End Sub

    Public Sub setpperdidas(pperdidas As Integer)
        Me.pperdidas = pperdidas

    End Sub
    Public Sub setnum(num As carta_1)
        Me.num = num

    End Sub
    Public Sub setjugador(jugador As String)
        Me.jugador = jugador
    End Sub
    Public Function cadena(j As jugador) As String
        cadena = j.getjugador + "tiene" + j.getpganadas
        Return cadena
    End Function




End Class
