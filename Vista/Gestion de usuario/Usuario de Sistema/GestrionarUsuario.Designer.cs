namespace Vista
{
    partial class FrmGestrionarUsuario
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
            this.tabFrmGestionDegrupo = new System.Windows.Forms.TabControl();
            this.tabGrupo = new System.Windows.Forms.TabPage();
            this.btnListar = new System.Windows.Forms.Button();
            this.rbFiltrarPoNombre = new System.Windows.Forms.RadioButton();
            this.rbfiltrarPorEstado = new System.Windows.Forms.RadioButton();
            this.lbnumeroDeRegistros = new System.Windows.Forms.Label();
            this.lbCantidadDeRegistros = new System.Windows.Forms.Label();
            this.lbNombreDelGrupo = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.chkbEliminar = new System.Windows.Forms.CheckBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.DgvGrillaUsuario = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmbEstadoUsuario = new System.Windows.Forms.ComboBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.txtbBuscarGrupoPorNombre = new System.Windows.Forms.TextBox();
            this.tabGestionDeGrupos = new System.Windows.Forms.TabPage();
            this.groupB1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RbEstadoUsuarioInactivo = new System.Windows.Forms.RadioButton();
            this.rbEstadoUsuarioActivo = new System.Windows.Forms.RadioButton();
            this.txtbNombreDelUsuario = new System.Windows.Forms.TextBox();
            this.lbNombreDelUsuario = new System.Windows.Forms.Label();
            this.txtbPrimeraClave = new System.Windows.Forms.TextBox();
            this.lbPrimeraClave = new System.Windows.Forms.Label();
            this.txtbLegajo = new System.Windows.Forms.TextBox();
            this.lbLegajo = new System.Windows.Forms.Label();
            this.txtbDNI = new System.Windows.Forms.TextBox();
            this.lbDNI = new System.Windows.Forms.Label();
            this.RbGrupoInactivo = new System.Windows.Forms.RadioButton();
            this.rbEstadoGrupoActivo = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.LbCodigo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbNombreDelGrupo = new System.Windows.Forms.TextBox();
            this.lbEstadoGrupo = new System.Windows.Forms.Label();
            this.txtbCodigo = new System.Windows.Forms.TextBox();
            this.ttMensajeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.ErrorIcon = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.tabFrmGestionDegrupo.SuspendLayout();
            this.tabGrupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGrillaUsuario)).BeginInit();
            this.tabGestionDeGrupos.SuspendLayout();
            this.groupB1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFrmGestionDegrupo
            // 
            this.tabFrmGestionDegrupo.Controls.Add(this.tabGrupo);
            this.tabFrmGestionDegrupo.Controls.Add(this.tabGestionDeGrupos);
            this.tabFrmGestionDegrupo.Location = new System.Drawing.Point(12, 12);
            this.tabFrmGestionDegrupo.Name = "tabFrmGestionDegrupo";
            this.tabFrmGestionDegrupo.SelectedIndex = 0;
            this.tabFrmGestionDegrupo.Size = new System.Drawing.Size(783, 451);
            this.tabFrmGestionDegrupo.TabIndex = 12;
            // 
            // tabGrupo
            // 
            this.tabGrupo.BackColor = System.Drawing.Color.Snow;
            this.tabGrupo.Controls.Add(this.btnListar);
            this.tabGrupo.Controls.Add(this.rbFiltrarPoNombre);
            this.tabGrupo.Controls.Add(this.rbfiltrarPorEstado);
            this.tabGrupo.Controls.Add(this.lbnumeroDeRegistros);
            this.tabGrupo.Controls.Add(this.lbCantidadDeRegistros);
            this.tabGrupo.Controls.Add(this.lbNombreDelGrupo);
            this.tabGrupo.Controls.Add(this.btnEliminar);
            this.tabGrupo.Controls.Add(this.chkbEliminar);
            this.tabGrupo.Controls.Add(this.btnFiltrar);
            this.tabGrupo.Controls.Add(this.DgvGrillaUsuario);
            this.tabGrupo.Controls.Add(this.cmbEstadoUsuario);
            this.tabGrupo.Controls.Add(this.lbEstado);
            this.tabGrupo.Controls.Add(this.txtbBuscarGrupoPorNombre);
            this.tabGrupo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tabGrupo.Location = new System.Drawing.Point(4, 22);
            this.tabGrupo.Name = "tabGrupo";
            this.tabGrupo.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrupo.Size = new System.Drawing.Size(775, 425);
            this.tabGrupo.TabIndex = 0;
            this.tabGrupo.Text = "Grupos";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(662, 394);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 16;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // rbFiltrarPoNombre
            // 
            this.rbFiltrarPoNombre.AutoSize = true;
            this.rbFiltrarPoNombre.Location = new System.Drawing.Point(632, 85);
            this.rbFiltrarPoNombre.Name = "rbFiltrarPoNombre";
            this.rbFiltrarPoNombre.Size = new System.Drawing.Size(109, 17);
            this.rbFiltrarPoNombre.TabIndex = 15;
            this.rbFiltrarPoNombre.Text = "Filtrar Por Nombre";
            this.rbFiltrarPoNombre.UseVisualStyleBackColor = true;
            this.rbFiltrarPoNombre.CheckedChanged += new System.EventHandler(this.rbFiltrarPoNombre_CheckedChanged);
            // 
            // rbfiltrarPorEstado
            // 
            this.rbfiltrarPorEstado.AutoSize = true;
            this.rbfiltrarPorEstado.Checked = true;
            this.rbfiltrarPorEstado.Location = new System.Drawing.Point(632, 62);
            this.rbfiltrarPorEstado.Name = "rbfiltrarPorEstado";
            this.rbfiltrarPorEstado.Size = new System.Drawing.Size(105, 17);
            this.rbfiltrarPorEstado.TabIndex = 14;
            this.rbfiltrarPorEstado.TabStop = true;
            this.rbfiltrarPorEstado.Text = "Filtrar Por Estado";
            this.rbfiltrarPorEstado.UseVisualStyleBackColor = true;
            this.rbfiltrarPorEstado.CheckedChanged += new System.EventHandler(this.rbfiltrarPorEstado_CheckedChanged);
            // 
            // lbnumeroDeRegistros
            // 
            this.lbnumeroDeRegistros.AutoSize = true;
            this.lbnumeroDeRegistros.Location = new System.Drawing.Point(170, 399);
            this.lbnumeroDeRegistros.Name = "lbnumeroDeRegistros";
            this.lbnumeroDeRegistros.Size = new System.Drawing.Size(0, 13);
            this.lbnumeroDeRegistros.TabIndex = 13;
            // 
            // lbCantidadDeRegistros
            // 
            this.lbCantidadDeRegistros.AutoSize = true;
            this.lbCantidadDeRegistros.Location = new System.Drawing.Point(50, 399);
            this.lbCantidadDeRegistros.Name = "lbCantidadDeRegistros";
            this.lbCantidadDeRegistros.Size = new System.Drawing.Size(119, 13);
            this.lbCantidadDeRegistros.TabIndex = 12;
            this.lbCantidadDeRegistros.Text = "Cantidad De Registros :";
            // 
            // lbNombreDelGrupo
            // 
            this.lbNombreDelGrupo.AutoSize = true;
            this.lbNombreDelGrupo.Location = new System.Drawing.Point(50, 37);
            this.lbNombreDelGrupo.Name = "lbNombreDelGrupo";
            this.lbNombreDelGrupo.Size = new System.Drawing.Size(63, 13);
            this.lbNombreDelGrupo.TabIndex = 6;
            this.lbNombreDelGrupo.Text = "Descripcion";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(144, 75);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // chkbEliminar
            // 
            this.chkbEliminar.AutoSize = true;
            this.chkbEliminar.Location = new System.Drawing.Point(53, 79);
            this.chkbEliminar.Name = "chkbEliminar";
            this.chkbEliminar.Size = new System.Drawing.Size(62, 17);
            this.chkbEliminar.TabIndex = 10;
            this.chkbEliminar.Text = "Eliminar";
            this.chkbEliminar.UseVisualStyleBackColor = true;
            this.chkbEliminar.CheckedChanged += new System.EventHandler(this.chkbEliminar_CheckedChanged);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(632, 32);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(105, 23);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // DgvGrillaUsuario
            // 
            this.DgvGrillaUsuario.AllowUserToAddRows = false;
            this.DgvGrillaUsuario.AllowUserToDeleteRows = false;
            this.DgvGrillaUsuario.AllowUserToOrderColumns = true;
            this.DgvGrillaUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DgvGrillaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGrillaUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.DgvGrillaUsuario.Location = new System.Drawing.Point(53, 120);
            this.DgvGrillaUsuario.MultiSelect = false;
            this.DgvGrillaUsuario.Name = "DgvGrillaUsuario";
            this.DgvGrillaUsuario.ReadOnly = true;
            this.DgvGrillaUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvGrillaUsuario.Size = new System.Drawing.Size(686, 268);
            this.DgvGrillaUsuario.TabIndex = 9;
            this.DgvGrillaUsuario.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGrillaUsuario_CellContentDoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // cmbEstadoUsuario
            // 
            this.cmbEstadoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cmbEstadoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbEstadoUsuario.FormattingEnabled = true;
            this.cmbEstadoUsuario.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstadoUsuario.Location = new System.Drawing.Point(463, 34);
            this.cmbEstadoUsuario.Name = "cmbEstadoUsuario";
            this.cmbEstadoUsuario.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoUsuario.TabIndex = 5;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(379, 40);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(40, 13);
            this.lbEstado.TabIndex = 8;
            this.lbEstado.Text = "Estado";
            // 
            // txtbBuscarGrupoPorNombre
            // 
            this.txtbBuscarGrupoPorNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtbBuscarGrupoPorNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbBuscarGrupoPorNombre.Location = new System.Drawing.Point(144, 35);
            this.txtbBuscarGrupoPorNombre.Name = "txtbBuscarGrupoPorNombre";
            this.txtbBuscarGrupoPorNombre.Size = new System.Drawing.Size(207, 20);
            this.txtbBuscarGrupoPorNombre.TabIndex = 7;
            // 
            // tabGestionDeGrupos
            // 
            this.tabGestionDeGrupos.Controls.Add(this.groupB1);
            this.tabGestionDeGrupos.Location = new System.Drawing.Point(4, 22);
            this.tabGestionDeGrupos.Name = "tabGestionDeGrupos";
            this.tabGestionDeGrupos.Padding = new System.Windows.Forms.Padding(3);
            this.tabGestionDeGrupos.Size = new System.Drawing.Size(775, 425);
            this.tabGestionDeGrupos.TabIndex = 1;
            this.tabGestionDeGrupos.Text = "Gestion de Grupos";
            this.tabGestionDeGrupos.UseVisualStyleBackColor = true;
            // 
            // groupB1
            // 
            this.groupB1.Controls.Add(this.label3);
            this.groupB1.Controls.Add(this.RbEstadoUsuarioInactivo);
            this.groupB1.Controls.Add(this.rbEstadoUsuarioActivo);
            this.groupB1.Controls.Add(this.txtbNombreDelUsuario);
            this.groupB1.Controls.Add(this.lbNombreDelUsuario);
            this.groupB1.Controls.Add(this.txtbPrimeraClave);
            this.groupB1.Controls.Add(this.lbPrimeraClave);
            this.groupB1.Controls.Add(this.txtbLegajo);
            this.groupB1.Controls.Add(this.lbLegajo);
            this.groupB1.Controls.Add(this.txtbDNI);
            this.groupB1.Controls.Add(this.lbDNI);
            this.groupB1.Controls.Add(this.RbGrupoInactivo);
            this.groupB1.Controls.Add(this.rbEstadoGrupoActivo);
            this.groupB1.Controls.Add(this.btnCancelar);
            this.groupB1.Controls.Add(this.btnGuardarCambios);
            this.groupB1.Controls.Add(this.btnEditar);
            this.groupB1.Controls.Add(this.btnNuevo);
            this.groupB1.Controls.Add(this.LbCodigo);
            this.groupB1.Controls.Add(this.label2);
            this.groupB1.Controls.Add(this.txtbNombreDelGrupo);
            this.groupB1.Controls.Add(this.lbEstadoGrupo);
            this.groupB1.Controls.Add(this.txtbCodigo);
            this.groupB1.Location = new System.Drawing.Point(7, 7);
            this.groupB1.Name = "groupB1";
            this.groupB1.Size = new System.Drawing.Size(749, 402);
            this.groupB1.TabIndex = 12;
            this.groupB1.TabStop = false;
            this.groupB1.Text = "Gu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Estado";
            // 
            // RbEstadoUsuarioInactivo
            // 
            this.RbEstadoUsuarioInactivo.AutoSize = true;
            this.RbEstadoUsuarioInactivo.Location = new System.Drawing.Point(196, 212);
            this.RbEstadoUsuarioInactivo.Name = "RbEstadoUsuarioInactivo";
            this.RbEstadoUsuarioInactivo.Size = new System.Drawing.Size(102, 17);
            this.RbEstadoUsuarioInactivo.TabIndex = 55;
            this.RbEstadoUsuarioInactivo.Text = "Usuario Inactivo";
            this.RbEstadoUsuarioInactivo.UseVisualStyleBackColor = true;
            this.RbEstadoUsuarioInactivo.CheckedChanged += new System.EventHandler(this.RbEstadoUsuarioInactivo_CheckedChanged);
            // 
            // rbEstadoUsuarioActivo
            // 
            this.rbEstadoUsuarioActivo.AutoSize = true;
            this.rbEstadoUsuarioActivo.Location = new System.Drawing.Point(96, 212);
            this.rbEstadoUsuarioActivo.Name = "rbEstadoUsuarioActivo";
            this.rbEstadoUsuarioActivo.Size = new System.Drawing.Size(94, 17);
            this.rbEstadoUsuarioActivo.TabIndex = 54;
            this.rbEstadoUsuarioActivo.Text = "Usuario Activo";
            this.rbEstadoUsuarioActivo.UseVisualStyleBackColor = true;
            this.rbEstadoUsuarioActivo.CheckedChanged += new System.EventHandler(this.rbEstadoUsuarioActivo_CheckedChanged);
            // 
            // txtbNombreDelUsuario
            // 
            this.txtbNombreDelUsuario.Location = new System.Drawing.Point(118, 158);
            this.txtbNombreDelUsuario.Name = "txtbNombreDelUsuario";
            this.txtbNombreDelUsuario.Size = new System.Drawing.Size(195, 20);
            this.txtbNombreDelUsuario.TabIndex = 49;
            // 
            // lbNombreDelUsuario
            // 
            this.lbNombreDelUsuario.AutoSize = true;
            this.lbNombreDelUsuario.Location = new System.Drawing.Point(18, 161);
            this.lbNombreDelUsuario.Name = "lbNombreDelUsuario";
            this.lbNombreDelUsuario.Size = new System.Drawing.Size(100, 13);
            this.lbNombreDelUsuario.TabIndex = 48;
            this.lbNombreDelUsuario.Text = "Nombre del Usuario";
            // 
            // txtbPrimeraClave
            // 
            this.txtbPrimeraClave.Location = new System.Drawing.Point(118, 116);
            this.txtbPrimeraClave.Name = "txtbPrimeraClave";
            this.txtbPrimeraClave.Size = new System.Drawing.Size(195, 20);
            this.txtbPrimeraClave.TabIndex = 47;
            // 
            // lbPrimeraClave
            // 
            this.lbPrimeraClave.AutoSize = true;
            this.lbPrimeraClave.Location = new System.Drawing.Point(18, 119);
            this.lbPrimeraClave.Name = "lbPrimeraClave";
            this.lbPrimeraClave.Size = new System.Drawing.Size(72, 13);
            this.lbPrimeraClave.TabIndex = 46;
            this.lbPrimeraClave.Text = "Primera Clave";
            // 
            // txtbLegajo
            // 
            this.txtbLegajo.Location = new System.Drawing.Point(118, 70);
            this.txtbLegajo.Name = "txtbLegajo";
            this.txtbLegajo.Size = new System.Drawing.Size(195, 20);
            this.txtbLegajo.TabIndex = 45;
            // 
            // lbLegajo
            // 
            this.lbLegajo.AutoSize = true;
            this.lbLegajo.Location = new System.Drawing.Point(18, 73);
            this.lbLegajo.Name = "lbLegajo";
            this.lbLegajo.Size = new System.Drawing.Size(39, 13);
            this.lbLegajo.TabIndex = 44;
            this.lbLegajo.Text = "Legajo";
            // 
            // txtbDNI
            // 
            this.txtbDNI.Location = new System.Drawing.Point(118, 28);
            this.txtbDNI.Name = "txtbDNI";
            this.txtbDNI.Size = new System.Drawing.Size(195, 20);
            this.txtbDNI.TabIndex = 43;
            // 
            // lbDNI
            // 
            this.lbDNI.AutoSize = true;
            this.lbDNI.Location = new System.Drawing.Point(18, 28);
            this.lbDNI.Name = "lbDNI";
            this.lbDNI.Size = new System.Drawing.Size(26, 13);
            this.lbDNI.TabIndex = 41;
            this.lbDNI.Text = "DNI";
            // 
            // RbGrupoInactivo
            // 
            this.RbGrupoInactivo.AutoSize = true;
            this.RbGrupoInactivo.Location = new System.Drawing.Point(535, 138);
            this.RbGrupoInactivo.Name = "RbGrupoInactivo";
            this.RbGrupoInactivo.Size = new System.Drawing.Size(95, 17);
            this.RbGrupoInactivo.TabIndex = 17;
            this.RbGrupoInactivo.Text = "Grupo Inactivo";
            this.RbGrupoInactivo.UseVisualStyleBackColor = true;
            this.RbGrupoInactivo.CheckedChanged += new System.EventHandler(this.RbGrupoInactivo_CheckedChanged);
            // 
            // rbEstadoGrupoActivo
            // 
            this.rbEstadoGrupoActivo.AutoSize = true;
            this.rbEstadoGrupoActivo.Location = new System.Drawing.Point(431, 138);
            this.rbEstadoGrupoActivo.Name = "rbEstadoGrupoActivo";
            this.rbEstadoGrupoActivo.Size = new System.Drawing.Size(87, 17);
            this.rbEstadoGrupoActivo.TabIndex = 16;
            this.rbEstadoGrupoActivo.Text = "Grupo Activo";
            this.rbEstadoGrupoActivo.UseVisualStyleBackColor = true;
            this.rbEstadoGrupoActivo.CheckedChanged += new System.EventHandler(this.rbEstadoGrupoActivo_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(664, 362);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 34);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(583, 362);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(75, 34);
            this.btnGuardarCambios.TabIndex = 14;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(502, 362);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 34);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(421, 362);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 34);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // LbCodigo
            // 
            this.LbCodigo.AutoSize = true;
            this.LbCodigo.Location = new System.Drawing.Point(370, 28);
            this.LbCodigo.Name = "LbCodigo";
            this.LbCodigo.Size = new System.Drawing.Size(40, 13);
            this.LbCodigo.TabIndex = 6;
            this.LbCodigo.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre del grupo";
            // 
            // txtbNombreDelGrupo
            // 
            this.txtbNombreDelGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtbNombreDelGrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbNombreDelGrupo.Location = new System.Drawing.Point(467, 93);
            this.txtbNombreDelGrupo.Name = "txtbNombreDelGrupo";
            this.txtbNombreDelGrupo.Size = new System.Drawing.Size(276, 20);
            this.txtbNombreDelGrupo.TabIndex = 10;
            // 
            // lbEstadoGrupo
            // 
            this.lbEstadoGrupo.AutoSize = true;
            this.lbEstadoGrupo.Location = new System.Drawing.Point(373, 138);
            this.lbEstadoGrupo.Name = "lbEstadoGrupo";
            this.lbEstadoGrupo.Size = new System.Drawing.Size(46, 13);
            this.lbEstadoGrupo.TabIndex = 8;
            this.lbEstadoGrupo.Text = "Estado :";
            // 
            // txtbCodigo
            // 
            this.txtbCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtbCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbCodigo.Location = new System.Drawing.Point(467, 21);
            this.txtbCodigo.Name = "txtbCodigo";
            this.txtbCodigo.Size = new System.Drawing.Size(276, 20);
            this.txtbCodigo.TabIndex = 9;
            // 
            // ErrorIcon
            // 
            this.ErrorIcon.ContainerControl = this;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(678, 472);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmGestrionarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 507);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tabFrmGestionDegrupo);
            this.Name = "FrmGestrionarUsuario";
            this.Text = "Gestion de Usuario de Sistema";
            this.Load += new System.EventHandler(this.GestrionarUsuario_Load);
            this.tabFrmGestionDegrupo.ResumeLayout(false);
            this.tabGrupo.ResumeLayout(false);
            this.tabGrupo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGrillaUsuario)).EndInit();
            this.tabGestionDeGrupos.ResumeLayout(false);
            this.groupB1.ResumeLayout(false);
            this.groupB1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabFrmGestionDegrupo;
        private System.Windows.Forms.TabPage tabGrupo;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.RadioButton rbFiltrarPoNombre;
        private System.Windows.Forms.RadioButton rbfiltrarPorEstado;
        private System.Windows.Forms.Label lbnumeroDeRegistros;
        private System.Windows.Forms.Label lbCantidadDeRegistros;
        private System.Windows.Forms.Label lbNombreDelGrupo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.CheckBox chkbEliminar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView DgvGrillaUsuario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.ComboBox cmbEstadoUsuario;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.TextBox txtbBuscarGrupoPorNombre;
        private System.Windows.Forms.TabPage tabGestionDeGrupos;
        private System.Windows.Forms.GroupBox groupB1;
        private System.Windows.Forms.RadioButton RbGrupoInactivo;
        private System.Windows.Forms.RadioButton rbEstadoGrupoActivo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label LbCodigo;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtbNombreDelGrupo;
        private System.Windows.Forms.Label lbEstadoGrupo;
        public System.Windows.Forms.TextBox txtbCodigo;
        private System.Windows.Forms.TextBox txtbDNI;
        private System.Windows.Forms.Label lbDNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RbEstadoUsuarioInactivo;
        private System.Windows.Forms.RadioButton rbEstadoUsuarioActivo;
        private System.Windows.Forms.TextBox txtbNombreDelUsuario;
        private System.Windows.Forms.Label lbNombreDelUsuario;
        private System.Windows.Forms.TextBox txtbPrimeraClave;
        private System.Windows.Forms.Label lbPrimeraClave;
        private System.Windows.Forms.TextBox txtbLegajo;
        private System.Windows.Forms.Label lbLegajo;
        private System.Windows.Forms.ToolTip ttMensajeAyuda;
        private System.Windows.Forms.ErrorProvider ErrorIcon;
        private System.Windows.Forms.Button btnSalir;
    }
}