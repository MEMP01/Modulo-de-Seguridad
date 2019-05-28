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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void LoggInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IniciarSesion iniciarSesion = new IniciarSesion();
            iniciarSesion.Show();
        }

        private void LoggOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       
        private void GestionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void SalirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro que quiere salir?", "Salir", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                MessageBox.Show("Hasta luego");
                Close();
            }
        

    }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_De_Grupos gestion_De_Grupos = new Gestion_De_Grupos();
            gestion_De_Grupos.InstanciaSingleton.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_de_Usuarios gestion_De_Usuarios = new Gestion_de_Usuarios();
            gestion_De_Usuarios.Show();
        }
    }
}
