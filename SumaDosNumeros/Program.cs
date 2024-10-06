using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumaDosNumeros //Este es el nombre del programa
{ // Aquí empieza el namespace
    class Program //Este es el nombre de la Clase
    { //Aquí inicia la clase Program
        static void Main(string[] args) //Este es el método Main
        { //Aquí comienza el método Main

            //Identación de código es un código ordenado
            //Asignación de variables que vamos a usar
            int primerNumero; //Este es el primer número
            int segundoNumero; //Este es el segundo número
            int suma; //Esta es la suma de los 2 números


            //DATOS DE ENTRADA
            /*El Write escribe la línea y deja el cursor ahí y 
             el WriteLine escribe la línea y se va a la siguiente línea*/
            Console.Write("Ingresa el primer número: ");

            //El ReadLine da como resultado una variable de tipo String
            //Aquí se va a realizar una conversión implícita con el método Parse a una variable int de 32 bits
            primerNumero = Int32.Parse(Console.ReadLine()); //Aquí se va a leer lo que teclee el usuario

            Console.Write("Ingresa el segundo número: ");
            segundoNumero = Int32.Parse(Console.ReadLine());

            //PROCESO DE DATOS
            suma = primerNumero + segundoNumero; //A la variable suma se le asigna el resultado de la expresión aritmética

            //DATOS DE SALIDA
            //Aquí se imprime el valor que se le asigno a la variable suma
            //Aquí el signo de + sirve para concatenación
            Console.WriteLine("Suma = " + suma);

            //Aquí se detiene la ejecución del programa
            Console.ReadKey();

        } //Aquí termina el método Main
    } //Aquí termina la clase Program
} //Aquí termina el namespace
