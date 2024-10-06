using System; //Instrucciones using, sirve para ver la ubicación de las librerías que vamos a usar.

namespace ProgramacionTarea6 //El namespace sirve para dar el nombre al programa.
{
    class Program //Este es el nombre de la Clase.
    {
        static void Main(string[] args) //Este es el método Main que comienza la ejecución del programa en C#.
        {
            Console.WriteLine("ASIGNATURA. PROGRAMACIÓN ESTRUCTURADA\nUNIDAD 4. TIPOS ESTRUCTURADOS DE DATOS\nTAREA 6.\n");
            int fila, col; //Declarando las variables de tipo int a utilizar.
            do //Aquí si el usuario ingresa un valor menor a 1 o un valor mayor a 10, tendrá que intentarlo nuevamente.
            {
                Console.Write("Ingrese el tamaño del arreglo bidimensional: "); //Aquí se le solicita al usuario que ingrese un valor que será el tamaño del arreglo bidimensional.
                fila = Convert.ToInt32(Console.ReadLine()); //El método ReadLine nos regresa un tipo de dato String, así que se tendrá que convertir a un tipo de dato int.
                if (fila < 1 || fila > 10) //Si el usuario ingresa un valor menor a 1 o un valor mayor a 10, tendrá que intentarlo nuevamente.
                {
                    Console.Write("\nPor favor, vuelva a ingresar el tamaño del arreglo y únicamente ingrese valores de 1 a 10.\n"); //Aquí se le solicita al usuario que ingrese un valor igual o mayor a 1 o un valor igual o menor a 10.
                }
                else if (fila >= 1 && fila <= 10) //Si el usuario ingresa un valor igual o mayor a 1 o un valor igual o menor a 10 se ejecutará el código dentro del else-if.
                {
                    Console.WriteLine(""); //Aquí se hará un salto de línea.
                    col = fila; //Aquí se asigna a la variable col la variable fila.
                    int[,] a = new int[fila, col]; //Aquí se asigna al arreglo unidimensional de tipo int la nueva creación de un arreglo bidimensional de tipo int.
                    //Aquí se están inicializando dos arreglos de valores de tipo int.
                    for (int i = 0; i < fila; i++) //Este for nos ayuda a que se haga el recorrido del arreglo.
                    {
                        for (int j = 0; j < col; j++) //Este for nos ayuda a que se haga el recorrido del arreglo.
                        {
                            a[i, j] = i + 1 + j; //Con ayuda del for, aquí se va asignando al arreglo bidimensional el recorrido del arreglo.
                        }
                    }
                    //Aquí se están inicializando dos arreglos de valores de tipo int.
                    for (int i = 0; i < fila; i++) //Este for nos ayuda a que se haga el recorrido del arreglo.
                    {
                        for (int j = 0; j < col; j++) //Este for nos ayuda a que se haga el recorrido del arreglo.
                        {
                            Console.Write("[{0}]\t", a[i, j]); //Aquí se mostrará en la consola de salida el contenido del arreglo bidimensional con ayuda de la secuencia de escape tabulador \t.
                        }
                        Console.WriteLine(""); //Aquí se hará un salto de línea para la siguiente columna del arreglo bidimensional.
                    }
                }
            } while (fila < 1 || fila > 10); //Mientras fila es menor a 1 o mayor a 10 se ejecutará el código dentro del do-while.
            Console.ReadKey(); //Este es un comando para detener el programa, el ReadKey acepta cualquier tecla, mientras que el ReadLine solo acepta el Enter.
        }
    }
}