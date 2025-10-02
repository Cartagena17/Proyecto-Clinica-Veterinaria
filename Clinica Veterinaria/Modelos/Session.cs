    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos.Entidades;

namespace Modelos
{
    public class Session
    {
        public static Usuario UsuarioActual { get; set; }

        public static bool EsAdministrador
        {
            get
            {
                return UsuarioActual != null && UsuarioActual.Rol == "Administrador";
            }
        }

        public static bool EsEmpleado
        {
            get
            {
                return UsuarioActual != null && UsuarioActual.Rol == "Empleado";
            }
        }

        public static void CerrarSesion()
        {
            UsuarioActual = null;
        }
    }
}
