Module Module1
    'CONTINUACIÓN PROGRAMA 02 - ÁMBITO DE LAS VARIABLES.
    Dim numero3 As Integer = 12 'Declaración o creación y asignación de una variable de ámbito global
    Sub Main() 'Inicia Método Main
        'PROGRAMA 01 - DECLARACIÓN DE VARIABLES Y CONSTANTES.
        'Declarar y asignar el valor a una variable de tipo de dato Integer
        Dim numero0 As Integer = 12 'Instrucción Dim que nos permite declarar o crear una varible

        'Otra forma de asignar el valor a una variable de tipo de dato Integer
        Dim numero1 As Integer
        numero1 = 12

        'Declarar y asignar el valor a una constante de tipo de dato Double
        Const PULGADA As Double = 2.54 'Instrucción Const que nos permite declarar o crear una constante

        'Declarar y asignar el valor a una variable de tipo de dato Char
        Dim letra As Char = "a"

        'Declarar y asignar el valor a una variable de tipo de dato String
        Dim cadena As String = "Cadena de caracteres"

        'Declarar y asignar el valor a una variable de tipo de dato Boolean
        Dim condicion As Boolean = True

        'PROGRAMA 02 - ÁMBITO DE LAS VARIABLES.
        Dim numero2 As Integer = 12 'Declaración o creación y asignación de una variable de ámbito local
        numero2 = 24 'Sobreescribir el valor de una variable de ámbito local

        numero3 = 24 'Sobreescribir el valor de una variable de ámbito global dentro del Método Main

        'PROGRAMA 03 - OPERADORES Y EXPRESIONES.
        Dim aritmetico1 As Double = 8 / 3 'Variable que almacenará el resultado de la expresión aritmética
        Console.WriteLine(aritmetico1) 'Instrucción que imprimirá por consola el valor que contiene la variable 

        Dim aritmetico2 As Integer = 8 'Variable que asignará el valor inicial de tipo de dato Integer
        aritmetico2 += 8 'Sobreescribir el valor de la variable que asignará el operador aritmético de incremento
        aritmetico2 -= 2 'Sobreescribir el valor de la variable que asignará el operador aritmético de decremento
        Console.WriteLine(aritmetico2) ' Instrucción que imprimirá por consola el valor que contiene la variable






    End Sub 'Termina Método Main
    'CONTINUACIÓN PROGRAMA 02 - ÁMBITO DE LAS VARIABLES.
    Sub otroMetodo() 'Creación de un nuevo procedimiento o un nuevo método otroMetodo
        numero3 = 40 'Sobreescribir el valor de una variable de ámbito global
    End Sub 'Termina otroMetodo

End Module
