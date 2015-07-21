// ===++===
//
//	OrtizOL - xCSw
//
//  Proyecto: Cupi2.NET
//
// ===--===
/*============================================================
//
// Clase(s): `ControlCarrito`
//
// Propósito: Implementar y representar el control visual 
// (DataGridView) con los ítems (libros) agregados al 
// carrito de compra.
//
// Original: http://cupi2.uniandes.edu.co/sitio/index.php/cursos/apo1/nivel-3/tienda-de-libros/visualizacion-codigo/tablamodelocarrocompras
//
============================================================*/

using System;
using System.Windows.Forms;
using N3_TiendaLibros.Modelo;

namespace N3_TiendaLibros.GUI
{
    /// <summary>
    /// Clase que representa el control personalizado para el carrito de compras.
    /// </summary>
    public partial class ControlCarrito : UserControl
    {
        #region Constructores
        /// <summary>
        /// Crea un nuevo carrito de compras visual.
        /// </summary>
        public ControlCarrito()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos:
        /// <summary>
        /// Adiciona un nuevo libro al carrito de compras.
        /// </summary>
        /// <param name="libro">Libro a agregar.</param>
        /// <param name="cantidad">Cantidad del libro comprar.</param>
        public void AdicionarLibroCarrito(Libro libro, int cantidad)
        {
            // Comprueba si ya existe el libro en el carrito de compra:
            if (ExisteLibroEnCarrito(libro.Isbn))
            {
                foreach (DataGridViewRow dvrLibro in dgvCarrito.Rows)
                {
                    if (dvrLibro.Cells[0].Value.ToString().Equals(libro.Isbn))
                    {
                        dvrLibro.Cells[2].Value = ((int)dvrLibro.Cells[2].Value) + cantidad;
                        dvrLibro.Cells[3].Value = ((int)dvrLibro.Cells[2].Value) * libro.Precio;
                        break;
                    }
                }
            }
            else
            {
                int index = dgvCarrito.Rows.Add();

                dgvCarrito.Rows[index].Cells[0].Value = libro.Isbn;
                dgvCarrito.Rows[index].Cells[1].Value = libro.Titulo;
                dgvCarrito.Rows[index].Cells[2].Value = cantidad;
                dgvCarrito.Rows[index].Cells[3].Value = (decimal)cantidad * libro.Precio;
            }

            CalcularTotalCompra();
        }

        /// <summary>
        /// Calcula el total de la compra.
        /// </summary>
        private void CalcularTotalCompra()
        {
            decimal totalCompra = 0.0M;

            foreach (DataGridViewRow dgrLibro in dgvCarrito.Rows)
            {
                totalCompra += Decimal.Parse(dgrLibro.Cells[3].Value.ToString());
            }

            txtTotal.Text = String.Format("{0:C}", totalCompra);
        }
        /// <summary>
        /// Comprueba si el libro ya existe en el carrito de compra visual.
        /// </summary>
        /// <param name="isbn">ISBN del libro a comprobar existencia.</param>
        /// <returns><em>true</em> si el libro ya existe, <em>false</em> en caso contrario.</returns>
        private bool ExisteLibroEnCarrito(String isbn)
        {
            foreach(DataGridViewRow libro in dgvCarrito.Rows)
            {
                if (libro.Cells[0].Value.ToString().Equals(isbn))
                {
                    return true;
                }
            }

            return false;
        }
        #endregion

        /// <summary>
        /// EVento que valida la eliminación de un ítem del carrito de compras.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.Rows.Count > 0)
            {
                dgvCarrito.Rows.RemoveAt(dgvCarrito.CurrentRow.Index);

                CalcularTotalCompra();
            }
            else
            {
                MessageBox.Show(this, "Aún no se han agregado libros al carrito.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
