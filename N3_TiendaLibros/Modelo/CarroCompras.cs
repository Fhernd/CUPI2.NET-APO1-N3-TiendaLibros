// ===++===
//
//	OrtizOL - xCSw
//
//  Proyecto: Cupi2.NET
//
// ===--===
/*============================================================
//
// Clase(s): `CarroCompras`
//
// Propósito: Implementar y representar la entidad 
// `CarroCompras` del dominio.
//
// Original: http://cupi2.uniandes.edu.co/sitio/index.php/cursos/apo1/nivel-3/tienda-de-libros/visualizacion-codigo/carrocompras
//
============================================================*/

using System;
using System.Collections;

namespace N3_TiendaLibros.Modelo
{
    /// <summary>
    /// Representa la entidad `CarroCompras`.
    /// </summary>
    public class CarroCompras
    {
        #region Campos
        /// <summary>
        /// Ïtems de la compra de libros.
        /// </summary>
        private ArrayList m_itemsCompra;
        #endregion

        #region Propiedades
        /// <summary>
        /// Recupera y modifica los ítems de compra.
        /// </summary>
        public ArrayList ItemsCompra
        {
            get 
            { 
                return m_itemsCompra; 
            }
            set 
            { 
                m_itemsCompra = value; 
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Crea un nuevo carrito de compras de libros.
        /// </summary>
        public CarroCompras()
        {
            m_itemsCompra = new ArrayList();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Adiciona un libro como ítem en el carrito de compras.
        /// </summary>
        /// <param name="libro">Libro a agregar al carrito de compras.</param>
        /// <param name="cantidad">Cantidad de este libro a agregar.</param>
        public void AdicionarCompra(Libro libro, int cantidad)
        {
            // Busca un ítem de compra donde exista el libro:
            ItemCompra item = BuscarItemCompraLibro(libro.Isbn);

            // Si no existe ese libro en el carrito, crea el ítem y lo agrega:
            if (item == null)
            {
                ItemCompra nuevoItem = new ItemCompra(libro, cantidad);
                m_itemsCompra.Add(nuevoItem);
            }
            else
            {
                // Si ya existe, sólo aumenta la cantidad del pedido:
                item.CantidadSolicitada += cantidad;
            }
        }
        /// <summary>
        /// Borra un ítem de compra del carrito de compras.
        /// </summary>
        /// <param name="item">Ítem de compra a eliminar.</param>
        public void BorrarItemCompra(ItemCompra item)
        {
            ItemCompra itemAux = null;
            bool encontrado = false;

            // El índice para recorrer los elementos:
            int i = 0;
            int tamanio = m_itemsCompra.Count;

            // Avanza mientras no encuentre el libro en un ítem:
            while (i < tamanio && !encontrado)
            {
                itemAux = (ItemCompra)m_itemsCompra[i];

                if (itemAux.IgualAItem(item))
                {
                    encontrado = true;
                }


                ++i;
            }

            if (encontrado)
            {
                m_itemsCompra.Remove(itemAux);
            }
        }
        /// <summary>
        /// Busca un ítem de compra por el ISBN del libro.
        /// </summary>
        /// <param name="isbn">ISBN del libro a buscar.</param>
        /// <returns>Ítem de compra del libro buscado.</returns>
        public ItemCompra BuscarItemCompraLibro(String isbn)
        {
            foreach (ItemCompra item in m_itemsCompra)
            {
                if (item.Libro.Isbn.Equals(isbn))
                {
                    return item;
                }
            }

            return null;
        }
        /// <summary>
        /// CAlcula el total de la compra para este carrito de compra.
        /// </summary>
        /// <returns>Total de la compra.</returns>
        public decimal CalcularValorTotalCompra()
        {
            decimal total = 0.0M;

            foreach (ItemCompra item in m_itemsCompra)
            {
                total += item.CalcularSubtotalItem();
            }

            return total;
        }
        #endregion
    }
}
