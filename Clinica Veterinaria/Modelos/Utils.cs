using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Utils
    {
        private static readonly Random random = new Random();

        public static string GenerarContraseñaSegura(int longitud = 8)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%";
            return new string(Enumerable.Repeat(chars, longitud)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
