using System; //Instrucciones using, sirve para ver la ubicación de las librerías que vamos a usar.

namespace Ambientes_de_desarrollo_y_frameworks_Tarea02 //El namespace sirve para dar el nombre al programa.
{
    class Program //Este es el nombre de la Clase.
    {
        static void Main(string[] args) //Este es el método Main que comienza la ejecución del programa en C#.
        {
            Console.WriteLine("ASIGNATURA. AMBIENTES DE DESARROLLO Y FRAMEWORKS\nUNIDAD 2. INTRODUCCIÓN A VISUAL C#.NET\nTAREA 2.\n");
           
            //Declarando las variables de tipo double a utilizar.
            double alt, bas; //Variables donde se almacenarán los valores ingresados por el usuario.
            double area; //Variable donde se almacenará el resultado de la operación.
            Console.WriteLine("PROGRAMA. CÁLCULO DEL ÁREA DE UN TRIÁNGULO.");
            Console.Write("\nIngrese el valor de la base del triángulo: "); //Aquí se solicita al usuario que teclee la base del triángulo que se capturará en una variable de tipo double bas.
            bas = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de la altura del triángulo: "); //Aquí se solicita al usuario que teclee la altura del triángulo que se capturará en una variable de tipo double alt.
            alt = double.Parse(Console.ReadLine());
            area = (bas * alt)/(2); //Aquí se efectuará la operación para calcular el área del triángulo usando los valores que ingresó el usuario.
            Console.WriteLine("\nLa base del triángulo es de: " + bas + " u\nLa altura del triángulo es de: " + alt + " u\nEl área del triángulo es de: " + area + " u^2"); //Aquí se mostrará en la consola de salida el resultado de efectuar el cálculo del área del triángulo y los valores de la base y la altura del triángulo que ingresó el usuario.
            Console.ReadKey(); //Este es un comando para detener el programa, el ReadKey acepta cualquier tecla, mientras que el ReadLine solo acepta el Enter.
        }
    }
}