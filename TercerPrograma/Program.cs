using System;
using System.Runtime.Intrinsics;

namespace TercerPrograma
{
    class Program
    {
        //Estas variables se denominan campos de clase, principio de POO porque todos los objetos tienen propiedades y métodos
        int numero1 = 5; //Esta variable tiene ámbito de clase
        int numero2 = 7; //Esta variable tiene ámbito de clase
        static void Main(string[] args) //El método main jamás nos va a devolver un dato es por ello que no va a llevar en su interior la instrucción return
            //El método main puede recibir un arreglo de tipo String en la llamada
            //A la hora de llamar a un método con la palabra reservada static no se puede utilizar ningún objeto en la llamada
        {
            /* MÉTODOS I
             * Los métodos en C#
             * ¿Qué son?
             * Son un grupo de sentencias(instrucciones) de líneas de código a las que se da un nombre identificativo,
             * que realizan una tarea en concreto(en común).
             * ¿Para qué sirven?
             * El método sirve para realizar una tarea en concreto en un momento determinado. Un método
             * no realiza su tarea hasta que no es llamado.
             * ¿Cuál es su sintaxis?
             * Tipo_dato_devuelto nombre_Metodo (parametros) {
             * cuerpo_del_metodo
             * } */

            /* Métodos
             * No se ejecutará hasta que el método no sea llamado
             * Todos los métodos irán dentro de una clase en un programa de C#, a diferencia de C, C++, Visual Basic 
             * donde tenemos métodos globales que pueden ir declarados fuera de una clase
             * Se debe especificar el tipo devuelto y los parámetros --> En Visual Basic se admite el uso de la palabra reservada var que la palabra reservada var no especifica el tipo de parámetro
             * No hay distinción entre métodos y funciones. En C# ambos términos son lo mismo --> En Visual Basic un método no devuelve ningún valor mientras que en una función si
             * Un método puede recibir n parámetros, es decir el número de parámetros que sean necesarios porque en estos n parámetros se almacenará los valores que el usuario introduzca
             * en la interfaz gráfica, en consola o en un formulario
             * Un método void nunca llevará la instrucción return */

            /* MÉTODOS II
             * Los métodos en C#
             * Declaración y llamada a método  de tipo void
             * Llamada a un método con Paso de parámetros */

            //Llamada del método para que el flujo de ejecución salte desde la llamada hasta el interior del método
            mensajeEnPantalla();
            Console.WriteLine("Mensaje desde el método Main");
            //El punto de entrada de un programa siempre es el método Main así que  puede ir un método antes que el método Main
            //Podemos llamar a un método las veces que sean necesarias

            sumaNumeros1(7,9); //Llamada de un método pasando 2 parámetros para que el método reciba 2 parámetros
            Console.WriteLine(sumaNumeros2(7, 9)); //Imprime en consola la llamada del método
            Console.WriteLine(divideNumeros1(18, 6)); //Imprime en consola la llamada del método
            Console.WriteLine(divideNumeros2(18, 7)); //Imprime en consola la llamada del método
            Console.WriteLine(divideNumeros3(18, 7)); //Imprime en consola la llamada del método
            Console.WriteLine(divideNumeros4(18, 7)); //Imprime en consola la llamada del método

            /*El compilador de C# distingue perfectamente a cual de todos los métodos tiene que llamar 
             * por los parámetros dados en una sobrecarga de métodos */
            Console.WriteLine(Suma1(2, 4));
            Console.WriteLine(Suma1(2, 4, 6));
            Console.WriteLine(Suma1(7, 5.3));
            Console.WriteLine(Suma1(1, 2, 3, 4));
            Console.WriteLine(Ayuda1(7, 5.3));
            Console.WriteLine(Ayuda2(7, 5.3));

            /* LLamada al método, 
             * lo que hará este programa es que el primer parámetro viaja y se almacena en el primer parámetro del método,
             * el segundo parámetro viaja y se almacena en el segundo parámetro del método, si en la llamada al método
             * no se le paso un tercer párámetro porque ese parámetro es opcional el compilador de C# no dará error.
             * Al asignarle en la llamada al método un tercer parámetro, el tercer parámetro viaja y se almacena en el 
             * tercer parámetro del método y ya no recibe el valor recibido en el parámetro del método.
             * Esto es de ayuda cuando C# trabaja con otros lenguajes de programación que no admiten la sobrecarga de métodos */
            int valor1 = 7;
            double valor2 = 5.2;
            double valor3 = 8.3;
            //Aquí se llama al método que más se adapte al número de parámetros
            Console.WriteLine(Suma2(valor1, valor2, valor3)); //Llamada al método con parámetro opcional
            Console.WriteLine(Suma2(valor1, valor2)); //Llamada al método con parámetros obligatorios
        }
        //CREACIÓN DE UN MÉTODO
        static void mensajeEnPantalla()
        {
            Console.WriteLine("Mensaje desde el método mensajeEnPantalla");
        }

