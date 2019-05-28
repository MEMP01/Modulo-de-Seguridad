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


        private SqlCommand SqlComando;
        ConneccionSql ConneccionSql;

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
        /// <param name="grupo">ingresar objeto del tipo grupo</param>
        /// <returns>respuesta Si o No fue exitosa la operacion</returns>
        public string IngresarGrupo(DatosGrupo grupo)
        {
            string rta = "";
            ConneccionSql = new ConneccionSql();

            try
            {


                ConneccionSql.OpenConneccion();
                SqlConnection sqlConnection = new SqlConnection(ConneccionSql.ObtenerConeccion());
                SqlComando = new SqlCommand
                {
                    Connection = sqlConnection,
                    CommandText = "Insert",
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


                rta = SqlComando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Ingresar el registro ";

            }
            catch (Exception ex)
            {
                rta = ex.Message;
            }
            finally
            {
                ConneccionSql.CloseConneccion();
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
            ConneccionSql = new ConneccionSql();

            try
            {


                ConneccionSql.OpenConneccion();
                SqlConnection sqlConnection = new SqlConnection(ConneccionSql.ObtenerConeccion());
                SqlComando = new SqlCommand
                {
                    Connection = sqlConnection,
                    CommandText = "Update",
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


                rta = SqlComando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Ingresar el registro ";

            }
            catch (Exception ex)
            {
                rta = ex.Message;
            }
            finally
            {
                ConneccionSql.CloseConneccion();
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
            ConneccionSql = new ConneccionSql();

            try
            {


                ConneccionSql.OpenConneccion();
                SqlConnection sqlConnection = new SqlConnection(ConneccionSql.ObtenerConeccion());
                SqlComando = new SqlCommand
                {
                    Connection = sqlConnection,
                    CommandText = "Delete",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter sqlparametersIdnGrupo = new SqlParameter
                {
                    ParameterName = "@idGrupo",
                    SqlDbType = SqlDbType.Int,

                    Value = grupo.IdNombre1

                };

                SqlComando.Parameters.Add(sqlparametersIdnGrupo);



                rta = SqlComando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Ingresar el registro ";

            }
            catch (Exception ex)
            {
                rta = ex.Message;
            }
            finally
            {
                ConneccionSql.CloseConneccion();
            }
            return rta;

        }


              /// <summary>
              /// lista todos los grupos existentes en el sistema
              /// </summary>
              /// <returns>Devuelve una lista de todos los grupos del tipo datatable</returns>
        public DataTable ListarGrupos()
        {
            DataTable dataTable;
            ConneccionSql = new ConneccionSql();
            try
            {

                ConneccionSql.OpenConneccion();
                SqlConnection sql = new SqlConnection(ConneccionSql.ObtenerConeccion());
                SqlComando = new SqlCommand
                {
                    Connection = sql,
                    CommandText = "select",
                    CommandType = CommandType.StoredProcedure
                };
                SqlDataAdapter sqltabla = new SqlDataAdapter(SqlComando);
                dataTable = new DataTable();
                sqltabla.Fill(dataTable);






            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error de Listado", ex);
            }
            finally
            {
                ConneccionSql.CloseConneccion();
            }
            return dataTable;


        }
         /// <summary>
         /// buscar por ID un grupo en particular
         /// </summary>
         /// <param name="datosGrupo">Ingrese el Id del grupo a encontrar</param>
         /// <returns>devuelve el grupo </returns>
        public DataTable BuscarGrupos(DatosGrupo datosGrupo)
        {
            DataTable dataTable;
            ConneccionSql = new ConneccionSql();
            try
            {
                ConneccionSql.OpenConneccion();
                SqlConnection sql = new SqlConnection(ConneccionSql.ObtenerConeccion());
                SqlComando = new SqlCommand
                {
                    Connection = sql,
                    CommandText = "Buscar",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter sqlParameter = new SqlParameter
                {
                    ParameterName = "@idGrupo",
                    SqlDbType = SqlDbType.Int,
                    Value = datosGrupo.IdNombre1
                };
                SqlComando.Parameters.Add(sqlParameter);

                SqlDataAdapter sqltabla = new SqlDataAdapter(SqlComando);
                dataTable = new DataTable();
                sqltabla.Fill(dataTable);



            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error de Listado", ex);
            }
            finally
            {
                ConneccionSql.CloseConneccion();
            }

            return dataTable;


        }





    }
}
