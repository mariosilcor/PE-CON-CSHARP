using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program {

    static void Main(string[] args) {

        int indexMenu = 0;
        int indexSwitch;
        string nombre;

        Console.WriteLine("Escribe tu nombre: ");
        nombre = Console.ReadLine();
        Console.Clear();

        while (indexMenu != 4) {

            Console.WriteLine("Bienvenido " + nombre + "\r\n");
            Console.WriteLine("Selecciona una de las siguientes opciones: \r\n");
            Console.WriteLine("1.- Convertir Grados Celsius a Grados Fahrenheit");
            Console.WriteLine("2.- Contador de multiplos de 3 con limite al 1000");
            Console.WriteLine("3.- Obtener el area de un triangulo");
            Console.WriteLine("4.- Salir");

            indexSwitch = Int32.Parse(Console.ReadLine());

            switch (indexSwitch) {

                case 1:
                    float localCase1;
                    Console.WriteLine("Escribe los °C que deseas convertir a °F: ");
                    localCase1 = float.Parse(Console.ReadLine());
                    Console.WriteLine(localCase1 + "°C son iguales a " + ((localCase1 * 9 / 5) + 32) + "°F\r\n");
                    Console.WriteLine("Presiona cualquier tecla para regresar al menu anterior....");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 2:
                    Console.WriteLine("Los numeros de 3 en 3 hasta el 1000 son: ");

                    for (int i= 3; i <= 1000; i += 3) {
                        Console.WriteLine(i);
                    }

                    Console.WriteLine("Presiona cualquier tecla para regresar al menu anterior....");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 3:
                    float localA;
                    float localB;
                    Console.WriteLine("Ingresa la base del triangulo: ");
                    localB = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa la altura del triangulo: ");
                    localA = float.Parse(Console.ReadLine());

                    Console.WriteLine("El area de tu triangulo es: " + ((localB * localA) / 2));

                    Console.WriteLine("Presiona cualquier tecla para regresar al menu anterior....");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 4:
                    indexMenu = 4;
                    break;

                default:
                    Console.WriteLine("Error entrada no valida!!!!!!");
                    Console.WriteLine("Presiona cualquier tecla para continuar....");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }

        }

        Console.WriteLine("Gracias por usar la aplicación diseñada por Odin Alcazar, hasta la proxima <3");
        Console.WriteLine("Presiona cualquier tecla para continuar....");
        Console.ReadKey();
        Console.Clear();

    }
}