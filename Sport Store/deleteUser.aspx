﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="deleteUser.aspx.cs" Inherits="Sport_Store.deleteUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <link href="Css/Estilos.css" rel="stylesheet" />
    <title>Eliminar usuario</title>
</head>
<body class="bg-light">
    <div class="wrapper">
        <div class="formcontent">
            <form id="formulario_login" runat="server">
                <div class="form-control">
                    <div class="row">
                        <asp:Label class="h2" ID="lblBienvenida" runat="server" Text="Elimina un usuario"></asp:Label>
                    </div>
                    <div>
                        <asp:Label ID="lblUsuario" runat="server" Text="Usuario:"></asp:Label>
                        <asp:TextBox ID="tbUsuario" CssClass="form-control" runat="server" placeholder="Nombre de Usuario"></asp:TextBox>
                    </div>
                    <div class="row">
                        <asp:Label runat="server" CssClass="alert-danger" ID="lblError"></asp:Label>
                        <asp:Label runat="server" CssClass="alert-success" ID="lblSuccess"></asp:Label>
                    </div>
                    <br />
                    <div class="row">
                        <asp:Button ID="BtnDelete" CssClass="btn btn-primary btn-dark" runat="server" Text="Eliminiar usuario" OnClick="BtnDeleteUsuario_Click" />
                    </div>
                    <br />
                    <div class="row">
                        <asp:Button ID="BtnCerrar" CssClass="btn btn-primary btn-dark" runat="server" Text="Regresar" OnClick="BtnRegresar_Click" />
                    </div>
                </div>
            </form>
        </div>
    </div>
</body>
</html>