using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//ArreglosListaInicializadora
namespace Algoritmos_Clase1
{
    class Program
    {
        //ESTRUCTURA
        struct calif
        {
            public int calificacion;
            public string materia;
        }
        static void Main(string[] args)
        {
            //Declaración con creación e inicialización
            //de un arreglo de tipo de dato float
            float[] precio = { 12.45F, 27.50F, 38.45F, 92.00F, 64.50F };
           
            //i es una variable de control
            for (int i = 0; i < precio.Length; i++)
            Console.WriteLine("precio[i]");

            //Uso del foreach
            foreach (float elemento in precio)
            Console.WriteLine(elemento);

            //Arreglo de tipo de dato float de 1000 posiciones
            //La variable descuento describe las 1000 posiciones
            float[] descuento = new float[1000];
            //La descripción del arreglo se asigna a la variable precio
            descuento = precio;
            for (int i = 0; i < descuento.Length; i++)
                Console.WriteLine(descuento[i]);
            Console.ReadLine();

            //PROGRAMA QUE PIDE LAS CALIFICACIONES DE 5 MATERIAS
            //Y OBTIENE SU PROMEDIO USANDO ARREGLOS

            int suma = 0;
            int[] calificaciones = new int[5];
            string[] materias = new string[5]

            { "Matemáticas", "Física", "Programación", "Inglés", "Redacción" };

            for (int i = 0; i < calificaciones.Length; i++)
            {
                Console.Write("Ingresa la calificación de {0}: ", materias[i]);
                calificaciones[i] = Int32.Parse(Console.ReadLine());
                suma = suma + calificaciones[i];
            }

            Console.Write("Tu promedio de calificaciones es de: {0}", (float)suma / 5);
            Console.ReadLine();

            //PROGRAMA QUE PIDE LAS CALIFICACIONES DE 5 MATERIAS
            //Y OBTIENE SU PROMEDIO USANDO ARREGLOS
            //Y TENIENDO UNA ESTRUCTURA 
            //EN ESTE PROGRAMA MOSTRAMOS
            //LA FUNCIÓN DE UN ARREGLO DE ESTRUCTURAS
            calif[] listaCalificaciones = new calif[5];
            listaCalificaciones[0].materia = "Matemáticas";
            listaCalificaciones[1].materia = "Física";
            listaCalificaciones[2].materia = "Programación";
            listaCalificaciones[3].materia = "Inglés";
            listaCalificaciones[4].materia = "Redacción";
            int suma2 = 0;
            for (int i = 0; i < listaCalificaciones.Length; i++)
            {
                Console.Write("Ingresa la calificación de {0}: ",
                    listaCalificaciones[i].materia);
                listaCalificaciones[i].calificacion = Int32.Parse(Console.ReadLine());
                suma = suma + listaCalificaciones[i].calificacion;
            }
            Console.WriteLine("Tu promedio de calificaciones es de: {0}", (float)suma / 5);
            Console.ReadLine();
        }
    }
}
