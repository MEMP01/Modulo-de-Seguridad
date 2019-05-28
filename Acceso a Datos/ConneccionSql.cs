using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Acceso_a_Datos
{
    public class ConneccionSql : IConeccion
    {
        private readonly string ConnecionString = "@Data Source=LAPTOP-J71K94AN/SQLEXPRESSS;Initial Catalog=ModuloDeSeguridad;Integrated Security=True;Asynchronous Processing=True;MultipleActiveResultSets=True;TrustServerCertificate=False;Column Encryption Setting=Enabled";
        SqlConnection conneccionSqlServer;

        public string ConnecionString1
        {
            get
            {
                return ConnecionString;
            }
        }

        public string ObtenerConeccion()
        {
            return ConnecionString1;
        }
        public void OpenConneccion()
        {
            conneccionSqlServer = new SqlConnection(ObtenerConeccion());
            conneccionSqlServer.Open();
        }

        public void CloseConneccion()
        {
            conneccionSqlServer.Close();
        }


        public DbDataReader DbDataReader(string Query)
        {
            SqlCommand cmd = new SqlCommand(Query, conneccionSqlServer);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;

        }

        public void ExecuteQueries(string Query)
        {
            SqlCommand cmd = new SqlCommand(Query, conneccionSqlServer);
            cmd.ExecuteNonQuery(); ;
        }


        public DataTable ShowInDataGridView(string Query)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Query, ObtenerConeccion());
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            DataTable DataTable = dataSet.Tables[0];
            return DataTable;



        }
    }
}
