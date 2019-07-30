using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{       /// <summary>
/// Esta clase se utiliza para realizar ABM de Usuario del Sistema
/// </summary>
    public class DatosUsuario
    {
        //private string PrimeraClave;
        private int legajo;
        private string Clave;
        private string NombreDeUsuarioDeSistema;
        private int DNI;
        private string estadoDelUsuarioDelSistema;

        //campos auxiliares
        private SqlCommand SqlComando;
        private SqlConnection sqlConneccion;
        private Coneccion miConeccion;

        /// <summary>
        /// Constructor de la clase Datos Usuario
        /// </summary>
        /// <param name="clave1"></param>
        /// <param name="nombreDeUsuarioDeSistema1"></param>
        /// <param name="dNI1"></param>
        /// <param name="estadoDelUsuarioDelSistema"></param>
        public DatosUsuario(string clave1, string nombreDeUsuarioDeSistema1, int dNI1, string estadoDelUsuarioDelSistema)
        {
            //PrimeraClave1 = primeraClave1;
            Clave1 = clave1;
            NombreDeUsuarioDeSistema1 = nombreDeUsuarioDeSistema1;
            DNI1 = dNI1;
            EstadoDelUsuarioDelSistema = estadoDelUsuarioDelSistema;
        }
               /// <summary>
               /// Constructor vacio
               /// </summary>
        public DatosUsuario() { }
            /// <summary>
            /// encapsulamientos de campos
            /// </summary>
        //public string PrimeraClave1 { get => PrimeraClave; set => PrimeraClave = value; }
        public string Clave1 { get => Clave; set => Clave = value; }
        /// <summary>
        /// encapsulamiento del campo NombreDeUsuarioDeSistema
        /// </summary>
        public string NombreDeUsuarioDeSistema1 { get => NombreDeUsuarioDeSistema; set => NombreDeUsuarioDeSistema = value; }
        /// <summary>
        ///     encapsulamiento del campo  DNI
        /// </summary>
        public int DNI1 { get => DNI; set => DNI = value; }
        /// <summary>
        /// encapsulamiento del campo    estadoDelUsuarioDelSistema
        /// </summary>
        public string EstadoDelUsuarioDelSistema { get => estadoDelUsuarioDelSistema; set => estadoDelUsuarioDelSistema = value; }
        /// <summary>
        /// encapsulamiento del campo    legajo
        /// </summary>
        public int Legajo { get => legajo; set => legajo = value; }

        /// <summary>
        /// Insert de Usuario Nuevo
        /// </summary>
        /// <param name="datosUsuario">Objeto del tipo DatosUsuario</param>
        /// <returns>devuelve un OK si la operacion se completo exitosamente</returns>
        public string IngresarUsuario(DatosUsuario  datosUsuario)
        {


            string rta = "";
            miConeccion = new Coneccion();
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection.ConnectionString = Coneccion.CadenaDeconneccion;
                sqlConnection.Open();

                SqlComando = new SqlCommand
                {
                    Connection = sqlConneccion,
                    CommandText = "InsertUsuario",
                    CommandType = CommandType.StoredProcedure
                };



                SqlParameter idlegajo = new SqlParameter
                {
                    ParameterName = "@Legajo",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output

                };

                SqlComando.Parameters.Add(idlegajo);

                SqlParameter Clave = new SqlParameter
                {
                    ParameterName = "@Clave",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 1024,
                    Value = datosUsuario.Clave1
                };

                SqlComando.Parameters.Add(Clave);

                SqlParameter NombreDelsuario = new SqlParameter()
                {
                    ParameterName = "@NombreDeUsuario",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 60,
                    Value=  datosUsuario.NombreDeUsuarioDeSistema1
                };

                SqlComando.Parameters.Add(NombreDelsuario);

                SqlParameter sqlparametersNombre = new SqlParameter
                {
                    ParameterName = "@DNI",
                    SqlDbType = SqlDbType.Int,
                   
                    Value = datosUsuario.DNI1

                };

                SqlComando.Parameters.Add(sqlparametersNombre);

                SqlParameter sqlparametreEstado = new SqlParameter
                {
                    ParameterName = "@EstadoDelUsuario",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 60,
                    Value = datosUsuario.EstadoDelUsuarioDelSistema
                };
                SqlComando.Parameters.Add(sqlparametreEstado);

                

                rta = SqlComando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Ingresar el registro";

            }
            catch (Exception ex)
            {
                rta = ex.Message;
            }
            finally
            {
                sqlConnection.Close();
            }
            return rta;

        }

        /// <summary>
        /// metodo para  modificar un Usuario existente
        /// </summary>
        /// <param name="datosUsuario">ingresar objeto del tipo DatosUsuario</param>
        /// <returns>respuesta Si o No fue exitosa la operacion</returns>
        public string UpdateUsuario(DatosUsuario datosUsuario)
        {

            string rta = "";
            miConeccion = new Coneccion();
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection.ConnectionString = Coneccion.CadenaDeconneccion;
                sqlConnection.Open();

                SqlComando = new SqlCommand
                {
                    Connection = sqlConneccion,
                    CommandText = "updateUsuario",
                    CommandType = CommandType.StoredProcedure
                };



                SqlParameter idlegajo = new SqlParameter
                {
                    ParameterName = "@Legajo",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Input

                };

                SqlComando.Parameters.Add(idlegajo);

                SqlParameter Clave = new SqlParameter
                {
                    ParameterName = "@Clave",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 1024,
                    Value = datosUsuario.Clave1
                };

                SqlComando.Parameters.Add(Clave);

                SqlParameter NombreDelsuario = new SqlParameter()
                {
                    ParameterName = "@NombreDeUsuario",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 60,
                    Value = datosUsuario.NombreDeUsuarioDeSistema1
                };

                SqlComando.Parameters.Add(NombreDelsuario);

                SqlParameter sqlparametersNombre = new SqlParameter
                {
                    ParameterName = "@DNI",
                    SqlDbType = SqlDbType.Int,

                    Value = datosUsuario.DNI1

                };

                SqlComando.Parameters.Add(sqlparametersNombre);

                SqlParameter sqlparametreEstado = new SqlParameter
                {
                    ParameterName = "@EstadoDelUsuario",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 60,
                    Value = datosUsuario.EstadoDelUsuarioDelSistema
                };
                SqlComando.Parameters.Add(sqlparametreEstado);


                rta = SqlComando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Modificar el registro ";

            }
            catch (Exception ex)
            {
                rta = ex.Message;
            }
            finally
            {
                sqlConnection.Close();
            }
            return rta;


        }


        /// <summary>
        /// Elimina un Usuario existente
        /// </summary>
        /// <param name="datosUsuario"></param>
        /// <returns>respuesta Si o No fue exitosa la operacion</returns>
        public string EliminarUsuario(DatosUsuario datosUsuario)
        {
            string rta = "";
            miConeccion = new Coneccion();
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection.ConnectionString = Coneccion.CadenaDeconneccion;
                sqlConnection.Open();

                SqlComando = new SqlCommand
                {
                    Connection = sqlConneccion,
                    CommandText = "EliminarUsuario",
                    CommandType = CommandType.StoredProcedure
                };


                SqlParameter Legajo = new SqlParameter
                {
                    ParameterName = "@legajo",
                    SqlDbType = SqlDbType.Int,
                    Value = datosUsuario.Legajo

                };

                SqlComando.Parameters.Add(Legajo);

                rta = SqlComando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Eliminar el registro ";

            }
            catch (Exception ex)
            {
                rta = ex.Message;
            }
            finally
            {
                sqlConnection.Close();
            }
            return rta;

        }


        /// <summary>
        /// lista todos los Usuarios del sistema existentes en el sistema
        /// </summary>
        /// <returns>Devuelve una lista de todos los usuarios del sistema del tipo datatable</returns>
        public DataTable ListarUsuario()
        {
            DataTable dataTablaResultado = new DataTable("Usuario");
            SqlConnection sqlConneccion = new SqlConnection();
            miConeccion = new Coneccion();
            try
            {

                sqlConneccion.ConnectionString = Coneccion.CadenaDeconneccion;
                sqlConneccion.Open();



                SqlDataAdapter sqltabla = new SqlDataAdapter("SELECT  Usuario.Legajo AS 'Legajo',    Usuario.NombreDeUsuario AS 'Nombre de Usuario',Usuario.DNI AS 'DNI', Usuario.EstadoDelUsuario AS 'Estado del Usuario' FROM Usuario", sqlConneccion);

                sqltabla.Fill(dataTablaResultado);

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error de Listado", ex);
            }
            finally
            {
                sqlConneccion.Close();
            }
            return dataTablaResultado;


        }
        /// <summary>
        /// buscar por ID un grupo en particular
        /// </summary>
        /// <returns>devuelve el grupo </returns>
        public DataTable BuscarUsuarioPorDni(DatosUsuario datosUsuario)
        {
            DataTable dataTable = new DataTable();
            SqlConnection sqlConneccion = new SqlConnection();
            miConeccion = new Coneccion();
            try
            {

                sqlConneccion.ConnectionString = Coneccion.CadenaDeconneccion;
                sqlConneccion.Open();
                SqlComando = new SqlCommand
                {
                    Connection = sqlConneccion,
                    CommandText = "BuscarUsuarioPorDNI",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter sqlparametersDNI = new SqlParameter
                {
                    ParameterName = "@DNI",
                    SqlDbType = SqlDbType.Int,
                    Value = datosUsuario.DNI1
                };

                SqlComando.Parameters.Add(sqlparametersDNI);


                SqlDataAdapter sqltabla = new SqlDataAdapter(SqlComando);
                sqltabla.Fill(dataTable);


            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error de Busqueda", ex);
            }
            finally
            {
                sqlConneccion.Close();
            }

            return dataTable;


        }




    }






}
