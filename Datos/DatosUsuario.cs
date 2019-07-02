using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{       /// <summary>
/// Esta clase se utiliza para realizar ABM de Usuario del Sistema
/// </summary>
    class DatosUsuario
    {
        //private string PrimeraClave;
        private int legajo;
        private string Clave;
        private string NombreDeUsuarioDeSistema;
        private int DNI;
        private string estadoDelUsuarioDelSistema;
        private SqlCommand SqlComando;
        private SqlConnection sqlConneccion;
        private Coneccion Miconeccion;


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
        public string NombreDeUsuarioDeSistema1 { get => NombreDeUsuarioDeSistema; set => NombreDeUsuarioDeSistema = value; }
        public int DNI1 { get => DNI; set => DNI = value; }
        public string EstadoDelUsuarioDelSistema { get => estadoDelUsuarioDelSistema; set => estadoDelUsuarioDelSistema = value; }
        public int Legajo { get => legajo; set => legajo = value; }

        /// <summary>
        /// Insert de Usuario Nuevo
        /// </summary>
        /// <param name="datosUsuario"></param>
        /// <returns>devuelve un OK si la operacion se completo exitosamente</returns>
        public string IngresarUsuario(DatosUsuario  datosUsuario)
        {


            SqlConnection sqlConneccion = new SqlConnection();
            string rta = "";
            try
            {

                sqlConneccion.ConnectionString = Coneccion.CadenaDeconneccion;
                sqlConneccion.Open();
                SqlComando = new SqlCommand
                {
                    Connection = sqlConneccion,
                    CommandText = "SP_ABM_Usuario",
                    CommandType = CommandType.StoredProcedure
                };



                SqlParameter idlegajo = new SqlParameter
                {
                    ParameterName = "@legajo",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output

                };

                SqlComando.Parameters.Add(idlegajo);

                SqlParameter Clave = new SqlParameter
                {
                    ParameterName = "@clave",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 1024,
                    Value = datosUsuario.Clave1
                };

                SqlComando.Parameters.Add(Clave);

                SqlParameter NombreDelsuario = new SqlParameter()
                {
                    ParameterName = "@nombredeUsuario",
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

                SqlParameter sqlparameterStatementType = new SqlParameter
                {
                    ParameterName = "@statementType",
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 20,
                    Value = "Insert"
                };

                SqlComando.Parameters.Add(sqlparameterStatementType);

                rta = SqlComando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Ingresar el registro";

            }
            catch (Exception ex)
            {
                rta = ex.Message;
            }
            finally
            {
                if (sqlConneccion.State == ConnectionState.Open)
                {
                    sqlConneccion.Close();
                }
            }
            return rta;

        }

        /// <summary>
        /// metodo para  modificar un Usuario existente
        /// </summary>
        /// <param name="datosUsuario">ingresar objeto del tipo grupo</param>
        /// <returns>respuesta Si o No fue exitosa la operacion</returns>
        public string UpdateUsuario(DatosUsuario datosUsuario)
        {

            string rta = "";
            Miconeccion = new Coneccion();
            SqlConnection sqlConneccion = new SqlConnection();

            try
            {


                sqlConneccion.ConnectionString = Coneccion.CadenaDeconneccion;
                sqlConneccion.Open();
                SqlComando = new SqlCommand
                {
                    Connection = sqlConneccion,
                    CommandText = "SP_ABM_Usuario",
                    CommandType = CommandType.StoredProcedure
                };



                SqlParameter idlegajo = new SqlParameter
                {
                    ParameterName = "@legajo",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Input

                };

                SqlComando.Parameters.Add(idlegajo);

                SqlParameter Clave = new SqlParameter
                {
                    ParameterName = "@clave",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 1024,
                    Value = datosUsuario.Clave1
                };

                SqlComando.Parameters.Add(Clave);

                SqlParameter NombreDelsuario = new SqlParameter()
                {
                    ParameterName = "@nombredeUsuario",
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

                SqlParameter sqlparameterStatementType = new SqlParameter
                {
                    ParameterName = "@statementType",
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 20,
                    Value = "Update"
                };

                SqlComando.Parameters.Add(sqlparameterStatementType);

                rta = SqlComando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Modificar el registro ";

            }
            catch (Exception ex)
            {
                rta = ex.Message;
            }
            finally
            {
                if (sqlConneccion.State == ConnectionState.Open)
                {
                    sqlConneccion.Close();
                }
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
            Miconeccion = new Coneccion();
            SqlConnection sqlConneccion = new SqlConnection();

            try
            {
                sqlConneccion.ConnectionString = Coneccion.CadenaDeconneccion;
                sqlConneccion.Open();
                SqlComando = new SqlCommand
                {
                    Connection = sqlConneccion,
                    CommandText = "SP_ABM_Usuario",
                    CommandType = CommandType.StoredProcedure
                };


                SqlParameter Legajo = new SqlParameter
                {
                    ParameterName = "@legajo",
                    SqlDbType = SqlDbType.Int,
                    Value = datosUsuario.Legajo

                };

                SqlComando.Parameters.Add(Legajo);

                SqlParameter sqlparameterStatementType = new SqlParameter
                {
                    ParameterName = "@statementType",
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 20,
                    Value = "Delete"
                };

                SqlComando.Parameters.Add(sqlparameterStatementType);


                rta = SqlComando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Eliminar el registro ";

            }
            catch (Exception ex)
            {
                rta = ex.Message;
            }
            finally
            {
                if (sqlConneccion.State == ConnectionState.Open)
                {
                    sqlConneccion.Close();
                }
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
            Miconeccion = new Coneccion();
            try
            {

                sqlConneccion.ConnectionString = Coneccion.CadenaDeconneccion;
                sqlConneccion.Open();



                SqlDataAdapter sqltabla = new SqlDataAdapter("Select * from VistaUsuario", sqlConneccion);

                sqltabla.Fill(dataTablaResultado);

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error de Listado", ex);
            }
            finally
            {
                if (sqlConneccion.State == ConnectionState.Open)
                {
                    sqlConneccion.Close();
                }
            }
            return dataTablaResultado;


        }
        /// <summary>
        /// buscar por ID un grupo en particular
        /// </summary>
        /// <param name="datosGrupo">Ingrese el Id del grupo a encontrar</param>
        /// <returns>devuelve el grupo </returns>
        public DataTable BuscarGrupos(DatosUsuario datosUsuario)
        {
            DataTable dataTable = new DataTable();
            SqlConnection sqlConneccion = new SqlConnection();
            Miconeccion = new Coneccion();
            try
            {

                sqlConneccion.ConnectionString = Coneccion.CadenaDeconneccion;
                sqlConneccion.Open();
                SqlComando = new SqlCommand
                {
                    Connection = sqlConneccion,
                    CommandText = "SP_ABM_Usuario",
                    CommandType = CommandType.StoredProcedure
                };



                SqlParameter sqlLegajo = new SqlParameter
                {
                    ParameterName = "@legajo",
                    SqlDbType = SqlDbType.Int,
                    
                    Value = datosUsuario.Legajo
                };
                SqlComando.Parameters.Add(sqlLegajo);

                SqlParameter sqlparameterStatementType = new SqlParameter
                {
                    ParameterName = "@statementType",
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 20,
                    Value = "Buscar"
                };

                SqlComando.Parameters.Add(sqlparameterStatementType);

                SqlDataAdapter sqltabla = new SqlDataAdapter(SqlComando);
                sqltabla.Fill(dataTable);


            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error de Busqueda", ex);
            }
            finally
            {
                if (sqlConneccion.State == ConnectionState.Open)
                {
                    sqlConneccion.Close();
                }
            }

            return dataTable;


        }




    }






}
