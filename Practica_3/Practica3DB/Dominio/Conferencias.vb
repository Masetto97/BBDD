Public Class Conferencias
    Private idconferencia As Integer
    Private siglas As String
    Private nombre As String
    Private lugar As String
    Private fecha_inicio As Date
    Private fecha_fin As Date
    Private gestor As GestorConferencias
    Sub New()
        gestor = New GestorConferencias
    End Sub

    Sub New(ByVal idconferencia As Integer)
        gestor = New GestorConferencias
        Me.idconferencia = idconferencia
    End Sub

    Sub New(ByVal idconferencia As Integer, ByVal siglas As String, ByVal nombre As String, ByVal lugar As String, ByVal fecha_inicio As Date, ByVal fecha_fin As Date)
        gestor = New GestorConferencias
        Me.idconferencia = idconferencia
        Me.siglas = siglas
        Me.nombre = nombre
        Me.lugar = lugar
        Me.fecha_inicio = fecha_inicio
        Me.fecha_fin = fecha_fin
    End Sub


    'metodos para obtener/cambiar/leer/eliminar el valor de algun atributo relacionado con las conferencias
    Public ReadOnly Property migestor As GestorConferencias
        Get
            Return gestor
        End Get
    End Property
    Public Property miidconferencia As Integer
        Get
            Return idconferencia
        End Get
        Set(idconferencia As Integer)
            Me.idconferencia = idconferencia
        End Set
    End Property
    Public Property misiglas As String
        Get
            Return siglas
        End Get
        Set(siglas As String)
            Me.siglas = siglas
        End Set
    End Property
    Public Property minombre As String
        Get
            Return nombre
        End Get
        Set(nombre As String)
            Me.nombre = nombre
        End Set
    End Property
    Public Property milugar As String
        Get
            Return lugar
        End Get
        Set(lugar As String)
            Me.lugar = lugar
        End Set
    End Property
    Public Property mifecha_inicio As Date
        Get
            Return fecha_inicio
        End Get
        Set(fecha_inicio As Date)
            Me.fecha_inicio = fecha_inicio
        End Set
    End Property
    Public Property mifecha_fin As Date
        Get
            Return fecha_fin
        End Get
        Set(fecha_fin As Date)
            Me.fecha_fin = fecha_fin
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
