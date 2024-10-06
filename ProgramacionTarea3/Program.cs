using System; //Instrucciones using, sirve para ver la ubicación de las librerías que vamos a usar.

namespace ProgramacionTarea2 //El namespace sirve para dar el nombre al programa.
{
    class Program // Este es el nombre de la Clase.
    {
        static void Main(string[] args) //Este es el método Main que comienza la ejecución del programa en C#.
        {
            Console.WriteLine("ASIGNATURA. PROGRAMACIÓN ESTRUCTURADA\nUNIDAD 3. SENTENCIAS DE CONTROL DEL PROGRAMA\nTAREA 3.\n");
            //Aquí se le solicita al usuario que ingrese una opción para validar la suma o para salir del programa, en caso de que ingrese otra opción será una opción no válida.
            Console.WriteLine("1. Validar la suma");
            Console.WriteLine("2. Salir del programa");
            Console.Write("\nIngrese una opción: ");
            int opc = Convert.ToInt32(Console.ReadLine()); 
            switch (opc) //Aquí el switch evalúa la opción que ingresó el usuario.
            {
                case 1: //Si el usuario ingresa el número 1 se mostrará en la consola de salida todo el flujo del programa del case1.
                    int sum1, sum2, sum3, num1, num2, num3; //Declarando las variables de tipo int a utilizar.
                    Console.Write("\nEscribe el primer número: "); //Aquí se le solicita al usuario que ingrese un primer número que se capturará en una variable de tipo int num1.
                    num1 = int.Parse(Console.ReadLine());
                    Console.Write("Escribe el segundo número: "); //Aquí se le solicita al usuario que ingrese un segundo número que se capturará en una variable de tipo int num2.
                    num2 = int.Parse(Console.ReadLine());
                    Console.Write("Escribe el tercer número: "); //Aquí se le solicita al usuario que ingrese un tercer número que se capturará en una variable de tipo int num3.
                    num3 = int.Parse(Console.ReadLine());
                    //Aquí se realizan las sumas y también se va asignando el resultado a cada variable.
                    sum1 = num1 + num2;
                    sum2 = num2 + num3;
                    sum3 = num3 + num1;
                    if ((sum1 == sum2) && (sum2 == sum3) && (sum3 == sum1)) //Aquí se está comparando si sum1 es igual a sum2, si sum2 es igual a sum3 y si sum3 es igual a sum1.
                    {
                        //Aquí se mostrará en la consola de salida el resultado de efectuar cada una de las tres sumas, si el usuario ingreso los tres números iguales.
                        Console.WriteLine("\nLa primer suma de: " + num1 + " + " + num2 + " = " + sum1);
                        Console.WriteLine("La segunda suma de: " + num2 + " + " + num3 + " = " + sum2);
                        Console.WriteLine("La tercera suma de: " + num3 + " + " + num1 + " = " + sum3);
                        Console.WriteLine("\nLa primer suma es igual a la segunda suma\nLa segunda suma es igual a la tercer suma\nLa tercer suma es igual a la primer suma\n\nTodas las sumas son iguales");
                    }
                    else if ((sum1 != sum2) && (sum2 != sum3) && (sum3 == sum1)) //Aquí se está comparando si sum1 es diferente a sum2, si sum2 es diferente a sum3 y si sum3 es igual a sum1.
                    {
                        //Aquí se mostrará en la consola de salida el resultado de efectuar cada una de las tres sumas, si el usuario ingreso el primer número diferente y el segundo y tercer número iguales.
                        Console.WriteLine("\nLa primer suma de: " + num1 + " + " + num2 + " = " + sum1);
                        Console.WriteLine("La segunda suma de: " + num2 + " + " + num3 + " = " + sum2);
                        Console.WriteLine("La tercera suma de: " + num3 + " + " + num1 + " = " + sum3);
                        Console.WriteLine("\nLa primer suma es diferente a la segunda suma\nLa segunda suma es diferente a la tercer suma\nLa tercer suma es igual a la primer suma");
                    }
                    else if ((sum1 != sum2) && (sum2 == sum3) && (sum3 != sum1)) //Aquí se está comparando si sum1 es diferrente a sum2, si sum2 es igual a sum3 y si sum3 es diferente a sum1.
                    {
                        //Aquí se mostrará en la consola de salida el resultado de efectuar cada una de las tres sumas, si el usuario ingreso el tercer número diferente y el primer y segundo número iguales.
                        Console.WriteLine("\nLa primer suma de: " + num1 + " + " + num2 + " = " + sum1);
                        Console.WriteLine("La segunda suma de: " + num2 + " + " + num3 + " = " + sum2);
                        Console.WriteLine("La tercera suma de: " + num3 + " + " + num1 + " = " + sum3);
                        Console.WriteLine("\nLa primer suma es diferente a la segunda suma\nLa segunda suma es igual a la tercer suma\nLa tercer suma es diferente a la primer suma");
                    }
                    else if ((sum1 == sum2) && (sum2 != sum3) && (sum3 != sum1)) //Aquí se está comparando si sum1 es igual a sum2, si sum2 es diferente a sum3 y si sum3 es diferente a sum1.
                    {
                        //Aquí se mostrará en la consola de salida el resultado de efectuar cada una de las tres sumas, si el usuario ingreso el segundo número diferente y el primer y tercer número iguales.
                        Console.WriteLine("\nLa primer suma de: " + num1 + " + " + num2 + " = " + sum1);
                        Console.WriteLine("La segunda suma de: " + num2 + " + " + num3 + " = " + sum2);
                        Console.WriteLine("La tercera suma de: " + num3 + " + " + num1 + " = " + sum3);
                        Console.WriteLine("\nLa primer suma es igual a la segunda suma\nLa segunda suma es diferente a la tercer suma\nLa tercer suma es diferente a la primer suma");
                    }
                    else //Entonces quiere decir que los tres números que ingreso el usuario son diferentes.
                    {
                        //Aquí se mostrará en la consola de salida el resultado de efectuar cada una de las tres sumas, si el usuario ingreso los tres números diferentes.t
                        Console.WriteLine("\nLa primer suma de: " + num1 + " + " + num2 + " = " + sum1);
                        Console.WriteLine("La segunda suma de: " + num2 + " + " + num3 + " = " + sum2);
                        Console.WriteLine("La tercera suma de: " + num3 + " + " + num1 + " = " + sum3);
                        Console.WriteLine("\nLa primer suma es diferente a la segunda suma\nLa segunda suma es diferente a la tercer suma\nLa tercer suma es diferente a la primer suma\n\nTodas las sumas son diferentes");
                    }
                    break;
                case 2: //Si el usuario ingresa el número 2 se mostrará en la consola de salida un mensaje de despedida.
                    Console.WriteLine("\nHasta Pronto");
                    break;
                default: //Si el usuario ingresa cualquier otro número o carácter se mostrará en la consola de salida un mensaje de opción no válida.
                    Console.WriteLine("\nOpción no válida");
                    break;
            }
            Console.ReadKey(); //Este es un comando para detener el programa, el ReadKey acepta cualquier tecla, mientras que el ReadLine solo acepta el Enter.
        }
    }
}
