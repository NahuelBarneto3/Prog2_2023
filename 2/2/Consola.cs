using Entidades;
using System.Text;

namespace _2
{
    internal class Consola
    {
        static void Main(string[] args)
        {
            #region Basura

            //Console.WriteLine(l1.Mostrar());
            //Console.WriteLine(l2.Mostrar());

            //    int[] numeros = new int[10];
            //    string[] palabras = { "p1", "p2" };

            //    string[] diasDeLaSemana = new string[7];
            //    diasDeLaSemana[0] = "Lunes";
            //    diasDeLaSemana[1] = "Martes";
            //    diasDeLaSemana[2] = "Miercoles";

            //    for (int i = 0; i < numeros.Length; i++)
            //    {
            //        numeros[i] = i+1;
            //        Console.WriteLine(numeros[i]);
            //    }

            //    for (int i = 0; i < diasDeLaSemana.Length; i++)
            //    {
            //        Console.WriteLine(diasDeLaSemana[i]);
            //        if (diasDeLaSemana[i] == "Martes")
            //        {
            //            break;
            //        }
            //    }
            //    Console.WriteLine("---------");
            //    foreach (string dia in diasDeLaSemana)
            //    {
            //        Console.WriteLine(dia);
            //        if (dia == "Martes")
            //        {
            //            break;
            //        }
            //    }

            //    Console.WriteLine(numeros.Length);
            //    Console.WriteLine(palabras.Length);
            //    Console.WriteLine(diasDeLaSemana.Length); 


            //int[] numeros = new int[10];
            //Libro[] libros = new Libro[10];

            //for (int i = 0; i < libros.Length; i++)
            //{
            //    libros[i] = new($"Libro{i}", $"Autor{i}", Genero.Fantasia);
            //    Console.WriteLine(libros[i].Mostrar());
            //}
            //Console.WriteLine("------- LIBROS DE HORROR");
            //for (int i = 0; i < libros.Length; i++)
            //{
            //    if (libros[i].GetGenero() == Genero.Horror)
            //    {
            //        Console.WriteLine(libros[i].Mostrar());
            //        break;
            //    }
            //}
            #endregion
          
            //string nombre = "Juan";
            //Console.WriteLine(nombre[0]);

            Estante MiEstante = new Estante(3);

            //Libro l1 = new Libro("Mistborn: El imperio Final", "Brandon Sanderson");
            do
            {
                MostrarMenu();
                Console.WriteLine($"Estanteria con espacio para {MiEstante.GetCantidadLibros()} Libro/s");
                Console.WriteLine("Ingrese opcion");
                string opcionMenu = Console.ReadLine().ToUpper();
                
                switch (opcionMenu)
                {
                    case "A":
                        //SALIR
                        Console.WriteLine("\n Gracias por usar la libreria \n");
                        break;
                    case "B":
                        if(MiEstante.GetCantidadLibros() > 0)
                        {
                            Console.WriteLine("Ingrese nombre de libro");
                            string nombreLibro = Console.ReadLine().ToUpper();
                            Console.WriteLine("Ingrese nombre Autor");
                            string nombreAutor = Console.ReadLine().ToUpper();
                            Libro libro = new Libro(nombreLibro, nombreAutor);
                            MiEstante.AgregarLibroAlEstante(libro);
                        }else
                        {
                            Console.WriteLine("\n Limite de estanteria alcanzado\n");
                        }
                        break;
                    case "C":
                        if (MiEstante.GetCantidadLibros() < 4)
                        {
                            
                            Console.WriteLine("Ingrese Id (Numero) de libro a dar de baja");
                            int idLibro;
                            bool intParseTry = int.TryParse(Console.ReadLine(),out idLibro);
                            Console.WriteLine(intParseTry);
                            
                            Console.WriteLine(MiEstante.SacarLibroDelEstante(idLibro));

                            if (MiEstante.SacarLibroDelEstante(idLibro) != -1 && intParseTry == true)
                            {
                                MiEstante.SacarLibroDelEstante(idLibro);
                                Console.WriteLine($"Id {idLibro} dado de baja correctamente");
                            }if (MiEstante.GetCantidadLibros() > 3 && intParseTry == true)
                            {
                                Console.WriteLine("\nEspacio maximo de la estanteria alcanzado o ID incorrecto\n");
                            } else
                            {
                                Console.WriteLine("Tiene que ser un numero");
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n Limite de estanteria alcanzado\n");
                        }
                        break;
                    case "D":
                        //MODIFICAR
                        Console.WriteLine("C");

                        break;
                    default:
                        Console.WriteLine("Opcion no valida.\n");
                        break;
                }
            } while (true);
        }

        static void MostrarMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("|    Opciones     |");
            sb.AppendLine("|  A- SALIR       |");
            sb.AppendLine("|  B- ALTA LIBRO  |");
            sb.AppendLine("|  C- BAJA        |");
            sb.AppendLine("|  D- MODIFICAR   |");

            Console.WriteLine(sb);
            
        }
    }
    
}