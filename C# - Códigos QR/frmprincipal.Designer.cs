namespace c_sahrp
{
    partial class frmprincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbgenerar = new System.Windows.Forms.PictureBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.pbmostrararchivo = new System.Windows.Forms.PictureBox();
            this.btnabrir = new System.Windows.Forms.Button();
            this.pnseparacion = new System.Windows.Forms.Panel();
            this.txtmostrar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbgenerar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmostrararchivo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(12, 54);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(520, 38);
            this.txtnombre.TabIndex = 1;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto:";
            // 
            // pbgenerar
            // 
            this.pbgenerar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbgenerar.Location = new System.Drawing.Point(12, 107);
            this.pbgenerar.Name = "pbgenerar";
            this.pbgenerar.Size = new System.Drawing.Size(255, 255);
            this.pbgenerar.TabIndex = 3;
            this.pbgenerar.TabStop = false;
            // 
            // btnguardar
            // 
            this.btnguardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnguardar.Location = new System.Drawing.Point(273, 107);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(259, 82);
            this.btnguardar.TabIndex = 4;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // pbmostrararchivo
            // 
            this.pbmostrararchivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbmostrararchivo.Location = new System.Drawing.Point(624, 107);
            this.pbmostrararchivo.Name = "pbmostrararchivo";
            this.pbmostrararchivo.Size = new System.Drawing.Size(255, 255);
            this.pbmostrararchivo.TabIndex = 5;
            this.pbmostrararchivo.TabStop = false;
            // 
            // btnabrir
            // 
            this.btnabrir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnabrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnabrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnabrir.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnabrir.Location = new System.Drawing.Point(624, 38);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(255, 54);
            this.btnabrir.TabIndex = 6;
            this.btnabrir.Text = "Abrir archivo";
            this.btnabrir.UseVisualStyleBackColor = true;
            this.btnabrir.Click += new System.EventHandler(this.btnabrir_Click);
            // 
            // pnseparacion
            // 
            this.pnseparacion.BackColor = System.Drawing.SystemColors.ControlText;
            this.pnseparacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnseparacion.Location = new System.Drawing.Point(571, 14);
            this.pnseparacion.Name = "pnseparacion";
            this.pnseparacion.Size = new System.Drawing.Size(10, 400);
            this.pnseparacion.TabIndex = 7;
            // 
            // txtmostrar
            // 
            this.txtmostrar.Location = new System.Drawing.Point(624, 376);
            this.txtmostrar.Name = "txtmostrar";
            this.txtmostrar.ReadOnly = true;
            this.txtmostrar.Size = new System.Drawing.Size(255, 38);
            this.txtmostrar.TabIndex = 8;
            // 
            // frmprincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(891, 426);
            this.Controls.Add(this.txtmostrar);
            this.Controls.Add(this.pnseparacion);
            this.Controls.Add(this.btnabrir);
            this.Controls.Add(this.pbmostrararchivo);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.pbgenerar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnombre);
            this.Font = new System.Drawing.Font("Railway", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar y mostrar códigos qr";
            ((System.ComponentModel.ISupportInitialize)(this.pbgenerar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmostrararchivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbgenerar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.PictureBox pbmostrararchivo;
        private System.Windows.Forms.Button btnabrir;
        private System.Windows.Forms.Panel pnseparacion;
        private System.Windows.Forms.TextBox txtmostrar;
    }
}
