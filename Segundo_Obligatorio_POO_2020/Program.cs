using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*Jorge Matias Cabral Méndez
  C.I: 4.763.553-3
  Grupo: lunes, miércoles y viernes 20:30*/


namespace Segundo_Obligatorio_POO_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aviso> listAviso = new List<Aviso>();
            List<Articulo> listArticulo = new List<Articulo>();
            List<Categoria> listCategoria = new List<Categoria>();

            string opcion = "";
            while (opcion != "0")
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("* * Bienvenido al menú de Avisos Clasificados * *\n");
                    Console.WriteLine("1 - Mantenimiento de Categorías.");
                    Console.WriteLine("2 - Agregar Articulo.");
                    Console.WriteLine("3 - Agregar Aviso Común.");
                    Console.WriteLine("4 - Agregar Aviso Destacado.");
                    Console.WriteLine("5 - Mostrar avisos ordenados por fecha de publicación.");
                    Console.WriteLine("6 - Mostar Avisos por fecha indicada.");
                    Console.WriteLine("7 - Mostrar Aviso por Código Identificador.");
                    Console.WriteLine("0 - Salir.");
                    Console.WriteLine("Seleccione una opción:");
                    opcion = Console.ReadLine();
                    switch (opcion)
                    {
                        case "1":
                            
                                Operaciones.BuscarCategoria(listCategoria, listAviso);
                                break;
                            
                        case "2":
                            
                                Operaciones.AgregarArticulo(listArticulo);
                                break;
                            
                        case "3":
                            
                                Operaciones.AgregarAviso(listCategoria, listAviso);
                                break;
                            
                        case "4":
                            
                                Operaciones.AregarAviso(listCategoria, listAviso, listArticulo);
                                break;
                            
                        case "5":
                            
                                Operaciones.MostrarAvisosOrdenadosFecha(listAviso);
                                break;
                            
                        case "6":
                            
                                Operaciones.MostrarAvisoFecha(listAviso);
                                break;
                            
                        case "7":
                            
                                Operaciones.MostrarAvisoPorIdentificador(listAviso);
                                break;
                            
                        case "0":
                            
                                Console.WriteLine("Ha seleccionado salir.\nEnter para confirmar . . . ");
                                break;
                            
                        default:
                            
                                Console.WriteLine("Opción inválida.");
                                break;
                            
                    }
                    if (opcion != "0")
                    {
                        Console.WriteLine("\nEnter para continuar . . .  ");
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Enter para continuar . . . ");
                }
                Console.ReadLine();
            }
        }
    }
}

