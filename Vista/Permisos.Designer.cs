namespace Vista
{
    partial class FrmPermisos
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnListar = new System.Windows.Forms.Button();
            this.rbFiltrarPoNombre = new System.Windows.Forms.RadioButton();
            this.rbfiltrarPorEstado = new System.Windows.Forms.RadioButton();
            this.lbnumeroDeRegistros = new System.Windows.Forms.Label();
            this.lbCantidadDeRegistros = new System.Windows.Forms.Label();
            this.lbNombreDelGrupo = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cmbEstadoGrupo = new System.Windows.Forms.ComboBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.txtbBuscarGrupoPorNombre = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RbGrupoInactivo = new System.Windows.Forms.RadioButton();
            this.rbEstadoActivo = new System.Windows.Forms.RadioButton();
            this.LbCodigo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbNombreDelGrupo = new System.Windows.Forms.TextBox();
            this.lbEstadoGrupo = new System.Windows.Forms.Label();
            this.txtbCodigo = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(49, 328);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 29;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // rbFiltrarPoNombre
            // 
            this.rbFiltrarPoNombre.AutoSize = true;
            this.rbFiltrarPoNombre.Location = new System.Drawing.Point(49, 72);
            this.rbFiltrarPoNombre.Name = "rbFiltrarPoNombre";
            this.rbFiltrarPoNombre.Size = new System.Drawing.Size(109, 17);
            this.rbFiltrarPoNombre.TabIndex = 28;
            this.rbFiltrarPoNombre.Text = "Filtrar Por Nombre";
            this.rbFiltrarPoNombre.UseVisualStyleBackColor = true;
            // 
            // rbfiltrarPorEstado
            // 
            this.rbfiltrarPorEstado.AutoSize = true;
            this.rbfiltrarPorEstado.Checked = true;
            this.rbfiltrarPorEstado.Location = new System.Drawing.Point(49, 49);
            this.rbfiltrarPorEstado.Name = "rbfiltrarPorEstado";
            this.rbfiltrarPorEstado.Size = new System.Drawing.Size(105, 17);
            this.rbfiltrarPorEstado.TabIndex = 27;
            this.rbfiltrarPorEstado.TabStop = true;
            this.rbfiltrarPorEstado.Text = "Filtrar Por Estado";
            this.rbfiltrarPorEstado.UseVisualStyleBackColor = true;
            // 
            // lbnumeroDeRegistros
            // 
            this.lbnumeroDeRegistros.AutoSize = true;
            this.lbnumeroDeRegistros.Location = new System.Drawing.Point(166, 394);
            this.lbnumeroDeRegistros.Name = "lbnumeroDeRegistros";
            this.lbnumeroDeRegistros.Size = new System.Drawing.Size(0, 13);
            this.lbnumeroDeRegistros.TabIndex = 26;
            // 
            // lbCantidadDeRegistros
            // 
            this.lbCantidadDeRegistros.AutoSize = true;
            this.lbCantidadDeRegistros.Location = new System.Drawing.Point(46, 354);
            this.lbCantidadDeRegistros.Name = "lbCantidadDeRegistros";
            this.lbCantidadDeRegistros.Size = new System.Drawing.Size(119, 13);
            this.lbCantidadDeRegistros.TabIndex = 25;
            this.lbCantidadDeRegistros.Text = "Cantidad De Registros :";
            // 
            // lbNombreDelGrupo
            // 
            this.lbNombreDelGrupo.AutoSize = true;
            this.lbNombreDelGrupo.Location = new System.Drawing.Point(192, 76);
            this.lbNombreDelGrupo.Name = "lbNombreDelGrupo";
            this.lbNombreDelGrupo.Size = new System.Drawing.Size(63, 13);
            this.lbNombreDelGrupo.TabIndex = 20;
            this.lbNombreDelGrupo.Text = "Descripcion";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(49, 19);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(105, 23);
            this.btnFiltrar.TabIndex = 18;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // cmbEstadoGrupo
            // 
            this.cmbEstadoGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cmbEstadoGrupo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbEstadoGrupo.FormattingEnabled = true;
            this.cmbEstadoGrupo.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstadoGrupo.Location = new System.Drawing.Point(276, 43);
            this.cmbEstadoGrupo.Name = "cmbEstadoGrupo";
            this.cmbEstadoGrupo.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoGrupo.TabIndex = 19;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(192, 49);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(40, 13);
            this.lbEstado.TabIndex = 22;
            this.lbEstado.Text = "Estado";
            // 
            // txtbBuscarGrupoPorNombre
            // 
            this.txtbBuscarGrupoPorNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtbBuscarGrupoPorNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbBuscarGrupoPorNombre.Location = new System.Drawing.Point(286, 74);
            this.txtbBuscarGrupoPorNombre.Name = "txtbBuscarGrupoPorNombre";
            this.txtbBuscarGrupoPorNombre.Size = new System.Drawing.Size(207, 20);
            this.txtbBuscarGrupoPorNombre.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 172);
            this.dataGridView1.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.txtbBuscarGrupoPorNombre);
            this.groupBox1.Controls.Add(this.btnListar);
            this.groupBox1.Controls.Add(this.lbEstado);
            this.groupBox1.Controls.Add(this.rbFiltrarPoNombre);
            this.groupBox1.Controls.Add(this.cmbEstadoGrupo);
            this.groupBox1.Controls.Add(this.rbfiltrarPorEstado);
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.lbnumeroDeRegistros);
            this.groupBox1.Controls.Add(this.lbNombreDelGrupo);
            this.groupBox1.Controls.Add(this.lbCantidadDeRegistros);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 440);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.RbGrupoInactivo);
            this.groupBox2.Controls.Add(this.rbEstadoActivo);
            this.groupBox2.Controls.Add(this.LbCodigo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtbNombreDelGrupo);
            this.groupBox2.Controls.Add(this.lbEstadoGrupo);
            this.groupBox2.Controls.Add(this.txtbCodigo);
            this.groupBox2.Location = new System.Drawing.Point(571, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 440);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // RbGrupoInactivo
            // 
            this.RbGrupoInactivo.AutoSize = true;
            this.RbGrupoInactivo.Location = new System.Drawing.Point(187, 172);
            this.RbGrupoInactivo.Name = "RbGrupoInactivo";
            this.RbGrupoInactivo.Size = new System.Drawing.Size(95, 17);
            this.RbGrupoInactivo.TabIndex = 24;
            this.RbGrupoInactivo.Text = "Grupo Inactivo";
            this.RbGrupoInactivo.UseVisualStyleBackColor = true;
            // 
            // rbEstadoActivo
            // 
            this.rbEstadoActivo.AutoSize = true;
            this.rbEstadoActivo.Location = new System.Drawing.Point(83, 172);
            this.rbEstadoActivo.Name = "rbEstadoActivo";
            this.rbEstadoActivo.Size = new System.Drawing.Size(87, 17);
            this.rbEstadoActivo.TabIndex = 23;
            this.rbEstadoActivo.Text = "Grupo Activo";
            this.rbEstadoActivo.UseVisualStyleBackColor = true;
            // 
            // LbCodigo
            // 
            this.LbCodigo.AutoSize = true;
            this.LbCodigo.Location = new System.Drawing.Point(73, 43);
            this.LbCodigo.Name = "LbCodigo";
            this.LbCodigo.Size = new System.Drawing.Size(40, 13);
            this.LbCodigo.TabIndex = 18;
            this.LbCodigo.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre del grupo";
            // 
            // txtbNombreDelGrupo
            // 
            this.txtbNombreDelGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtbNombreDelGrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbNombreDelGrupo.Location = new System.Drawing.Point(122, 108);
            this.txtbNombreDelGrupo.Name = "txtbNombreDelGrupo";
            this.txtbNombreDelGrupo.Size = new System.Drawing.Size(276, 20);
            this.txtbNombreDelGrupo.TabIndex = 22;
            // 
            // lbEstadoGrupo
            // 
            this.lbEstadoGrupo.AutoSize = true;
            this.lbEstadoGrupo.Location = new System.Drawing.Point(25, 172);
            this.lbEstadoGrupo.Name = "lbEstadoGrupo";
            this.lbEstadoGrupo.Size = new System.Drawing.Size(46, 13);
            this.lbEstadoGrupo.TabIndex = 20;
            this.lbEstadoGrupo.Text = "Estado :";
            // 
            // txtbCodigo
            // 
            this.txtbCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtbCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbCodigo.Location = new System.Drawing.Point(122, 36);
            this.txtbCodigo.Name = "txtbCodigo";
            this.txtbCodigo.Size = new System.Drawing.Size(276, 20);
            this.txtbCodigo.TabIndex = 21;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(28, 205);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(254, 184);
            this.dataGridView2.TabIndex = 25;
            // 
            // FrmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 524);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPermisos";
            this.Text = "Permisos";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.RadioButton rbFiltrarPoNombre;
        private System.Windows.Forms.RadioButton rbfiltrarPorEstado;
        private System.Windows.Forms.Label lbnumeroDeRegistros;
        private System.Windows.Forms.Label lbCantidadDeRegistros;
        private System.Windows.Forms.Label lbNombreDelGrupo;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cmbEstadoGrupo;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.TextBox txtbBuscarGrupoPorNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton RbGrupoInactivo;
        private System.Windows.Forms.RadioButton rbEstadoActivo;
        private System.Windows.Forms.Label LbCodigo;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtbNombreDelGrupo;
        private System.Windows.Forms.Label lbEstadoGrupo;
        public System.Windows.Forms.TextBox txtbCodigo;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}