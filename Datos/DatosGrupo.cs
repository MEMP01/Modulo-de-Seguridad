using Acceso_a_Datos;
using System;
using System.Data;
using System.Data.SqlClient;


namespace Datos
{  /// <summary>
/// Esta Clase se utiliza para realizar ejecutar Altas, Bajas , Modificacion, Busquedas y Listados de elementos para la tabla grupos
/// </summary>
    public class DatosGrupo
    {
        //Encapsulado de los campos de la tabla
        private string nombreGrupo;
        private int IdNombre;
        private string estadoGrupo;

        /// <summary>
        /// encapsulamiento del campo Nombre del grupo
        /// </summary>
        public string NombreGrupo { get => nombreGrupo; set => nombreGrupo = value; }
        /// <summary>
        /// Encapsulamiento del campo ID del Grupo
        /// </summary>
        public int IdNombre1 { get => IdNombre; set => IdNombre = value; }
        /// <summary>
        /// encapsulamiento del campo estado del grupo
        /// </summary>
        public string EstadoGrupo { get => estadoGrupo; set => estadoGrupo = value; }

        //campos auxiliares
        private SqlCommand SqlComando;
        private SqlConnection sqlConneccion;
        private Coneccion Miconeccion;
         

        /// <summary>
        /// Contructor de la clase DatosGrupos           
        /// </summary>
        public DatosGrupo() { }
        /// <summary>
        /// contructo de la clase datos grupo
        /// </summary>
        /// <param name="id"> ID del Grupo</param>
        /// <param name="nombre"> Nombre del Grupo</param>
        /// <param name="estado">Estado Del Grupo</param>
        public DatosGrupo(int id, string nombre, string estado)
        {
            NombreGrupo = nombre;
            IdNombre1 = id;
            EstadoGrupo = estado;
        }

        /// <summary>
        /// Metodo para ingresar un nuevo grupo de usuarios
        /// </summary>
        /// <param name="grupo">ingresar objeto del tipo Datosgrupo</param>
        /// <returns>respuesta Si o No fue exitosa la operacion</returns>
        public string IngresarGrupo(DatosGrupo grupo)
        {
            string rta = "";

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

                SqlParameter sqlparameterStatementType = new SqlParameter
                {
                    ParameterName = "@statementType",
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 20,
                    Value = "Insert"
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
                    CommandText = "Sp_ABMC_Grupos",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter sqlparametersIdnGrupo = new SqlParameter
                {
                    ParameterName = "@idGrupo",
                    SqlDbType = SqlDbType.Int,

                    Value = grupo.IdNombre1

                };



                SqlComando.Parameters.Add(sqlparametersIdnGrupo);

                SqlParameter sqlparameterStatementType = new SqlParameter
                {
                    ParameterName = "@statementType",
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 20,
                    Value = "Delete"
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
        /// lista todos los grupos existentes en el sistema
        /// </summary>
        /// <returns>Devuelve una lista de todos los grupos del tipo datatable</returns>
        public DataTable ListarGrupos()
        {
            DataTable dataTablaResultado= new DataTable("Grupo");
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
            DataTable dataTable;
            Miconeccion = new Coneccion();
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

                SqlParameter sqlParameter = new SqlParameter
                {
                    ParameterName = "@idGrupo",
                    SqlDbType = SqlDbType.Int,
                    Value = datosGrupo.IdNombre1
                };
                SqlComando.Parameters.Add(sqlParameter);

                SqlParameter sqlparameterStatementType = new SqlParameter
                {
                    ParameterName = "@statementType",
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 20,
                    Value = "Buscar"
                };

                SqlComando.Parameters.Add(sqlparameterStatementType);

                SqlDataAdapter sqltabla = new SqlDataAdapter(SqlComando);
                dataTable = new DataTable();
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
