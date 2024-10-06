using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidades;
using CapaLogicaNegocio;

namespace SistemaWeb
{
    public partial class Login : System.Web.UI.Page
    {
        //El PageLoad es lo que se ejecuta cuando carga la página
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Evento del botón Iniciar Sesión
        //Dentro de este método se accederá a la Clase EmpleadoLN
        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            //Se hará una instancia del objeto porque vamos a obtener un objeto de tipo Empleado
            //El objeto Empleado se obtendrá del Método AccesoSistema que retornará un objeto Empleado que enviará dos parámetros
            Empleado objEmpleado = EmpleadoLN.getInstance().AccesoSistema(txtUsuario.Text, txtPassword.Text);
            //Como ya se están ingresando los datos del Web Form se usará la condicional if
            if (objEmpleado != null)
            {
                //Aquí quiere decir que si hemos accedido a la Base de datos y nos traerá un objeto
                //Se mostrará el el lado del cliente un script
                Response.Write("<script>alert('USUARIO CORRECTO.')</script>");
            }
            //Aquí quiere decir Si el objeto objEmpleado no es distinto es distinto de null, es decir es igual a un null
            else
            {
                Response.Write("<script>alert('USUARIO INCORRECTO.')</script>");
            }
            /*
            //Declaración y asignación de variables
            string user = txtUsuario.Text;
            string password = txtPassword.Text;
            string userName = "xd";
            string passName = "xd";
            //Condicional if que mostrará una alerta si el user y el password son iguales
            if (user.Equals(userName) && password.Equals(passName)) //Método .Equals
            {
                //Alerta de JS
                Response.Write("<script>alert('USUARIO CORRECTO')</script>");
            }
            else
            {
                //Alerta de JS
                Response.Write("<script>alert('USUARIO INCORRECTO')</script>");
            }
        }
           

        protected void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }   
            */
        }
    }
}