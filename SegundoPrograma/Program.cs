using System;

namespace SegundoPrograma // El identificador aquí es SegundoPrograma porque está identificando a nuestro namespace(nombre de espacio)
{
    class Program // El identificador aquí es Program porque está identificando a nuestra clase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Segundo Programa\n"); // Esto imprime un mensaje en consola.
            int edad1;
            edad1 = 28;
            Console.WriteLine(edad1);
            Console.WriteLine(7 * 5);
            Console.WriteLine(5.0 / 2.0); //C# detecta que el valor numérico es decimal y el resultado lo da en decimal de tipo double
            Console.WriteLine(9 % 4); //Te devuelve un 1 porque te devuelve el resto de una división
            int edad2 = 19;
            int edad3 = 15;
            edad2++; //Operador de incremento
            edad2 += 8; //Incremento de 8 unidades
            Console.WriteLine("Tienes una edad de " + edad2 + " años"); //Concatenación de Strings
            Console.WriteLine("Tienes una edad de " + ++edad3 + " años"); //Operador de incremento como prefijo en una concatenación de Strings
            Console.WriteLine($"Tienes una edad de {edad2} años"); //Interpolación de Strings
            /* C# introduce una novedad llamada interpolación de strings algo que no tiene C ni Java 
             * que consiste en concatenar Strings sin utilizar el operador + */

            int edadPersona1;
            int edadPersona2;
            int edadPersona3;
            int edadPersona4;

            //C# permite hacer lo siguiente para asignar un mismo valor
            edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 27; //Iniciar todas las variables con el mismo valor
            Console.WriteLine(edadPersona2);

            //En otros lenguajes se puede hacer lo siguiente:
            int edadPersona5, edadPersona6, edadPersona7, Persona8 = 27;//Solamente la última variable tiene el valor de 27

            //Declaración implícita de variables no confundir con Visual Basic que tiene el mismo tipo de declaración
            var edadPersona = 27;/* Palabra reservada var que asigna en tiempo de ejecución del programa el 
                                  * tipo de dato que corresponda a esa variable, se tieen que asignar desde un principio */
            /* Nota: En Visual Basic durante la ejecución del programa se puede utilizar el tipo de declaración var y luego
             * durante la ejecución del programa en cualquier parte del código asignar un tipo de dato diferente, ejemplo:
             * var edadPersona = 2/;
             * edadPersona = 27.5;
             * Console.WriteLine(edadPersona); --> EN Visual Basic está permitido esto pero en C# no está permitido
             */
            Console.WriteLine(edadPersona);
            var nombrePersona = "Mario"; //Asigna a la variable un tipo String
            Console.WriteLine(nombrePersona);

            //Conversiones explícitas e implícitas
            //Conversión explícita, ejercicio pasar la variable temperatura de tipo double a tipo entero
            double temperatura1 = 34.5;
            int temperatura2;
            /* Se hace una conversión explícita o casting, se tiene que especificar entre paréntesis 
             * delante del nombre de la variable la conversión que queremos hacer */
            temperatura2 = (int)temperatura1;
            Console.WriteLine(temperatura2);

            //Conversión implícita, se hace entre tipos de datos compatibles y no e nesecitará hacer un casting
            int habitantesCiudad = 10000000;
            long habitantesCiudad2020 = habitantesCiudad;
            Console.WriteLine(habitantesCiudad2020);

            float pesoMaterial = 5.78F; //Un tipo de dato float deberá de llevar el sufijo F para especificar que es de tipo float
            double pesoMaterialPrec = pesoMaterial;
            Console.WriteLine(pesoMaterialPrec);

            /*Referencia en C#
             * Buscar en Google Tabla de conversiones numéricas implícitas entre tipos de datos primitivos
             */

