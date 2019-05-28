using Datos;
using System.Data;

namespace Control
{       /// <summary>
/// Controladora de Grupo
/// </summary>
    public class ControlGrupo
    {
        private DatosGrupo datosGrupo;
        /// <summary>
        /// Encapsulo un campo del tipo <see cref="DatosGrupo"/>
        /// </summary>
        public DatosGrupo DatosGrupo { get => datosGrupo; set => datosGrupo = value; }

        /// <summary>
        /// Controladora para ingresar registros de grupo
        /// </summary>
        /// <param name="NombreDelGrupo">Ingresar el nombre del grupo</param>
        /// <param name="Estado">ingresar el estado del grupo</param>
        /// <returns>respuesta Si o No fue exitosa la operacion</returns>
        public string InsertGrupo(string NombreDelGrupo, string Estado)
        {
            DatosGrupo = new DatosGrupo
            {
                NombreGrupo = NombreDelGrupo,
                EstadoGrupo = Estado


            };
            return DatosGrupo.IngresarGrupo(DatosGrupo);

        }
        /// <summary>
        ///  Controladora para modificacion de registros de grupo
        /// </summary>
        /// <param name="idGrupo">ingresar la id del Grupo</param>
        /// <param name="nombredelGrupo">Ingresar el nombre del grupo</param>
        /// <param name="estado"> ingresar el estado del grupo</param>
        /// <returns>respuesta Si o No fue exitosa la operacion</returns>
        public string UpdateGrupo(int idGrupo, string nombredelGrupo, string estado)
        {
            DatosGrupo = new DatosGrupo
            {
                IdNombre1 = idGrupo,
                NombreGrupo = nombredelGrupo,
                EstadoGrupo = estado
            };
            return DatosGrupo.UpdateGrupos(DatosGrupo);
        }

        /// <summary>
        ///  Controladora para Eliminacion de registros de grupo
        /// </summary>
        /// <param name="id_grupo">ingresar la id del Grupo</param>
        /// <returns>respuesta Si o No fue exitosa la operacion</returns>
        public string EliminarGrupo(int id_grupo)
        {
            DatosGrupo = new DatosGrupo
            {
                IdNombre1 = id_grupo
            };
            return DatosGrupo.EliminarGrupo(DatosGrupo);
        }

        /// <summary>
        ///  Controladora para Listar de registros de grupo
        /// </summary>
        /// <returns>Devuelve todos los Grupos en el sistema</returns>
        public DataTable ListarGrupos()
        {
            DatosGrupo = new DatosGrupo();
            return DatosGrupo.ListarGrupos();

        }

        /// <summary>
        ///  Controladora para Buscar un  grupo en el sistema mediante su ID
        /// </summary>
        /// <param name="id_grupo"></param>
        /// <returns>Devuelve el grupo si existe</returns>
        public DataTable BuscarGrupo(int id_grupo)
        {
            DatosGrupo = new DatosGrupo
            {
                IdNombre1 = id_grupo
            };
            return DatosGrupo.BuscarGrupos(DatosGrupo);
        }
    }
}
