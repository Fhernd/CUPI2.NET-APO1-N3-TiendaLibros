// ===++===
//
//	OrtizOL - xCSw
//
//  Proyecto: Cupi2.NET
//
// ===--===
/*============================================================
//
// Clase(s): `ItemCompra`
//
// Propósito: Implementar y representar la entidad 
// `ItemCompra` del dominio.
//
// Original: http://cupi2.uniandes.edu.co/sitio/index.php/cursos/apo1/nivel-3/tienda-de-libros/visualizacion-codigo/itemcompra
//
============================================================*/

using System;

namespace N3_TiendaLibros.Modelo
{
    /// <summary>
    /// Clase que representa la entidad `ItemCompra`.
    /// </summary>
    public class ItemCompra
    {
        #region Campos
        /// <summary>
        /// Libro asociado a este ítem de compra.
        /// </summary>
        private Libro m_libro;
        /// <summary>
        /// Cantidad del libro comprada.
        /// </summary>
        private int m_cantidad;
        #endregion

        #region Campos
        /// <summary>
        /// Recupera y modifica el libro asociado a este ítem de compra.
        /// </summary>
        public Libro Libro
        {
            get 
            { 
                return m_libro; 
            }
            set 
            { 
                m_libro = value; 
            }
        }
        /// <summary>
        /// Recupera y modifica la cantidad solicitada de este ítem de compra.
        /// </summary>
        public int CantidadSolicitada
        {
            get 
            { 
                return m_cantidad; 
            }
            set 
            { 
                m_cantidad = value; 
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Crea ítem de compra con un libro y su cantidad a comprar.
        /// </summary>
        /// <param name="libro">Libro a asociar a este ítem de compra.</param>
        /// <param name="cantidad">Cantidad a comprar de este libro.</param>
        public ItemCompra(Libro libro, int cantidad)
        {
            this.m_libro = libro;
            this.m_cantidad = cantidad;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Calcula el subtotal de este ítem de compra.
        /// </summary>
        /// <returns>Subtotal de la compra.</returns>
        public decimal CalcularSubtotalItem()
        {
            return Libro.Precio * Decimal.Parse(m_cantidad.ToString());
        }
        /// <summary>
        /// Determina si este ítem de compra es igual a otro ítem de compra.
        /// </summary>
        /// <param name="item">Otro ítem de compra a comparar.</param>
        /// <returns><em>true</em> si los dos ítems son iguales, <em>false</em> en caso contrario.</returns>
        public bool IgualAItem(ItemCompra item)
        {
            return m_libro.IgualALibro(item.Libro);
        }
        #endregion
    }
}
