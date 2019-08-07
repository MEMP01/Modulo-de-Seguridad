using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Soporte.Cache
{

    /// <summary>
    /// Clase estatica para almacenar en memoria el estado del usuario logeado
    /// </summary>
    public static class UsuarioActivo
    {
        public static int IdUseruario { get; set; }         
        public static string NombreDeUsuario { get; set; }
        public static string Grupo { get; set; }
        public static string Email { get; set; }

    }
}
