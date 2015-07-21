// ===++===
//
//	OrtizOL - xCSw
//
//  Proyecto: Cupi2.NET
//
// ===--===
/*============================================================
//
// Clase(s): `ControlAdicionarLibro`.
//
// Propósito: Implementar y representar el control 
// personalizado con los botones de adición y puntos de 
// extensión.
//
// Original: http://cupi2.uniandes.edu.co/sitio/index.php/cursos/apo1/nivel-3/tienda-de-libros/visualizacion-codigo/panelbotonesagregar
//
============================================================*/

using System;
using System.Windows.Forms;

namespace N3_TiendaLibros.GUI
{
    /// <summary>
    /// Control de adición de libros al catálogo.
    /// </summary>
    public partial class ControlAdicionarLibro : UserControl
    {
        #region Controles
        /// <summary>
        /// Referencia la ventana principal de la aplicación.
        /// </summary>
        private Principal m_principal;
        #endregion

        #region Constructores:
        /// <summary>
        /// Crea nuevo control para la adición de libros al catálogo.
        /// </summary>
        /// <param name="principal">Referencia a la ventana principal de la aplicación.</param>
        public ControlAdicionarLibro(Principal principal)
        {
            InitializeComponent();

            m_principal = principal;
        }
        #endregion

        #region Eventos:
        /// <summary>
        /// Activa el diálogo de ingreso de datos del libro.
        /// </summary>
        /// <param name="sender">Objeto generador del evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void btnAdicionarLibro_Click(object sender, EventArgs e)
        {
            using (DialogoAdicionarLibro dal = new DialogoAdicionarLibro(m_principal))
            {
                dal.ShowDialog(this);
            }
        }
        /// <summary>
        /// Activa la generación del punto de extensión no. 1.
        /// </summary>
        /// <param name="sender">Objeto generador del evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void btnOpcion1_Click(object sender, EventArgs e)
        {
            m_principal.PuntoExtension1();
        }
        /// <summary>
        /// Activa la generación del punto de extensión no. 2.
        /// </summary>
        /// <param name="sender">Objeto generador del evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void btnOpcion2_Click(object sender, EventArgs e)
        {
            m_principal.PuntoExtension2();
        }
        #endregion
    }
}
