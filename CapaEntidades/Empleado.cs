using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    //Atributos de la Clase Empleado
    public class Empleado
    {
        public int ID { get; set; }
        //Objeto TipoEmpleado del atributo RTipoEmpleado
        public TipoEmpleado RTipoEmpleado { get; set; }
        public String Nombre { get; set; }
        public String ApPaterno { get; set; }
        public String ApMaterno { get; set; }
        public String NumDocumento { get; set; }
        public bool Estado { get; set; }
        public String Imagen { get; set; }
        public String Usuario { get; set; }
        public String Clave { get; set; }

        //Constructor vacío
        public Empleado()
        {

        }
        //Constructor con parámetros que son los atributos de la Clase Empleado
        public Empleado(int ID, TipoEmpleado RTipoEmpleado, String Nombre, String APaterno, String ApMaterno, String NumDocumento, bool Estado, String Imagen, String Usuario, String Clave)
        {
            //Instancias de los atributos que estamos recibiendo
            this.ID = ID;
            this.RTipoEmpleado = RTipoEmpleado;
            this.Nombre = Nombre;
            this.ApPaterno = ApPaterno;
            this.ApMaterno = ApMaterno;
            this.NumDocumento = NumDocumento;
            this.Estado = Estado;
            this.Imagen = Imagen;
            this.Usuario = Usuario;
            this.Clave = Clave;
        }
    }
}