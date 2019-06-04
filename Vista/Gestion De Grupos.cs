using Control;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Vista
{
    public partial class Gestion_De_Grupos : Form
    {
        private bool EsNuevo;
        private bool EsEditar;

        private ControlGrupo ControldeGrupo;

        private static Gestion_De_Grupos Singleton;
        /// <summary>
        /// Contructor del Formulario
        /// </summary>
        public Gestion_De_Grupos()
        {
            InitializeComponent();
            ttMensajeAyuda.SetToolTip(txtbNombreDelGrupo, "Ingrese el nombre del Grupo");
            ttMensajeAyuda.SetToolTip(rbEstadoActivo, "Seleccione esta opcion para setear el estado del grupo como Activo");
            ttMensajeAyuda.SetToolTip(RbGrupoInactivo, "Seleccione esta opcion para setear el estado del grupo como Inactivo ");
            ttMensajeAyuda.SetToolTip(txtbCodigo, "Aqui Aparece el Codigo del grupo, el mísmo No se puede modificar");
            ttMensajeAyuda.SetToolTip(cmbEstadoGrupo, "Seleccione un estado de grupo como filtro de busqueda");
            ttMensajeAyuda.SetToolTip(txtbBuscarGrupoPorNombre, "Ingrese un nombre de grupo como filtro de busqueda");
            ttMensajeAyuda.SetToolTip(btnFiltrar, "Ingrese un nombre de grupo y/o un estado de grupo para realizar la busqueda");
            ttMensajeAyuda.SetToolTip(btnNuevo, "Click para ingresar datos para un nuevo grupo al Sistema");
            ttMensajeAyuda.SetToolTip(btnGuardarCambios, "Click para confirmar datos del grupo del Sistema");
            ttMensajeAyuda.SetToolTip(btnEditar, "Click para modificar datos del grupo del sistema");
            ttMensajeAyuda.SetToolTip(chkbEliminar, "Click aquí para habilitar el boton Eliminar");
            ttMensajeAyuda.SetToolTip(btnCancelar, "Click aquí para deshacer cambios");
            ttMensajeAyuda.SetToolTip(btnSalirGestioGrupo, "Click aquí para regresar al formulario principal");
            ttMensajeAyuda.SetToolTip(rbFiltrarPoNombre, "Seleccione esta opcion para filtrar por Nombre");
            ttMensajeAyuda.SetToolTip(rbfiltrarPorEstado, "Seleccione esta opcion para filtrar por Estado");
        }
        /// <summary>
        /// Implementacion del patron creacional Singleton para obtener una sola instacia del formulario  Gestion_De_Grupos
        /// </summary>
        public Gestion_De_Grupos InstanciaSingleton
        {
            get
            {
                if (Singleton == null)
                {
                    Singleton = new Gestion_De_Grupos();
                }
                return Singleton;
            }

        }

        /// <summary>
        ///    Muestra un mensaje de confirmacion de la operacion
        /// </summary>
        /// <param name="mensaje"></param>
        private void MesanjeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Modulo de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        ///     Muestra Un mensaje de Error
        /// </summary>
        /// <param name="mensaje"></param>
        private void MesanjeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Modulo de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
          /// <summary>
          /// Limpia todos los textbox
          /// </summary>
        private void LimpiarTodo()
        {
            txtbBuscarGrupoPorNombre.Text = string.Empty;
            txtbCodigo.Text = string.Empty;
            txtbNombreDelGrupo.Text = string.Empty;    
        }
          /// <summary>
          /// habilita el textbox de nombre del grupo
          /// </summary>
          /// <param name="valor"></param>
        private void Habilitar(bool valor)
        {
            txtbNombreDelGrupo.ReadOnly = !valor;

        }

        /// <summary>
        /// habilitar y desactivar según la operacion
        /// </summary>
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
        /// Sirve para ocultar columas en la panilla principal de grupos
        /// </summary>
        private void OcultarColumnas    ()
        {
            DgvGrillaGrupos.Columns[0].Visible = false;
            DgvGrillaGrupos.Columns[1].Visible = false;
        }

        /// <summary>
        /// Lista todos los Grupos existentes
        /// </summary>
        private void LlenarGrilla()
        {
            ControldeGrupo = new ControlGrupo();
            DgvGrillaGrupos.DataSource = ControldeGrupo.ListarGrupos();
            lbnumeroDeRegistros.Text = Convert.ToString(DgvGrillaGrupos.Rows.Count);
        }


        private void Filtrar()
        {
           
          
                DataTable dt = DgvGrillaGrupos.DataSource as DataTable;
                string query = string.Format("Estadogrupo = '{0}'", cmbEstadoGrupo.Text);
                dt.DefaultView.RowFilter = query;
                lbnumeroDeRegistros.Text = Convert.ToString(DgvGrillaGrupos.Rows.Count);

            
            
        }




        private void Gestion_De_Grupos_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            Habilitar(false);
            LlenarGrilla();
            Botones();

        }

     

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            Grupo grupo = new Grupo
            {
                EsNueva1 = true
            };
            grupo.InstanciaSingleton.Show();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Grupo grupo = new Grupo();
            grupo.InstanciaSingleton.Show();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Grupo grupo = new Grupo();
            grupo.InstanciaSingleton.Show();
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
          
            if (txtbBuscarGrupoPorNombre.Enabled == true)
            {
                string nombre = txtbBuscarGrupoPorNombre.Text;
                ControldeGrupo = new ControlGrupo();
                DgvGrillaGrupos.DataSource = ControldeGrupo.BuscarGrupo(nombre);
                lbnumeroDeRegistros.Text = Convert.ToString(DgvGrillaGrupos.Rows.Count);
            }
            else Filtrar();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Singleton = null;
            Close();
        }

        private void groupB1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

        }

        private void RbfiltrarPorEstado_CheckedChanged(object sender, EventArgs e)
        {
            txtbBuscarGrupoPorNombre.Enabled = false;
            cmbEstadoGrupo.Enabled = true;
        }

        private void RbFiltrarPoNombre_CheckedChanged(object sender, EventArgs e)
        {
            cmbEstadoGrupo.Enabled = false;
            txtbBuscarGrupoPorNombre.Enabled = true;
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
            LlenarGrilla();
        }
    }
}
