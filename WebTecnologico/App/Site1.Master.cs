using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tecnologico.Web.Core.Model;

namespace WebTecnologico.App
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.GetCurrentUser() == null)
            {
                this.Session.Clear();
                Response.Redirect("~/Login.aspx?msg=Usuario no autorizado");
            }
        }

        protected Usuario GetCurrentUser()
        {
            return this.Session["usuario.App"] as Usuario;
        }

        public string GetUsername()
        {
            Usuario usuario = GetCurrentUser();

            return (usuario != null) ? usuario.Username : string.Empty;
        }

        protected void lnkLogout_Click(object sender, EventArgs e)
        {
            this.Session.Clear();
            this.Session.Abandon();
            Response.Redirect("~/Login.aspx");
        }
    }
}