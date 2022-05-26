﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace Sport_Store
{
    public partial class addUser : System.Web.UI.Page
    {
        string patron = "holamundo";
        protected void BtnAddUsuario_Click(object sender, EventArgs e)
        {
            string conectar = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection sqlConectar = new SqlConnection(conectar);
            SqlCommand cmd = new SqlCommand("SP_AgregarUsuario", sqlConectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Connection.Open();
            cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = tbUsuario.Text;
            cmd.Parameters.Add("@Pass", SqlDbType.VarChar, 50).Value = tbPassword.Text;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = tbEmail.Text;
            cmd.Parameters.Add("@Patron", SqlDbType.VarChar, 50).Value = patron;

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblSuccess.Text = "Usuario creado con exito";
            }
            else
            {
                lblError.Text = "Error de Usuario o Contrasenia";
            }

            cmd.Connection.Close();
        }
    }
}