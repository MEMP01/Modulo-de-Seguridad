using Control;
using System;
using System.Data;
using System.Windows.Forms;



namespace Vista

{
    /// <summary>
    ///       Clase FrmGestion_de_Usuarios_de_Empresa
    /// </summary>
    public partial class FrmGestion_de_Usuarios_de_Empresa : Form
    {

        private bool EsNuevo;
        private bool EsEditar;
        private ControlUsuarios ControlDeUsuarios;
        private static FrmGestion_de_Usuarios_de_Empresa Singleton;

        /// <summary>
        /// Constructor de la clase FrmGestion_de_Usuarios_de_Empresa
        /// </summary>
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
            ttMensajeAyuda.SetToolTip(RbUsuarioInactivo, "Seleccione esta opcion para setear el estado del Usuario como Inactivo ");
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
            ttMensajeAyuda.SetToolTip(rb_FiltrarPorDni, "Seleccione esta opcion para filtrar por Nombre");
            ttMensajeAyuda.SetToolTip(rbfiltrarPorEstado, "Seleccione esta opcion para filtrar por DNI");
        }
        /// <summary>
        /// Singleton de FrmGestion_de_Usuarios_de_Empresa
        /// </summary>
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
        private void OcultarColumnas()
        {
            DgvGrillaUsuarios.Columns[0].Visible = false;
            DgvGrillaUsuarios.Columns[1].Visible = false;
        }
        /// <summary>
        /// Metodo para llenar la grilla
        /// </summary>
        public void LlenarGrilla()
        {
            ControlDeUsuarios = new ControlUsuarios();
            DgvGrillaUsuarios.DataSource = ControlDeUsuarios.CListarUsuario();
            lbnumeroDeRegistros.Text = Convert.ToString(DgvGrillaUsuarios.Rows.Count);
        }

