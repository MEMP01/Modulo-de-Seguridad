namespace Vista
{
    partial class Auditoria
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
            this.dgvauditoria = new System.Windows.Forms.DataGridView();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.CalendarioInicio = new System.Windows.Forms.MonthCalendar();
            this.CalendarioFin = new System.Windows.Forms.MonthCalendar();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvauditoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvauditoria
            // 
            this.dgvauditoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvauditoria.Location = new System.Drawing.Point(44, 212);
            this.dgvauditoria.Name = "dgvauditoria";
            this.dgvauditoria.Size = new System.Drawing.Size(784, 346);
            this.dgvauditoria.TabIndex = 0;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(560, 33);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(237, 23);
            this.btnFiltrar.TabIndex = 1;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // CalendarioInicio
            // 
            this.CalendarioInicio.Location = new System.Drawing.Point(13, 33);
            this.CalendarioInicio.Name = "CalendarioInicio";
            this.CalendarioInicio.TabIndex = 2;
            // 
            // CalendarioFin
            // 
            this.CalendarioFin.Location = new System.Drawing.Point(279, 33);
            this.CalendarioFin.Name = "CalendarioFin";
            this.CalendarioFin.TabIndex = 3;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(560, 564);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(237, 23);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(560, 168);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(237, 27);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(560, 62);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(237, 27);
            this.btnListar.TabIndex = 6;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // Auditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 599);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.CalendarioFin);
            this.Controls.Add(this.CalendarioInicio);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dgvauditoria);
            this.Name = "Auditoria";
            this.Text = "Auditoria";
            this.Load += new System.EventHandler(this.Auditoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvauditoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvauditoria;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.MonthCalendar CalendarioInicio;
        private System.Windows.Forms.MonthCalendar CalendarioFin;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnListar;
    }
}