namespace Vista
{
    partial class Grupo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Agregar");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Modificar");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Eliminar");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Filtrar");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Acciones", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Formulario Gestionar Grupos", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Gestionar Grupos", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Agregar");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Modificar");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Eliminar");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Filtrar");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Resetear Clave");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Acciones", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Formulario Gestionar Usuarios", new System.Windows.Forms.TreeNode[] {
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Gestionar Usuarios", new System.Windows.Forms.TreeNode[] {
            treeNode14});
            this.TABCdatos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chbEstado = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.LbCodigo = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbAsignar = new System.Windows.Forms.Label();
            this.dgvGrupoUsuarios = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.TABCdatos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoUsuarios)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TABCdatos
            // 
            this.TABCdatos.Controls.Add(this.tabPage1);
            this.TABCdatos.Controls.Add(this.tabPage2);
            this.TABCdatos.Controls.Add(this.tabPage3);
            this.TABCdatos.Location = new System.Drawing.Point(13, 32);
            this.TABCdatos.Name = "TABCdatos";
            this.TABCdatos.SelectedIndex = 0;
            this.TABCdatos.Size = new System.Drawing.Size(390, 246);
            this.TABCdatos.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chbEstado);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.lbEstado);
            this.tabPage1.Controls.Add(this.lbDescripcion);
            this.tabPage1.Controls.Add(this.LbCodigo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(382, 220);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chbEstado
            // 
            this.chbEstado.AutoSize = true;
            this.chbEstado.Location = new System.Drawing.Point(76, 158);
            this.chbEstado.Name = "chbEstado";
            this.chbEstado.Size = new System.Drawing.Size(56, 17);
            this.chbEstado.TabIndex = 5;
            this.chbEstado.Text = "Activo";
            this.chbEstado.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(6, 163);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(40, 13);
            this.lbEstado.TabIndex = 2;
            this.lbEstado.Text = "Estado";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(6, 96);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbDescripcion.TabIndex = 1;
            this.lbDescripcion.Text = "Descripción";
            // 
            // LbCodigo
            // 
            this.LbCodigo.AutoSize = true;
            this.LbCodigo.Location = new System.Drawing.Point(6, 24);
            this.LbCodigo.Name = "LbCodigo";
            this.LbCodigo.Size = new System.Drawing.Size(40, 13);
            this.LbCodigo.TabIndex = 0;
            this.LbCodigo.Text = "Código";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbAsignar);
            this.tabPage2.Controls.Add(this.dgvGrupoUsuarios);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(382, 220);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Usuarios";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.TabPage2_Click);
            // 
            // lbAsignar
            // 
            this.lbAsignar.AutoSize = true;
            this.lbAsignar.Location = new System.Drawing.Point(7, 4);
            this.lbAsignar.Name = "lbAsignar";
            this.lbAsignar.Size = new System.Drawing.Size(42, 13);
            this.lbAsignar.TabIndex = 1;
            this.lbAsignar.Text = "Asignar";
            // 
            // dgvGrupoUsuarios
            // 
            this.dgvGrupoUsuarios.AllowUserToAddRows = false;
            this.dgvGrupoUsuarios.AllowUserToDeleteRows = false;
            this.dgvGrupoUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupoUsuarios.Location = new System.Drawing.Point(7, 22);
            this.dgvGrupoUsuarios.Name = "dgvGrupoUsuarios";
            this.dgvGrupoUsuarios.ReadOnly = true;
            this.dgvGrupoUsuarios.Size = new System.Drawing.Size(310, 174);
            this.dgvGrupoUsuarios.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.treeView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(382, 220);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Acciones";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(7, 28);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Agregar";
            treeNode1.Text = "Agregar";
            treeNode2.Name = "Modificar";
            treeNode2.Text = "Modificar";
            treeNode3.Name = "Eliminar";
            treeNode3.Text = "Eliminar";
            treeNode4.Name = "Filtar";
            treeNode4.Text = "Filtrar";
            treeNode5.Name = "Acciones";
            treeNode5.Text = "Acciones";
            treeNode6.Name = "FrmGestionarGrupos";
            treeNode6.Text = "Formulario Gestionar Grupos";
            treeNode7.Name = "GestionarGrupos";
            treeNode7.Text = "Gestionar Grupos";
            treeNode8.Name = "Agregar";
            treeNode8.Text = "Agregar";
            treeNode9.Name = "Modificar";
            treeNode9.Text = "Modificar";
            treeNode10.Name = "Eliminar";
            treeNode10.Text = "Eliminar";
            treeNode11.Name = "Filtrar";
            treeNode11.Text = "Filtrar";
            treeNode12.Name = "ResetearClave";
            treeNode12.Text = "Resetear Clave";
            treeNode13.Name = "Acciones";
            treeNode13.Text = "Acciones";
            treeNode14.Name = "FormularioGestionarUsuarios";
            treeNode14.Text = "Formulario Gestionar Usuarios";
            treeNode15.Name = "GestionarUsuarios";
            treeNode15.Text = "Gestionar Usuarios";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode15});
            this.treeView1.Size = new System.Drawing.Size(340, 186);
            this.treeView1.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(17, 284);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(324, 284);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // Grupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 314);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.TABCdatos);
            this.Name = "Grupo";
            this.Text = "Grupo";
            this.Load += new System.EventHandler(this.Grupo_Load);
            this.TABCdatos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoUsuarios)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TABCdatos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label LbCodigo;
        private System.Windows.Forms.CheckBox chbEstado;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label lbAsignar;
        private System.Windows.Forms.DataGridView dgvGrupoUsuarios;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}