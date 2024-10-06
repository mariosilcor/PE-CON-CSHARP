using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; //Gracias a esta librería se puede usar Stream para la reproducción del sonido
using System.Linq;
using System.Media; //Gracias a esta librería se puede usar SoundPlayer para la reproducción del sonido
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiedraPapelTijeras
{
    public partial class Form1 : Form
    {
        //Inicialización de las variables int
        int PosicionOriginalPlayer1, PosicionOriginalPlayer2;
        int movimientosManos, TiempoSeleccion, TiempoTotalJuego = 0;
        //Booleano
        bool MovimientoArriba;
        //String
        String GaneActual = "empate";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            //Se obtiene pictureBox1.Location.Y
            PosicionOriginalPlayer1 = pictureBox1.Location.Y;
            //Se obtiene pictureBox2.Location.Y
            PosicionOriginalPlayer2 = pictureBox2.Location.Y;
            //Se inicializa timer3
            timer3.Enabled = true;
            timer3.Start();
            //Se llama IniciarJuego
            IniciarJuego();
            //Aquí reproduce el sonido readygo
            Sonido("readygo");
        }
        //Método para Iniciar el Juego
        public void IniciarJuego()
        {
            //Se inicializan las variables para poder Iniciar el Juego
            MovimientoArriba = false;
            movimientosManos = 0;
            //Tiempo que se tiene para que el usuario seleccione
            TiempoSeleccion = 150;
            GaneActual = "empate";
            //Se inicializa timer1 y timer2
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer1.Start();
            timer2.Start();
        }
        //Método para reproducir Sonido como un String que se le pasará como parámetro NombreSonido
        //El sonido se puede reproducir porque se envía a través de un parámetro String
        public void Sonido(String NombreSonido)
        {
            var sonido = (Stream)Properties.Resources.ResourceManager.GetObject(NombreSonido);
            SoundPlayer SonidoCargado = new SoundPlayer(sonido);
            SonidoCargado.Play();
        }
        //Aquí se utiliza el timer1 para identificar el tiempo de respuesta del usuario
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Se declaran variables para inicializar la velocidad de movimiento
            int posicion = pictureBox1.Location.Y;
            int velocidadMovimiento = 30;
            if ((posicion < 281) && (MovimientoArriba == false))
            {
                //Se realizan movimientos en las manos si la condición es true, todo esto dará la ilusión del movimiento de las manos
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + velocidadMovimiento);
                pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - velocidadMovimiento);
                //Se valida la posición de las manos si es igual a 263, si es así MovimientosArriba se convertirá en true
                if (posicion == 263)
                {
                    MovimientoArriba = true;
                }
            }
            if ((posicion > 59) && (MovimientoArriba == true))
            {
                //Se realizan movimientos en las manos si la condición es true, todo esto dará la ilusión del movimiento de las manos, contrario al incremento y al decremento
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - velocidadMovimiento);
                pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + velocidadMovimiento);
                //Se valida la posición de las manos si es igual a 83, si es así MovimientosArriba se convertirá en false
                if (posicion == 83)
                {
                    MovimientoArriba = false;
                    //Se incrementa 1 movimientosManos
                    movimientosManos++;
                }
            }
                //Se pregunta si(if) el movimiento de las manos es igual a 2, quiere decir que se movió 2 veces
                if (movimientosManos == 2)
                {
                    //Aquí se detiene el timer1, el pictureBox1 y el pictureBox2 se pondrán en la posición original que vendría siendo el movimiento de enmedio
                    timer1.Stop();
                    pictureBox1.Location = new Point(pictureBox1.Location.X, PosicionOriginalPlayer1);
                    pictureBox2.Location = new Point(pictureBox2.Location.X, PosicionOriginalPlayer2);
                    //Se inicializa la variable Random
                    //También se generan las 2 partidas por medio de un valor Random
                    Random rnd = new Random();
                    int player1 = rnd.Next(1, 4);
                    int player2 = rnd.Next(1, 4);
                    //Aquí caerán los valores aleatorios en los movimientos de las manos para player1 y para player2
                    pictureBox1.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(player1.ToString());
                    pictureBox2.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(player2 + "_d");
                    //Aquí se vuelve a inicializar timer2
                    timer2.Start();
                    //Aqui se identifica el botón(button) que el usuario presiono
                    rojo.Enabled = true;
                    azul.Enabled = true;
                    empate.Enabled = true;

                    //Aquí se denotan los valores 1, 2 y 3 que son tijera, piedra y papel y se hacen las siguientes validaciones
                    //1.- Tijera
                    //2.- Piedra
                    //3.- Papel

                    //Aquí se valida si el azul gana
                    if (((player1 == 1) && (player2 == 2)) || ((player1 == 2) && (player2 == 3)) || ((player1 == 3) && (player2 == 1)))
                    {
                        GaneActual = "azul";
                    }
                    //Aquí se valida si el rojo gana
                    if (((player1 == 1) && (player2 == 3)) || ((player1 == 2) && (player2 == 1)) || ((player1 == 3) && (player2 == 2)))
                    {
                        GaneActual = "rojo";
                    }
                }
        }
        //Aquí se utiliza el timer2 para identificar el tiempo de respuesta del usuario
        private void timer2_Tick(object sender, EventArgs e)
        {
            //Aquí se decrementa de 1 en 1, el tiempo de 150 
            TiempoSeleccion--;
            //Aquí es cuánto se tiene de tiempo el usuario para seleccionar la opción que el crea conveniente
            lblTiempo.Text = TiempoSeleccion.ToString() + "ms";
            //Si TiempoSelección es menor o igual a 0 se detendrá el timer2
            if (TiempoSeleccion <= 0)
            {
                timer2.Stop();
                IniciarJuego();
                //Se volverá a iniciar el juego diciéndole que hay un tiempo fuera, se reproducirá un sonido de timeover
                Sonido("timeover");
            }
        }
        //Si el usuario selecciona la opción predeterminada, se utilizará el método Verificar donde se verificará que botón(button) presiono el usuario
        private void Verificar(object sender, EventArgs e) //Evento Verificar
        {
            //Aquí se comparará el ganador actual
            String Presionado = ((PictureBox)sender).Name;
            //Se identificará si el botón(button) presionado es igual al ganador actual ya sea azul o rojo debido a la función aleatorio(Random)
            //Se identificará que el botón presionado es igual al GaneActual y TiempoSeleccion es mayor a 0
            if ((Presionado == GaneActual) && (TiempoSeleccion > 0))
            {
                //Conversión de toString a toInt debido a que se trabaja con un valor entero porque se refiere al incremento de un punto, es decir si el botón(button) Presionado es igual a GaneActual se otorgará 1 punto
                lblPuntos.Text = (Convert.ToInt32(lblPuntos.Text) + 1).ToString();
                //Si la función es true se detendrá todo, es decir timer2 se detendrá y se dará el gane al jugador
                timer2.Stop();
                //Se inicializará nuevamente el juego y se reproducirá como Sonido Punto
                IniciarJuego();
                Sonido("Punto");
            }
            else 
            {
                //En caso contrario también se detendrá el tiempo, es decir timer2 se detendrá
                timer2.Stop();
                //Se inicializará nuevamente el juego y se reproducirá como Sonido error, en vez de Sonido Punto
                IniciarJuego();
                Sonido("error");
            }
            //Aquí se desactivarán los botones para que el usuario ya no pueda seleccionar los botones hasta que el tiempo sea válido
            rojo.Enabled = false;
            azul.Enabled = false;
            empate.Enabled = false;
        }
        //Aquí se utiliza el timer3 para identificar el tiempo de respuesta del usuario
        private void timer3_Tick(object sender, EventArgs e)
        {
            //Aquí se validará el tiempo total del juego y si el juego no se ha terminado se verán los puntos que alcanzó el usuario
            if (TiempoTotalJuego == (1000 * 1))
            {
                //Si el tiempo ya se terminó, el juego ya se ha terminado
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                //Si el juego ya ha terminado reproducirá el sonido gameover
                Sonido("gameover");
                //El DialogResult es para preguntar si el usuario quiere que el juego continúe, si es así le dirá un mensaje de Tiempo agotado y los Puntos finales que logro el usuario
                DialogResult result = MessageBox.Show("Tiempo agotado - Puntaje Final:" + lblPuntos.Text, "Tiempo agotado", MessageBoxButtons.OK);
                //Cómo última instancia preguntará si result es igual a DialogResult.OK
                if (result == DialogResult.OK)
                {
                    //Aquí se podrá volver a inicializar todo, activar el timer3 e inicializar el juego
                    lblPuntos.Text = "0";
                    timer3.Enabled = true;
                    timer3.Start();
                    IniciarJuego();
                    //Si el juego se vuelve a inicializar se reproducirá el Sonido readygo
                    Sonido("readygo");
                }
            }
            //Se implementará TiempoTotalJuego incrementándose de 1 en 1
            TiempoTotalJuego++;
        }
    }
}