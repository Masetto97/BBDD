Public Class Autor
    Private idinvestigador As Integer
    Private idarticulo As Integer
    Private idorden As Integer
    Private gestor As GestorAutor

    Sub New()
        gestor = New GestorAutor
    End Sub

    Sub New(ByVal idinvestigador As Integer, idarticulo As Integer, ByVal idorden As Integer)
        Me.idinvestigador = idinvestigador
        Me.idarticulo = idarticulo
        Me.idorden = idorden
        gestor = New GestorAutor
    End Sub

    Sub New(ByVal idinvestigador As Integer, idarticulo As Integer)
        Me.idinvestigador = idinvestigador
        Me.idarticulo = idarticulo
        gestor = New GestorAutor
    End Sub

    Sub New(ByVal idinvestigador As Integer)
        Me.idinvestigador = idinvestigador
        gestor = New GestorAutor
    End Sub


    'metodos para obtener/cambiar/leer/eliminar el valor de algun atributo relacionado con el autor
    Public Property miidinvestigador As Integer
        Get
            Return idinvestigador
        End Get
        Set(value As Integer)
            idinvestigador = value
        End Set
    End Property

    Public Property miidarticulo As Integer
        Get
            Return idarticulo
        End Get
        Set(value As Integer)
            idarticulo = value
        End Set
    End Property

    Public Property miidorden As Integer
        Get
            Return idorden
        End Get
        Set(value As Integer)
            idorden = value
        End Set
    End Property

    Public ReadOnly Property migestor As GestorAutor
        Get
            Return gestor
        End Get
    End Property



    Public Sub insertar()
        migestor.insert(Me)
    End Sub

    Public Sub eliminarTodo()
        migestor.deleteAll(Me)
    End Sub
    Public Sub eliminar()
        migestor.delete(Me)
    End Sub
    Public Sub modificar()
        migestor.update(Me)
    End Sub

    Public Sub leerArticulos()
        migestor.readPapers(Me)
    End Sub

    Public Sub leerInvestigadores()
        migestor.readResearchers(Me)
    End Sub

    Public Sub leerNoAutores()
        migestor.readnonAuthors(Me)
    End Sub

    Public Sub leermaximoorden()
        gestor.readMaxOrder(Me)
    End Sub

End Class
