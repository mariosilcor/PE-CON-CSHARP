using System; //Instrucciones using, sirve para ver la ubicación de las librerías que vamos a usar.

namespace ProgramacionTarea4 //El namespace sirve para dar el nombre al programa.
{
    class Program //Este es el nombre de la Clase.
    {
        static void Main(string[] args) //Este es el método Main que comienza la ejecución del programa en C#.
        {
            Console.WriteLine("ASIGNATURA. PROGRAMACIÓN ESTRUCTURADA\nUNIDAD 3. SENTENCIAS DE CONTROL DEL PROGRAMA\nTAREA 4.");
            //Declarando las variables de tipo float a utilizar y asignando el valor a cada variable.
            float suma = 0.0F, cant = 0.0F, calif = 0.0F, prom = 0.0F;
            //Declarando la variable de tipo char a utilizar.
            char opc = 's';
            while (opc == 's') //Mientras opc es igual al carácter 's' se ejecutará el código dentro de while.
            {
                do //Aquí si el usuario ingresa una calificación menor a 1 o una calificación mayor a 10, tendrá que intentarlo nuevamente.
                {
                    Console.Write("\nIngrese una calificación: "); //Aquí se le solicita al usuario que ingrese una calificación.
                    calif = float.Parse(Console.ReadLine());
                    if (calif < 1 || calif > 10) //Si el usuario ingresa una calificación menor a 1 o una calificación mayor a 10, tendrá que intentarlo nuevamente.
                    {
                        Console.Write("\nPor favor, vuelva a ingresar la calificación y únicamente ingrese valores de 1 a 10."); //Aquí se le solicita al usuario que ingrese una calificación igual o mayor a 1 o una calificación igual o menor a 10.
                    }
                    else if (calif >= 1 && calif <= 10) //Si el usuario ingresa una calificación igual o mayor a 1 o una calificación igual o menor a 10, tendrá que decidir si desea o no desea introducir otra calificación.
                    {
                        Console.Write("Desea ingresar otra calificación? s/n: "); //Aquí se le solicita al usuario si desea o no desea introducir otra calificación.
                        opc = char.Parse(Console.ReadLine()); 
                        if (opc != 's' && opc != 'n') //Si el usuario ingresa un carácter diferente a 's' o un carácter diferente a 'n', tendrá que intentarlo nuevamente.
                        {
                            do //Aquí si el usuario ingresa un carácter diferente a 's' o un carácter diferente a 'n', tendrá que intentarlo nuevamente.
                            {
                                Console.Write("Por favor, vuelva a ingresar el carácter y únicamente ingrese 's' o 'n': "); //Aquí se le solicita al usuario que ingrese únicamente el carácter 's' o únicamente el carácter 'n'.
                                opc = char.Parse(Console.ReadLine());
                            } while (opc != 's' && opc != 'n'); //Mientras opc es diferente al carácter 's' y diferente al carácter 'n' se ejecutará el código dentro del do-while.
                        }
                        suma = suma + calif; //Aquí se realizará la suma de la variable suma más la variable calif y se asignará a la variable suma, únicamente si el usuario ingresó una calificación igual o mayor a 1 o una calificación igual o menor a 10.
                        cant++; //Aquí se está incrementando de uno en uno la variable cant, únicamente si el usuario ingresó una calificación igual o mayor a 1 o una calificación igual o menor a 10.
                    }
                } while (opc != 'n'); //Mientras opc es diferente al carácter 'n' se ejecutará el código dentro del do-while.
            }
            prom = suma / cant; //Aquí se realizará la división de la variable suma entre la variable cant y se asignará a la variable prom, únicamente con los valores iguales o mayores a 1 o con los valores iguales o menores a 10 que ingresó el usuario.
            Console.Write("\nEl promedio de los " + cant + " valores ingresados es de: " + prom + "\n"); //Aquí se mostrará en la consola de salida el número de valores ingresados y el promedio de los valores que ingresó el usuario.
            Console.ReadKey(); //Este es un comando para detener el programa, el ReadKey acepta cualquier tecla, mientras que el ReadLine solo acepta el Enter.
        }
    }
}