Imports System.Data.OleDb

Public Class GestorInvestigadores
    Private listaInvestigadores As Collection 'Declara la coleccion "listaInvestigadores"
    Private miAgente As AgenteBD

    'Crea una nueva colección de Investigadores y llama al Agente
    Public Sub New()
        listaInvestigadores = New Collection
        miAgente = AgenteBD.getAgente()
    End Sub

    Public ReadOnly Property milistaInvestigadores As Collection
        Get
            Return listaInvestigadores 'Devuelve la lista de Investigadores
        End Get
    End Property

    'Inserta una nueva tupla con los atributos declarados en la lista de Investigadores
    Public Sub insert(investigador As Investigadores)
        miAgente.modificar("INSERT INTO INVESTIGADORES (nombre,apellidos,despacho,edificio,departamento,teléfono,email) VALUES ('" & investigador.minombre & "','" & investigador.miapellido & "','" & investigador.midespacho & "','" & investigador.miedificio & "','" & investigador.midepartamento & "','" & investigador.mitelefono & "','" & investigador.miemail & "');")
    End Sub

    'Borra una tupla existente en la lista de Investigadores
    Public Sub delete(investigador As Investigadores)
        miAgente.modificar("DELETE FROM INVESTIGADORES WHERE idInvest=" & investigador.miidinvest & ";")
    End Sub

    'Modifica/Actualiza los atributos de una tupla con los valores introducidos por texto, para la tabla de Investigadores
    Public Sub update(investigador As Investigadores)
        miAgente.modificar("UPDATE INVESTIGADORES SET Nombre = '" & investigador.minombre & "', Apellidos = '" & investigador.miapellido & "', Despacho = '" & investigador.midespacho & "', Edificio = '" & investigador.miedificio & "', Departamento = '" & investigador.midepartamento & "', Teléfono ='" & investigador.mitelefono & "', INVESTIGADORES.Email = '" & investigador.miemail & "' WHERE idInvest=" & investigador.miidinvest & ";")

    End Sub

    'Lee los atributos de la lista de Investigadores en el orden dado. Primero lee los IDs y despues los demas atributos
    Public Sub read(ByRef investigador As Investigadores)
        Dim lista As OleDbDataReader = miAgente.leerdatos("SELECT * FROM INVESTIGADORES WHERE IDINVEST=" & investigador.miidinvest)
        If lista.Read() Then
            investigador.minombre = lista(1)
            investigador.miapellido = lista(2)
            investigador.midespacho = lista(3)
            investigador.miedificio = lista(4)
            investigador.midepartamento = lista(5)
            investigador.mitelefono = lista(6)
            investigador.miemail = lista(7)
        End If
    End Sub

    'Lee todos los datos que se encuentren en la lista de Investigadores
    Public Sub readAll() 'Lee directamente de Investigadores
        Dim lista As OleDbDataReader = miAgente.leerdatos("SELECT * FROM INVESTIGADORES;")
        Dim invest As Investigadores

        While lista.Read() 'Lee la lista en bucle
            invest = New Investigadores(lista(0))
            listaInvestigadores.Add(invest) 'Añade investigador
        End While
    End Sub

    'Referencia la lista de Investigadores y establece una ID maxima de la lista
    Public Sub readMax(ByRef investigador As Investigadores)
        Dim lista As OleDbDataReader = miAgente.leerdatos("SELECT MAX(idInvest) as maxid FROM INVESTIGADORES;")

        If lista.Read() Then
            investigador.miidinvest = Convert.ToInt32(lista(0))
        End If
    End Sub
    Public Function readAuthors(ByRef investigador As Investigadores) As Integer
        Dim lista As OleDbDataReader = miAgente.leerdatos("SELECT count(invest) as cantidad FROM Autor WHERE invest=" & investigador.miidinvest)
        Dim value As Integer = 0
        If lista.Read() Then
            value = lista(0)
        End If
        readAuthors = value
    End Function

    Public Function readAttends(ByRef investigador As Investigadores) As Integer
        Dim lista As OleDbDataReader = miAgente.leerdatos("SELECT count(invest) as cantidad FROM Asiste WHERE invest=" & investigador.miidinvest)
        Dim value As Integer = 0
        If lista.Read() Then
            value = lista(0)
        End If
        readAttends = value
    End Function
End Class