// ===++===
//
//	OrtizOL - xCSw
//
//  Proyecto: Cupi2.NET
//
// ===--===
/*============================================================
//
// Clase(s): `TiendaLibrosTest`
//
// Propósito: Probar el estado y comportamiento de la entidad 
// `TinedaLibros`.
//
// Original: N/D.
//
============================================================*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3_TiendaLibros.Modelo;

namespace N3_TiendaLibrosTest
{
    /// <summary>
    /// Clase de prueba de la clase `TiendaLibros`.
    /// </summary>
    [TestClass]
    public class TiendaLibrosTest
    {
        #region Campos de prueba:
        /// <summary>
        /// Libro de prueba no. 1.
        /// </summary>
        private Libro libro1;
        /// <summary>
        /// Libro de prueba no. 2.
        /// </summary>
        private Libro libro2;
        /// <summary>
        /// Tienda de libros de prueba.
        /// </summary>
        private TiendaLibros tienda;
        #endregion

        #region Escenarios de configuración de pruebas:
        /// <summary>
        /// Configuración de escenario de pruebas no. 1.
        /// </summary>
        private void ConfiguracionEscenario1()
        {
            string titulo, isbn;
            int precio, cantidad;
            CarroCompras carro;

            // Crea el primer libro pra pruebas:
            titulo = "Título 1";
            isbn = "ISBN 1";
            precio = 1000;
            libro1 = new Libro(isbn, titulo, precio);

            // Crea el segundo libro para pruebas:
            titulo = "Título 2";
            isbn = "ISBN 2";
            precio = 200;
            libro2 = new Libro(isbn, titulo, precio);

            // Adiciona los libros al catálogo:
            tienda = new TiendaLibros();
            tienda.AdicionarLibroCatalogo(libro1);
            tienda.AdicionarLibroCatalogo(libro2);

            // Inicializa el carro de compras:
            carro = tienda.Carrito;
            cantidad = 1;
            carro.AdicionarCompra(libro1, cantidad);
        }
        /// <summary>
        /// Configuración de escenario de pruebas no. 2.
        /// </summary>
        private void ConfiguracionEscenario2()
        {
            string titulo, isbn;
            int precio, cantidad;
            CarroCompras carro;

            // Crea el primer libro para pruebas:
            titulo = "Título 3";
            isbn = "ISBN 3";
            precio = 10;
            libro1 = new Libro(isbn, titulo, precio);

            // Crea el segundo libro para pruebas:
            titulo = "Título 4";
            isbn = "ISBN 4";
            precio = 20;
            libro2 = new Libro(isbn, titulo, precio);

            // Adiciona los libros al catálogo:
            tienda = new TiendaLibros();
            tienda.AdicionarLibroCatalogo(libro1);
            tienda.AdicionarLibroCatalogo(libro2);

            // Inicializa el carro de compras:
            carro = tienda.Carrito;
            cantidad = 2;
            carro.AdicionarCompra(libro1, cantidad);
        }
        /// <summary>
        /// Configuración de escenario de pruebas no. 3.
        /// </summary>
        private void ConfiguracionEscenario3()
        {
            string titulo, isbn;
            int precio, cantidad;
            CarroCompras carro;

            // Obtiene los datos de prueba:

            // Crea el primer libro para pruebas:
            titulo = "Título 5";
            isbn = "ISBN 5";
            precio = 100;
            libro1 = new Libro(isbn, titulo, precio);

            // Crea el segundo libro para pruebas:
            titulo = "Título 6";
            isbn = "ISBN 6";
            precio = 200;
            libro2 = new Libro(isbn, titulo, precio);

            // Adiciona los libros al catálogo:
            tienda = new TiendaLibros();
            tienda.AdicionarLibroCatalogo(libro1);
            tienda.AdicionarLibroCatalogo(libro2);

            // Inicializa el carro de compras:
            carro = tienda.Carrito;
            cantidad = 3;
            carro.AdicionarCompra(libro1, cantidad);
        }
        #endregion

        #region Métodos de prueba:
        /// <summary>
        /// Prueba la adición de un libro al catálogo.
        /// </summary>
        [TestMethod]
        public void AdicionarLibroCatalogoTest()
        {
            ConfiguracionEscenario1();

            Libro libroObtenido;
            libroObtenido = tienda.BuscarLibro(libro1.Isbn);

            Assert.IsTrue(libroObtenido.IgualALibro(libro1), "Adición libro");
            Assert.AreEqual(libroObtenido.Isbn, libro1.Isbn, "ISBN adición libro");
            Assert.AreEqual(libroObtenido.Titulo, libro1.Titulo, "Título adición libro");
            Assert.AreEqual(libroObtenido.Precio, libro1.Precio, "Precio adición libro");
        }
        /// <summary>
        /// Prueba el intento de adición de un libro ya existen en el catálogo.
        /// </summary>
        [TestMethod]
        public void AdicionarLibroExisteTest()
        {
            ConfiguracionEscenario2();

            int numeroLibrosAntes, numeroLibrosDespues;

            numeroLibrosAntes = tienda.Catalogo.Count;
            tienda.AdicionarLibroCatalogo(libro1);
            numeroLibrosDespues = tienda.Catalogo.Count;

            Assert.AreEqual(numeroLibrosAntes, numeroLibrosDespues, "Adición libro existe.");
        }
        /// <summary>
        /// Prueba la búsqueda de un libr.
        /// </summary>
        [TestMethod]
        public void BuscarLibroTest()
        {
            ConfiguracionEscenario3();

            CarroCompras carro = tienda.Carrito;
            ItemCompra item = carro.BuscarItemCompraLibro(libro1.Isbn);
            Libro libro = item.Libro;
            
            Assert.AreEqual(libro, tienda.BuscarLibro(libro.Isbn));
        }
        /// <summary>
        /// Prueba la compra de un libro.
        /// </summary>
        [TestMethod]
        public void NuevaCompraTest()
        {
            ConfiguracionEscenario2();

            tienda.CrearNuevaCompra();
            CarroCompras carro = tienda.Carrito;

            Assert.AreEqual(0, carro.ItemsCompra.Count);
        }
        /// <summary>
        /// Prueba la obtención del carrito de compras de la tienda.
        /// </summary>
        [TestMethod]
        public void ObtenerCarroTest()
        {
            ConfiguracionEscenario1();

            CarroCompras carro = tienda.Carrito;
            ItemCompra item = carro.BuscarItemCompraLibro(libro1.Isbn);

            Assert.IsTrue(libro1.IgualALibro(item.Libro));
        }
        #endregion
    }
}
