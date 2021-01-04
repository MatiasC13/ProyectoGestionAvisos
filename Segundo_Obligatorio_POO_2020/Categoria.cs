using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Segundo_Obligatorio_POO_2020
{
    class Categoria
    {
        private string codigoCategoria;
        private string nombre;
        private double precio;
        #region Propiedades
        public string CodigoCategoria
        {
            get { return codigoCategoria; }
            set
            {
                if (value.Trim().Length == 3)
                    codigoCategoria = value;
                else
                    throw new Exception("El código de la categoría debe de tener 3 caracteres.");

            }
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value.Trim().Length > 0)
                    nombre = value;
                else
                    throw new Exception("El nombre de la categoría debe tener al menos un caracter.");

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
                    throw new Exception("El precio de la categoría debe ser superior a cero.");
            }
        }
        #endregion

        public Categoria(string codigoCategoria, string nombre, double precio)
        {
            CodigoCategoria = codigoCategoria;
            Nombre = nombre;
            Precio = precio;
        }

        public override string ToString()
        {
            return "\n- Nombre: " + Nombre.ToUpper() + "\n- Precio Base: " + Precio + "\n- Código de categoría: " + CodigoCategoria;
        }
    }
}
