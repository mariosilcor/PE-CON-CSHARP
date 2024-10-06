//Instrucciones using, sirven para ver la ubicación de las librerías a usar.
using System;

namespace ArbolBinarioOrdenado //El namespace sirve para dar el nombre al programa.
{
    public class ArbolBinarioOrdenado //Este es el nombre de la Clase de tipo public.
    {
        class Nodo
        {
            public int info;
            public Nodo izq, der;
        }
        Nodo raiz;

        public ArbolBinarioOrdenado()
        {
            raiz = null;
        }

        public void Insertar(int info) //Este es el método Insertar de tipo public void que tiene como parámetro la variable info que es de tipo int, y no devuelve ningún valor.
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.info = info;
            nuevo.izq = null;
            nuevo.der = null;
            if (raiz == null)
                raiz = nuevo;
            else
            {
                Nodo anterior = null, reco;
                reco = raiz;
                while (reco != null)
                {
                    anterior = reco;
                    if (info < reco.info)
                        reco = reco.izq;
                    else
                        reco = reco.der;
                }
                if (info < anterior.info)
                    anterior.izq = nuevo;
                else
                    anterior.der = nuevo;
            }
        }


        private void ImprimirPre(Nodo reco) //Este es el método ImprimirPre de tipo private void que tiene como parámetro la variable reco que es de tipo objeto, y no devuelve ningún valor.
        {
            if (reco != null)
            {
                Console.Write(reco.info + " ");
                ImprimirPre(reco.izq);
                ImprimirPre(reco.der);
            }
        }

        public void ImprimirPre() //Este es el método ImprimirPre de tipo public void y no tiene ningún parámetro.
        {
            ImprimirPre(raiz);
            Console.WriteLine();
        }

        private void ImprimirEntre(Nodo reco) //Este es el método ImprimirEntre de tipo private void que tiene como parámetro la variable reco que es de tipo objeto, y no devuelve ningún valor.
        {
            if (reco != null)
            {
                ImprimirEntre(reco.izq);
                Console.Write(reco.info + " ");
                ImprimirEntre(reco.der);
            }
        }

        public void ImprimirEntre() //Este es el método ImprimirEntre de tipo public void y no tiene ningún parámetro.
        {
            ImprimirEntre(raiz);
            Console.WriteLine();
        }


        private void ImprimirPost(Nodo reco) //Este es el método ImprimirPost de tipo private void que tiene como parámetro la variable reco que es de tipo objeto, y no devuelve ningún valor.
        {
            if (reco != null)
            {
                ImprimirPost(reco.izq);
                ImprimirPost(reco.der);
                Console.Write(reco.info + " ");
            }
        }


        public void ImprimirPost() //Este es el método ImprimirPost de tipo public void y no tiene ningún parámetro.
        {
            ImprimirPost(raiz);
            Console.WriteLine();
        }

        static void Main(string[] args) //Este es el método Main que comienza la ejecución del programa en C#.
        {
            Console.WriteLine("ASIGNATURA. ALGORITMOS Y ESTRUCTURAS DE DATOS\nUNIDAD 4. ÁRBOLES\nTAREA 6.\n");
            int num, valor; //Declarando las variables de tipo de dato int a utilizar.
            ArbolBinarioOrdenado abo = new ArbolBinarioOrdenado(); //Aquí se asigna al objeto abo la nueva creación de la Clase ArbolBinarioOrdenado.
            Console.Write("Introduce la cantidad de números a ingresar: "); //Aquí se le pedirá al usuario que introduzca la cantidad de números a ingresar.
            num = Convert.ToInt32(Console.ReadLine()); //Aquí se asigna la variable num al método ReadLine que nos regresa un tipo de dato String, así que se tendrá que convertir a un tipo de dato int.
            Console.WriteLine(); //Aquí se hará un salto de línea.
            for (int i = 0; i < num; i++) //Este for nos ayuda a que todo el código dentro del bucle se ejecute la cantidad de veces que haya decidido el usuario la cantidad de números a ingresar.
            {
                Console.Write("Ingrese cualquier número: "); //Aquí se le pedirá al usuario que ingrese cualquier número.
                valor = Convert.ToInt32(Console.ReadLine()); //Aquí se asigna la variable valor al método ReadLine que nos regresa un tipo de dato String, así que se tendrá que convertir a un tipo de dato int.
                abo.Insertar(valor); //Aquí se ejecuta el método Insertar que se había asignado al objeto abo y tiene como parámetro la variable valor.
            }
            Console.WriteLine("\nImpresión preorden: "); //Aquí se mostrará en la consola de salida el mensaje Impresión preorden.
            abo.ImprimirPre(); //Aquí se ejecuta el método ImprimirPre que se había asignado al objeto abo.
            Console.WriteLine("\nImpresión entreorden: "); //Aquí se mostrará en la consola de salida el mensaje Impresión entreorden.
            abo.ImprimirEntre(); //Aquí se ejecuta el método ImprimirEntre que se había asignado al objeto abo.
            Console.WriteLine("\nImpresión postorden: "); //Aquí se mostrará en la consola de salida el mensaje Impresión postorden.
            abo.ImprimirPost(); //Aquí se ejecuta el método ImprimirPost que se había asignado al objeto abo.
            Console.ReadKey(); //Este es un comando para detener el programa, el ReadKey acepta cualquier tecla, mientras que el ReadLine solo acepta el Enter.
        }
    }
}