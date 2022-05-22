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
            this.lbcoincide = new System.Windows.Forms.Label();
            this.txttexto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbcoincide
            // 
            this.lbcoincide.AutoSize = true;
            this.lbcoincide.Font = new System.Drawing.Font("Railway", 30F);
            this.lbcoincide.Location = new System.Drawing.Point(67, 157);
            this.lbcoincide.Name = "lbcoincide";
            this.lbcoincide.Size = new System.Drawing.Size(226, 64);
            this.lbcoincide.TabIndex = 0;
            this.lbcoincide.Text = "Correcto";
            // 
            // txttexto
            // 
            this.txttexto.Font = new System.Drawing.Font("Railway", 24F);
            this.txttexto.Location = new System.Drawing.Point(78, 51);
            this.txttexto.Name = "txttexto";
            this.txttexto.Size = new System.Drawing.Size(752, 59);
            this.txttexto.TabIndex = 1;
            this.txttexto.TextChanged += new System.EventHandler(this.txttexto_TextChanged);
            // 
            // frmprincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(918, 253);
            this.Controls.Add(this.txttexto);
            this.Controls.Add(this.lbcoincide);
            this.Font = new System.Drawing.Font("Railway", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expresiones regulares";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label lbcoincide;
        private System.Windows.Forms.TextBox txttexto;
    }
}