        private void Filtrar()
        {
            try
            {
                if (cmbEstadoUsuario.Text == "Activo")
                {
                    DataTable dt = DgvGrillaUsuarios.DataSource as DataTable;
                    string query = string.Format("Estado = '{0}'", 1);
                    dt.DefaultView.RowFilter = query;
                    lbnumeroDeRegistros.Text = Convert.ToString(DgvGrillaUsuarios.Rows.Count);
                }
                if (cmbEstadoUsuario.Text == "Inactivo")
                {
                    DataTable dt = DgvGrillaUsuarios.DataSource as DataTable;
                    string query = string.Format("Estado = '{0}'", 2);
                    dt.DefaultView.RowFilter = query;
                    lbnumeroDeRegistros.Text = Convert.ToString(DgvGrillaUsuarios.Rows.Count);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }      

        private void Gestion_de_Usuarios_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            Habilitar(false);
            LlenarGrilla();
            Botones();
            chkbEliminar.Checked = false;
            DgvGrillaUsuarios.Columns[0].Visible = false;

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

        //  private void BtnSalir_Click(object sender, EventArgs e)
        //  {
        //      Singleton = null;
        //      Close();
        //  }

        private void GroupB1_Enter(object sender, EventArgs e)
        {

        }

        private void RbEstadoActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RbGrupoInactivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CmbNombredeGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtbCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void RbfiltrarPorEstado_CheckedChanged(object sender, EventArgs e)
        {
            rb_FiltrarPorDni.Checked = false;
            txtbBuscarUsuarioPorDNI.Enabled = false;
            cmbEstadoUsuario.Enabled = true;
        }

        

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbBuscarUsuarioPorDNI.Enabled == true)
                {
                    string DNI = txtbBuscarUsuarioPorDNI.Text;
                    ControlDeUsuarios = new ControlUsuarios();
                    DgvGrillaUsuarios.DataSource = ControlDeUsuarios.CBuscarUsuario(Convert.ToInt32(DNI));
                }
                else
                {
                    Filtrar();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            EsNuevo = true;
            EsEditar = false;
            Botones();
            LimpiarTodo();
            Habilitar(true);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (!txtbDNI.Text.Equals(""))
            {
                EsEditar = true;
                Botones();
                Habilitar(true);
            }
            else
            {
                MensanjeError("Debe selecciona primero el registro a modificar");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            EsNuevo = false;
            EsEditar = false;
            Botones();
            LimpiarTodo();
            Habilitar(false);
        }

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                int estadodelusuario = 0;
                string estado;

                ControlDeUsuarios = new ControlUsuarios();

                if (txtbDNI.Text == string.Empty)
                {
                    MensanjeError("Falta ingresar algunos datos, estos serán remarcados");
                    ErrorIcono.SetError(txtbDNI, "Ingrese un DNI para el Usuario");
                }
                if (txtbNombre.Text == string.Empty)
                {
                    MensanjeError("Falta ingresar algunos datos, estos serán remarcados");
                    ErrorIcono.SetError(txtbNombre, "Ingrese un nombre para el Usuario");
                }
                if (txtbApellido.Text == string.Empty)
                {
                    MensanjeError("Falta ingresar algunos datos, estos serán remarcados");
                    ErrorIcono.SetError(txtbApellido, "Ingrese un apellido para el Usuario");
                }
                if (txtbSexo.Text == string.Empty)
                {
                    MensanjeError("Falta ingresar algunos datos, estos serán remarcados");
                    ErrorIcono.SetError(txtbSexo, "Ingrese el sexo del Usuario");
                }
                if (txtbEdad.Text == string.Empty)
                {
                    MensanjeError("Falta ingresar algunos datos, estos serán remarcados");
                    ErrorIcono.SetError(txtbEdad, "Ingrese la edad del Usuario");
                }
                if (txtbEmail.Text == string.Empty)
                {
                    MensanjeError("Falta ingresar algunos datos, estos serán remarcados");
                    ErrorIcono.SetError(txtbEmail, "Ingrese un Email para el Usuario");
                }
                if (txtbTelefono.Text == string.Empty)
                {
                    MensanjeError("Falta ingresar algunos datos, estos serán remarcados");
                    ErrorIcono.SetError(txtbTelefono, "Ingrese un telefono para el Usuario");
                }
                if (txtbPais.Text == string.Empty)
                {
                    MensanjeError("Falta ingresar algunos datos, estos serán remarcados");
                    ErrorIcono.SetError(txtbPais, "Ingrese un pais para el Usuario");
                }
                if (txtbProvincia.Text == string.Empty)
                {
                    MensanjeError("Falta ingresar algunos datos, estos serán remarcados");
                    ErrorIcono.SetError(txtbProvincia, "Ingrese un provincia para el Usuario");
                }
                if (txtbDireccion.Text == string.Empty)
                {
                    MensanjeError("Falta ingresar algunos datos, estos serán remarcados");
                    ErrorIcono.SetError(txtbDireccion, "Ingrese una direccion para el Usuario");
                }
                if (txtbCodigoPostal.Text == string.Empty)
                {
                    MensanjeError("Falta ingresar algunos datos, estos serán remarcados");
                    ErrorIcono.SetError(txtbCodigoPostal, "Ingrese un codigo postal para el Usuario");
                }

                else
                {
                    if (EsNuevo)
                    {
                        estado = "";
                        if (rbEstadoActivo.Checked)
                        {
                            estado = "Activo";
                            estadodelusuario = 1;
                            MessageBox.Show("aca activo" + estado);

                        }
                       if (RbUsuarioInactivo.Checked)
                        {
                            estado = "Inactivo";
                            estadodelusuario = 2;
                            MessageBox.Show("aca inactivo" + estado);
                        }

                        MessageBox.Show("aca bien" + estado);
                        rpta = ControlDeUsuarios.CAltaUsuario(Convert.ToInt32(txtbDNI.Text),
                            txtbApellido.Text.Trim(), txtbNombre.Text.Trim(), Convert.ToChar(txtbSexo.Text), Convert.ToInt32(txtbEdad.Text),
                            txtbEmail.Text.Trim(), Convert.ToInt32(txtbTelefono.Text), txtbPais.Text.Trim(), txtbProvincia.Text.Trim(),
                           txtbDireccion.Text, Convert.ToInt32(txtbCodigoPostal.Text), estadodelusuario);
                    }
                    else
                    {
                        estado = "";


                        if (rbEstadoActivo.Checked)
                        {
                            estado = "Activo";
                            estadodelusuario = 1;
                            MessageBox.Show("aca activo" + estado);
                        }
                        if (RbUsuarioInactivo.Checked)
                        {
                            estado = "Inactivo";
                            estadodelusuario = 2;
                            MessageBox.Show("aca inactivo" + estado);
                        }


                        rpta = ControlDeUsuarios.CModificacionUsuario(Convert.ToInt32(txtbDNI.Text),
                            txtbApellido.Text.Trim(), txtbNombre.Text.Trim(), Convert.ToChar(txtbSexo.Text), Convert.ToInt32(txtbEdad.Text),
                            txtbEmail.Text.Trim(), Convert.ToInt32(txtbTelefono.Text), txtbPais.Text.Trim(), txtbProvincia.Text.Trim(),
                           txtbDireccion.Text, Convert.ToInt32(txtbCodigoPostal.Text), estadodelusuario);
                        // tabFrmGestionDegrupo.SelectedIndex = 0;

                    }

                    if (rpta.Equals("OK"))
                    {

                        if (EsNuevo)
                        {
                            MensanjeOK("Se ingreso exitosamente un nuevo grupo al sistema");
                        }
                        else
                        {

                            MensanjeOK("Se Modifico exitosamente el grupo dado");
                        }
                    }
                    else if (rpta.Equals("No se pudo Ingresar el registro"))
                    {

                        MensanjeError(rpta);
                    }

                    EsNuevo = false;
                    EsEditar = false;
                    Botones();
                    LimpiarTodo();
                    LlenarGrilla();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }


        }

        private void BtnSalirGestioGrupo_Click(object sender, EventArgs e)
        {
            Singleton = null;
            Close();
        }

        private void DgvGrillaUsuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void DgvGrillaUsuarios_DoubleClick(object sender, EventArgs e)
        {
            txtbDNI.Text = Convert.ToString(DgvGrillaUsuarios.CurrentRow.Cells["DNI"].Value);
            txtbApellido.Text = Convert.ToString(DgvGrillaUsuarios.CurrentRow.Cells["Apellido"].Value);
            txtbNombre.Text = Convert.ToString(DgvGrillaUsuarios.CurrentRow.Cells["Nombre"].Value);
            txtbSexo.Text = Convert.ToString(DgvGrillaUsuarios.CurrentRow.Cells["Sexo"].Value);
            txtbEdad.Text = Convert.ToString(DgvGrillaUsuarios.CurrentRow.Cells["Edad"].Value);
            txtbEmail.Text = Convert.ToString(DgvGrillaUsuarios.CurrentRow.Cells["Email"].Value);
            txtbTelefono.Text = Convert.ToString(DgvGrillaUsuarios.CurrentRow.Cells["Telefono"].Value);
            txtbPais.Text = Convert.ToString(DgvGrillaUsuarios.CurrentRow.Cells["Pais"].Value);
            txtbProvincia.Text = Convert.ToString(DgvGrillaUsuarios.CurrentRow.Cells["Provincia"].Value);
            txtbDireccion.Text = Convert.ToString(DgvGrillaUsuarios.CurrentRow.Cells["Direccion"].Value);
            txtbCodigoPostal.Text = Convert.ToString(DgvGrillaUsuarios.CurrentRow.Cells["CodigoPostal"].Value);
            //9  txtbDNI.Text = Convert.ToString(DgvGrillaUsuarios.CurrentRow.Cells["Estado"].Value);
            if (DgvGrillaUsuarios.CurrentRow.Cells["Estado"].Value.Equals("1"))
            {
                rbEstadoActivo.Checked = true;
            }
            else
            {
                RbUsuarioInactivo.Checked = true;
            }
            tabFrmGestionDeUsuarios.SelectedIndex = 1;


        }

        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente desea eliminar los registros", "Gestion de Usuarios de Empresa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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

      

        private void Rb_FiltrarPorDni_CheckedChanged(object sender, EventArgs e)
        {
            rbfiltrarPorEstado.Checked = false;
            txtbBuscarUsuarioPorDNI.Enabled = true;
            cmbEstadoUsuario.Enabled = false;
        }

        private void txtbBuscarUsuarioPorDNI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
