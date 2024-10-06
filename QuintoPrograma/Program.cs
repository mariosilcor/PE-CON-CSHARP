using System;

namespace QuintoPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Estructuras de control de flujo -> Bucles
             * Bucle while I
             * ¿Qué son los bucles?
             * Bucle while */
            /* Bucles. Permiten repetir la ejecución de líneas de código un número determinado o indeterminado de veces.
             * Los bucles son estructuras de control de flujo, es decir alteran el flujo de ejecución del programa y nos permiten repetir
             * la ejecución de equis líneas de código un número determinado de veces. Muchas veces a la hora de programar surge la
             * necesidad de que equis líneas de código se tengan que repetir equis veces, es decir tu escribirás el código que deseas
             * repetir una única vez y el bucle lo repetirá por ti las veces que sean necesarias.
             * El uso de los bucles nos va a permitir:
             * Repetir código de forma rápida y sencilla.
             * Ahorro de tiempo a la hora de programar.
             * Trabajar con grandes volúmenes de datos. Cuando se trabaje con bases de datos para poder manipular grandes volúmenes de 
             * datos que puedan estar almacenados en una tabla de una base de datos, el uso de los bucles es imprescindible.
             * Trabajar con arreglos(arrays).
             * 
             * Los bucles en Programación, en casi todos los lenguajes de programación se engloban en dos grandes categorías.
             * Tipos de Bucles:
             * Bucles determinados: For con su variante For-each. Son aquellos que sin necesidad de ejecutar el programa simplemente 
             * leyendo el código fuente sabemos cuántas veces exactamente repetirán el código de su interior. 
             * Bucles indeterminados: While y Do-while. Son aquellos en los que no sabemos cuántas veces repetirá el código de su interior
             * leyendo el código fuente, necesitamos ejecutar el programa para saber en tiempo de ejecución cuántas veces va a repetir el
             * código de su interior. Es más puede que un bucle indeterminado no llegue jamás a ejecutar una sola vez el código que hay en
             * su interior.
             * 
             * Bucle While: Ayuda a comprender el funcionamiento traduciendo "while" por "mientras"
             * Se utiliza el bucle while cuando no sabemos el número de veces que se repetirá el código de su interior.
             * Por ejemplo: Cuando consultemos una base de datos, pues casi nunca sabremos cuántos registros exactamente hay almacenados 
             * en una tabla. Por ese motivo para leer la información que hay en el interior de una tabla de una base de datos utilizaremos
             * el bucle while porque el bucle while recorrerá desde el primer registro hasta el último registro para ofrecernos esa
             * información.
             * 
             * Bucle While. Sintaxís
             * 
             * while (condición a evaluar) {
             * código a repetir
             * }
             * 
             * El bucle while se repetirá mientras la condición que está evaluando sea true. En el momento en que la condición pase de
             * ser true a ser false dejará de repetir el código que hay en su interior y el flujo de ejecución del programa continuará
             * desde la llave de cierre del bucle en adelante, es por eso que se llama bucle indeterminado, pues no sabemos a ciencia
             * cierta cuándo esa condición a evaluar pasará de ser true a ser false. */
            Console.WriteLine("¿Deseas entrar en el bucle while?"); //Impresión del mensaje en consola
            String respuesta = Console.ReadLine(); /* Dato introducido por el usuario en teclado, el dato se almacenará en la variable
                                                    * de tipo String respuesta */
            while(respuesta != "no") /* Mientras el dato almacenado en la variable respuesta sea diferente de no repetirá todo el código 
                                      * que hay en su interior */
            {
                Console.WriteLine("Estás ejecutando el interior del bucle while");
                Console.WriteLine("Introduce tu nombre: ");
                String nombre = Console.ReadLine(); /* El flujo de ejecución del programa se encuentra detenido en esta línea a la espera
                                                     * de que el usuario introduzca un dato de tipo String nombre */
                Console.WriteLine($"Saldrás del bucle {nombre} cuando respondas 'no' a la pregunta");
                Console.WriteLine("¿Deseas repetir otra vez el bucle while?");
                respuesta = Console.ReadLine(); /* El flujo de ejecución del programa se encuentra detenido en esta línea a la espera de
                                                 * que el usuario introduzca un dato de tipo String respuesta que ya se había declarado
                                                 * anteriormente. Aquí lo que se está haciendo es sobreescribir el valor que hay
                                                 * almacenado en la variable respuesta. Si la condición sigue siendo true vuelve otra vez
                                                 * a ejecutar el código */
            }
            //Si la condición pasa a ser false el bucle while dejará de ejecutarse y ejecutará las siguientes líneas de código
            //Nota: Un bucle while puede que jamás llegue a ejecutarse o puede ejecutarse un número infinito de veces
            //Nota: La condición a evaluar en el bucle while puede ser tan simple o tan compleja como se necesite.
            Console.WriteLine("Has salido del bucle while");
            /* Ejercicio: Programa que genere un número aleatorio comprendido entre 0 y 100. Ese número lo va a generar el programa pero
             * nosotros no lo vamos a saber. Una vez que el programa ha generado ese número aleatorio el programa nos debe preguntar por
             * consola de qué número se trata. Por ejemplo: El usuario introducirá un número por teclado y el programa debe decirle al 
             * usuario si el número es mayor o menos del número que se haya generado aleatoriamente. Hasta que el usuario introduzca por
             * teclado el número que haya generado aleatoriamente el programa. Cuando el usuario introduzca el número que haya generado
             * aleatoriamente el programa, el programa debe decirle al usuario que ha acertado el valor numérico y que ha utilizado equis
             * intentos para averiguar el número generado aleatoriamente por el programa */

            /* Bucle while II */
            //¿Cómo genero en C# un número aleatorio entre 0 y 100? = Variable de tipo random
            //Nota: No es realmente aleatorio ya que el programa utiliza lo que es el reloj del sistema para generar números aleatorios
            Random numero1 = new Random(); //Instrucción utilizando POO, creación de una variable objeto numero de tipo Random
            int aleatorio1 = numero1.Next(0, 100); /* Variable aleatorio que es igual a la variable objeto de tipo entero numero 
                                                        * que generará un número aleatorio entre 0 y 100 gracias al método .Next(); */
            int miNumero1 = 101; /* Variable que guardará el número que el usuario introduzca por teclado en los diferentes 
                                 * intentos que hará para averiguar el número aleatorio */
            int intentos1 = 0; // Variable que almacenará los intentos que va consumiendo el usuario para averiguar el número aleatorio
            Console.WriteLine("Introduce en número entre 0 y 100"); /* Impresión de un mensaje en consola para informar al usuario 
                                                                     * la instrucción del programa */
            while (aleatorio1 != miNumero1) /* Bucle while, en caso de que sea true se ejecutará la siguiente instrucción.
                                           * Solamente ejecutará el código del bucle while si el número que ha generado el programa
                                           * aleatoriamente es diferente de la variable miNumero, eso quiere decir que el usuario no ha
                                           * acertado */
            {
                intentos1++; //Incremento de la variable intentos si el flujo de ejecución del programa entra en el bucle while
                miNumero1 = int.Parse(Console.ReadLine()); //Conversión de dato introducido por teclado de tipo String a dato de tipo int
                if (miNumero1 > aleatorio1) //Condicional if
                    Console.WriteLine("Error, el número es menor"); /* El programa le informa al usuario que el número que ha generado el
                                                                     * programa aleatoriamente es menor que lo que ha introducido por 
                                                                     * teclado */
                if (miNumero1 < aleatorio1) //Condicional if
                    Console.WriteLine("Error, el número es mayor"); /* El programa le informa al usuario que el número que ha generado el
                                                                     * programa aleatoriamente es mayor que lo que ha introducido por
                                                                     * teclado */
            }
            Console.WriteLine($"¡Correcto! has utilizado {intentos1} intentos"); /* Impresión del mensaje fuera del bucle while ya que la
                                                                                 * condición del bucle while es false */
            //Nota: Un código de programación será más elegante mientras se utilice menos código, está más optimizado y consuma menos recursos
            //Nota: En Programación no existe un único código que solucione un programa
            /* Bucle Do-While
             * Bucle do-while: Ayuda a comprender el funcionamiento traduciendo "do-while" por "haz-mientras"
             * Su funcionamiento es idéntico al bucle while excepto por un detalle: el bucle do-while ejecutará el código de su interior 
             * al menos una vez (aunque la condición sea false)
             * Si la condición del bucle while es false durante la primera ejecución del programa, el código del bucle while no llega a
             * ejecutarse nunca. Al contrario del bucle do-while, si la condición del bucle do-while es false durante la primera ejecución
             * del programa, el código del bucle do-while llega a ejecutarse al menos una sola vez
             * Nota: En algunos casos concretos puede resultar más cómodo utilizar un bucle do-while que utilizar un bucle while 
             * Nota: Casi siempre lo que se puede hacer en un bucle while se puede hacer también con un bucle do-while y viceversa.
             * Nota: El código se simplificará bastante si se utiliza un bucle do-while */
            int z = 10; //Declaración de la variable z
            //Sintaxís del bucle do-while
            do //Haz, el programa ejecutará al menos una sola vez el código del bucle do-while si la condición es false
            {
                Console.WriteLine("Impresión " + z); // Impresión del mensaje en consola
                z++; //Incremento de la variable z
            } while (z < 10) ; /* Mientras evalua la condición el programa se da cuenta que es false, por eso no vuelve a ejecutar más 
                                * el bucle do-while */
            //Utilidad del bucle do-while: Simplificación del código

            Random numero2 = new Random(); //Instrucción utilizando POO, creación de una variable objeto numero de tipo Random
            int aleatorio2 = numero2.Next(0, 100); /* Variable aleatorio que es igual a la variable objeto de tipo entero numero 
                                                        * que generará un número aleatorio entre 0 y 100 gracias al método .Next(); */
            int miNumero2; /* Variable que guardará el número que el usuario introduzca por teclado en los diferentes 
                            * intentos que hará para averiguar el número aleatorio */
            int intentos2 = 0; // Variable que almacenará los intentos que va consumiendo el usuario para averiguar el número aleatorio
            Console.WriteLine("Introduce en número entre 0 y 100"); /* Impresión de un mensaje en consola para informar al usuario 
                                                                     * la instrucción del programa */
            do //Bucle do-while, el código del interior se ejecutará al menos una vez
            {
                intentos2++; //Incremento de la variable intentos si el flujo de ejecución del programa entra en el bucle do-while
                miNumero2 = int.Parse(Console.ReadLine()); //Conversión de dato introducido por teclado de tipo String a dato de tipo int
                if (miNumero2 > aleatorio2) //Condicional if
                    Console.WriteLine("Error, el número es menor"); /* El programa le informa al usuario que el número que ha generado el
                                                                     * programa aleatoriamente es menor que lo que ha introducido por 
                                                                     * teclado */
                if (miNumero2 < aleatorio2) //Condicional if
                    Console.WriteLine("Error, el número es mayor"); /* El programa le informa al usuario que el número que ha generado el
                                                                     * programa aleatoriamente es mayor que lo que ha introducido por
                                                                     * teclado */
            } while (aleatorio2 != miNumero2); /* Bucle while, mientras evalua la condición si es true el programa vuelve a ejecutar
                                                * el código del bucle do-while */
            Console.WriteLine($"¡Correcto! has utilizado {intentos2} intentos"); /* Impresión del mensaje fuera del bucle do-while ya que 
                                                                                  * la condición del bucle while es false */
        }
    }
}