            /*Aquí vamos a pedir al usuario introducir valores numéricos por consola gracias a la instrucción o método .ReadLine();
             * El método .ReadLine() devuelve texto, si al introducir un valor numérico es considerado por el programa como
             un valor de texto y en definitiva se intenta almacenar un valor de texto en una variable de tipo entero y no se puede
            almacenar en una variable de tipo entero un valor de texto, es aquí donde vienen conversiones necesarias.
            Esto es común cuando se piden datos al usuario y esos datos vengan de un formulario o de una base de datos,
            es muy probable que esos datos vengan en formato de texto y se necesite que esos valores estén en formato numérico*/
            Console.WriteLine("Introduce el primer número: ");
            //Aquí el programa se queda a la espera hasta que el usuario introduzca en consola para que se almacene en una variable
            int num1 = int.Parse(Console.ReadLine()); /* Aquí le decimos al programa que convierta el método 
                                                      * .Parse a entero y que nos devuelva la instrucción .ReadLine,
                                                      por ejemplo: si introducimos el número 8 o cualquier número que al principio
                                                      es considerado como texto al estar dentro de int.Parse automáticamente
                                                      se convierte en un valor numérico y esto si ya se puede almacenar en una
                                                      variable de tipo entero */
            Console.WriteLine("Introduce el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("El resultado es " + (num1 + num2)); //Concatenación de dos números pedidos por teclado
            //Nota: El flujo de ejecución de un programa dentro de un método main siempre será de arriba a abajo y de izquierda a derecha
            //Nota: En C# te permite también concatenar valores a través de llaves {} dentro de un String

            const int VALOR1 = 5;//Palabra reservada const para declarar constantes y deben inicializarse en la misma línea
            /* Como buena práctica de programación el nombre de las constantes se suele poner en mayúsculas 
             * para diferenciar una constante de una variable */
            const int VALOR2 = 7;

            //Ejercicio: Mostrar en consola el valor que suman las constantes VALOR1 y VALOR2
            //Nota: Se puede escribir un segundo argumento o parámetro dentro del método o función .WriteLine
            Console.WriteLine("El valor de las constantes son: {0} y {1}", VALOR1, VALOR2);
            /* Aquí le decimos al programa que queremos reflejar
             * el valor que almacena la constante o variable del
             * siguiente parámetro, los parámetros los empieza a contar
             * desde el 0, es como si fuera un arreglo */

            //Ejercicio: Calcula el área de un círculo, vamos a pedirle al usuario que introduzca por teclado el radio del círculo
            //Aquí haremos uso de una constante PI=3.1416, es un valor que no se deberá alterar
            const double PI = 3.1416;
            Console.WriteLine("Introduce la medida del radio: ");
            double radio = double.Parse(Console.ReadLine());
            double area = radio * radio * PI; //Aquí se hace el uso de una constante después de haberla declarado e iniciado anteriormente en el programa
            Console.WriteLine($"El área del círculo es: {area}");

            //También se puede hacer uso de un método que pertenece a la clase Math
            /* En la biblioteca de C# tenemos una clase Math que permite realizar diferentes cálculos matemáticos
             * Potencia de un número: Se utiliza el método .Pow perteneciente a la clase Math = Math.Pow(base, exponente); */

            //Nuevo cálculo del área
            Console.WriteLine("Introduce la medida del radio: ");
            double r = double.Parse(Console.ReadLine());
            double a = Math.Pow(radio, 2)*PI;
            Console.WriteLine($"El área del círculo es: {a}");
        }
    }
}

/* Sintaxis básica I en C#
 * Comentarios en el código
 * Identificadores y palabras clave
 * Convenciones(buenas prácticas) a la hora de programar en C# */

// COMENTARIO EN C#

/* COMENTARIO
 * MULTILÍNEA EN C# */

/* IDENTIFICADORES EN C#
 * Los identificadores son los nombres que se usan para identificar los elementos de tus programas:
 * Namespaces
 * Clases
 * Métodos
 * Variables
 * Constantes 
 
 * Convenciones para nombrar identificadores:
 * 
 * Solo se pueden usar letras(mayúsculas y minúsculas), números y guiones bajos.
 * Ejemplo: 
 * Está permitido // Primera_Aplicacion
 * No está permitido // Primera-Aplicacion
 *
 * Los identificadores nunca deben comenzar con un número, deben comenzar por una letra o un guón bajo.
 * Ejemplo:
 * Está permitido // _Primera_Aplicacion2
 * No está permitido // 2Primera_Aplicacion
 *
 * No se deben utilizar palabras clave(palabras reservadas), todo lo que está en color azul son palabras reservadas.
 * Ejemplo:
 * Está permitido // Clase
 * No está permitido // class */

/* Sintaxis básica II en C#
 * Tipos de datos en C#
 * Variables: declaración e iniciación
 * Convenciones y buenas prácticas */

