using System; //Instrucciones using, sirve para ver la ubicación de las librerías que vamos a usar.

namespace Aplicacion02_Ejemplo //El namespace sirve para dar el nombre al programa.
{
    class Program //Este es el nombre de la Clase.
    {
        static void Main(string[] args) //Este es el método Main que comienza la ejecución del programa en C#.
        {
            //Declarando la variable de tipo int a utilizar.
            int opc; //Variable donde se almacenará el valor ingresado por el usuario.
            Console.WriteLine("Elige una opción: ");
            Console.WriteLine("1. Convertir de °F a °C.");
            Console.WriteLine("2. Conteo de 1 en 1 hasta el 500.");
            opc = Int16.Parse(Console.ReadLine());
            if (opc == 1) //Aquí se está comparando si opc es igual a 1.
            {
                //Declarando las variables de tipo double a utilizar.
                double f, c; //Variables donde se almacenarán los valores ingresados por el usuario.
                const double b = 5/9; //Constante que no podrá cambiar de valor durante la ejecución del programa.
                Console.WriteLine("Programa que convierte de Grados Fahrenheit a Grados Celcius.");
                Console.WriteLine("Ingresa el valor de Grados Fahrenheit: "); //Aquí se le solicita al usuario que ingrese un valor por teclado que se capturará en una variable de tipo double f.
                f = double.Parse(Console.ReadLine());
                c = (f - 32) * b; //Aquí se efectuará la operación para realizar la conversión de grados fahrenheit a grados celcius usando el valor que ingresó el usuario.
                Console.WriteLine("La conversión a Grados Celcius es: {0}°C", c); //Aquí se mostrará en la consola de salida el resultado de efectuar la conversión de grados fahrenheit a grados celcius.
            }
            else if (opc == 2) //Aquí se está comparando si opc es igual a 2.
            {
                int a;
                Console.WriteLine("Programa que realiza una numeración de 1 en 1 hasta el 500.");
                for (a = 1; a < 501; a++) //Este for nos ayuda a que se haga el recorrido de la variable.
                {
                    Console.WriteLine(a); //Aquí se mostrará en la consola de salida la numeración de 1 en 1 hasta llegar al 500.
                }
            }
            Console.ReadKey(); //Este es un comando para detener el programa, el ReadKey acepta cualquier tecla, mientras que el ReadLine solo acepta el Enter.
        }
    }
}