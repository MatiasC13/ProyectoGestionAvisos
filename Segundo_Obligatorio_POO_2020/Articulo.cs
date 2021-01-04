using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Segundo_Obligatorio_POO_2020
{
    class Articulo
    {
        private string codigo;
        private double precio;
        private string descripcion;

        #region Propiedades
        public string Codigo
        {
            get { return codigo; }
            set
            {
                if (value.Trim().Length == 6)
                    codigo = value;
                else
                    throw new Exception("El código del artículo debe de tener 6 caracteres.");
            }
        }

        public double Precio
        {
            get { return precio; }
            set
            {
                if (value > 0)
                    precio = value;
                else
                    throw new Exception("El precio del artículo debe ser mayor a cero.");
            }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        #endregion

        public Articulo(string codigo, double precio, string descripcion)
        {
            Codigo = codigo;
            Precio = precio;
            Descripcion = descripcion;
        }

        public override string ToString()
        {
            return "\n- Descripción del artículo: " + Descripcion + "\n- Precio: " + Precio + "\n- Código: " + Codigo;
        }
    }
}
