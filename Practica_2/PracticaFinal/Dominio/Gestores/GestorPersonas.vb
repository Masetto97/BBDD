'Importamos las librerias necesarias para una conexión abierta a un origen de datos.
Imports System.Data.OleDb

'Creación de la clase que se encarga de la gestión de personas dentro de la base de datos.
Public Class GestorPersonas

    'ATRIBUTOS

    Private listaDePersonas As Collection 'Creamos una nueva "colección" en la que se incluirá la lista de las personas que contiene la base de datos.

    'Método constructor para la lista de personas que conforman la base de datos.
    Public Sub New()
        listaDePersonas = New Collection
    End Sub

    'Método para la lectura de la lista de personas una vez cargada la base de datos por el programa.
    Public ReadOnly Property miListaDePersonas As Collection
        Get
            Return listaDePersonas
        End Get
    End Property

    'Método que contiene a la función que se encarga de incluir nuevas personas dentro de la base de datos.
    Public Sub insertarPersona(persona As Personas)
        Dim miAgente As AgenteBD 'Creación de un nuevo objeto del tipo AgenteDB.
        miAgente = AgenteBD.getAgente()
        miAgente.Cambio_Elementos("INSERT INTO PERSONAS VALUES ('" & persona.getDNI & "','" & persona.getNombre & "');")
    End Sub

    'Método que contiene a la función que se encarga de borrar los datos de las personas seleccionadas dentro de la
    'base de datos.
    Public Sub borrarPersona(persona As Personas)
        Dim miAgente As AgenteBD 'Creación de un nuevo objeto del tipo AgenteDB.
        miAgente = AgenteBD.getAgente()
        miAgente.Cambio_Elementos("DELETE FROM PERSONAS WHERE DNI='" & persona.getDNI & "';")
    End Sub

    'Método que contiene a la función que se encarga de modificar los datos de las personas seleccionadas dentro de la
    'base de datos.
    Public Sub actualizar_Persona(persona As Personas)
        Dim miAgente As AgenteBD 'Creación de un nuevo objeto del tipo AgenteDB.
        miAgente = AgenteBD.getAgente()
        miAgente.Cambio_Elementos("UPDATE PERSONAS SET NOMBRE='" & persona.getNombre & "' WHERE DNI='" & persona.getDNI & "';")
    End Sub

    'Método que permite leer las personas contenidas en la base de datos.
    Public Sub leer_persona()

        Dim miAg As AgenteBD 'Creación de un nuevo objeto del tipo AgenteDB
        miAg = AgenteBD.getAgente()
        Dim lista As OleDbDataReader = miAg.Lectura_BBDD("SELECT * FROM PERSONAS;")

        'Permite que la lista de personas se lea de forma continua siempre que se vayan a añadir nuevos objetos del tipo Personas.
        While lista.Read()
            listaDePersonas.Add(New Personas(lista(0), lista(1)))
        End While
    End Sub

    'Fin de la clase GestorPersonas.
End Class
