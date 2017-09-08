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
    public partial class WebForm1 : System.Web.UI.Page
    {
        List<Elemento> list_e = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            list_e = DAOTabla.TodosElementos();
            //return View(list_e);
            //RecorrerElemento(list_e);

        }

        public static void RecorrerElemento(List<Elemento> lista_e)
        {
            foreach (Elemento f in lista_e)
            {
                Console.WriteLine(f.ToString());
            }
        }

        public List<Elemento> ListadoElementos()
        {
           return list_e;
        }        
        /*
        protected void btnMostarElemento(object sender, EventArgs e)
        {

            Elemento ele = sender as Elemento;

            if (ele != null)
            {
                Response.Redirect("~/App/Pagina1.aspx");
            }


        }
        */
    }
}