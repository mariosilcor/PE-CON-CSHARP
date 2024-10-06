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
    public partial class Prestamos : Form
    {
        /*Aquí se declara un dato de tipo String
         llamado nombre_cliente*/
        string nombre_cliente;
        //Arreglo(array) de datos de tipo String
        string[] razas_disponibles = { " Balrog ", " Drúedain ", " Enano ", " Elfo ", " Ent ", " Goblin ", " Hobbit ", " Hombre ", " Istari (Mago) ", " Orco ", " Troll ", "Uruk-hai " };
        //Arreglo(array) de datos de tipo int
        int[] cuotas_disponibles = { 12, 24, 36, 60, 120, 180, 240 };
        /*Arreglo(array) de Strings, pero no se inicializa,
         porque se inicializa dentro del Constructor
        leyendo los datos del archivo lugares.txt*/
        string[] lugares_disponibles;
        /*Diccionario(Dictionary) con las claves de tipo
         entero(int) y los valores de tipo doble(double),
        que es el que va a indicar cuántos intereses
        corresponden de acuerdo a las cuotas.
        
         La cantidad de cuotas es el tipo de dato int y 
        el monto del interés es el tipo de dato double*/
        Dictionary<int, double> intereses_base;

        /*Constructor Prestamos que es el nombre de la 
         * Clase(class), el Constructor recibirá el dato
         de tipo String llamado nombre*/
        public Prestamos(string nombre)
        {
            /*Lo que hace el Constructor es inicializar
             los componentes*/
            InitializeComponent();
            /*Aquí se asigna nombre_cliente lo que
             viene en nombre*/
            nombre_cliente = nombre;

            /*La siguientes líneas de código van a permitir cargar
             dentro del arreglo(array) lugares_disponibles todos 
            los datos que están dentro del archivo lugares.txt
            
             \r es el carácter de retorno
            \n es el carácter de nueva línea
            
             El archivo lugares se pasará a String(ToString)*/
            string listado_ciudades = Properties.Resources.lugares.ToString();
            /*Aquí se tomará el String listado_ciudades que
             separará los datos con los separadores \r\n,
            y utilizando el método .Split hará que el String
            se corte para obtener distintos Strings por
            separado y que cada uno de ellos este colocado
            como elemento del arreglo(array), así que el
            método .Split generará un nuevo arreglo(array), 
            y el método .RemoveEmptyEntries eliminará las
            líneas vacías detro del arreglo(array) de Strings
            si es que hay una línea vacía*/
            lugares_disponibles = listado_ciudades.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            /*Aquí se inicializa al diccionario,
             es decir se instancia*/
            intereses_base = new Dictionary<int, double>();
            /*Se declaran dos variables de tipo int y double*/
            int i;
            double intereses;
            /*El tipo de dato int que es i se inicializa en 0 
             * y termina en 1 menos de la longitud del 
             * arreglo(array) cuotas_disponibles, 
             * a su vez el tipo de dato double que es 
             * intereses se inicializa en 3.0 y se va a ir
             incrementado de 0.5 y el dato i se va a ir
            incrementando de uno en uno*/
            for (i = 0, intereses = 3.0;
                i < cuotas_disponibles.Length;
                i++, intereses += 0.5)
            {
                /*Al diccionario intereses_base se le va a ir
                 agregando una clave que es el elemento que
                sale dentro del arreglo(array) 
                cuotas_disponibles en la posición i hasta el
                final y por cada uno de ellos el valor que
                se colocará es el que esté dentro de la
                variable intereses que empezará en 3.0
                hasta llegar a 6.0*/
                intereses_base[cuotas_disponibles[i]] = intereses;
            }
        }

        //Evento Prestamos_Load de tipo privado(private)
        private void Prestamos_Load(object sender, EventArgs e)
        {
            /*Aquí son 3 llamadas a 3 métodos que se van a
             encargar de cargar o popular los datos dentro
            de los ComboBoxes*/
            popularCuotas();
            popularRazas();
            popularCiudades();
            /* El saludo concatena al String que sale
             del texto(.Text) el nombre del cliente con
            el operador += */
            saludo.Text += nombre_cliente;
        }

        /*Los siguientes métodos van a iterar por cada
         uno de los arreglos(arrays) agregando al
        ComboBox correspondiente todos los datos,
        desde el elemento 0 hasta 1 menos de la
        longitud pasando por cada uno de ellos uno a uno y
        por cada uno de los elementos del arreglo(array) lo
        que hará con el elemento cuotas_disponibles[i] es
        agregarlo a la propiedad Items del ComboBox.
        
         La propiedad(prop) Items es una colección de todos
        los elementos que muestra el ComboBox*/
        //Método popularCuotas
        void popularCuotas()
        {
            for (int i = 0; i < cuotas_disponibles.Length; i++)
            {
                cuotas.Items.Add(cuotas_disponibles[i]);
            }
        }

        //Método popularRazas
        void popularRazas()
        {
            for (int i = 0; i < razas_disponibles.Length; i++)
            {
                razas.Items.Add(razas_disponibles[i]);
            }
        }

        //Método popularCiudades
        void popularCiudades()
        {
            for (int i = 0; i < lugares_disponibles.Length; i++)
            {
                lugares.Items.Add(lugares_disponibles[i]);
            }
        }

        //Evento del botón(button) btnVolver_Click
        private void btnVolver_Click(object sender, EventArgs e)
        {
            /*Lo que se hará aquí es:
             Que este objeto(object) que es el formulario
            (form) Prestamos lo cierre y volverá a quedar
            visible el formulario anterior que era
            el formulario(form) de Inicio*/
            this.Close();
        }

        //Aquí se agrega el Cálculo de los Intereses
        /*El método calcular_Intereses calculará el
         interés*/
        double calcularInteres()
        {
            /*Aquí no hay conversión a String, así que se
             guardará en una variable cuotas_pedidas que es 
            un dato de tipo int el SelectedItem del
            ComboBox cuotas, pero como es un elemento de tipo
            Object no es un número entero(int), así que
            se convertirá a entero(int) y se usará para la
            conversión el casting que se hace poniendo
            entre paréntesis delante del objeto(object)
            a convertir el tipo de dato que queremos*/
            int cuotas_pedidas = (int)cuotas.SelectedItem;
            /*Aquí se obtendrán las propiedades(props)
             .SelectedItem, que significa, que se está
            obteniendo cual es el Item Seleccionado del 
            ComboBox y a ese elemento de tipo Object se va 
            a convertir a String mediante el método
            .ToString y después mediante el método
            .ToLower se convertirá a minúsculas */
            string raza_seleccionada = razas.SelectedItem.ToString().ToLower();
            string lugar_seleccionado = lugares.SelectedItem.ToString().ToLower();
            /*Aquí se definirá cual es el interés base
             que es el que selecciono el usuario,
            del diccionario intereses_base se tomará el
            valor que corresponda a cuotas_pedidas que se
            guardará en una variable de tipo double
            llamada interes*/
            double interes = intereses_base[cuotas_pedidas];
            /*Aquí se evaluarán las penalidades al nuevo 
             * arreglo (array) de razas, que es
             simplemente para evaluar si la raza 
            seleccionada es alguna del arreglo(array) y
            lo que se quiere hacer es saber si contiene a
            la raza seleccionada*/
            if (new[] { "orco", "uruk-hai", "goblin", "troll", "balrog" }.Contains(raza_seleccionada))
            {
                /*Si la raza seleccionada por el usuario 
                 * está dentro del arreglo(array) se le sumará
                 un interés de 0.3*/
                interes += 0.3;
            }
            if (new[] { "rivendell", "tirion", "valinor", "hobbiton", "bree", "gondor" }.Contains(lugar_seleccionado))
            {
                /*Si el lugar seleccionado por el usuario
                 está dentro del arreglo(array) se le restará
                un interés de 0.3*/
                interes -= 0.3;
            }
            /*Una vez que se tiene el cálculo del interés
             se retorna(return)*/
            return interes;
        }

        /*Método btnConfirmar_Click que es el que controla
         el evento*/
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            /*Aqui queremos ver si han pasado las
             validaciones necesarias para ver si el botón(button)
            se tiene que activar o no se tiene que activar y 
            también para ver si tenemos que mostrar el
            errorProvider1 de un panel o no se tiene que
            mostrar el errorProvider1*/

            /*Aquí se utilizará una estructura switch que va
             a evaluar el valor que retorna el método validaciones,
            el método validaciones retorna un tipo entero(int)*/
            switch (validaciones())
            {
                case 0:
                    {
                        errorProvider1.SetError(DatosPersonales, "");
                        errorProvider1.SetError(DatosPrestamo, "");
                        double interes_mensual = calcularInteres();
                        double monto_pedido = double.Parse(monto.Text);
                        int cuotas_pedidas = (int)cuotas.SelectedItem;
                        double interes_total = monto_pedido * (interes_mensual / 100) * cuotas_pedidas;
                        double monto_a_pagar = monto_pedido + interes_total;
                        string mensaje = "Su préstamo por " + monto_pedido + " en " + cuotas_pedidas + " cuotas se concederá con un interés del " + interes_mensual + "% mensual.\nEl monto final asciende a " + monto_a_pagar;
                        MessageBoxButtons botones = MessageBoxButtons.OK;
                        MessageBox.Show(mensaje, "Cálculo de intereses", botones);
                        break;
                    }
                case 1:
                    {
                        errorProvider1.SetError(DatosPersonales, "Debe completar todos los datos personales");
                        errorProvider1.SetError(DatosPrestamo, "");
                        break;
                    }
                case 2:
                    {
                        errorProvider1.SetError(DatosPrestamo, "Debe ingresar un monto numérico y una cantidad de cuotas");
                        errorProvider1.SetError(DatosPersonales, "");
                        break;
                    }
            }
        }

        /*Aquí también se agregará un método que se
          va a encargar de las validaciones*/

        /*Este método validaciones que retorna un valor entero(int)
         se va a encargar de validar los campos que se hayan 
        completado
        
         El método validaciones nos puede retornar 0, 1 o 2*/
        int validaciones()
        {
            /*Si(if) se completaron los campos de razas
             y lugares retornará 1, si agluno de los
            campos está vacío la propiedad
            .SelectedIndex de razas y/o lugares es menor
            o igual a -1, entonces el usuario no
            selecciono nada, es decir si el usuario no
            selecciono nada en el Combo de razas y/o
            en el Combo de lugares se retornará 1,
            el retornar 1 indica que hubo un error en el
            panel de Datos Personales*/
            if ((razas.SelectedIndex <= -1) || (lugares.SelectedIndex <= -1))
            {
                return 1;
            }
            else
            {
                /*Si(if) retorna 2 el error está en el panel
                 Detalle del Préstamo
                
                 Si el monto que ingreso el usuario en 
                la propiedad TextBox, se tiene que ver
                si todo el texto que ingreso el usuario
                son dígitos, es decir lo que se pretende 
                hacer es que todos los carácteres del String 
                Text sean dígitos, si todos los carácteres
                son dígitos dará verdadero(true)
                pero la negación(!) hará que si no todos 
                los carácteres son dígitos O (||) si el
                texto del monto está vacío(""), es decir
                si el String está vacío O (||) si el
                usuario no selecciono ninguna cuota, con
                la propiedad .SelectedIndex que nos permite
                evaluar si con el -1 el usuario no
                selecciono nada, si sucede cualquier
                condición de las 3 retornará 2, eso
                indica que hubo un error en el panel
                Detalle del Préstamo*/
                if (!(monto.Text.All(Char.IsDigit)) || (monto.Text == "") || (cuotas.SelectedIndex <= -1))
                {
                    return 2;
                }
                else
                {
                    /*Sino pasa nada de lo anterior
                     * retorna 0, es decir no hay ningún 
                     * error y la validación fue correcta,
                     * así que le tenemos que permitir al
                     * usuario ver el resultado de
                     su operación*/
                    return 0;
                }
            }
        }
    }
}
