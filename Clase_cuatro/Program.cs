using System;

namespace Clase_cuatro
{
    class Program
    {
        static void Main(string[] args) //Este es el método Main.
        {
            //Se declaran las variables a utilizar
            int numero = 1; //Variable donde se va a recibir la entrada del teclado
            int factorial = 1; //Variable que va a ir acumulando el valor del factorial
            Console.Write("Introduce un número para obtener su factorial: "); //El Write deja el cursor en la misma línea
            //El método ReadLine pertenece a la Consola que da como resultado un String. pero el String no se puede asignar a numero porque numero es entero, entonces la función Parse de la clase Int16 lo que hace es convertir el String a un entero ded 16 bits y lo asigna a la variable numero.
            numero = Int16.Parse(Console.ReadLine()); //Aquí se va a recibir lo que el usuario ingreso
            for (int i = 0; i <= numero; i++)
            {
                factorial = factorial * (i + 1);
            }
            //La función WriteLine siempre tiene como parámetro un String y siempre el parámetro de una función está separado por comas
            //El parámetro de la función WriteLine siempre se cuenta a partir de 0 los siguientes parámetros del WriteLine, que en este caso es factorial
            Console.WriteLine("El factorial es: {0}", factorial); //El WriteLine baja el cursor a la siguiente línea.

            //for que contiene dos variables de control, las variables i y j.
            //La expresión de control incluye a ambas variables i y j.
            //También dentro del for hay 2 actualizaciones, i va incrementando y j va disminuyendo.
            for (int i = 0, j = 9; i < j; i++, j--)
            {
                //Primero se va a imprimir el primer parámetro 0 el valor de i y después se va a imprimir el segundo parámetro 1 el valor de j.
                Console.WriteLine(" i = {0}, j = {1}", i, j);
            }

            //Se declara la variable de control continuar de tipo char y se inicializa con s.
            char continuar = 's';
            //Se declara la variable que almacenará la opción que vaya a ingresar el usuario.
            int opcion = 0;
            do
            {
                //Cada vez que se muestre el menú se borrará la pantalla.
                Console.Clear();
                //Aquí se le muestra las opciones del menú al usuario.
                Console.WriteLine("Elige una opción: ");
                Console.WriteLine("1: Primera opción: ");
                Console.WriteLine("2: Segunda opción: ");
                Console.WriteLine("3: Tercera opción: ");
                Console.Write("Opción: ");
                //Aquí va a esperar el programa a que el usuario ingrese una opción.
                opcion = Int32.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        //Aquí le muestra el mensaje al usuario si ingreso como opción 1.
                        Console.WriteLine("Elegiste la primera opción");
                        break;
                    case 2:
                        //Aquí le muestra el mensaje al usuario si ingreso como opción 2.
                        Console.WriteLine("Elegiste la segunda opción");
                        break;
                    case 3:
                        //Aquí le muestra el mensaje al usuario si ingreso como opción 3.
                        Console.WriteLine("Elegiste la tercera opción");
                        break;
                    default:
                        //Aquí le muestra el mensaje al usuario si ingreso una opción inválida
                        Console.WriteLine("Opción no válida");
                        break;
                }
                //Aquí se le pregunta al usuario si desea continuar.
                //A la variable continuar se le asigna lo que el usuario ingrese, se convertirá a char y se asignará a continuar.
                Console.Write("Desea continuar?");
                continuar = char.Parse(Console.ReadLine());
                //Esta es la condición del while, Mientras que la variable continuar sea igual a 's' o que la variable continuar sea igual a 'S'
            } while ((continuar == 's') || (continuar == 'S'));

            Console.ReadKey(); //Detiene la ejecución del programa hasta que se ingrese una tecla.
        }
    }
}
