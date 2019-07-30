using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;


namespace Control
{
    /// <summary>
    /// Clase de capa de control de Usuario del sistema
    /// </summary>
   public  class ControlUsuario
    {
        private DatosUsuario DatosUsuario;
         /// <summary>
         /// encapsulo variable del tipo DatosUsuario
         /// </summary>
        public DatosUsuario DatosUsuario1 { get => DatosUsuario; set => DatosUsuario = value; }

        /// <summary>
        /// Metodo para ingresar un nuevo usuario del sistema 
        /// </summary>
        /// <param name="legajo">Campo AutoNumerico</param>
        /// <param name="clave">ingresar nueva Contraseña</param>
        /// <param name="nombredeusuario">Ingresar Nombre del usuario del sistema</param>
        /// <param name="dni">ingresar DNI, el mísmo debe existir</param>
        /// <param name="estadoDelUsuario">ingresar estado del Usuario</param>
        /// <returns>OK si la operacion fue exitosa, sino lo que devuelve un error</returns>
        public string CInsertUsuario( string clave, string nombredeusuario, int dni, string estadoDelUsuario)
        {
            DatosUsuario1 = new DatosUsuario
            {
            
                Clave1 = clave,
                NombreDeUsuarioDeSistema1 = nombredeusuario,
                DNI1 = dni,
                EstadoDelUsuarioDelSistema = estadoDelUsuario
            };
            return DatosUsuario1.IngresarUsuario(DatosUsuario1);
        }

        /// <summary>
        ///  Metodo para modificar a un usuario del sistema existente
        /// </summary>
        /// <param name="legajo">Campo AutoNumerico</param>
        /// <param name="clave">ingresar nueva Contraseña</param>
        /// <param name="nombredeusuario">Ingresar Nombre del usuario del sistema</param>
        /// <param name="dni">ingresar DNI, el mísmo debe existir</param>
        /// <param name="estadoDelUsuario">ingresar estado del Usuario</param>
        /// <returns>OK si la operacion fue exitosa, sino lo que devuelve un error</returns>
        public string CUpdateUsuario(int legajo, string clave, string nombredeusuario, int dni, string estadoDelUsuario)
        {
            DatosUsuario1 = new DatosUsuario
            {
                Legajo = legajo,
                Clave1 = clave,
                NombreDeUsuarioDeSistema1 = nombredeusuario,
                DNI1 = dni,
                EstadoDelUsuarioDelSistema = estadoDelUsuario
            };
            return DatosUsuario1.UpdateUsuario(DatosUsuario1);
        }

        /// <summary>
        /// metodo para eliminar registro fisico de un usuario del sistema
        /// </summary>
        /// <param name="dni">Ingresar el dni para eliminar</param>
        /// <returns>devuelve OK si la operacion fue exitosa, sino  lo que devuelve es un error</returns>
        public string CdeleteUsuario(int dni)
        {
            DatosUsuario1 = new DatosUsuario
            {
                DNI1 = dni
            };
            return DatosUsuario1.EliminarUsuario(DatosUsuario1);
        }
        /// <summary>
        /// Metodo para listar Usuario 
        /// </summary>
        /// <returns>Devuelve un objeto del tipo datatable conteniendo a todos los usuarios del sistema</returns>
        public DataTable CListarusuariosDelSistema()
        {
            DatosUsuario1 = new DatosUsuario();
            return DatosUsuario1.ListarUsuario();
        }
        /// <summary>
        /// Metodo para buscar un usuario por su dni
        /// </summary>
        /// <param name="dni">ingresar el dni del usuario del sistema</param>
        /// <returns>Devuelve un objeto del tipo datatable conteniendo al usuario del sistema</returns>
        public DataTable CBuscarUsuarioDelSistema(int dni)
        {
            DatosUsuario1 = new DatosUsuario
            {
                DNI1 = dni
            };
            return DatosUsuario1.BuscarUsuarioPorDni(DatosUsuario1);
        }

        /// <summary>
        /// metodo de control que llama a llenarcomboboxDNI
        /// </summary>
        /// <returns>devuelve una lista de dni de usuarios</returns>
        public DataTable CLLenarComboDNI()
        {
            DatosUsuario1 = new DatosUsuario();
            return DatosUsuario1.LlenarComboboxDNI();
        }
    }

}
