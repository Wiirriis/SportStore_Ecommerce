using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sport_Store
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuariologueado"] != null)
            {
                string usuariologueado = Session["usuariologueado"].ToString();
                lblUsuario.Text = "Bienvenido/a " + usuariologueado;
                lblInicioSesion.Text = "Cerrar sesion";
                
            }
            /*else
            {
                Response.Redirect("WebForm1.aspx");
            }*/
        }
        protected void BtnCerrar_Click(object sender, EventArgs e)
        {
            Session.Remove("usuariologueado");
            Response.Redirect("Login_InfoToolsSV.aspx");
        }
    }
}