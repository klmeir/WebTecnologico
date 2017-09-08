using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tecnologico.Web.Core.DAO;
using Tecnologico.Web.Core.Model;

namespace WebTecnologico.App
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string num = Request["num"];
                if (!String.IsNullOrEmpty(num))
                {
                    Elemento l = DAOTabla.FindElemento(num);
                    this.lblNumero.Text = l.Numero;
                    this.lblNombre.Text = l.Nombre;
                    this.lblSimbolo.Text = l.Simbolo;
                }
            }

        }
    }
}