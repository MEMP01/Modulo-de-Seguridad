using Datos;
using System.Data;
namespace Control
{
    public class ControlAuditoria
    {
        private DatosAuditoria datosAuditoria;

        public ControlAuditoria()
        {

        }

        public ControlAuditoria(DatosAuditoria datosAuditoria)
        {
            this.DatosAuditoria = datosAuditoria;
        }

        public DatosAuditoria DatosAuditoria { get => datosAuditoria; set => datosAuditoria = value; }

        public void nuevoauditoria(ControlGrupo controlGrupo)
        {

        }
    }
}
