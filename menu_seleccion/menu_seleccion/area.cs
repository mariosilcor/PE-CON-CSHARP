using System;
namespace menu_seleccion
{
	public class area
	{
		public area()
		{
            float bases, altura, area;
            Console.WriteLine("*******Area de un Triangulo*******\n");
            Console.Write("Ingrese la base del triangulo: ");
            bases = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la altura del triangulo: ");
            altura = float.Parse(Console.ReadLine());
            area = (bases * altura) / 2;
            Console.WriteLine("\nEl area del triangulo es: {0}", area.ToString("0.##"));
        }
	}
}

