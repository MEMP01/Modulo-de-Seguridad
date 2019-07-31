using System;
using System.Data.SqlClient;

namespace Datos
{
    /// <summary>
    /// Clase para validar login
    /// </summary>
    public class DLogin
    {

        private string NombreDeUsuario;
        private string Password;

        /// <summary>
        /// Contructor de la clase DLogin
        /// </summary>
        /// <param name="nombreDeUsuario1">Ingrese el nombre del Usuario</param>
        /// <param name="password1">ingrese el password</param>
        public DLogin(string nombreDeUsuario1, string password1)
        {
            NombreDeUsuario1 = nombreDeUsuario1;
            Password1 = password1;
        }
        /// <summary>
        /// contructor vacio de la clase DLogin
        /// </summary>
        public DLogin() { }
        /// <summary>
        /// Campos encapsulados  NombreDeUsuario
        /// </summary>
        public string NombreDeUsuario1 { get => NombreDeUsuario; set => NombreDeUsuario = value; }
        /// <summary>
        /// Campos encapsuladors Password
        /// </summary>
        public string Password1 { get => Password; set => Password = value; }

        //campos auxiliares
        private SqlCommand SqlComando;
        private SqlConnection sqlConneccion;
        private Coneccion miConeccion;

        /// <summary>
        ///  Metodo para validar si los datos ingresados en el formulario Iniciar sesion son validos y permite el acceso siempre y cuando el usuario posea un estado de 'Activo'
        /// </summary>
        /// <param name="login">Un objeto del tipo Dlogin</param>
        /// <returns>devuelve un valor mayor a 0(cero) si la operacion es correcta y devuleve 0(cero) en caso de que
        /// la operacion posea algo incorrecto, ya sea porque no exite el usuario, no es correcto el nombre de usuario
        /// , no es correcto la clave o el estado del usuario es 'Inactivo' </returns>
        public int ValidarDatos(DLogin login)
        {
            string rta;
            int idUsuario = 0;
            miConeccion = new Coneccion();
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
               
                sqlConnection.ConnectionString = Coneccion.CadenaDeconneccion;
                sqlConnection.Open();

                string commandString = "SELECT ISNULL([Legajo],0)  FROM [Usuario] WHERE [NombreDeUsuario]= @user AND[Clave]= @pass AND [EstadoDelUsuario]= 'Activo'";

                SqlCommand cmd = new SqlCommand(commandString, sqlConnection);
                cmd.Parameters.AddWithValue("@user", login.NombreDeUsuario1);
                cmd.Parameters.AddWithValue("@pass", login.Password1);


                 idUsuario = Convert.ToInt32(cmd.ExecuteScalar());
            


            }
            catch (Exception ex)
            {
             rta= ex.Message;
            }
            finally
            {
                sqlConnection.Close();
            }
            return idUsuario;
        }
    }
}
