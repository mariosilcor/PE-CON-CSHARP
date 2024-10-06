using System; //Instrucciones using, sirve para ver la ubicación de las librerías que vamos a usar.

namespace ProgramacionTarea5 //El namespace sirve para dar el nombre al programa.
    {
    class Arreglo //Este es el nombre de la Clase.
        {
        int[] edades; //Aquí se declara la variable edades como un arreglo de tipo int.
        public void recibe() //Este es el método recibe de tipo public.
        {
            Console.WriteLine("ASIGNATURA. PROGRAMACIÓN ESTRUCTURADA\nUNIDAD 4. TIPOS ESTRUCTURADOS DE DATOS\nTAREA 5.\n");
            edades = new int[10]; //Aquí se asigna a la variable edades la nueva creación de un arreglo de 10 elementos de tipo int.
            //Aquí se está inicializando un arreglo de valores de tipo int.
            for (int i = 0; i < edades.Length; i++) //Este for nos ayuda a que se haga el recorrido del arreglo.
            {
                Console.Write("Ingrese la edad " + (i + 1) + ": "); //Aquí se le pedirá al usuario que ingrese valores.
                edades[i] = int.Parse(Console.ReadLine()); //El método ReadLine nos regresa un tipo de dato String, así que se tendrá que convertir a un tipo de dato int.
            }
            Console.WriteLine("\nCalculando el promedio de las edades ingresadas…"); //Aquí se le muestra un mensaje al usuario.

            //INGRESA AQUÍ TU CÓDIGO.
            int j; //Aquí se declara la variable j de tipo de dato int.
            double suma = 0, prom = 0; //Aquí se declaran las variables suma y prom de tipo de dato double.
            for (j = 0; j < edades.Length; j++) //Este for nos ayuda a que se haga el recorrido del arreglo.
            {
                suma += edades[j];
            }
            prom = suma / j;  //Aquí se realizará la división de la variable suma entre la variable j y se asignará a la variable prom.
            Console.WriteLine("\nEl promedio de las {0} edades ingresadas es de: {1}", j, prom); //Aquí se mostrará en la consola de salida el número de edades ingresadas y el promedio de los valores que ingresó el usuario.
        }
            static void Main(string[] args) //Este es el método Main que comienza la ejecución del programa en C#.
            {
            Arreglo alumnos = new Arreglo(); //Aquí se asigna a la variable alumnos la nueva creación de la Clase Arreglo.
            alumnos.recibe(); //Aquí se llama al método recibe que se había asignado a la variable alumnos.
            Console.ReadKey(); //Este es un comando para detener el programa, el ReadKey acepta cualquier tecla, mientras que el ReadLine solo acepta el Enter.
        }
    }
}