//Instrucciones using, sirve para ver la ubicación de las librerías que vamos a usar
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase_dos //El namespace sirve para dar el nombre al programa
    //DeclaraciónDeVariables
{
    /* Ejemplo de: 
     * Declaración de variables
     * Asignación de valores constantes
     * Uso de las variables
     */
    class Program // Este es el nombre de la Clase
    {
        static void Main(string[] args)
        {
            //Aquí estamos declarando variables de diferentes tipos
            byte numeroDeAlumnos;
            int poblacionDeLaCiudad;
            long poblacionMundial;
            float PI;
            decimal precioDelArticulo;
            char letraIngresada;
            bool esAlto;
            //Aquí estamos asignando los valores constantes a las variables
            numeroDeAlumnos = 25;
            poblacionDeLaCiudad = 2500000;
            poblacionMundial = 7500000000;
            PI = 3.1416F;
            letraIngresada = 'U';
            precioDelArticulo = 18.95M;
            esAlto = true;
            //Aquí se van a usar las variables que declaramos anteriormente
            Console.WriteLine("El número de alumnos es: " + numeroDeAlumnos); 
            Console.WriteLine("La población de la ciudad es: " + poblacionDeLaCiudad); 
            Console.WriteLine("La población mundial es: " + poblacionMundial); 
            Console.WriteLine("El valor de PI es: " + PI);
            Console.WriteLine("El precio del artículo es: $" + precioDelArticulo) ;
            Console.WriteLine("La letra ingresada es: " + letraIngresada);
            Console.WriteLine("Es la persona alta?: " + esAlto);

            //Este es un comando para detener el programa, el ReadKey acepta cualquier tecla, mientras que el ReadLine solo aceptar el Enter
            Console.ReadKey();
        }
    }
}
