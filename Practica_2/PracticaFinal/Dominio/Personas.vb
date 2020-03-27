'Creación de la clase que guarda los atributos referidos a los objetos de tipo Persona.
Public Class Personas

    'ATRIBUTOS DE LAS PERSONAS

    Private Gestor As GestorPersonas
    Private Nombre As String
    Private DNI As String


    'Constructor_1
    Sub New(ByVal dni As String, ByVal nombre As String) 'Constructor con paso de variables "dni" y "nombre".
        Gestor = New GestorPersonas() 'Creación de un nuevo objeto constructor del tipo GestorPersonas.
        Me.DNI = dni
        Me.Nombre = nombre
    End Sub


    'Constructor_2: este constructor lo utilizaremos para eliminar, modificar o añadir elementos a la base de datos
    Sub New()
        Gestor = New GestorPersonas()
    End Sub

    ' Método de lectura del gestor de la lista de personas dentro de la base de datos.
    Public ReadOnly Property migestor As GestorPersonas
        Get
            Return Gestor
        End Get
    End Property



    'Método que devuelve el contenido de "nombre" como un tipo String.
    Public Property getNombre As String
        Get
            Return Nombre
        End Get
        Set(nombre As String) 'Convierte "nombre" a String.
            Me.Nombre = nombre
        End Set
    End Property


    'Método que devuelve el contenido de "dni" como un tipo String.
    Public Property getDNI As String
        Get
            Return DNI
        End Get
        Set(dni As String) 'Convierte "dni" a String.
            Me.DNI = dni
        End Set
    End Property

    Public Sub leertodo()
        Gestor.leer_persona() 'Se encarga de la lectura del gestor para la base de datos.
    End Sub

    Public Sub insertarDatos() 'Referencia al método encargado de insertar los datos de una persona dentro del gestor de la base de datos.
        Gestor.insertarPersona(Me)
    End Sub

    Public Sub modificarDatos()
        Gestor.actualizar_Persona(Me) 'Referencia al método encargado de modificar los datos de una persona dentro del gestor de la base de datos.
    End Sub

    Public Sub eliminarDatos()
        Gestor.borrarPersona(Me) 'Referencia al método encargado de borrar los datos de una persona dentro del gestor de la base de datos.
    End Sub

    'Fin de la clase Personas.
End Class
