using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Gestion_De_Grupos : Form
    {
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
        private void Gestion_De_Grupos_Load(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Grupo grupo = new Grupo();
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
