using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase_tres
{
    class Program //Nombre de la Clase
    {
        static void Main(string[] args) //Función Main que empieza el Programa
        {
            //SELECCIÓN SIMPLE IF
            Console.Write("Introduce la calificación: "); //Write imprime en pantalla y deja el cursor (puntero) a continuación sin dar un Enter
            int calif1 = Int32.Parse(Console.ReadLine()); //Se declara la variable calif como entera(int) y se le asigna la conversión a un entero(int) de 32 bits de la operación de lectura desde el teclado que nos da un String lo que se teclee que se convertirá a un entero(int) de 32 bits y se asignará a la variable calif 
            if (calif1 >= 6) //Si el valor de la variable calif es mayor o igual a 6 se imprimirá un mensaje, sino es así no imprimirá nada
                Console.WriteLine("Aprobado");
            Console.ReadLine();

            //SELECCIÓN DOBLE IF
            Console.Write("Introduce la calificación: ");
            int calif2 = Int32.Parse(Console.ReadLine());
            if (calif2 >= 6) //Si calif es mayor o igual a 6 se imprimirá Aprobado y si calif no es mayor o igual a 6 se imprimirá Reprobado
                Console.WriteLine("Aprobado");
            else
                Console.WriteLine("Reprobado");

            //OPERADOR CONDICIONAL
            Console.WriteLine("Introduce la calificación: ");
            int calif3 = Int32.Parse(Console.ReadLine());
            //Si calif es mayor o igual a 6 se imprimirá Aprobado pero si calif no es mayor o igual a 6 se imprimirá Reprobado
            Console.WriteLine(calif3 >= 6 ? "Aprobado" : "Reprobado"); //Esto es la sustitución de la selección doble if

            //SENTENCIA IF ELSE ANIDADO PRIMERA FORMA
            Console.Write("Introduce la calificación: ");
            int calif4 = Int32.Parse(Console.ReadLine());
            if (calif4 >= 9)
            {
                Console.WriteLine("A");
            }
            else
            {
                if (calif4 == 8)
                {
                    Console.WriteLine("B");
                }
                else
                {
                    if (calif4 == 7)
                    {
                        Console.WriteLine("C");
                    }
                    else
                    {
                        if (calif4 == 6)
                        {
                            Console.WriteLine("D");
                        }
                        else
                        {
                            Console.WriteLine("F");
                        }
                    }
                }
            }

            //SENTENCIA IF ELSE ANIDADO SEGUNDA FORMA
            Console.Write("Introduce la calificación: ");
            int calif5 = Int32.Parse(Console.ReadLine());
            if (calif5 >= 9)
            {
                Console.WriteLine("A");
            }
            else if (calif5 == 8)
            {
                Console.WriteLine("B");
            }
            else if (calif5 == 7)
            {
                Console.WriteLine("C");
            }
            else if (calif5 == 6)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }

            //SENTENCIA IF ELSE ANIDADO TERCERA FORMA
            Console.Write("Introduce la calificación: ");
            int calif6 = Int32.Parse(Console.ReadLine());
            if (calif6 >= 9)
                Console.WriteLine("A");
            else if (calif6 == 8)
                Console.WriteLine("B");
            else if (calif6 == 7)
                Console.WriteLine("C");
            else if (calif6 == 6)
                Console.WriteLine("D");
            else
                Console.WriteLine("F");

            //SENTENCIA SWITCH
            Console.Write("Introduce la calificación: ");
            int calif7 = Int32.Parse(Console.ReadLine());
            switch (calif7)
            {
                case 10:
                case 9:
                    Console.WriteLine("A");
                    break;
                case 8:
                    Console.WriteLine("B");
                    break;
                case 7:
                    Console.WriteLine("C");
                    break;
                case 6:
                    Console.WriteLine("D");
                    break;
                default:
                    Console.WriteLine("F");
                    break;
            }

            /* EJERCICIO CLASE 3, ESTO ES UN TEMA DE REDES.
             * Recibe un número entre 0 y 255, y convierte 
             * el número "apagando" los 4 bits menos significativos
             */
            int mask = 240;
            int numero = 0;
            Console.Write("Introduce un número del 0 al 255: ");
            numero = Int16.Parse(Console.ReadLine());
            numero = numero & mask;
            Console.Write("Ahora el número es: {0}", numero);
            Console.ReadKey();
        } //Aquí termina el Main
    } //Aquí termina la Clase
} //Aquí termina el namespace
