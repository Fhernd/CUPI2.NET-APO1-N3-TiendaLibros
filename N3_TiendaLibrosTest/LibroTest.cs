// ===++===
//
//	OrtizOL - xCSw
//
//  Proyecto: Cupi2.NET
//
// ===--===
/*============================================================
//
// Clase(s): `LibroTest`.
//
// Propósito: Probar el estado y comportamiento de la entidad 
// `Libro`.
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
    /// Clase de prueba de la clase `Libro`.
    /// </summary>
    [TestClass]
    public class LibroTest
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
        #endregion

        #region Escanarios de configuración de pruebas:
        /// <summary>
        /// Configuración de escenario de pruebas no. 3.
        /// </summary>
        private void ConfiguracionEscenario1()
        {
            String titulo, isbn;
            int precio;

            // Crea el primer libro para pruebas:
            titulo = "Título 1";
            isbn = "ISBN 1";
            precio = 1000;
            libro1 = new Libro(isbn, titulo, precio);

            // Crea el segundo libro para pruebas:
            titulo = "Título 2";
            isbn = "ISBN  2";
            precio = 2000;
            libro2 = new Libro(isbn, titulo, precio);
        }
        /// <summary>
        /// Configuración de escenario de pruebas no. 2.
        /// </summary>
        private void ConfiguracionEscenario2()
        {
            string titulo, isbn;
            int precio;

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
        }

        /// <summary>
        /// Configuración de escenario de pruebas no. 3.
        /// </summary>
        private void ConfiguracionEscenario3()
        {
            string titulo, isbn;
            int precio;

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
        }
        #endregion

        #region Métodos de prueba:
        /// <summary>
        /// Prueba de creación de objetos `Libro`.
        /// </summary>
        [TestMethod]
        public void CrearLibroTest()
        {
            ConfiguracionEscenario1();
            string titulo, isbn;
            int precio;

            titulo = "Título 1";
            isbn = "ISBN 1";
            precio = 1000;

            Assert.AreEqual(titulo, libro1.Titulo);
            Assert.AreEqual(isbn, libro1.Isbn);
            Assert.AreEqual(precio, libro1.Precio);
        }
        /// <summary>
        /// Prueba de la comparación de ISBNs.
        /// </summary>
        [TestMethod]
        public void ObtenerIsbnTest()
        {
            ConfiguracionEscenario3();

            string isbn = "ISBN 5";

            Assert.AreEqual(libro1.Isbn, isbn);
        }
        /// <summary>
        /// Prueba de la obtención del precio de un libro.
        /// </summary>
        [TestMethod]
        public void ObtenerPrecioTest()
        {
            ConfiguracionEscenario1();

            int precio = 1000;

            Assert.AreEqual(libro1.Precio, precio);
        }
        /// <summary>
        /// Prueba de la obtención del título del libro.
        /// </summary>
        [TestMethod]
        public void ObtenerTituloTest()
        {
            ConfiguracionEscenario2();

            string titulo = "Título 3";

            Assert.AreEqual(libro1.Titulo, titulo);
        }
        /// <summary>
        /// Prueba de la diferencia de dos libros.
        /// </summary>
        [TestMethod]
        public void LibrosDiferentesTest()
        {
            ConfiguracionEscenario1();

            Assert.IsFalse(libro1.IgualALibro(libro2));
        }
        /// <summary>
        /// Prueba de la igualdad de dos libros.
        /// </summary>
        [TestMethod]
        public void LibrosIgualesTest()
        {
            ConfiguracionEscenario3();

            Assert.IsTrue(libro1.IgualALibro(libro1));
        }
        #endregion
    }
}
