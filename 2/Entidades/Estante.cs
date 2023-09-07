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
        public Libro[] libros;

        public int GetCantidadLibros() 
        {
            return cantidadMaximaLibros;
        }

        public Estante(int cantidadMaximaLibros)
        {
            this.cantidadMaximaLibros = cantidadMaximaLibros;
            libros = new Libro[cantidadMaximaLibros];
        }

        public void AgregarLibroAlEstante(Libro libro)
        {
            if (this.cantidadMaximaLibros != 0)
            {
                this.libros.Append(libro);
                this.cantidadMaximaLibros--;
                Console.WriteLine($"Libro {libro.GetTitulo()} agregado correctamente\n");
                comi
            }
            else
            {
                Console.WriteLine("No hay mas espacio en el estante :(\n");
            }
        }


        
    }
}
