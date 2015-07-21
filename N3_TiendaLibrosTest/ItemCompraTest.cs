// ===++===
//
//	OrtizOL - xCSw
//
//  Proyecto: Cupi2.NET
//
// ===--===
/*============================================================
//
// Clase(s): `ItemCompraTest`.
//
// Propósito: Probar el estado y comportamiento de la 
// entidad `ItemCompra`.
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
    /// Clase de prueba de la clase `ItemCompra`.
    /// </summary>
    [TestClass]
    public class ItemCompraTest
    {
        #region Campos de prueba
        /// <summary>
        /// Libro de prueba no. 1.
        /// </summary>
        private Libro libro1;
        /// <summary>
        /// Libro de prueba no. 2.
        /// </summary>
        private Libro libro2;
        /// <summary>
        /// Ítem de compra de prueba no. 1.
        /// </summary>
        private ItemCompra item1;
        /// <summary>
        /// Ítem de compra de prueba no. 2.
        /// </summary>
        private ItemCompra item2;
        #endregion

        #region Escenarios de Configuración de Pruebas
        /// <summary>
        /// Configuración de escenario de pruebas no. 1.
        /// </summary>
        private void ConfiguracionEscenario1()
        {
            string titulo, isbn;
            int precio, cantidad1, cantidad2;

            // Crea el primer libro para pruebas:
            titulo = "Título 1";
            isbn = "ISBN 1";
            precio = 1000;
            libro1 = new Libro(titulo, titulo, precio);

            // Crea el segundo libro pra pruebas:
            titulo = "Título 2";
            isbn = "ISBN 2";
            precio = 2000;
            libro2 = new Libro(titulo, titulo, precio);

            // Crea un ítem de compra:
            cantidad1 = 2;
            item1 = new ItemCompra(libro1, cantidad1);
            
            // Crea otro ítem de compra:
            cantidad2 = 3;
            item2 = new ItemCompra(libro2, cantidad2);
        }
        /// <summary>
        /// Configuración de escenario de pruebas no. 2.
        /// </summary>
        private void ConfiguracionEscenario2()
        {
            string titulo, isbn;
            int precio, cantidad1, cantidad2;

            // Crea el primer libro para pruebas:
            titulo = "Título 3";
            isbn = "ISBN 3";
            precio = 10000;
            libro1 = new Libro(isbn, titulo, precio);

            // Crea el segundo libro para pruebas:
            titulo = "Título 4";
            isbn = "ISBN 4";
            precio = 20000;
            libro2 = new Libro(isbn, titulo, precio);

            // Crea un ítem de compra:
            cantidad1 = 20;
            item1 = new ItemCompra(libro1, cantidad1);

            // Crea otro ítem de compra:
            cantidad2 = 30;
            item2 = new ItemCompra(libro2, cantidad2);
        }
        /// <summary>
        /// Configuración de escenario de pruebas no. 3.
        /// </summary>
        private void ConfiguracionEscenario3()
        {
            string titulo, isbn;
            int precio, cantidad1, cantidad2;

            // Obtiene los datos de prueba:

            // Crea el primer libro para pruebas:
            titulo = "Título 5";
            isbn = "ISBN 5";
            precio = 10;
            libro1 = new Libro(isbn, titulo, precio);

            // Crea el segundo libro para pruebas:
            titulo = "Título 6";
            isbn = "ISBN 6";
            precio = 20;
            libro2 = new Libro(isbn, titulo, precio);

            // Crea un ítem de compra:
            cantidad1 = 1;
            item1 = new ItemCompra(libro1, cantidad1);

            // Crea otro ítem de compra:
            cantidad2 = 2;
            item2 = new ItemCompra(libro2, cantidad2);
        }
        #endregion

        #region Métodos de prueba:
        /// <summary>
        /// Prueba del método de cálculo de subtotal.
        /// </summary>
        [TestMethod]
        public void CalculoSubtotalTest()
        {
            ConfiguracionEscenario2();

            int cantidad = 20;
            int precio = 10000;

            Assert.AreEqual(cantidad * precio, item1.CalcularSubtotalItem());
        }
        /// <summary>
        /// Prueba el método cambio de cantidad de un ítem.
        /// </summary>
        [TestMethod]
        public void CambioCantidadItemTest()
        {
            ConfiguracionEscenario1();

            int cantidad = 4;
            item2.CantidadSolicitada = 4;

            Assert.AreEqual(cantidad, item2.CantidadSolicitada);
        }
        /// <summary>
        /// Prueba del método crear ítem de compra.
        /// </summary>
        [TestMethod]
        public void CrearItemCompraTest()
        {
            ConfiguracionEscenario1();

            int cantidad = 2;

            // Verifica las cantidades:
            Assert.AreEqual(cantidad, item1.CantidadSolicitada);

            // Verifica los libros:
            Assert.IsTrue(item1.Libro.IgualALibro(libro1));
        }
        /// <summary>
        /// Prueba del ISBN de un ítem.
        /// </summary>
        [TestMethod]
        public void IsbnItemTest()
        {
            ConfiguracionEscenario1();

            // Verifica los ISBN de los libros:
            Assert.AreEqual(item1.Libro.Isbn, libro1.Isbn);
        }
        /// <summary>
        /// Prueba de diferencia entre dos ítems.
        /// </summary>
        [TestMethod]
        public void ItemsDiferentesTest()
        {
            ConfiguracionEscenario3();

            Assert.IsFalse(item1.IgualAItem(item2));
        }
        /// <summary>
        /// Prueba de la igualdad de dos ítems.
        /// </summary>
        [TestMethod]
        public void ItemsIgualesTest()
        {
            ConfiguracionEscenario2();

            Assert.IsTrue(item1.IgualAItem(item1));
        }
        /// <summary>
        /// Prueba de la igualdad de dos libros.
        /// </summary>
        [TestMethod]
        public void LibroTest()
        {
            ConfiguracionEscenario2();

            // Verifica los ISBN de los libros:
            Assert.AreEqual(item2.Libro, libro2);
        }
        #endregion
    }
}
