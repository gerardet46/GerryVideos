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
            this.cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.lbid = new System.Windows.Forms.Label();
            this.lbprecio = new System.Windows.Forms.Label();
            this.lbcolor = new System.Windows.Forms.Label();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb
            // 
            this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(18, 68);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(515, 37);
            this.cb.TabIndex = 0;
            this.cb.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.lbid);
            this.gb1.Controls.Add(this.lbprecio);
            this.gb1.Controls.Add(this.lbcolor);
            this.gb1.Location = new System.Drawing.Point(18, 129);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(515, 197);
            this.gb1.TabIndex = 3;
            this.gb1.TabStop = false;
            this.gb1.Text = "Información de la planta:";
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(15, 50);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(38, 31);
            this.lbid.TabIndex = 2;
            this.lbid.Text = "Id:";
            // 
            // lbprecio
            // 
            this.lbprecio.AutoSize = true;
            this.lbprecio.Location = new System.Drawing.Point(15, 148);
            this.lbprecio.Name = "lbprecio";
            this.lbprecio.Size = new System.Drawing.Size(83, 31);
            this.lbprecio.TabIndex = 1;
            this.lbprecio.Text = "Precio:";
            // 
            // lbcolor
            // 
            this.lbcolor.AutoSize = true;
            this.lbcolor.Location = new System.Drawing.Point(15, 99);
            this.lbcolor.Name = "lbcolor";
            this.lbcolor.Size = new System.Drawing.Size(85, 31);
            this.lbcolor.TabIndex = 0;
            this.lbcolor.Text = "Color: ";
            // 
            // frmprincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 345);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb);
            this.Font = new System.Drawing.Font("Railway", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL con imágenes";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Label lbprecio;
        private System.Windows.Forms.Label lbcolor;
        private System.Windows.Forms.Label lbid;
    }
}
