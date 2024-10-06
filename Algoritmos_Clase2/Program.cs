using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; //LIBRERÍA PARA ARCHIVOS DE TEXTO
using System.IO; //LIBRERÍA PARA ARCHIVOS EN GENERAL

namespace Algoritmos_Clase2 //NOMBRE DEL PROGRAMA
{
    class Program //CLASE PROGRAM
    {
        static void Main(string[] args) //MÉTODO MAIN
        {
            StreamReader archivo;//CLASE STREAMREADER QUE ESTA EN LA LIBRERÍA PARA ARCHIVOS DE TEXTO DONDE CREARÉ EL OBJETO ARCHIVO
            string linea; //Clase string que esta en la librería System.Collections.Generic vamos a crear la variable linea
            archivo = File.OpenText("Prueba.txt"); //Operación OpenText del método File, pero debe existir dentro de la misma carpeta donde está el programa un archivo llamado Prueba.txt
            linea = archivo.ReadLine();  //Variable linea se hace un ReadLine del archivo pero no de la consola
            Console.WriteLine(linea); //En la consola vamos a escribir la linea
            Console.WriteLine(archivo.ReadLine()); //En la consola vamos a escribir una linea que sea la lectura desde el archivo
            archivo.Close(); //Se cierra el archivo
            Console.ReadKey(); //Se detiene el programa
        }
    }
}
