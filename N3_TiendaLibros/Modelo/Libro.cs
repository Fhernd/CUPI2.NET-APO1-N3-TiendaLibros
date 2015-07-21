// ===++===
//
//	OrtizOL - xCSw
//
//  Proyecto: Cupi2.NET
//
// ===--===
/*============================================================
//
// Clase(s): `Libro`
//
// Propósito: Implementar y representar la entidad `Libro`
// del dominio.
//
// Original: http://cupi2.uniandes.edu.co/sitio/index.php/cursos/apo1/nivel-3/tienda-de-libros/visualizacion-codigo/libro
//
============================================================*/

using System;

namespace N3_TiendaLibros.Modelo
{
    /// <summary>
    /// Clase que representa la entidad `Libro`.
    /// </summary>
    public class Libro
    {
        #region Campos
        /// <summary>
        /// ISBN del libro.
        /// </summary>
        private String m_isbn;
        /// <summary>
        /// Precio del libro.
        /// </summary>
        private decimal m_precio;
        /// <summary>
        /// Título del libro
        /// </summary>
        private String m_titulo;
        #endregion

        #region Propiedades
        /// <summary>
        /// Recupera y modifica el ISBN del libro.
        /// </summary>
        public String Isbn
        {
            get 
            { 
                return m_isbn; 
            }
            set 
            { 
                m_isbn = value; 
            }
        }
        /// <summary>
        /// Recupera y modifica el precio del libro.
        /// </summary>
        public decimal Precio
        {
            get 
            { 
                return m_precio; 
            }
            set 
            { 
                m_precio = value; 
            }
        }
        /// <summary>
        /// Recupera y modifica el título del libro.
        /// </summary>
        public String Titulo
        {
            get 
            { 
                return m_titulo; 
            }
            set 
            { 
                m_titulo = value; 
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Crea un nuevo libro.
        /// </summary>
        /// <param name="isbn">ISBN del libro.</param>
        /// <param name="titulo">Título del libro.</param>
        /// <param name="precio">Precio del libro.</param>
        public Libro(String isbn, String titulo, decimal precio)
        {
            this.m_isbn = isbn;
            this.m_precio = precio;
            this.m_titulo = titulo;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Determina si este libro es igual a otro libro.
        /// </summary>
        /// <param name="libro">Libro a comparar.</param>
        /// <returns><em>true</em> si los libros son iguales, <em>false</em> en caso contrario.</returns>
        public bool IgualALibro(Libro libro)
        {
            return this.m_isbn.Equals(libro.Isbn);
        }
        #endregion
    }
}
