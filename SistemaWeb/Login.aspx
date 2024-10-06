<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SistemaWeb.Login" %>

<!DOCTYPE html>
<html class="bg-black" xmlns="http://www.w3.org/1999/xhtml"> <!--Class de tipo background black-->
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Acceso al Sistema de Clínica</title>
    <!--Enlazar estilos a nuestra página usando Bootstrap mediante cdn-->
    <link href="//maxcdn.bootsrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="//cdnjs.cloudflare.com/ajax/libs/font-awesome/4.1.0/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <!--Vamos a linkear nuestros estilos que incluimos dentro del proyecto-->
    <link href="css/AdminLTE.css" rel="stylesheet" type="text/css" />
</head>
<body class="bg-black"> <!--Este body tiene la clase background-black-->
    <div class="form-box" id="login-box"> <!--Este div tiene la clase formbox black que va a englobar nuestro form-->
        <div class="header">Login</div> <!--Este es el estilo del Login-->
        <form id="form1" runat="server"> <!--Este form se envía dentro del div-->
        <div class="body bg-gray"> <!--body donde pondremos nuestros controles-->
            <div class="form-group"> <!--form-group sirve para agrupar elementos dentro del formulario-->
                <!--Dentro del form-group pondremos nuestros controles de ASP.NET-->
                <!--TextBox de nuestro usuario-->
                <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control" placeholder="Ingrese su usuario."></asp:TextBox>
            </div>
            <div class="form-group">
                <!--TextBox de nuestro password-->
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" placeholder="Ingrese su password."></asp:TextBox>
            </div>
        </div>
            <!--Aquí en el Footer pondremos un botón para ingresar al Sistema-->
            <div class="footer">
                <asp:Button ID="btnIngresar" runat="server" Text="Iniciar Sesión" CssClass="btn bg-olive btn-block" OnClick="btnIngresar_Click" />
            </div>
    </form>
        </div>
    <!--Eventos de jquery y de bootstrap-->
    <script src="//ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/3.2.0/js/bootstrap.min.js" type="text/javascript"></script>
</html>