// ===++===
//
//	OrtizOL - xCSw
//
//  Proyecto: Cupi2.NET
//
// ===--===
/*============================================================
//
// Clase(s): `Principal`
//
// Propósito: Implementar y representar el formulario 
// principal de la aplicación.
//
// Original: http://cupi2.uniandes.edu.co/sitio/index.php/cursos/apo1/nivel-3/tienda-de-libros/visualizacion-codigo/interfaztiendalibros
//
============================================================*/

using System.Drawing;
using System.Windows.Forms;
using N3_TiendaLibros.Modelo;

namespace N3_TiendaLibros.GUI
{
    /// <summary>
    /// Clase que presenta la ventana (formulario) principal de la aplicación.
    /// </summary>
    public partial class Principal : Form
    {
        #region Controles
        /// <summary>
        /// Control de adición de libro.
        /// </summary>
        private ControlAdicionarLibro ctlAdicionarLibro;
        /// <summary>
        /// Control visual del carrito de compras.
        /// </summary>
        private ControlCarrito ctlCarrito;
        /// <summary>
        /// Control del catálogo de libros a la venta.
        /// </summary>
        private ControlCatalogo ctlCatalogo;
        #endregion

        #region Campos
        /// <summary>
        /// Carrito de compra.
        /// </summary>
        private CarroCompras carrito;
        /// <summary>
        /// Tienda de libros.
        /// </summary>
        private TiendaLibros tienda;
        #endregion

        #region Constructores:
        /// <summary>
        /// Crea la ventana principal de la aplicación.
        /// </summary>
        public Principal()
        {
            InitializeComponent();

            // Creación de entidades:
            tienda = new TiendaLibros();
            carrito = tienda.Carrito;

            // Creación de controles:

            ctlAdicionarLibro = new ControlAdicionarLibro(this);
            ctlAdicionarLibro.Location = new Point(0, 0);
            this.Controls.Add(ctlAdicionarLibro);

            ctlCatalogo = new ControlCatalogo(this);
            ctlCatalogo.Location = new Point(3, 35);
            this.Controls.Add(ctlCatalogo);

            ctlCarrito = new ControlCarrito();
            ctlCarrito.Location = new Point(3, 250);
            this.Controls.Add(ctlCarrito);
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Adiciona un nuevo libro al carrito de compras.
        /// </summary>
        /// <param name="isbn">ISBN del libro a adicionar.</param>
        /// <param name="cantidad">Cantidad del libro a comprar.</param>
        public void AdicionarCompra(string isbn, int cantidad)
        {
            Libro libro = tienda.BuscarLibro(isbn);
            carrito.AdicionarCompra(libro, cantidad);

            ctlCarrito.AdicionarLibroCarrito(libro, cantidad);
        }
        /// <summary>
        /// Adicionar un nuevo libro al catálogo.
        /// </summary>
        /// <param name="isbn">ISBN del libro.</param>
        /// <param name="titulo">Título del libro.</param>
        /// <param name="precio">Precio del libro.</param>
        public void AdicionarLibro(string isbn, string titulo, decimal precio)
        {
            Libro nuevoLibro = new Libro(isbn, titulo, precio);
            tienda.AdicionarLibroCatalogo(nuevoLibro);
            ctlCatalogo.AgregarLibroCatalogo(nuevoLibro);
        }
        /// <summary>
        /// Determina si el libro ya existe en la tienda.
        /// </summary>
        /// <param name="isbn">ISBN del libro.</param>
        /// <returns><em>true</em> si el libro ya existe, <em>false</em> en caso contrario.</returns>
        public bool ExisteLibro(string isbn)
        {
            Libro libroEncontrado = tienda.BuscarLibro(isbn);

            return libroEncontrado != null ? true : false;
        }
        #endregion

        #region Puntos de extensión.
        public void PuntoExtension1()
        {
            MessageBox.Show(this, tienda.MetodoExtension1(), "Opción 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void PuntoExtension2()
        {
            MessageBox.Show(this, tienda.MetodoExtension2(), "Opción 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
