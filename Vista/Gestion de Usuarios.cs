using Control;
using System;
using System.Data;
using System.Windows.Forms;



namespace Vista
{
    public partial class FrmGestion_de_Usuarios_de_Empresa : Form
    {

        private bool EsNuevo;
        private bool EsEditar;
        private ControlUsuarios ControlDeUsuarios;
        private static FrmGestion_de_Usuarios_de_Empresa Singleton;

        public FrmGestion_de_Usuarios_de_Empresa()
        {
            InitializeComponent();
            ttMensajeAyuda.SetToolTip(txtbNombre, "Ingrese el nombre del Usuario");
            ttMensajeAyuda.SetToolTip(txtbApellido, "Ingrese el apellido del Usuario");
            ttMensajeAyuda.SetToolTip(txtbSexo, "Ingrese el sexo del Usuario");
            ttMensajeAyuda.SetToolTip(txtbEdad, "Ingrese la edad del Usuario");
            ttMensajeAyuda.SetToolTip(txtbEmail, "Ingrese el mail del Usuario");
            ttMensajeAyuda.SetToolTip(txtbTelefono, "Ingrese el telefono del usuario");
            ttMensajeAyuda.SetToolTip(txtbPais, "Ingrese el pais de origen del Usuario");
            ttMensajeAyuda.SetToolTip(txtbProvincia, "ingrese la provincia de origen del Usuario");
            ttMensajeAyuda.SetToolTip(txtbDireccion, "Ingrese la direccion de recidencia actual del Usuario");
            ttMensajeAyuda.SetToolTip(txtbCodigoPostal, "Ingrese el codigo postal actual del Usuario");
            ttMensajeAyuda.SetToolTip(rbEstadoActivo, "Seleccione esta opcion para setear el estado del Usuario como Activo");
            ttMensajeAyuda.SetToolTip(RbGrupoInactivo, "Seleccione esta opcion para setear el estado del Usuario como Inactivo ");
            ttMensajeAyuda.SetToolTip(txtbDNI, "Aqui Aparece el DNI del Usuario");
            ttMensajeAyuda.SetToolTip(cmbEstadoUsuario, "Seleccione un estado de Usuario como filtro de busqueda");
            ttMensajeAyuda.SetToolTip(txtbBuscarUsuarioPorDNI, "Ingrese un DNI de Usuario como filtro de busqueda");
            ttMensajeAyuda.SetToolTip(btnFiltrar, "Ingrese un DNI de Usuario y/o un estado de Usuario para realizar la busqueda");
            ttMensajeAyuda.SetToolTip(btnNuevo, "Click para ingresar datos para un nuevo Usuario al Sistema");
            ttMensajeAyuda.SetToolTip(btnGuardarCambios, "Click para confirmar datos del Usuario del Sistema");
            ttMensajeAyuda.SetToolTip(btnEditar, "Click para modificar datos del Usuario del sistema");
            ttMensajeAyuda.SetToolTip(chkbEliminar, "Click aquí para habilitar el boton Eliminar");
            ttMensajeAyuda.SetToolTip(btnCancelar, "Click aquí para deshacer cambios");
            ttMensajeAyuda.SetToolTip(btnSalirGestioGrupo, "Click aquí para regresar al formulario principal");
            ttMensajeAyuda.SetToolTip(rbFiltrarPoNombre, "Seleccione esta opcion para filtrar por Nombre");
            ttMensajeAyuda.SetToolTip(rbfiltrarPorEstado, "Seleccione esta opcion para filtrar por DNI");
        }
        public FrmGestion_de_Usuarios_de_Empresa InstanciaSingleton
        {
            get
            {
                if (Singleton == null)
                {
                    Singleton = new FrmGestion_de_Usuarios_de_Empresa();
                }
                return Singleton;
            }
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
            txtbEdad.Text = string.Empty;
            txtbEmail.Text = string.Empty;
            txtbPais.Text = string.Empty;
            txtbProvincia.Text = string.Empty;
            txtbDireccion.Text = string.Empty;
            txtbCodigoPostal.Text = string.Empty;
        }
        private void Habilitar(bool valor)
        {
            txtbDNI.ReadOnly = !valor;
            txtbNombre.ReadOnly = !valor;
            txtbApellido.ReadOnly = !valor;
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
        private void OcultarColumnas()
        {
            DgvGrillaUsuarios.Columns[0].Visible = false;
            DgvGrillaUsuarios.Columns[1].Visible = false;
        }
        public void LlenarGrilla()
        {
            ControlDeUsuarios = new ControlUsuarios();
            DgvGrillaUsuarios.DataSource = ControlDeUsuarios.CListarUsuario();
            lbnumeroDeRegistros.Text = Convert.ToString(DgvGrillaUsuarios.Rows.Count);
        }

        private void Filtrar()
        {
            DataTable dt = DgvGrillaUsuarios.DataSource as DataTable;
            string query = string.Format("EstadoDelUsuario = '{0}'", cmbEstadoUsuario.Text);
            dt.DefaultView.RowFilter = query;
            lbnumeroDeRegistros.Text = Convert.ToString(DgvGrillaUsuarios.Rows.Count);

        }

        private void Gestion_de_Usuarios_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            Habilitar(false);
            LlenarGrilla();
            Botones();
            chkbEliminar.Checked = false;

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmGestion_de_Usuarios_de_Empresa gestion_De_Usuarios_De_Empresa = new FrmGestion_de_Usuarios_de_Empresa
            {
                EsNuevo = true
            };
            gestion_De_Usuarios_De_Empresa.InstanciaSingleton.Show();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente desea eliminar los registros", "Gestion de Grupos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    string DNI = "";
                    string rta = "";

                    foreach (DataGridViewRow row in DgvGrillaUsuarios.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            DNI = Convert.ToString(row.Cells[1].Value);

                            ControlDeUsuarios = new ControlUsuarios();
                            rta = ControlDeUsuarios.CEliminarUsuario(Convert.ToInt32(DNI));

                            if (rta.Equals("OK"))
                            {
                                MensanjeOK("Se elimino correctamente el registro");
                            }
                            else
                            {
                                MensanjeError("No se pudo eliminar correctamente el registro" + rta);
                            }

                        }

                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LlenarGrilla();
            chkbEliminar.Checked = false;

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {

        }

        private void groupB1_Enter(object sender, EventArgs e)
        {

        }

        private void rbEstadoActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RbGrupoInactivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbNombredeGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void RbfiltrarPorEstado_CheckedChanged(object sender, EventArgs e)
        {
            rbFiltrarPoNombre.Checked = false;
        }

        private void RbFiltrarPoNombre_CheckedChanged(object sender, EventArgs e)
        {
            rbfiltrarPorEstado.Checked = false;
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
            LlenarGrilla();
        }

        private void CmbEstadoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DgvGrillaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvGrillaUsuarios.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkboxEliminar = (DataGridViewCheckBoxCell)DgvGrillaUsuarios.Rows[e.RowIndex].Cells["Eliminar"];
                chkboxEliminar.Value = !Convert.ToBoolean(chkboxEliminar.Value);
            }
        }

        private void ChkbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbEliminar.Checked)
            {
                DgvGrillaUsuarios.Columns[0].Visible = true;
            }
            else
            {
                DgvGrillaUsuarios.Columns[0].Visible = false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {

        }

        private void btnSalirGestioGrupo_Click(object sender, EventArgs e)
        {

        }

        private void DgvGrillaUsuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
