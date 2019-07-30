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
    public partial class IniciarSesion : Form
    {
        private CLogin CLogin;
        private EncriptarContraseñas EncriptarContraseñas;

        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ttMensajeAyuda.SetToolTip(txtbUsuario, "Ingrese su nombre de Usuario");
            ttMensajeAyuda.SetToolTip(txtbContraseña, "Ingrese su contraseña");

        }

        private void MensanjeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Modulo de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensanjeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Modulo de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void BtnAceptar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtbUsuario.Text == string.Empty)
                {
                    MensanjeError("Falta ingresar algunos datos, estos serán remarcados");
                    ErrorIcon.SetError(txtbUsuario, "Ingrese un nombre para el Usuario");
                }
                if (txtbContraseña.Text == string.Empty)
                {
                    MensanjeError("Falta ingresar algunos datos, estos serán remarcados");
                    ErrorIcon.SetError(txtbContraseña, "Ingrese una contraseña valida para el Usuario");
                }



                CLogin = new CLogin();
                EncriptarContraseñas = new EncriptarContraseñas();
                string pass = EncriptarContraseñas.GetSHA256(txtbContraseña.Text.Trim());


                if (CLogin.ValidarUsuarioYpasswod(txtbUsuario.Text,pass)> 0)
                {
                    MessageBox.Show("Datos Validos", "Bienvenido", MessageBoxButtons.OK);
                    PRINCIPALALGO frmPrincipal = new PRINCIPALALGO();
                    frmPrincipal.Show();
                }
                else
                {
                    MensanjeError("Usuario, ó Contraseña Invalidos");
                }
                
            }
                catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




          
            
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

        private void BtnRecuperarContraseña_Click(object sender, EventArgs e)
        {

        }

        private void BtnCambiarContraseña_Click(object sender, EventArgs e)
        {

        }
    }
}
