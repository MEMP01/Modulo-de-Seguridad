using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using System.Data.SqlClient;


namespace Datos
{
    /// <summary>
    ///           clase para asignar un usuario a un grupo
    /// </summary>
    public class DGrupoUsuario
    {
        int idGrupo;
        int Id;
        int idusuario;

        /// <summary>
        /// Contructor de la clase GrupoUsuario
        /// </summary>
        /// <param name="idGrupo">Ingresar el Id del grupo del tipo int</param>
       
        /// <param name="idusuario">Ingresar el id del usuario del tipo Int</param>
        public DGrupoUsuario(int idGrupo, int idusuario)
        {
            IdGrupo = idGrupo;
          // Id1 = id1;
            Idusuario = idusuario;
        }
          /// <summary>
          /// Contructor Vacio De la clase GrupoUsuario
          /// </summary>
        public DGrupoUsuario() { }
        /// <summary>
        /// Encapsulado del campo IDGrupo
        /// </summary>
        public int IdGrupo { get => idGrupo; set => idGrupo = value; }
        /// <summary>
        /// Encapsulado del campo ID
        /// </summary>
        public int Id1 { get => Id; set => Id = value; }
        /// <summary>
        /// Encapsulado del campo    Idusuario
        /// </summary>
        public int Idusuario { get => idusuario; set => idusuario = value; }

        //campos auxiliares
        private SqlCommand SqlComando;

        private Coneccion miConeccion;


    }
}
