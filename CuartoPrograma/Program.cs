using System;

namespace CuartoPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ESTRUCTURAS DE CONTROL DE FLUJO: CONDICIONAL IF I. Las estructuras de control hacen que los programas 
             * tomen desiciones por si mismos, es la base para inteligencia artificial.
             * Declaración de variables booleanas. Un valor booleano solo puede almacenar true or false
             * Uso de operadores booleanos
             * Condicional IF. Las condicionales if evaluan expresiones booleanas que como resultado darán siempre true or false.
             * Un condicional if cuando se evalua nos devuelve un valor booleano */
            bool haceFrio1;
            haceFrio1 = true;
            Console.WriteLine(haceFrio1);

            //Operador negación !, invierte el sentido de una expresión booleana y también invierte el valor de una variable booleana
            bool haceFrio2;
            haceFrio2 = true;
            Console.WriteLine(!haceFrio2);

            /* OPERADORES DE COMPARACIÓN
             * OPERADOR                 SIGNIFICADO
             * ==                       Igual que
             * !=                       Diferente que
             * <                        Menor que
             * <=                       Menor o igual que
             * >                        Mayor que
             * >=                       Mayor o igual que
             * 
             * OPERADORES LÓGICOS
             * OPERADOR                 SIGNIFICADO
             * &&                       And (Y lógico)
             * ||                       Or (O lógico)
             * 
             * ¿Po qué se denominan a los condicionales o bucles estructuras de control?
             * Porque controla el flujo de ejecución del programa, es decir altera el control de flujo de ejecución del programa. */

            /* CONDICIONAL IF: Lo que hace es evaluar la condición y como resultado de la evaluación solamente habrá true or false.
             * Si la condición es true ejecutará el código que hay dentro del condicional.
             * Cuando termine de ejecutar todo el código dentro del if, el flujo de ejecución del programa continuará ejecutando
             * las líneas de código que pudiera haber a continuación del condicional.
             * Si la condición que evalua la condicional if es false el flujo de ejecución del programa ignora por completo
             * lo que hay dentro de la condicional if y continuará ejecutando el programa después de la condicional if.
             * if(condición) {
             * Código a ejecutar si la condición es verdadera(true);
             * } 
             */

            /* A un programa o aplicación le podemos plantear una pregunta muy compleja, 
            según sea compleja la pregunta así será complejo el if */
            //Ejercicio: Programa que evalue si la persona es mayor de edad o no es mayor de edad.
            int edad1 = 25;
            Console.WriteLine("Vamos a evaluar si eres mayor de edad");
            if(edad1>=18) //Condicional if
            {
                Console.WriteLine("Adelante, puedes pasar porque eres mayor de edad");
            }
            if (edad1 >= 18) //Condicional if
 /* Las llaves del condicional if se pueden omitir siempre y cuando el bloque del condicional if este formado por una única línea de código,
  * solo la primera línea pertenece al condicional if porque no lleva llaves y las siguientes líneas de código se ejecutarán porque no 
  * pertenecen al condicional if */
                Console.WriteLine("Adelante, puedes pasar porque eres mayor de edad");
            Console.WriteLine("Disfruta de tu estancia");

            /* CONDICIONAL IF II
             * Particularidades de la sintaxis del condicional if
             * Uso de operadores lógicos con if
             * Uso de la estructura "else" */

            Console.WriteLine("Vamos a evaluar si puedes conducir un vehículo");
            bool carnet1 = true; //Variable booleana

            if (carnet1) //Condicional if, evaluación de una variable booleana de tipo true
                Console.WriteLine("Puedes conducir el vehículo"); //Ejecución de la línea del código

            //Estructura else
            bool carnet2 = false; //Variable booleana
            Console.WriteLine("Vamos a evaluar si puedes conducir un vehículo");
            if (carnet2 == true) //Condicional if
                Console.WriteLine("Puedes conducir el vehículo"); //Ejecución de la línea del código
            else //Si dentro del bloque else solo habrá una instrucción se puden omitir las llaves
                Console.WriteLine("Lo siento, no puedes conducir el vehículo");
            /* En el flujo de ejecución de un programa si una instrucción entra en el if no entra en el else y viceversa si una
             * instrucción no entra en el if entra en el else */
            Console.WriteLine("Aquí termina el programa del vehículo"); //Instrucción que pertenece dentro del método main

            //Lo que se pretende con suprimir las llaves es reducir el número de líneas de código
            bool carnet3 = false;
            Console.WriteLine("Vamos a evaluar si puedes conducir un vehículo");
            if (carnet3 == true) Console.WriteLine("Puedes conducir el vehículo"); //Ejecución de la línea del código
            else Console.WriteLine("Lo siento, no puedes conducir el vehículo");
            /* En el flujo de ejecución de un programa si una instrucción entra en el if no entra en el else y viceversa si una
             * instrucción no entra en el if entra en el else */
            Console.WriteLine("Aquí termina el programa del vehículo"); //Instrucción que pertenece dentro del método main

            //Un condicional if puede evaluar más de una condición, es decir puede ser mucho más compleja
            /* Programa: Una persona puede conducir un vehículo siempre y cuando sea mayor de edad y tenga licencia de conducir,
             * si alguna de las dos condiciones no se cumple no podrá conducir un vehículo aunque solo se cumpla una condición,
            * esto se podrá hacer con el operador lógico &&(AND) */
            Console.WriteLine("Vamos a evaluar si puedes conducir un vehículo");
            Console.WriteLine("Introduce tu edad: ");//El programa le pide al usuario que introduzca la edad por teclado
            int edad2 = Int32.Parse(Console.ReadLine());//Variable edad, que es introducida por el usuario en consola
            /* El método .ReadLine(); le permite al usuario introducir datos por consola, la información que introduce el usuario por
             * consola es considerada siempre un String, es decir un texto aunque el usuario introduzca un valor numérico.
             * El método .Parse que pertenece a Int32 lo que hace es pasar a entero lo que el usuario introduzca en consola que siempre será
             * un String, es decir un texto y una vez que está pasado a entero lo almacena en la variable edad2 */
            Console.WriteLine("¿Tienes licencia de conducir?");
            string carnet4 = Console.ReadLine();//Variable de tipo String, el programa le pide al usuario si tiene licencia de conducir
            /* En este caso no se necesita hacer ningún tipo de conversión de datos ya que saldrá un dato de tipo String que se 
             * almacenará en una variable de tipo String */

            /* Construcción del if que evalue si la edad es mayor o igual que 18 y además que el carnet es igual a si,
             * en caso de que se cumplan las dos condiciones a la vez, el programa permitirá conducir el vehículo */
            if (edad1 >= 18 && carnet4 == "si") //Operador lógico AND que hace que las dos condiciones se tengan que cumplir
                Console.WriteLine("Puedes conducir el vehículo");
            else
                Console.WriteLine("No puedes conducir el vehículo");

            /* CONDICIONAL IF III
             * Particularidades de la sintaxis del condicional if
             * Uso de operadores lógicos con if
             * Uso de "else if" */

            /* En Programación ante un mismo problema puede haber varias alternativas y por eso
             * La Programación no se debe memorizar sino que se debe entender. */
            // Programa que al introducir una edad menor a 18 la segunda pregunta no la debería hacer
            // El ámbito de una variable va desde la llave de apertura donde es declarada una variable hasta la llave de cierre
            Console.WriteLine("Vamos a evaluar si puedes conducir un vehículo");
            Console.WriteLine("Introduce tu edad: ");
            int edad3 = Int32.Parse(Console.ReadLine());
            string carnet5 = "no"; /* Declaración de una variable donde el ámbito de la variable es desde la llave de apertura del método 
                                    * main hasta la llave de cierre del método main, también se tiene que inicializar la variable */
            //Evaluación con otra condicional if
            if (edad3 >= 18) {
                Console.WriteLine("¿Tienes licencia de conducir?");
                carnet5 = Console.ReadLine(); //Inicialización de la variable carnet5
            }
            if (edad3 >= 18 && carnet5 == "si") //Utilización de la variable carnet5
                Console.WriteLine("Puedes conducir el vehículo");
            else
                Console.WriteLine("No puedes conducir el vehículo");

            //Condicionales Anidados o if anidados, es decir un condicional dentro de un condicional
            Console.WriteLine("Vamos a evaluar si puedes conducir un vehículo");
            Console.WriteLine("Introduce tu edad: ");
            int edad4 = Int32.Parse(Console.ReadLine());
            //Evaluación con una condicional if
            if (edad4 < 18) Console.WriteLine("No puedes conducir el vehículo");
            else
            {
                Console.WriteLine("¿Tienes licencia de conducir?");
                string carnet6 = Console.ReadLine(); //Variable que es igual a lo que el usuario introduzca en consola
                // Método .Compare(); tiene tres parámetros, lo que hace es comparar dos cadenas de carácteres
                int compara = String.Compare(carnet6, "si", true); //Devuelve un número entero 0, quiere decir que la comparación es igual
                if (compara == 0) Console.WriteLine("Puedes conducir el vehículo");
                else Console.WriteLine("No puedes conducir el vehículo");
                //Nota: Nunca puede haber un else sin su correspondiente if, cada else tiene que pertenecer a un if que le precede
            }

            //Programa que calcule el promedio de un curso, este programa le pedirá al usuario 3 calificaciones del curso
            Console.WriteLine("Introduce el primer parcial: ");
            float parcial1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo parcial: ");
            float parcial2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el tercer parcial: ");
            float parcial3 = Int32.Parse(Console.ReadLine());
            if (parcial1 >= 5 || parcial2 >= 5 || parcial3 >= 5)
                Console.WriteLine("La calificación final es: " + (parcial1 + parcial2 + parcial3) / 3);
            else Console.WriteLine("No tienes derecho a presentar exámen extraordinario");

            /* CONDICIONAL IF IV
             * Uso de "else if" */
            //Programa que le pregunte al usuario su edad en consola y mande un mensaje de acuerdo a su edad
            //Puedes utilizar el else if junto con evaluaciones complejas utilizando operadores lógicos
            Console.WriteLine("Introduce tu edad: ");
            int edad5 = Int32.Parse(Console.ReadLine());
            if (edad5 < 18) Console.WriteLine("Eres un niño");
            else if (edad5 >= 18 && edad5 < 30) Console.WriteLine("Eres un jóven"); //Este else le pertenece al if que le precede
            else if (edad5 >= 30 && edad5 < 60) Console.WriteLine("Eres un adulto"); //Este else le pertenece al if que le precede
            else Console.WriteLine("Eres un adulto mayor"); //Este else le pertenece al if que le precede
            /* Estructura de condicional switch:
             * Es una estructura condicional cuya particularidad es que cuando se tienen que evaluar muchas condiciones en cadena
             * la sintaxís suele ser más sencilla, todo aquello que se puede hacer con un switch tampién se puede hacer con un if,
             * pero todo lo que podemos hacer con un if no siempre se podrá hacer con un switch.
             * En Visual Basic si se puede hacer con un if lo que se puede hacer con un switch */

            /* CONDICIONAL SWITCH
             * Uso de switch 
             * Sintaxís del Switch:
             * switch (expresión de control) {
             * case expresión constante:
             * código a realizar
             * break;
             * case expresión constante:
             * código a realizar
             * break;
             * ...
             * default:
             * código a realizar
             * break;
             * }
             */
            //Palabras reservadas: switch, case, break y default.
            //Nota: El ámbito de la variable declarada en un switchserá desde la llave de apertura hasta la llave del cierre del switch
            /* La estructura switch tiene en su interior una estructura case, estas estructuras case lo que hacen es comparar la expresión
             * de control con una expresión constante, entonces si se declara una variable en un case, pues el ámbito de esa variable no
             * será del case sino que será del switch porque el ámbito de una variable se marca siempre las llaves del bloque donde han
             * sido declaradas. El case tiene una expresión constante que se va a comparar comparar con la expresión de control y en caso
             * de que sea igual que la expresión de control, pues el flujo de ejecución del programa entrará dentro del case y realizará
             * el código que haya dentro del case. Cada case deberá tener al finalizar un break. El break lo que hace es romper el flujo
             * de ejecución del programa para que una vez que se ha cumplido uno de los case salga de la estructura switch y continué el
             * flujo de ejecución a partir de la llave de cierre.
             * Adicionalmente la estructura switch puede tener también en su interior un default que correspondería al else de la
             * estructura condicional switch y la función es la misma. Si después de evaluar varios case no se cumple ninguno de ellos,
             * el flujo de ejecución del programa entrará a ejecutar lo que hay dentro del default, igual que cuando se tiene un if, si la
             * condición no se cumple pasa a ejecutar el else, pues en el switch la realiza el default.
             * Podemos tener dentro de un switch todos los case que sean necesarios. 
             * El default es adicional, igual que el else, pues no es imprescindible completarlo a no ser que se necesite 
             * 
             * HAY QUE TENER EN CUENTA EN LA ESTRUCTURA SWITCH:
             * Cada expresión constante será única, la expresión constante es lo que va acontinuación del case y se compara con la
             * expresión de control del switch para cada case, no se puede repetir la expresión constante
             * No se admite en C# a continuación de los case operadores de comparación y solamente se puede evaluar los valores de tipo
             * int, valores de tipo char y valores de tipo String. Si se encesita evaluar un float o un double, pues entonces estás 
             * obligado a utilizar un if. De igual forma si se necesita utilizar operadores de comparación para cualquier expresión
             * compleja se tendrá que utilizar un if en lugar de un switch
             * Solo se puede usar el switch para evaluar:
             * int
             * char
             * String
             * (float y double han de utilizar if)
             * Los case solo pueden contener expresiones constantes
             * Todos los case deben llevar su break
             * Se puede utilizar return y throw
             * En C# se pueden sustituir las instrucciones break por un return, por un throw o por un goto aunque es muy poco común.
             * Es una muy mala práctica de programación utilizar goto en C#, ya que es poco elegante utilizar goto en C#
             */
            Console.WriteLine("Elige el medio de transporte (coche, tren o avión): ");
            //Aquí el usuario elige el medio de transporte que se almacena en la variable String
            string medioTransporte = Console.ReadLine(); 
            //En C/C++ y C# hay ligeras diferencias en la sintaxís de la estructura switch, siempre es obligatorio poner un break
            switch (medioTransporte) //Aquí el programa compara la variable con las expresiones constantes que hay en cada case
            { //Nota: Este programa hecho con la estructura switch igualmente funcionaría con la estructura if
            //La estructura switch se suele utilizar más en casos en los que haya que evaluar más condiciones
                case "coche":
                    Console.WriteLine("La velocidad media es: 100km/hr");
                    break;

                case "tren":
                    Console.WriteLine("La velocidad media es: 250km/hr");
                    break;

                case "avión":
                    Console.WriteLine("La velocidad media es: 800km/hr");
                    break;

                default:
                    Console.WriteLine("El transporte elegido no está contemplado");
                    break;
            }
            /* En caso de que el usuario introduzca un valor que no está contemplado, el programa no entra en ningún case, entra en el 
             * default y el flujo de ejecución del programa continua a partir de la llave de cierre del switch */
            Console.WriteLine("Aquí termina el programa del transporte");
            /* Ejercicio: Elabora un programa que debe calcular la comisión para una serie de comerciales y dependiendo del mes del que se
               trate, pues la comisión se calcula de una forma u otra forma, por ejemplo puede haber más comisión en los meses de noviembre,
               diciembre y enero que son meses cercanos a la navidad que en los meses julio, agosto y septiembre */
            Console.WriteLine("Introduce número de mes para el cálculo de la comisión");
            int nMes = Int32.Parse(Console.ReadLine()); //Aquí el usuario introduce el número de mes y se almacena en la variable nMes
            switch (nMes) //Aquí el switch evalua el mes introducido por el usuario
            { //Nota: No puede haber 2 o más cases que contemplen la misma expresión constante
            /* Nota: Cuánto menos código tiene un programa es más eficiente, por eso para elaborar programas que evaluen muchas condiciones 
             * la estructura switch es más cómoda de utilizar que el condicional if, pues se escribe más y el código es más complejo.
             * Normalmente un switch case es más fácil de leer sino que también al ejecutar el programa es más eficiente. 
             * Nota: En C# solamente se puede evauar en una estructura switch valores enteros, char o String.
             * Nota: Solo se admiten en los case expresiones constantes y deben ser únicas en cada case y en el switch en general. 
             * Nota: Cada case debe de llevar su break. */
                case 1:
                    Console.WriteLine("Mes escogido: Enero");
                    break;
                case 2:
                    Console.WriteLine("Mes escogido: Febrero");
                    break;
                case 3:
                    Console.WriteLine("Mes escogido: Marzo");
                    break;
                case 4:
                    Console.WriteLine("Mes escogido: Abril");
                    break;
                case 5:
                    Console.WriteLine("Mes escogido: Mayo");
                    break;
                case 6:
                    Console.WriteLine("Mes escogido: Junio");
                    break;
                case 7:
                    Console.WriteLine("Mes escogido: Julio");
                    break;
                case 8:
                    Console.WriteLine("Mes escogido: Agosto");
                    break;
                case 9:
                    Console.WriteLine("Mes escogido: Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Mes escogido: Octubre");
                    break;
                case 11:
                    Console.WriteLine("Mes escogido: Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Mes escogido: Diciembre");
                    break;
                default: //El default contempla la posibilidad de decirle al usuario que lo introducido por teclado no está contemplado
                    Console.WriteLine("Mes incorrecto");
                    break;
            }
        }
    }
}
