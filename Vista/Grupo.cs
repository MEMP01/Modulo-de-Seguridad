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
    public partial class Grupo : Form
    {

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


        public Grupo()
        {
            InitializeComponent();
        }



        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Singleton = null;
            Close();
        }

        private void Grupo_Load(object sender, EventArgs e)
        {

        }
    }
}
