using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class EmpleadoLN //Esta Clase nos servirá para acceder a nuestros métodos
    {
        //Se creará la region
        #region "PATRON SINGLETON"
        //Dentro de la region se creará un atributo EmpleadoLN de la Clase EmpleadoLN de tipo private static
        //La variable objEmpleado de tipo EmpleadoLN está en null, es decir no está instanciada
        private static EmpleadoLN objEmpleado = null;
        //Aquí se esconde el Constructor
        private EmpleadoLN()
        {

        }
        //Aquí se creará un método public static que nos devolverá un objeto EmpleadoLN y una instancia del objeto EmpleadoLN
        public static EmpleadoLN getInstance()
        {
            //Aquí es la condicional if del objeto objEmpleado
            if (objEmpleado == null)
            {
                objEmpleado = new EmpleadoLN();
            }
            //Aquí se retornará el objeto objEmpleado
            return objEmpleado;
        }

        //Aquí será nuestra Lógica del Negocio
        public Empleado AccesoSistema(String user, String pass)
        {
            //Tenemos que acceder al método AccesoSistema
            //Entonces retornamos EmpleadoDAO
            //El try catch es para verificar las excepciones
            try
            {
                return EmpleadoDAO.getInstance().AccesoSistema(user, pass);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Se cerrará la region
        #endregion
    }
}
