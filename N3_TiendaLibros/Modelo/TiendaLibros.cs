// ===++===
//
//	OrtizOL - xCSw
//
//  Proyecto: Cupi2.NET
//
// ===--===
/*============================================================
//
// Clase(s): `TiendaLibros`.
//
// Propósito: Implementar y representar la entidad 
// `TiendaLibros` del dominio.
//
// Original: http://cupi2.uniandes.edu.co/sitio/index.php/cursos/apo1/nivel-3/tienda-de-libros/visualizacion-codigo/tiendalibros
//
============================================================*/

using System;
using System.Collections;

namespace N3_TiendaLibros.Modelo
{
    /// <summary>
    /// Clase que representa la entidad `TiendaLibros`.
    /// </summary>
    public class TiendaLibros
    {
        #region Campos
        /// <summary>
        /// Catálogo de libros.
        /// </summary>
        private ArrayList m_catalogo;
        /// <summary>
        /// Carrito de compras.
        /// </summary>
        private CarroCompras m_carrito;
        #endregion

        #region Propiedades
        /// <summary>
        /// Recupera y modifica el carrito de compras de esta tienda de libros.
        /// </summary>
        public CarroCompras Carrito
        {
            get 
            { 
                return m_carrito; 
            }
            set 
            { 
                m_carrito = value; 
            }
        }
        /// <summary>
        /// Recupera y modifica el catálogo de venta de esta tienda de libros.
        /// </summary>
        public ArrayList Catalogo
        {
            get 
            { 
                return m_catalogo; 
            }
            set 
            { 
                m_catalogo = value; 
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Crea una nueva tienda de libros.
        /// </summary>
        public TiendaLibros()
        {
            m_catalogo = new ArrayList();
            m_carrito = new CarroCompras();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Adiciona un nuevo libro al catálogo de venta de la tienda.
        /// </summary>
        /// <param name="libro">Libro a adicionar al catálogo de venta.</param>
        public void AdicionarLibroCatalogo(Libro libro)
        {
            // Verifica si el libro existe:
            Libro resultado = BuscarLibro(libro.Isbn);
            
            // Sólo añade el libro si no existe:
            if (resultado == null)
            {
                m_catalogo.Add(libro);
            }
        }
        /// <summary>
        /// Busca un libro en el catálogo.
        /// </summary>
        /// <param name="isbn">ISBN del libro a buscar en el catálogo.</param>
        /// <returns>Referencia del libro encontrado. (Puede ser `null`.)</returns>
        public Libro BuscarLibro(String isbn)
        {
            int indice = 0;
            int totalLibros = m_catalogo.Count;
            Libro libro = null;
            bool encontrado = false;

            while (indice < totalLibros && !encontrado)
            {
                libro = (Libro)m_catalogo[indice];

                if (libro != null && libro.Isbn.Equals(isbn))
                {
                    encontrado = true;
                }

                ++indice;
            }

            if (encontrado)
            {
                return libro;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Crea un nuevo carrito de compra.
        /// </summary>
        public void CrearNuevaCompra()
        {
            m_carrito = new CarroCompras();
        }
        #endregion

        #region Métodos de extensión
        /// <summary>
        /// Método de extensión número 1.
        /// </summary>
        /// <returns>Cadena de caracteres de respuesta.</returns>
        public String MetodoExtension1()
        {
            return "Respuesta 1";
        }
        /// <summary>
        /// Método de extensión número 2.
        /// </summary>
        /// <returns>Cadena de caracteres de respuesta.</returns>
        public String MetodoExtension2()
        {
            return "Respuesta 2";
        }
        #endregion
    }
}
