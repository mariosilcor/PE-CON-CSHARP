using System;

namespace menu_seleccion
{
	public class menu
	{
		public menu()
		{
			int opc;
			Console.WriteLine("*****Elija una opción*****\n");
			Console.WriteLine("1. Conversión de temperatura");
            Console.WriteLine("2. Contador");
            Console.WriteLine("3. Cálculo de area\n");
			opc = int.Parse(Console.ReadLine());
			switch (opc)
			{
				case 1:
                    conversion temp = new conversion();
                    break;
				case 2:
					contador cont = new contador();
					break;
				case 3:
					area triangulo = new area();
					break;
			}
			Console.ReadKey();
        }
	}
}

