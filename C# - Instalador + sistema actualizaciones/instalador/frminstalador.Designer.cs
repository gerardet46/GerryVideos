namespace instalador
{
    partial class frminstalador
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbaceptar = new System.Windows.Forms.RadioButton();
            this.rbnoacepto = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtmenuinicio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btncarpeta = new System.Windows.Forms.Button();
            this.txtruta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rtbprogreso = new System.Windows.Forms.RichTextBox();
            this.lbprogreso = new System.Windows.Forms.Label();
            this.pbinstalacion = new System.Windows.Forms.ProgressBar();
            this.pnbotones = new System.Windows.Forms.Panel();
            this.btnatras = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.lbversion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnbotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbversion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 537);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(9, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(803, 65);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sigue los pasos para instalar el programa";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(11, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(803, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido al instalador de msgapp!!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbaceptar);
            this.panel2.Controls.Add(this.rbnoacepto);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 537);
            this.panel2.TabIndex = 0;
            // 
            // rbaceptar
            // 
            this.rbaceptar.AutoSize = true;
            this.rbaceptar.Location = new System.Drawing.Point(24, 341);
            this.rbaceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbaceptar.Name = "rbaceptar";
            this.rbaceptar.Size = new System.Drawing.Size(73, 21);
            this.rbaceptar.TabIndex = 3;
            this.rbaceptar.Text = "Acepto";
            this.rbaceptar.UseVisualStyleBackColor = true;
            // 
            // rbnoacepto
            // 
            this.rbnoacepto.AutoSize = true;
            this.rbnoacepto.Checked = true;
            this.rbnoacepto.Location = new System.Drawing.Point(24, 314);
            this.rbnoacepto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnoacepto.Name = "rbnoacepto";
            this.rbnoacepto.Size = new System.Drawing.Size(94, 21);
            this.rbnoacepto.TabIndex = 2;
            this.rbnoacepto.TabStop = true;
            this.rbnoacepto.Text = "No acepto";
            this.rbnoacepto.UseVisualStyleBackColor = true;
            this.rbnoacepto.CheckedChanged += new System.EventHandler(this.rbnoacepto_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.richTextBox1.Location = new System.Drawing.Point(24, 70);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(679, 230);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Haz lo que quieras con el programa.\n\nYa sería el colmo no aceptar esta licencia.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(20, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lee y acepta la licencia";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtmenuinicio);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btncarpeta);
            this.panel3.Controls.Add(this.txtruta);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(824, 537);
            this.panel3.TabIndex = 0;
            // 
            // txtmenuinicio
            // 
            this.txtmenuinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtmenuinicio.Location = new System.Drawing.Point(29, 211);
            this.txtmenuinicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmenuinicio.Name = "txtmenuinicio";
            this.txtmenuinicio.Size = new System.Drawing.Size(494, 23);
            this.txtmenuinicio.TabIndex = 4;
            this.txtmenuinicio.Text = "msgapp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(25, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Añadir al menú de inicio";
            // 
            // btncarpeta
            // 
            this.btncarpeta.Location = new System.Drawing.Point(539, 73);
            this.btncarpeta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncarpeta.Name = "btncarpeta";
            this.btncarpeta.Size = new System.Drawing.Size(138, 21);
            this.btncarpeta.TabIndex = 2;
            this.btncarpeta.Text = "Seleccionar carpeta";
            this.btncarpeta.UseVisualStyleBackColor = true;
            this.btncarpeta.Click += new System.EventHandler(this.btncarpeta_Click);
            // 
            // txtruta
            // 
            this.txtruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtruta.Location = new System.Drawing.Point(28, 73);
            this.txtruta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtruta.Name = "txtruta";
            this.txtruta.Size = new System.Drawing.Size(494, 23);
            this.txtruta.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(25, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Selecciona la ruta de instalción";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(824, 537);
            this.panel4.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(248, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Listo para instalar!";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rtbprogreso);
            this.panel5.Controls.Add(this.lbprogreso);
            this.panel5.Controls.Add(this.pbinstalacion);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(824, 537);
            this.panel5.TabIndex = 0;
            // 
            // rtbprogreso
            // 
            this.rtbprogreso.Location = new System.Drawing.Point(36, 151);
            this.rtbprogreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbprogreso.Name = "rtbprogreso";
            this.rtbprogreso.ReadOnly = true;
            this.rtbprogreso.Size = new System.Drawing.Size(751, 288);
            this.rtbprogreso.TabIndex = 2;
            this.rtbprogreso.Text = "";
            // 
            // lbprogreso
            // 
            this.lbprogreso.AutoSize = true;
            this.lbprogreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbprogreso.Location = new System.Drawing.Point(32, 44);
            this.lbprogreso.Name = "lbprogreso";
            this.lbprogreso.Size = new System.Drawing.Size(53, 20);
            this.lbprogreso.TabIndex = 1;
            this.lbprogreso.Text = "label7";
            // 
            // pbinstalacion
            // 
            this.pbinstalacion.Location = new System.Drawing.Point(36, 72);
            this.pbinstalacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbinstalacion.Maximum = 140;
            this.pbinstalacion.Name = "pbinstalacion";
            this.pbinstalacion.Size = new System.Drawing.Size(750, 41);
            this.pbinstalacion.TabIndex = 0;
            // 
            // pnbotones
            // 
            this.pnbotones.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnbotones.Controls.Add(this.btnatras);
            this.pnbotones.Controls.Add(this.btnsiguiente);
            this.pnbotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnbotones.Location = new System.Drawing.Point(0, 469);
            this.pnbotones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnbotones.Name = "pnbotones";
            this.pnbotones.Size = new System.Drawing.Size(824, 68);
            this.pnbotones.TabIndex = 1;
            // 
            // btnatras
            // 
            this.btnatras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnatras.Location = new System.Drawing.Point(496, 15);
            this.btnatras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(149, 42);
            this.btnatras.TabIndex = 1;
            this.btnatras.Text = "&Atrás";
            this.btnatras.UseVisualStyleBackColor = true;
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsiguiente.Location = new System.Drawing.Point(663, 16);
            this.btnsiguiente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(149, 42);
            this.btnsiguiente.TabIndex = 0;
            this.btnsiguiente.Text = "Siguiente";
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // lbversion
            // 
            this.lbversion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbversion.Location = new System.Drawing.Point(9, 181);
            this.lbversion.Name = "lbversion";
            this.lbversion.Size = new System.Drawing.Size(803, 65);
            this.lbversion.TabIndex = 2;
            this.lbversion.Text = "Detectando última versión...";
            this.lbversion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 537);
            this.Controls.Add(this.pnbotones);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instalación msgapp";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnbotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;

        private System.Windows.Forms.Panel pnbotones;
        private System.Windows.Forms.Button btnatras;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbaceptar;
        private System.Windows.Forms.RadioButton rbnoacepto;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncarpeta;
        private System.Windows.Forms.TextBox txtruta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmenuinicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbprogreso;
        private System.Windows.Forms.Label lbprogreso;
        private System.Windows.Forms.ProgressBar pbinstalacion;
        private System.Windows.Forms.Label lbversion;
    }
}
