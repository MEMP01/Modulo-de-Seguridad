using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Acceso_a_Datos
{                      /// <summary>
/// 
/// </summary>
    public class ConneccionSql : IConeccion
    {
        private readonly string ConnecionString = @"Data Source=LAPTOP-J71K94AN\SQLEXPRESS;Initial Catalog=Modulo_DeSeguridad;Integrated Security=True";
        private SqlConnection _conneccionSqlServer;

        /// <summary>
        /// 
        /// </summary>
        public string ConnecionString1
        {
            get
            {
                return ConnecionString;
            }
        }

        public SqlConnection ConneccionSqlServer { get => _conneccionSqlServer; set => _conneccionSqlServer = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string ObtenerConeccion()
        {
            return ConnecionString1;
        }
        /// <summary>
        /// 
        /// </summary>
        public void OpenConneccion()
        {
            ConneccionSqlServer = new SqlConnection(ObtenerConeccion());
            ConneccionSqlServer.Open();
        }
        /// <summary>
        /// 
        /// </summary>
        public void CloseConneccion() => ConneccionSqlServer.Close();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Query"></param>
        /// <returns></returns>
        public DbDataReader DbDataReader(string Query)
        {
            SqlCommand cmd = new SqlCommand(Query, ConneccionSqlServer);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Query"></param>
        public void ExecuteQueries(string Query)
        {
            SqlCommand cmd = new SqlCommand(Query, ConneccionSqlServer);
            cmd.ExecuteNonQuery(); ;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Query"></param>
        /// <returns></returns>
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
