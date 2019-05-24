using Datos;
using System.Data;

namespace Control
{
    public class ControlGrupo
    {
        DatosGrupo datosGrupo;

        public string InsertGrupo(string NombreDelGrupo, string Estado)
        {
            datosGrupo = new DatosGrupo
            {
                NombreGrupo = NombreDelGrupo    ,
                EstadoGrupo=Estado

              
            };
            return datosGrupo.IngresarGrupo(datosGrupo);

        }
         public string UpdateGrupo (int idGrupo,string nombredelGrupo, string estado)
        {
            datosGrupo = new DatosGrupo
            {
                IdNombre1 = idGrupo,
                NombreGrupo = nombredelGrupo,
                EstadoGrupo = estado
            };
            return datosGrupo.UpdateGrupos(datosGrupo);
        }

        public string EliminarGrupo(int id_grupo)
        {
            datosGrupo = new DatosGrupo
            {
                IdNombre1 = id_grupo
            };
            return datosGrupo.EliminarGrupo(datosGrupo);
        }

       public DataTable ListarGrupos()
        {
            datosGrupo = new DatosGrupo();
            return datosGrupo.ListarGrupos();

        }

        public DataTable BuscarGrupo(int id_grupo)
        {
            datosGrupo = new DatosGrupo
            {
                IdNombre1 = id_grupo
            };
            return datosGrupo.BuscarGrupos(datosGrupo.IdNombre1);
        }
    }
}
