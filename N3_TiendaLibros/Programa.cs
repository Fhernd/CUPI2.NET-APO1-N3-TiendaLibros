// ===++===
//
//	OrtizOL - xCSw
//
//  Proyecto: Cupi2.NET
//
// ===--===
/*============================================================
//
// Clase(s): `Programa`
//
// Propósito: Crear una instancia de la aplicación.
//
// Original: N/D.
//
============================================================*/

using System;
using System.Windows.Forms;
using N3_TiendaLibros.GUI;

namespace N3_TiendaLibros
{
    static class Programa
    {
        /// <summary>
        /// Punto de entrada de la ejecución de la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
        }
    }
}
