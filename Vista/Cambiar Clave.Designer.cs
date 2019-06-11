namespace Vista
{
    partial class FrmCambiar_Clave
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
            this.lbContraseñaActual = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbNuevaContraseña = new System.Windows.Forms.Label();
            this.lbConfirmarContraseña = new System.Windows.Forms.Label();
            this.ErrorIcon = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtbContraseñaActual = new System.Windows.Forms.TextBox();
            this.txtbNuevaContraseña = new System.Windows.Forms.TextBox();
            this.txtbConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.ChkBMostrarContraseña = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbContraseñaActual
            // 
            this.lbContraseñaActual.AutoSize = true;
            this.lbContraseñaActual.Location = new System.Drawing.Point(10, 16);
            this.lbContraseñaActual.Name = "lbContraseñaActual";
            this.lbContraseñaActual.Size = new System.Drawing.Size(94, 13);
            this.lbContraseñaActual.TabIndex = 0;
            this.lbContraseñaActual.Text = "Contraseña Actual";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(371, 254);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(523, 254);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lbNuevaContraseña
            // 
            this.lbNuevaContraseña.AutoSize = true;
            this.lbNuevaContraseña.Location = new System.Drawing.Point(10, 56);
            this.lbNuevaContraseña.Name = "lbNuevaContraseña";
            this.lbNuevaContraseña.Size = new System.Drawing.Size(96, 13);
            this.lbNuevaContraseña.TabIndex = 3;
            this.lbNuevaContraseña.Text = "Nueva Contraseña";
            // 
            // lbConfirmarContraseña
            // 
            this.lbConfirmarContraseña.AutoSize = true;
            this.lbConfirmarContraseña.Location = new System.Drawing.Point(12, 97);
            this.lbConfirmarContraseña.Name = "lbConfirmarContraseña";
            this.lbConfirmarContraseña.Size = new System.Drawing.Size(108, 13);
            this.lbConfirmarContraseña.TabIndex = 4;
            this.lbConfirmarContraseña.Text = "Confirmar Contraseña";
            // 
            // ErrorIcon
            // 
            this.ErrorIcon.ContainerControl = this;
            // 
            // txtbContraseñaActual
            // 
            this.txtbContraseñaActual.Location = new System.Drawing.Point(146, 9);
            this.txtbContraseñaActual.Name = "txtbContraseñaActual";
            this.txtbContraseñaActual.Size = new System.Drawing.Size(452, 20);
            this.txtbContraseñaActual.TabIndex = 5;
            // 
            // txtbNuevaContraseña
            // 
            this.txtbNuevaContraseña.Location = new System.Drawing.Point(146, 49);
            this.txtbNuevaContraseña.Name = "txtbNuevaContraseña";
            this.txtbNuevaContraseña.Size = new System.Drawing.Size(452, 20);
            this.txtbNuevaContraseña.TabIndex = 6;
            // 
            // txtbConfirmarContraseña
            // 
            this.txtbConfirmarContraseña.Location = new System.Drawing.Point(146, 90);
            this.txtbConfirmarContraseña.Name = "txtbConfirmarContraseña";
            this.txtbConfirmarContraseña.Size = new System.Drawing.Size(452, 20);
            this.txtbConfirmarContraseña.TabIndex = 7;
            // 
            // ChkBMostrarContraseña
            // 
            this.ChkBMostrarContraseña.AutoSize = true;
            this.ChkBMostrarContraseña.Location = new System.Drawing.Point(146, 133);
            this.ChkBMostrarContraseña.Name = "ChkBMostrarContraseña";
            this.ChkBMostrarContraseña.Size = new System.Drawing.Size(118, 17);
            this.ChkBMostrarContraseña.TabIndex = 8;
            this.ChkBMostrarContraseña.Text = "Mostrar Contraseña";
            this.ChkBMostrarContraseña.UseVisualStyleBackColor = true;
            // 
            // FrmCambiar_Clave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 288);
            this.Controls.Add(this.ChkBMostrarContraseña);
            this.Controls.Add(this.txtbConfirmarContraseña);
            this.Controls.Add(this.txtbNuevaContraseña);
            this.Controls.Add(this.txtbContraseñaActual);
            this.Controls.Add(this.lbConfirmarContraseña);
            this.Controls.Add(this.lbNuevaContraseña);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lbContraseñaActual);
            this.Name = "FrmCambiar_Clave";
            this.Text = "Cambiar Clave";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbContraseñaActual;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbNuevaContraseña;
        private System.Windows.Forms.Label lbConfirmarContraseña;
        private System.Windows.Forms.ErrorProvider ErrorIcon;
        private System.Windows.Forms.CheckBox ChkBMostrarContraseña;
        private System.Windows.Forms.TextBox txtbConfirmarContraseña;
        private System.Windows.Forms.TextBox txtbNuevaContraseña;
        private System.Windows.Forms.TextBox txtbContraseñaActual;
    }
}