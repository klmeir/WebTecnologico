<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="WebTecnologico.App.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="alert alert-danger" role="alert">
        <h1>Detalle De Elemento</h1>
        <br />
        <asp:Label runat="server" ID="lblNumero"></asp:Label> 
        <br />
        <asp:Label runat="server" ID="lblNombre"></asp:Label> 
        <br />
        <asp:Label runat="server" ID="lblSimbolo"></asp:Label>      
    </div>
    </form>
</body>
</html>