/* TIPOS DE DATOS MÁS UTILIZADOS EN C#
 * Tipo                             Descripción                                             Tamaño(bits)
 * int                              Números enteros                                         32
 * long                             Números enteros muy grandes                             64
 * float                            Números decimales                                       32
 * double                           Números decimales con parte decimal larga               64
 * decimal                          Números decimales con parte decimal muy larga           128
 * string                           Cadena de carácteres                                    16 por carácter
 * char                             Un único carácter                                       16                  
 * bool                             Booleanos                                               8                  
 * 
 * Cada tipo de dato tiene un tamaño que se representa en bits, por ejemplo un dato de tipo int tiene 32 bits, quiere decir que
 * cuando se maneja un tipo de dato entero(int) estamos consumiendo 32 bits en la memoria RAM de nuestro ordenador. */

/* VARIABLES.
 * Espacio en la memoria(RAM) del ordenador donde se almacenará un valor que podrá cambiar durante la ejecución del programa.
 * Cuando creamos una variable y el programa termina, ese espacio en la memoria se libera automáticamente. 
 * 
 * Convenciones(buenas prácticas) a la hora de declarar(dar nombre) a las variables:
 * No comenzar el nombre de la variable con un guión bajo, por ejemplo: // _edad 
 * No generará ningún error pero no se considera buena práctica de programación.
 * 
 * No crear más de una variable que se diferencien solo por una letra, por ejemplo: // EDAD, Edad, edad
 * 
 * Comenzar el nombre de la variable con letra minúscula, por ejemplo: // edad
 * No generará ningún error pero no se considera buena práctica de programación, por ejemplo: // Edad
 *
 * Si el nombre de la variable está compuesto por más de una palabra, comenzar la segunda con mayúscula, por ejemplo: // edadPersona
 * No generará ningún error pero no se considera buena práctica de programación, por ejemplo: // EdadPersona, edadpersona
 * 
 * No utilizar notación húngara, por ejemplo: // bedad, iedad */

/* DECLARACIÓN E INICIACIÓN DE VARIABLES
 * 
 * ¿Qué es declarar una variable?
 * Declarar una variable es crear/construir la variable
 * En C# para declarar una variable debemos indicar el tipo de dato que va a almacenar en su interior y acontinuación
 * el nombre de la variable, por ejemplo: // int edad;
 * 
 * ¿Qué es iniciar una variable?
 * Iniciar una variable es asignar un valor a la misma, es decir, especificar qué valor almacena la variable en su interior,
 * por ejemplo: // int edad;
 *              // edad = 28;
 * Existe la posibilidad de declarar e iniciar en la misma instrucción, por ejemplo: int edad = 28;
 * 
 * Nota: ¡En C# no se puede utilizar una variable que no se ha iniciado! */

/* Sintaxis básica III en C#
 * Operadores aritméticos en C#
 * + También se utiliza para concatenación de Strings, es decir unir dos o más cadenas de texto entre sí.
 * ++ Incremento
 * -- Decremento
 * += Incrementa un valor numérico
 * -= Decrementa un valor numérico
 */

/* Sintaxis básica IV en C#
 * Operador asignación "="
 * Declaración implícita de variables
 * Conversiones implícitas y explícitas
 */

/*Sintaxis básica V en C#
 *Conversión valores de texto a valores número, nota: un texto, tipo de dato String es considerado un objeto
 *Esto es gracias a la instrucción, es decir un método que se puede aplicar a cualquier dato primitivo .parse --> int.parse();
 *
 *TIPOS DE ERRORES EN PROGRAMACIÓN:
 *Errores de sintaxis: son los que se cometen a la hora de escribir un código
 *Excepciones: son los que cuando el usuario introduce en consola un dato que no sea válido, est si se puede solventar,
 *es decir se le puede decir al programa que este preparado para que el usuario introduzca en consola un dato que quizá no sea válido.
 *En este caso la excepción pasaria a estar controlada pero el programa no termina, solo no ejecuta la línea con la excepción.
 */

/*Sintaxis básica VI en C#
 * Definición y uso de constantes
 * VARIABLE. Espacio en la memoria del ordenador donde se almacenará un valor que podría cambiar durante la ejecución del programa.
 * CONSTANTE. Espacio en la memoria del ordenador donde se almacenará un valor que no podrá cambiar durante la ejecución del programa.
 * */