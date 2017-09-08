using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tecnologico.Web.Core.DAO;
using Tecnologico.Web.Core.Model;

namespace WebTecnologico
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string msg = Request["msg"];
                if (!String.IsNullOrEmpty(msg))
                {
                    this.lbMsg.Text = msg;
                }
            }
        }

         

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string password = txtPassword.Text;

            Usuario usuario = DAOUsuario.FindUsuario(user, password);

            if (usuario != null)
            {
                this.Session.Clear();
                this.Session.Add("usuario.App", usuario);
                Response.Redirect("~/App/Pagina1.aspx");
            }

            
        }
    }
}