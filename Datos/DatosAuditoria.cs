using System;
using System.Data;
using System.Data.SqlClient;


namespace Datos
{
   public class DatosAuditoria

    {
        private string legajo;
        private DateTime fecha;
        private string accion;

        private SqlCommand SqlComando;
        private SqlConnection sqlConneccion;
        private Coneccion Miconeccion;


        public DatosAuditoria() { }
        public DatosAuditoria(string legajo, DateTime fecha, string accion)
        {
            Legajo = legajo;
            Fecha = fecha;
            Accion = accion;
        }

        public string Legajo { get => legajo; set => legajo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Accion { get => accion; set => accion = value; }


        public void NuevoaltaAuditoria(DatosAuditoria datos)
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
                    CommandText = "Sp_InAuditoriaAltas",
                    CommandType = CommandType.StoredProcedure
                };



                SqlParameter id = new SqlParameter
                {
                    ParameterName = "@id",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output

                };

                SqlComando.Parameters.Add(id);

                SqlParameter sqlparametersLegajo= new SqlParameter
                {
                    ParameterName = "@legajo",
                    SqlDbType = SqlDbType.Int,
                    Value = datos.Legajo

                };
                SqlComando.Parameters.Add(sqlparametersLegajo);

                SqlComando.ExecuteNonQuery() ;

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



        }


        public DataTable MostrarAuditoria()
        {
            DataTable dataTablaResultado = new DataTable("AuditoriaAltas");
            SqlConnection sqlConneccion = new SqlConnection();
            Miconeccion = new Coneccion();
            try
            {

                sqlConneccion.ConnectionString = Coneccion.CadenaDeconneccion;
                sqlConneccion.Open();



                SqlDataAdapter sqltabla = new SqlDataAdapter("Select * from AuditoriaAltas", sqlConneccion);

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
    }
}
