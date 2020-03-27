'Clase donde recibiremos los valores de A, B Y C y procederemos a dividir la ecuación por tipo y luego calcularemos
'su resultado.
Public Class ecuacion

    'ATRIBUTOS DE LA CLASE

    'Soluciones de la ecuación
    Private resultado1 As String
    Private resultado2 As String

    'Terminos de la ecuación
    Private Termino_A As Double
    Private Termino_B As Double
    Private Termino_C As Double

    'Tipo de ecuación: 
    'tipo_1: reales 
    'tipo_2: dobles
    'tipo_3: complejas
    Private tipo As Integer


    'Constructor, donde le pasamos los numeros de las cajas A, B y C y llamamos al metodo que ejecuta la ecuación
    Sub New(ByVal A As Double, ByVal B As Double, ByVal C As Double)
        Termino_A = A
        Termino_B = B
        Termino_C = C
        Calculadora()
    End Sub

    'Metodo que calcula las soluciones de la ecuación según el tipo de ecuación
    Public Sub Calculadora()

        'Variable que usaremos para calcular lo que hay dentro de la raiz.
        Dim Dentro_Raiz As Double = 0.0
        Dentro_Raiz = Termino_B ^ 2 - 4 * Termino_A * Termino_C

        'Cuando lo de dentro de la raiz es 0, tienen raices dobles
        If Dentro_Raiz = 0 Then
            resultado1 = " " & (-Termino_B / 2 * Termino_A)
            resultado2 = " " & (-Termino_B / 2 * Termino_A)
            tipo = 2
        Else
            'Cuando lo de dentro de la raiz es mayor a 0, tienen raices reales
            If Dentro_Raiz > 0 Then
                resultado1 = Math.Round(Convert.ToDouble((-Termino_B + Math.Sqrt(Dentro_Raiz)) / 2 * Termino_A), 2)
                resultado2 = Math.Round(Convert.ToDouble((-Termino_B - Math.Sqrt(Dentro_Raiz)) / 2 * Termino_A), 2)
                tipo = 1
                'Cuando no es ni mayor/igual a 0, seria el tipo de ecuación con raices complejas
            Else
                resultado1 = -Termino_B / 2 * Termino_A & "+" & Math.Round(Math.Sqrt(Dentro_Raiz * -1) / 2 * Termino_A, 2) & "i"
                resultado2 = -Termino_B / 2 * Termino_A & "-" & Math.Round(Math.Sqrt(Dentro_Raiz * -1) / 2 * Termino_A, 2) & "i"
                tipo = 3
            End If
        End If
    End Sub

    'Metodos de consulta del valor de los atributos.

    'Metodo para saber el valor del resultado_1
    Public ReadOnly Property getresultado1 As String
        Get
            Return resultado1
        End Get
    End Property

    'Metodo para saber el valor del resultado_2
    Public ReadOnly Property getresultado2 As String
        Get
            Return resultado2
        End Get
    End Property

    'Metodo para saber el valor del tipo de ecuación, los tipos estan definidos antes de la declaración del atributo
    Public ReadOnly Property gettipo As Integer
        Get
            Return tipo
        End Get
    End Property

    'Fin de la clase
End Class