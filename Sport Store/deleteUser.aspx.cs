using System;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
namespace Sport_Store
{
    public partial class deleteUser : System.Web.UI.Page
    {
        string patron = "holamundo";
        protected void BtnDeleteUsuario_Click(object sender, EventArgs e)
        {
            string conectar = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection sqlConectar = new SqlConnection(conectar);
            SqlCommand cmd = new SqlCommand("SP_DeleteUsuario", sqlConectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Connection.Open();
            cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = tbUsuario.Text;

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblSuccess.Text = "Usuario eliminado con exito";
            }
            else
            {
                lblError.Text = "Error de Usuario o Contrasenia";
            }

            cmd.Connection.Close();
        }

        protected void BtnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
    }
}