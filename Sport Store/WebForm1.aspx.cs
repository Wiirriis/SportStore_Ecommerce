using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using Sport_Store.Datos;

namespace Sport_Store
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ProductosAdmin productos = new ProductosAdmin();
        protected void Page_Load(object sender, EventArgs e)
        {
            gvProductos.DataSource = productos.consultarProductos();
            gvProductos.DataBind();
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