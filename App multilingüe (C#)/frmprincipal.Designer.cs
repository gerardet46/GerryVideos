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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.idiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.españolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalàToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irAlOtroFormularioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbnombre = new System.Windows.Forms.Label();
            this.lbedad = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnfinaliza = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idiomaToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(691, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // idiomaToolStripMenuItem
            // 
            this.idiomaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.españolToolStripMenuItem,
            this.catalàToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.idiomaToolStripMenuItem.Name = "idiomaToolStripMenuItem";
            this.idiomaToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.idiomaToolStripMenuItem.Text = "Lengua";
            // 
            // españolToolStripMenuItem
            // 
            this.españolToolStripMenuItem.Name = "españolToolStripMenuItem";
            this.españolToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.españolToolStripMenuItem.Text = "&Español";
            this.españolToolStripMenuItem.Click += new System.EventHandler(this.españolToolStripMenuItem_Click);
            // 
            // catalàToolStripMenuItem
            // 
            this.catalàToolStripMenuItem.Name = "catalàToolStripMenuItem";
            this.catalàToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.catalàToolStripMenuItem.Text = "&Català";
            this.catalàToolStripMenuItem.Click += new System.EventHandler(this.catalàToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.englishToolStripMenuItem.Text = "&English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarProgramaToolStripMenuItem,
            this.irAlOtroFormularioToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // cerrarProgramaToolStripMenuItem
            // 
            this.cerrarProgramaToolStripMenuItem.Name = "cerrarProgramaToolStripMenuItem";
            this.cerrarProgramaToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.cerrarProgramaToolStripMenuItem.Text = "Cerrar programa";
            this.cerrarProgramaToolStripMenuItem.Click += new System.EventHandler(this.cerrarProgramaToolStripMenuItem_Click);
            // 
            // irAlOtroFormularioToolStripMenuItem
            // 
            this.irAlOtroFormularioToolStripMenuItem.Name = "irAlOtroFormularioToolStripMenuItem";
            this.irAlOtroFormularioToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.irAlOtroFormularioToolStripMenuItem.Text = "Ir al otro formulario";
            this.irAlOtroFormularioToolStripMenuItem.Click += new System.EventHandler(this.irAlOtroFormularioToolStripMenuItem_Click);
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Location = new System.Drawing.Point(32, 58);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(173, 46);
            this.lbnombre.TabIndex = 1;
            this.lbnombre.Text = "Nombre:";
            // 
            // lbedad
            // 
            this.lbedad.AutoSize = true;
            this.lbedad.Location = new System.Drawing.Point(81, 139);
            this.lbedad.Name = "lbedad";
            this.lbedad.Size = new System.Drawing.Size(124, 46);
            this.lbedad.TabIndex = 2;
            this.lbedad.Text = "Edad:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(242, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(325, 53);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(242, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(325, 53);
            this.textBox2.TabIndex = 4;
            // 
            // btnfinaliza
            // 
            this.btnfinaliza.Location = new System.Drawing.Point(242, 236);
            this.btnfinaliza.Name = "btnfinaliza";
            this.btnfinaliza.Size = new System.Drawing.Size(325, 60);
            this.btnfinaliza.TabIndex = 5;
            this.btnfinaliza.Text = "Hecho";
            this.btnfinaliza.UseVisualStyleBackColor = true;
            // 
            // frmprincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(691, 354);
            this.Controls.Add(this.btnfinaliza);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbedad);
            this.Controls.Add(this.lbnombre);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio de idioma";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem idiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem españolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalàToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarProgramaToolStripMenuItem;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Label lbedad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnfinaliza;
        private System.Windows.Forms.ToolStripMenuItem irAlOtroFormularioToolStripMenuItem;
    }
}
