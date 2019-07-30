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
            txtbBuscaUsuarioPorDni.Text = string.Empty;
            txtbLegajo.Text = string.Empty;
            txtbNombreDelUsuario.Text = string.Empty;
            txtbClave.Text = string.Empty;
           
            txtbCodigo.Text = string.Empty;
            
        }
        private void Habilitar(bool valor)
        {
            txtbDNI.ReadOnly = !valor;
            txtbLegajo.ReadOnly = !valor;
            txtbNombreDelUsuario.ReadOnly = !valor;
            txtbClave.ReadOnly = !valor;
            txtbCodigo.ReadOnly = !valor;
         
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

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void RbfiltrarPorEstado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RbFiltrarPoNombre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkbEliminar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnListar_Click(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RbEstadoUsuarioActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RbEstadoUsuarioInactivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RbEstadoGrupoActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RbGrupoInactivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TxtbPrimeraClave_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
