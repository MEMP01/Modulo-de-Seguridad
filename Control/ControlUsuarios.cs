using Datos;
using System.Data;

namespace Control
{

    /// <summary>
    ///  Controladora de Usuarios
    /// </summary>
    public class ControlUsuarios
    {
        private DatosUsuarios DatosUsuarios;
        /// <summary>
        /// Encapsulado del campo del tipo DatosUSuario
        /// </summary>
        public DatosUsuarios DatosUsuarios1 { get => DatosUsuarios; set => DatosUsuarios = value; }

        /// <summary>
        /// Controladora para ingresar registros de Usuarios
        /// </summary>
        /// <param name="dNI1">Dni del usuario</param>
        /// <param name="apellido">Apellido del usuario</param>
        /// <param name="nombreusuario">Nomrbre del usuario</param>
        /// <param name="sexo">Sexo del usuario</param>
        /// <param name="edad">Edad del usuario</param>
        /// <param name="email">Email del usuario</param>
        /// <param name="telefono">Telefono del usuario</param>
        /// <param name="pais">pais del usuario</param>
        /// <param name="provincia">provincia del usuario</param>
        /// <param name="direcion">direccion del usuario</param>
        /// <param name="codigopostal">codigo postal del usuario</param>
        /// <param name="estado">estado del usuario</param>
        /// <returns>respuesta Si o No fue exitosa la operacion</returns>
        public string CAltaUsuario(int dNI1, string apellido, string nombreusuario, char sexo, int edad, string email, int telefono, string pais, string provincia, string direcion, int codigopostal, int estado)
        {
            DatosUsuarios1 = new DatosUsuarios
            {
                DNI1 = dNI1,
                Apellido = apellido,
                Nombreusuario = nombreusuario,
                Sexo = sexo,
                Edad = edad,
                Email = email,
                Telefono = telefono,
                Pais = pais,
                Provincia = provincia,
                Direcion = direcion,
                Codigopostal = codigopostal,
                Estado = estado
            };
            return DatosUsuarios1.IngresarUsuarios(DatosUsuarios1);

        }

        /// <summary>
        /// Controladora para Modificar registros de Usuarios
        /// </summary>
        /// <param name="dNI1">Dni del usuario</param>
        /// <param name="apellido">Apellido del usuario</param>
        /// <param name="nombreusuario">Nomrbre del usuario</param>
        /// <param name="sexo">Sexo del usuario</param>
        /// <param name="edad">Edad del usuario</param>
        /// <param name="email">Email del usuario</param>
        /// <param name="telefono">Telefono del usuario</param>
        /// <param name="pais">pais del usuario</param>
        /// <param name="provincia">provincia del usuario</param>
        /// <param name="direcion">direccion del usuario</param>
        /// <param name="codigopostal">codigo postal del usuario</param>
        /// <param name="estado">estado del usuario</param>
        /// <returns>respuesta Si o No fue exitosa la operacion</returns>
        public string CModificacionUsuario(int dNI1, string apellido, string nombreusuario, char sexo, int edad, string email, int telefono, string pais, string provincia, string direcion, int codigopostal, int estado)
        {
            DatosUsuarios1 = new DatosUsuarios
            {
                DNI1 = dNI1,
                Apellido = apellido,
                Nombreusuario = nombreusuario,
                Sexo = sexo,
                Edad = edad,
                Email = email,
                Telefono = telefono,
                Pais = pais,
                Provincia = provincia,
                Direcion = direcion,
                Codigopostal = codigopostal,
                Estado = estado
            };
            return DatosUsuarios1.UpdateUsuarios(DatosUsuarios1);

        }

        /// <summary>
        /// Controladora para Eliminar registros de Usuarios
        /// </summary>
        /// <param name="dNI1">Dni del usuario</param>
        /// <returns>respuesta Si o No fue exitosa la operacion</returns>
        public string CEliminarUsuario(int dNI1)
        {
            DatosUsuarios1 = new DatosUsuarios
            {
                DNI1 = dNI1

            };
            return DatosUsuarios1.EliminarUsuario(DatosUsuarios1);
        }

        /// <summary>
        /// Devuelve todos los usuarios
        /// </summary>
        /// <returns>Lista tipo datatable de todos los ususarios</returns>
        public DataTable CListarUsuario()
        {
            DatosUsuarios1 = new DatosUsuarios();
            return DatosUsuarios1.ListarUsuarios();
        }
        /// <summary>
        /// Buscar Usuario por DNI
        /// </summary>
        /// <param name="dNI1"></param>
        /// <returns>Retorna el usuario siempre que exista en el sistema</returns>
        public DataTable CBuscarUsuario(int dNI1)
        {
            DatosUsuarios1 = new DatosUsuarios
            {
                DNI1 = dNI1

            };
            return DatosUsuarios1.BuscarUsuariosPorDNI(DatosUsuarios1);
        }
    }
}
