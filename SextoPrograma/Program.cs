using System;

namespace SextoPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Excepciones I
             * ¿Qué son las excepciones?
             * ¿Qué es el "manejo o captura de excepciones"?
             * Excepciones. Las excepciones son errores en tiempo de ejecución del programa, es decir mientras el programa se está
             * ejecutando y que escapa al control del programador
             * Errores más comunes en Programación:
             * Memoria del ordenador corrupta. Que ocasiona que nuestro programa caiga
             * Desbordamiento de la pila de llamadas. Que ocasiona que nuestro programa caiga
             * Errores de hardware: Sectores de disco duro defectuosos. Que hacen que haya un error en la escritura o en la lectura y
             * ocasiona que nuestro programa caiga
             * Acceso a ficheros inexistentes. Cuando intentamos acceder a ficheros desde nuestro programa y esos ficheros no están donde
             * se supone que deberían de estar, por ejemplo cuando intentas manipular una imágen que debe estar en un directorio y resulta
             * que no está o tiene otro nombre, eso también ocasiona que el programa caiga
             * Conexiones a BBDD interrumpidas. Cuando accedemos a BBDD por motivos ajenos por completo a nuestro control y a nuestra
             * voluntad, eso también ocasiona que el programa caiga
             * Etc 
             
             * Que un programa caiga siempre es problemático, lo que ocurre es que hay veces que si el programa es muy pequeño, pues 
             * el problema no es tan grande pero si el programa es muy grande y este programa realiza varias tareas que el programa caiga
             * en un punto en concreto durante su ejecución sí que puede ser problemático
             * 
             * Por ejemplo: Ya sabemos que un flujo de ejecución del programa va siempre de arriba a abajo, así que si ejecutamos un
             * programa pues comenzará a leer la primera línea, después la siguiente línea y así sucesivamente.
             * El flujo de ejecución de un programa cambia cuando nos encontramos con un condicional porque puede pegar saltos o cuando
             * nos encontramos con un bucle porque puede volver otra vez hacia arriba pero si no hay condicionales ni bucles el flujo
             * de ejecución del programa va de arriba a abajo y el programa pues va ejecutando y realizando cada una de las líneas de
             * código que se va encontrando, pero imaginemos que durante la ejecución del programa pues hay una línea en concreto que
             * genera un error o bien porque el usuario realiza una acción inesperada, por ejemplo que ocurre en ese caso, qué ocurre
             * cuando hay un error que escapa a nuestro control. Se dice que se produce en ese momento lo que se denomina una excepción,
             * es decir un error en tiempo de ejecución, es decir durante la ejecución de un programa y si el programa es muy grande y es
             * un programa que realiza varias tareas es problemático porque desde la línea que ha generado el error hacia adelante nuestro
             * programa no va a ejecutar nada, entonces a lo mejor no es muy problemático que la línea que ha generado el error, el
             * programa no ejecute la línea pero a lo mejor si es problemático que deje de ejecutar quizás las miles de líneas que hay
             * a continuación de donde se ha generado el error y que realizan numerosas tareas.
             * La captura de excepciones o el manejo de excepciones consiste en que cuando se genera una excepción o un error en tiempo de
             * ejecución, esa excepción se captura que es lo mismo que decir que se trate o que se le diga a nuestro programa que hacer en
             * el caso de que se produzca esa excepción, ese error en tiempo de ejecución y ese quehacer se consigue con un bloque
             * try...catch, es decir en un programa nosotros utilizaremos un bloque try...catch en el que le diremos a nuestro programa
             * qué hacer en el caso de que se produzca una excepción y eso de decirle qué hacer ocasiona que quizás la línea que ha
             * generado el error no se ejecute pero si que se ejecute el resto de líneas, es decir evita que el programa caiga para que el
             * resto del programa y el resto de tareas que pueda realizar el programa pues no deje de ejecutarse.
             * La captura o el manejo de excepciones se puede traducir de una manera coloquial cómo saltarnos el error y que el programa
             * siga hacia adelante. Esto tiene muchos matices porque hay muchas formas diferentes de capturar una excepción, le podemos
             * decir que efectivamente se salte la excepción y siga hacia adelante pero tambien le podemos decir reintenta ejecutar de
             * nuevo la línea que genere el error y se le pueden decir muchas más cosas.
             * 
             * Ejercicio: Construye un bloque try...cath en el programa de adivinar un número aleatorio que solvente una posible 
             * excepción. Imaginándose que el programa es mucho más complejo de lo que en realidad es y realiza muchas tareas, una de ellas
             * es adivinar el número aleatorio pero imaginándonos que detrás de la última línea de código pues este programa podría llegar
             * a realizar muchas más tareas diferentes.
             */
            Random numero1 = new Random();
            int aleatorio1 = numero1.Next(0, 100);
            int minumero1;
            int intentos1 = 0;
            Console.WriteLine("Introduce un número entre 0 y 100: ");
            do
            {
                intentos1++;
                try /* Bloque try: Se coloca justo antes de la línea que genera el error o la excepción se abre un bloque try con una llave
                     * que se abre y esa llave se cerrará después de la línea que genera el error, con esto le estamos diciendo al programa
                     * intenta ejecutar esta línea y a continuación del bloque try siempre debe ir acompañado de un bloque catch */
                {
                    minumero1 = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex1) /* Bloque catch: Este bloque catch recibe por parámetros un objeto de tipo excepción, 
                                            * FormatException es el mensaje que nos daría la consola si se produjera un error que es del 
                                            * tipo FormatException y acontinuación se introduce una variable objeto que normalmente por
                                            * convención suele llamarse e de error o ex de excepción. Se abre la llave y se cierra la llave
                                            * del bloque catch, es entre estas dos llaves de apertura y cierre del bloque catch donde le
                                            * tenemos que decir al programa que debe hacer, le podemos decir al programa que imprima un
                                            * texto en consola y así el programa informaría al usuario que esté ejecutando el programa
                                            * pues el error que ha producido en concreto.
                                            * 
                                            * Nota: Después de haber construido el bloque try...catch después del bloque catch una variable 
                                            * no inicializada puede generar un error en el programa que antes no se había generado, esto es
                                            * porque en C# las variables para poder utilizarlas deben estar iniciadas, es decir deben tener
                                            * un valor asignado, esto ocurre por el bloque try porque le estamos diciendo al programa que
                                            * intente ejecutarla línea dentro del bloque try, al decirle al programa que lo intente, el
                                            * programa entiende que al intentarlo puede que lo consiga o puede que no lo consiga, si lo
                                            * consigue es perfecto pero si no lo consigue, si no ejecuta esa línea de código la variable
                                            * que se genero el error jamás se inicia, ya que solamente está declarada pero como se inicia
                                            * en la línea de código que está dentro del try, si está línea de código no llegara a ejecutarse
                                            * nunca pues la variable quedaría sin iniciar y esto no puede quedar al azar, esta
                                            * circunstancia hay que controlarla, es decir la variable dentro del bloque try tiene que estar
                                            * iniciada para que no nos de el error, tanto si la ejecución de la línea tiene éxito como si no
                                            * tiene éxito. Para solucionarlo de una manera un poco elegante es inicializar la variable
                                            * dentro del bloque catch, diciéndole dentroo del bloque catch que la variable es igual a cero.
                                            * De esta forma si el programa ejecuta con éxito la línea del try ignora al catch, es decir si
                                            * el try tiene éxito el catch no se ejecuta, ya que pasaría directamente a la siguiente línea
                                            * de código después de la llave de cierre del catch pero si no tiene éxito el try y la línea de
                                            * código del try no se ejecuta el flujo de ejecución del programa si entra en el catch, al
                                            * entrar en el catch nos imprime en consola los mensajes dentro del catch
                                            */
                {
                    Console.WriteLine("No has introducido un valor numérico. Se toma como número introducido el número 0");
                    //Esta no es una solución muy elegante pero nos sirve por lo menos para salvar la excepción
                    /* Nota: Sin la excepción el programa cae si el usuario introduce un error, pero con la excepción el programa no va 
                     * a ejecutar la línea donde el usuario introdujo el error, el programa saltará al catch y realizará las líneas de
                     * código dentro del catch, es decir el programa no cae, y así pues podriamos seguir ejecutando el programa, esto es
                     * salvar una excepción que se genera al introducir texto.
                     * Errores en Programación:
                     * Errores en tiempo de ejecución que utilizando bloques try...catch, es decir capturando esas excepciones y tratándolas
                     * podemos solventar. Los programas construidos deben de contemplar la captura de excepciones, también es posible
                     * capturar varias excepciones diferentes, pues una misma línea de código es susceptible de que genere errores de
                     * diferente tipo, puede ser un error de formato, un error de entrada-salida, y en ese caso podemos utilizar un try y 
                     * después varios catch y cada catch que capture una excepción en concreto. */
                    minumero1 = 0;
                }
                catch (OverflowException ex1)
                { /* A partir de aquí se construye otro bloque catch, en esta ocasión contemplando la 
                                              * posibilidad de que la excepción que lance sea de tipo OverFlowException y en el interior
                                              * del bloque catch, ponemos el código que queremos que ejecute en el caso de que se lance una
                                              * excepción de este tipo, también debemos iniciar nuevamente la variable que se está
                                              * utilizando porque si nosotros no lo hacemos, VisualStudio nos marcará un error a la hora
                                              * de utilizar la variable, el código es susceptible de cometer en este caso porque se lo
                                              * hemos dicho una excepción de tipo OverflowException, en este caso el flujo de ejecución
                                              * entraría en el segundo catch, no entraría en el primer catch y tampoco sería capaz de
                                              * ejecutar lo que hay en el try, por ese motivo lanzó la excepción, entonces tenemos que
                                              * contemplar todas las posibilidades y debemos iniciar la variable, es decir si no es capaz de
                                              * ejecutar el try, si tampoco ejecuta el primer catch, al ejecutar el segundo catch debemos
                                              * iniciar la variable */
                    Console.WriteLine("Ha introducido un valor demasiado alto. Se toma como número introducido el número 0");
                    minumero1 = 0;
                } /* Nota: Al ejecutar este programa en el caso de que el usuario introduzca un texto el programa no cae, se captura la
                   * excepción y continúa, en el caso de que el usuario introduzca un valor numérico excesivamente alto el programa tampoco
                   * cae, captura la excepción y continúa y ahora sí el programa es menos susceptible a que caiga */
                if (minumero1 > aleatorio1)
                    Console.WriteLine("El número es más bajo");
                if (minumero1 < aleatorio1)
                    Console.WriteLine("El número es más alto");
            } while (aleatorio1 != minumero1);
            Console.WriteLine($"Correcto! Has utilizado {intentos1} intentos");
            /* Nota: La impresión de esta línea en consola después de que el usuuario juegue al número aleatorio pues el programa
             * continaría realizando las siguientes tareas para las que está destinado. Sin embargo qué ocurre si por ejemplo: el usuario
             * realiza una acción inesperada, es decir que el usuario introduzca por error o malintencionalmente introduce un texto.
             * En este momento se produce una excepción, es decir un error en tiempo de ejecución. Si leemos la información que nos da
             * la consola lo que nos dice es lo siguiente:
             * Unhandled Exception: traducido quiere decir excepción sin capturar y a continuación se nos informa de qué tipo de excepción
             * o qué tipo de error en tiempo de ejecución ha tenido lugar y nos dice lo siguiente:
             * System.FormatException: nos dice que es un error en el formato, es decir una excepción de formato y luego además nos da aún
             * más información y nos dice lo siguiente:
             * Input string was not in a correct format: el string introducido no estaba en el formato correcto y si seguimos leyendo aún
             * nos da más información porque más adelante al final nos dice incluso la línea de código en la que se ha generado el error en
             * tiempo de ejecución y nos dirá en que número de línea de código en la que se ha generado ese error en tiempo de ejecución.
             * Bien si echamos un vistazo al código y buscamos la línea de código donde se ha generado el error muy probablemente nos
             * daremos cuenta que la excepción se ha producido justo cuando el programa intenta guardar en una variable lo que se ha
             * introducido en consola al haber introducido un texto. Hemos introducido en consola un texto y el error viene porque el
             * método .Parse() no es capaz de convertir a entero esta información que hemos introducido en consola, pues si introducimos
             * un valor numérico, ese valor numérico que en principio es un texto, sí que es capaz el método .Parse() de convertirlo en un
             * número entero y almacenarlo en una variable, pero si en vez de introducir un número introducimos un texto, el método
             * .Parse() no es capaz de convertir el número entero el texto que hemos introducido, esto quiere decir que el texto lo sigue
             * dejando como texto y al dejarlo como texto lo intenta almacenar en una variable, pero resulta que la variable es de tipo
             * int(entero) y es ahí donde se produce el error, se produce el error porque intenta guardar en una variiable de tipo
             * int(entero) un valor de texto, ese es el error en concreto que se produce cuando el usuario realiza la acción.
             * Además de esta excepción o este error el programa puede ser susceptible de generar varias excepciones en tiempo de
             * ejecución. Pero principalmente la excepción más común es la excepción que se genera cuando el usuario introduce texto en
             * consola, ya que el problema que se tenemos en la línea de código donde se genero el error el programa cae y las siguientes
             * líneas de código no llega a ejecutarlo jamás y las supuestas tareas que irían a continuación de la última línea de código
             * tampoco se ejecutan, es decir el programa cae justo en la línea de código donde se genero el error y de esa misma línea en
             * adelante no se ejecuta nada y eso puede ser un problema, pues nuestro programa puede estar destinado a realizar muchas más
             * tareas y no se ejecutaría ninguna, esto se puede solventar con un bloque try...catch
             * 
             * Bloque try...catch
             * try: en inglés quiere decir intenta
             * catch: en inglés quiere decir captura
             * Lo que tenemos que hacer es localizar la línea del error y meter esa línea del error dentro de un try que es como decirle al
             * programa intenta ejecutar la línea de nuevo, en el caso de que lo consiga no hay ningún problema pero en el caso de que no
             * pueda ejecutar la línea de código tras intentarlo el flujo de ejecución entraría entonces en el bloque catch y en el bloque
             * catch es donde capturamos el error y es donde le decimos que tiene que hacer nuestro programa en caso de que haya un error en
             * tiempo de ejecución, en caso de que se produzca una excepción.
             */
            Console.WriteLine("A partir de esta línea de código el programa continuaría");

            /* Excepciones II
             * Captura de varias excepciones.
             * El código anterior se construyó un bloque try...catch para contemplar la posibilidad de que ocurriera un FormatException,
             * es decir que el usuario cuando se le pide un valor numérico pues introduzca texto, gracias al bloque try...catch pues el
             * programa no cae, el flujo de ejecución en el caso de que se introduzca texto entra dentro del bloque catch y el programa
             * continua con su ejecución. Si ejecutamos el programa introduciendo un texto, pues vemos como el programa no cae.
             * Pero qué ocurre si en lugar de introducir texto cuando le pedimos el valor numérico al usuario pues al usuario se le ocurre
             * introducir un valor numérico extremadamente largo, aquí no hay un FormatException (forma de excepción), es decir no hay un
             * fallo del formato, hay un fallo de otro tipo, pues si pulsamos Enter vemos cómo el programa cae de nuevo, y si nos fijamos
             * en el mensaje que nos lanza la consola nos dice  Unhandled Exception, que hay una excepción sin capturar y concretamente
             * la excepción que tiene lugar es un System.OverflowException, lo que ha ocurrido aquí es lo siguiente:
             * 
             * Cuando creamos un Programa en C# y en otros lenguajes de programación nuestro código es susceptible de que lance más de una
             * excepción diferente y es justo lo que ha ocurrido en el ejemplo donde el usuario introduce un número extremadamente grande,
             * nosotros tenemos un bloque try...catch, el flujo de ejecución entra en el try e intenta ejecutar el código que hay en el
             * try, si por cualquier motivo no puede ejecutar el código se lanza una excepción.
             * 
             * try {
             * //código que se intenta
             * } catch (FormatException e) {
             * //código que se ejecuta si hay excepción
             * }
             * En el primer caso: es que se lanza una excepción de FormatException si el usuario introduce un valor de texto. En este caso
             * lo que hace el programa es comprobar que la excepción que ha lanzado el bloque try corresponde con la que se ha estipulado
             * en el bloque catch, es decir mira a ver si coinciden en el caso de que coincidan, da el ok y la excepción que se lanzó es
             * capturada y tratada por el bloque catch, ejecutando el código que hay dentro del alcance, pero qué ocurre cuando el código
             * que está intentando el try lanza una excepción de otro tipo, por ejemplo: OverFlowException, este tipo de excepción es
             * cuando el usuario introduce un valor más grande en consola, el programa comprueba a ver si la excepción que estipulamos en
             * el catch corresponde con la que ha lanzado el programa, al comprobar que esto no es así, esa excepción no puede ser 
             * capturada, no puede ser tratada, así que el programa cae en esta ocasión por una excepción de tipo OverFlowException, pero
             * cuál es el remedio, el remedio es utilizar varios catch, es decir para solventar esta situación nosotros podemos crear un
             * bloque try...catch pero on un doble catch, es decir un try con un código a intentar. Este código a intentar si lanza una
             * excepción de tipo FormatException lo controlamos y capturamos con el primer catch y el programa continúa, y si lanza una
             * excepción de tipo OverFlowException, pues también lo controlamos y lo capturamos en esta ocasión con el segundo catch, se
             * ejecutaría el código que hay en el segundo catch y el programa continuaría su ejecución, esta es la forma de solventar el
             * programa, pues podemos encadenar tantos catch como necesitemos con un único bloque try, pero qué ocurre si nuestro código
             * lanza una tercera excepción diferente, pues el programa volvería a caer y qué ocurre si la excepción que lanza se puede
             * capturar desde dos catch, esto es importante tenerlo en cuenta.
             * 
             * En principio veremos cómo construir un segundo catch en esta ocasión que  capture una excepción de tipo OverFlowException y
             * como el programa funcionará correctamente.
             * 
             * El código anterior de programación es muy sencillo, son ejemplos sencillos, así que todas las excepciones que puede lanzar
             * el programa  casi las tenemos controladas, puede lanzar un FormatException, puede lanzar un OverflowException, quizá alguna
             * más pero en un programa complejo muy largo con muchas líneas de código, el programa será susceptible de que lance muchas
             * excepciones, quizás 15 o 16, pero qué tenemos que hacer en ese caso, podríamos construir 15 o 16 catch uno a continuación de
             * otro para capturar todas las posibles excepciones que hace el programa, eso sería un trabajo demasiado costoso, lo que se
             * suele hacer en esos casos es utilizar una excepción genérica.
             * 
             * HERENCIA DE EXCEPCIONES.
             * Exception > SystemException > FormatException - OverflowException
             * 
             * Las excepciones en los lenguajes de programación orientados a objetos, por ejemplo: C#, tienen una jerarquía, también
             * denominada herencia, la herencia es de vital importancia en programación, pero tener en cuenta que las excepciones tienen
             * una jerarquía, se han visto 2: FormatException & OverflowException, bueno pues por encima de estas 2 excepciones en una
             * jerarquía se encuentra SystemException y por encima de SystemException se encuentra Exception, es como una especie de árbol
             * genealógico o herencia en la cual tenemos en la cúspide a la clase Exception, por debajo en la jerarquía de la herencia
             * tenemos a la clase SystemException y por debajo de SystemException tenemos entre otra muchas a FormatException &
             * OverflowException, eso quiere decir que si nosotros en nuestros programas en lugar de capturar FormatException &
             * OverflowException en un bloque catch, capturamos Exception, lo que hacemos es contemplar la posibilidad y capturar que
             * nuestro programa pueda lanzar cualquier excepción que esté por debajo en el árbol de herrencia, en esta jerarquía. */

            Random numero2 = new Random();
            int aleatorio2 = numero2.Next(0, 100);
            int minumero2;
            int intentos2 = 0;
            Console.WriteLine("Introduce un número entre 0 y 100: ");
            do
            {
                intentos2++;
                try //Bloque try para una instrucción
                {
                    minumero2 = int.Parse(Console.ReadLine()); /* Introducción del número en consola si el usuario introduce texto o 
                                                                * valores muy grandes */
                }
                //Excepción de forma Exception
                catch (Exception ex2) /* Captura genérica para que con el catch gracias a la clase padre Exception capture cualquier tipo 
                                       * de error que pueda surgir con el programa, sin embargo esto a pesar de que es un recurso útil en
                                       * algunas circunstancias no se recomienda abusar de él, más bien se recomienda afinar todo lo
                                       * posible a la hora de capturar excepciones y no capturar excepciones genéricas, pues lo más
                                       * recomendable con este programa que además es muy simple sea utilizar varios catch para ir 
                                       * capturando excepciones, pues este programa tampoco puede lanzar muchas excepciones diferentes,
                                       * puede lanzar dos o tres excepciones que quedarán cubiertas cada una de ellas con su catch */
                {
                    Console.WriteLine("No has introducido un valor numérico válido. Se toma como número introducido el número 0");
                    minumero2 = 0;
                    Console.WriteLine(ex2.Message);
                    /* Si utilizamos el objeto de tipo Exception para que imprima un mensaje en consola gracias al método .Message, lo que
                     * se hace es imprimir en consola además del mensaje de error, pues qué tipo de excepción ha tenido lugar, por poner un
                     * ejemplo: este objeto tiene muchos más métodos además de el método .Message o muchas más propiedades mejor dicho,
                     * además de la propiedad .Message, al ejecutar el programa si el usuario introduce texto se va a imprimir un mensaje
                     * en inglés en consola: Input string was not in a correct format, es decir no está introducido en el formato correcto, 
                     * y si el usuario introduce un valor numérico extremadamente largo, pues se va a imprimir un mensaje en inglés en
                     * consola: Value was either too large or too small for an Int32, es decir el valor que has introducido es demasiado
                     * largo para un tipo primitivo de Int32, y eso lo consigue el objeto que llamamos ex2 de tipo Exception, así que por
                     * todos estos motivos no es recomendable a pesar de que se puede prescindir de la clase padre Exception.
                     * 
                     * Resumen: A la hora de crear un programa en C# si estamos manejando excepciones hay que intentar afinar todo lo
                     * posible construyendo varios catch y en el caso de que uestro programa sea muy complejo y susceptible de lanzar muchas
                     * excepciones diferentes lo que haremos será una captura genérica con la clase padre Exception */
                }
                if (minumero2 > aleatorio2)
                    Console.WriteLine("El número es más bajo");
                if (minumero2 < aleatorio2)
                    Console.WriteLine("El número es más alto");
            } while (aleatorio2 != minumero2);
            Console.WriteLine($"Correcto! Has utilizado {intentos2} intentos");
            /* Llevando esto a la práctica lo que habría que hacer en el código simplemente es un bloque try con un solo bloque catch, 
             * pero en lugar de capturar un tipo de excepción, lo que se hace es capturar el padre de todas las clases de excepciones, que 
             * el padre es Exception, bueno pues con esto contemplamos que nuestro programa cometa en la línea del try un número 
             * indefinido o indeterminado de excepciones, con esto contemplamos y capturamos varios tipos de excepciones, por ejemplo:
             * FormatException, OverflowException y cualquier otra excepción que podría tener el programa.
             * Al ejecutar el programa si el usuario introduce un texto el programa continúa, si el usuario introduce un valor numérico 
             * muy alto el programa también continúa. Esto de capturar una excepción genérica y olvidarnos de construir varios catch, no
             * siempre funciona porque en la medida de lo posible a la hora de programar debes tener la máxima presición para especificar
             * cuál es la excepción cápturada y tratada, esto funciona pero al usuario no le da ninguna información de qué ha ocurrido
             * en específico, pues el usuario quizás no sabe por qué se ha cometido una excepción y nosotros como programadores si este
             * código no lo hubiéramos hecho nosotros y lo hubiera hecho otro programador al leer esta línea de código, pues tampoco
             * tenemos una idea muy aproximada de qué tipo de excepción se está capturando, entonces en la medida de lo posible hay que
             * ser preciso con la captura de la excepción afinando todo lo posible pero habrá programas que por su complejidad no podamos
             * detenernos a construir varios catch para afinar todo lo posible y tengamos que construir una excepción de tipo Exception en
             * general, C# tiene una característica que no tienen otros lenguajes de programación y es que si vas a utilizar una excepción
             * genérica para simplificar el código incluso puedes omitir la captura de la excepción simplemente diciendo catch, solo es
             * válido cuando vas a utilizar una excepción genérica, es decir la clase Exception, en ese caso C# te permite prescindir de
             * esa expresión, esto tampoco es recomendable aunque el lenguaje C# lo permite no se considera una buena práctica de
             * programación, sin embargo no está bien visto porque a ojos de otro programador, pues no le estamos diciendo nada ya que no
             * le estamos diciendo que se ha capturado en el bloque catch y además es muy útil utilizar el objeto de tipo Exception, ya que
             * cuando nosotros capturamos una excepción sea el tipo que sea utilizamos una variable objeto a la cual se suele llamar ex
             * por convención o se suele llamar también e, pero se puede llamar como el programador desee, bien pues ese objeto de tipo
             * Exception que se ha declarado en los parámetros del catch es muy útil para proporcionar información */

            /* Excepciones III
             * Conflictos en el uso de varios catch
             * Captura de excepciones con filtros
             * Expresiones checked y unchecked
             * 
             * Cuando estamos utilizando varios catch pueden surgir varios conflictos, por ejemplo:
             * Con este programa a lo mejor no tiene demasiado sentido porque es extremadamente simple pero con programas complejos sí que
             * puede surgir el escenario siguiente: Imaginemos que en este programa queremos capturar todas las excepciones posibles con un
             * catch excepto una, imaginemos que a la excepción de FormatException le queremos dar un tratamiento especial para
             * indicarle al usuario en el caso de que introduzca texto, pues que no se permite la introducción de texto y con el resto de
             * excepciones que pueda lanzar el programa, pues capturarlas de una forma general, esto se haría pues con 2 catch, uno para
             * capturar las excepciones generales y el otro catch para darle un tratamiento especial a la excepción de FormatException, en
             * esta excepción general podríamos informarle al usuario que ha habido un error simplemente, porque vamos a imaginarnos que se
             * están capturando 7 u 8 excepciones diferentes que pueden lanzar el programa, no se especifica una excepción en concreto,
             * simplemente se le informa al usuario que ha habido un error y se toma como número introducido el 0 y lueego iniciar la
             * variable que se está utilizando en 0 y a continuación como queremos darle un tratamiento especial a la excepción de
             * FormatException, pues se construiría otro catch pero no va a surgir un problema que es el siguiente: si a continuación
             * construimos un catch y le decimos FormatException se abrirían las llaves y en entre las llaves del catch donde se le daría un
             * tratamiento especial donde afinaríamos más especificando que error ha cometido el usuario.
             * Se supone que con esto que se acaba de hacer pues quedarían cubiertas todas las excepciones gracias a la captura de la clase
             * Exception y además le estaríamos dando un tratamiento especial a la excepción de FormatException donde también tendríamos que 
             * iniciar la variable que se está utilizando, sin embargo Visual Studio marcará un error en esta captura de excepción, al
             * marcarlo con el mouse lo que nos dice el mensaje de error es: una cláusula catch previa ya detecta todas las excepciones de
             * este tipo o de tipo superior, es decir que cuando estés elaborando un programa en C# y utilices una captura general 
             * utilizando la clase Exception no tiene ningún sentido que a continuación intentes afinar con una captura en concreto, es 
             * decir con una excepción en concreto porque este FormatException ya ha quedado cubierto en la captura general, entonces 
             * Visual Studio no lo reconoce y nos marca el error aunque si estamos utilizando un editor diferente a Visual Studio puede 
             * que no nos marque error antes de ejecutar el programa, pues tenemos que tener en cuenta que después de una captura general 
             * con Exception no podemos utilizar una clase que herede de Exception en este caso FormatException, aunque si queremos realizar
             * esta tarea, es decir dar un tratamiento especial a una excepción en concreto y después hacer una captura genérica siempre la 
             * que es más concreta debe ir antes de lo que es la captura general, esto sí que lo permite Visual Studio, si que se puede 
             * hacer en C#, al ejecutar el programa en el caso de que el usuario introduzca texto, es decir de que ocurra un
             * FormatException entra en el primer catch y en el caso de que ocurra otra excepción diferente, por ejemplo: que el usuario
             * introduzca un número muy grande cuando pulse Enter se va a lanzar una excepción pero no será de tipo FormatException, lo que
             * hace el compilador en este caso es buscar que catch se adecúa más a este tipo de excepción y va a encontrar que es el
             * genérico porque FormatException no tiene nada que ver. Resumiendo como primera lección primero van los catch específicos y
             * al final van los catch genéricos, siempre se debe seguir ese orden y como segunda lección es que cuando se lanza una
             * excepción, imagínate que tenemos 7 catch uno detrás de otro, el compilador lo que hace es buscar el que más se adecúe cuando
             * encuentra el primer catch que se adecúa a esa excepción ignora todos los que puede haber a continuación, aunque también hay 
             * otra forma de realizar esta tarea, es decir cuando queremos capturar muchas excepciones y darles a todas un tratamiento
             * genérico excepto a una de ellas podemos utilizar lo que se llaman excepciones con filtro, esta es una nueva característica de
             * C# y consiste en lo siguiente: dejamos la captura genérica, es decir solamente tenemos un catch y nos ponemos en la misma
             * situación, pues vamos a imaginarnos que al FormatException le queremos dar un tratamiento especial, bueno pues la otra
             * alternativa es utilizar lo que se conoce como filtros y es incluir a continuación de la captura de la excepción genérica la
             * cláusula when, después del when le tenemos que especificar cuál es la excepción que queremos excluir de esta captura, en este
             * caso FormatException y eso lo podemos hacer de la siguiente forma: 
             * catch (Exception objeto de tipo excepción) when (objeto de tipo excepción.GetType) */
            Random numero3 = new Random();
            int aleatorio3 = numero3.Next(0, 100);
            int minumero3;
            int intentos3 = 0;
            Console.WriteLine("Introduce un número entre 0 y 100: ");
            do
            {
                intentos3++;
                try //Bloque try para una instrucción
                {
                    minumero3 = int.Parse(Console.ReadLine()); /* Introducción del número en consola si el usuario introduce texto o 
                                                                * valores muy grandes */
                }
                //Excepción de forma Exception
                catch(FormatException ex3)
                {
                    Console.WriteLine("Has introducido texto. Se toma como valor numérico el número 0");
                    minumero3 = 0;
                }
                catch (Exception ex3)
                {
                    Console.WriteLine("No has introducido un valor numérico válido. Se toma como número introducido el número 0");
                    minumero3 = 0;
                    Console.WriteLine(ex3.Message);
                }
                if (minumero3 > aleatorio3)
                    Console.WriteLine("El número es más bajo");
                if (minumero3 < aleatorio3)
                    Console.WriteLine("El número es más alto");
            } while (aleatorio3 != minumero3);
            Console.WriteLine($"Correcto! Has utilizado {intentos3} intentos");

            //Usando el método GetType
            /* .GetType, es un método que pertenece al objeto de tipo Exception, es lo mismo la propiedad .Message que pertenece al objeto 
             * de tipo Exception, bueno pues además de propiedades tenemos también métodos que pertenecen al objeto de tipo Exception.
             * */
           //Nota: El objeto de tipo excepción es el error
            Random numero4 = new Random();
            int aleatorio4 = numero4.Next(0, 100);
            int minumero4;
            int intentos4 = 0;
            Console.WriteLine("Introduce un número entre 0 y 100: ");
            do
            {
                intentos4++;
                try //Bloque try para una instrucción
                {
                    minumero4 = int.Parse(Console.ReadLine()); /* Introducción del número en consola si el usuario introduce texto o 
                                                                * valores muy grandes */
                }
                /* Lo que aquí le decimos al compilador es que capture todas las excepciones cuando las excepciones sean diferentes de
                 * FormatExeption, es como decirle todas menos FormatException, ex4.GetType lo que nos devuelve es el tipo de excepción que
                 * se ha lanzado, por ejemplo: OverflowException, como OverflowException es diferente de FormatException pues entraría en
                 * el catch y haría lo que hay entre la llave de apertura y de cierre, cualquier otro tipo de excepción que nos devuelve
                 * ex4.GetType y que sea diferente de FormatException pues entonces entrará en las llaves de apertura y cierre del catch, y
                 * hará el código en concreto pero si se produce la excepción FormatException, esa excepción en concreto ya no se cumple la
                 * condición, ya lo que nos devuelve ex4.GetType no es diferente de FormatException, es lo mismo entonces es cuando no entra
                 * en el catch y es ahora cuando se tiene que construir otro catch para darle un tratamiento especial a la excepción de tipo
                 * FormatException, esta es otra forma de hacerlo, es utilizar excepciones con filtros.
                 * Esta es una excepción con filtros, cuando se están elaborando programas complejos y queremos capturar todas
                 * excepciones sin saber a ciencia cierta cuáles van a ser, pero hay una en concreto que queremos tratar de forma especial,
                 * pues esta es una forma de hacerlo, así no nos tenemos que preocupar de poner un catch específico antes o después, bueno
                 * pues utilizamos un filtro y luego se trata el catch en concreto.
                 * 
                 * Nota:
                 * Error de tipo Overflow: 123456789012345678901234567890
                 * Lo que hará el programa es entrar en el catch general e ignorar el catch específico del FormatException
                 * Error de tipo FormatException: abcdefjhijklmnopqrstuvwxyz
                 * Lo que hará el programa es ignorar el catch general porque le hemos dicho al programa que capture todas las excepciones
                 * menos esta excepción de tipo FormatException y entrará en el catch específico */
                catch (Exception ex4) when (ex4.GetType()!=typeof(FormatException))
                {
                    Console.WriteLine("Ha habido un error. Se toma como valor numérico el número 0");
                    minumero4 = 0;
                }
                catch (FormatException ex4)
                {
                    Console.WriteLine("Has introducido texto. Se toma como número introducido el número 0");
                    minumero4 = 0;
                    Console.WriteLine(ex4.Message);
                }
                if (minumero4 > aleatorio4)
                    Console.WriteLine("El número es más bajo");
                if (minumero4 < aleatorio4)
                    Console.WriteLine("El número es más alto");
            } while (aleatorio4 != minumero4);
            Console.WriteLine($"Correcto! Has utilizado {intentos4} intentos");

            /* Nota: Comportamiento bastante curioso que tiene el compilador de C# a la hora de trabajar con operaciones aritméticas que
             * pueden lanzar un error
             * 
             * Expresiones checked y unchecked (chequeadas y sin chequear) */
            int numero5 = int.MaxValue; /* Declaración de una variable de tipo int
                                         * .MaxValue es una propiedad de la clase Integer que lo que hace es devolvernos el valor más alto
                                         * que admite el tipo primitivo int */
            int resultado1 = numero5 + 20; /* En esta variable resultado1 se almacena lo que hay dentro de la variable numero5 y le sumamos
                                            * 20, esta expresión debería de dar un error, una excepción de tipo Overflow, porque ya se está
                                            * almacenando el valor máximo que admite un int (entero), si además a ese valor le sumamos 20 y
                                            * lo pretendemos almacenar en una variable de tipo int (entero), aquí debería de haber un
                                            * desbordamiento, sin embargo al ejecutar el programa no dará ningún error pero nos da una
                                            * respuesta errónea, nos pone un número negativo, pues debería de haber un desbordamiento, es
                                            * decir el programa debería de caer al realizar esta tarea, sin embargo no es así y se comporta
                                            * de una forma muy extraña C#, además nos devuelve un número erróneo que es un número negativo
                                            * muy grande, la explicación de este comportamiento es rendimiento, pues se intenta que los
                                            * programas tengan el máximo rendimiento en C#, eso es lo que intenta el compilador, de tal 
                                            * forma que permite de manera transparente para el usuario hacer un Overflow y generar una 
                                            * respuesta errónea, es decir el compilador sabe que hay un desbordamiento pero antes de dejar 
                                            * que caiga el programa lo que hace es de forma transparante tratar la excepción y nos devuelve 
                                            * una respuesta errónea porque no sabe muy bien qué hacer, esto lo hace por rendimiento porque 
                                            * las operaciones aritméticas son las más frecuentes en los programas que podamos realizar en 
                                            * C# y en cualquier otro lenguaje de programación, y si en un programa complejo tiene que ver 
                                            * si hay desbordamiento o no hay desbordamiento en cada una de las operaciones aritméticas, 
                                            * esto ocasionaría un rendimiento muy pobre por parte del compilador de tal forma que lo que 
                                            * hace es asumir que puede haber un posible error y continuar con la ejecución del programa 
                                            * hacia adelante, si hubiese  más líneas de código a continuación en el programa, pues después 
                                            * de haber tratado esta excepción de aquella forma y de habernos dado una respuesta errónea 
                                            * seguiría ejecutando las líneas de código que hay más adelante, pues es una cuestión simple 
                                            * de rendimiento para no dejar que el programa caiga porque lo más frecuente a la hora de 
                                            * programar son las operaciones aritméticas y puede ser que tengamos en un programa miles de 
                                            * operaciones aritméticas y una de ellas se desborde, pues el compilador asume que esa la 
                                            * ignoramos, damos una respuesta errónea pero no dejamos que el programa caiga, eso es lo que 
                                            * hace realmente el compilador, es una cuestión de rendimiento, sin embargo el comportamiento 
                                            * del compilador de C# en ocasiones no nos vendrá bien, es decir habrá veces que lo que
                                            * queremos es que si ocurre una circunstancia de estas características pues se lance una
                                            * excepción, entonces en ese caso lo que haremos es utilizar la expresión checked
                                            */
            Console.WriteLine(numero5); /* Imprimirá en consola el valor máximo que admite el tipo primitivo int, en definitiva lo que hace 
                                         * la expresión int.MaxValue es devolvernos el valor máximo de un primitivo int, lo guarda el 
                                         * número y lo imprimirá en consola */
            Console.WriteLine(resultado1);
            checked /* Expresión checked, lo que le decimos al programa es que lo que hay dentro de la expresión checked , pues lo chequé
                     * de tal forma que si hay un error de estas características, una excepción del desbordamiento no siga hacia adelante,
                     * sino que el programa caiga efectivamente, es cómo decirle al programa: oye mira comprueba, en vez de dejarlo pasar
                     * por alto, qué es lo que hace por defecto, comprueba esto minuciosamente y en el caso de que haya un error pues que
                     * se lance la excepción, al ejecutar este programa vemos que se lanza la excepción de Overflow, este comportamiento no
                     * es demasiado conocido en C#, pues son circunstancias que se dan */
            {
            int numero6 = int.MaxValue;
            int resultado2 = numero6 + 20;
            Console.WriteLine(numero6);
            Console.WriteLine(resultado2);
            }
            /* El entorno de desarrollo Visual Studio tiene una opción para qué este checked no lo tengamos que programar nosotros y el
             * compilador haga un chequeo exhaustivo de cada una de las operaciones aritméticas para que en el caso de que lance una
             * excepción caiga el programa sin necesidad de poner el checked, no es el comportamiento que tiene C# por defecto, ya que por
             * defecto lo dejamos pasar por alto pero si queremos que no lo pase por alto habría que hacer lo siguiente:
             * En primer lugar si pulsamos con el botón derecho sobre nuestro proyecto, es decir vamos al explorador de soluciones,
             * buscamos nuestro proyecto, pulsamos con el botón derecho y en el menú contextual elegimos propiedades se nos abren las
             * propiedades del proyecto, una vez que se nos han abierto las propiedades del proyecto tenemos que ir a compilación para
             * cambiar de alguna forma el comportamiento por defecto del compilador de C# y en la opción de compilación bajamos con la
             * barra de desplazamiento y pulsamos el botón de avanzadas y dentro de avanzadas tenemos:
             * Comprobar el desbordamiento y subdesbordamiento aritmético, por defecto está desactivado, eso quiere decir que el compilador
             * de C# por defecto no comprueba si hay desbordamiento, es decir si hay una excepción de tipo Overflow. Si activamos la casilla
             * es como si nosotros hubiésemos programado el checked pero de forma implícita sin necesidad de ponerlo, bueno pues aceptamos
             * la ventana, guardamos cambios con CONTROL+S en las modificaciones que hicimos en el compilador, cerramos la ventana de
             * propiedades y ahora si volvemos a ejecutar el programa a pesar de que no hay una expresión checked, pues lanzará una
             * excepción, al ejecutar el programa vemos cómo lanza la excepción, es como si hubiésemos escrito la expresión checked.
             * Este comportamiento que tiene C# esta relacionado con las excepciones de tipo desbordamiento */
        }
    }
}
