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
            this.txtserial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncomprar = new System.Windows.Forms.Button();
            this.txtcomprar = new System.Windows.Forms.TextBox();
            this.lbestado = new System.Windows.Forms.Label();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtserial
            // 
            this.txtserial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtserial.Location = new System.Drawing.Point(18, 59);
            this.txtserial.Name = "txtserial";
            this.txtserial.Size = new System.Drawing.Size(897, 38);
            this.txtserial.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Licencia: (xxxxx-xxxxx-xxxxx-xxxxx-xxxxx)";
            // 
            // btncomprar
            // 
            this.btncomprar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btncomprar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btncomprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncomprar.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btncomprar.Location = new System.Drawing.Point(18, 118);
            this.btncomprar.Name = "btncomprar";
            this.btncomprar.Size = new System.Drawing.Size(429, 95);
            this.btncomprar.TabIndex = 2;
            this.btncomprar.Text = "&Comprar licencia";
            this.btncomprar.UseVisualStyleBackColor = true;
            this.btncomprar.Click += new System.EventHandler(this.btncomprar_Click);
            // 
            // txtcomprar
            // 
            this.txtcomprar.Location = new System.Drawing.Point(12, 268);
            this.txtcomprar.Name = "txtcomprar";
            this.txtcomprar.ReadOnly = true;
            this.txtcomprar.Size = new System.Drawing.Size(897, 38);
            this.txtcomprar.TabIndex = 4;
            // 
            // lbestado
            // 
            this.lbestado.AutoSize = true;
            this.lbestado.Location = new System.Drawing.Point(12, 234);
            this.lbestado.Name = "lbestado";
            this.lbestado.Size = new System.Drawing.Size(192, 31);
            this.lbestado.TabIndex = 6;
            this.lbestado.Text = "Esperando acción";
            // 
            // btnaceptar
            // 
            this.btnaceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnaceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaceptar.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnaceptar.Location = new System.Drawing.Point(468, 118);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(447, 95);
            this.btnaceptar.TabIndex = 1;
            this.btnaceptar.Text = "&Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // frmprincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(927, 339);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.lbestado);
            this.Controls.Add(this.txtcomprar);
            this.Controls.Add(this.btncomprar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtserial);
            this.Font = new System.Drawing.Font("Railway", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Licencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.TextBox txtserial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncomprar;
        private System.Windows.Forms.TextBox txtcomprar;
        private System.Windows.Forms.Label lbestado;
        private System.Windows.Forms.Button btnaceptar;
    }
}
