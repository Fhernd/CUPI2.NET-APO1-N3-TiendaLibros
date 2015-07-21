// ===++===
//
//	OrtizOL - xCSw
//
//  Proyecto: Cupi2.NET
//
// ===--===
/*============================================================
//
// Clase(s): `ControlCatalogo`
//
// Propósito: Implementar y representar el control visual 
// personalizado para el catálogo de libros a la venta.
//
// Original: http://cupi2.uniandes.edu.co/sitio/index.php/cursos/apo1/nivel-3/tienda-de-libros/visualizacion-codigo/tablamodelocatalogo
//
============================================================*/

using System;
using System.Windows.Forms;
using N3_TiendaLibros.Modelo;

namespace N3_TiendaLibros.GUI
{
    /// <summary>
    /// Clase que representa el control visual del catálogo de libros.
    /// </summary>
    public partial class ControlCatalogo : UserControl
    {
        #region Controles
        /// <summary>
        /// Referencia la ventana principal de la aplicación.
        /// </summary>
        private Principal m_principal;
        #endregion

        #region Constructores
        /// <summary>
        /// Crea un nuevo control para la adición de libros al catálogo de venta.
        /// </summary>
        /// <param name="principal">Referencia a la ventana principal de la aplicación.</param>
        public ControlCatalogo(Principal principal)
        {
            InitializeComponent();
            
            m_principal = principal;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Agrega un nuevo libro al catálogo.
        /// </summary>
        /// <param name="libro">Libro a agregar.</param>
        public void AgregarLibroCatalogo(Libro libro)
        {
            if (dgvCatalogo.Rows.Count == 0)
            {
                txtCantidad.Enabled = true;
                btnComprar.Enabled = true;
            }

            int index = dgvCatalogo.Rows.Add();

            dgvCatalogo.Rows[index].Cells["tbcIsbn"].Value = libro.Isbn;
            dgvCatalogo.Rows[index].Cells["tbcTitulo"].Value = libro.Titulo;
            dgvCatalogo.Rows[index].Cells["tbcPrecio"].Value = libro.Precio;
        }
        #endregion

        #region Eventos:
        /// <summary>
        /// Evento que inicia el proceso de compra de un libro.
        /// </summary>
        /// <param name="sender">Objeto generador del evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text.Length > 0)
            {
                Int16 cantidad;

                if (Int16.TryParse(txtCantidad.Text, out cantidad))
                {
                    DataGridViewRow dgr = dgvCatalogo.SelectedRows[0];

                    m_principal.AdicionarCompra(dgr.Cells["tbcIsbn"].Value.ToString(), cantidad);
                }
                else
                {
                    MessageBox.Show(this, "El campo Precio no contiene un valor válido. (Sólo se admiten valores enteros.)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(this, "El campo no debe estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
