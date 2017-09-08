using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecnologico.Web.Core.Model
{
    public class Categoria
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        
    }
}
