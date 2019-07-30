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
    public partial class PRINCIPALALGO : Form
    {
        private int childFormNumber = 0;
                     /// <summary>
                     /// contructor del formulario principal
                     /// </summary>
        public PRINCIPALALGO()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void PRINCIPALALGO_Load(object sender, EventArgs e)
        {

        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void WindowsMenu_Click(object sender, EventArgs e)
        {

        }

        private void GruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestion_De_Grupos gestion_De_Grupos = new FrmGestion_De_Grupos();
            gestion_De_Grupos.Show();
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AuditoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Auditoria auditoria = new Auditoria();
            auditoria.Show();
        }

        private void CambiarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RecuperarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void UsuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmGestion_de_Usuarios_de_Empresa frmGestion_De_Usuarios_De_ = new FrmGestion_de_Usuarios_de_Empresa();
            frmGestion_De_Usuarios_De_.Show();
        }

        private void UsuariosDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestrionarUsuario gestrionarUsuario = new FrmGestrionarUsuario();
            gestrionarUsuario.Show();
        }
    }
}
