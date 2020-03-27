
Imports System.Data.OleDb

Public Class GestorArticulos
    Private listaArticulos As Collection 'Declara la coleccion "listaArticulos"
    Private miAgente As AgenteBD

    'Crea una nueva colección de Articulos y llama al Agente
    Public Sub New()
        listaArticulos = New Collection
        miAgente = AgenteBD.getAgente()
    End Sub

    'Crea una lista de Articulos como coleccion
    Public ReadOnly Property milistaArticulos As Collection
        Get
            Return listaArticulos
        End Get
    End Property

    'Inserta una nueva tupla con los atributos declarados en la lista de Articulos
    Public Sub insert(articulo As Articulos)
        miAgente.modificar("INSERT INTO ARTICULOS (titulo,conferencia,pag_inicio,pag_fin) VALUES ('" & articulo.mititulo & "'," & articulo.miconferencia & "," & articulo.mipag_inicio & "," & articulo.mipag_fin & ");")
    End Sub

    'Borra una tupla especifica existente en la lista de Articulos
    Public Sub delete(articulo As Articulos)
        miAgente.modificar("DELETE FROM articulos WHERE idArticulo=" & articulo.miidarticulo & ";")
    End Sub

    'Modifica/Actualiza los atributos de una tupla con los valores introducidos por texto, para la tabla de Articulos
    Public Sub update(articulo As Articulos)
        miAgente.modificar("UPDATE Articulos SET titulo = '" & articulo.mititulo & "', conferencia = " & articulo.miconferencia & ", pag_inicio = " & articulo.mipag_inicio & ", pag_fin = " & articulo.mipag_fin & " WHERE idarticulo=" & articulo.miidarticulo & ";")

    End Sub

    'Lee los atributos de la lista de Articulos en el orden dado. Primero lee los IDs y despues los demas atributos
    Public Sub read(ByRef articulo As Articulos)
        Dim lista As OleDbDataReader = miAgente.leerdatos("SELECT * FROM ARTICULOS WHERE idArticulo=" & articulo.miidarticulo)

        If lista.Read() Then
            articulo.mititulo = lista(1)
            articulo.miconferencia = lista(2)
            articulo.mipag_inicio = lista(3)
            articulo.mipag_fin = lista(4)
        End If
    End Sub

    'Lee todos los datos que se encuentren en la lista de Articulos
    Public Sub readAll()
        Dim lista As OleDbDataReader = miAgente.leerdatos("SELECT * FROM ARTICULOS;")
        Dim articulo As Articulos

        While lista.Read() 'Lee la lista en bucle
            articulo = New Articulos(lista(0))
            listaArticulos.Add(articulo) 'Añade articulo
        End While
    End Sub

    'Referencia la lista de Articulos y establece una ID maxima de la lista
    Public Sub readMax(ByRef articulo As Articulos)
        Dim lista As OleDbDataReader = miAgente.leerdatos("SELECT MAX(idArticulo) as maxid FROM ARTICULOS;")

        If lista.Read() Then
            articulo.miidarticulo = Convert.ToInt32(lista(0))
        End If
    End Sub

End Class