using static Entidades.Enums;
using System.Text;

namespace Entidades
{
    public class Libro
    {
        private string titulo;
        private int cantidadPaginas;
        private DateTime fechaPublicacion;
        private string autor;
        public Genero genero;

        public Libro(string titulo, string autor)
        {
            Random r = new Random();
            this.titulo = titulo;
            cantidadPaginas = r.Next(1, 1000);
            fechaPublicacion = new(r.Next(1950, 2000), r.Next(1, 13), r.Next(1, 31));
            this.autor = autor;
            genero = (Genero)r.Next(0, 5);
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\nTITULO: {titulo}");
            sb.AppendLine($"CANT. PAGINAS {cantidadPaginas}");
            sb.AppendLine($"FECHA DE PUBLICACION: {fechaPublicacion.ToString("dd/MM/yy")}");
            sb.AppendLine($"AUTOR: {autor}");
            sb.AppendLine($"GENERO: {genero}\n");
            return sb.ToString();
        }

        #region Geter
        public string GetTitulo()
        {
            return titulo.ToUpper();
        }
        public int GetCantidadPaginas()
        {
            return cantidadPaginas;
        }
        public string GetFechaPublicacion()
        {
            return fechaPublicacion.ToString("dd/MM/yy");
        }
        public string GetAutor()
        {
            return autor;
        }
        public Genero GetGenero()
        {
            return genero;
        }
        #endregion

        #region Seter
        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }
        public void SetCantidadPaginas(int cantidadPaginas)
        {
            this.cantidadPaginas = cantidadPaginas;
        }
        public void SetFechaPublicacion(DateTime fechaPublicacion)
        {
            this.fechaPublicacion = fechaPublicacion;
        }
        public void SetAutor(string autor)
        {
            this.autor = autor;
        }
        public void SetGenero(Genero genero)
        {
            this.genero = genero;
        }
        #endregion
    }
}
