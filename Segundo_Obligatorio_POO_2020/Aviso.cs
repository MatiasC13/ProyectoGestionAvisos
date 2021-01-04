using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Segundo_Obligatorio_POO_2020
{
    abstract class Aviso
    {
        private int codigoidentificador;
        private string telefono;
        private DateTime fecha;
        private Categoria cat;
        private static int contador;

        #region Propiedades
        public int Codigoidentificador
        {
            get { return codigoidentificador; }
        }

        public string Telefono
        {
            get { return telefono; }
            set 
            { 
             int a;
             if (Int32.TryParse(value, out a))
             {
                 telefono = value;
             }
             else
             {
                 throw new Exception("El teléfono solo admite formato numérico.");
             }
            }
        }


        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public Categoria Cat
        {
            get { return cat; }
            set { cat = value; }
        }
        #endregion

        public Aviso(string telefono, DateTime fecha, Categoria cat)
        {
            Telefono = telefono;
            Fecha = fecha;
            Cat = cat;
            contador++;
            codigoidentificador = contador;
        }

        public override string ToString()
        {
            return "\n- Código interno: " + Codigoidentificador + "\n- Categoría: " + Cat.Nombre.ToUpper() + "\n- Fecha: " + Fecha.ToShortDateString() + "\n- Telefono: " + Telefono;
        }
    }
}
