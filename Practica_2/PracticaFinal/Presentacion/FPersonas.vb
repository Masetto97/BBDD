'Clase que contiene la funcionalidad relacionada con la parte visual del programa.
Public Class FPersonas

    'Función que carga la lista de personas. Inicialización de las funciones a False hasta ser clickadas.
    Private Sub FPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAnadir.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnLimpiar.Enabled = False
        btnConectar.Enabled = False
    End Sub

    'Referencia al objeto que muestra la lista de personas en la base de datos.
    Private Sub lstPersonas_Click(sender As Object, e As EventArgs) Handles lstPersonas.Click
        Dim rowview As DataRowView = lstPersonas.SelectedItem
        txtDni.Text = lstPersonas.SelectedValue
        Dim row As DataRow = rowview.Row
        txtNombre.Text = row(1)

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos() 'Llamada a la función LimpiarCampos
    End Sub

    'Función del botón modificar que permite actualizar los datos de una persona que ya se encuentre en la base de datos.
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If Not txtDni.Text = "" Then
            Dim persona As New Personas
            persona.getDNI = txtDni.Text
            persona.getNombre = txtNombre.Text
            persona.modificarDatos()

            CargarPersonas() 'Llamada a la función CargarPersonas
            LimpiarCampos() 'Llamada a la función LimpiarCampos
            MsgBox("Datos Modificados")
        Else
            MsgBox("Debes seleccionar una PERSONA")
        End If

    End Sub

    'Función que permite cargar las personas de la base de datos por su dni y nombre.
    Private Sub CargarPersonas()
        Dim personas As New Personas
        Dim tabla As New DataTable("Personas")
        tabla.Columns.Add("personid", Type.GetType("System.String"))
        tabla.Columns.Add("personname", Type.GetType("System.String"))

        Dim drG As DataRow

        personas.leertodo()

        For Each personas In personas.migestor.miListaDePersonas
            drG = tabla.NewRow
            drG.Item("personid") = personas.getDNI
            drG.Item("personname") = personas.getNombre
            tabla.Rows.InsertAt(drG, 0)
        Next

        lstPersonas.DataSource = tabla
        lstPersonas.DisplayMember = tabla.Columns(0).ToString
        lstPersonas.ValueMember = tabla.Columns(0).ToString
        lstPersonas.SelectedIndex = -1


    End Sub

    'Limpia los campos de texto en los que se introducen el nombre y el dni.
    Private Sub LimpiarCampos()
        txtDni.Text = ""
        txtNombre.Text = ""
    End Sub

    'Funcionalidad del botón Eliminar.
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim seguro As Integer
        If Not txtDni.Text = "" Then

            seguro = MsgBox("¿Estás seguro de que desea borrar esta persona?.", vbYesNo + vbExclamation + vbDefaultButton2, "Borrar Persona.")
            If (seguro = vbYes) Then
                Dim persona As New Personas
                persona.getDNI = txtDni.Text

                Try
                    persona.eliminarDatos()
                    CargarPersonas()
                    LimpiarCampos()
                    MsgBox("Datos Eliminados")

                Catch ex As Exception
                    MessageBox.Show("Error al eliminar la persona.", "Error persona.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End Try
            End If
        Else
            MsgBox("Debes seleccionar una PERSONA")
        End If
    End Sub

    'Funcionalidad del botón Añadir.
    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click
        If Not txtDni.Text = "" Then
            If Not dniExistente() Then
                If Not txtNombre.Text = "" Then
                    Dim persona As New Personas
                    persona.getDNI = txtDni.Text
                    persona.getNombre = txtNombre.Text
                    persona.insertarDatos()

                    CargarPersonas()
                    LimpiarCampos()
                    MsgBox("Datos Insertados")
                Else
                    MsgBox("Debes introducir un NOMBRE")
                End If
            Else
                MsgBox("DNI ya existente en la base de datos")
            End If
        Else
            MsgBox("Debes introducir una DNI")
        End If

    End Sub

    'Funcionalidad del botón Buscar (el usuario busca base de datos manualmente).
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim openfile As New OpenFileDialog
        openfile.InitialDirectory = "c:\Desktop"
        openfile.Filter = "Ficheros de bases de datos (*.accdb)|*.accdb|All files (*.*)|*.*"
        openfile.RestoreDirectory = True

        If (openfile.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            txtRuta.Text = openfile.FileName()
            AgenteBD.ruta = txtRuta.Text
        Else
            Exit Sub
        End If
        btnConectar.Enabled = True
    End Sub

    'Funcionalidad del botón Conectar.
    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        MsgBox("BASE DE DATOS CONECTADA CORRECTAMENTE")
        CargarPersonas()
        btnAnadir.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        btnLimpiar.Enabled = True
        btnConectar.Enabled = True
    End Sub

    'Función encargada de comprobar que el dni coincide con uno ya contenido en
    'la base de datos para la modificación de los datos referidos al mismo.
    Function dniExistente() As Boolean
        Dim encontrado As Boolean = False
        Dim dgrview As DataRowView
        Dim dgr As DataRow
        For i = 0 To lstPersonas.Items.Count - 1
            dgrview = lstPersonas.Items(i)
            dgr = dgrview.Row
            If dgr.Item("personid") = txtDni.Text Then
                encontrado = True
            End If
        Next
        dniExistente = encontrado
    End Function
End Class