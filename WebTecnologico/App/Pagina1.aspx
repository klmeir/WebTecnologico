<%@ Page Title="" Language="C#" MasterPageFile="~/App/Site1.Master" AutoEventWireup="true" CodeBehind="Pagina1.aspx.cs" Inherits="WebTecnologico.App.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="server">
    Consulta de Cartera
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    CONTENIDO DE LA PAGINA
    <div>

        <table>
            <tr>
                <% 
                    for (int i = 0; i < 18; i++)
                    { 
                %>
                <th></th>
                <% 
                 }
                %>
            </tr>
            <tr>
                <%
                    int g = 1;
                    int p = 1;
                    int itemp = 1;
                    foreach (var item in this.ListadoElementos())
                    {

                        if (g < 19)
                        {

                            g++;
                            itemp = int.Parse(item.Periodo);
                            if ((int.Parse(item.Periodo) != p))
                            {
                                g = 1;
                                p++;
                        
                %>
            </tr>
            <tr>
                <td width="5%" align="center" bgcolor="<%= item.Color %>"><%= item.Numero %><br>
                    <a title="<%= item.Nombre %>" href="Detalle.aspx?num=<%= item.Numero %>"><%= item.Simbolo %></a>
                </td>

                <%  
                    }
                    else
                    {
                %>

                <td width="5%" align="center" bgcolor="<%= item.Color %>"><%= item.Numero %><br>
                    <a title="<%= item.Nombre %>" href="Detalle.aspx?num=<%= item.Numero %>"><%= item.Simbolo %></a>
                </td>

                <%  
                    }
                }
                else
                {
                    
                %>
            </tr>
            <tr>
                <%
                    g = 1;
                    p++;
                }


            } 
                %>
        </table>
    </div>
    <script type="text/javascript">
        function btnMostarElemento(i) {
            alert(item);
        }
</script>
</asp:Content>
