using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{     /// <summary>
/// Clase de la capa datos de auditorias
/// </summary>
    public class Auditorias
    {
        //campos auxiliares
        private SqlCommand SqlComando;
        private SqlConnection sqlConneccion;
        private Coneccion miConeccion;
        private string rta;
           /// <summary>
           /// Metodo para auditar los Login
           /// </summary>
        public void AuditoriaLogin()
        {
            DLogin dLogin = new DLogin();
            miConeccion = new Coneccion();
            SqlConnection sqlConnection = new SqlConnection();

            try
            {

                sqlConnection.ConnectionString = Coneccion.CadenaDeconneccion;
                sqlConnection.Open();
                //string commandString = "insert into "


            }
            catch (Exception ex)
            {
                rta = ex.Message;
            }





        }
    }
}
