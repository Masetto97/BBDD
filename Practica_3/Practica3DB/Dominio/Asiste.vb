Public Class Asiste
    Private idinvestigador As Integer
    Private idconferencia As Integer
    Private gestor As GestorAsiste

    Sub New()
        gestor = New GestorAsiste
    End Sub

    Sub New(ByVal idinvestigador As Integer, idconferencia As Integer)
        Me.idinvestigador = idinvestigador
        Me.idconferencia = idconferencia
        gestor = New GestorAsiste
    End Sub

    Public Property miidinvestigador As Integer
        Get
            Return idinvestigador
        End Get
        Set(value As Integer)
            idinvestigador = value
        End Set
    End Property

    Public Property miidconferencia As Integer
        Get
            Return idconferencia
        End Get
        Set(value As Integer)
            idconferencia = value
        End Set
    End Property

    Public ReadOnly Property migestor As GestorAsiste
        Get
            Return gestor
        End Get
    End Property

    Public Sub insertar()
        migestor.insert(Me)
    End Sub
    Public Sub eliminar()
        migestor.delete(Me)
    End Sub
    Public Sub leerAsistentes()
        migestor.readAssisting(Me)
    End Sub

    Public Sub leerNoAsistentes()
        migestor.readNonAssisting(Me)
    End Sub
End Class
