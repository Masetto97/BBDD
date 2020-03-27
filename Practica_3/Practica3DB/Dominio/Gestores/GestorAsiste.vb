
Imports System.Data.OleDb

Public Class GestorAsiste
    Private listaAsistentes As Collection 'Declara la coleccion "listaAsistentes"
    Private miAgente As AgenteBD

    'Crea una lista de Asistentes como coleccion
    Public Property milistaAsistentes As Collection
        Get
            Return listaAsistentes
        End Get
        Set(value As Collection)
            listaAsistentes = value
        End Set
    End Property

    'Crea una nueva colección de Asistentes y llama al Agente
    Public Sub New()
        listaAsistentes = New Collection
        miAgente = AgenteBD.getAgente()
    End Sub

    'Inserta una nueva tupla con los atributos declarados en la lista de Asiste
    Public Sub insert(ByVal asiste As Asiste)
        miAgente.modificar("INSERT INTO Asiste VALUES (" & asiste.miidconferencia & "," & asiste.miidinvestigador & ");")
    End Sub

    'Borra una tupla especifica existente en la lista de Asiste
    Public Sub delete(ByVal asiste As Asiste)
        miAgente.modificar("DELETE FROM Asiste WHERE conferencia=" & asiste.miidconferencia & " and invest=" & asiste.miidinvestigador & ";")
    End Sub

    'Lee la lista de conferencias a la que no asisten investigadores
    Public Sub readNonAssisting(ByVal asiste As Asiste)
        Dim list As OleDbDataReader = miAgente.leerdatos("SELECT idconferencia FROM conferencias WHERE idconferencia NOT IN (SELECT conferencia FROM Asiste WHERE invest=" & asiste.miidinvestigador & ");")

        While list.Read()
            listaAsistentes.Add(list(0))
        End While
    End Sub

    'Lee la lista de conferencias a la que si asisten investigadores
    Public Sub readAssisting(ByVal asiste As Asiste)

        Dim list As OleDbDataReader = miAgente.leerdatos("SELECT conferencia FROM Asiste WHERE invest=" & asiste.miidinvestigador & ";")

        While list.Read()
            listaAsistentes.Add(list(0))
        End While

    End Sub
End Class