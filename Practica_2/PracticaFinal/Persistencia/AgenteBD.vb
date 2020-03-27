'Importamos las librerias necesarias para una conexión abierta a una base de datos.
Imports System.Data.OleDb

'Clase que se encarga de las gestiones que se realizarán con respecto a el manejo de la base de datos en cuanto a su
'carga  y la modificación/limpieza de los campos de texto.
Public Class AgenteBD

    'ATRIBUTOS

    Private Shared CadConexion = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source="
    Private Shared mConexion As OleDbConnection
    Public Shared ruta As String 'Ruta seleccionada donde se encuentra la base de datos
    Private Shared Inst As AgenteBD 'Instancia  que usaremos para comunicarnos con la BBDD




    'Creamos el método para acceder a la base de datos y se comprueba si esta ha sido introducida correctamente.
    Private Sub New()

        'Iniciamos todos los atributos.
        CadConexion = CadConexion & ruta
        AgenteBD.mConexion = New OleDbConnection(CadConexion)

        Try 'Procedemos a conectar con la base de datos.
            AgenteBD.mConexion.Open()
        Catch ex As Exception  'Excepción en caso de que ocurra un error con el manejo de la conexión con la base de datos.
            MessageBox.Show("Error en la conexion con la base de datos" & ControlChars.CrLf & ex.Message &
            ControlChars.CrLf & ex.Source())
        End Try
    End Sub

    'Método de lectura para la comprobación de una conexión correcta a la base de datos.
    ReadOnly Property get_oleDb() As OleDbConnection
        Get
            Return mConexion
        End Get
    End Property

    'Creación del agente para la gestión de la base de datos.
    Public Shared Function getAgente() As AgenteBD

        If Inst Is Nothing Then
            Inst = New AgenteBD()
        End If

        Return Inst
    End Function

    'Método que permite la lectura de los datos que se encuentran dentro de la base de datos.
    Public Function Lectura_BBDD(ByVal sql As String) As OleDbDataReader

        Dim com As New OleDbCommand(sql, mConexion)
        Return com.ExecuteReader()

    End Function


    'Método para permitir modificar parcialmente los datos seleccionados dentro de la base de datos, ya que hemos considerado que el DNI, es un 
    'elemento que al ser unico en cada persona, no se puede modificar
    Public Function Cambio_Elementos(ByVal sql As String) As Integer

        Dim com As New OleDbCommand(sql, mConexion)
        Return com.ExecuteNonQuery()

    End Function

    'Fin de la clase AgenteDB.
End Class