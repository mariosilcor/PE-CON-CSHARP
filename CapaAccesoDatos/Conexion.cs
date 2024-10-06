using System;
using System.Collections.Generic;
using System.Data.SqlClient; //Accede a los métodos del Cliente Sql
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    //Esta clase será para crear nuestra conexión a la base de datos
    public class Conexion
    {
        //Se crearán las instancias declarando una region
        #region "PATRON SINGLETON"
        //Dentro de la region se creará un atributo Conexion de la Clase Conexion de tipo private static
        //La variable conexion de tipo Conexion está en null, es decir no está instanciada
        private static Conexion conexion = null;
        //Se ocultará el Constructor Conexion
        private Conexion()
        {

        }
        //Se creará un método public static para retornar una instancia de la Clase Conexion
        //Se retornará un objeto Conexion y el método se llamará getInstance
        public static Conexion getInstance()
        {
            if (conexion == null)
            {
                //Si no se ha instanciado se creará una nueva instancia, es decir un nuevo objeto de la Clase Conexion
                conexion = new Conexion();
            }
            //Aquí se retornará conexion
            return conexion;
        }
        #endregion

        //Se creará un método de tipo public que nos devuelva la conexion a la base de datos
        public SqlConnection ConexionBD()
        {
            //El método retornará una nueva instancia de la cadena de conexion SqlConnection
            SqlConnection conexion = new SqlConnection();
            //Se obtendrá la cadena de conexion y se retornará un String
            //El DataSource es donde se obtendrá la Data, si es de manera local será .
            //Si la base de datos está dentro de un servidor será la dirección IP
            //El InitialCatalog es el nombre de la base de datos
            conexion.ConnectionString = "Data Source = .; Initial Catalog = DBClinica; User ID = Eduardo; Password = Kurasao";
            //Se devolverá una variable de tipo SqlConnection
            return conexion;
        }
    }
}
