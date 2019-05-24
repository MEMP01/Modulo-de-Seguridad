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
            Gestion_De_Grupos gestion_De_Grupos = new Gestion_De_Grupos();
            gestion_De_Grupos.Show();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void ChkBoxMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
