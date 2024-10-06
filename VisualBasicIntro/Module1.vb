Imports System

'Autor: Mario.
'Fecha: 19/11/2023.
'Este módulo sirve para enseñar como funciona Visual Basic.NET
Module Module1

    Sub Main(args As String())
        'EJERCICIO 02. TIPOS DE DATOS EN C#.
        '*Declaramos dos variables enteras y le asignamos un valor.
        '*Declaramos otra variable entera y le asignamos la suma de las dos variables anteriores.
        '*Declaramos tres variables de tipo entero en una sola línea.
        '*Declaramos dos variables de tipo doble y le asignamos un valor.
        '*Declaramos una tercer variable de tipo doble y le asignamos la suma de las dos variables enteras y la suma de las dos variables dobles.
        Dim num1 As Integer = 1
        Dim num2 As Integer = 1
        Dim suma As Integer = num1 + num2
        Dim num3 As Integer = 1, num4 As Integer = 2, num5 As Integer = 3
        Dim valD1 As Double = 5.5
        Dim valD2 As Double = 6.6
        Dim sumaD As Double = valD1 + valD2
        Dim valFloat As Single = 5.5F
        Dim sumaFD = sumaD + valFloat

        Console.WriteLine(num1 & "+" & num2 & " = " & suma)
        Console.WriteLine(valD1 & "+" & valD2 & " = " & sumaD)
        Console.WriteLine(sumaD & "+" & valFloat & " = " & sumaFD)
        Console.WriteLine("Suma es de tipo " & suma.GetType.ToString())
        Console.WriteLine("SumaD es de tipo " & sumaD.GetType.ToString())
        Console.WriteLine("SumaFD es de tipo " & sumaFD.GetType.ToString())
        Console.ReadKey()
    End Sub
End Module
