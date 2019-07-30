namespace Vista
{
    partial class IniciarSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarSesion));
            this.LBUSUARIO = new System.Windows.Forms.Label();
            this.LBPASSword = new System.Windows.Forms.Label();
            this.ErrorIcon = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensajeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.txtbUsuario = new System.Windows.Forms.TextBox();
            this.txtbContraseña = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.chkBoxMostrarContraseña = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRecuperarContraseña = new System.Windows.Forms.Button();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBUSUARIO
            // 
            resources.ApplyResources(this.LBUSUARIO, "LBUSUARIO");
            this.LBUSUARIO.Name = "LBUSUARIO";
            // 
            // LBPASSword
            // 
            resources.ApplyResources(this.LBPASSword, "LBPASSword");
            this.LBPASSword.Name = "LBPASSword";
            // 
            // ErrorIcon
            // 
            this.ErrorIcon.ContainerControl = this;
            // 
            // txtbUsuario
            // 
            resources.ApplyResources(this.txtbUsuario, "txtbUsuario");
            this.txtbUsuario.Name = "txtbUsuario";
            this.ttMensajeAyuda.SetToolTip(this.txtbUsuario, resources.GetString("txtbUsuario.ToolTip"));
            // 
            // txtbContraseña
            // 
            resources.ApplyResources(this.txtbContraseña, "txtbContraseña");
            this.txtbContraseña.Name = "txtbContraseña";
            this.ttMensajeAyuda.SetToolTip(this.txtbContraseña, resources.GetString("txtbContraseña.ToolTip"));
            // 
            // btnAceptar
            // 
            resources.ApplyResources(this.btnAceptar, "btnAceptar");
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnCancelar
            // 
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // chkBoxMostrarContraseña
            // 
            resources.ApplyResources(this.chkBoxMostrarContraseña, "chkBoxMostrarContraseña");
            this.chkBoxMostrarContraseña.Name = "chkBoxMostrarContraseña";
            this.chkBoxMostrarContraseña.UseVisualStyleBackColor = true;
            this.chkBoxMostrarContraseña.CheckedChanged += new System.EventHandler(this.ChkBoxMostrarContraseña_CheckedChanged);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnRecuperarContraseña
            // 
            resources.ApplyResources(this.btnRecuperarContraseña, "btnRecuperarContraseña");
            this.btnRecuperarContraseña.Name = "btnRecuperarContraseña";
            this.btnRecuperarContraseña.UseVisualStyleBackColor = true;
            this.btnRecuperarContraseña.Click += new System.EventHandler(this.BtnRecuperarContraseña_Click);
            // 
            // btnCambiarContraseña
            // 
            resources.ApplyResources(this.btnCambiarContraseña, "btnCambiarContraseña");
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.UseVisualStyleBackColor = true;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.BtnCambiarContraseña_Click);
            // 
            // IniciarSesion
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnCambiarContraseña);
            this.Controls.Add(this.btnRecuperarContraseña);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkBoxMostrarContraseña);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtbContraseña);
            this.Controls.Add(this.txtbUsuario);
            this.Controls.Add(this.LBPASSword);
            this.Controls.Add(this.LBUSUARIO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "IniciarSesion";
            this.Opacity = 0.6D;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBUSUARIO;
        private System.Windows.Forms.Label LBPASSword;
        private System.Windows.Forms.ErrorProvider ErrorIcon;
        private System.Windows.Forms.TextBox txtbContraseña;
        private System.Windows.Forms.TextBox txtbUsuario;
        private System.Windows.Forms.ToolTip ttMensajeAyuda;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.CheckBox chkBoxMostrarContraseña;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCambiarContraseña;
        private System.Windows.Forms.Button btnRecuperarContraseña;
    }
}

