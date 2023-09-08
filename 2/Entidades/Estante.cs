using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        private int cantidadMaximaLibros;
        private int idLibro;
        public Libro[] libros;
        public Estante(int cantidadMaximaLibros)
        {
            this.cantidadMaximaLibros = cantidadMaximaLibros;
            libros = new Libro[cantidadMaximaLibros];
            this.idLibro = cantidadMaximaLibros+1;
        }
        public int GetCantidadLibros() 
        {
            return cantidadMaximaLibros;
        }

       

        public void AgregarLibroAlEstante(Libro libro)
        {
            this.libros.Append(libro);
            this.cantidadMaximaLibros--;
            this.idLibro--;
            Console.WriteLine($"\nLibro {libro.GetTitulo()} del autor {libro.GetAutor()} agregado correctamente\n " +
                $"Y lo retiras con tu ID que es {idLibro}\n");
        }

        public int SacarLibroDelEstante(int id)
        {
            
            int indiceABorrar = Array.IndexOf(this.libros, id);
            if(indiceABorrar == -1)
            {
                return indiceABorrar;

            }
            else
            {
                libros = libros.Where((e, i) => i > indiceABorrar).ToArray();
                this.cantidadMaximaLibros++;
                this.idLibro++;
                Console.WriteLine($"\nLibro {libros[indiceABorrar].GetTitulo()} del autor {libros[indiceABorrar].GetAutor()} dado de baja Correctamente\n" +
                    $"Muchas gracias por usar la Biblioteca!");
                return indiceABorrar; 
            }
            
            
            
        }

        
    }
}
