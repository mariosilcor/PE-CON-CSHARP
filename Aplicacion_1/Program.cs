using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_1

{

    class Program

    {

        static void Main(string[] args)

        {

            int opc;

            Console.WriteLine("elige una opcion:");

            Console.WriteLine("1. convertir de °F a °C");

            Console.WriteLine("2. conteo de 1 en 1 hasta el 500");

            opc = Int16.Parse(Console.ReadLine());



            if (opc == 1)

            {
                double f, c;

                const double b = 0.555;

                Console.WriteLine("programa que convierte de grados Fahrenheit a centigrados");

                Console.WriteLine("ingresa el valor de los grados Fahrenheit:");

                f = double.Parse(Console.ReadLine());

                c = (f - 32) * b;

                Console.WriteLine("La conversión a grados centigrados es {0}°C ", c);

            }

            else if (opc == 2)

            {

                int a;

                for (a = 0; a < 501; a++)

                {

                    Console.WriteLine(a);

                }

            }



            Console.Read();



        }

    }

}
