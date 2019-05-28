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
    public partial class Grupo : Form
    {
        private bool EsNueva;
        private bool EsModificar;
        private Grupo oGrupo;

        private static Grupo Singleton;
        /// <summary>
        /// Implementacion del patron creacional Singleton para obtener una sola instacia del formulario Grupo
        /// </summary>
        public Grupo InstanciaSingleton
        {
            get
            {
                if (Singleton == null)
                {
                    Singleton = new Grupo();
                }
                return Singleton;
            }

        }

        public bool EsNueva1 { get => EsNueva; set => EsNueva = value; }
        public bool EsModificar1 { get => EsModificar; set => EsModificar = value; }
        public Grupo Grupo1 { get => oGrupo; set => oGrupo = value; }
      

        public Grupo()
        {
            InitializeComponent();

        }

         /**
        private void Habilitar(bool Valor)
        {
            if (Valor == false)
            {
                txtbCodigo.Enabled = false;
                txtbDescripcion.Enabled = true;
                chbEstado.Enabled = true;
            }
            else
            {
                
            }
        }
             */

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string estados = "";
            if (chbEstado.Checked) {
                estados = "Activo";
                    }
            else
            {
                estados = "Inactivo";
            }
            ControlGrupo controlGrupo = new ControlGrupo();
            controlGrupo.InsertGrupo(txtbDescripcion.Text, estados);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Singleton = null;
            Close();
        }

        private void Grupo_Load(object sender, EventArgs e)
        {       /**
                   if (EsNueva1 = true)
            {
                oGrupo = new Grupo();
                oGrupo.Habilitar(true);
            }      if (EsModificar = true)
            {

            }           **/
        }

        private void TxtbDescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
