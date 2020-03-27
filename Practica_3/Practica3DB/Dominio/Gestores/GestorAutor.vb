Imports System.Data.OleDb
Public Class GestorAutor
    Private listaAutores As Collection 'Declara la coleccion "listaAutores"
    Private miAgente As AgenteBD

    'Crea una lista de Autores como coleccion
    Public Property milistaAutores As Collection
        Get
            Return listaAutores
        End Get
        Set(value As Collection)
            listaAutores = value
        End Set
    End Property

    'Crea una nueva colección de Autores y llama al Agente
    Public Sub New()
        listaAutores = New Collection
        miAgente = AgenteBD.getAgente()
    End Sub

    'Inserta una nueva tupla con los atributos declarados en la lista de Autor
    Public Sub insert(ByVal autor As Autor)
        miAgente.modificar("INSERT INTO Autor (invest,articulo,orden) VALUES (" & autor.miidinvestigador & "," & autor.miidarticulo & "," & autor.miidorden & ");")
    End Sub

    'Borra una tupla especifica existente en la lista de Autor
    Public Sub delete(ByVal autor As Autor)
        miAgente.modificar("DELETE FROM Autor WHERE articulo=" & autor.miidarticulo & " and invest=" & autor.miidinvestigador & ";")
    End Sub

    'Borra todas las tuplas existentes en la lista de Autor
    Public Sub deleteAll(ByVal autor As Autor)
        miAgente.modificar("DELETE FROM Autor WHERE articulo=" & autor.miidarticulo & ";")
    End Sub

    'Modifica/Actualiza los atributos de una tupla con los valores introducidos por texto, para la tabla de Autor
    Public Sub update(ByVal autor As Autor)
        miAgente.modificar("UPDATE Autor SET invest = " & autor.miidinvestigador & ", orden = " & autor.miidorden & " WHERE articulo=" & autor.miidarticulo & ";")
    End Sub

    'Lee los articulos asociados a un autor determinado
    Public Sub readPapers(ByVal autor As Autor)
        Dim list As OleDbDataReader = miAgente.leerdatos("SELECT articulo FROM autor WHERE invest=" & autor.miidinvestigador & ";")

        While list.Read()
            listaAutores.Add(list(0))
        End While
    End Sub

    'Lee la asociacion de un investigador con un autor determinado
    Public Sub readResearchers(ByVal autor As Autor)
        Dim list As OleDbDataReader = miAgente.leerdatos("Select distinct invest from (SELECT invest FROM autor WHERE articulo=" & autor.miidarticulo & " order by orden);")

        While list.Read()
            listaAutores.Add(list(0))
        End While
    End Sub

    'Lee los investigadores cuya ID no pertenece a la ID de un autor
    Public Sub readnonAuthors(ByVal autor As Autor)
        Dim list As OleDbDataReader = miAgente.leerdatos("SELECT idinvest FROM investigadores WHERE idinvest NOT IN (SELECT invest FROM autor WHERE articulo=" & autor.miidarticulo & ");")

        While list.Read()
            listaAutores.Add(list(0))
        End While
    End Sub

    'Referencia la lista de Autor y establece una ID maxima de la lista
    Public Sub readMaxOrder(ByRef autor As Autor)
        Dim lista As OleDbDataReader = miAgente.leerdatos("SELECT MAX(orden) as maxid FROM autor;")

        If lista.Read() Then
            autor.miidorden = Convert.ToInt32(lista(0)) + 1
        End If
    End Sub

End Class