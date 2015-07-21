// ===++===
//
//	OrtizOL - xCSw
//
//  Proyecto: Cupi2.NET
//
// ===--===
/*============================================================
//
// Clase(s): `CarroCompraTest`
//
// Propósito: Probar el estado y funcionalidad de la entidad
// `CarroCompra`.
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
    /// Clase de prueba de la clase `CarroCompra`.
    /// </summary>
    [TestClass]
    public class CarroCompraTest
    {
        #region Campos de prueba
        /// <summary>
        /// Libro de pruebas no. 1.
        /// </summary>
        private Libro libro1;
        /// <summary>
        /// Libro de pruebas no. 2.
        /// </summary>
        private Libro libro2;
        /// <summary>
        /// Ítem de pruebas no. 1.
        /// </summary>
        private ItemCompra item1;
        /// <summary>
        /// Ítem de pruebas número 2.
        /// </summary>
        private ItemCompra item2;
        /// <summary>
        /// Carrito de pruebas.
        /// </summary>
        private CarroCompras carrito;
        #endregion

        #region Esecenarios de configuración
        /// <summary>
        /// Configuración de escenario de pruebas no. 1.
        /// </summary>
        private void ConfiguracionEscenario1()
        {
            String titulo, isbn;
            int precio, cantidad1, cantidad2;

            // Crea el primer libro para pruebas:
            titulo = "T[itulo 1";
            isbn = "ISBN 1";
            precio = 1000;
            libro1 = new Libro(isbn, titulo, precio);

            // Crea el segundo libro para pruebas:
            titulo = "Título 2";
            isbn = "ISBN 2";
            precio = 2000;
            libro2 = new Libro(isbn, titulo, precio);

            // Crea un ítem de compra:
            cantidad1 = 2;
            item1 = new ItemCompra(libro1, cantidad1);

            // Crea otro ítem de compra:
            cantidad2 = 3;
            item2 = new ItemCompra(libro2, cantidad2);

            // Crea el carro de compras con un ítem de compra:
            carrito = new CarroCompras();
            carrito.AdicionarCompra(libro1, cantidad1);
            carrito.AdicionarCompra(libro2, cantidad2);
        }
        /// <summary>
        /// Configuración de escenario de pruebas no. 2.
        /// </summary>
        private void ConfiguracionEscenario2()
        {
            String titulo, isbn;
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

            // Crea el carro de compras con un ítem de compra:
            carrito = new CarroCompras();
            carrito.AdicionarCompra(libro1, cantidad1);
            carrito.AdicionarCompra(libro2, cantidad2);
        }
        /// <summary>
        /// Configuración de escenario de pruebas no. 3.
        /// </summary>
        private void ConfiguracionEscenario3()
        {
            String titulo, isbn;
            int precio, cantidad1, cantidad2;

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

            // Crea el carro de compras con un ítem de compra:
            carrito = new CarroCompras();
            carrito.AdicionarCompra(libro1, cantidad1);
            carrito.AdicionarCompra(libro2, cantidad2);
        }
        #endregion

        #region Métodos de prueba:
        /// <summary>
        /// Prueba el método de adición de compra.
        /// </summary>
        [TestMethod]
        public void AdicionarCompraTest()
        {
            ConfiguracionEscenario1();
            int cantidad;
            ItemCompra item;

            // Obtiene el libro del ítem. El libro esperado es el libro 1:
            item = carrito.BuscarItemCompraLibro(libro1.Isbn);

            Assert.IsTrue(item.Libro.Isbn.Equals(libro1.Isbn));

            // Verifica cantidades:
            cantidad = 2;

            Assert.AreEqual(cantidad, item.CantidadSolicitada);
        }
        /// <summary>
        /// Prueba del método de adición de ítem de compra.
        /// </summary>
        [TestMethod]
        public void AdicionarItemCompraExisteTest()
        {
            ConfiguracionEscenario2();
            ItemCompra item;
            int cantidad;

            // Adiciona el mismo ítem de compra:
            carrito.AdicionarCompra(item1.Libro, item1.CantidadSolicitada);

            // Obtiene el libro del ítem. El libro esperado es el libro 1:
            item = carrito.BuscarItemCompraLibro(libro1.Isbn);

            Assert.IsTrue(item.Libro.IgualALibro(libro1));

            // Verifica cantidades:
            cantidad = 20;

            Assert.AreEqual(cantidad * 2, item.CantidadSolicitada);
        }
        /// <summary>
        /// Prueba el método de eliminación de ítem de compra.
        /// </summary>
        [TestMethod]
        public void BorrarItemCompraTest()
        {
            ConfiguracionEscenario3();
            carrito.BorrarItemCompra(item1);

            // Intenta buscar el ítem por el libro:
            ItemCompra item = carrito.BuscarItemCompraLibro(libro1.Isbn);

            if (item != null)
            {
                Assert.Fail("El libro ya no se debe encontrar en el carro.");
            }
        }
        /// <summary>
        /// Prueba el método de búsqueda de ítem.
        /// </summary>
        [TestMethod]
        public void BuscarItemCompraTest()
        {
            ConfiguracionEscenario3();
            carrito.AdicionarCompra(item1.Libro, item1.CantidadSolicitada);

            // Intenta buscar el ítem por el libro:
            ItemCompra item = carrito.BuscarItemCompraLibro(libro1.Isbn);

            Assert.AreEqual(item.Libro.Isbn, item1.Libro.Isbn);
        }
        /// <summary>
        /// Prueba el método de calcular total.
        /// </summary>
        [TestMethod]
        public void CalcularTotalTest()
        {
            ConfiguracionEscenario2();
            int precio1, precio2, cantidad1, cantidad2, totalEsperado;

            // Adiciona nuevamente los ítem de compra (pedido doble):
            carrito.AdicionarCompra(item1.Libro, item1.CantidadSolicitada);
            carrito.AdicionarCompra(item2.Libro, item2.CantidadSolicitada);

            // El valor de la compra es la suma de los precios de los libros 
            // por el doble de las cantidad:
            precio1 = 10000;
            precio2 = 20000;
            cantidad1 = 2 * 20;
            cantidad2 = 2 * 30;

            totalEsperado = precio1 * cantidad1 + precio2 * cantidad2;

            Assert.AreEqual(totalEsperado, carrito.CalcularValorTotalCompra());
        }
        #endregion
    }
}
