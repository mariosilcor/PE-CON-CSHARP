using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoTierraMedia
{
    //Clase Inicio que hereda de la Clase Formulario(Form)
    public partial class Inicio : Form
    {
        public Inicio() //Constructor del formulario Inicio
        {
            //Inicialización de los Componentes
            InitializeComponent();
        }

        //Método del evento Button para salir 
        private void btnSalir_Click(object sender, EventArgs e)
        {
            /* Método que cierra el formulario, 
             * que es el objeto(object) Inicio */
            this.Close();
        }

        /* Método del evento que carga el formulario(form),
         que ejecutará código cuando el formulario(form)
        se carga */
        private void Inicio_Load(object sender, EventArgs e)
        {
            /* Método del evento btnSolicitar en su
             propiedad .Enabled tenga el valor 
            falso(false), es decir el botón(button)
            estará deshabilitado */
            btnSolicitar.Enabled = false;
        }

        private void controlBotones()
        {
            /*Este método controlBotones tomará el
             * texto dentro de la caja de texto
             llamada nombre, es decir el nombre que
            ingresa el usuario, el método Trim
            elimina espacios si es que el usuario
            los ingreso, luego de esto se compara si
            es diferente(!=) de string vacío y además
            el texto que contiene la caja de texto
            nombre tenga únicamente letras*/
            if (nombre.Text.Trim() != string.Empty &&
                nombre.Text.All(Char.IsLetter))
            {
                /*Si se cumple está condición el evento
                 btnSolicitar se habilitará y además
                del componente errorProvider1 se obtendrá
                un String vacío*/
                btnSolicitar.Enabled = true;
                errorProvider1.SetError(nombre, "");
            }
            else
            {
                /*Esto es si no se cumple la condición de 
                 * que el usuario no ingrese letras*/
                if (!(nombre.Text.All(Char.IsLetter)))
                {
                    /*Si se cumple está condición, del
                     * componente errorProvider1 se
                     * obtendrá un mensaje de tipo String*/
                    errorProvider1.SetError(nombre,
                        "El nombre sólo debe contener " +
                        "letras");
                }
                else
                {
                    /*Si el usuario no ingresa letras, se
                     da por hecho que el usuario no introdujo
                    nada, es decir del componente
                    errorProvider1 se obtendrá un mensaje
                    de tipo String*/
                    errorProvider1.SetError(nombre,
                        "Debe introducir su nombre");
                }
                /*Para cualquiera de los casos del if-else
                 se deshabilitará el evento botón(button)*/
                btnSolicitar.Enabled = false;
                /*Este método significa que el usuario
                 * puede volver a escribir dentro de la 
                 * caja de texto, si es que el evento botón(button)
                 está deshabilitado*/
                nombre.Focus();
            }
        }

        /* Método del evento cuando cambia la 
         * caja de texto(TextChanged) */
        private void nombre_TextChanged(object sender, EventArgs e)
        {
            //Método que va a controlar los botones(buttons)
            controlBotones();
        }

        //Método del evento botón(button) btnSolicitar
        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            /* Constructor del formulario Prestamos,
             que se le pasará la caja de texto(TextBox)
            llamado nombre.
            
             Instanciar objetos: instrucción new.
            
             Palabra reservada using, lo que hace es que luego
            de que se ejecute el código, el objeto se eliminará
            de la memoria, llamando automáticamente a un método
            llamado dispose, que lo que hace es eliminar toda
            referencia de la memoria. */
            using (Prestamos ventanaPrestamos =
                new Prestamos(nombre.Text))
                /*El método .ShowDialog muestra el 
                 formulario(form) de forma modal.
                
                 La diferendia del método .Show es que nos abre 
                dos hilos(thread) diferentes donde vamos a poner
                cada uno de los formularios(forms), en cambio el
                método .ShowDialog utiliza el mismo hilo(thread)
                del proceso para mostrar ambos formularios(forms) 
                y por eso uno queda bloqueado hasta que se
                resuelva el otro formulario*/
            ventanaPrestamos.ShowDialog();
        }
    }
}
