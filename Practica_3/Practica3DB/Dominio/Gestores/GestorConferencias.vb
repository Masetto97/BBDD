Imports System.Data.OleDb
Public Class GestorConferencias
    Private listaConferencias As Collection 'Declara la coleccion "listaConferencias"
    Private miAgente As AgenteBD
    Private valido As Boolean

    'Crea una nueva colección de Conferencias y llama al Agente
    Public Sub New()
        listaConferencias = New Collection
        miAgente = AgenteBD.getAgente()
    End Sub


    Public ReadOnly Property milistaConferencias As Collection
        Get
            Return listaConferencias 'Devuelve la lista de Conferencias
        End Get
    End Property

    'Inserta una nueva tupla con los atributos declarados en la lista de Conferencias
    Public Sub insert(conferencia As Conferencias)
        miAgente.modificar("INSERT INTO CONFERENCIAS (siglas,nombre,lugar,fecha_inicio,fecha_fin) VALUES ('" & conferencia.misiglas & "','" & conferencia.minombre & "','" & conferencia.milugar & "','" & FormatDateTime(conferencia.mifecha_inicio, DateFormat.ShortDate) & "','" & FormatDateTime(conferencia.mifecha_fin, DateFormat.ShortDate) & "');")
    End Sub

    'Borra una tupla existente en la lista de Conferencias
    Public Sub delete(conferencia As Conferencias)
        miAgente.modificar("DELETE FROM CONFERENCIAS WHERE idconferencia=" & conferencia.miidconferencia & ";")
    End Sub

    'Modifica/Actualiza los atributos de una tupla con los valores introducidos por texto, para la tabla de Conferencias
    Public Sub update(conferencia As Conferencias)
        miAgente.modificar("UPDATE CONFERENCIAS SET siglas = '" & conferencia.misiglas & "', nombre = '" & conferencia.minombre & "', lugar = '" & conferencia.milugar & "', fecha_inicio = '" & FormatDateTime(conferencia.mifecha_inicio, DateFormat.ShortDate) & "', fecha_fin = '" & FormatDateTime(conferencia.mifecha_fin, DateFormat.ShortDate) & "' WHERE idconferencia=" & conferencia.miidconferencia & ";")

    End Sub

    'Lee los atributos de la lista de Conferencias en el orden dado. Primero lee los IDs y despues los demas atributos
    Public Sub read(ByRef conferencia As Conferencias)
        Dim lista As OleDbDataReader = miAgente.leerdatos("SELECT * FROM CONFERENCIAS WHERE idconferencia=" & conferencia.miidconferencia)
        If lista.Read() Then
            conferencia.misiglas = lista(1)
            conferencia.minombre = lista(2)
            conferencia.milugar = lista(3)
            conferencia.mifecha_inicio = lista(4)
            conferencia.mifecha_fin = lista(5)
        End If
    End Sub

    'Lee todos los datos que se encuentren en la lista de Conferencias
    Public Sub readAll() 'Lee directamente de Conferencias
        Dim lista As OleDbDataReader = miAgente.leerdatos("SELECT * FROM CONFERENCIAS;")
        Dim conferencia As Conferencias

        While lista.Read()
            conferencia = New Conferencias(lista(0))
            listaConferencias.Add(conferencia) 'Añade conferencia
        End While
    End Sub

    'Referencia la lista de Conferencias y establece una ID maxima de la lista
    Public Sub readMax(ByRef conferencia As Conferencias)
        Dim lista As OleDbDataReader = miAgente.leerdatos("SELECT MAX(idConferencia) as maxid FROM CONFERENCIAS;")

        If lista.Read() Then
            conferencia.miidconferencia = Convert.ToInt32(lista(0))
        End If
    End Sub

    'Lee la tabla de conferencias por IDs y valida unicamente las que superen o igualen el valor 1. Las demas quedaran invalidadas.
    Public Sub readTabla(ByRef conferencia As Conferencias)
        Dim numero As OleDbDataReader = miAgente.leerdatos("SELECT COUNT(idConferencia) FROM CONFERENCIAS;")

        If numero.Read() > 1 Then
            valido = True
        End If
        If numero.Read() <= 0 Then
            valido = False
        End If
    End Sub


End Class