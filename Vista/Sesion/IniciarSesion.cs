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
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void BtnAceptar_Click(object sender, EventArgs e)
        {

            PRINCIPALALGO frmPrincipal = new PRINCIPALALGO();
            frmPrincipal.Show();
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro que quiere salir?", "Salir", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                MessageBox.Show("Hasta luego");
                Close();
            }
        }

        private void ChkBoxMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRecuperarContraseña_Click(object sender, EventArgs e)
        {

        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {

        }
    }
}
