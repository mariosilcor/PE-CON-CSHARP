using System; //Aquí están las Librerías que podemos usar en C#.

namespace Clase_cinco //Este es el nombre del programa.
{
    class Program //En la clase Program se incluyen todos nuestros métodos
    {
        static void Main(string[] args) //Este es el Método Main
        {
            float[] precio1; //Aquí se declara la variable precio como un arreglo de valores float
            precio1 = new float[5]; //Aquí se le asigna a la variable precio la nueva creación de un arreglo de 5
            precio1[0] = 12.45F;
            precio1[1] = 27.50F;
            //Como el elemento 2 y el elemento 3 no se asignan por default se le asignará un 0
            //Así hasta...
            precio1[4] = 64.50F;
            //La variable precio es una estructura de datos porque es un arreglo
            for (int i = 0; i < precio1.Length; i++) //Este for nos ayuda a que se haga el recorrido del arreglo
            {
                Console.WriteLine(precio1[i]);
            }

            float[] precio2 = new float[5]; //Declaración y creación de un arreglo de valores de tipo float
            
            //Aquí se está inicializando un arreglo de valores de tipo float
            for (int i = 0; i < precio2.Length; i++)
            {
                //El comando ReadLine nos regresa un String, se tendrá que convertir a tipo de dato float
                Console.Write("Ingresa el valor de precio[" + i + "]: "); //Aquí se le pedirán datos al usuario
                precio2[i] = float.Parse(Console.ReadLine());
            }
            for (int i = 0; i < precio2.Length; i++)
            {
                Console.WriteLine("Precio[" + i + "]: " + precio2[i]); //Aquí se desplegan los datos del usuario
            }

            float[] precio3 = { 12.5F, 25.5F, 96.9F }; //Declaración, creación e inicialización de un arreglo de tipo float
            for (int i = 0; i < precio3.Length; i++)
            {
                Console.WriteLine("Precio[" + i + "]: " + precio3[i]);
            }

            //Uso del foreach que sustituye al for
            float[] precio4 = {12.5F, 25.5F, 96.9F}; //Declaración, creación e inicialización de un arreglo de tipo float
            foreach (float dato in precio4) //dato es una variable de recorrido del arreglo
            {
                Console.WriteLine(dato);
            }

            //Programa que pide las calificaciones de 5 materias y obtiene su promedio
            int suma = 0;
            int[] calificaciones = new int[5]; //Arreglo de enteros
            string[] materias = new string[5]
                {"Matemáticas", "Física", "Química", "Programación", "Inglés"}; //Arreglo de strings

            for (int i = 0; i < calificaciones.Length; i++)
            {
                Console.Write("Ingresa la calificación de {0}: ", materias[i]); //Aquí se van a ir capturando las calificaciones
                calificaciones[i] = Int32.Parse(Console.ReadLine());
                suma = suma + calificaciones[i];
            }
            Console.WriteLine("Tu promedio de calificaciones es: {0}", (float)suma / 5); //Aquí se calcula el promedio de las calificaciones
            Console.ReadKey();
        }
    }
}
