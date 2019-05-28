using Acceso_a_Datos;
using System;
using System.Data;
using System.Data.SqlClient;


namespace Datos
{
    public class DatosGrupo
    {
        private string nombreGrupo;
        private int IdNombre;
        private string estadoGrupo;
        private SqlCommand SqlComando;

        ConneccionSql ConneccionSql;

        public string NombreGrupo { get => nombreGrupo; set => nombreGrupo = value; }
        public int IdNombre1 { get => IdNombre; set => IdNombre = value; }
        public string EstadoGrupo { get => estadoGrupo; set => estadoGrupo = value; }

        public DatosGrupo() { }
        public DatosGrupo(int id, string nombre, string estado)
        {
            NombreGrupo = nombre;
            IdNombre1 = id;
            EstadoGrupo = estado;
        }


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


       public string UpdateGrupos (DatosGrupo grupo)
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

                SqlParameter sqlparametersIdnGrupo= new SqlParameter
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
