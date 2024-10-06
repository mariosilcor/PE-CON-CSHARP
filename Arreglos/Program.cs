using System; //Instrucciones using, sirve para ver la ubicación de las librerías que vamos a usar.

namespace Arreglos //El namespace sirve para dar el nombre al programa.
{
    class Program //Este es el nombre de la Clase.
    {
        static void Main(string[] args) //Este es el método Main que comienza la ejecución del programa en C#.
        {
            Console.WriteLine("ASIGNATURA. ALGORITMOS Y ESTRUCTURAS DE DATOS\nUNIDAD 1. ESTRUCTURAS ESTÁTICAS DE DATOS\nTAREA 2.\n");

            //Solicitar al usuario introducir la longitud del arreglo a crear.
            int num = 0; //Aquí se declara y se asigna el valor a la variable num de tipo de dato int.
            int[] arr; //Aquí se declara la variable arr como un arreglo de tipo int.
            string filas; //Aquí se declara la variable filas de tipo de dato string.
            Console.Write("Introduce la longitud del arreglo a crear: "); //Aquí se le muestra un mensaje al usuario.
            filas = Console.ReadLine(); //Aquí se asigna a la variable filas el método ReadLine que nos regresa un valor de tipo de dato string.
            num = int.Parse(filas); //Aquí se asigna a la variable num el método Parse que convierte un valor de tipo string a un valor de tipo int.
            arr = new int[num]; //Aquí se asigna a la variable arr la nueva creación de un arreglo de los elementos que contenga la variable num de tipo int.
            Console.WriteLine("La longitud del arreglo creado es: " + arr.Length + "\n"); //Aquí se le muestra un mensaje al usuario.

            //Solicitar al usuario los elementos a almacenar en el arreglo.
            for (int i = 0; i < arr.Length; i++) //Este for nos ayuda a que se haga el recorrido del arreglo.
            {
                Console.Write("Introduce el número " + (i + 1) + " en el índice " + (i) + " del arreglo: "); //Aquí se le muestra un mensaje al usuario.
                filas = Console.ReadLine(); //Aquí se asigna a la variable filas el método ReadLine que nos regresa un valor de tipo de dato string.
                arr[i] = int.Parse(filas);  //Aquí se asigna al arreglo arr que contiene los elementos de la variable i el método Parse que convierte un valor de tipo string a un valor de tipo int.
            }

            //Mostrar al usuario el contenido del arreglo creado.
            Console.WriteLine("\nEl contenido del arreglo creado es: "); //Aquí se le muestra un mensaje al usuario.
            for (int i = 0; i < arr.Length; i++) //Este for nos ayuda a que se haga el recorrido del arreglo.
            {
                Console.Write("[" + arr[i] + "]"); //Aquí se le muestra un mensaje al usuario.
            }

            //Ordenamiento del arreglo por el método seleccionado, en este inserción.
            int aux1, aux2; //Aquí se declaran las variables aux1 y aux2 de tipo de dato int.
            for (int i = 0; i < arr.Length; i++) //Este for nos ayuda a que se haga el recorrido del arreglo.
            {
                aux1 = arr[i];
                aux2 = i - 1;
                while (aux2 >= 0 && arr[aux2] > aux1) //Mientras la variable aux2 sea igual o mayor a 0, y el arreglo arr que contiene los elementos de la variable aux2 sea mayor a la variable aux1 se ejecutará el código dentro del while.
                {
                    arr[aux2 + 1] = arr[aux2];
                    aux2--;
                }
                arr[aux2 + 1] = aux1;
            }

            //Mostrar al usuario el arreglo ordenado por el método de inserción.
            Console.WriteLine("\n\nEl ordenamiento del arreglo por el método de inserción es:"); //Aquí se le muestra un mensaje al usuario.
            for (int i = 0; i < num; i++) //Este for nos ayuda a que se haga el recorrido del arreglo.
            {
                Console.Write("[" + arr[i] + "]"); //Aquí se le muestra un mensaje al usuario.
            }

            //Solicitar al usuario la búsqueda de un elemento en el arreglo ordenado.
            Console.Write("\n\nIntroduce un número a buscar: "); //Aquí se le muestra un mensaje al usuario.
            int busq = int.Parse(Console.ReadLine()); //Aquí se declara y se asigna la variable busq el método ReadLine que nos regresa un valor de tipo de dato string, así que se tendrá que convertir a un valor de tipo de dato int con ayuda del método Parse.
            int ii = 0, jj = num, kk = 0; //Aquí se declaran y se asignan los valores a las variables de tipo de dato int.
            bool found = false;//Aquí se declara y se asigna el valor false a la variable found de tipo de dato boolean.
            while (ii <= jj && found == false) //Mientras la variable ii sea igual o menor a la variable jj, y la variable found sea igual al valor false se ejecutará el código dentro del while.
            {
                kk = (ii + jj) / 2;
                if (arr[kk] == busq) //Si el arreglo arr que contiene los elementos de la variable kk es igual a la variable busq se ejecutará el código dentro del if.
                {
                    found = true; //Aquí se asigna el valor true a la variable found de tipo de dato boolean.
                }
                if (arr[kk] > busq) //Si el arreglo arr que contiene los elementos de la variable kk es mayor a la variable busq se ejecutará el código dentro del if.
                {
                    jj = kk - 1;
                }
                else //Si el arreglo arr que contiene los elementos de la variable kk no es mayor a la variable busq se saltará el if y se ejecutará el código dentro del else.
                {
                    ii = kk + 1;
                }
            }

            //Mostrarle al usuario la posición en que se localiza el elemento buscado.
            if (found == true) //Si la variable found es igual al valor true se ejecutará el código dentro del if.
            {
                Console.WriteLine("El elemento [" + busq + "] está ubicado en la posición " + (kk + 1) + " en el índice " + kk + " del arreglo ordenado"); //Aquí se le muestra un mensaje al usuario.
            }
            else //Si la variable found no es igual al valor true se saltará el if y se ejecutará el código dentro del else.
            {
                Console.WriteLine("El elemento [{0}] no está ubicado en ninguna posición del arreglo ordenado", busq); //Aquí se le muestra un mensaje al usuario.
            }
            Console.ReadKey(); //Este es un comando para detener el programa, el ReadKey acepta cualquier tecla, mientras que el ReadLine solo acepta el Enter.
        }
    }
}