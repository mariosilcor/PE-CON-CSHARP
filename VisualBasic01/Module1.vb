Module Module1 'Aquí empieza el módulo
    'Dim variableGlobal As Integer = 12 'Declaración de una variable de ámbito Global
    Sub Main() 'Aquí empieza el método Main.
        'Console.WriteLine("Hola!!!") 'Aquí muestra un mensaje en la consola del sistema.
        Console.ReadKey(True)
        'Dim numero As Integer = 12 'Instrucción Dim para declarar una variable.
        'numero = 15 'Asignar el valor a una variable de tipo Integer
        'Const PULGADA As Double = 2.54 'Instrucción Const para declarar una constante.
        'Dim num As Integer = 12
        'Dim pulgada As Double = 3.14
        'Dim letra As Char = "a"
        'Dim cadena As String = "Esto es una cadena"
        'Dim condicion As Boolean = True
        'variableGlobal = 24 'Asignación de la variable de ámbito Global

        'Entrada de datos por consola
        'Console.Write("Ingrese su nombre: ") 'Aquí se imprime por consola un mensaje al usuario.
        'Dim miNombre As String = Console.ReadLine() 'Aquí se declara una variable de tipo String y se asigna a la Clase Console y al método ReadLine.
        'Console.WriteLine("Bienvenido al Sistema " & miNombre) 'Aquí se imprime por consola un mensaje al usuario y con ayuda del operador &, el dato ingresado por teclado de tipo String almacenada en la variable miNombre.

        'Sentencia if-else
        'Realizar un programa que muestre por consola si un estudiante con el dinero que
        'tiene ahorrado puede pagar la universidad y estudiar, teniendo en cuenta que el
        'semestre del programa que estudia tiene un valor de 600.

        Dim estudia As Boolean = False 'Se declara una variable de tipo de dato Boolean y se inicializa en False.
        Console.Write("Ingresa el dinero ahorrado: ")
        Dim dineroAhorrado As Double = Console.ReadLine() 'Aquí se pide por teclado y se almacena lo que ingresa el usuario en la variable dineroAhorrado.
        If dineroAhorrado >= 600 Then 'Inicia Sentencia if simple.
            estudia = True
        End If 'Termina sentencia if simple.
        If estudia = True Then 'Inicia sentencia if else y evalúa si la variable estudia es True.
            Console.WriteLine("Si tienes el dinero suficiente para pagar la universidad")
        Else
            Console.WriteLine("No tienes el dinero suficiente para pagar la universidad")
        End If 'Termina sentencia if else.

        'Sentencia if-else anidado
        'Elaborar un programa de consola en VisualBasic.net, que ingresamdo el valor total de
        'una compra, realice un descuento de acuerdo a lo siguiente: si el valor de la compra
        'está entre 50-100 el descuento será del 5%, si está entre 101-150 el descuento será
        'del 10% y si la compra es mayor a 150 el descuento será del 15%, el programa debe
        'mostrar el total de la compra, el total de la compra con el descuento y el descuento.

        Console.WriteLine("Ingrese el valor total de la compra: ")
        'Aquí se muestra la entrada de datos por teclado.
        Dim valorCompra As Double = Console.ReadLine() 'Aquí se pide por teclado y se almacena lo que ingresa el usuario en la variable valorCompra.
        Dim descuento As Double = 0 'Se crea una variable para almacenar el descuento y se inicializa en 0.
        If valorCompra >= 50 And valorCompra <= 100 Then 'Inicia sentencia if elseif
            descuento = valorCompra * 0.05
        ElseIf valorCompra > 100 And valorCompra <= 150 Then
            descuento = valorCompra * 0.1
        ElseIf valorCompra > 150 Then
            descuento = valorCompra * 0.15
        End If 'Termina sentencia if elseif
        'Aquí se  muestra la salida del programa.
        Console.WriteLine("El valor total de la compra sin descuento es de: " & valorCompra)
        Console.WriteLine("El valor total de la compra con descuento es de: " & valorCompra - descuento)
        Console.WriteLine("El valor del descuento en la compra es de: " & descuento)

        'Estructura selectiva select case
        'Elaborar un programa de consola en Visual Basic.net, que permita realizar una operación básica matemática
        'entre dos números, teniendo en cuenta la opción del usuario por teclado, siendo:
        '1.Suma, 2.Resta, 3.Multiplicación, 4.División y 5.Porcentaje.

        Console.Write("Ingrese 1.Sumar, 2.Restar, 3.Multiplicar, 4.Dividir y 5.Porcentaje")
        Dim opcion As Integer = Console.ReadLine() 'Aquí se almacena la respuesta del usuario en una variable
        Dim numero1, numero2 As Double 'Aquí se crean dos variables de tipo de dato Double
        Select Case opcion 'Estructura selectiva Select Case
            Case 1 : Console.Write("Ingrese el primer número a sumar: ")
                numero1 = Console.ReadLine()
                Console.Write("Ingrese el segundo número a sumar: ")
                numero2 = Console.ReadLine()
                Console.WriteLine("La suma de los números es: " & (numero1 + numero2))
            Case 2 : Console.Write("Ingrese el primer número a restar: ")
                numero1 = Console.ReadLine()
                Console.Write("Ingrese el segundo número a restar: ")
                numero2 = Console.ReadLine()
                Console.WriteLine("La resta de los números es: " & (numero1 - numero2))
            Case 3 : Console.Write("Ingrese el primer número a multiplicar: ")
                numero1 = Console.ReadLine()
                Console.Write("Ingrese el segundo número a multiplicar: ")
                numero2 = Console.ReadLine()
                Console.WriteLine("La multiplicación de los números es: " & (numero1 * numero2))
            Case 4 : Console.Write("Ingrese el primer número a dividir: ")
                numero1 = Console.ReadLine()
                Console.Write("Ingrese el segundo número a dividir: ")
                numero2 = Console.ReadLine()
                Console.WriteLine("La división de los números es: " & (numero1 / numero2))
            Case 5 : Console.Write("Ingrese el número a sacar el porcentaje: ")
                numero1 = Console.ReadLine()
                Console.Write("Ingrese el porcentaje: ")
                numero2 = Console.ReadLine()
                Console.WriteLine("El " & numero2 & "% de " & numero1 & "es de: " & (numero1 * numero2) / 100)
            Case Else
                Console.WriteLine("La opción ingresada no existe")
        End Select

    End Sub 'Aquí termina el método Main
    Sub otroMetodo()
        'variableGlobal = 80 'Asignación de la variable de ámbito Global
    End Sub

End Module 'Aquí termina el módulo
