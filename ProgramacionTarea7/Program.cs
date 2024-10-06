using System; //Instrucciones using, sirve para ver la ubicación de las librerías que vamos a usar.

namespace ProgramacionTarea7 //El namespace sirve para dar el nombre al programa.
{
    class Funciones //Este es el nombre de la Clase.
    {
        public void saludo() //Este es el método saludo de tipo public y no devuelve ningún valor.
        {
            Console.WriteLine("ASIGNATURA. PROGRAMACIÓN ESTRUCTURADA\nUNIDAD 5. FUNCIONES\nTAREA 7.\n");
            Console.Write("Ingresa tu nombre: "); //Aquí se le pedirá al usuario que ingrese su nombre.
            string nombre = Convert.ToString(Console.ReadLine()); //Aquí se declara la variable nombre como tipo de dato String y se asigna la variable nombre al método ReadLine que nos regresa un tipo de dato String.
            Console.WriteLine("Hola " + nombre + "!"); //Aquí se le da un saludo al usuario, concatenando la variable nombre.
        }
        public int edad() //Este es el método edad de tipo public y devuelve un valor de tipo de dato int.
        {
            Console.Write("Ingresa el año actual: "); //Aquí se le pedirá al usuario que ingrese el año actual.
            //Aquí se declara la variable actual como tipo de dato int y se asigna la variable actual al método ReadLine que nos regresa un tipo de dato String, así que se tendrá que convertir a un tipo de dato int.
            int actual = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingresa el año en qué naciste: "); //Aquí se le pedirá al usuario que ingrese el año en que nació.
            //Aquí se declara la variable nacimiento como tipo de dato int y se asigna la variable nacimiento al método ReadLine que nos regresa un tipo de dato String, así que se tendrá que convertir a un tipo de dato int.
            int nacimiento = Convert.ToInt32(Console.ReadLine());
            int edad = actual - nacimiento; //Aquí se declara la variable edad como tipo de dato int y se asigna la variable edad a la variable actual menos la variable nacimiento.
            return edad; //Aquí se devuelve el método edad, una vez que haya finalizado el método.
        }
        public int horas(int vida) //Este es el método horas de tipo public que tiene como parámetro la variable vida que es de tipo de dato int, y devuelve un valor de tipo de dato int.
        {
            Console.WriteLine("Tú has vivido: " + vida + " años"); //Aquí se le indica al usuario el tiempo de vida en años, concatenando la variable vida.
            int horas = vida * 8764; //Aquí se declara la variable horas como tipo de dato int y se asigna la variable horas a la variable vida por 8764, que es la cantidad de horas aproximadas que contiene un año.
            return horas; //Aquí se devuelve el método horas, una vez que haya finalizado el método.
        }
        public void despedida(int tiempo) //Este es el método despedida de tipo public que tiene como parámetro la variable tiempo que es de tipo de dato int, y no devuelve ningún valor.
        {
            Console.WriteLine("Tú has vivido más de: " + tiempo + " horas"); //Aquí se le indica al usuario el tiempo de vida en horas aproximadas, concatenando la variable tiempo.
            Console.WriteLine("Hasta Pronto!"); //Aquí se le da una despedida al usuario.
        }
        static void Main(string[] args) //Este es el método Main que comienza la ejecución del programa en C#.
        {
            Funciones programa = new Funciones(); //Aquí se asigna a la variable programa la nueva creación de la Clase Funciones.
            programa.saludo(); //Aquí se ejecuta el método saludo que se había asignado a la variable programa.
            int vida = programa.edad(); //Aquí se ejecuta y se asigna la variable vida de tipo de dato int al método edad que se había asignado a la variable programa.
            int tiempo = programa.horas(vida); //Aquí se ejecuta y se asigna la variable tiempo de tipo de dato int al método horas que se había asignado a la variable programa y tiene como parámetro la variable vida.
            programa.despedida(tiempo); //Aquí se ejecuta el método despedida que se había asignado a la variable programa y tiene como parámetro la variable tiempo.
            Console.ReadKey(); //Este es un comando para detener el programa, el ReadKey acepta cualquier tecla, mientras que el ReadLine solo acepta el Enter.
        }
    }
}