using System; //Instrucciones using, sirve para ver la ubicación de las librerías que vamos a usar.

namespace ProgramacionTarea2 //El namespace sirve para dar el nombre al programa.
{
    class Program // Este es el nombre de la Clase.
    {
        static void Main(string[] args) //Este es el método Main que comienza la ejecución del programa en C#.
        {
            //Declarando las variables de tipo double a utilizar.
            double num1, num2; //Variables donde se almacenarán los valores ingresados por el usuario.
            double sum, rest, mult, div, res; //Variables donde se almacenarán los resultados de cada operación.

            Console.WriteLine("ASIGNATURA. PROGRAMACIÓN ESTRUCTURADA\nUNIDAD 2. PROGRAMACIÓN ESTRUCTURADA\nTAREA 2.\n");
            Console.Write("Escribe el primer número: "); //Aquí se solicita al usuario que teclee el primer número que se capturará en una variable de tipo double num1.
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Escribe el segundo número: "); //Aquí se solicita al usuario que teclee el segundo número que se capturará en una variable de tipo double num2.
            num2 = double.Parse(Console.ReadLine()); 

            //Aquí se efectuarán las cuatro operaciones básicas usando los valores que ingreso el usuario
            sum = num1 + num2;
            rest = num1 - num2;
            mult = num1 * num2;
            div = num1 / num2;
            res = num1 % num2; // El operador módulo "%" calcula el residuo después de dividir el primer operando por el segundo operando.

            //Aquí se mostrará en la consola de salida el resultado de efectuar cada una de las cuatro operaciones básicas, más el residuo, con los dos valores capturados.
            Console.WriteLine("\nEl resultado de la suma es: " + sum);
            Console.WriteLine("El resultado de la resta es: " + rest);
            Console.WriteLine("El resultado de la multiplicación es: " + mult);
            Console.WriteLine("El resultado de la división es: " + div);
            Console.WriteLine("El resultado del residuo es: " + res);
            Console.WriteLine("\nTu primer número ingresado fue: " + num1);
            Console.WriteLine("Tu segundo número ingresado fue: " + num2);
            Console.ReadKey(); //Este es un comando para detener el programa, el ReadKey acepta cualquier tecla, mientras que el ReadLine solo acepta el Enter.
        }
    }
}