        static void sumaNumeros1(int num1, int num2) /* Método que recibe 2 argumentos o parámetros de tipo entero, 
                                                     * este método no devuelve nada */
        {
            Console.WriteLine("La suma de los números es: " + (num1 + num2)); //Concatenación del String
            Console.WriteLine($"La suma de los números es: {num1+num2}"); //Concatenación del String
            /* MÉTODOS III
             * Los métodos en C#: Los métodos de tipo void no devuelven ningún dato cuando son llamados.
             * Métodos "return": Son aquellos que nos devuelven datos cuando son llamados
             */
        }

        static int sumaNumeros2(int num1, int num2) //Este método devuelve un método de tipo int(entero)
            //Nota: Un método también puede devolver objetos
        {
            return num1 + num2; /* Instrucción return, siempre devuelve el flujo de ejecución a la llamada
                                 * y lo que ahí acontinuación del return no llega a ejecutarse nunca */
        }

        static int divideNumeros1(int num1, int num2)
        {
            return num1 / num2;
        }
        static double divideNumeros2(double num1, int num2)
        {
            return num1 / num2;
        }

        //Otra forma de declarar métodos usando un operador =>, la sintaxis se simplifica bastante
        static double divideNumeros3(double num1, int num2) => num1 / num2;
        /* Modularización. Esto quiere decir que tus programas es conveniente dividirlos en pequeñas partes.
         * Porque cuando un método ocupa más de la pantalla, tenemos que utilizar la barra de scrall */

        static double divideNumeros4(double num1, int num2) 
            //Esto es recomendable hacer si la variable resultado la vamos a utilizar en otra línea de código
        {
            double resultado;
            resultado = num1 / num2;
            return resultado;
        }

        /* MÉTODOS IV
         * Ámbito o alcance de métodos y variables: Es todo el código que hay comprendido en un método y solo será visible en ese ámbito
         * Sobrecarga de métodos */
        void primerMetodo()
        /* En cuanto el método termina su ejecución todo lo que hay en su interior 
                          * desaparece de la memoria y queda fuera del alcande desde cualquier otro método*/
        {
            int numero1 = 5; //Esta variable tiene alcance de método o un ámbito local, es decir la visibilidad de esta variable es local
            int numero2 = 7;
            Console.WriteLine(numero1 + numero2); /* La instrucción Console.WriteLine está en el mismo 
                                                    ámbito o alcance que la declaración de las mismas */
            /* Cuando declaramos una variable tiene una excepción no con ámbito de método, no con ámbito local sino con ámbito de clase,
             * es decir dentro de una clase pero fuera de cualquier método */
        }
        void segundoMetodo()
        {
            Console.WriteLine(numero1+numero2); /*Estas variables son visibles tanto desde el método porque el ámbito de las variables es 
                                                 *desde la lave de apertura de la hasta la llave de cierre de la clase */
        }
        // Sobrecarga de métodos.Es cuanto tienes en el mismo ámbito, es decir en la misma clase dos o mas métodos con el mismo nombre
        /* El método .WriteLine pertenece al lenguaje C#, es decir viene ya declarado en el propio lenguaje
        y ese método pertenece a una clase que se llama Console */

