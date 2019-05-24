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
        public Gestion_De_Grupos()
        {
            InitializeComponent();
        }

        private void Gestion_De_Grupos_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Grupo grupo = new Grupo();
            grupo.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Grupo grupo = new Grupo();
            grupo.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Grupo grupo = new Grupo();
            grupo.Show();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
