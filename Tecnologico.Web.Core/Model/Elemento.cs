using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecnologico.Web.Core.Model
{
    public class Elemento
    {

        private string numero;

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private string simbolo;

        public string Simbolo
        {
            get { return simbolo; }
            set { simbolo = value; }
        }

        private string categoria;

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string grupo;

        public string Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }

        private string periodo;

        public string Periodo
        {
            get { return periodo; }
            set { periodo = value; }
        }

        private string config;

        public string Config
        {
            get { return config; }
            set { config = value; }
        }

        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private string electro;

        public string Electro
        {
            get { return electro; }
            set { electro = value; }
        }

        private string radio;

        public string Radio
        {
            get { return radio; }
            set { radio = value; }
        }

        private string masa;

        public string Masa
        {
            get { return masa; }
            set { masa = value; }
        }

        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10}", this.Numero, this.Simbolo, this.Categoria, this.Nombre, this.Grupo, this.Periodo, this.Config, this.Estado, this.Electro, this.Radio, this.Masa, this.Color);
        }
        
    }
}
