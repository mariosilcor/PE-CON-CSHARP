using System; //Instrucciones using, sirven para ver la ubicación de las librerías que vamos a usar.
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambientes_de_desarrollo_y_frameworks_Tarea04 //El namespace sirve para dar el nombre al programa.
{
    public partial class Form1 : Form //Aquí la clase parcial de tipo public está definida usando más de un archivo de código fuente.
    {
        public Form1() //Esta es la Clase Form de tipo public que representa la interfaz de usuario de la aplicación.
        {
            InitializeComponent(); //Aquí se ejecuta el método InitializeComponent que carga la página compilada de un componente.
        }

        private void btCalcular_Click(object sender, EventArgs e) //Este es el método btCalcular_Click que recibe como parámetro una referencia al control/objeto que generó el evento object sender, y los mismos datos del evento EventArgs e.
        {
            //Declarando las variables de tipo double a utilizar.
            double fahrenheit; //Variable donde se almacenará el valor ingresado por el usuario.
            double celcius; //Variable donde se almacenará el resultado de la operación.
            fahrenheit = (Convert.ToDouble(ctValor.Text)); //Aquí se asigna a la variable y la conversión del texto que está contenido en el objeto ctValor a un valor de tipo de dato double.
            celcius = (fahrenheit - 32) * 5/9; //Aquí se efectuará la operación para realizar la conversión de grados fahrenheit a grados celcius usando el valor que ingresó el usuario.
            ctResultado.Text = string.Format("{0:f}", celcius); //Aquí se asigna al objeto ctResultado que contiene un valor de tipo texto un valor de tipo string con formato numérico estándar que está contenido en la variable celcius.
        }
    }
}