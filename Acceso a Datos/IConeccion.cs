using System.Data.Common;
using System.Data;

namespace Acceso_a_Datos
{
    interface IConeccion
    {
        void OpenConneccion();
        void CloseConneccion();
        void ExecuteQueries(string Query);
        DataTable ShowInDataGridView(string Query);
        DbDataReader DbDataReader(string Query);

    }
}
