using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Segundo_Obligatorio_POO_2020
{
    class Destacado: Aviso
    {
        private Articulo artic;

        public Articulo Artic
        {
            get { return artic; }
            set { artic = value; }
        }

        public Destacado(string telefono, DateTime fecha, Categoria cat, Articulo artic)
            : base(telefono, fecha, cat)
        {
            Artic = artic;
        }

        public override string ToString()
        {
            return "\n- Aviso Destacado:" + base.ToString()  + Artic.ToString();
        }
    }
}
