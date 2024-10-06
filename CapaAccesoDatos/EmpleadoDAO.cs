using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades; //Accede a las Clases de la CapaEntidades
using System.Data.SqlClient;
using System.Data;

namespace CapaAccesoDatos
{
    //Clase EmpleadoDAO
    public class EmpleadoDAO
    {
        //Se creará la region
        #region "PATRON SINGLETON"
        //Se creará una instancia de la misma Clase
        private static EmpleadoDAO daoEmpleado = null;

        //Se esconderá el Constructor Empleado DAO
        private EmpleadoDAO()
        {

        }
        //Se creará un método public static que retornará una instancia EmpleadoDAO
        public static EmpleadoDAO getInstance()
        {
            //Si no se ha instanciado se creará una nueva instancia, es decir un nuevo objeto de la Clase EmpleadoDAO
            if (daoEmpleado == null)
            {
                daoEmpleado = new EmpleadoDAO();
            }
            //Se retornará daoEmpleado
            return daoEmpleado;
        }
        //Se cerrará la region
        #endregion

        //Se creará un método para loggearnos al Sistema a través de la base de datos
        //El método para hacer un acceso al Sistema retornará un objeto de tipo Empleado que se hizo referencia a la CapaEntidades
        //El método se llamará AccesoSistema y recibirá como parámetros el usuario y el password
        public Empleado AccesoSistema(String user, String pass)
        {
            //Aquí se obtiene la cadena de conexion
            //Se necesita un SqlConnection, una lectura de datos y una lectura de comandos
            SqlConnection conexion = null;
            //El SqlCommand es para enviar nuestro comando a la base de datos y que se ejecute
            SqlCommand cmd = null;
            //El SqlDataReader es para leer los datos
            SqlDataReader dr = null;
            //El objeto de tipo Empleado es el que se llenará dentro del método
            Empleado objectEmpleado = null;

            //Aquí nos permitirá traer el objeto de la base de datos y verificar que sea un usuario válido
            //Se usará un try catch para menejar las excepciones y el finally es para cerrar la cadena
            try
            {
                //Aquí se hará referencia a la Clase Conexion que accederá al método ConexionBD
                conexion = Conexion.getInstance().ConexionBD();
                //Aquí ya teniendo Acceso a ConexionBD se enviará el comando y recibirá como parámetros el nombre de nuestro procedimiento almacenado y como segundo parámetro se enviará la conexion
                cmd = new SqlCommand("spAccesoSistema", conexion);
                //Aquí diremos qué tipo de comando estamos enviando que será un prodecdimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                //Aquí se enviarán los parámetros a nuestra consulta, el primer parámetro es el nombre de nuestro parámetro y el segundo parámetro es el dato que se envía del método AccesoSistema 
                //Los parámetros se envían con @
                cmd.Parameters.AddWithValue("@prmUser", user);
                cmd.Parameters.AddWithValue("@prmPass", pass);
                //Esto es para abrir la conexion y ejecutar
                conexion.Open();
                //Ya tenemos los datos de nuestro formulario que se envían a nuestro procedimiento
                //Así que ejecutaremos nuestro método con un lector de datos que se estará enviando al SqlDataReader
                dr = cmd.ExecuteReader();
                //Si la lectura de datos tiene una lectura para leer nos creará un objeto
                if(dr.Read())
                {
                    //Como está en null se tandrá que instanciar
                    objectEmpleado = new Empleado();
                    //Se obtendrá el ID, conviertiendo el dato que se trae como String a un Int y se asigna al atributo de nuestro objeto
                    objectEmpleado.ID = Convert.ToInt32(dr["idEmpleado"].ToString());
                    //Se hará lo mismo con el Usuario y el Password pero no se convertirá el dato porque ya es un String
                    objectEmpleado.Usuario = dr["usuario"].ToString();
                    objectEmpleado.Clave = dr["clave"].ToString();
                }
            }
            catch (Exception ex) 
            {
                //Esto es si no se ejecuta el try
                objectEmpleado = null;
                //Esto es para retornar la excepción
                throw ex;
            }
            finally
            {
                //Aquí es para cerrar la conexion
                conexion.Close();
            }
            //Aquí se retornará el objeto
            return objectEmpleado;
        }
    }
}
