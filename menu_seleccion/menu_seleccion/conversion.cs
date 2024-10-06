using System;
namespace menu_seleccion
{
	public class conversion
	{

        public conversion()
        {
            float temp, convert;
            Console.WriteLine("\n*****Conversión de temperatura*****");
            Console.Write("Ingrese la temperatura en grados Centigrados: ");
            temp = float.Parse(Console.ReadLine());
            convert = (temp * 9/5)+32;
            Console.WriteLine("La temperatura en grados Fahrenheit es {0}: ", convert.ToString("0.##"));
        }
	}
}

