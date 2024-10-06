using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algoritmos_Clase3
{
    class Program //La Clase Program contiene el método Main
    {
        static void Main(string[] args) //Método Main
        {
            /* De la clase ListaEnlazada vamos a definir la variable lista
             * y vamos a asignarle a la variable lista la creación de un nuevo
             objeto de la clase ListaEnlazada */
            ListaEnlazada lista = new ListaEnlazada(); //Se crea el objeto lista enlazada
            /* Del objeto lista que creamos vamos a ejecutar el método Insertar
             y le vamos a pasar como datos los números 9, 12 y 4 */
            lista.Insertar(9); //Se inserta un nodo a la lista con un aatributo de tipo entero(int)
            lista.Insertar(12);
            lista.Insertar(4);
            /* De la clase lista Ejecutamos el método Mostar que no necesita parámetros */
            //4.9 y 12
            lista.Mostrar(); //Muestra la lista enlazada del menor al mayor de los tipos de datos
            lista.Insertar(75);
            //4, 9, 12 y 75
            lista.Mostrar();
            lista.Borrar(4); //Borra un nodo de la lista enlazada
            //9, 12 y 75
            lista.Mostrar();
            //NOTA: El método Mostrar incluye un nodo null al último
            Console.ReadKey();
        }
    }

    class Nodo //Clase Nodo que contiene 2 atributos que son valor y sig
    {
        public int valor;
        public Nodo sig;
        //La variable v es un entero(int) y la variable s es un apuntador(descriptor de un objeto)
        public Nodo (int v, Nodo s) // Constructor de la Clase Nodo, el método se llama igual que la Clase que es Nodo, es decir, es un método constructor
            /* El método Constructor recibe 2 parámetros de entrada que son la v que es de tipo entera(int) y la v que es de tipo Nodo */
       //Una Clase se llama autoreferenciada cuando se tiene un atributo que se llama igual que la Clase
        {
            //Al atributo o variable valor del objeto se le asigna v
            valor = v;
            //Al atributo o variable sig del objeto se le asigna el descriptor de otro objeto
            sig = s;
        }
    }

    class ListaEnlazada //Clase ListaEnlazada
    {
        Nodo primero; //Primer nodo
        Nodo actual; //Actual nodo
        public ListaEnlazada() //Método constructor ListaEnlazada
        {
            primero = null; //Se asigna null al primer nodo
            actual = null; //Se asigna null al nodo actual
        }
        public void Insertar(int v) //Método constructor Insertar
        {
            Nodo anterior; //Se define la variable anterior como un contenedor para un objeto de la Clase Nodo
            if (ListaVacia() || primero.valor > v)
            {
                //Si la variable valor del objeto primero es mayor que la variable v significa que es el primer dato
                //Preguntamos si la lista está vacía regresa a true y si no regresa a false y eso lo sabemos cuando primero sea igual a null
                //Se asigna a la variable primero la creación de un nuevo nodo con el valor del dato que va a entrar(v) y el apuntador primero
                primero = new Nodo(v, primero);
            }
            else
            {
                //Si no se cumple el if, entonces se busca la posición para la inserción del nuevo dato
                anterior = primero;
                while (anterior.sig != null && anterior.sig.valor <= v)
                    anterior = anterior.sig;
                anterior.sig = new Nodo(v, anterior.sig);
            }
        }
        public void Mostrar() //Método Constructor Mostrar
        {
            Nodo aux; //Se utiliza una Variable auxiliar que va a ir recorriendo la lista
            aux = primero; //El recorrido empieza con la variable primero
            while (aux != null) //Mientras la variable aux sea diferente de null
            {
                //Se va a imprimir el valor del nodo y también un espacio y ->
                Console.Write(aux.valor + " -> ");
                aux = aux.sig;
                //La ejecución del programa se sale del while si la variable aux es null
            }
            Console.Write("null");
            Console.WriteLine(); //Salto de línea   
        }

        //Los métodos Siguiente, Primero y Ultimo no se utilizan
        public void Borrar(int v) //Método Constructor Borrar
        {
            Nodo anterior, nodo;
            nodo = primero;
            anterior = null;
            while (nodo != null && nodo.valor < v)
            {
                anterior = nodo;
                nodo = nodo.sig;
            }
            if (nodo == null || nodo.valor != v)
                return;
            else
            {
                if (anterior == null)
                    primero = nodo.sig;
                else anterior.sig = nodo.sig;
            }
        }
        public bool ListaVacia() //Método Constructor ListaVacia
        {
            //Preguntamos si la lista está vacía regresa a true y si no regresa a false y eso lo sabemos cuando primero sea igual a null
            if (primero == null)
                return true;
            return false;
        }

        //Los métodos Siguiente, Primero y Ultimo no se utilizan

        /*
         
        public void Siguiente ()
        {
            if (actual != null)
        actual = actual.sig;
        }

        public void Primero()
        {
            actual = primero;
        }

        public void Ultimo()
        {
            Primero();
            if (!ListaVacia())
                while (actual.sig != null)
                    Siguiente();
        }

        public bool Actual()
        {
            if (actual != null)
                return true;
            return false;
        }

        public int ValorActual()
        {
            return actual.valor;
        }

         */
    }

}
