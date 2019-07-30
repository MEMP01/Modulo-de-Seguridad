using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Control
{
    public class CLogin
    {
        private DLogin dlogin;

        public CLogin() { }

        public DLogin Dlogin { get => dlogin; set => dlogin = value; }

        public int ValidarUsuarioYpasswod(string usu, string pass)
        {

            Dlogin = new DLogin
            {
                NombreDeUsuario1 = usu,
                Password1 = pass
            };
            return Dlogin.ValidarDatos(Dlogin);

        }

    }
}
