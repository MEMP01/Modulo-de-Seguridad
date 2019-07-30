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
        private static FrmGestrionarUsuario Singleton;


        /// <summary>
        /// Constructor del formulario de gestion de Usuario del Sistema
        /// </summary>
        public FrmGestrionarUsuario()
        {
            InitializeComponent();

            ttMensajeAyuda.SetToolTip(rbEstadoUsuarioActivo, "Seleccione esta opcion para setear el estado del Usuario como Activo");
            ttMensajeAyuda.SetToolTip(RbEstadoUsuarioInactivo, "Seleccione esta opcion para setear el estado del Usuario como Inactivo ");
            ttMensajeAyuda.SetToolTip(cmbDni, "Aqui Aparece el DNI del Usuario");
            ttMensajeAyuda.SetToolTip(txtbClave, "Aqui ingrese la clave o password");
            ttMensajeAyuda.SetToolTip(txtbLegajo, "Aqui aparece el legajo del usuario");
            ttMensajeAyuda.SetToolTip(txtbNombreDelUsuario, "Ingrese el nombre del usuario del sistema");

            ttMensajeAyuda.SetToolTip(cmbEstadoUsuario, "Seleccione un estado de Usuario como filtro de busqueda");
            ttMensajeAyuda.SetToolTip(btnFiltrar, "Ingrese un DNI de Usuario y/o un estado de Usuario para realizar la busqueda");
            ttMensajeAyuda.SetToolTip(btnNuevo, "Click para ingresar datos para un nuevo Usuario al Sistema");
            ttMensajeAyuda.SetToolTip(btnGuardarCambios, "Click para confirmar datos del Usuario del Sistema");
            ttMensajeAyuda.SetToolTip(btnEditar, "Click para modificar datos del Usuario del sistema");
            ttMensajeAyuda.SetToolTip(chkbEliminar, "Click aquí para habilitar el boton Eliminar");
            ttMensajeAyuda.SetToolTip(btnCancelar, "Click aquí para deshacer cambios");
            ttMensajeAyuda.SetToolTip(btnSalir, "Click aquí para regresar al formulario principal");
            ttMensajeAyuda.SetToolTip(rbFiltrarPoDni, "Seleccione esta opcion para filtrar por Nombre");
            ttMensajeAyuda.SetToolTip(rbfiltrarPorEstado, "Seleccione esta opcion para filtrar por DNI");
        }


        private void GestrionarUsuario_Load(object sender, EventArgs e)
        {
            Habilitar(false);
            LlenarGrilla();
            Botones();
            chkbEliminar.Checked = false;
            DgvGrillaUsuario.Columns[0].Visible = false;
            LlenarCOmbobox();

        }
        
        private void LlenarCOmbobox()
        {
            controlusuario = new ControlUsuario();

            cmbDni.DataSource = controlusuario.CLLenarComboDNI();
            cmbDni.DisplayMember = "DNI";
            cmbDni.ValueMember = "DNI";

        }

        /// <summary>
        /// Singleton de FrmGestion_de_Usuarios_de_Empresa
        /// </summary>
        public FrmGestrionarUsuario InstanciaSingleton
        {
            get
            {
                if (Singleton == null)
                {
                    Singleton = new FrmGestrionarUsuario();
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
          
            txtbBuscaUsuarioPorDni.Text = string.Empty;
            txtbLegajo.Text = string.Empty;
            txtbNombreDelUsuario.Text = string.Empty;
            txtbClave.Text = string.Empty;
           
            txtbCodigo.Text = string.Empty;
            
        }
        private void Habilitar(bool valor)
        {
            
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

        /// <summary>
        /// metodo para llenar grilla DgvGrillaUsuario con los usuarios del sistema 
        /// </summary>
        public void LlenarGrilla()
        {
            controlusuario = new ControlUsuario();
            DgvGrillaUsuario.DataSource = controlusuario.CListarusuariosDelSistema();
            lbCantidadDeRegistros.Text = Convert.ToString(DgvGrillaUsuario.Rows.Count);
        }

        /// <summary>
        /// metodo Para Filtrar por estado
        /// </summary>
        private void Filtrar()
        {
            try
            {
                if (cmbEstadoUsuario.Text == "Activo")
                {
                    DataTable dt = DgvGrillaUsuario.DataSource as DataTable;
                    string query = string.Format("[Estado del Usuario] = '{0}'", cmbEstadoUsuario.Text);
                    dt.DefaultView.RowFilter = query;
                    lbnumeroDeRegistros.Text = Convert.ToString(DgvGrillaUsuario.Rows.Count);
                }
                if (cmbEstadoUsuario.Text == "Inactivo")
                {
                    DataTable dt = DgvGrillaUsuario.DataSource as DataTable;
                    string query = string.Format("[Estado del Usuario] = '{0}'", cmbEstadoUsuario.Text);
                    dt.DefaultView.RowFilter = query;
                    lbnumeroDeRegistros.Text = Convert.ToString(DgvGrillaUsuario.Rows.Count);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbBuscaUsuarioPorDni.Enabled == true)
                {
                    string DNI = txtbBuscaUsuarioPorDni.Text;
                    controlusuario = new ControlUsuario();
                    DgvGrillaUsuario.DataSource = controlusuario.CBuscarUsuarioDelSistema(Convert.ToInt32(DNI));
                }
                else
                {
                    Filtrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RbfiltrarPorEstado_CheckedChanged(object sender, EventArgs e)
        {
            //rbfiltrarPorEstado.Checked = true;
           // rbFiltrarPoDni.Checked = false;
            txtbBuscaUsuarioPorDni.Enabled = false;
            cmbEstadoUsuario.Enabled = true;
        }

        private void RbFiltrarPoNombre_CheckedChanged(object sender, EventArgs e)
        {
           // rbFiltrarPoDni.Checked = true;
           // rbfiltrarPorEstado.Checked=false;
            txtbBuscaUsuarioPorDni.Enabled = true;
            cmbEstadoUsuario.Enabled = false;
        }

        private void ChkbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbEliminar.Checked)
            {
                DgvGrillaUsuario.Columns[0].Visible = true;
            }
            else
            {
                DgvGrillaUsuario.Columns[0].Visible = false;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente desea eliminar los registros", "Gestion de Usuarios de Empresa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    string DNI = "";
                    string rta = "";

                    foreach (DataGridViewRow row in DgvGrillaUsuario.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            DNI = Convert.ToString(row.Cells[1].Value);

                            controlusuario = new ControlUsuario();
                            rta = controlusuario.CdeleteUsuario(Convert.ToInt32(DNI));

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
           
        

        private void BtnListar_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
            LlenarGrilla();
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
            if (!txtbLegajo.Text.Equals(""))
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

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                string clave = "";
                int estadodelusuario = 0;
                string estado;
                controlusuario = new ControlUsuario();

                if (txtbNombreDelUsuario.Text == string.Empty)
                {
                    MensanjeError("Falta ingresar algunos datos, estos serán remarcados");
                    ErrorIcon.SetError(txtbNombreDelUsuario, "Ingrese un nombre para el Usuario");
                }
                else
                {
                    if (EsNuevo)
                    {
                        estado = "";
                        if (rbEstadoUsuarioActivo.Checked)
                        {
                            estado = "Activo";
                            estadodelusuario = 1;
                            MessageBox.Show("aca activo" + estado);

                        }
                        if (RbEstadoUsuarioInactivo.Checked)
                        {
                            estado = "Inactivo";
                            estadodelusuario = 2;
                            MessageBox.Show("aca inactivo" + estado);
                        }

                        
                        EncriptarContraseñas encriptar = new EncriptarContraseñas();

                        clave = encriptar.GetSHA256(txtbClave.Text);
                        string b = Convert.ToString(cmbDni.SelectedValue);
                        int a = Int32.Parse(b);
                        rpta = controlusuario.CInsertUsuario(clave, txtbNombreDelUsuario.Text.Trim(),a ,    estado);
                    }
                    else
                    {
                        estado = "";


                        if (rbEstadoUsuarioActivo.Checked)
                        {
                            estado = "Activo";
                            estadodelusuario = 1;
                            MessageBox.Show("aca activo" + estado);

                        }
                        if (RbEstadoUsuarioInactivo.Checked)
                        {
                            estado = "Inactivo";
                            estadodelusuario = 2;
                            MessageBox.Show("aca inactivo" + estado);
                        }
                        EncriptarContraseñas encriptar = new EncriptarContraseñas();

                        clave = encriptar.GetSHA256(txtbClave.Text);
                        rpta = controlusuario.CUpdateUsuario(Convert.ToInt32(txtbLegajo.Text.Trim()), clave, txtbNombreDelUsuario.Text.Trim(), Convert.ToInt32(cmbDni.SelectedValue), estado);

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


                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
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

        private void DgvGrillaUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvGrillaUsuario.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkboxEliminar = (DataGridViewCheckBoxCell)DgvGrillaUsuario.Rows[e.RowIndex].Cells["Eliminar"];
                chkboxEliminar.Value = !Convert.ToBoolean(chkboxEliminar.Value);
            }
        }

        private void DgvGrillaUsuario_DoubleClick(object sender, EventArgs e)
        {
            cmbDni.Text = Convert.ToString(DgvGrillaUsuario.CurrentRow.Cells["DNI"].Value);
            txtbLegajo.Text = Convert.ToString(DgvGrillaUsuario.CurrentRow.Cells["Legajo"].Value);
            txtbNombreDelUsuario.Text = Convert.ToString(DgvGrillaUsuario.CurrentRow.Cells["Nombre de Usuario"].Value);
            if (DgvGrillaUsuario.CurrentRow.Cells["Estado del Usuario"].Value.Equals("1"))
            {
                rbEstadoUsuarioActivo.Checked = true;
            }
            else
            {
                RbEstadoUsuarioInactivo.Checked = true;
            }
            tabFrmGestionDeUsuario.SelectedIndex = 1;
        }

        private void CmbDni_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
