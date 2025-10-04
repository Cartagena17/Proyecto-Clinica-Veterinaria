using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public int? personalId { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Activo { get; set; }
        public string TokenRecuperacion { get; set; }
        public DateTime? FechaExpiracionToken { get; set; }

        public string Email { get; set; }
    }
}
