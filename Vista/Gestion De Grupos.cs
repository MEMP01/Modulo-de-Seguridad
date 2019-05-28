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
    public partial class Gestion_De_Grupos : Form
    {
        private ControlGrupo ControlGrupo;

        private static Gestion_De_Grupos Singleton;
        public Gestion_De_Grupos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Implementacion del patron creacional Singleton para obtener una sola instacia del formulario  Gestion_De_Grupos
        /// </summary>
        public Gestion_De_Grupos InstanciaSingleton
        {
            get  {
                if (Singleton == null)
                {
                    Singleton = new Gestion_De_Grupos();
                }
                return Singleton;
            }
            
        }
         /// <summary>
         /// encapsulo un campo del tipo controlGrupo
         /// </summary>
        public ControlGrupo ControlGrupo1 { get => ControlGrupo; set => ControlGrupo = value; }

        private void Gestion_De_Grupos_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
           //lenarGrilla();

        }
         /**
        private void LlenarGrilla()
        {
            DgvGrillaGrupos.DataSource = ControlGrupo1.ListarGrupos();

        }
         **/
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

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Singleton = null;
            Close();
        }
    }
}
