using System;
namespace menu_seleccion
{
	public class contador
	{
		public contador()
		{
			int i=0;
            Console.WriteLine("\n*****Contador*****\n");
            do {
				Console.WriteLine("{0}", i.ToString("0"));
				i = i + 3;
			} while (i < 100);
		}
	}
}

