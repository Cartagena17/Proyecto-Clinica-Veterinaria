using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using Vistas.Formularios;

namespace Vistas
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

            // ✅ NUEVA LÓGICA DE LOGIN
            var usuarioModel = new UsuarioModel();

            if (!usuarioModel.HayUsuariosRegistrados())
            {
                Application.Run(new frmPrimerUsuario());
            }
            else
            {
                Application.Run(new frmLogin());
            }
        }
    }
}
