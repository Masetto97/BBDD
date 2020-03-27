
'Clase principal, en la cual llamamos a nuestra clase ecuación para obtener el tipo y los resultados, y ademas sirve como 
'intermediaria con la interfaz, emitiendo mensajes cada vez que una operación no es valida.
Public Class Main

    'ATRIBUTOS DE LA CLASE

    Private A As Double
    Private B As Double
    Private C As Double

    'Metodo usado para la creación de los objetos y para iniciar los atributos
    Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Inicialización de los atributos a 0.0
        A = 0.0
        B = 0.0
        C = 0.0
    End Sub

    'Metodo usado para calcular el resultado de las ecuaciones, así como  el tipo de ecuación y mostrar las soluciones y el tipo
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click

        'Declaración de la clase ecuacion, para así poder utilizar sus metodos.
        Dim ecuacion As ecuacion
        'Variable booleana que se encarga de comprobar si no hay ningun error para poder calcular la ecuación bien
        Dim Correcto As Boolean = False
        'Llamada al metodo Comprobar para ver si no hay ningun error
        Correcto = Comprobar()

        If Correcto Then

            'Cuando Correcto es true, se procede a llamar al contructor de la clase ecuacion
            ecuacion = New ecuacion(A, B, C)

            'Obtencion de los resultados de la ecuación
            lblr1.Text = ecuacion.getresultado1
            lblr2.Text = ecuacion.getresultado2

            'Para elegir el tipo de ecuacion, necesitamos saber cual de los 3 tipos es, para ello hacemos una selección multiple
            'que dependiendo del valor de tipo, eligirá una opción u otra.

            Select Case (ecuacion.gettipo)
                'tipo_1: reales 
                Case 1

                    lblResult.Text = "Raices Reales"
                    lblResult.ForeColor = Color.Blue
                    lblr1.ForeColor = Color.Blue
                    lblr2.ForeColor = Color.Blue

                'tipo_2: dobles
                Case 2

                    lblResult.Text = "Raices Dobles"
                    lblResult.ForeColor = Color.Blue
                    lblr1.ForeColor = Color.Blue
                    lblr2.ForeColor = Color.Blue

                'tipo_3: complejas
                Case 3

                    lblResult.Text = "Raices Complejas"
                    lblResult.ForeColor = Color.Red
                    lblr1.ForeColor = Color.Red
                    lblr2.ForeColor = Color.Red

            End Select
        End If
    End Sub


    'Metodo para comprobar que todo lo introduccido es correcto
    Function Comprobar() As Boolean

        'Varibles usadas en el metodo para comprobar que todo es valido
        Dim errores As String = ""
        Dim valido As Boolean = False

        'Comprobamos que los cuadros de texto de A, B Y C, no este vacio, en el caso de que esté muestra una ventana emergente
        'diciendo que no ha introduccido un valor
        If txtA.Text = "" Then
            errores = errores + "No has introducido valor en A" & vbCr
        End If
        If txtB.Text = "" Then
            errores = errores + "No has introducido valor en B" & vbCr
        End If
        If txtC.Text = "" Then
            errores = errores + "No has introducido valor en C" & vbCr
        End If
        If Not errores = "" Then
            MsgBox(errores)
        Else
            'Comprobamos que los cuadros de texto de A, B Y C son valores numéricos
            If Not IsNumeric(txtA.Text) Then
                errores = errores + "Valor de A no numerico" & vbCr
            End If
            If Not IsNumeric(txtB.Text) Then
                errores = errores + "Valor de B no numerico" & vbCr
            End If
            If Not IsNumeric(txtC.Text) Then
                errores = errores + "Valor de C no numerico" & vbCr
            End If
            If Not errores = "" Then
                MsgBox(errores)
                valido = False
            Else
                'Ahora tratamos los decimales, es decir, comprobamos que si ponen un "." se cambie por una coma, para así evitar
                ' de que se produzca un error sintactica 
                A = Convert.ToDouble(Replace(txtA.Text, ".", ","))
                B = Convert.ToDouble(Replace(txtB.Text, ".", ","))
                C = Convert.ToDouble(Replace(txtC.Text, ".", ","))
                If A = 0 Then
                    MsgBox("A no puede ser 0")
                    valido = False
                Else
                    valido = True
                End If
            End If
        End If
        'Devolvemos el valor de la variable valido
        Return valido
    End Function


    'Fin de la clase
End Class