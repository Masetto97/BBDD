Public Class Articulos
    Private idarticulo As Integer
    Private titulo As String
    Private conferencia As Integer
    Private pag_inicio As String
    Private pag_fin As String
    Private gestor As GestorArticulos

    Sub New()
        gestor = New GestorArticulos
    End Sub

    Sub New(ByVal idarticulo As Integer)
        gestor = New GestorArticulos
        Me.idarticulo = idarticulo
    End Sub

    Sub New(ByVal idarticulo As Integer, ByVal titulo As String, ByVal conferencia As Integer, ByVal pag_inicio As String, ByVal pag_fin As String, ByVal investigador As Integer, ByVal orden As Integer)
        gestor = New GestorArticulos
        Me.idarticulo = idarticulo
        Me.titulo = titulo
        Me.conferencia = conferencia
        Me.pag_inicio = pag_inicio
        Me.pag_fin = pag_fin
    End Sub

    Public ReadOnly Property migestor As GestorArticulos
        Get
            Return gestor
        End Get
    End Property
    Public Property miidarticulo As Integer
        Get
            Return idarticulo
        End Get
        Set(idarticulo As Integer)
            Me.idarticulo = idarticulo
        End Set
    End Property
    Public Property mititulo As String
        Get
            Return titulo
        End Get
        Set(titulo As String)
            Me.titulo = titulo
        End Set
    End Property

    Public Property miconferencia As Integer
        Get
            Return conferencia
        End Get
        Set(value As Integer)
            conferencia = value
        End Set
    End Property

    Public Property mipag_inicio As String
        Get
            Return pag_inicio
        End Get
        Set(pag_inicio As String)
            Me.pag_inicio = pag_inicio
        End Set
    End Property
    Public Property mipag_fin As String
        Get
            Return pag_fin
        End Get
        Set(pag_fin As String)
            Me.pag_fin = pag_fin
        End Set
    End Property
    
    Public Sub insertar()
        gestor.insert(Me)
    End Sub
    Public Sub eliminar()
        gestor.delete(Me)
    End Sub
    Public Sub modificar()
        gestor.update(Me)
    End Sub
    Public Sub leer()
        gestor.read(Me)
    End Sub
    Public Sub leertodo()
        gestor.readAll()
    End Sub
    Public Sub leermaximo()
        gestor.readMax(Me)
    End Sub
End Class
