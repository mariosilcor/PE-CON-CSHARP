using System; //Instrucciones using, sirve para ver la ubicación de las librerías que vamos a usar.

namespace Aplicacion01_Ejemplo //El namespace sirve para dar el nombre al programa.
{
    class Program //Este es el nombre de la Clase.
    {
        static void Main(string[] args) //Este es el método Main que comienza la ejecución del programa en C#.
        {
            //Declarando las variables de tipo int a utilizar.
            int a, b; //Variables donde se almacenarán los valores ingresados por el usuario.
            int c;  //Variable donde se almacenará el resultado de la operación.
            Console.WriteLine("Ingrese el primer valor: "); //Aquí se solicita al usuario que teclee el primer número que se capturará en una variable de tipo int a.
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor: "); //Aquí se solicita al usuario que teclee el segundo número que se capturará en una variable de tipo int b.
            b = Int32.Parse(Console.ReadLine());
            c = a + b; //Aquí se efectuará la operación de la suma usando los valores que ingresó el usuario.
            Console.WriteLine("El resultado de la suma es: {0} ", c); //Aquí se mostrará en la consola de salida el resultado de efectuar la operación de la suma.
            Console.ReadKey(); //Este es un comando para detener el programa, el ReadKey acepta cualquier tecla, mientras que el ReadLine solo acepta el Enter.
        }
    }
}