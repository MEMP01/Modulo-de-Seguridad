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
            ((System.ComponentModel.ISupportInitialize)(this.dgvauditoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvauditoria
            // 
            this.dgvauditoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvauditoria.Location = new System.Drawing.Point(13, 207);
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
            // Auditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 568);
            this.Controls.Add(this.CalendarioFin);
            this.Controls.Add(this.CalendarioInicio);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dgvauditoria);
            this.Name = "Auditoria";
            this.Text = "Auditoria";
            ((System.ComponentModel.ISupportInitialize)(this.dgvauditoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvauditoria;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.MonthCalendar CalendarioInicio;
        private System.Windows.Forms.MonthCalendar CalendarioFin;
    }
}