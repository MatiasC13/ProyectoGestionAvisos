using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Segundo_Obligatorio_POO_2020
{
    class Operaciones
    {
        public static void AgregarCategoria(List<Categoria> listaCat, string codigoCat)
        {
            Console.WriteLine("Ingrese el nombre de la nueva categoría:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el precio de la categoría:");
            double precio = Convert.ToDouble(Console.ReadLine());
            Categoria cat = new Categoria(codigoCat, nombre, precio);
            Console.WriteLine("\nSe agregó la categoría: " + cat.ToString());
            listaCat.Add(cat);

        }

        public static void EliminarCategoria(List<Categoria> listaCat, List<Aviso> listAviso, Categoria cat)
        {
            foreach (Aviso item in listAviso)
            {
                if (item.Cat == cat)
                    throw new Exception("No se puede eliminar una categoría asociada a un aviso.");
            }
             
                    listaCat.Remove(cat);
                    Console.WriteLine("La categoría " + cat.Nombre + " ha sido eliminada.");
                
        }

        public static void EditarCategoria(Categoria cat)
        {
            Console.WriteLine("Indique el nuevo nombre para la categoría con el código " + cat.CodigoCategoria + ":");
            cat.Nombre = Console.ReadLine();
            Console.WriteLine("Indique el nuevo precio base para la categoría con el código " + cat.CodigoCategoria + ":");
            cat.Precio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("La nueva categoría es: " + cat.ToString());
        }

        public static void BuscarCategoria(List<Categoria> listaCat, List<Aviso> listAviso)
        {
            Console.WriteLine("Ingrese el código (3 caracteres) de la categoría que está buscando: ");
            string codigo = Console.ReadLine();
            Categoria cat = null;
            foreach (Categoria item in listaCat)
            {
                if (item.CodigoCategoria == codigo)
                    cat = item;

            }

            if (cat == null)
            {
                Console.WriteLine("No existe una categoría asociada al código " + codigo + "\nEnter para crear categoría.");
                Console.ReadLine();
                AgregarCategoria(listaCat, codigo);
            }
            else
            {
                Console.WriteLine("La categoría existe: \n 1- Para editar \n 2- Para eliminar \n 3- Para salir");
                string opcion = Console.ReadLine();
                if (opcion == "1")
                {
                    EditarCategoria(cat);
                }
                else if (opcion == "2")
                {
                   
                    EliminarCategoria(listaCat, listAviso, cat);
                }
                else if (opcion == "3")
                {
                    Console.WriteLine("Ha salido sin ningún cambio.");
                }
                else
                {
                    Console.WriteLine("Opción inválida.");
                }
            }
            
        }

        public static void AgregarArticulo(List<Articulo> lista)
        {
            Console.WriteLine("Ingrese un código de 6 caracteres para el artículo que desea agregar:");
            string codigo = Console.ReadLine();
            foreach (Articulo item in lista)
            {
                if (item.Codigo == codigo)
                    throw new Exception("Ya existe un artículo con el código " + codigo);
            }
            Console.WriteLine("Ingrese el precio del artículo: ");
            double precio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese una breve descripción del artículo: ");
            string descripcion = Console.ReadLine();
            Articulo articulo = new Articulo(codigo, precio, descripcion);
            lista.Add(articulo);

            Console.WriteLine("\nSe agregó el artículo: " + articulo.ToString());
        }

        public static void AgregarAviso(List<Categoria> listaCat, List<Aviso> listAviso)
        {
            Console.WriteLine("Ingrese el código de la categoría del aviso: ");
            string codigo = Console.ReadLine();
            Categoria cat = null;
            foreach (Categoria item in listaCat)
            {
                if (item.CodigoCategoria == codigo)
                    cat = item;

            }

            if (cat == null)
            {
                throw new Exception("No existe una categoría asociada al código " + codigo);
            }
            else
            {
                Console.WriteLine("Ingrese las palabras claves del aviso: ");
                string palabraclave = Console.ReadLine();
                Console.WriteLine("Ingrese la fecha del aviso en formato (dd/mm/aaaa): ");
                DateTime fecha = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Ingrese el teléfono del aviso: ");
                string telefono = Console.ReadLine();
                Comun avisocomun = new Comun(telefono, fecha, cat, palabraclave);
                listAviso.Add(avisocomun);
                Console.WriteLine("\nSe agregó a la lista el aviso: " + avisocomun.ToString());
            }
        }

        public static void AregarAviso(List<Categoria> listaCat, List<Aviso> listAviso, List<Articulo> listArt)
        {
            Console.WriteLine("Ingrese el código de la categoría del aviso: ");
            string codigo = Console.ReadLine();
            Categoria cat = null;
            foreach (Categoria item in listaCat)
            {
                if (item.CodigoCategoria == codigo)
                    cat = item;

            }

            if (cat == null)
            {
                throw new Exception("No existe una categoría asociada al código " + codigo);
            }


            Console.WriteLine("Ingrese el código del artículo: ");
            string codigoArt = Console.ReadLine();
            Articulo art = null;
            foreach (Articulo item in listArt)
            {
                if (item.Codigo == codigoArt)
                    art = item;

            }

            if (art == null)
            {
                throw new Exception("No existe un artículo asociado al código " + codigoArt);
            }
            else
            {
                Console.WriteLine("Ingrese la fecha del aviso en formato (dd/mm/aaaa): ");
                DateTime fecha = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Ingrese el teléfono del aviso: ");
                string telefono = Console.ReadLine();
                Destacado avisoDestacado = new Destacado(telefono, fecha, cat, art);
                listAviso.Add(avisoDestacado);
                Console.WriteLine("\nSe agregó el aviso:" + avisoDestacado.ToString());

            }
        }

        public static void MostrarAvisoFecha(List<Aviso> listAviso)
        {
            Console.WriteLine("Ingrese la fecha en la que desea consultar avisos(dd/mm/aaaa):");
            DateTime fecha = Convert.ToDateTime(Console.ReadLine());
            List<Aviso> lista = new List<Aviso>();
            foreach (Aviso item in listAviso)
            {
                if (item.Fecha == fecha)
                    lista.Add(item);
            }
            if (lista.Count == 0)
            {
                Console.WriteLine("No se encontró el aviso en la fecha " + fecha.ToString("dd/MM/yyyy"));
            }
            else
            {
                foreach (Aviso item in lista)
                {
                    Console.WriteLine("Aviso(s) en la fecha " + fecha.ToString("dd/MM/yyyy") + ": " + item.ToString());
                }
            }
        }

        public static void MostrarAvisoPorIdentificador(List<Aviso> listAviso)
        {
            Console.WriteLine("Ingrese el código identificador del aviso que desea mostrar:");
            int codigo = Convert.ToInt32(Console.ReadLine());
            Aviso a = null;
            foreach (Aviso item in listAviso)
            {
                if (item.Codigoidentificador == codigo)
                    a = item;
            }
            if (a == null)
            {
                Console.WriteLine("No se encontró ningún aviso asociado al código " + codigo);
            }
            else
            {
                Console.WriteLine("Existe un aviso asociado al código ingresado: " + a.ToString());
            }
        }

        public static void MostrarAvisosOrdenadosFecha(List<Aviso> listAviso)
        {

            if (listAviso.Count > 0)
            {
                Aviso swap = null;
                for (int i = 0; i < listAviso.Count; i++)
                {
                    for (int j = i + 1; j < listAviso.Count; j++)
                    {
                        if (listAviso[i].Fecha > listAviso[j].Fecha)
                        {
                            swap = listAviso[j];
                            listAviso[j] = listAviso[i];
                            listAviso[i] = swap;
                        }
                    }
                }


                foreach (Aviso item in listAviso)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("No se ha encontrado ningún aviso.");
            }
        }
    }
}
