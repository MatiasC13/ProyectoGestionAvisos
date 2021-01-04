using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Segundo_Obligatorio_POO_2020
{
    class Comun: Aviso
    {
        private string palabrasClave;

        public string PalabrasClave
        {
            get { return palabrasClave; }
            set { palabrasClave = value; }
        }

        public Comun(string telefono, DateTime fecha, Categoria cat, string palabrasClave)
            : base(telefono, fecha, cat)
        {
            PalabrasClave = palabrasClave;
        }

        public override string ToString()
        {
            return "\n- Aviso Común: " + base.ToString() + "\n- Palabras Claves: " + palabrasClave;
        }
    }
}
