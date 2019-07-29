using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;

namespace Vista
{
    /// <summary>
    /// Formulario de gestion de Usuario del Sistema
    /// </summary>
    public partial class FrmGestrionarUsuario : Form

    {
        private bool EsNuevo;
        private bool EsEditar;
        private ControlUsuario controlusuario;
        private static FrmGestion_de_Usuarios_de_Empresa Singleton;


        /// <summary>
        /// Constructor del formulario de gestion de Usuario del Sistema
        /// </summary>
        public FrmGestrionarUsuario()
        {
            InitializeComponent();
        }

        private void GestrionarUsuario_Load(object sender, EventArgs e)
        {

        }
        private void MensanjeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Modulo de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensanjeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Modulo de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void LimpiarTodo()
        {
            txtbDNI.Text = string.Empty;
            txtbBuscarUsuarioPorDNI.Text = string.Empty;
            txtbNombre.Text = string.Empty;
            txtbApellido.Text = string.Empty;
            txtbSexo.Text = string.Empty;
            txtbTelefono.Text = string.Empty;
            txtbEdad.Text = string.Empty;
            txtbEmail.Text = string.Empty;
            txtbPais.Text = string.Empty;
            txtbProvincia.Text = string.Empty;
            txtbDireccion.Text = string.Empty;
            txtbCodigoPostal.Text = string.Empty;
            txtbBuscarUsuarioPorDNI.Text = string.Empty;
        }
        private void Habilitar(bool valor)
        {
            txtbDNI.ReadOnly = !valor;
            txtbNombre.ReadOnly = !valor;
            txtbApellido.ReadOnly = !valor;
            txtbTelefono.ReadOnly = !valor;
            txtbSexo.ReadOnly = !valor;
            txtbEdad.ReadOnly = !valor;
            txtbEmail.ReadOnly = !valor;
            txtbPais.ReadOnly = !valor;
            txtbProvincia.ReadOnly = !valor;
            txtbDireccion.ReadOnly = !valor;
            txtbCodigoPostal.ReadOnly = !valor;
        }

        private void Botones()
        {
            if (EsNuevo || EsEditar)
            {
                Habilitar(true);
                btnNuevo.Enabled = false;
                btnGuardarCambios.Enabled = true;
                btnCancelar.Enabled = true;
                btnEditar.Enabled = false;
            }
            else
            {
                Habilitar(false);
                btnNuevo.Enabled = true;
                btnGuardarCambios.Enabled = false;
                btnCancelar.Enabled = false;
                btnEditar.Enabled = true;
            }
        }


        private void DgvGrillaUsuario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void rbfiltrarPorEstado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbFiltrarPoNombre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkbEliminar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void rbEstadoUsuarioActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RbEstadoUsuarioInactivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbEstadoGrupoActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RbGrupoInactivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtbPrimeraClave_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
