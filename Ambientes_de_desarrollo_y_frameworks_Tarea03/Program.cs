using System; //Instrucciones using, sirve para ver la ubicación de las librerías que vamos a usar.

namespace Ambientes_de_desarrollo_y_frameworks_Tarea03 //El namespace sirve para dar el nombre al programa.
{
    class Program //Este es el nombre de la Clase.
    {
        static void Main(string[] args) //Este es el método Main que comienza la ejecución del programa en C#.
        {
            Console.WriteLine("ASIGNATURA. AMBIENTES DE DESARROLLO Y FRAMEWORKS\nUNIDAD 3. USO DEL .NET FRAMEWORK MEDIANTE CLASES\nTAREA 3.\n");

            //Aquí se le solicita al usuario que ingrese una opción para validar la suma o para salir del programa, en caso de que ingrese otra opción será una opción no válida.
            Console.WriteLine("PROGRAMA. INSTRUCCIONES DE DECISIÓN OCUPADAS EN C#.");
            Console.WriteLine("1. Conversión de Grados Celcius a Grados Fahrenheit.");
            Console.WriteLine("2. Contador de 3 en 3 hasta llegar al 999.");
            Console.WriteLine("3. Cálculo del área de un triángulo.");
            Console.Write("\nIngrese una opción: ");
            int opc = Convert.ToInt32(Console.ReadLine());
            switch (opc) //Aquí el switch evalúa la opción que ingresó el usuario.
            {
                case 1: //Si el usuario ingresa el número 1 se mostrará en la consola de salida todo el flujo del programa del case1.
                    double celcius; //Variable donde se almacenará el valor ingresado por el usuario.
                    double fahrenheit; //Variable donde se almacenará el resultado de la operación.
                    Console.WriteLine("PROGRAMA. CONVERSIÓN DE GRADOS CELCIUS A GRADOS FAHRENHEIT.");
                    Console.Write("\nIngrese el valor de los Grados Celcius: "); //Aquí se le solicita al usuario que ingrese un valor por teclado que se capturará en una variable de tipo double celcius.
                    celcius = double.Parse(Console.ReadLine());
                    fahrenheit = (celcius * (9/5)) + 32; //Aquí se efectuará la operación para realizar la conversión de grados celcius a grados fahrenheit usando el valor que ingresó el usuario.
                    //Aquí se mostrará en la consola de salida el resultado de efectuar el cálculo del área del triángulo y los valores de la base y la altura del triángulo que ingresó el usuario.
                    Console.WriteLine("La conversión de {0}°C a Grados Fahrenheit es: {1}°F", celcius, fahrenheit); //Aquí se mostrará en la consola de salida el valor que ingresó el usuario por teclado y el resultado de efectuar la conversión de grados celcius a grados fahrenheit.
                    break;
                case 2: //Si el usuario ingresa el número 2 se mostrará en la consola de salida todo el flujo del programa del case2.
                    Console.WriteLine("PROGRAMA. CONTADOR DE 3 EN 3 HASTA LLEGAR AL 999.");
                    Console.WriteLine("\nLa sucesión de números de 3 en 3 hasta llegar al 999 es: ");
                    for (int i = 3; i <= 1000; i += 3) //Este for nos ayuda a que se haga el recorrido de la variable.
                    {
                        Console.WriteLine(i); //Aquí se mostrará en la consola de salida la numeración de 3 en 3 hasta llegar al 999.
                    }
                    break;
                case 3: //Si el usuario ingresa el número 2 se mostrará en la consola de salida un mensaje de despedida.
                    //Declarando las variables de tipo double a utilizar.
                    double alt, bas; //Variables donde se almacenarán los valores ingresados por el usuario.
                    double area; //Variable donde se almacenará el resultado de la operación.
                    Console.WriteLine("PROGRAMA. CÁLCULO DEL ÁREA DE UN TRIÁNGULO.");
                    Console.Write("\nIngrese el valor de la base del triángulo: "); //Aquí se le solicita al usuario que teclee la base del triángulo que se capturará en una variable de tipo double bas.
                    bas = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el valor de la altura del triángulo: "); //Aquí se le solicita al usuario que teclee la altura del triángulo que se capturará en una variable de tipo double alt.
                    alt = double.Parse(Console.ReadLine());
                    area = (bas * alt) / (2); //Aquí se efectuará la operación para calcular el área del triángulo usando los valores que ingresó el usuario.
                    Console.WriteLine("\nLa base del triángulo es de: " + bas + " u\nLa altura del triángulo es de: " + alt + " u\nEl área del triángulo es de: " + area + " u^2"); //Aquí se mostrará en la consola de salida el resultado de efectuar el cálculo del área del triángulo y los valores de la base y la altura del triángulo que ingresó el usuario.
                    break;
                default: //Si el usuario ingresa cualquier otro número o carácter se mostrará en la consola de salida un mensaje de opción no válida.
                    Console.WriteLine("\nOPCIÓN NO VÁLIDA.");
                    break;
            }
            Console.ReadKey(); //Este es un comando para detener el programa, el ReadKey acepta cualquier tecla, mientras que el ReadLine solo acepta el Enter.
        }
    }
}