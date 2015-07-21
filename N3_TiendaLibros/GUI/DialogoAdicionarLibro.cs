// ===++===
//
//	OrtizOL - xCSw
//
//  Proyecto: Cupi2.NET
//
// ===--===
/*============================================================
//
// Clase(s): `DialogoAdicionarLibro`
//
// Propósito: Implementar y representar el diálogo de 
// ingreso de datos del libro.
//
// Original: http://cupi2.uniandes.edu.co/sitio/index.php/cursos/apo1/nivel-3/tienda-de-libros/visualizacion-codigo/dialogoagregarlibro
//
============================================================*/

using System;
using System.Windows.Forms;

namespace N3_TiendaLibros.GUI
{
    /// <summary>
    /// Clase que representa el diálogo de adición de un libro.
    /// </summary>
    public partial class DialogoAdicionarLibro : Form
    {
        #region Controles
        /// <summary>
        /// Referencia la ventana principal de la aplicación.
        /// </summary>
        private Principal m_principal;
        #endregion

        #region Constructores:
        /// <summary>
        /// Crea un nuevo diálogo de adición de libros.
        /// </summary>
        /// <param name="principal">Referencia a la ventana principal de la aplicación.</param>
        public DialogoAdicionarLibro(Principal principal)
        {
            InitializeComponent();

            m_principal = principal;
            this.ActiveControl = txtTitulo;
            txtTitulo.Focus();
        }
        #endregion

        #region Eventos:
        /// <summary>
        /// Evento que valida la adición del libro.
        /// </summary>
        /// <param name="sender">Objeto generador del evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!(txtIsbn.Text.Length == 0) && !(txtTitulo.Text.Length == 0) && !(txtPrecio.Text.Length == 0))
            {
                if (!(m_principal.ExisteLibro(txtIsbn.Text)))
                {
                    decimal precio;
                    if (Decimal.TryParse(txtPrecio.Text, out precio))
                    {
                        if (!(precio == 0.0M))
                        {
                            m_principal.AdicionarLibro(txtIsbn.Text, txtTitulo.Text, precio);
                            this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show(this, "El precio debe ser mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "El campo Precio no contiene un valor válido. (Sólo se admiten valores decimales.)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(this, String.Format("Ya existe un libro con el ISBN {0}.", txtIsbn.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show(this, "Debe llenar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Evento de cancelación del diálogo de adición de libro.
        /// </summary>
        /// <param name="sender">Objeto generador del evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        #endregion
    }
}
