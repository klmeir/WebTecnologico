<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebTecnologico.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inicio de Sesion</title>
    <link href='http://fonts.googleapis.com/css?family=Open+Sans:400,700' rel='stylesheet' type='text/css' />

    <link rel="stylesheet" type="text/css" href="<%= ResolveClientUrl("~/lib/bootstrap/css/bootstrap.css") %>" />
    <link rel="stylesheet" type="text/css" href="<%= ResolveClientUrl("~/lib/font-awesome/css/font-awesome.css") %>" />

    <script src="<%= ResolveClientUrl("~/lib/jquery-1.11.1.min.js") %>" type="text/javascript"></script>

    <link rel="stylesheet" type="text/css" href="<%= ResolveClientUrl("~/stylesheets/theme.css") %>" />
    <link rel="stylesheet" type="text/css" href="<%= ResolveClientUrl("~/stylesheets/premium.css") %>" />

    <!-- Le HTML5 shim, for IE6-8 support of HTML5 elements -->
    <!--[if lt IE 9]>
      <script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
    <![endif]-->

    <style type="text/css">
        #line-chart
        {
            height: 300px;
            width: 800px;
            margin: 0px auto;
            margin-top: 1em;
        }

        .navbar-default .navbar-brand, .navbar-default .navbar-brand:hover
        {
            color: #fff;
        }
    </style>
</head>
<body class=" theme-blue">

    <div class="navbar navbar-default" role="navigation">
        <div class="navbar-header">
            <a class="" href="<%= ResolveClientUrl("~/Login.aspx") %>"><span class="navbar-brand"><span class="fa fa-paper-plane"></span>Aircraft</span></a>

        </div>

        <div class="navbar-collapse collapse" style="height: 1px;">
        </div>
    </div>

    <div class="dialog">
        <div class="panel panel-default">
            <p class="panel-heading no-collapse">Sign In</p>
            <div class="panel-body">
                <form id="form1" runat="server">
                    <div class="form-group">
                        <label>Username</label>
                        <asp:TextBox runat="server" ID="txtUsername" CssClass="form-control span12"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>Password</label>
                        <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" CssClass="form-controlspan12 form-control"></asp:TextBox>
                    </div>
                    
                    <asp:Button runat="server" ID="btnSignIn" Text="Sign In" CssClass="btn btn-primary pull-right" OnClick="btnSignIn_Click"/>
                    
                    <label class="remember-me">
                        <input type="checkbox">
                        Remember me</label>
                    <div class="clearfix"></div>
                </form>
            </div>
        </div>
        <p class="pull-right" style=""><a href="http://www.portnine.com" target="blank" style="font-size: .75em; margin-top: .25em;">Design by Portnine</a></p>
        <p><a href="reset-password.html">Forgot your password?</a></p>

        <div class="alert alert-danger" role="alert">
             <asp:Label runat="server" ID="lbMsg"></asp:Label>
        </div>
       
    </div>

    <script src="<%= ResolveClientUrl("~/lib/bootstrap/js/bootstrap.js") %>"></script>
    

</body>
</html>