        //Ejercicio: Crea dos métodos que sumen números
        static int Suma1(int operador1, int operador2) => operador1 + operador2;
        /*Este método devolverá la suma de los dos valores 
         * que pasarán por parámetro en la llamada, 
         * se utilizará el operador expression-bodied*/
        //Este método también suma y también devolverá un valor de tipo entero
        static int Suma1(int numero1, int numero2, int numero3) => numero1 + numero2;
        static int Suma1(int numero1, double numero2) => numero1;
        static int Suma1(int numero1, int numero2, int numero3, int numero4) => numero1 + numero2;
        /* Sobrecarga de métodos. Dos o más métodos con el mismo nombre pero esos métodos deben recibir diferentes 
         * tipos de parámetros o bien diferente número de parámetros*/

        /* MÉTODOS V
         * Ayudas de Visual Studio con métodos
         * Métodos con parámetros opcionales
         * Ambigüedades en llamadas a métodos */

        /* Un método con una única línea de instrucción en su interior, 
           otra forma es la notación simplificada con el operador expression-bodied */
        private static double Ayuda1(int v1, double v2) => v1 + v2;

        /* Este método llama a otro método, 
         * esto se ocupa cuando en un return se desea crear un método que nos devuelva el dato que se utilizará en el return */
        private static double Ayuda2(int v1, double v2)
        {
            return NewMethod(v1, v2);
        }
        //Este método es llamado desde el return del anterior método
        private static double NewMethod(int v1, double v2)
        {
            return v1 + v2;
        }
        /* En la sobrecarga de métodos hay una característica que tiene C# que es permitir que los métodos reciban parámetros opcionales,
         * característica muy útil cuando se crean programas en C# que tengan que trabajar en unión con otras tecnologías,
         * por ejemplo: cuando se crea una aplicación para la plataforma Windows muchas veces no está programada con un único
         * lenguaje de programación sino que nuestro código C# debe trabajar junto con otros códigos de otros lenguajes de programación y
         * resulta que otros lenguajes de programación no admiten la sobrecarga de métodos. Hoy en día todos los lenguajes 
         * orientados a objetos modernos admiten la sobrecarga de métodos pero hay algunas excepciones a esta regla. Entonces para asegurar la
         * compatibilidad y que nuestros programas en C# trabajarán con otros lenguajes de programación y no tengan problema con la sobrecarga
         * de métodos se tendrá que usar los parámetros opcionales, por ejemplo: */

        /*Método que recibirá un parámetro opcional, este parámetro opcional se le asignará un valor,
        los otros parámetros sin valor asignado se denominan parámetros obligatorios, esto funciona
        de forma parecida a una sobrecarga de métodos sin tener en realidad ninguna sobrecarga de métodos*/
        static double Suma2(int num1, double num2, double num3=0) /*Los parámetros opcionales se escriben después 
                                                                          * de los parámetros obligatorios */
        {
            return num1+num2+num3; //Esto devuelve la suma de los parámetros
        }

        static double Suma2(int num1, double num2)
        {
            return num1 + num2;
        }

        /* La depuración nos permite ejecutar un programa línea a línea, 
         * es decir paso por paso para ver qué es lo que va haciendo el programa 
         * Ejecutar hasta el cursor, opción del compilador de C#. Nos aparecerá una flecha amarilla la cual nos indica que el programa
         * se encuentra detenido en ese punto, también aparecerá resaltada la línea donde el programa se encuentra detenido, nos ofrece
         * unas herramientas de diágnostico en la parte de la derecha del compilador de C#,
         * para ver cuantos recursos de nuestro ordenador ha consumido el programa.
         * Y en la parte inferior en la ventana automático nos aparece donde se encuentran las llamadas de los métodos.
         * Esto es de gran utilidad para ver que valor se almacena en un parámetro u otro porque en la parte inferior
         * en la ventana automático vemos como nos dice claramente que valor se almacena en un parámetro y que valor se almacena en otro */

    }
}
