using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    class DatosUsuario
    {
        private string PrimeraClave;
        private string Clave;
        private string NombreDeUsuarioDeSistema;
        private int DNI;
        private string estadoDelUsuarioDelSistema;
        private SqlCommand SqlComando;
        private SqlConnection sqlConneccion;
        private Coneccion Miconeccion;



        public DatosUsuario(string primeraClave1, string clave1, string nombreDeUsuarioDeSistema1, int dNI1, string estadoDelUsuarioDelSistema)
        {
            PrimeraClave1 = primeraClave1;
            Clave1 = clave1;
            NombreDeUsuarioDeSistema1 = nombreDeUsuarioDeSistema1;
            DNI1 = dNI1;
            EstadoDelUsuarioDelSistema = estadoDelUsuarioDelSistema;
        }

        public DatosUsuario() { }

        public string PrimeraClave1 { get => PrimeraClave; set => PrimeraClave = value; }
        public string Clave1 { get => Clave; set => Clave = value; }
        public string NombreDeUsuarioDeSistema1 { get => NombreDeUsuarioDeSistema; set => NombreDeUsuarioDeSistema = value; }
        public int DNI1 { get => DNI; set => DNI = value; }
        public string EstadoDelUsuarioDelSistema { get => estadoDelUsuarioDelSistema; set => estadoDelUsuarioDelSistema = value; }


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
                    CommandText = "Sp_ABMC_Grupos",
                    CommandType = CommandType.StoredProcedure
                };



                SqlParameter id = new SqlParameter
                {
                    ParameterName = "@idGrupo",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output

                };

                SqlComando.Parameters.Add(id);

                SqlParameter sqlparametersNombre = new SqlParameter
                {
                    ParameterName = "@nombre",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 120,
                    Value = datosUsuario.NombreDeUsuarioDeSistema1

                };

                SqlComando.Parameters.Add(sqlparametersNombre);

                SqlParameter sqlparametreEstado = new SqlParameter
                {
                    ParameterName = "@estado",
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
        /// metodo para  modificar un grupo existente
        /// </summary>
        /// <param name="grupo">ingresar objeto del tipo grupo</param>
        /// <returns>respuesta Si o No fue exitosa la operacion</returns>
        public string UpdateGrupos(DatosGrupo grupo)
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
                    CommandText = "Sp_ABMC_Grupos",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter sqlparametersNombre = new SqlParameter
                {
                    ParameterName = "@nombre",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 120,
                    Value = grupo.NombreGrupo

                };

                SqlComando.Parameters.Add(sqlparametersNombre);

                SqlParameter sqlparametreEstado = new SqlParameter
                {
                    ParameterName = "@estado",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 60,
                    Value = grupo.EstadoGrupo
                };
                SqlComando.Parameters.Add(sqlparametreEstado);

                SqlParameter id = new SqlParameter
                {
                    ParameterName = "@idGrupo",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Input,
                    Value = grupo.CodigoDeGrupo

                };

                SqlComando.Parameters.Add(id);

                SqlParameter sqlparameterStatementType = new SqlParameter
                {
                    ParameterName = "@statementType",
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 20,
                    Value = "Update"
                };

                SqlComando.Parameters.Add(sqlparameterStatementType);


                rta = SqlComando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Ingresar el registro ";

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
        /// Elimina un grupo existente
        /// </summary>
        /// <param name="grupo"></param>
        /// <returns>respuesta Si o No fue exitosa la operacion</returns>
        public string EliminarGrupo(DatosGrupo grupo)
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
                    CommandText = "EliminarGrupo",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter id = new SqlParameter
                {
                    ParameterName = "@id",
                    SqlDbType = SqlDbType.Int,
                    Value = grupo.CodigoDeGrupo

                };

                SqlComando.Parameters.Add(id);




                rta = SqlComando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Ingresar el registro ";

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
        /// lista todos los grupos existentes en el sistema
        /// </summary>
        /// <returns>Devuelve una lista de todos los grupos del tipo datatable</returns>
        public DataTable ListarGrupos()
        {
            DataTable dataTablaResultado = new DataTable("Grupo");
            SqlConnection sqlConneccion = new SqlConnection();
            Miconeccion = new Coneccion();
            try
            {

                sqlConneccion.ConnectionString = Coneccion.CadenaDeconneccion;
                sqlConneccion.Open();



                SqlDataAdapter sqltabla = new SqlDataAdapter("Select * from VistaGrupo", sqlConneccion);

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
        public DataTable BuscarGrupos(DatosGrupo datosGrupo)
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
                    CommandText = "SpBuscarGrupo",
                    CommandType = CommandType.StoredProcedure
                };



                SqlParameter sqlpnombre = new SqlParameter
                {
                    ParameterName = "@nombre",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 120,
                    Value = datosGrupo.NombreGrupo
                };
                SqlComando.Parameters.Add(sqlpnombre);

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
