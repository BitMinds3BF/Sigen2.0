using BITMINDS.controladores;
using BITMINDS.modelos;
using BITMINDS.repositorios.cliente;
using BITMINDS.repositorios.Usuarios;
using BITMINDS.ventanas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BITMINDS
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
