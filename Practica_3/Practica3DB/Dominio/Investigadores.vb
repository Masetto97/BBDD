Public Class Investigadores
    'Atributos de los Investigadores, tomados de la base de datos.
    Private idinvest As Integer
    Private nombre As String
    Private apellidos As String
    Private despacho As String
    Private edificio As String
    Private departamento As String
    Private telefono As String
    Private email As String
    'Gestor de los Investigadores
    Private gestorInv As GestorInvestigadores
    'Constructor, donde asignamos el gestor der investigadores.
    Sub New()
        gestorInv = New GestorInvestigadores
    End Sub
    'Constructor donde le pasamos el id del investigador, y se lo asignamos al nuestro investigador
    'tambien lo usamos para asignar el gestor de investigadores.
    Sub New(ByVal idinv As Integer)
        gestorInv = New GestorInvestigadores
        Me.idinvest = idinv
    End Sub
    'Constructor donde le pasamos todos los atributos del investigador y se lo asignamos a nuestro investigador.
    Sub New(ByVal idinvest As Integer, ByVal nombre As String, ByVal apellidos As String, ByVal despacho As String, ByVal edificio As String, ByVal departamento As String, ByVal telefono As String, ByVal email As String)
        gestorInv = New GestorInvestigadores
        Me.idinvest = idinvest
        Me.nombre = nombre
        Me.apellidos = apellidos
        Me.despacho = despacho
        Me.edificio = edificio
        Me.departamento = departamento
        Me.telefono = telefono
        Me.email = email
    End Sub

    'para leer los autores que asisten a una conferencia
    Public Function leerAutores() As Integer
        leerAutores = gestorInv.readAuthors(Me)
    End Function
    Public Function leerAsiste() As Integer
        leerAsiste = gestorInv.readAttends(Me)
    End Function

    'metodos para obtener/cambiar/leer/eliminar el valor de algun atributo relacionado con el investigador 

    Public ReadOnly Property migestor As GestorInvestigadores
        Get
            Return gestorInv
        End Get
    End Property
    Public Property miidinvest As Integer
        Get
            Return idinvest
        End Get
        Set(idinvest As Integer)
            Me.idinvest = idinvest
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
    Public Property miapellido As String
        Get
            Return apellidos
        End Get
        Set(apellidos As String)
            Me.apellidos = apellidos
        End Set
    End Property
    Public Property midespacho As String
        Get
            Return despacho
        End Get
        Set(despacho As String)
            Me.despacho = despacho
        End Set
    End Property
    Public Property miedificio As String
        Get
            Return edificio
        End Get
        Set(edificio As String)
            Me.edificio = edificio
        End Set
    End Property
    Public Property midepartamento As String
        Get
            Return departamento
        End Get
        Set(departamento As String)
            Me.departamento = departamento
        End Set
    End Property
    Public Property mitelefono As String
        Get
            Return telefono
        End Get
        Set(telefono As String)
            Me.telefono = telefono
        End Set
    End Property
    Public Property miemail As String
        Get
            Return email
        End Get
        Set(email As String)
            Me.email = email
        End Set
    End Property

    Public Sub insertar()
        gestorInv.insert(Me)
    End Sub
    Public Sub eliminar()
        gestorInv.delete(Me)
    End Sub
    Public Sub modificar()
        gestorInv.update(Me)
    End Sub
    Public Sub leer()
        gestorInv.read(Me)
    End Sub
    Public Sub leertodo()
        gestorInv.readAll()
    End Sub
    Public Sub leermaximo()
        gestorInv.readMax(Me)
    End Sub
End Class
