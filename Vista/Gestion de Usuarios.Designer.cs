namespace Vista
{
    partial class FrmGestion_de_Usuarios_de_Empresa
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
            this.tabFrmGestionDeUsuarios = new System.Windows.Forms.TabControl();
            this.tabUsuarios = new System.Windows.Forms.TabPage();
            this.btnListar = new System.Windows.Forms.Button();
            this.rbFiltrarPoNombre = new System.Windows.Forms.RadioButton();
            this.rbfiltrarPorEstado = new System.Windows.Forms.RadioButton();
            this.lbnumeroDeRegistros = new System.Windows.Forms.Label();
            this.lbCantidadDeRegistros = new System.Windows.Forms.Label();
            this.lbNombreDelGrupo = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.chkbEliminar = new System.Windows.Forms.CheckBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.DgvGrillaUsuarios = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmbEstadoUsuario = new System.Windows.Forms.ComboBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.txtbBuscarUsuarioPorDNI = new System.Windows.Forms.TextBox();
            this.tabGestionDeUsuarios = new System.Windows.Forms.TabPage();
            this.groupB1 = new System.Windows.Forms.GroupBox();
            this.txtbCodigoPostal = new System.Windows.Forms.TextBox();
            this.txtbDireccion = new System.Windows.Forms.TextBox();
            this.txtbProvincia = new System.Windows.Forms.TextBox();
            this.txtbPais = new System.Windows.Forms.TextBox();
            this.txtbTelefono = new System.Windows.Forms.TextBox();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.txtbEdad = new System.Windows.Forms.TextBox();
            this.txtbSexo = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbApellido = new System.Windows.Forms.TextBox();
            this.txtbDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCodigoPostal = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbProvincia = new System.Windows.Forms.Label();
            this.lbPais = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbEdad = new System.Windows.Forms.Label();
            this.lbSexo = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbDNI = new System.Windows.Forms.Label();
            this.RbUsuarioInactivo = new System.Windows.Forms.RadioButton();
            this.rbEstadoActivo = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalirGestioGrupo = new System.Windows.Forms.Button();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensajeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.tabFrmGestionDeUsuarios.SuspendLayout();
            this.tabUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGrillaUsuarios)).BeginInit();
            this.tabGestionDeUsuarios.SuspendLayout();
            this.groupB1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFrmGestionDeUsuarios
            // 
            this.tabFrmGestionDeUsuarios.Controls.Add(this.tabUsuarios);
            this.tabFrmGestionDeUsuarios.Controls.Add(this.tabGestionDeUsuarios);
            this.tabFrmGestionDeUsuarios.Location = new System.Drawing.Point(12, 12);
            this.tabFrmGestionDeUsuarios.Name = "tabFrmGestionDeUsuarios";
            this.tabFrmGestionDeUsuarios.SelectedIndex = 0;
            this.tabFrmGestionDeUsuarios.Size = new System.Drawing.Size(780, 512);
            this.tabFrmGestionDeUsuarios.TabIndex = 14;
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.BackColor = System.Drawing.Color.Snow;
            this.tabUsuarios.Controls.Add(this.btnListar);
            this.tabUsuarios.Controls.Add(this.rbFiltrarPoNombre);
            this.tabUsuarios.Controls.Add(this.rbfiltrarPorEstado);
            this.tabUsuarios.Controls.Add(this.lbnumeroDeRegistros);
            this.tabUsuarios.Controls.Add(this.lbCantidadDeRegistros);
            this.tabUsuarios.Controls.Add(this.lbNombreDelGrupo);
            this.tabUsuarios.Controls.Add(this.btnEliminar);
            this.tabUsuarios.Controls.Add(this.chkbEliminar);
            this.tabUsuarios.Controls.Add(this.btnFiltrar);
            this.tabUsuarios.Controls.Add(this.DgvGrillaUsuarios);
            this.tabUsuarios.Controls.Add(this.cmbEstadoUsuario);
            this.tabUsuarios.Controls.Add(this.lbEstado);
            this.tabUsuarios.Controls.Add(this.txtbBuscarUsuarioPorDNI);
            this.tabUsuarios.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tabUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuarios.Size = new System.Drawing.Size(772, 486);
            this.tabUsuarios.TabIndex = 0;
            this.tabUsuarios.Text = "Usuarios";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(662, 394);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 16;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.BtnListar_Click);
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
            this.rbFiltrarPoNombre.CheckedChanged += new System.EventHandler(this.RbFiltrarPoNombre_CheckedChanged);
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
            this.rbfiltrarPorEstado.CheckedChanged += new System.EventHandler(this.RbfiltrarPorEstado_CheckedChanged);
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
            this.chkbEliminar.CheckedChanged += new System.EventHandler(this.ChkbEliminar_CheckedChanged);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(632, 32);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(105, 23);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // DgvGrillaUsuarios
            // 
            this.DgvGrillaUsuarios.AllowUserToAddRows = false;
            this.DgvGrillaUsuarios.AllowUserToDeleteRows = false;
            this.DgvGrillaUsuarios.AllowUserToOrderColumns = true;
            this.DgvGrillaUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DgvGrillaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGrillaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.DgvGrillaUsuarios.Location = new System.Drawing.Point(53, 120);
            this.DgvGrillaUsuarios.MultiSelect = false;
            this.DgvGrillaUsuarios.Name = "DgvGrillaUsuarios";
            this.DgvGrillaUsuarios.ReadOnly = true;
            this.DgvGrillaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvGrillaUsuarios.Size = new System.Drawing.Size(686, 268);
            this.DgvGrillaUsuarios.TabIndex = 9;
            this.DgvGrillaUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGrillaUsuarios_CellContentClick);
            this.DgvGrillaUsuarios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGrillaUsuarios_CellContentDoubleClick);
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
            this.cmbEstadoUsuario.SelectedIndexChanged += new System.EventHandler(this.CmbEstadoUsuario_SelectedIndexChanged);
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
            // txtbBuscarUsuarioPorDNI
            // 
            this.txtbBuscarUsuarioPorDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtbBuscarUsuarioPorDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbBuscarUsuarioPorDNI.Location = new System.Drawing.Point(144, 35);
            this.txtbBuscarUsuarioPorDNI.Name = "txtbBuscarUsuarioPorDNI";
            this.txtbBuscarUsuarioPorDNI.Size = new System.Drawing.Size(207, 20);
            this.txtbBuscarUsuarioPorDNI.TabIndex = 7;
            // 
            // tabGestionDeUsuarios
            // 
            this.tabGestionDeUsuarios.Controls.Add(this.groupB1);
            this.tabGestionDeUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tabGestionDeUsuarios.Name = "tabGestionDeUsuarios";
            this.tabGestionDeUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabGestionDeUsuarios.Size = new System.Drawing.Size(772, 486);
            this.tabGestionDeUsuarios.TabIndex = 1;
            this.tabGestionDeUsuarios.Text = "Gestion de Usuarios";
            this.tabGestionDeUsuarios.UseVisualStyleBackColor = true;
            // 
            // groupB1
            // 
            this.groupB1.Controls.Add(this.txtbCodigoPostal);
            this.groupB1.Controls.Add(this.txtbDireccion);
            this.groupB1.Controls.Add(this.txtbProvincia);
            this.groupB1.Controls.Add(this.txtbPais);
            this.groupB1.Controls.Add(this.txtbTelefono);
            this.groupB1.Controls.Add(this.txtbEmail);
            this.groupB1.Controls.Add(this.txtbEdad);
            this.groupB1.Controls.Add(this.txtbSexo);
            this.groupB1.Controls.Add(this.txtbNombre);
            this.groupB1.Controls.Add(this.txtbApellido);
            this.groupB1.Controls.Add(this.txtbDNI);
            this.groupB1.Controls.Add(this.label1);
            this.groupB1.Controls.Add(this.lbCodigoPostal);
            this.groupB1.Controls.Add(this.lbDireccion);
            this.groupB1.Controls.Add(this.lbProvincia);
            this.groupB1.Controls.Add(this.lbPais);
            this.groupB1.Controls.Add(this.lbTelefono);
            this.groupB1.Controls.Add(this.lbEmail);
            this.groupB1.Controls.Add(this.lbEdad);
            this.groupB1.Controls.Add(this.lbSexo);
            this.groupB1.Controls.Add(this.lbNombre);
            this.groupB1.Controls.Add(this.lbApellido);
            this.groupB1.Controls.Add(this.lbDNI);
            this.groupB1.Controls.Add(this.RbUsuarioInactivo);
            this.groupB1.Controls.Add(this.rbEstadoActivo);
            this.groupB1.Controls.Add(this.btnCancelar);
            this.groupB1.Controls.Add(this.btnGuardarCambios);
            this.groupB1.Controls.Add(this.btnEditar);
            this.groupB1.Controls.Add(this.btnNuevo);
            this.groupB1.Location = new System.Drawing.Point(7, 7);
            this.groupB1.Name = "groupB1";
            this.groupB1.Size = new System.Drawing.Size(657, 467);
            this.groupB1.TabIndex = 12;
            this.groupB1.TabStop = false;
            this.groupB1.Text = "Gu";
            this.groupB1.Enter += new System.EventHandler(this.GroupB1_Enter);
            // 
            // txtbCodigoPostal
            // 
            this.txtbCodigoPostal.Location = new System.Drawing.Point(84, 305);
            this.txtbCodigoPostal.Name = "txtbCodigoPostal";
            this.txtbCodigoPostal.Size = new System.Drawing.Size(195, 20);
            this.txtbCodigoPostal.TabIndex = 48;
            // 
            // txtbDireccion
            // 
            this.txtbDireccion.Location = new System.Drawing.Point(84, 279);
            this.txtbDireccion.Name = "txtbDireccion";
            this.txtbDireccion.Size = new System.Drawing.Size(195, 20);
            this.txtbDireccion.TabIndex = 47;
            // 
            // txtbProvincia
            // 
            this.txtbProvincia.Location = new System.Drawing.Point(84, 255);
            this.txtbProvincia.Name = "txtbProvincia";
            this.txtbProvincia.Size = new System.Drawing.Size(195, 20);
            this.txtbProvincia.TabIndex = 46;
            // 
            // txtbPais
            // 
            this.txtbPais.Location = new System.Drawing.Point(84, 226);
            this.txtbPais.Name = "txtbPais";
            this.txtbPais.Size = new System.Drawing.Size(195, 20);
            this.txtbPais.TabIndex = 45;
            // 
            // txtbTelefono
            // 
            this.txtbTelefono.Location = new System.Drawing.Point(84, 199);
            this.txtbTelefono.Name = "txtbTelefono";
            this.txtbTelefono.Size = new System.Drawing.Size(195, 20);
            this.txtbTelefono.TabIndex = 44;
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(84, 176);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(195, 20);
            this.txtbEmail.TabIndex = 43;
            // 
            // txtbEdad
            // 
            this.txtbEdad.Location = new System.Drawing.Point(84, 150);
            this.txtbEdad.Name = "txtbEdad";
            this.txtbEdad.Size = new System.Drawing.Size(195, 20);
            this.txtbEdad.TabIndex = 42;
            // 
            // txtbSexo
            // 
            this.txtbSexo.Location = new System.Drawing.Point(84, 113);
            this.txtbSexo.Name = "txtbSexo";
            this.txtbSexo.Size = new System.Drawing.Size(195, 20);
            this.txtbSexo.TabIndex = 41;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(84, 84);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(195, 20);
            this.txtbNombre.TabIndex = 40;
            // 
            // txtbApellido
            // 
            this.txtbApellido.Location = new System.Drawing.Point(84, 59);
            this.txtbApellido.Name = "txtbApellido";
            this.txtbApellido.Size = new System.Drawing.Size(195, 20);
            this.txtbApellido.TabIndex = 39;
            // 
            // txtbDNI
            // 
            this.txtbDNI.Location = new System.Drawing.Point(84, 33);
            this.txtbDNI.Name = "txtbDNI";
            this.txtbDNI.Size = new System.Drawing.Size(195, 20);
            this.txtbDNI.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Estado";
            // 
            // lbCodigoPostal
            // 
            this.lbCodigoPostal.AutoSize = true;
            this.lbCodigoPostal.Location = new System.Drawing.Point(6, 308);
            this.lbCodigoPostal.Name = "lbCodigoPostal";
            this.lbCodigoPostal.Size = new System.Drawing.Size(72, 13);
            this.lbCodigoPostal.TabIndex = 36;
            this.lbCodigoPostal.Text = "Codigo Postal";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(6, 282);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(52, 13);
            this.lbDireccion.TabIndex = 35;
            this.lbDireccion.Text = "Dirección";
            // 
            // lbProvincia
            // 
            this.lbProvincia.AutoSize = true;
            this.lbProvincia.Location = new System.Drawing.Point(6, 258);
            this.lbProvincia.Name = "lbProvincia";
            this.lbProvincia.Size = new System.Drawing.Size(51, 13);
            this.lbProvincia.TabIndex = 34;
            this.lbProvincia.Text = "Provincia";
            // 
            // lbPais
            // 
            this.lbPais.AutoSize = true;
            this.lbPais.Location = new System.Drawing.Point(6, 229);
            this.lbPais.Name = "lbPais";
            this.lbPais.Size = new System.Drawing.Size(27, 13);
            this.lbPais.TabIndex = 33;
            this.lbPais.Text = "Pais";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(6, 202);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(49, 13);
            this.lbTelefono.TabIndex = 32;
            this.lbTelefono.Text = "Telefono";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(6, 183);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 31;
            this.lbEmail.Text = "Email";
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Location = new System.Drawing.Point(6, 153);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(32, 13);
            this.lbEdad.TabIndex = 30;
            this.lbEdad.Text = "Edad";
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Location = new System.Drawing.Point(6, 120);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(31, 13);
            this.lbSexo.TabIndex = 29;
            this.lbSexo.Text = "Sexo";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(6, 87);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 28;
            this.lbNombre.Text = "Nombre";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(6, 62);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(44, 13);
            this.lbApellido.TabIndex = 27;
            this.lbApellido.Text = "Apellido";
            // 
            // lbDNI
            // 
            this.lbDNI.AutoSize = true;
            this.lbDNI.Location = new System.Drawing.Point(6, 36);
            this.lbDNI.Name = "lbDNI";
            this.lbDNI.Size = new System.Drawing.Size(26, 13);
            this.lbDNI.TabIndex = 26;
            this.lbDNI.Text = "DNI";
            // 
            // RbUsuarioInactivo
            // 
            this.RbUsuarioInactivo.AutoSize = true;
            this.RbUsuarioInactivo.Location = new System.Drawing.Point(184, 335);
            this.RbUsuarioInactivo.Name = "RbUsuarioInactivo";
            this.RbUsuarioInactivo.Size = new System.Drawing.Size(102, 17);
            this.RbUsuarioInactivo.TabIndex = 17;
            this.RbUsuarioInactivo.Text = "Usuario Inactivo";
            this.RbUsuarioInactivo.UseVisualStyleBackColor = true;
            this.RbUsuarioInactivo.CheckedChanged += new System.EventHandler(this.RbGrupoInactivo_CheckedChanged);
            // 
            // rbEstadoActivo
            // 
            this.rbEstadoActivo.AutoSize = true;
            this.rbEstadoActivo.Location = new System.Drawing.Point(84, 335);
            this.rbEstadoActivo.Name = "rbEstadoActivo";
            this.rbEstadoActivo.Size = new System.Drawing.Size(97, 17);
            this.rbEstadoActivo.TabIndex = 16;
            this.rbEstadoActivo.Text = "Usuario  Activo";
            this.rbEstadoActivo.UseVisualStyleBackColor = true;
            this.rbEstadoActivo.CheckedChanged += new System.EventHandler(this.RbEstadoActivo_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(557, 424);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 34);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(476, 424);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(75, 34);
            this.btnGuardarCambios.TabIndex = 14;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.BtnGuardarCambios_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(395, 424);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 34);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(314, 424);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 34);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // btnSalirGestioGrupo
            // 
            this.btnSalirGestioGrupo.Location = new System.Drawing.Point(717, 534);
            this.btnSalirGestioGrupo.Name = "btnSalirGestioGrupo";
            this.btnSalirGestioGrupo.Size = new System.Drawing.Size(75, 23);
            this.btnSalirGestioGrupo.TabIndex = 12;
            this.btnSalirGestioGrupo.Text = "Salir";
            this.btnSalirGestioGrupo.UseVisualStyleBackColor = true;
            this.btnSalirGestioGrupo.Click += new System.EventHandler(this.BtnSalirGestioGrupo_Click);
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // FrmGestion_de_Usuarios_de_Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 560);
            this.Controls.Add(this.tabFrmGestionDeUsuarios);
            this.Controls.Add(this.btnSalirGestioGrupo);
            this.Name = "FrmGestion_de_Usuarios_de_Empresa";
            this.Text = "Gestion de Usuarios de Empresa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Gestion_de_Usuarios_Load);
            this.tabFrmGestionDeUsuarios.ResumeLayout(false);
            this.tabUsuarios.ResumeLayout(false);
            this.tabUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGrillaUsuarios)).EndInit();
            this.tabGestionDeUsuarios.ResumeLayout(false);
            this.groupB1.ResumeLayout(false);
            this.groupB1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabFrmGestionDeUsuarios;
        private System.Windows.Forms.TabPage tabUsuarios;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.RadioButton rbFiltrarPoNombre;
        private System.Windows.Forms.RadioButton rbfiltrarPorEstado;
        private System.Windows.Forms.Label lbnumeroDeRegistros;
        private System.Windows.Forms.Label lbCantidadDeRegistros;
        private System.Windows.Forms.Label lbNombreDelGrupo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.CheckBox chkbEliminar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView DgvGrillaUsuarios;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.ComboBox cmbEstadoUsuario;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.TextBox txtbBuscarUsuarioPorDNI;
        private System.Windows.Forms.TabPage tabGestionDeUsuarios;
        private System.Windows.Forms.GroupBox groupB1;
        private System.Windows.Forms.RadioButton RbUsuarioInactivo;
        private System.Windows.Forms.RadioButton rbEstadoActivo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalirGestioGrupo;
        private System.Windows.Forms.TextBox txtbCodigoPostal;
        private System.Windows.Forms.TextBox txtbDireccion;
        private System.Windows.Forms.TextBox txtbProvincia;
        private System.Windows.Forms.TextBox txtbPais;
        private System.Windows.Forms.TextBox txtbTelefono;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.TextBox txtbEdad;
        private System.Windows.Forms.TextBox txtbSexo;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtbApellido;
        private System.Windows.Forms.TextBox txtbDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCodigoPostal;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbProvincia;
        private System.Windows.Forms.Label lbPais;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbDNI;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.ToolTip ttMensajeAyuda;
    }
}